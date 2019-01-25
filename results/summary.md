# Benchmarks

Benchmark report generated on 25-jan-2019 16:37

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17763.253 (1809/October2018Update/Redstone5), VM=Hyper-V

Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores



## Important benchmarks

### High priority (current version slower than previous one)

10 item(s)

1. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v5.9.0 is **7,95%** (Δ: 296,710 ns) slower than v5.6.0

2. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.9.0 is **7,83%** (Δ: 2563,608 ns) slower than v5.6.0

3. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v5.9.0 is **3,87%** (Δ: 56903,597 ns) slower than v5.6.0

4. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.9.0 is **3,64%** (Δ: 46729,251 ns) slower than v5.6.0

5. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.9.0 is **3,19%** (Δ: 60845,685 ns) slower than v5.6.0

6. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.9.0 is **2,32%** (Δ: 15476,325 ns) slower than v5.6.0

7. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v5.9.0 is **1,84%** (Δ: 475298,767 ns) slower than v5.6.0

8. [Serialization_Binary_Benchmark::SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph) v5.9.0 is **1,75%** (Δ: 14812,517 ns) slower than v5.6.0

9. [Serialization_Json_Benchmark::SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models) v5.9.0 is **1,48%** (Δ: 304494,576 ns) slower than v5.6.0

10. [AssemblyExtensions_Benchmark::GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime) v5.9.0 is **1,06%** (Δ: 5937,630 ns) slower than v5.6.0



### Improved (current version faster than previous one)

9 item(s)

1. [TagHelper_Benchmark::ToString_](#TagHelper_Benchmark_ToString_) v5.9.0 is **94,07%** (Δ: -26687,818 ns) faster than v5.6.0

2. [ObjectToStringHelper_Benchmark::ToString_](#ObjectToStringHelper_Benchmark_ToString_) v5.9.0 is **87,52%** (Δ: -4271,762 ns) faster than v5.6.0

3. [Type_ReflectionExtensions_Benchmark::GetPropertiesEx_Instance](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance) v5.9.0 is **73,71%** (Δ: -2804,377 ns) faster than v5.6.0

4. [Type_ReflectionExtensions_Benchmark::GetPropertiesEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static) v5.9.0 is **60,39%** (Δ: -2659,533 ns) faster than v5.6.0

5. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance) v5.9.0 is **44,06%** (Δ: -5474,237 ns) faster than v5.6.0

6. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static) v5.9.0 is **42,63%** (Δ: -5613,852 ns) faster than v5.6.0

7. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.9.0 is **17,96%** (Δ: -2758,230 ns) faster than v5.6.0

8. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.9.0 is **17,19%** (Δ: -2657,057 ns) faster than v5.6.0

9. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type) v5.9.0 is **5,41%** (Δ: -279,066 ns) faster than v5.6.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 7,257 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">142,499 ns</td><td align="right" bgcolor="#FFFFFF">143,291 ns</td><td align="right" bgcolor="#FFFFFF">141,374 ns</td><td align="right" bgcolor="#FFFFFF">142,040 ns</td><td align="right" bgcolor="#FFFFFF">148,631 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 38,308 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">147,856 ns</td><td align="right" bgcolor="#FFFFFF">142,410 ns</td><td align="right" bgcolor="#FFFFFF">144,322 ns</td><td align="right" bgcolor="#FFFFFF">143,331 ns</td><td align="right" bgcolor="#FFFFFF">180,718 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 10,345 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">135,541 ns</td><td align="right" bgcolor="#FFFFFF">135,394 ns</td><td align="right" bgcolor="#FFFFFF">133,675 ns</td><td align="right" bgcolor="#FFFFFF">133,082 ns</td><td align="right" bgcolor="#FFFFFF">143,426 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 8,889 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,813 ns</td><td align="right" bgcolor="#FFFFFF">142,469 ns</td><td align="right" bgcolor="#FFFFFF">142,642 ns</td><td align="right" bgcolor="#FFFFFF">146,652 ns</td><td align="right" bgcolor="#FFFFFF">151,359 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 3,469 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,268 ns</td><td align="right" bgcolor="#FFFFFF">51,738 ns</td><td align="right" bgcolor="#FFFFFF">50,542 ns</td><td align="right" bgcolor="#FFFFFF">50,990 ns</td><td align="right" bgcolor="#FFFFFF">48,992 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 2,434 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58,941 ns</td><td align="right" bgcolor="#FFFFFF">56,506 ns</td><td align="right" bgcolor="#FFFFFF">56,916 ns</td><td align="right" bgcolor="#FFFFFF">56,925 ns</td><td align="right" bgcolor="#FFFFFF">56,867 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 4,617 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,048 ns</td><td align="right" bgcolor="#FFFFFF">54,625 ns</td><td align="right" bgcolor="#FFFFFF">55,311 ns</td><td align="right" bgcolor="#FFFFFF">56,239 ns</td><td align="right" bgcolor="#FFFFFF">59,242 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 50,409 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">992,025 ns</td><td align="right" bgcolor="#FFFFFF">1042,433 ns</td><td align="right" bgcolor="#FFFFFF">995,481 ns</td><td align="right" bgcolor="#FFFFFF">1001,603 ns</td><td align="right" bgcolor="#FFFFFF">1017,296 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,992 μs</td><td align="right" bgcolor="#FFFFFF">1,042 μs</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">1,002 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 3,356 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,995 ns</td><td align="right" bgcolor="#FFFFFF">20,859 ns</td><td align="right" bgcolor="#FFFFFF">21,492 ns</td><td align="right" bgcolor="#FFFFFF">23,076 ns</td><td align="right" bgcolor="#FFFFFF">23,351 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,872 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,343 ns</td><td align="right" bgcolor="#FFFFFF">23,471 ns</td><td align="right" bgcolor="#FFFFFF">25,006 ns</td><td align="right" bgcolor="#FFFFFF">25,274 ns</td><td align="right" bgcolor="#FFFFFF">24,571 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 0,442 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,660 ns</td><td align="right" bgcolor="#FFFFFF">6,655 ns</td><td align="right" bgcolor="#FFFFFF">6,642 ns</td><td align="right" bgcolor="#FFFFFF">6,218 ns</td><td align="right" bgcolor="#FFFFFF">6,266 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 27,102 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">758,217 ns</td><td align="right" bgcolor="#FFFFFF">731,115 ns</td><td align="right" bgcolor="#FFFFFF">740,522 ns</td><td align="right" bgcolor="#FFFFFF">737,337 ns</td><td align="right" bgcolor="#FFFFFF">758,157 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td><td align="right" bgcolor="#FFFFFF">0,731 μs</td><td align="right" bgcolor="#FFFFFF">0,741 μs</td><td align="right" bgcolor="#FFFFFF">0,737 μs</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 0,460 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,787 ns</td><td align="right" bgcolor="#FFFFFF">1,720 ns</td><td align="right" bgcolor="#FFFFFF">1,785 ns</td><td align="right" bgcolor="#FFFFFF">1,806 ns</td><td align="right" bgcolor="#FFFFFF">2,180 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 0,867 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,811 ns</td><td align="right" bgcolor="#FFFFFF">1,793 ns</td><td align="right" bgcolor="#FFFFFF">1,332 ns</td><td align="right" bgcolor="#FFFFFF">2,199 ns</td><td align="right" bgcolor="#FFFFFF">2,192 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,140 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,141 ns</td><td align="right" bgcolor="#FFFFFF">11,001 ns</td><td align="right" bgcolor="#FFFFFF">11,514 ns</td><td align="right" bgcolor="#FFFFFF">11,184 ns</td><td align="right" bgcolor="#FFFFFF">11,142 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 0,414 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,608 ns</td><td align="right" bgcolor="#FFFFFF">4,620 ns</td><td align="right" bgcolor="#FFFFFF">4,624 ns</td><td align="right" bgcolor="#FFFFFF">5,019 ns</td><td align="right" bgcolor="#FFFFFF">5,022 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 14,411 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,069 ns</td><td align="right" bgcolor="#FFFFFF">21,388 ns</td><td align="right" bgcolor="#FFFFFF">21,383 ns</td><td align="right" bgcolor="#FFFFFF">21,610 ns</td><td align="right" bgcolor="#FFFFFF">8,658 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 7,725 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,017 ns</td><td align="right" bgcolor="#FFFFFF">132,717 ns</td><td align="right" bgcolor="#FFFFFF">128,034 ns</td><td align="right" bgcolor="#FFFFFF">130,640 ns</td><td align="right" bgcolor="#FFFFFF">124,993 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 4,949 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">138,636 ns</td><td align="right" bgcolor="#FFFFFF">135,666 ns</td><td align="right" bgcolor="#FFFFFF">136,349 ns</td><td align="right" bgcolor="#FFFFFF">137,935 ns</td><td align="right" bgcolor="#FFFFFF">133,687 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 3,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">78,091 ns</td><td align="right" bgcolor="#FFFFFF">76,183 ns</td><td align="right" bgcolor="#FFFFFF">78,679 ns</td><td align="right" bgcolor="#FFFFFF">79,348 ns</td><td align="right" bgcolor="#FFFFFF">78,534 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 6,593 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">86,316 ns</td><td align="right" bgcolor="#FFFFFF">87,849 ns</td><td align="right" bgcolor="#FFFFFF">85,921 ns</td><td align="right" bgcolor="#FFFFFF">86,378 ns</td><td align="right" bgcolor="#FFFFFF">92,514 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 0,686 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,989 ns</td><td align="right" bgcolor="#FFFFFF">33,933 ns</td><td align="right" bgcolor="#FFFFFF">34,619 ns</td><td align="right" bgcolor="#FFFFFF">34,449 ns</td><td align="right" bgcolor="#FFFFFF">34,458 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 11,853 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,286 ns</td><td align="right" bgcolor="#FFFFFF">79,355 ns</td><td align="right" bgcolor="#FFFFFF">79,041 ns</td><td align="right" bgcolor="#FFFFFF">79,994 ns</td><td align="right" bgcolor="#FFFFFF">90,894 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 1,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,102 ns</td><td align="right" bgcolor="#FFFFFF">89,064 ns</td><td align="right" bgcolor="#FFFFFF">88,156 ns</td><td align="right" bgcolor="#FFFFFF">88,236 ns</td><td align="right" bgcolor="#FFFFFF">88,243 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 2,539 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">54,390 ns</td><td align="right" bgcolor="#FFFFFF">53,598 ns</td><td align="right" bgcolor="#FFFFFF">53,676 ns</td><td align="right" bgcolor="#FFFFFF">56,001 ns</td><td align="right" bgcolor="#FFFFFF">56,137 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 3,528 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">63,795 ns</td><td align="right" bgcolor="#FFFFFF">64,171 ns</td><td align="right" bgcolor="#FFFFFF">64,223 ns</td><td align="right" bgcolor="#FFFFFF">63,180 ns</td><td align="right" bgcolor="#FFFFFF">66,708 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 251,535 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10730,367 ns</td><td align="right" bgcolor="#FFFFFF">10719,732 ns</td><td align="right" bgcolor="#FFFFFF">10674,938 ns</td><td align="right" bgcolor="#FFFFFF">10827,035 ns</td><td align="right" bgcolor="#FFFFFF">10926,473 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,730 μs</td><td align="right" bgcolor="#FFFFFF">10,720 μs</td><td align="right" bgcolor="#FFFFFF">10,675 μs</td><td align="right" bgcolor="#FFFFFF">10,827 μs</td><td align="right" bgcolor="#FFFFFF">10,926 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 88,628 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10725,534 ns</td><td align="right" bgcolor="#FFFFFF">10682,871 ns</td><td align="right" bgcolor="#FFFFFF">10714,677 ns</td><td align="right" bgcolor="#FFFFFF">10665,804 ns</td><td align="right" bgcolor="#FFFFFF">10754,432 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,726 μs</td><td align="right" bgcolor="#FFFFFF">10,683 μs</td><td align="right" bgcolor="#FFFFFF">10,715 μs</td><td align="right" bgcolor="#FFFFFF">10,666 μs</td><td align="right" bgcolor="#FFFFFF">10,754 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 963,032 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21382,242 ns</td><td align="right" bgcolor="#FFFFFF">21287,924 ns</td><td align="right" bgcolor="#FF4949">22250,956 ns (Δ = +963,032 ns)</td><td align="right" bgcolor="#A8D08D">21362,228 ns (Δ = -888,728 ns)</td><td align="right" bgcolor="#FFFFFF">21372,731 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">21,382 μs</td><td align="right" bgcolor="#FFFFFF">21,288 μs</td><td align="right" bgcolor="#FFFFFF">22,251 μs</td><td align="right" bgcolor="#FFFFFF">21,362 μs</td><td align="right" bgcolor="#FFFFFF">21,373 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 352,326 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9957,563 ns</td><td align="right" bgcolor="#A8D08D">9605,237 ns (Δ = -352,326 ns)</td><td align="right" bgcolor="#FFFFFF">9820,218 ns</td><td align="right" bgcolor="#FFFFFF">9752,663 ns</td><td align="right" bgcolor="#FFFFFF">9791,507 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,958 μs</td><td align="right" bgcolor="#FFFFFF">9,605 μs</td><td align="right" bgcolor="#FFFFFF">9,820 μs</td><td align="right" bgcolor="#FFFFFF">9,753 μs</td><td align="right" bgcolor="#FFFFFF">9,792 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 294,243 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13350,823 ns</td><td align="right" bgcolor="#FFFFFF">13503,940 ns</td><td align="right" bgcolor="#FFFFFF">13645,066 ns</td><td align="right" bgcolor="#FFFFFF">13489,748 ns</td><td align="right" bgcolor="#FFFFFF">13371,756 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,351 μs</td><td align="right" bgcolor="#FFFFFF">13,504 μs</td><td align="right" bgcolor="#FFFFFF">13,645 μs</td><td align="right" bgcolor="#FFFFFF">13,490 μs</td><td align="right" bgcolor="#FFFFFF">13,372 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 131,966 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13538,683 ns</td><td align="right" bgcolor="#FFFFFF">13596,426 ns</td><td align="right" bgcolor="#FFFFFF">13670,649 ns</td><td align="right" bgcolor="#FFFFFF">13657,724 ns</td><td align="right" bgcolor="#FFFFFF">13614,626 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,539 μs</td><td align="right" bgcolor="#FFFFFF">13,596 μs</td><td align="right" bgcolor="#FFFFFF">13,671 μs</td><td align="right" bgcolor="#FFFFFF">13,658 μs</td><td align="right" bgcolor="#FFFFFF">13,615 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 218,092 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13403,972 ns</td><td align="right" bgcolor="#FFFFFF">13185,879 ns</td><td align="right" bgcolor="#FFFFFF">13229,529 ns</td><td align="right" bgcolor="#FFFFFF">13268,586 ns</td><td align="right" bgcolor="#FFFFFF">13347,221 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,404 μs</td><td align="right" bgcolor="#FFFFFF">13,186 μs</td><td align="right" bgcolor="#FFFFFF">13,230 μs</td><td align="right" bgcolor="#FFFFFF">13,269 μs</td><td align="right" bgcolor="#FFFFFF">13,347 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 7703,588 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">560541,786 ns</td><td align="right" bgcolor="#FFFFFF">559454,172 ns</td><td align="right" bgcolor="#FFFFFF">561139,668 ns</td><td align="right" bgcolor="#FFFFFF">561220,130 ns</td><td align="right" bgcolor="#FF4949">567157,759 ns (Δ = +5937,630 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">560,542 μs</td><td align="right" bgcolor="#FFFFFF">559,454 μs</td><td align="right" bgcolor="#FFFFFF">561,140 μs</td><td align="right" bgcolor="#FFFFFF">561,220 μs</td><td align="right" bgcolor="#FFFFFF">567,158 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,559 ms</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,567 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.6.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FF4949">7,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 212,809 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4319,496 ns</td><td align="right" bgcolor="#FFFFFF">4223,718 ns</td><td align="right" bgcolor="#FFFFFF">4384,953 ns</td><td align="right" bgcolor="#FFFFFF">4436,527 ns</td><td align="right" bgcolor="#FFFFFF">4330,398 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,319 μs</td><td align="right" bgcolor="#FFFFFF">4,224 μs</td><td align="right" bgcolor="#FFFFFF">4,385 μs</td><td align="right" bgcolor="#FFFFFF">4,437 μs</td><td align="right" bgcolor="#FFFFFF">4,330 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 158,693 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10899,492 ns</td><td align="right" bgcolor="#FFFFFF">10878,800 ns</td><td align="right" bgcolor="#FFFFFF">10856,369 ns</td><td align="right" bgcolor="#FFFFFF">11015,063 ns</td><td align="right" bgcolor="#FFFFFF">10969,099 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,899 μs</td><td align="right" bgcolor="#FFFFFF">10,879 μs</td><td align="right" bgcolor="#FFFFFF">10,856 μs</td><td align="right" bgcolor="#FFFFFF">11,015 μs</td><td align="right" bgcolor="#FFFFFF">10,969 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 161,134 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13471,833 ns</td><td align="right" bgcolor="#FFFFFF">13579,081 ns</td><td align="right" bgcolor="#FFFFFF">13548,295 ns</td><td align="right" bgcolor="#FFFFFF">13535,166 ns</td><td align="right" bgcolor="#FFFFFF">13417,947 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,472 μs</td><td align="right" bgcolor="#FFFFFF">13,579 μs</td><td align="right" bgcolor="#FFFFFF">13,548 μs</td><td align="right" bgcolor="#FFFFFF">13,535 μs</td><td align="right" bgcolor="#FFFFFF">13,418 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 201,571 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13637,170 ns</td><td align="right" bgcolor="#FFFFFF">13692,152 ns</td><td align="right" bgcolor="#FFFFFF">13540,677 ns</td><td align="right" bgcolor="#FFFFFF">13547,214 ns</td><td align="right" bgcolor="#FFFFFF">13490,582 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,637 μs</td><td align="right" bgcolor="#FFFFFF">13,692 μs</td><td align="right" bgcolor="#FFFFFF">13,541 μs</td><td align="right" bgcolor="#FFFFFF">13,547 μs</td><td align="right" bgcolor="#FFFFFF">13,491 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 157,526 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1437,958 ns</td><td align="right" bgcolor="#FFFFFF">1432,353 ns</td><td align="right" bgcolor="#FFFFFF">1469,052 ns</td><td align="right" bgcolor="#FFFFFF">1589,879 ns</td><td align="right" bgcolor="#FFFFFF">1435,758 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,438 μs</td><td align="right" bgcolor="#FFFFFF">1,432 μs</td><td align="right" bgcolor="#FFFFFF">1,469 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,436 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 223,054 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4049,925 ns</td><td align="right" bgcolor="#FFFFFF">4043,424 ns</td><td align="right" bgcolor="#FFFFFF">4120,100 ns</td><td align="right" bgcolor="#FFFFFF">3897,046 ns</td><td align="right" bgcolor="#FFFFFF">4084,201 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,050 μs</td><td align="right" bgcolor="#FFFFFF">4,043 μs</td><td align="right" bgcolor="#FFFFFF">4,120 μs</td><td align="right" bgcolor="#FFFFFF">3,897 μs</td><td align="right" bgcolor="#FFFFFF">4,084 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 96,035 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5001,980 ns</td><td align="right" bgcolor="#FFFFFF">4975,448 ns</td><td align="right" bgcolor="#FFFFFF">5071,483 ns</td><td align="right" bgcolor="#FFFFFF">4976,891 ns</td><td align="right" bgcolor="#FFFFFF">4990,031 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,002 μs</td><td align="right" bgcolor="#FFFFFF">4,975 μs</td><td align="right" bgcolor="#FFFFFF">5,071 μs</td><td align="right" bgcolor="#FFFFFF">4,977 μs</td><td align="right" bgcolor="#FFFFFF">4,990 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 184,584 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4204,099 ns</td><td align="right" bgcolor="#FFFFFF">4161,007 ns</td><td align="right" bgcolor="#FFFFFF">4168,812 ns</td><td align="right" bgcolor="#FFFFFF">4166,677 ns</td><td align="right" bgcolor="#FFFFFF">4019,515 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,204 μs</td><td align="right" bgcolor="#FFFFFF">4,161 μs</td><td align="right" bgcolor="#FFFFFF">4,169 μs</td><td align="right" bgcolor="#FFFFFF">4,167 μs</td><td align="right" bgcolor="#FFFFFF">4,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 239,563 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5139,785 ns</td><td align="right" bgcolor="#FFFFFF">5094,114 ns</td><td align="right" bgcolor="#FFFFFF">5115,187 ns</td><td align="right" bgcolor="#FFFFFF">4900,223 ns</td><td align="right" bgcolor="#FFFFFF">5035,826 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,140 μs</td><td align="right" bgcolor="#FFFFFF">5,094 μs</td><td align="right" bgcolor="#FFFFFF">5,115 μs</td><td align="right" bgcolor="#FFFFFF">4,900 μs</td><td align="right" bgcolor="#FFFFFF">5,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 165,129 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4140,558 ns</td><td align="right" bgcolor="#FFFFFF">4209,510 ns</td><td align="right" bgcolor="#FFFFFF">4121,391 ns</td><td align="right" bgcolor="#FFFFFF">4076,694 ns</td><td align="right" bgcolor="#FFFFFF">4044,381 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,141 μs</td><td align="right" bgcolor="#FFFFFF">4,210 μs</td><td align="right" bgcolor="#FFFFFF">4,121 μs</td><td align="right" bgcolor="#FFFFFF">4,077 μs</td><td align="right" bgcolor="#FFFFFF">4,044 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 374,178 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5099,027 ns</td><td align="right" bgcolor="#FFFFFF">5221,733 ns</td><td align="right" bgcolor="#FFFFFF">4985,760 ns</td><td align="right" bgcolor="#FFFFFF">4928,296 ns</td><td align="right" bgcolor="#FFFFFF">4847,555 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,099 μs</td><td align="right" bgcolor="#FFFFFF">5,222 μs</td><td align="right" bgcolor="#FFFFFF">4,986 μs</td><td align="right" bgcolor="#FFFFFF">4,928 μs</td><td align="right" bgcolor="#FFFFFF">4,848 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 97,245 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4126,359 ns</td><td align="right" bgcolor="#FFFFFF">4178,728 ns</td><td align="right" bgcolor="#FFFFFF">4193,405 ns</td><td align="right" bgcolor="#FFFFFF">4096,159 ns</td><td align="right" bgcolor="#FFFFFF">4132,305 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,126 μs</td><td align="right" bgcolor="#FFFFFF">4,179 μs</td><td align="right" bgcolor="#FFFFFF">4,193 μs</td><td align="right" bgcolor="#FFFFFF">4,096 μs</td><td align="right" bgcolor="#FFFFFF">4,132 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 262,740 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5174,822 ns</td><td align="right" bgcolor="#FFFFFF">5180,069 ns</td><td align="right" bgcolor="#FFFFFF">5044,751 ns</td><td align="right" bgcolor="#FFFFFF">5148,201 ns</td><td align="right" bgcolor="#FFFFFF">4917,328 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,175 μs</td><td align="right" bgcolor="#FFFFFF">5,180 μs</td><td align="right" bgcolor="#FFFFFF">5,045 μs</td><td align="right" bgcolor="#FFFFFF">5,148 μs</td><td align="right" bgcolor="#FFFFFF">4,917 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 90,750 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4092,350 ns</td><td align="right" bgcolor="#FFFFFF">4085,249 ns</td><td align="right" bgcolor="#FFFFFF">4033,368 ns</td><td align="right" bgcolor="#FFFFFF">4001,600 ns</td><td align="right" bgcolor="#FFFFFF">4052,976 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,092 μs</td><td align="right" bgcolor="#FFFFFF">4,085 μs</td><td align="right" bgcolor="#FFFFFF">4,033 μs</td><td align="right" bgcolor="#FFFFFF">4,002 μs</td><td align="right" bgcolor="#FFFFFF">4,053 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 279,066 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4998,039 ns</td><td align="right" bgcolor="#FFFFFF">4916,628 ns</td><td align="right" bgcolor="#FFFFFF">5089,995 ns</td><td align="right" bgcolor="#FFFFFF">5155,852 ns</td><td align="right" bgcolor="#A8D08D">4876,786 ns (Δ = -279,066 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,998 μs</td><td align="right" bgcolor="#FFFFFF">4,917 μs</td><td align="right" bgcolor="#FFFFFF">5,090 μs</td><td align="right" bgcolor="#FFFFFF">5,156 μs</td><td align="right" bgcolor="#FFFFFF">4,877 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 94,890 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4142,443 ns</td><td align="right" bgcolor="#FFFFFF">4132,101 ns</td><td align="right" bgcolor="#FFFFFF">4047,553 ns</td><td align="right" bgcolor="#FFFFFF">4107,198 ns</td><td align="right" bgcolor="#FFFFFF">4135,586 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,142 μs</td><td align="right" bgcolor="#FFFFFF">4,132 μs</td><td align="right" bgcolor="#FFFFFF">4,048 μs</td><td align="right" bgcolor="#FFFFFF">4,107 μs</td><td align="right" bgcolor="#FFFFFF">4,136 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 170,474 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5055,102 ns</td><td align="right" bgcolor="#FFFFFF">5015,896 ns</td><td align="right" bgcolor="#FFFFFF">5097,256 ns</td><td align="right" bgcolor="#FFFFFF">5008,380 ns</td><td align="right" bgcolor="#FFFFFF">4926,782 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,055 μs</td><td align="right" bgcolor="#FFFFFF">5,016 μs</td><td align="right" bgcolor="#FFFFFF">5,097 μs</td><td align="right" bgcolor="#FFFFFF">5,008 μs</td><td align="right" bgcolor="#FFFFFF">4,927 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 35,866 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">314,512 ns</td><td align="right" bgcolor="#FFFFFF">314,159 ns</td><td align="right" bgcolor="#FFFFFF">314,633 ns</td><td align="right" bgcolor="#FFFFFF">316,208 ns</td><td align="right" bgcolor="#FFFFFF">350,025 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,314 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 7,313 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">307,427 ns</td><td align="right" bgcolor="#FFFFFF">306,044 ns</td><td align="right" bgcolor="#FFFFFF">304,942 ns</td><td align="right" bgcolor="#FFFFFF">308,739 ns</td><td align="right" bgcolor="#FFFFFF">312,255 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 21,722 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">314,793 ns</td><td align="right" bgcolor="#FFFFFF">314,552 ns</td><td align="right" bgcolor="#FFFFFF">307,334 ns</td><td align="right" bgcolor="#FFFFFF">307,673 ns</td><td align="right" bgcolor="#FFFFFF">329,056 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 15,281 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">282,811 ns</td><td align="right" bgcolor="#FFFFFF">293,240 ns</td><td align="right" bgcolor="#FFFFFF">277,959 ns</td><td align="right" bgcolor="#FFFFFF">278,834 ns</td><td align="right" bgcolor="#FFFFFF">286,750 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 18,947 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">279,673 ns</td><td align="right" bgcolor="#FFFFFF">297,886 ns</td><td align="right" bgcolor="#FFFFFF">280,117 ns</td><td align="right" bgcolor="#FFFFFF">278,940 ns</td><td align="right" bgcolor="#FFFFFF">291,914 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,298 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 11,200 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">317,640 ns</td><td align="right" bgcolor="#FFFFFF">312,344 ns</td><td align="right" bgcolor="#FFFFFF">312,524 ns</td><td align="right" bgcolor="#FFFFFF">321,242 ns</td><td align="right" bgcolor="#FFFFFF">323,544 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,318 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 330,130 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1361,028 ns</td><td align="right" bgcolor="#FFFFFF">1418,310 ns</td><td align="right" bgcolor="#FFFFFF">1369,177 ns</td><td align="right" bgcolor="#FFFFFF">1455,878 ns</td><td align="right" bgcolor="#FFFFFF">1691,158 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">1,418 μs</td><td align="right" bgcolor="#FFFFFF">1,369 μs</td><td align="right" bgcolor="#FFFFFF">1,456 μs</td><td align="right" bgcolor="#FFFFFF">1,691 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 1,568 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">153,878 ns</td><td align="right" bgcolor="#FFFFFF">154,060 ns</td><td align="right" bgcolor="#FFFFFF">153,875 ns</td><td align="right" bgcolor="#FFFFFF">153,846 ns</td><td align="right" bgcolor="#FFFFFF">155,414 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 9,728 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">181,170 ns</td><td align="right" bgcolor="#FFFFFF">176,529 ns</td><td align="right" bgcolor="#FFFFFF">171,442 ns</td><td align="right" bgcolor="#FFFFFF">171,922 ns</td><td align="right" bgcolor="#FFFFFF">176,744 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 252,331 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2904,094 ns</td><td align="right" bgcolor="#FFFFFF">2739,676 ns</td><td align="right" bgcolor="#FFFFFF">2816,490 ns</td><td align="right" bgcolor="#FFFFFF">2651,763 ns</td><td align="right" bgcolor="#FFFFFF">2783,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,904 μs</td><td align="right" bgcolor="#FFFFFF">2,740 μs</td><td align="right" bgcolor="#FFFFFF">2,816 μs</td><td align="right" bgcolor="#FFFFFF">2,652 μs</td><td align="right" bgcolor="#FFFFFF">2,783 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 256,836 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5716,965 ns</td><td align="right" bgcolor="#FFFFFF">5487,812 ns</td><td align="right" bgcolor="#FFFFFF">5460,128 ns</td><td align="right" bgcolor="#FFFFFF">5530,694 ns</td><td align="right" bgcolor="#FFFFFF">5681,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,717 μs</td><td align="right" bgcolor="#FFFFFF">5,488 μs</td><td align="right" bgcolor="#FFFFFF">5,460 μs</td><td align="right" bgcolor="#FFFFFF">5,531 μs</td><td align="right" bgcolor="#FFFFFF">5,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 7,513 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">366,071 ns</td><td align="right" bgcolor="#FFFFFF">365,923 ns</td><td align="right" bgcolor="#FFFFFF">366,173 ns</td><td align="right" bgcolor="#FFFFFF">364,933 ns</td><td align="right" bgcolor="#FFFFFF">372,446 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,365 μs</td><td align="right" bgcolor="#FFFFFF">0,372 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 333,593 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5837,959 ns</td><td align="right" bgcolor="#FFFFFF">5624,143 ns</td><td align="right" bgcolor="#FFFFFF">5597,946 ns</td><td align="right" bgcolor="#FFFFFF">5504,366 ns</td><td align="right" bgcolor="#FFFFFF">5674,238 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,838 μs</td><td align="right" bgcolor="#FFFFFF">5,624 μs</td><td align="right" bgcolor="#FFFFFF">5,598 μs</td><td align="right" bgcolor="#FFFFFF">5,504 μs</td><td align="right" bgcolor="#FFFFFF">5,674 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 18,688 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">390,478 ns</td><td align="right" bgcolor="#FFFFFF">402,137 ns</td><td align="right" bgcolor="#FFFFFF">390,161 ns</td><td align="right" bgcolor="#FFFFFF">383,449 ns</td><td align="right" bgcolor="#FFFFFF">392,834 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,393 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 13,527 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">383,129 ns</td><td align="right" bgcolor="#FFFFFF">396,110 ns</td><td align="right" bgcolor="#FFFFFF">386,624 ns</td><td align="right" bgcolor="#FFFFFF">382,583 ns</td><td align="right" bgcolor="#FFFFFF">393,037 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,396 μs</td><td align="right" bgcolor="#FFFFFF">0,387 μs</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,393 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 16,444 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">383,176 ns</td><td align="right" bgcolor="#FFFFFF">385,080 ns</td><td align="right" bgcolor="#FFFFFF">383,807 ns</td><td align="right" bgcolor="#FFFFFF">381,193 ns</td><td align="right" bgcolor="#FFFFFF">397,638 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,385 μs</td><td align="right" bgcolor="#FFFFFF">0,384 μs</td><td align="right" bgcolor="#FFFFFF">0,381 μs</td><td align="right" bgcolor="#FFFFFF">0,398 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 14,943 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">382,172 ns</td><td align="right" bgcolor="#FFFFFF">381,912 ns</td><td align="right" bgcolor="#FFFFFF">380,433 ns</td><td align="right" bgcolor="#FFFFFF">380,307 ns</td><td align="right" bgcolor="#FFFFFF">395,250 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,382 μs</td><td align="right" bgcolor="#FFFFFF">0,382 μs</td><td align="right" bgcolor="#FFFFFF">0,380 μs</td><td align="right" bgcolor="#FFFFFF">0,380 μs</td><td align="right" bgcolor="#FFFFFF">0,395 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 533,433 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4084,308 ns</td><td align="right" bgcolor="#A8D08D">3550,875 ns (Δ = -533,433 ns)</td><td align="right" bgcolor="#FF4949">3997,721 ns (Δ = +446,846 ns)</td><td align="right" bgcolor="#A8D08D">3731,325 ns (Δ = -266,396 ns)</td><td align="right" bgcolor="#FF4949">4028,035 ns (Δ = +296,710 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,084 μs</td><td align="right" bgcolor="#FFFFFF">3,551 μs</td><td align="right" bgcolor="#FFFFFF">3,998 μs</td><td align="right" bgcolor="#FFFFFF">3,731 μs</td><td align="right" bgcolor="#FFFFFF">4,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 530,887 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6983,081 ns</td><td align="right" bgcolor="#FFFFFF">6777,382 ns</td><td align="right" bgcolor="#A8D08D">6452,193 ns (Δ = -325,188 ns)</td><td align="right" bgcolor="#FFFFFF">6552,434 ns</td><td align="right" bgcolor="#FFFFFF">6582,294 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,983 μs</td><td align="right" bgcolor="#FFFFFF">6,777 μs</td><td align="right" bgcolor="#FFFFFF">6,452 μs</td><td align="right" bgcolor="#FFFFFF">6,552 μs</td><td align="right" bgcolor="#FFFFFF">6,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 10,584 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">133,348 ns</td><td align="right" bgcolor="#FFFFFF">130,169 ns</td><td align="right" bgcolor="#FFFFFF">132,377 ns</td><td align="right" bgcolor="#FFFFFF">140,753 ns</td><td align="right" bgcolor="#FFFFFF">139,274 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 1,728 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">110,735 ns</td><td align="right" bgcolor="#FFFFFF">111,733 ns</td><td align="right" bgcolor="#FFFFFF">111,928 ns</td><td align="right" bgcolor="#FFFFFF">112,153 ns</td><td align="right" bgcolor="#FFFFFF">112,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 6,154 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,349 ns</td><td align="right" bgcolor="#FFFFFF">32,114 ns</td><td align="right" bgcolor="#FFFFFF">32,372 ns</td><td align="right" bgcolor="#FFFFFF">31,195 ns</td><td align="right" bgcolor="#FFFFFF">31,707 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 70,194 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">597,547 ns</td><td align="right" bgcolor="#FFFFFF">541,046 ns</td><td align="right" bgcolor="#FFFFFF">548,689 ns</td><td align="right" bgcolor="#FFFFFF">570,833 ns</td><td align="right" bgcolor="#FFFFFF">527,353 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,598 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td><td align="right" bgcolor="#FFFFFF">0,549 μs</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 74,491 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">886,865 ns</td><td align="right" bgcolor="#FFFFFF">904,484 ns</td><td align="right" bgcolor="#FFFFFF">911,134 ns</td><td align="right" bgcolor="#FFFFFF">961,356 ns</td><td align="right" bgcolor="#FFFFFF">949,874 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,887 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,961 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 67,695 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1021,452 ns</td><td align="right" bgcolor="#FFFFFF">1057,863 ns</td><td align="right" bgcolor="#FFFFFF">1024,990 ns</td><td align="right" bgcolor="#FFFFFF">1089,148 ns</td><td align="right" bgcolor="#FFFFFF">1081,083 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,021 μs</td><td align="right" bgcolor="#FFFFFF">1,058 μs</td><td align="right" bgcolor="#FFFFFF">1,025 μs</td><td align="right" bgcolor="#FFFFFF">1,089 μs</td><td align="right" bgcolor="#FFFFFF">1,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 84,128 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1219,982 ns</td><td align="right" bgcolor="#FFFFFF">1237,486 ns</td><td align="right" bgcolor="#FFFFFF">1222,422 ns</td><td align="right" bgcolor="#FFFFFF">1244,524 ns</td><td align="right" bgcolor="#FFFFFF">1304,110 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,220 μs</td><td align="right" bgcolor="#FFFFFF">1,237 μs</td><td align="right" bgcolor="#FFFFFF">1,222 μs</td><td align="right" bgcolor="#FFFFFF">1,245 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 71,809 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1504,304 ns</td><td align="right" bgcolor="#FFFFFF">1576,113 ns</td><td align="right" bgcolor="#FFFFFF">1521,156 ns</td><td align="right" bgcolor="#FFFFFF">1505,220 ns</td><td align="right" bgcolor="#FFFFFF">1536,708 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td><td align="right" bgcolor="#FFFFFF">1,576 μs</td><td align="right" bgcolor="#FFFFFF">1,521 μs</td><td align="right" bgcolor="#FFFFFF">1,505 μs</td><td align="right" bgcolor="#FFFFFF">1,537 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 78,814 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1681,957 ns</td><td align="right" bgcolor="#FFFFFF">1676,813 ns</td><td align="right" bgcolor="#FFFFFF">1706,763 ns</td><td align="right" bgcolor="#FFFFFF">1755,626 ns</td><td align="right" bgcolor="#FFFFFF">1741,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,682 μs</td><td align="right" bgcolor="#FFFFFF">1,677 μs</td><td align="right" bgcolor="#FFFFFF">1,707 μs</td><td align="right" bgcolor="#FFFFFF">1,756 μs</td><td align="right" bgcolor="#FFFFFF">1,742 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 229,159 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1987,698 ns</td><td align="right" bgcolor="#FFFFFF">2216,857 ns</td><td align="right" bgcolor="#FFFFFF">1992,016 ns</td><td align="right" bgcolor="#FFFFFF">2073,386 ns</td><td align="right" bgcolor="#FFFFFF">2080,047 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,988 μs</td><td align="right" bgcolor="#FFFFFF">2,217 μs</td><td align="right" bgcolor="#FFFFFF">1,992 μs</td><td align="right" bgcolor="#FFFFFF">2,073 μs</td><td align="right" bgcolor="#FFFFFF">2,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 25,866 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2236,711 ns</td><td align="right" bgcolor="#FFFFFF">2233,116 ns</td><td align="right" bgcolor="#FFFFFF">2218,008 ns</td><td align="right" bgcolor="#FFFFFF">2233,865 ns</td><td align="right" bgcolor="#FFFFFF">2210,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,237 μs</td><td align="right" bgcolor="#FFFFFF">2,233 μs</td><td align="right" bgcolor="#FFFFFF">2,218 μs</td><td align="right" bgcolor="#FFFFFF">2,234 μs</td><td align="right" bgcolor="#FFFFFF">2,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 4,935 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,943 ns</td><td align="right" bgcolor="#FFFFFF">2,052 ns</td><td align="right" bgcolor="#FFFFFF">2,063 ns</td><td align="right" bgcolor="#FFFFFF">2,065 ns</td><td align="right" bgcolor="#FFFFFF">2,009 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 5,988 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,434 ns</td><td align="right" bgcolor="#FFFFFF">25,994 ns</td><td align="right" bgcolor="#FFFFFF">24,067 ns</td><td align="right" bgcolor="#FFFFFF">25,243 ns</td><td align="right" bgcolor="#FFFFFF">23,446 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 5,692 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,426 ns</td><td align="right" bgcolor="#FFFFFF">17,838 ns</td><td align="right" bgcolor="#FFFFFF">17,734 ns</td><td align="right" bgcolor="#FFFFFF">18,676 ns</td><td align="right" bgcolor="#FFFFFF">18,036 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 38,605 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">364,637 ns</td><td align="right" bgcolor="#FFFFFF">386,243 ns</td><td align="right" bgcolor="#FFFFFF">372,915 ns</td><td align="right" bgcolor="#FFFFFF">403,242 ns</td><td align="right" bgcolor="#FFFFFF">392,322 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,365 μs</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,373 μs</td><td align="right" bgcolor="#FFFFFF">0,403 μs</td><td align="right" bgcolor="#FFFFFF">0,392 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 106,450 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">903,737 ns</td><td align="right" bgcolor="#FFFFFF">997,865 ns</td><td align="right" bgcolor="#FFFFFF">918,379 ns</td><td align="right" bgcolor="#FFFFFF">891,415 ns</td><td align="right" bgcolor="#FFFFFF">944,004 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">0,998 μs</td><td align="right" bgcolor="#FFFFFF">0,918 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,944 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 41,920 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">760,065 ns</td><td align="right" bgcolor="#FFFFFF">798,307 ns</td><td align="right" bgcolor="#FFFFFF">776,230 ns</td><td align="right" bgcolor="#FFFFFF">775,773 ns</td><td align="right" bgcolor="#FFFFFF">801,985 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,802 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 169,999 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">819,748 ns</td><td align="right" bgcolor="#FFFFFF">804,235 ns</td><td align="right" bgcolor="#FFFFFF">811,957 ns</td><td align="right" bgcolor="#FFFFFF">854,156 ns</td><td align="right" bgcolor="#FFFFFF">974,234 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,820 μs</td><td align="right" bgcolor="#FFFFFF">0,804 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#FFFFFF">0,854 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 40,666 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1050,767 ns</td><td align="right" bgcolor="#FFFFFF">1052,435 ns</td><td align="right" bgcolor="#FFFFFF">1031,687 ns</td><td align="right" bgcolor="#FFFFFF">1072,354 ns</td><td align="right" bgcolor="#FFFFFF">1066,305 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,051 μs</td><td align="right" bgcolor="#FFFFFF">1,052 μs</td><td align="right" bgcolor="#FFFFFF">1,032 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 226,601 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1447,896 ns</td><td align="right" bgcolor="#FFFFFF">1221,295 ns</td><td align="right" bgcolor="#FFFFFF">1233,005 ns</td><td align="right" bgcolor="#FFFFFF">1229,548 ns</td><td align="right" bgcolor="#FFFFFF">1287,072 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,448 μs</td><td align="right" bgcolor="#FFFFFF">1,221 μs</td><td align="right" bgcolor="#FFFFFF">1,233 μs</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 88,896 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1511,978 ns</td><td align="right" bgcolor="#FFFFFF">1509,618 ns</td><td align="right" bgcolor="#FFFFFF">1479,882 ns</td><td align="right" bgcolor="#FFFFFF">1527,962 ns</td><td align="right" bgcolor="#FFFFFF">1568,778 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,512 μs</td><td align="right" bgcolor="#FFFFFF">1,510 μs</td><td align="right" bgcolor="#FFFFFF">1,480 μs</td><td align="right" bgcolor="#FFFFFF">1,528 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 54,658 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1684,077 ns</td><td align="right" bgcolor="#FFFFFF">1676,304 ns</td><td align="right" bgcolor="#FFFFFF">1698,451 ns</td><td align="right" bgcolor="#FFFFFF">1702,199 ns</td><td align="right" bgcolor="#FFFFFF">1730,962 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,684 μs</td><td align="right" bgcolor="#FFFFFF">1,676 μs</td><td align="right" bgcolor="#FFFFFF">1,698 μs</td><td align="right" bgcolor="#FFFFFF">1,702 μs</td><td align="right" bgcolor="#FFFFFF">1,731 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 69,560 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1992,544 ns</td><td align="right" bgcolor="#FFFFFF">1988,956 ns</td><td align="right" bgcolor="#FFFFFF">2042,906 ns</td><td align="right" bgcolor="#FFFFFF">2021,510 ns</td><td align="right" bgcolor="#FFFFFF">2058,515 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,993 μs</td><td align="right" bgcolor="#FFFFFF">1,989 μs</td><td align="right" bgcolor="#FFFFFF">2,043 μs</td><td align="right" bgcolor="#FFFFFF">2,022 μs</td><td align="right" bgcolor="#FFFFFF">2,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 78,434 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2219,393 ns</td><td align="right" bgcolor="#FFFFFF">2246,596 ns</td><td align="right" bgcolor="#FFFFFF">2180,450 ns</td><td align="right" bgcolor="#FFFFFF">2236,599 ns</td><td align="right" bgcolor="#FFFFFF">2258,884 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,219 μs</td><td align="right" bgcolor="#FFFFFF">2,247 μs</td><td align="right" bgcolor="#FFFFFF">2,180 μs</td><td align="right" bgcolor="#FFFFFF">2,237 μs</td><td align="right" bgcolor="#FFFFFF">2,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 50,661 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">930,491 ns</td><td align="right" bgcolor="#FFFFFF">913,802 ns</td><td align="right" bgcolor="#FFFFFF">881,092 ns</td><td align="right" bgcolor="#FFFFFF">931,753 ns</td><td align="right" bgcolor="#FFFFFF">920,954 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">0,881 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">0,921 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 110,218 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1093,727 ns</td><td align="right" bgcolor="#FFFFFF">1113,306 ns</td><td align="right" bgcolor="#FFFFFF">1100,907 ns</td><td align="right" bgcolor="#FFFFFF">1172,631 ns</td><td align="right" bgcolor="#FFFFFF">1203,945 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,094 μs</td><td align="right" bgcolor="#FFFFFF">1,113 μs</td><td align="right" bgcolor="#FFFFFF">1,101 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,204 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 79,112 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1290,912 ns</td><td align="right" bgcolor="#FFFFFF">1370,024 ns</td><td align="right" bgcolor="#FFFFFF">1297,273 ns</td><td align="right" bgcolor="#FFFFFF">1328,055 ns</td><td align="right" bgcolor="#FFFFFF">1360,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,291 μs</td><td align="right" bgcolor="#FFFFFF">1,370 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,328 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 171,174 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1494,888 ns</td><td align="right" bgcolor="#FFFFFF">1514,555 ns</td><td align="right" bgcolor="#FFFFFF">1526,594 ns</td><td align="right" bgcolor="#FFFFFF">1607,884 ns</td><td align="right" bgcolor="#FFFFFF">1666,061 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,495 μs</td><td align="right" bgcolor="#FFFFFF">1,515 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td><td align="right" bgcolor="#FFFFFF">1,608 μs</td><td align="right" bgcolor="#FFFFFF">1,666 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 67,217 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1731,524 ns</td><td align="right" bgcolor="#FFFFFF">1721,376 ns</td><td align="right" bgcolor="#FFFFFF">1697,772 ns</td><td align="right" bgcolor="#FFFFFF">1764,989 ns</td><td align="right" bgcolor="#FFFFFF">1734,437 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,732 μs</td><td align="right" bgcolor="#FFFFFF">1,721 μs</td><td align="right" bgcolor="#FFFFFF">1,698 μs</td><td align="right" bgcolor="#FFFFFF">1,765 μs</td><td align="right" bgcolor="#FFFFFF">1,734 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 207,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1893,097 ns</td><td align="right" bgcolor="#FFFFFF">1915,043 ns</td><td align="right" bgcolor="#FFFFFF">1911,973 ns</td><td align="right" bgcolor="#FFFFFF">1983,879 ns</td><td align="right" bgcolor="#FFFFFF">2100,161 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,893 μs</td><td align="right" bgcolor="#FFFFFF">1,915 μs</td><td align="right" bgcolor="#FFFFFF">1,912 μs</td><td align="right" bgcolor="#FFFFFF">1,984 μs</td><td align="right" bgcolor="#FFFFFF">2,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 111,744 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2125,434 ns</td><td align="right" bgcolor="#FFFFFF">2043,343 ns</td><td align="right" bgcolor="#FFFFFF">2063,547 ns</td><td align="right" bgcolor="#FFFFFF">2110,647 ns</td><td align="right" bgcolor="#FFFFFF">2155,087 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,125 μs</td><td align="right" bgcolor="#FFFFFF">2,043 μs</td><td align="right" bgcolor="#FFFFFF">2,064 μs</td><td align="right" bgcolor="#FFFFFF">2,111 μs</td><td align="right" bgcolor="#FFFFFF">2,155 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 34,927 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">818,763 ns</td><td align="right" bgcolor="#FFFFFF">814,418 ns</td><td align="right" bgcolor="#FFFFFF">812,399 ns</td><td align="right" bgcolor="#FFFFFF">839,539 ns</td><td align="right" bgcolor="#FFFFFF">847,326 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,819 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,847 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 83,489 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1036,669 ns</td><td align="right" bgcolor="#FFFFFF">1051,847 ns</td><td align="right" bgcolor="#FFFFFF">1034,952 ns</td><td align="right" bgcolor="#FFFFFF">1065,254 ns</td><td align="right" bgcolor="#FFFFFF">1118,441 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,037 μs</td><td align="right" bgcolor="#FFFFFF">1,052 μs</td><td align="right" bgcolor="#FFFFFF">1,035 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 66,565 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1215,865 ns</td><td align="right" bgcolor="#FFFFFF">1229,933 ns</td><td align="right" bgcolor="#FFFFFF">1214,187 ns</td><td align="right" bgcolor="#FFFFFF">1225,016 ns</td><td align="right" bgcolor="#FFFFFF">1280,752 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,216 μs</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,214 μs</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,281 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 157,006 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1542,893 ns</td><td align="right" bgcolor="#FFFFFF">1509,686 ns</td><td align="right" bgcolor="#FFFFFF">1544,356 ns</td><td align="right" bgcolor="#FFFFFF">1531,470 ns</td><td align="right" bgcolor="#FFFFFF">1666,692 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,543 μs</td><td align="right" bgcolor="#FFFFFF">1,510 μs</td><td align="right" bgcolor="#FFFFFF">1,544 μs</td><td align="right" bgcolor="#FFFFFF">1,531 μs</td><td align="right" bgcolor="#FFFFFF">1,667 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 144,773 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1701,762 ns</td><td align="right" bgcolor="#FFFFFF">1729,599 ns</td><td align="right" bgcolor="#FFFFFF">1690,297 ns</td><td align="right" bgcolor="#FFFFFF">1778,944 ns</td><td align="right" bgcolor="#FFFFFF">1835,070 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,702 μs</td><td align="right" bgcolor="#FFFFFF">1,730 μs</td><td align="right" bgcolor="#FFFFFF">1,690 μs</td><td align="right" bgcolor="#FFFFFF">1,779 μs</td><td align="right" bgcolor="#FFFFFF">1,835 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 157,143 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1993,612 ns</td><td align="right" bgcolor="#FFFFFF">1970,487 ns</td><td align="right" bgcolor="#FFFFFF">2017,911 ns</td><td align="right" bgcolor="#FFFFFF">2076,065 ns</td><td align="right" bgcolor="#FFFFFF">2127,630 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,994 μs</td><td align="right" bgcolor="#FFFFFF">1,970 μs</td><td align="right" bgcolor="#FFFFFF">2,018 μs</td><td align="right" bgcolor="#FFFFFF">2,076 μs</td><td align="right" bgcolor="#FFFFFF">2,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 147,141 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2153,990 ns</td><td align="right" bgcolor="#FFFFFF">2171,271 ns</td><td align="right" bgcolor="#FFFFFF">2217,437 ns</td><td align="right" bgcolor="#FFFFFF">2301,131 ns</td><td align="right" bgcolor="#FFFFFF">2261,300 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,154 μs</td><td align="right" bgcolor="#FFFFFF">2,171 μs</td><td align="right" bgcolor="#FFFFFF">2,217 μs</td><td align="right" bgcolor="#FFFFFF">2,301 μs</td><td align="right" bgcolor="#FFFFFF">2,261 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 33,192 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">818,958 ns</td><td align="right" bgcolor="#FFFFFF">852,150 ns</td><td align="right" bgcolor="#FFFFFF">833,486 ns</td><td align="right" bgcolor="#FFFFFF">823,592 ns</td><td align="right" bgcolor="#FFFFFF">849,473 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,819 μs</td><td align="right" bgcolor="#FFFFFF">0,852 μs</td><td align="right" bgcolor="#FFFFFF">0,833 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 48,114 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1080,186 ns</td><td align="right" bgcolor="#FFFFFF">1087,381 ns</td><td align="right" bgcolor="#FFFFFF">1039,267 ns</td><td align="right" bgcolor="#FFFFFF">1070,717 ns</td><td align="right" bgcolor="#FFFFFF">1075,757 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,080 μs</td><td align="right" bgcolor="#FFFFFF">1,087 μs</td><td align="right" bgcolor="#FFFFFF">1,039 μs</td><td align="right" bgcolor="#FFFFFF">1,071 μs</td><td align="right" bgcolor="#FFFFFF">1,076 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 65,883 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1218,063 ns</td><td align="right" bgcolor="#FFFFFF">1230,690 ns</td><td align="right" bgcolor="#FFFFFF">1226,630 ns</td><td align="right" bgcolor="#FFFFFF">1229,365 ns</td><td align="right" bgcolor="#FFFFFF">1283,946 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,218 μs</td><td align="right" bgcolor="#FFFFFF">1,231 μs</td><td align="right" bgcolor="#FFFFFF">1,227 μs</td><td align="right" bgcolor="#FFFFFF">1,229 μs</td><td align="right" bgcolor="#FFFFFF">1,284 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 69,030 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1516,208 ns</td><td align="right" bgcolor="#FFFFFF">1474,726 ns</td><td align="right" bgcolor="#FFFFFF">1459,762 ns</td><td align="right" bgcolor="#FFFFFF">1513,194 ns</td><td align="right" bgcolor="#FFFFFF">1528,792 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,516 μs</td><td align="right" bgcolor="#FFFFFF">1,475 μs</td><td align="right" bgcolor="#FFFFFF">1,460 μs</td><td align="right" bgcolor="#FFFFFF">1,513 μs</td><td align="right" bgcolor="#FFFFFF">1,529 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 116,446 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1733,442 ns</td><td align="right" bgcolor="#FFFFFF">1735,370 ns</td><td align="right" bgcolor="#FFFFFF">1654,585 ns</td><td align="right" bgcolor="#FFFFFF">1752,083 ns</td><td align="right" bgcolor="#FFFFFF">1771,031 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,733 μs</td><td align="right" bgcolor="#FFFFFF">1,735 μs</td><td align="right" bgcolor="#FFFFFF">1,655 μs</td><td align="right" bgcolor="#FFFFFF">1,752 μs</td><td align="right" bgcolor="#FFFFFF">1,771 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 96,571 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2025,794 ns</td><td align="right" bgcolor="#FFFFFF">2045,358 ns</td><td align="right" bgcolor="#FFFFFF">1985,920 ns</td><td align="right" bgcolor="#FFFFFF">2073,679 ns</td><td align="right" bgcolor="#FFFFFF">2082,491 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,026 μs</td><td align="right" bgcolor="#FFFFFF">2,045 μs</td><td align="right" bgcolor="#FFFFFF">1,986 μs</td><td align="right" bgcolor="#FFFFFF">2,074 μs</td><td align="right" bgcolor="#FFFFFF">2,082 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 162,170 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2204,084 ns</td><td align="right" bgcolor="#FFFFFF">2185,652 ns</td><td align="right" bgcolor="#FFFFFF">2225,311 ns</td><td align="right" bgcolor="#FFFFFF">2321,906 ns</td><td align="right" bgcolor="#FFFFFF">2347,823 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,204 μs</td><td align="right" bgcolor="#FFFFFF">2,186 μs</td><td align="right" bgcolor="#FFFFFF">2,225 μs</td><td align="right" bgcolor="#FFFFFF">2,322 μs</td><td align="right" bgcolor="#FFFFFF">2,348 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 31,245 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6049,660 ns</td><td align="right" bgcolor="#FFFFFF">6080,905 ns</td><td align="right" bgcolor="#FFFFFF">6063,822 ns</td><td align="right" bgcolor="#FFFFFF">6071,511 ns</td><td align="right" bgcolor="#FFFFFF">6069,381 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,050 μs</td><td align="right" bgcolor="#FFFFFF">6,081 μs</td><td align="right" bgcolor="#FFFFFF">6,064 μs</td><td align="right" bgcolor="#FFFFFF">6,072 μs</td><td align="right" bgcolor="#FFFFFF">6,069 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 105,534 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10002,416 ns</td><td align="right" bgcolor="#FFFFFF">9898,509 ns</td><td align="right" bgcolor="#FFFFFF">9928,595 ns</td><td align="right" bgcolor="#FFFFFF">9966,583 ns</td><td align="right" bgcolor="#FFFFFF">10004,043 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,002 μs</td><td align="right" bgcolor="#FFFFFF">9,899 μs</td><td align="right" bgcolor="#FFFFFF">9,929 μs</td><td align="right" bgcolor="#FFFFFF">9,967 μs</td><td align="right" bgcolor="#FFFFFF">10,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 95,104 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7959,282 ns</td><td align="right" bgcolor="#FFFFFF">8025,053 ns</td><td align="right" bgcolor="#FFFFFF">7935,144 ns</td><td align="right" bgcolor="#FFFFFF">7971,096 ns</td><td align="right" bgcolor="#FFFFFF">7929,949 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,959 μs</td><td align="right" bgcolor="#FFFFFF">8,025 μs</td><td align="right" bgcolor="#FFFFFF">7,935 μs</td><td align="right" bgcolor="#FFFFFF">7,971 μs</td><td align="right" bgcolor="#FFFFFF">7,930 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 88,403 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5951,876 ns</td><td align="right" bgcolor="#FFFFFF">6024,514 ns</td><td align="right" bgcolor="#FFFFFF">5936,112 ns</td><td align="right" bgcolor="#FFFFFF">5957,381 ns</td><td align="right" bgcolor="#FFFFFF">6010,541 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,952 μs</td><td align="right" bgcolor="#FFFFFF">6,025 μs</td><td align="right" bgcolor="#FFFFFF">5,936 μs</td><td align="right" bgcolor="#FFFFFF">5,957 μs</td><td align="right" bgcolor="#FFFFFF">6,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 82,336 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9931,657 ns</td><td align="right" bgcolor="#FFFFFF">9938,412 ns</td><td align="right" bgcolor="#FFFFFF">9902,895 ns</td><td align="right" bgcolor="#FFFFFF">9856,076 ns</td><td align="right" bgcolor="#FFFFFF">9875,189 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,932 μs</td><td align="right" bgcolor="#FFFFFF">9,938 μs</td><td align="right" bgcolor="#FFFFFF">9,903 μs</td><td align="right" bgcolor="#FFFFFF">9,856 μs</td><td align="right" bgcolor="#FFFFFF">9,875 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 196,937 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11759,724 ns</td><td align="right" bgcolor="#FFFFFF">11761,595 ns</td><td align="right" bgcolor="#FFFFFF">11723,417 ns</td><td align="right" bgcolor="#FFFFFF">11578,908 ns</td><td align="right" bgcolor="#FFFFFF">11775,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">11,760 μs</td><td align="right" bgcolor="#FFFFFF">11,762 μs</td><td align="right" bgcolor="#FFFFFF">11,723 μs</td><td align="right" bgcolor="#FFFFFF">11,579 μs</td><td align="right" bgcolor="#FFFFFF">11,776 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 451,781 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4042,418 ns</td><td align="right" bgcolor="#FFFFFF">4206,070 ns</td><td align="right" bgcolor="#FFFFFF">4123,311 ns</td><td align="right" bgcolor="#FFFFFF">3953,660 ns</td><td align="right" bgcolor="#FFFFFF">3754,289 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,042 μs</td><td align="right" bgcolor="#FFFFFF">4,206 μs</td><td align="right" bgcolor="#FFFFFF">4,123 μs</td><td align="right" bgcolor="#FFFFFF">3,954 μs</td><td align="right" bgcolor="#FFFFFF">3,754 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 48,158 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">593,674 ns</td><td align="right" bgcolor="#FFFFFF">590,002 ns</td><td align="right" bgcolor="#FFFFFF">565,863 ns</td><td align="right" bgcolor="#FFFFFF">565,249 ns</td><td align="right" bgcolor="#FFFFFF">545,516 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,594 μs</td><td align="right" bgcolor="#FFFFFF">0,590 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,546 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 72,282 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">666,238 ns</td><td align="right" bgcolor="#FFFFFF">606,591 ns</td><td align="right" bgcolor="#FFFFFF">619,246 ns</td><td align="right" bgcolor="#FFFFFF">617,793 ns</td><td align="right" bgcolor="#FFFFFF">593,956 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,607 μs</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,594 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 17,386 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">436,563 ns</td><td align="right" bgcolor="#FFFFFF">440,737 ns</td><td align="right" bgcolor="#FFFFFF">445,042 ns</td><td align="right" bgcolor="#FFFFFF">444,243 ns</td><td align="right" bgcolor="#FFFFFF">453,950 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,437 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,454 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 0,481 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,440 ns</td><td align="right" bgcolor="#FFFFFF">3,347 ns</td><td align="right" bgcolor="#FFFFFF">2,960 ns</td><td align="right" bgcolor="#FFFFFF">2,975 ns</td><td align="right" bgcolor="#FFFFFF">2,959 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,443 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,972 ns</td><td align="right" bgcolor="#FFFFFF">2,974 ns</td><td align="right" bgcolor="#FFFFFF">2,979 ns</td><td align="right" bgcolor="#FFFFFF">3,023 ns</td><td align="right" bgcolor="#FFFFFF">2,580 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 0,129 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,589 ns</td><td align="right" bgcolor="#FFFFFF">10,672 ns</td><td align="right" bgcolor="#FFFFFF">10,693 ns</td><td align="right" bgcolor="#FFFFFF">10,709 ns</td><td align="right" bgcolor="#FFFFFF">10,718 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 1,077 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,042 ns</td><td align="right" bgcolor="#FFFFFF">3,757 ns</td><td align="right" bgcolor="#FFFFFF">2,965 ns</td><td align="right" bgcolor="#FFFFFF">2,992 ns</td><td align="right" bgcolor="#FFFFFF">2,982 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1,899 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,781 ns</td><td align="right" bgcolor="#FFFFFF">12,214 ns</td><td align="right" bgcolor="#FFFFFF">12,715 ns</td><td align="right" bgcolor="#FFFFFF">12,490 ns</td><td align="right" bgcolor="#FFFFFF">11,882 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 1,026 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,304 ns</td><td align="right" bgcolor="#FFFFFF">3,358 ns</td><td align="right" bgcolor="#FFFFFF">2,939 ns</td><td align="right" bgcolor="#FFFFFF">2,332 ns</td><td align="right" bgcolor="#FFFFFF">2,964 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 8,818 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">73,681 ns</td><td align="right" bgcolor="#FFFFFF">65,785 ns</td><td align="right" bgcolor="#FFFFFF">65,038 ns</td><td align="right" bgcolor="#FFFFFF">64,863 ns</td><td align="right" bgcolor="#FFFFFF">65,019 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 0,453 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,083 ns</td><td align="right" bgcolor="#FFFFFF">3,387 ns</td><td align="right" bgcolor="#FFFFFF">2,960 ns</td><td align="right" bgcolor="#FFFFFF">2,980 ns</td><td align="right" bgcolor="#FFFFFF">2,934 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 0,422 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,758 ns</td><td align="right" bgcolor="#FFFFFF">3,351 ns</td><td align="right" bgcolor="#FFFFFF">3,336 ns</td><td align="right" bgcolor="#FFFFFF">3,492 ns</td><td align="right" bgcolor="#FFFFFF">3,344 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 2,457 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">99,011 ns</td><td align="right" bgcolor="#FFFFFF">99,235 ns</td><td align="right" bgcolor="#FFFFFF">100,366 ns</td><td align="right" bgcolor="#FFFFFF">100,776 ns</td><td align="right" bgcolor="#FFFFFF">98,319 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 0,124 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,026 ns</td><td align="right" bgcolor="#FFFFFF">0,134 ns</td><td align="right" bgcolor="#FFFFFF">0,146 ns</td><td align="right" bgcolor="#FFFFFF">0,149 ns</td><td align="right" bgcolor="#FFFFFF">0,149 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 10,841 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">134,186 ns</td><td align="right" bgcolor="#FFFFFF">124,839 ns</td><td align="right" bgcolor="#FFFFFF">123,346 ns</td><td align="right" bgcolor="#FFFFFF">124,547 ns</td><td align="right" bgcolor="#FFFFFF">123,919 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 4592,016 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-87,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5201,292 ns</td><td align="right" bgcolor="#A8D08D">4858,822 ns (Δ = -342,470 ns)</td><td align="right" bgcolor="#FFFFFF">4936,809 ns</td><td align="right" bgcolor="#FFFFFF">4881,038 ns</td><td align="right" bgcolor="#A8D08D">609,276 ns (Δ = -4271,762 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,201 μs</td><td align="right" bgcolor="#FFFFFF">4,859 μs</td><td align="right" bgcolor="#FFFFFF">4,937 μs</td><td align="right" bgcolor="#FFFFFF">4,881 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 1,578 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,706 ns</td><td align="right" bgcolor="#FFFFFF">29,195 ns</td><td align="right" bgcolor="#FFFFFF">29,227 ns</td><td align="right" bgcolor="#FFFFFF">29,128 ns</td><td align="right" bgcolor="#FFFFFF">29,202 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 33801,945 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4636349,176 ns</td><td align="right" bgcolor="#FFFFFF">4623461,556 ns</td><td align="right" bgcolor="#FFFFFF">4606283,304 ns</td><td align="right" bgcolor="#FFFFFF">4604879,528 ns</td><td align="right" bgcolor="#FFFFFF">4602547,231 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4636,349 μs</td><td align="right" bgcolor="#FFFFFF">4623,462 μs</td><td align="right" bgcolor="#FFFFFF">4606,283 μs</td><td align="right" bgcolor="#FFFFFF">4604,880 μs</td><td align="right" bgcolor="#FFFFFF">4602,547 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">4,636 ms</td><td align="right" bgcolor="#FFFFFF">4,623 ms</td><td align="right" bgcolor="#FFFFFF">4,606 ms</td><td align="right" bgcolor="#FFFFFF">4,605 ms</td><td align="right" bgcolor="#FFFFFF">4,603 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">536,000</td><td align="right" bgcolor="#FF4949">537,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">536,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">536,000</td><td align="right" bgcolor="#FF4949">537,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 36531,613 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">937168,583 ns</td><td align="right" bgcolor="#A8D08D">908005,185 ns (Δ = -29163,398 ns)</td><td align="right" bgcolor="#FFFFFF">905113,204 ns</td><td align="right" bgcolor="#FFFFFF">902797,493 ns</td><td align="right" bgcolor="#FFFFFF">900636,969 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">937,169 μs</td><td align="right" bgcolor="#FFFFFF">908,005 μs</td><td align="right" bgcolor="#FFFFFF">905,113 μs</td><td align="right" bgcolor="#FFFFFF">902,797 μs</td><td align="right" bgcolor="#FFFFFF">900,637 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,937 ms</td><td align="right" bgcolor="#FFFFFF">0,908 ms</td><td align="right" bgcolor="#FFFFFF">0,905 ms</td><td align="right" bgcolor="#FFFFFF">0,903 ms</td><td align="right" bgcolor="#FFFFFF">0,901 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">290,000</td><td align="right" bgcolor="#FFFFFF">290,000</td><td align="right" bgcolor="#FFFFFF">290,000</td><td align="right" bgcolor="#FFFFFF">290,000</td><td align="right" bgcolor="#FF4949">291,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 22447,112 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1311369,273 ns</td><td align="right" bgcolor="#A8D08D">1296682,259 ns (Δ = -14687,014 ns)</td><td align="right" bgcolor="#FFFFFF">1291046,838 ns</td><td align="right" bgcolor="#FFFFFF">1290880,350 ns</td><td align="right" bgcolor="#FFFFFF">1288922,161 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1311,369 μs</td><td align="right" bgcolor="#FFFFFF">1296,682 μs</td><td align="right" bgcolor="#FFFFFF">1291,047 μs</td><td align="right" bgcolor="#FFFFFF">1290,880 μs</td><td align="right" bgcolor="#FFFFFF">1288,922 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,311 ms</td><td align="right" bgcolor="#FFFFFF">1,297 ms</td><td align="right" bgcolor="#FFFFFF">1,291 ms</td><td align="right" bgcolor="#FFFFFF">1,291 ms</td><td align="right" bgcolor="#FFFFFF">1,289 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">315,000</td><td align="right" bgcolor="#A8D08D">314,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">320,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">315,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">314,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 20,389 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">146,201 ns</td><td align="right" bgcolor="#FFFFFF">146,910 ns</td><td align="right" bgcolor="#FFFFFF">155,387 ns</td><td align="right" bgcolor="#FFFFFF">146,910 ns</td><td align="right" bgcolor="#FFFFFF">134,998 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 3,527 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">141,133 ns</td><td align="right" bgcolor="#FFFFFF">144,659 ns</td><td align="right" bgcolor="#FFFFFF">142,016 ns</td><td align="right" bgcolor="#FFFFFF">142,628 ns</td><td align="right" bgcolor="#FFFFFF">141,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 15,046 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,155 ns</td><td align="right" bgcolor="#FFFFFF">91,276 ns</td><td align="right" bgcolor="#FFFFFF">92,642 ns</td><td align="right" bgcolor="#FFFFFF">96,098 ns</td><td align="right" bgcolor="#FFFFFF">81,109 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 222,682 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5581,329 ns</td><td align="right" bgcolor="#FFFFFF">5694,183 ns</td><td align="right" bgcolor="#FFFFFF">5588,190 ns</td><td align="right" bgcolor="#FFFFFF">5505,280 ns</td><td align="right" bgcolor="#FFFFFF">5471,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,581 μs</td><td align="right" bgcolor="#FFFFFF">5,694 μs</td><td align="right" bgcolor="#FFFFFF">5,588 μs</td><td align="right" bgcolor="#FFFFFF">5,505 μs</td><td align="right" bgcolor="#FFFFFF">5,472 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 88,713 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1308,635 ns</td><td align="right" bgcolor="#FFFFFF">1317,345 ns</td><td align="right" bgcolor="#FFFFFF">1291,633 ns</td><td align="right" bgcolor="#FFFFFF">1329,024 ns</td><td align="right" bgcolor="#FFFFFF">1380,346 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,309 μs</td><td align="right" bgcolor="#FFFFFF">1,317 μs</td><td align="right" bgcolor="#FFFFFF">1,292 μs</td><td align="right" bgcolor="#FFFFFF">1,329 μs</td><td align="right" bgcolor="#FFFFFF">1,380 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 139,429 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6776,235 ns</td><td align="right" bgcolor="#FFFFFF">6877,762 ns</td><td align="right" bgcolor="#FFFFFF">6800,718 ns</td><td align="right" bgcolor="#FFFFFF">6915,664 ns</td><td align="right" bgcolor="#FFFFFF">6877,726 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,776 μs</td><td align="right" bgcolor="#FFFFFF">6,878 μs</td><td align="right" bgcolor="#FFFFFF">6,801 μs</td><td align="right" bgcolor="#FFFFFF">6,916 μs</td><td align="right" bgcolor="#FFFFFF">6,878 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 130,554 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5670,608 ns</td><td align="right" bgcolor="#FFFFFF">5644,651 ns</td><td align="right" bgcolor="#FFFFFF">5559,569 ns</td><td align="right" bgcolor="#FFFFFF">5690,123 ns</td><td align="right" bgcolor="#FFFFFF">5614,749 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,671 μs</td><td align="right" bgcolor="#FFFFFF">5,645 μs</td><td align="right" bgcolor="#FFFFFF">5,560 μs</td><td align="right" bgcolor="#FFFFFF">5,690 μs</td><td align="right" bgcolor="#FFFFFF">5,615 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 102,003 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1398,590 ns</td><td align="right" bgcolor="#FFFFFF">1355,360 ns</td><td align="right" bgcolor="#FFFFFF">1296,588 ns</td><td align="right" bgcolor="#FFFFFF">1349,930 ns</td><td align="right" bgcolor="#FFFFFF">1303,764 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,399 μs</td><td align="right" bgcolor="#FFFFFF">1,355 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,350 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 44,389 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1206,409 ns</td><td align="right" bgcolor="#FFFFFF">1185,201 ns</td><td align="right" bgcolor="#FFFFFF">1192,629 ns</td><td align="right" bgcolor="#FFFFFF">1229,590 ns</td><td align="right" bgcolor="#FFFFFF">1227,655 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,206 μs</td><td align="right" bgcolor="#FFFFFF">1,185 μs</td><td align="right" bgcolor="#FFFFFF">1,193 μs</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,228 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 34,873 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">573,471 ns</td><td align="right" bgcolor="#FFFFFF">562,185 ns</td><td align="right" bgcolor="#FFFFFF">576,991 ns</td><td align="right" bgcolor="#FFFFFF">567,918 ns</td><td align="right" bgcolor="#FFFFFF">542,118 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,573 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,577 μs</td><td align="right" bgcolor="#FFFFFF">0,568 μs</td><td align="right" bgcolor="#FFFFFF">0,542 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 6,873 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">181,745 ns</td><td align="right" bgcolor="#FFFFFF">177,484 ns</td><td align="right" bgcolor="#FFFFFF">176,948 ns</td><td align="right" bgcolor="#FFFFFF">177,849 ns</td><td align="right" bgcolor="#FFFFFF">183,821 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 16,163 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">182,788 ns</td><td align="right" bgcolor="#FFFFFF">176,892 ns</td><td align="right" bgcolor="#FFFFFF">177,979 ns</td><td align="right" bgcolor="#FFFFFF">174,990 ns</td><td align="right" bgcolor="#FFFFFF">191,153 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,183 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 37866,523 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">883982,285 ns</td><td align="right" bgcolor="#A8D08D">857837,817 ns (Δ = -26144,468 ns)</td><td align="right" bgcolor="#FFFFFF">858192,769 ns</td><td align="right" bgcolor="#A8D08D">846115,762 ns (Δ = -12077,007 ns)</td><td align="right" bgcolor="#FF4949">860928,278 ns (Δ = +14812,517 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">883,982 μs</td><td align="right" bgcolor="#FFFFFF">857,838 μs</td><td align="right" bgcolor="#FFFFFF">858,193 μs</td><td align="right" bgcolor="#FFFFFF">846,116 μs</td><td align="right" bgcolor="#FFFFFF">860,928 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,884 ms</td><td align="right" bgcolor="#FFFFFF">0,858 ms</td><td align="right" bgcolor="#FFFFFF">0,858 ms</td><td align="right" bgcolor="#FFFFFF">0,846 ms</td><td align="right" bgcolor="#FFFFFF">0,861 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#A8D08D">327,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">327,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 15347,160 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">534364,983 ns</td><td align="right" bgcolor="#FFFFFF">533896,182 ns</td><td align="right" bgcolor="#FFFFFF">534715,458 ns</td><td align="right" bgcolor="#A8D08D">519368,298 ns (Δ = -15347,160 ns)</td><td align="right" bgcolor="#FFFFFF">520081,281 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">534,365 μs</td><td align="right" bgcolor="#FFFFFF">533,896 μs</td><td align="right" bgcolor="#FFFFFF">534,715 μs</td><td align="right" bgcolor="#FFFFFF">519,368 μs</td><td align="right" bgcolor="#FFFFFF">520,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,534 ms</td><td align="right" bgcolor="#FFFFFF">0,534 ms</td><td align="right" bgcolor="#FFFFFF">0,535 ms</td><td align="right" bgcolor="#FFFFFF">0,519 ms</td><td align="right" bgcolor="#FFFFFF">0,520 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#A8D08D">118,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">118,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 17970,675 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">735859,316 ns</td><td align="right" bgcolor="#FFFFFF">733696,303 ns</td><td align="right" bgcolor="#FFFFFF">736309,590 ns</td><td align="right" bgcolor="#A8D08D">721763,679 ns (Δ = -14545,911 ns)</td><td align="right" bgcolor="#FFFFFF">718338,915 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">735,859 μs</td><td align="right" bgcolor="#FFFFFF">733,696 μs</td><td align="right" bgcolor="#FFFFFF">736,310 μs</td><td align="right" bgcolor="#FFFFFF">721,764 μs</td><td align="right" bgcolor="#FFFFFF">718,339 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FFFFFF">0,734 ms</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FFFFFF">0,722 ms</td><td align="right" bgcolor="#FFFFFF">0,718 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">264,000</td><td align="right" bgcolor="#FFFFFF">264,000</td><td align="right" bgcolor="#FFFFFF">264,000</td><td align="right" bgcolor="#A8D08D">260,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">260,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 43061,190 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,3 %</td><td align="right" bgcolor="#FF4949">+1,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1850652,803 ns</td><td align="right" bgcolor="#A8D08D">1807591,613 ns (Δ = -43061,190 ns)</td><td align="right" bgcolor="#FF4949">1826206,846 ns (Δ = +18615,233 ns)</td><td align="right" bgcolor="#FFFFFF">1811663,259 ns</td><td align="right" bgcolor="#FFFFFF">1817985,997 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1850,653 μs</td><td align="right" bgcolor="#FFFFFF">1807,592 μs</td><td align="right" bgcolor="#FFFFFF">1826,207 μs</td><td align="right" bgcolor="#FFFFFF">1811,663 μs</td><td align="right" bgcolor="#FFFFFF">1817,986 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,851 ms</td><td align="right" bgcolor="#FFFFFF">1,808 ms</td><td align="right" bgcolor="#FFFFFF">1,826 ms</td><td align="right" bgcolor="#FFFFFF">1,812 ms</td><td align="right" bgcolor="#FFFFFF">1,818 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#A8D08D">989,000 (Δ = -6,000)</td><td align="right" bgcolor="#FFFFFF">989,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 965151,423 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25894412,547 ns</td><td align="right" bgcolor="#FF4949">26740570,363 ns (Δ = +846157,816 ns)</td><td align="right" bgcolor="#A8D08D">26043944,448 ns (Δ = -696625,915 ns)</td><td align="right" bgcolor="#A8D08D">25775418,940 ns (Δ = -268525,508 ns)</td><td align="right" bgcolor="#FF4949">26250717,707 ns (Δ = +475298,767 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">25894,413 μs</td><td align="right" bgcolor="#FF4949">26740,570 μs (Δ = +846,158 μs)</td><td align="right" bgcolor="#A8D08D">26043,944 μs (Δ = -696,626 μs)</td><td align="right" bgcolor="#A8D08D">25775,419 μs (Δ = -268,526 μs)</td><td align="right" bgcolor="#FF4949">26250,718 μs (Δ = +475,299 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">25,894 ms</td><td align="right" bgcolor="#FFFFFF">26,741 ms</td><td align="right" bgcolor="#FFFFFF">26,044 ms</td><td align="right" bgcolor="#FFFFFF">25,775 ms</td><td align="right" bgcolor="#FFFFFF">26,251 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.6.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4900,000</td><td align="right" bgcolor="#FF4949">4901,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">4912,000 (Δ = +11,000)</td><td align="right" bgcolor="#A8D08D">4902,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">4896,000 (Δ = -6,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#A8D08D">13,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">14,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 60547,452 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1531510,821 ns</td><td align="right" bgcolor="#A8D08D">1511489,059 ns (Δ = -20021,761 ns)</td><td align="right" bgcolor="#FFFFFF">1500868,706 ns</td><td align="right" bgcolor="#A8D08D">1470963,369 ns (Δ = -29905,337 ns)</td><td align="right" bgcolor="#FF4949">1527866,966 ns (Δ = +56903,597 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1531,511 μs</td><td align="right" bgcolor="#FFFFFF">1511,489 μs</td><td align="right" bgcolor="#FFFFFF">1500,869 μs</td><td align="right" bgcolor="#FFFFFF">1470,963 μs</td><td align="right" bgcolor="#FFFFFF">1527,867 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,532 ms</td><td align="right" bgcolor="#FFFFFF">1,511 ms</td><td align="right" bgcolor="#FFFFFF">1,501 ms</td><td align="right" bgcolor="#FFFFFF">1,471 ms</td><td align="right" bgcolor="#FFFFFF">1,528 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">275,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">271,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">271,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 86971,754 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4645687,675 ns</td><td align="right" bgcolor="#FF4949">4722577,668 ns (Δ = +76889,992 ns)</td><td align="right" bgcolor="#A8D08D">4672239,543 ns (Δ = -50338,125 ns)</td><td align="right" bgcolor="#FFFFFF">4635605,913 ns</td><td align="right" bgcolor="#FFFFFF">4637733,783 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4645,688 μs</td><td align="right" bgcolor="#FFFFFF">4722,578 μs</td><td align="right" bgcolor="#FFFFFF">4672,240 μs</td><td align="right" bgcolor="#FFFFFF">4635,606 μs</td><td align="right" bgcolor="#FFFFFF">4637,734 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">4,646 ms</td><td align="right" bgcolor="#FFFFFF">4,723 ms</td><td align="right" bgcolor="#FFFFFF">4,672 ms</td><td align="right" bgcolor="#FFFFFF">4,636 ms</td><td align="right" bgcolor="#FFFFFF">4,638 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">883,000</td><td align="right" bgcolor="#FFFFFF">883,000</td><td align="right" bgcolor="#FF4949">887,000 (Δ = +4,000)</td><td align="right" bgcolor="#A8D08D">882,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">882,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 752772,893 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20735741,326 ns</td><td align="right" bgcolor="#FF4949">21257616,531 ns (Δ = +521875,205 ns)</td><td align="right" bgcolor="#A8D08D">20662593,588 ns (Δ = -595022,944 ns)</td><td align="right" bgcolor="#FFFFFF">20504843,638 ns</td><td align="right" bgcolor="#FF4949">20809338,214 ns (Δ = +304494,576 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20735,741 μs</td><td align="right" bgcolor="#FF4949">21257,617 μs (Δ = +521,875 μs)</td><td align="right" bgcolor="#A8D08D">20662,594 μs (Δ = -595,023 μs)</td><td align="right" bgcolor="#FFFFFF">20504,844 μs</td><td align="right" bgcolor="#FF4949">20809,338 μs (Δ = +304,495 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">20,736 ms</td><td align="right" bgcolor="#FFFFFF">21,258 ms</td><td align="right" bgcolor="#FFFFFF">20,663 ms</td><td align="right" bgcolor="#FFFFFF">20,505 ms</td><td align="right" bgcolor="#FFFFFF">20,809 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3931,000</td><td align="right" bgcolor="#FFFFFF">3931,000</td><td align="right" bgcolor="#FF4949">3954,000 (Δ = +23,000)</td><td align="right" bgcolor="#A8D08D">3932,000 (Δ = -22,000)</td><td align="right" bgcolor="#FF4949">3936,000 (Δ = +4,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 79404,237 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1886740,215 ns</td><td align="right" bgcolor="#FFFFFF">1886743,783 ns</td><td align="right" bgcolor="#FFFFFF">1896079,614 ns</td><td align="right" bgcolor="#FFFFFF">1905298,767 ns</td><td align="right" bgcolor="#FF4949">1966144,451 ns (Δ = +60845,685 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1886,740 μs</td><td align="right" bgcolor="#FFFFFF">1886,744 μs</td><td align="right" bgcolor="#FFFFFF">1896,080 μs</td><td align="right" bgcolor="#FFFFFF">1905,299 μs</td><td align="right" bgcolor="#FFFFFF">1966,144 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,887 ms</td><td align="right" bgcolor="#FFFFFF">1,887 ms</td><td align="right" bgcolor="#FFFFFF">1,896 ms</td><td align="right" bgcolor="#FFFFFF">1,905 ms</td><td align="right" bgcolor="#FFFFFF">1,966 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.5.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1850,000</td><td align="right" bgcolor="#FFFFFF">1850,000</td><td align="right" bgcolor="#FFFFFF">1850,000</td><td align="right" bgcolor="#FF4949">1874,000 (Δ = +24,000)</td><td align="right" bgcolor="#FFFFFF">1874,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 15476,325 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+2,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">670883,764 ns</td><td align="right" bgcolor="#FFFFFF">667135,154 ns</td><td align="right" bgcolor="#FFFFFF">672812,733 ns</td><td align="right" bgcolor="#A8D08D">665765,330 ns (Δ = -7047,403 ns)</td><td align="right" bgcolor="#FF4949">681241,654 ns (Δ = +15476,325 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">670,884 μs</td><td align="right" bgcolor="#FFFFFF">667,135 μs</td><td align="right" bgcolor="#FFFFFF">672,813 μs</td><td align="right" bgcolor="#FFFFFF">665,765 μs</td><td align="right" bgcolor="#FFFFFF">681,242 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,671 ms</td><td align="right" bgcolor="#FFFFFF">0,667 ms</td><td align="right" bgcolor="#FFFFFF">0,673 ms</td><td align="right" bgcolor="#FFFFFF">0,666 ms</td><td align="right" bgcolor="#FFFFFF">0,681 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.5.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">437,000</td><td align="right" bgcolor="#A8D08D">436,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">436,000</td><td align="right" bgcolor="#FF4949">438,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">438,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 76630,769 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,2 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1255329,712 ns</td><td align="right" bgcolor="#FFFFFF">1262685,257 ns</td><td align="right" bgcolor="#FFFFFF">1257781,296 ns</td><td align="right" bgcolor="#FF4949">1285231,230 ns (Δ = +27449,933 ns)</td><td align="right" bgcolor="#FF4949">1331960,480 ns (Δ = +46729,251 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1255,330 μs</td><td align="right" bgcolor="#FFFFFF">1262,685 μs</td><td align="right" bgcolor="#FFFFFF">1257,781 μs</td><td align="right" bgcolor="#FFFFFF">1285,231 μs</td><td align="right" bgcolor="#FFFFFF">1331,960 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,255 ms</td><td align="right" bgcolor="#FFFFFF">1,263 ms</td><td align="right" bgcolor="#FFFFFF">1,258 ms</td><td align="right" bgcolor="#FFFFFF">1,285 ms</td><td align="right" bgcolor="#FFFFFF">1,332 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.5.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1379,000</td><td align="right" bgcolor="#FFFFFF">1379,000</td><td align="right" bgcolor="#FFFFFF">1379,000</td><td align="right" bgcolor="#FF4949">1390,000 (Δ = +11,000)</td><td align="right" bgcolor="#FF4949">1391,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 221864,371 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4392771,498 ns</td><td align="right" bgcolor="#FFFFFF">4416454,576 ns</td><td align="right" bgcolor="#A8D08D">4370556,174 ns (Δ = -45898,401 ns)</td><td align="right" bgcolor="#FF4949">4577597,152 ns (Δ = +207040,978 ns)</td><td align="right" bgcolor="#FFFFFF">4592420,545 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4392,771 μs</td><td align="right" bgcolor="#FFFFFF">4416,455 μs</td><td align="right" bgcolor="#FFFFFF">4370,556 μs</td><td align="right" bgcolor="#FFFFFF">4577,597 μs</td><td align="right" bgcolor="#FFFFFF">4592,421 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">4,393 ms</td><td align="right" bgcolor="#FFFFFF">4,416 ms</td><td align="right" bgcolor="#FFFFFF">4,371 ms</td><td align="right" bgcolor="#FFFFFF">4,578 ms</td><td align="right" bgcolor="#FFFFFF">4,592 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">6058,000</td><td align="right" bgcolor="#A8D08D">6057,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">6058,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">6144,000 (Δ = +86,000)</td><td align="right" bgcolor="#A8D08D">6143,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 406,299 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1312,765 ns</td><td align="right" bgcolor="#FFFFFF">1389,135 ns</td><td align="right" bgcolor="#FFFFFF">1261,470 ns</td><td align="right" bgcolor="#FFFFFF">1458,276 ns</td><td align="right" bgcolor="#FFFFFF">1667,769 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,313 μs</td><td align="right" bgcolor="#FFFFFF">1,389 μs</td><td align="right" bgcolor="#FFFFFF">1,261 μs</td><td align="right" bgcolor="#FFFFFF">1,458 μs</td><td align="right" bgcolor="#FFFFFF">1,668 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 36,176 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">267,468 ns</td><td align="right" bgcolor="#FFFFFF">249,892 ns</td><td align="right" bgcolor="#FFFFFF">249,118 ns</td><td align="right" bgcolor="#FFFFFF">231,292 ns</td><td align="right" bgcolor="#FFFFFF">231,305 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,250 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 282,287 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4961,049 ns</td><td align="right" bgcolor="#FFFFFF">4822,245 ns</td><td align="right" bgcolor="#FFFFFF">4773,635 ns</td><td align="right" bgcolor="#FFFFFF">4859,065 ns</td><td align="right" bgcolor="#FFFFFF">4678,762 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,961 μs</td><td align="right" bgcolor="#FFFFFF">4,822 μs</td><td align="right" bgcolor="#FFFFFF">4,774 μs</td><td align="right" bgcolor="#FFFFFF">4,859 μs</td><td align="right" bgcolor="#FFFFFF">4,679 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 34,802 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">261,610 ns</td><td align="right" bgcolor="#FFFFFF">247,881 ns</td><td align="right" bgcolor="#FFFFFF">247,775 ns</td><td align="right" bgcolor="#FFFFFF">226,808 ns</td><td align="right" bgcolor="#FFFFFF">234,175 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,262 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 313,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9892,956 ns</td><td align="right" bgcolor="#FFFFFF">9660,759 ns</td><td align="right" bgcolor="#FFFFFF">9833,431 ns</td><td align="right" bgcolor="#FFFFFF">9772,600 ns</td><td align="right" bgcolor="#FFFFFF">9579,297 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,893 μs</td><td align="right" bgcolor="#FFFFFF">9,661 μs</td><td align="right" bgcolor="#FFFFFF">9,833 μs</td><td align="right" bgcolor="#FFFFFF">9,773 μs</td><td align="right" bgcolor="#FFFFFF">9,579 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 0,455 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,451 ns</td><td align="right" bgcolor="#FFFFFF">13,423 ns</td><td align="right" bgcolor="#FFFFFF">13,442 ns</td><td align="right" bgcolor="#FFFFFF">13,016 ns</td><td align="right" bgcolor="#FFFFFF">13,471 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 26687,818 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-94,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28177,124 ns</td><td align="right" bgcolor="#FFFFFF">28151,952 ns</td><td align="right" bgcolor="#FFFFFF">28155,304 ns</td><td align="right" bgcolor="#FFFFFF">28368,740 ns</td><td align="right" bgcolor="#A8D08D">1680,923 ns (Δ = -26687,818 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">28,177 μs</td><td align="right" bgcolor="#FFFFFF">28,152 μs</td><td align="right" bgcolor="#FFFFFF">28,155 μs</td><td align="right" bgcolor="#FFFFFF">28,369 μs</td><td align="right" bgcolor="#FFFFFF">1,681 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -34,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1,448 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,703 ns</td><td align="right" bgcolor="#FFFFFF">37,698 ns</td><td align="right" bgcolor="#FFFFFF">37,683 ns</td><td align="right" bgcolor="#FFFFFF">37,119 ns</td><td align="right" bgcolor="#FFFFFF">36,255 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 3,708 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,317 ns</td><td align="right" bgcolor="#FFFFFF">28,354 ns</td><td align="right" bgcolor="#FFFFFF">26,469 ns</td><td align="right" bgcolor="#FFFFFF">26,442 ns</td><td align="right" bgcolor="#FFFFFF">30,026 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 2,043 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,347 ns</td><td align="right" bgcolor="#FFFFFF">29,554 ns</td><td align="right" bgcolor="#FFFFFF">29,417 ns</td><td align="right" bgcolor="#FFFFFF">30,582 ns</td><td align="right" bgcolor="#FFFFFF">31,460 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 3,858 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,242 ns</td><td align="right" bgcolor="#FFFFFF">39,059 ns</td><td align="right" bgcolor="#FFFFFF">39,061 ns</td><td align="right" bgcolor="#FFFFFF">39,100 ns</td><td align="right" bgcolor="#FFFFFF">38,840 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 15,772 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">375,328 ns</td><td align="right" bgcolor="#FFFFFF">359,557 ns</td><td align="right" bgcolor="#FFFFFF">361,383 ns</td><td align="right" bgcolor="#FFFFFF">362,292 ns</td><td align="right" bgcolor="#FFFFFF">360,391 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,375 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,362 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 3,571 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">106,311 ns</td><td align="right" bgcolor="#FFFFFF">108,907 ns</td><td align="right" bgcolor="#FFFFFF">107,606 ns</td><td align="right" bgcolor="#FFFFFF">106,610 ns</td><td align="right" bgcolor="#FFFFFF">109,881 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 172,596 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4998,420 ns</td><td align="right" bgcolor="#FFFFFF">4831,043 ns</td><td align="right" bgcolor="#FFFFFF">4969,729 ns</td><td align="right" bgcolor="#FFFFFF">5003,639 ns</td><td align="right" bgcolor="#FFFFFF">4954,696 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,998 μs</td><td align="right" bgcolor="#FFFFFF">4,831 μs</td><td align="right" bgcolor="#FFFFFF">4,970 μs</td><td align="right" bgcolor="#FFFFFF">5,004 μs</td><td align="right" bgcolor="#FFFFFF">4,955 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 2657,057 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15398,562 ns</td><td align="right" bgcolor="#FFFFFF">15193,858 ns</td><td align="right" bgcolor="#FFFFFF">15244,697 ns</td><td align="right" bgcolor="#FFFFFF">15453,522 ns</td><td align="right" bgcolor="#A8D08D">12796,465 ns (Δ = -2657,057 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15,399 μs</td><td align="right" bgcolor="#FFFFFF">15,194 μs</td><td align="right" bgcolor="#FFFFFF">15,245 μs</td><td align="right" bgcolor="#FFFFFF">15,454 μs</td><td align="right" bgcolor="#FFFFFF">12,796 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 127,299 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4928,408 ns</td><td align="right" bgcolor="#FFFFFF">4920,709 ns</td><td align="right" bgcolor="#FFFFFF">4950,522 ns</td><td align="right" bgcolor="#FFFFFF">4823,223 ns</td><td align="right" bgcolor="#FFFFFF">4890,125 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,928 μs</td><td align="right" bgcolor="#FFFFFF">4,921 μs</td><td align="right" bgcolor="#FFFFFF">4,951 μs</td><td align="right" bgcolor="#FFFFFF">4,823 μs</td><td align="right" bgcolor="#FFFFFF">4,890 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 2773,925 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15372,155 ns</td><td align="right" bgcolor="#FFFFFF">15251,617 ns</td><td align="right" bgcolor="#FFFFFF">15248,213 ns</td><td align="right" bgcolor="#FFFFFF">15356,459 ns</td><td align="right" bgcolor="#A8D08D">12598,229 ns (Δ = -2758,230 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15,372 μs</td><td align="right" bgcolor="#FFFFFF">15,252 μs</td><td align="right" bgcolor="#FFFFFF">15,248 μs</td><td align="right" bgcolor="#FFFFFF">15,356 μs</td><td align="right" bgcolor="#FFFFFF">12,598 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 3,819 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,299 ns</td><td align="right" bgcolor="#FFFFFF">13,119 ns</td><td align="right" bgcolor="#FFFFFF">12,683 ns</td><td align="right" bgcolor="#FFFFFF">12,865 ns</td><td align="right" bgcolor="#FFFFFF">11,305 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 104,035 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">994,970 ns</td><td align="right" bgcolor="#FFFFFF">994,746 ns</td><td align="right" bgcolor="#FFFFFF">890,935 ns</td><td align="right" bgcolor="#FFFFFF">903,055 ns</td><td align="right" bgcolor="#FFFFFF">909,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,903 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 22,889 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,197 ns</td><td align="right" bgcolor="#FFFFFF">134,056 ns</td><td align="right" bgcolor="#FFFFFF">129,442 ns</td><td align="right" bgcolor="#FFFFFF">141,420 ns</td><td align="right" bgcolor="#FFFFFF">118,531 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 84,253 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3135,543 ns</td><td align="right" bgcolor="#FFFFFF">3162,010 ns</td><td align="right" bgcolor="#FFFFFF">3201,621 ns</td><td align="right" bgcolor="#FFFFFF">3191,503 ns</td><td align="right" bgcolor="#FFFFFF">3117,367 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,136 μs</td><td align="right" bgcolor="#FFFFFF">3,162 μs</td><td align="right" bgcolor="#FFFFFF">3,202 μs</td><td align="right" bgcolor="#FFFFFF">3,192 μs</td><td align="right" bgcolor="#FFFFFF">3,117 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 144,238 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1425,729 ns</td><td align="right" bgcolor="#FFFFFF">1409,100 ns</td><td align="right" bgcolor="#FFFFFF">1453,568 ns</td><td align="right" bgcolor="#FFFFFF">1347,851 ns</td><td align="right" bgcolor="#FFFFFF">1309,329 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,426 μs</td><td align="right" bgcolor="#FFFFFF">1,409 μs</td><td align="right" bgcolor="#FFFFFF">1,454 μs</td><td align="right" bgcolor="#FFFFFF">1,348 μs</td><td align="right" bgcolor="#FFFFFF">1,309 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 14,127 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">570,558 ns</td><td align="right" bgcolor="#FFFFFF">572,320 ns</td><td align="right" bgcolor="#FFFFFF">575,290 ns</td><td align="right" bgcolor="#FFFFFF">584,685 ns</td><td align="right" bgcolor="#FFFFFF">572,924 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,572 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,573 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 105,544 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1011,182 ns</td><td align="right" bgcolor="#FFFFFF">986,483 ns</td><td align="right" bgcolor="#FFFFFF">905,639 ns</td><td align="right" bgcolor="#FFFFFF">951,857 ns</td><td align="right" bgcolor="#FFFFFF">967,054 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,011 μs</td><td align="right" bgcolor="#FFFFFF">0,986 μs</td><td align="right" bgcolor="#FFFFFF">0,906 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,967 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 16,643 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">132,052 ns</td><td align="right" bgcolor="#FFFFFF">125,949 ns</td><td align="right" bgcolor="#FFFFFF">127,919 ns</td><td align="right" bgcolor="#FFFFFF">127,819 ns</td><td align="right" bgcolor="#FFFFFF">115,409 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 23,290 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">135,764 ns</td><td align="right" bgcolor="#FFFFFF">136,379 ns</td><td align="right" bgcolor="#FFFFFF">139,848 ns</td><td align="right" bgcolor="#FFFFFF">146,426 ns</td><td align="right" bgcolor="#FFFFFF">123,135 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 14,874 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">123,956 ns</td><td align="right" bgcolor="#FFFFFF">127,884 ns</td><td align="right" bgcolor="#FFFFFF">131,700 ns</td><td align="right" bgcolor="#FFFFFF">126,701 ns</td><td align="right" bgcolor="#FFFFFF">116,825 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 77,137 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">810,549 ns</td><td align="right" bgcolor="#FFFFFF">867,429 ns</td><td align="right" bgcolor="#FFFFFF">854,189 ns</td><td align="right" bgcolor="#FFFFFF">821,561 ns</td><td align="right" bgcolor="#FFFFFF">887,686 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,811 μs</td><td align="right" bgcolor="#FFFFFF">0,867 μs</td><td align="right" bgcolor="#FFFFFF">0,854 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 11,566 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">118,425 ns</td><td align="right" bgcolor="#FFFFFF">128,310 ns</td><td align="right" bgcolor="#FFFFFF">129,736 ns</td><td align="right" bgcolor="#FFFFFF">129,991 ns</td><td align="right" bgcolor="#FFFFFF">128,301 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 97,936 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1237,633 ns</td><td align="right" bgcolor="#FFFFFF">1335,568 ns</td><td align="right" bgcolor="#FFFFFF">1304,339 ns</td><td align="right" bgcolor="#FFFFFF">1252,275 ns</td><td align="right" bgcolor="#FFFFFF">1262,683 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,238 μs</td><td align="right" bgcolor="#FFFFFF">1,336 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td><td align="right" bgcolor="#FFFFFF">1,252 μs</td><td align="right" bgcolor="#FFFFFF">1,263 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 5,009 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,062 ns</td><td align="right" bgcolor="#FFFFFF">128,734 ns</td><td align="right" bgcolor="#FFFFFF">127,624 ns</td><td align="right" bgcolor="#FFFFFF">132,071 ns</td><td align="right" bgcolor="#FFFFFF">128,337 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 4,964 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">228,495 ns</td><td align="right" bgcolor="#FFFFFF">230,623 ns</td><td align="right" bgcolor="#FFFFFF">231,504 ns</td><td align="right" bgcolor="#FFFFFF">233,459 ns</td><td align="right" bgcolor="#FFFFFF">229,314 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 5,707 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,970 ns</td><td align="right" bgcolor="#FFFFFF">140,996 ns</td><td align="right" bgcolor="#FFFFFF">143,642 ns</td><td align="right" bgcolor="#FFFFFF">140,469 ns</td><td align="right" bgcolor="#FFFFFF">137,935 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 15,069 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,634 ns</td><td align="right" bgcolor="#FFFFFF">207,703 ns</td><td align="right" bgcolor="#FFFFFF">199,368 ns</td><td align="right" bgcolor="#FFFFFF">194,271 ns</td><td align="right" bgcolor="#FFFFFF">205,138 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 94,678 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1834,723 ns</td><td align="right" bgcolor="#FFFFFF">1766,239 ns</td><td align="right" bgcolor="#FFFFFF">1810,720 ns</td><td align="right" bgcolor="#FFFFFF">1860,917 ns</td><td align="right" bgcolor="#FFFFFF">1776,980 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,835 μs</td><td align="right" bgcolor="#FFFFFF">1,766 μs</td><td align="right" bgcolor="#FFFFFF">1,811 μs</td><td align="right" bgcolor="#FFFFFF">1,861 μs</td><td align="right" bgcolor="#FFFFFF">1,777 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 71,767 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">842,985 ns</td><td align="right" bgcolor="#FFFFFF">908,979 ns</td><td align="right" bgcolor="#FFFFFF">889,312 ns</td><td align="right" bgcolor="#FFFFFF">906,333 ns</td><td align="right" bgcolor="#FFFFFF">837,212 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,909 μs</td><td align="right" bgcolor="#FFFFFF">0,889 μs</td><td align="right" bgcolor="#FFFFFF">0,906 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 116,276 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">965,638 ns</td><td align="right" bgcolor="#FFFFFF">989,564 ns</td><td align="right" bgcolor="#FFFFFF">935,717 ns</td><td align="right" bgcolor="#FFFFFF">978,852 ns</td><td align="right" bgcolor="#FFFFFF">873,287 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,966 μs</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,873 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 75,816 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">892,181 ns</td><td align="right" bgcolor="#FFFFFF">816,365 ns</td><td align="right" bgcolor="#FFFFFF">866,947 ns</td><td align="right" bgcolor="#FFFFFF">886,375 ns</td><td align="right" bgcolor="#FFFFFF">837,694 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">0,816 μs</td><td align="right" bgcolor="#FFFFFF">0,867 μs</td><td align="right" bgcolor="#FFFFFF">0,886 μs</td><td align="right" bgcolor="#FFFFFF">0,838 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 114,247 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">962,989 ns</td><td align="right" bgcolor="#FFFFFF">986,375 ns</td><td align="right" bgcolor="#FFFFFF">1012,024 ns</td><td align="right" bgcolor="#FFFFFF">1007,620 ns</td><td align="right" bgcolor="#FFFFFF">897,777 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,963 μs</td><td align="right" bgcolor="#FFFFFF">0,986 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">0,898 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 20,435 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">158,259 ns</td><td align="right" bgcolor="#FFFFFF">151,981 ns</td><td align="right" bgcolor="#FFFFFF">155,047 ns</td><td align="right" bgcolor="#FFFFFF">155,553 ns</td><td align="right" bgcolor="#FFFFFF">137,824 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 20,332 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,267 ns</td><td align="right" bgcolor="#FFFFFF">165,844 ns</td><td align="right" bgcolor="#FFFFFF">167,291 ns</td><td align="right" bgcolor="#FFFFFF">171,201 ns</td><td align="right" bgcolor="#FFFFFF">150,869 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 13,508 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">149,009 ns</td><td align="right" bgcolor="#FFFFFF">150,717 ns</td><td align="right" bgcolor="#FFFFFF">154,323 ns</td><td align="right" bgcolor="#FFFFFF">154,505 ns</td><td align="right" bgcolor="#FFFFFF">140,996 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 5640,141 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13007,879 ns</td><td align="right" bgcolor="#FFFFFF">13196,301 ns</td><td align="right" bgcolor="#FFFFFF">13151,306 ns</td><td align="right" bgcolor="#FFFFFF">13170,012 ns</td><td align="right" bgcolor="#A8D08D">7556,160 ns (Δ = -5613,852 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,008 μs</td><td align="right" bgcolor="#FFFFFF">13,196 μs</td><td align="right" bgcolor="#FFFFFF">13,151 μs</td><td align="right" bgcolor="#FFFFFF">13,170 μs</td><td align="right" bgcolor="#FFFFFF">7,556 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 69,587 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1325,983 ns</td><td align="right" bgcolor="#FFFFFF">1324,840 ns</td><td align="right" bgcolor="#FFFFFF">1342,451 ns</td><td align="right" bgcolor="#FFFFFF">1348,631 ns</td><td align="right" bgcolor="#FFFFFF">1394,428 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,326 μs</td><td align="right" bgcolor="#FFFFFF">1,325 μs</td><td align="right" bgcolor="#FFFFFF">1,342 μs</td><td align="right" bgcolor="#FFFFFF">1,349 μs</td><td align="right" bgcolor="#FFFFFF">1,394 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 5586,404 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12343,994 ns</td><td align="right" bgcolor="#FFFFFF">12537,503 ns</td><td align="right" bgcolor="#FFFFFF">12516,457 ns</td><td align="right" bgcolor="#FFFFFF">12425,336 ns</td><td align="right" bgcolor="#A8D08D">6951,099 ns (Δ = -5474,237 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,344 μs</td><td align="right" bgcolor="#FFFFFF">12,538 μs</td><td align="right" bgcolor="#FFFFFF">12,516 μs</td><td align="right" bgcolor="#FFFFFF">12,425 μs</td><td align="right" bgcolor="#FFFFFF">6,951 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FF4949">11,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 65,750 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1309,808 ns</td><td align="right" bgcolor="#FFFFFF">1373,842 ns</td><td align="right" bgcolor="#FFFFFF">1328,156 ns</td><td align="right" bgcolor="#FFFFFF">1308,092 ns</td><td align="right" bgcolor="#FFFFFF">1360,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,310 μs</td><td align="right" bgcolor="#FFFFFF">1,374 μs</td><td align="right" bgcolor="#FFFFFF">1,328 μs</td><td align="right" bgcolor="#FFFFFF">1,308 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 59,636 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">977,195 ns</td><td align="right" bgcolor="#FFFFFF">976,210 ns</td><td align="right" bgcolor="#FFFFFF">978,796 ns</td><td align="right" bgcolor="#FFFFFF">1015,813 ns</td><td align="right" bgcolor="#FFFFFF">956,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,977 μs</td><td align="right" bgcolor="#FFFFFF">0,976 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">1,016 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 2849,014 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-60,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4593,289 ns</td><td align="right" bgcolor="#FFFFFF">4547,447 ns</td><td align="right" bgcolor="#FFFFFF">4429,905 ns</td><td align="right" bgcolor="#FFFFFF">4403,808 ns</td><td align="right" bgcolor="#A8D08D">1744,275 ns (Δ = -2659,533 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,593 μs</td><td align="right" bgcolor="#FFFFFF">4,547 μs</td><td align="right" bgcolor="#FFFFFF">4,430 μs</td><td align="right" bgcolor="#FFFFFF">4,404 μs</td><td align="right" bgcolor="#FFFFFF">1,744 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 2959,000 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-73,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3835,661 ns</td><td align="right" bgcolor="#FFFFFF">3959,036 ns</td><td align="right" bgcolor="#FFFFFF">3781,060 ns</td><td align="right" bgcolor="#FFFFFF">3804,413 ns</td><td align="right" bgcolor="#A8D08D">1000,036 ns (Δ = -2804,377 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,836 μs</td><td align="right" bgcolor="#FFFFFF">3,959 μs</td><td align="right" bgcolor="#FFFFFF">3,781 μs</td><td align="right" bgcolor="#FFFFFF">3,804 μs</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 5,101 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">199,751 ns</td><td align="right" bgcolor="#FFFFFF">198,438 ns</td><td align="right" bgcolor="#FFFFFF">194,649 ns</td><td align="right" bgcolor="#FFFFFF">196,560 ns</td><td align="right" bgcolor="#FFFFFF">199,518 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 86,522 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">997,111 ns</td><td align="right" bgcolor="#FFFFFF">965,117 ns</td><td align="right" bgcolor="#FFFFFF">910,589 ns</td><td align="right" bgcolor="#FFFFFF">951,848 ns</td><td align="right" bgcolor="#FFFFFF">924,732 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,997 μs</td><td align="right" bgcolor="#FFFFFF">0,965 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,925 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 21,462 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">166,341 ns</td><td align="right" bgcolor="#FFFFFF">170,284 ns</td><td align="right" bgcolor="#FFFFFF">169,192 ns</td><td align="right" bgcolor="#FFFFFF">171,735 ns</td><td align="right" bgcolor="#FFFFFF">150,273 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 167,636 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3270,734 ns</td><td align="right" bgcolor="#FFFFFF">3233,393 ns</td><td align="right" bgcolor="#FFFFFF">3280,567 ns</td><td align="right" bgcolor="#FFFFFF">3341,322 ns</td><td align="right" bgcolor="#FFFFFF">3173,686 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,271 μs</td><td align="right" bgcolor="#FFFFFF">3,233 μs</td><td align="right" bgcolor="#FFFFFF">3,281 μs</td><td align="right" bgcolor="#FFFFFF">3,341 μs</td><td align="right" bgcolor="#FFFFFF">3,174 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 19,756 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">271,792 ns</td><td align="right" bgcolor="#FFFFFF">271,567 ns</td><td align="right" bgcolor="#FFFFFF">273,635 ns</td><td align="right" bgcolor="#FFFFFF">271,314 ns</td><td align="right" bgcolor="#FFFFFF">291,070 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,143 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,117 ns</td><td align="right" bgcolor="#FFFFFF">16,186 ns</td><td align="right" bgcolor="#FFFFFF">16,011 ns</td><td align="right" bgcolor="#FFFFFF">16,260 ns</td><td align="right" bgcolor="#FFFFFF">16,103 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 9,697 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,823 ns</td><td align="right" bgcolor="#FFFFFF">53,520 ns</td><td align="right" bgcolor="#FFFFFF">47,051 ns</td><td align="right" bgcolor="#FFFFFF">48,987 ns</td><td align="right" bgcolor="#FFFFFF">52,380 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 10,237 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,752 ns</td><td align="right" bgcolor="#FFFFFF">53,166 ns</td><td align="right" bgcolor="#FFFFFF">53,008 ns</td><td align="right" bgcolor="#FFFFFF">53,084 ns</td><td align="right" bgcolor="#FFFFFF">58,989 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 10,319 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,772 ns</td><td align="right" bgcolor="#FFFFFF">43,975 ns</td><td align="right" bgcolor="#FFFFFF">47,016 ns</td><td align="right" bgcolor="#FFFFFF">51,218 ns</td><td align="right" bgcolor="#FFFFFF">54,295 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 2,437 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,529 ns</td><td align="right" bgcolor="#FFFFFF">24,746 ns</td><td align="right" bgcolor="#FFFFFF">24,965 ns</td><td align="right" bgcolor="#FFFFFF">24,861 ns</td><td align="right" bgcolor="#FFFFFF">24,689 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 2,019 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,874 ns</td><td align="right" bgcolor="#FFFFFF">32,417 ns</td><td align="right" bgcolor="#FFFFFF">32,497 ns</td><td align="right" bgcolor="#FFFFFF">32,893 ns</td><td align="right" bgcolor="#FFFFFF">32,661 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,832 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,510 ns</td><td align="right" bgcolor="#FFFFFF">38,056 ns</td><td align="right" bgcolor="#FFFFFF">36,989 ns</td><td align="right" bgcolor="#FFFFFF">38,821 ns</td><td align="right" bgcolor="#FFFFFF">38,369 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 26,310 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">634,280 ns</td><td align="right" bgcolor="#FFFFFF">616,185 ns</td><td align="right" bgcolor="#FFFFFF">617,571 ns</td><td align="right" bgcolor="#FFFFFF">642,495 ns</td><td align="right" bgcolor="#FFFFFF">618,381 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,634 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 40,479 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">204,849 ns</td><td align="right" bgcolor="#FFFFFF">245,328 ns</td><td align="right" bgcolor="#FFFFFF">221,333 ns</td><td align="right" bgcolor="#FFFFFF">223,376 ns</td><td align="right" bgcolor="#FFFFFF">212,179 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 2,787 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,249 ns</td><td align="right" bgcolor="#FFFFFF">38,928 ns</td><td align="right" bgcolor="#FFFFFF">38,939 ns</td><td align="right" bgcolor="#FFFFFF">39,036 ns</td><td align="right" bgcolor="#FFFFFF">37,936 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,450 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,472 ns</td><td align="right" bgcolor="#FFFFFF">40,022 ns</td><td align="right" bgcolor="#FFFFFF">40,544 ns</td><td align="right" bgcolor="#FFFFFF">41,298 ns</td><td align="right" bgcolor="#FFFFFF">40,505 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 0,494 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,277 ns</td><td align="right" bgcolor="#FFFFFF">11,230 ns</td><td align="right" bgcolor="#FFFFFF">10,844 ns</td><td align="right" bgcolor="#FFFFFF">11,236 ns</td><td align="right" bgcolor="#FFFFFF">11,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 2,054 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,347 ns</td><td align="right" bgcolor="#FFFFFF">12,090 ns</td><td align="right" bgcolor="#FFFFFF">12,158 ns</td><td align="right" bgcolor="#FFFFFF">12,108 ns</td><td align="right" bgcolor="#FFFFFF">12,401 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 2737,078 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32890,459 ns</td><td align="right" bgcolor="#FFFFFF">32812,873 ns</td><td align="right" bgcolor="#FFFFFF">32572,844 ns</td><td align="right" bgcolor="#FFFFFF">32746,315 ns</td><td align="right" bgcolor="#FF4949">35309,923 ns (Δ = +2563,608 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">32,890 μs</td><td align="right" bgcolor="#FFFFFF">32,813 μs</td><td align="right" bgcolor="#FFFFFF">32,573 μs</td><td align="right" bgcolor="#FFFFFF">32,746 μs</td><td align="right" bgcolor="#FFFFFF">35,310 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,334 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,363 ns</td><td align="right" bgcolor="#FFFFFF">13,342 ns</td><td align="right" bgcolor="#FFFFFF">13,502 ns</td><td align="right" bgcolor="#FFFFFF">13,621 ns</td><td align="right" bgcolor="#FFFFFF">13,287 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 5,147 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,934 ns</td><td align="right" bgcolor="#FFFFFF">25,705 ns</td><td align="right" bgcolor="#FFFFFF">22,587 ns</td><td align="right" bgcolor="#FFFFFF">27,082 ns</td><td align="right" bgcolor="#FFFFFF">25,491 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 0,414 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,107 ns</td><td align="right" bgcolor="#FFFFFF">18,103 ns</td><td align="right" bgcolor="#FFFFFF">18,112 ns</td><td align="right" bgcolor="#FFFFFF">18,518 ns</td><td align="right" bgcolor="#FFFFFF">18,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 4,448 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,500 ns</td><td align="right" bgcolor="#FFFFFF">23,793 ns</td><td align="right" bgcolor="#FFFFFF">22,523 ns</td><td align="right" bgcolor="#FFFFFF">25,914 ns</td><td align="right" bgcolor="#FFFFFF">25,948 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 6,459 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,263 ns</td><td align="right" bgcolor="#FFFFFF">26,371 ns</td><td align="right" bgcolor="#FFFFFF">25,107 ns</td><td align="right" bgcolor="#FFFFFF">28,722 ns</td><td align="right" bgcolor="#FFFFFF">27,134 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 1,805 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">50,275 ns</td><td align="right" bgcolor="#FFFFFF">50,395 ns</td><td align="right" bgcolor="#FFFFFF">51,670 ns</td><td align="right" bgcolor="#FFFFFF">49,865 ns</td><td align="right" bgcolor="#FFFFFF">50,307 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 855,913 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1382,669 ns</td><td align="right" bgcolor="#A8D08D">613,056 ns (Δ = -769,613 ns)</td><td align="right" bgcolor="#FFFFFF">619,041 ns</td><td align="right" bgcolor="#FFFFFF">526,756 ns</td><td align="right" bgcolor="#FFFFFF">540,558 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,383 μs</td><td align="right" bgcolor="#FFFFFF">0,613 μs</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 14,269 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,526 ns</td><td align="right" bgcolor="#FFFFFF">24,032 ns</td><td align="right" bgcolor="#FFFFFF">24,008 ns</td><td align="right" bgcolor="#FFFFFF">37,634 ns</td><td align="right" bgcolor="#FFFFFF">23,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 24,247 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">342,236 ns</td><td align="right" bgcolor="#FFFFFF">334,961 ns</td><td align="right" bgcolor="#FFFFFF">350,969 ns</td><td align="right" bgcolor="#FFFFFF">330,394 ns</td><td align="right" bgcolor="#FFFFFF">354,641 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,342 μs</td><td align="right" bgcolor="#FFFFFF">0,335 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,330 μs</td><td align="right" bgcolor="#FFFFFF">0,355 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 0,849 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,162 ns</td><td align="right" bgcolor="#FFFFFF">45,404 ns</td><td align="right" bgcolor="#FFFFFF">45,741 ns</td><td align="right" bgcolor="#FFFFFF">45,313 ns</td><td align="right" bgcolor="#FFFFFF">45,364 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 3,262 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">146,085 ns</td><td align="right" bgcolor="#FFFFFF">148,767 ns</td><td align="right" bgcolor="#FFFFFF">145,505 ns</td><td align="right" bgcolor="#FFFFFF">146,785 ns</td><td align="right" bgcolor="#FFFFFF">146,010 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 7,174 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">45,502 ns</td><td align="right" bgcolor="#FFFFFF">38,387 ns</td><td align="right" bgcolor="#FFFFFF">38,328 ns</td><td align="right" bgcolor="#FFFFFF">45,458 ns</td><td align="right" bgcolor="#FFFFFF">42,099 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 82,360 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">569,289 ns</td><td align="right" bgcolor="#FFFFFF">486,929 ns</td><td align="right" bgcolor="#FFFFFF">548,144 ns</td><td align="right" bgcolor="#FFFFFF">547,669 ns</td><td align="right" bgcolor="#FFFFFF">542,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,569 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 619,055 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#FF4949">+12,7 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4414,857 ns</td><td align="right" bgcolor="#A8D08D">4090,806 ns (Δ = -324,051 ns)</td><td align="right" bgcolor="#FF4949">4610,724 ns (Δ = +519,918 ns)</td><td align="right" bgcolor="#A8D08D">3991,669 ns (Δ = -619,055 ns)</td><td align="right" bgcolor="#FFFFFF">4225,043 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,415 μs</td><td align="right" bgcolor="#FFFFFF">4,091 μs</td><td align="right" bgcolor="#FFFFFF">4,611 μs</td><td align="right" bgcolor="#FFFFFF">3,992 μs</td><td align="right" bgcolor="#FFFFFF">4,225 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 452,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4288,914 ns</td><td align="right" bgcolor="#FFFFFF">4110,016 ns</td><td align="right" bgcolor="#FFFFFF">4110,482 ns</td><td align="right" bgcolor="#A8D08D">3835,968 ns (Δ = -274,514 ns)</td><td align="right" bgcolor="#FFFFFF">4007,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,289 μs</td><td align="right" bgcolor="#FFFFFF">4,110 μs</td><td align="right" bgcolor="#FFFFFF">4,110 μs</td><td align="right" bgcolor="#FFFFFF">3,836 μs</td><td align="right" bgcolor="#FFFFFF">4,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 368,330 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4877,177 ns</td><td align="right" bgcolor="#FFFFFF">4666,777 ns</td><td align="right" bgcolor="#FFFFFF">4715,710 ns</td><td align="right" bgcolor="#FFFFFF">4614,100 ns</td><td align="right" bgcolor="#FFFFFF">4508,847 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,877 μs</td><td align="right" bgcolor="#FFFFFF">4,667 μs</td><td align="right" bgcolor="#FFFFFF">4,716 μs</td><td align="right" bgcolor="#FFFFFF">4,614 μs</td><td align="right" bgcolor="#FFFFFF">4,509 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 145,737 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5441,686 ns</td><td align="right" bgcolor="#FFFFFF">5371,042 ns</td><td align="right" bgcolor="#FFFFFF">5374,492 ns</td><td align="right" bgcolor="#FFFFFF">5342,681 ns</td><td align="right" bgcolor="#FFFFFF">5295,949 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,442 μs</td><td align="right" bgcolor="#FFFFFF">5,371 μs</td><td align="right" bgcolor="#FFFFFF">5,374 μs</td><td align="right" bgcolor="#FFFFFF">5,343 μs</td><td align="right" bgcolor="#FFFFFF">5,296 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 48,533 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,711 ns</td><td align="right" bgcolor="#FFFFFF">144,657 ns</td><td align="right" bgcolor="#FFFFFF">143,633 ns</td><td align="right" bgcolor="#FFFFFF">96,359 ns</td><td align="right" bgcolor="#FFFFFF">96,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 50,684 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">145,085 ns</td><td align="right" bgcolor="#FFFFFF">148,132 ns</td><td align="right" bgcolor="#FFFFFF">144,032 ns</td><td align="right" bgcolor="#FFFFFF">97,449 ns</td><td align="right" bgcolor="#FFFFFF">97,886 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 268,883 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4099,470 ns</td><td align="right" bgcolor="#FFFFFF">4119,159 ns</td><td align="right" bgcolor="#FFFFFF">3987,358 ns</td><td align="right" bgcolor="#FFFFFF">4012,801 ns</td><td align="right" bgcolor="#FFFFFF">3850,276 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,099 μs</td><td align="right" bgcolor="#FFFFFF">4,119 μs</td><td align="right" bgcolor="#FFFFFF">3,987 μs</td><td align="right" bgcolor="#FFFFFF">4,013 μs</td><td align="right" bgcolor="#FFFFFF">3,850 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 37,882 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">267,244 ns</td><td align="right" bgcolor="#FFFFFF">256,540 ns</td><td align="right" bgcolor="#FFFFFF">286,897 ns</td><td align="right" bgcolor="#FFFFFF">294,422 ns</td><td align="right" bgcolor="#FFFFFF">277,207 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 29,238 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">265,706 ns</td><td align="right" bgcolor="#FFFFFF">264,005 ns</td><td align="right" bgcolor="#FFFFFF">285,476 ns</td><td align="right" bgcolor="#FFFFFF">293,243 ns</td><td align="right" bgcolor="#FFFFFF">283,311 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 36,246 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">315,057 ns</td><td align="right" bgcolor="#FFFFFF">305,474 ns</td><td align="right" bgcolor="#FFFFFF">341,720 ns</td><td align="right" bgcolor="#FFFFFF">341,492 ns</td><td align="right" bgcolor="#FFFFFF">315,192 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,342 μs</td><td align="right" bgcolor="#FFFFFF">0,341 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 28,243 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">271,966 ns</td><td align="right" bgcolor="#FFFFFF">267,028 ns</td><td align="right" bgcolor="#FFFFFF">290,015 ns</td><td align="right" bgcolor="#FFFFFF">295,272 ns</td><td align="right" bgcolor="#FFFFFF">273,100 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 35,296 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">275,707 ns</td><td align="right" bgcolor="#FFFFFF">263,473 ns</td><td align="right" bgcolor="#FFFFFF">298,769 ns</td><td align="right" bgcolor="#FFFFFF">281,726 ns</td><td align="right" bgcolor="#FFFFFF">279,376 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,276 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 191,638 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1525,018 ns</td><td align="right" bgcolor="#FFFFFF">1491,048 ns</td><td align="right" bgcolor="#FFFFFF">1589,591 ns</td><td align="right" bgcolor="#FFFFFF">1463,309 ns</td><td align="right" bgcolor="#FFFFFF">1654,947 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,525 μs</td><td align="right" bgcolor="#FFFFFF">1,491 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,655 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 170,381 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1517,556 ns</td><td align="right" bgcolor="#FFFFFF">1559,677 ns</td><td align="right" bgcolor="#FFFFFF">1594,682 ns</td><td align="right" bgcolor="#FFFFFF">1595,271 ns</td><td align="right" bgcolor="#FFFFFF">1687,937 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,518 μs</td><td align="right" bgcolor="#FFFFFF">1,560 μs</td><td align="right" bgcolor="#FFFFFF">1,595 μs</td><td align="right" bgcolor="#FFFFFF">1,595 μs</td><td align="right" bgcolor="#FFFFFF">1,688 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 47,031 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">334,636 ns</td><td align="right" bgcolor="#FFFFFF">321,599 ns</td><td align="right" bgcolor="#FFFFFF">359,979 ns</td><td align="right" bgcolor="#FFFFFF">368,629 ns</td><td align="right" bgcolor="#FFFFFF">349,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,335 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td><td align="right" bgcolor="#FFFFFF">0,369 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 30,136 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">330,731 ns</td><td align="right" bgcolor="#FFFFFF">343,487 ns</td><td align="right" bgcolor="#FFFFFF">354,195 ns</td><td align="right" bgcolor="#FFFFFF">360,867 ns</td><td align="right" bgcolor="#FFFFFF">335,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,331 μs</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td><td align="right" bgcolor="#FFFFFF">0,354 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,336 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 55,158 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">353,317 ns</td><td align="right" bgcolor="#FFFFFF">361,451 ns</td><td align="right" bgcolor="#FFFFFF">408,474 ns</td><td align="right" bgcolor="#FFFFFF">367,479 ns</td><td align="right" bgcolor="#FFFFFF">362,813 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,353 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,408 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td><td align="right" bgcolor="#FFFFFF">0,363 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 47,084 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">291,928 ns</td><td align="right" bgcolor="#FFFFFF">288,485 ns</td><td align="right" bgcolor="#FFFFFF">335,569 ns</td><td align="right" bgcolor="#FFFFFF">312,208 ns</td><td align="right" bgcolor="#FFFFFF">296,457 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,336 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,296 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 36,441 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">285,682 ns</td><td align="right" bgcolor="#FFFFFF">293,162 ns</td><td align="right" bgcolor="#FFFFFF">322,123 ns</td><td align="right" bgcolor="#FFFFFF">307,273 ns</td><td align="right" bgcolor="#FFFFFF">286,959 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 24,662 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">779,940 ns</td><td align="right" bgcolor="#FFFFFF">772,319 ns</td><td align="right" bgcolor="#FFFFFF">758,797 ns</td><td align="right" bgcolor="#FFFFFF">767,085 ns</td><td align="right" bgcolor="#FFFFFF">755,278 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,780 μs</td><td align="right" bgcolor="#FFFFFF">0,772 μs</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,767 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 233,452 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1448,627 ns</td><td align="right" bgcolor="#FFFFFF">1425,944 ns</td><td align="right" bgcolor="#FFFFFF">1346,175 ns</td><td align="right" bgcolor="#FFFFFF">1579,627 ns</td><td align="right" bgcolor="#FFFFFF">1569,011 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,449 μs</td><td align="right" bgcolor="#FFFFFF">1,426 μs</td><td align="right" bgcolor="#FFFFFF">1,346 μs</td><td align="right" bgcolor="#FFFFFF">1,580 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 154,092 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1507,726 ns</td><td align="right" bgcolor="#FFFFFF">1450,715 ns</td><td align="right" bgcolor="#FFFFFF">1515,210 ns</td><td align="right" bgcolor="#FFFFFF">1410,529 ns</td><td align="right" bgcolor="#FFFFFF">1564,621 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,508 μs</td><td align="right" bgcolor="#FFFFFF">1,451 μs</td><td align="right" bgcolor="#FFFFFF">1,515 μs</td><td align="right" bgcolor="#FFFFFF">1,411 μs</td><td align="right" bgcolor="#FFFFFF">1,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 26,766 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">334,439 ns</td><td align="right" bgcolor="#FFFFFF">325,174 ns</td><td align="right" bgcolor="#FFFFFF">347,497 ns</td><td align="right" bgcolor="#FFFFFF">351,940 ns</td><td align="right" bgcolor="#FFFFFF">342,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,334 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,347 μs</td><td align="right" bgcolor="#FFFFFF">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 30,970 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">297,647 ns</td><td align="right" bgcolor="#FFFFFF">290,944 ns</td><td align="right" bgcolor="#FFFFFF">312,853 ns</td><td align="right" bgcolor="#FFFFFF">321,914 ns</td><td align="right" bgcolor="#FFFFFF">302,087 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,298 μs</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,302 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 26,899 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">497,407 ns</td><td align="right" bgcolor="#FFFFFF">499,729 ns</td><td align="right" bgcolor="#FFFFFF">492,272 ns</td><td align="right" bgcolor="#FFFFFF">519,171 ns</td><td align="right" bgcolor="#FFFFFF">518,986 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,492 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,763 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,020 ns</td><td align="right" bgcolor="#FFFFFF">12,418 ns</td><td align="right" bgcolor="#FFFFFF">10,951 ns</td><td align="right" bgcolor="#FFFFFF">12,714 ns</td><td align="right" bgcolor="#FFFFFF">12,410 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 0,821 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,218 ns</td><td align="right" bgcolor="#FFFFFF">12,196 ns</td><td align="right" bgcolor="#FFFFFF">11,713 ns</td><td align="right" bgcolor="#FFFFFF">12,508 ns</td><td align="right" bgcolor="#FFFFFF">12,535 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,495 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,307 ns</td><td align="right" bgcolor="#FFFFFF">12,204 ns</td><td align="right" bgcolor="#FFFFFF">10,944 ns</td><td align="right" bgcolor="#FFFFFF">12,439 ns</td><td align="right" bgcolor="#FFFFFF">12,412 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 0,616 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,725 ns</td><td align="right" bgcolor="#FFFFFF">12,388 ns</td><td align="right" bgcolor="#FFFFFF">12,109 ns</td><td align="right" bgcolor="#FFFFFF">12,708 ns</td><td align="right" bgcolor="#FFFFFF">12,396 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 0,485 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,485 ns</td><td align="right" bgcolor="#FFFFFF">0,427 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,467 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,484 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,467 ns</td><td align="right" bgcolor="#FFFFFF">0,482 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,484 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,102 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,267 ns</td><td align="right" bgcolor="#FFFFFF">1,257 ns</td><td align="right" bgcolor="#FFFFFF">0,315 ns</td><td align="right" bgcolor="#FFFFFF">1,417 ns</td><td align="right" bgcolor="#FFFFFF">0,776 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,698 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,473 ns</td><td align="right" bgcolor="#FFFFFF">0,475 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,698 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 0,489 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,474 ns</td><td align="right" bgcolor="#FFFFFF">0,489 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,468 ns</td><td align="right" bgcolor="#FFFFFF">0,292 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 2,009 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,285 ns</td><td align="right" bgcolor="#FFFFFF">1,236 ns</td><td align="right" bgcolor="#FFFFFF">0,446 ns</td><td align="right" bgcolor="#FFFFFF">2,455 ns</td><td align="right" bgcolor="#FFFFFF">0,785 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 193,583 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1310,768 ns</td><td align="right" bgcolor="#FFFFFF">1468,809 ns</td><td align="right" bgcolor="#FFFFFF">1454,703 ns</td><td align="right" bgcolor="#FFFFFF">1401,061 ns</td><td align="right" bgcolor="#FFFFFF">1504,351 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,311 μs</td><td align="right" bgcolor="#FFFFFF">1,469 μs</td><td align="right" bgcolor="#FFFFFF">1,455 μs</td><td align="right" bgcolor="#FFFFFF">1,401 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1117,494 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32292,426 ns</td><td align="right" bgcolor="#FF4949">33331,238 ns (Δ = +1038,812 ns)</td><td align="right" bgcolor="#FFFFFF">33346,082 ns</td><td align="right" bgcolor="#FFFFFF">33409,920 ns</td><td align="right" bgcolor="#FFFFFF">33163,453 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">32,292 μs</td><td align="right" bgcolor="#FFFFFF">33,331 μs</td><td align="right" bgcolor="#FFFFFF">33,346 μs</td><td align="right" bgcolor="#FFFFFF">33,410 μs</td><td align="right" bgcolor="#FFFFFF">33,163 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,032 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


