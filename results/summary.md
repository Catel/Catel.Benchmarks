# Benchmarks

Benchmark report generated on 29-jan-2018 13:12

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.12, OS=Windows 10.0.17083, VM=Hyper-V

Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), 1 CPU, 8 logical cores and 8 physical cores



## Important benchmarks

### High priority (current version slower than previous one)

4 item(s)

1. [ServiceLocator_Benchmark::ResolveType_With_Transient_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency) v5.3.0 is **6,40%** (Δ: 359,506 ns) slower than v5.2.0

2. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.3.0 is **6,08%** (Δ: 892,287 ns) slower than v5.2.0

3. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v5.3.0 is **5,75%** (Δ: 825,900 ns) slower than v5.2.0

4. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.3.0 is **1,98%** (Δ: 12474,057 ns) slower than v5.2.0



### Improved (current version faster than previous one)

7 item(s)

1. [TypeExtensions_Benchmark::GetCollectionElementType](#TypeExtensions_Benchmark_GetCollectionElementType) v5.3.0 is **64,52%** (Δ: -648,507 ns) faster than v5.2.0

2. [Log_Debug_Benchmark::Log_Debug_Format_3_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments) v5.3.0 is **21,56%** (Δ: -262,212 ns) faster than v5.2.0

3. [ObjectToStringHelper_Benchmark::ToString_](#ObjectToStringHelper_Benchmark_ToString_) v5.3.0 is **14,93%** (Δ: -557,205 ns) faster than v5.2.0

4. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type) v5.3.0 is **13,26%** (Δ: -547,157 ns) faster than v5.2.0

5. [AssemblyExtensions_Benchmark::Product](#AssemblyExtensions_Benchmark_Product) v5.3.0 is **2,93%** (Δ: -298,891 ns) faster than v5.2.0

6. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.3.0 is **1,55%** (Δ: -10108,047 ns) faster than v5.2.0

7. [Serialization_Binary_Benchmark::SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models) v5.3.0 is **1,42%** (Δ: -3147,600 ns) faster than v5.2.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 30,100 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,108 ns</td><td align="right" bgcolor="#FFFFFF">97,417 ns</td><td align="right" bgcolor="#FFFFFF">95,008 ns</td><td align="right" bgcolor="#FFFFFF">97,082 ns</td><td align="right" bgcolor="#FFFFFF">96,725 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 3,355 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,145 ns</td><td align="right" bgcolor="#FFFFFF">97,877 ns</td><td align="right" bgcolor="#FFFFFF">95,057 ns</td><td align="right" bgcolor="#FFFFFF">96,478 ns</td><td align="right" bgcolor="#FFFFFF">94,790 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 4,718 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,985 ns</td><td align="right" bgcolor="#FFFFFF">91,653 ns</td><td align="right" bgcolor="#FFFFFF">89,819 ns</td><td align="right" bgcolor="#FFFFFF">88,267 ns</td><td align="right" bgcolor="#FFFFFF">91,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 59,413 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">154,102 ns</td><td align="right" bgcolor="#FFFFFF">98,173 ns</td><td align="right" bgcolor="#FFFFFF">96,992 ns</td><td align="right" bgcolor="#FFFFFF">94,688 ns</td><td align="right" bgcolor="#FFFFFF">95,990 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 9,912 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,795 ns</td><td align="right" bgcolor="#FFFFFF">37,393 ns</td><td align="right" bgcolor="#FFFFFF">45,660 ns</td><td align="right" bgcolor="#FFFFFF">45,940 ns</td><td align="right" bgcolor="#FFFFFF">47,305 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 14,055 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,317 ns</td><td align="right" bgcolor="#FFFFFF">42,610 ns</td><td align="right" bgcolor="#FFFFFF">56,665 ns</td><td align="right" bgcolor="#FFFFFF">53,897 ns</td><td align="right" bgcolor="#FFFFFF">53,638 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 11,965 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,245 ns</td><td align="right" bgcolor="#FFFFFF">42,120 ns</td><td align="right" bgcolor="#FFFFFF">54,050 ns</td><td align="right" bgcolor="#FFFFFF">54,085 ns</td><td align="right" bgcolor="#FFFFFF">53,710 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 54,670 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">698,703 ns</td><td align="right" bgcolor="#FFFFFF">704,427 ns</td><td align="right" bgcolor="#FFFFFF">649,757 ns</td><td align="right" bgcolor="#FFFFFF">651,228 ns</td><td align="right" bgcolor="#FFFFFF">676,812 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,699 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td><td align="right" bgcolor="#FFFFFF">0,677 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,670 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,517 ns</td><td align="right" bgcolor="#FFFFFF">14,300 ns</td><td align="right" bgcolor="#FFFFFF">14,833 ns</td><td align="right" bgcolor="#FFFFFF">14,970 ns</td><td align="right" bgcolor="#FFFFFF">14,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1,845 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,918 ns</td><td align="right" bgcolor="#FFFFFF">15,993 ns</td><td align="right" bgcolor="#FFFFFF">17,763 ns</td><td align="right" bgcolor="#FFFFFF">17,757 ns</td><td align="right" bgcolor="#FFFFFF">17,410 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,302 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,438 ns</td><td align="right" bgcolor="#FFFFFF">6,338 ns</td><td align="right" bgcolor="#FFFFFF">7,404 ns</td><td align="right" bgcolor="#FFFFFF">7,640 ns</td><td align="right" bgcolor="#FFFFFF">7,490 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 20,137 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">524,040 ns</td><td align="right" bgcolor="#FFFFFF">523,410 ns</td><td align="right" bgcolor="#FFFFFF">519,147 ns</td><td align="right" bgcolor="#FFFFFF">520,530 ns</td><td align="right" bgcolor="#FFFFFF">539,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td><td align="right" bgcolor="#FFFFFF">0,539 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,787 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,350 ns</td><td align="right" bgcolor="#FFFFFF">1,072 ns</td><td align="right" bgcolor="#FFFFFF">1,637 ns</td><td align="right" bgcolor="#FFFFFF">1,707 ns</td><td align="right" bgcolor="#FFFFFF">1,858 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,858 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,423 ns</td><td align="right" bgcolor="#FFFFFF">0,787 ns</td><td align="right" bgcolor="#FFFFFF">2,644 ns</td><td align="right" bgcolor="#FFFFFF">2,260 ns</td><td align="right" bgcolor="#FFFFFF">2,333 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,127 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,598 ns</td><td align="right" bgcolor="#FFFFFF">9,608 ns</td><td align="right" bgcolor="#FFFFFF">11,382 ns</td><td align="right" bgcolor="#FFFFFF">11,725 ns</td><td align="right" bgcolor="#FFFFFF">11,527 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,292 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,498 ns</td><td align="right" bgcolor="#FFFFFF">3,207 ns</td><td align="right" bgcolor="#FFFFFF">3,353 ns</td><td align="right" bgcolor="#FFFFFF">3,290 ns</td><td align="right" bgcolor="#FFFFFF">3,352 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 5,497 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,995 ns</td><td align="right" bgcolor="#FFFFFF">14,265 ns</td><td align="right" bgcolor="#FFFFFF">16,722 ns</td><td align="right" bgcolor="#FFFFFF">19,762 ns</td><td align="right" bgcolor="#FFFFFF">16,872 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 16,478 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,652 ns</td><td align="right" bgcolor="#FFFFFF">80,448 ns</td><td align="right" bgcolor="#FFFFFF">96,927 ns</td><td align="right" bgcolor="#FFFFFF">94,433 ns</td><td align="right" bgcolor="#FFFFFF">96,664 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 20,690 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,487 ns</td><td align="right" bgcolor="#FFFFFF">85,657 ns</td><td align="right" bgcolor="#FFFFFF">101,962 ns</td><td align="right" bgcolor="#FFFFFF">101,698 ns</td><td align="right" bgcolor="#FFFFFF">106,177 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 10,992 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58,227 ns</td><td align="right" bgcolor="#FFFFFF">55,578 ns</td><td align="right" bgcolor="#FFFFFF">65,572 ns</td><td align="right" bgcolor="#FFFFFF">66,472 ns</td><td align="right" bgcolor="#FFFFFF">66,570 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 10,085 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">64,103 ns</td><td align="right" bgcolor="#FFFFFF">74,038 ns</td><td align="right" bgcolor="#FFFFFF">72,377 ns</td><td align="right" bgcolor="#FFFFFF">74,188 ns</td><td align="right" bgcolor="#FFFFFF">74,012 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 4,008 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,170 ns</td><td align="right" bgcolor="#FFFFFF">24,220 ns</td><td align="right" bgcolor="#FFFFFF">26,635 ns</td><td align="right" bgcolor="#FFFFFF">25,898 ns</td><td align="right" bgcolor="#FFFFFF">28,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -24,000)</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,023)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 20,270 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,143 ns</td><td align="right" bgcolor="#FFFFFF">55,610 ns</td><td align="right" bgcolor="#FFFFFF">75,880 ns</td><td align="right" bgcolor="#FFFFFF">62,368 ns</td><td align="right" bgcolor="#FFFFFF">64,248 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,137 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">64,763 ns</td><td align="right" bgcolor="#FFFFFF">63,142 ns</td><td align="right" bgcolor="#FFFFFF">69,535 ns</td><td align="right" bgcolor="#FFFFFF">71,278 ns</td><td align="right" bgcolor="#FFFFFF">69,618 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 5,314 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">38,735 ns</td><td align="right" bgcolor="#FFFFFF">38,197 ns</td><td align="right" bgcolor="#FFFFFF">43,107 ns</td><td align="right" bgcolor="#FFFFFF">42,523 ns</td><td align="right" bgcolor="#FFFFFF">43,510 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 4,435 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,683 ns</td><td align="right" bgcolor="#FFFFFF">46,605 ns</td><td align="right" bgcolor="#FFFFFF">51,040 ns</td><td align="right" bgcolor="#FFFFFF">50,292 ns</td><td align="right" bgcolor="#FFFFFF">50,808 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 805,112 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7672,863 ns</td><td align="right" bgcolor="#FFFFFF">7484,422 ns</td><td align="right" bgcolor="#FF4949">8289,533 ns (Δ = +805,112 ns)</td><td align="right" bgcolor="#FFFFFF">8252,190 ns</td><td align="right" bgcolor="#FFFFFF">8271,327 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,673 μs</td><td align="right" bgcolor="#FFFFFF">7,484 μs</td><td align="right" bgcolor="#FFFFFF">8,290 μs</td><td align="right" bgcolor="#FFFFFF">8,252 μs</td><td align="right" bgcolor="#FFFFFF">8,271 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 806,028 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7608,849 ns</td><td align="right" bgcolor="#FFFFFF">7492,073 ns</td><td align="right" bgcolor="#FF4949">8298,102 ns (Δ = +806,028 ns)</td><td align="right" bgcolor="#FFFFFF">8240,658 ns</td><td align="right" bgcolor="#FFFFFF">8234,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,609 μs</td><td align="right" bgcolor="#FFFFFF">7,492 μs</td><td align="right" bgcolor="#FFFFFF">8,298 μs</td><td align="right" bgcolor="#FFFFFF">8,241 μs</td><td align="right" bgcolor="#FFFFFF">8,234 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 6107,665 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14502,382 ns</td><td align="right" bgcolor="#FFFFFF">14657,205 ns</td><td align="right" bgcolor="#FF4949">20519,363 ns (Δ = +5862,158 ns)</td><td align="right" bgcolor="#FFFFFF">20551,617 ns</td><td align="right" bgcolor="#FFFFFF">20610,047 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,502 μs</td><td align="right" bgcolor="#FFFFFF">14,657 μs</td><td align="right" bgcolor="#FFFFFF">20,519 μs</td><td align="right" bgcolor="#FFFFFF">20,552 μs</td><td align="right" bgcolor="#FFFFFF">20,610 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1364,000</td><td align="right" bgcolor="#FF4949">1376,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -688,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,332</td><td align="right" bgcolor="#FF4949">1,344 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,672)</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 3559,914 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+55,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5974,619 ns</td><td align="right" bgcolor="#FFFFFF">6011,557 ns</td><td align="right" bgcolor="#FF4949">9361,187 ns (Δ = +3349,630 ns)</td><td align="right" bgcolor="#FFFFFF">9353,423 ns</td><td align="right" bgcolor="#FFFFFF">9534,533 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,975 μs</td><td align="right" bgcolor="#FFFFFF">6,012 μs</td><td align="right" bgcolor="#FFFFFF">9,361 μs</td><td align="right" bgcolor="#FFFFFF">9,353 μs</td><td align="right" bgcolor="#FFFFFF">9,535 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3011,000</td><td align="right" bgcolor="#FF4949">3043,000 (Δ = +32,000)</td><td align="right" bgcolor="#A8D08D">1524,000 (Δ = -1519,000)</td><td align="right" bgcolor="#FFFFFF">1524,000</td><td align="right" bgcolor="#FFFFFF">1524,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,940</td><td align="right" bgcolor="#FF4949">2,972 (Δ = +0,031)</td><td align="right" bgcolor="#A8D08D">1,488 (Δ = -1,483)</td><td align="right" bgcolor="#FFFFFF">1,488</td><td align="right" bgcolor="#FFFFFF">1,488</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 444,888 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9625,722 ns</td><td align="right" bgcolor="#FFFFFF">9652,725 ns</td><td align="right" bgcolor="#FF4949">10070,610 ns (Δ = +417,885 ns)</td><td align="right" bgcolor="#FFFFFF">9845,990 ns</td><td align="right" bgcolor="#FFFFFF">9796,007 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,626 μs</td><td align="right" bgcolor="#FFFFFF">9,653 μs</td><td align="right" bgcolor="#FFFFFF">10,071 μs</td><td align="right" bgcolor="#FFFFFF">9,846 μs</td><td align="right" bgcolor="#FFFFFF">9,796 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">430,000 (Δ = -406,000)</td><td align="right" bgcolor="#FFFFFF">430,000</td><td align="right" bgcolor="#FFFFFF">430,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,420 (Δ = -0,396)</td><td align="right" bgcolor="#FFFFFF">0,420</td><td align="right" bgcolor="#FFFFFF">0,420</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 333,483 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9946,368 ns</td><td align="right" bgcolor="#FFFFFF">9728,622 ns</td><td align="right" bgcolor="#FF4949">10036,280 ns (Δ = +307,658 ns)</td><td align="right" bgcolor="#FFFFFF">9934,087 ns</td><td align="right" bgcolor="#FFFFFF">10062,105 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,946 μs</td><td align="right" bgcolor="#FFFFFF">9,729 μs</td><td align="right" bgcolor="#FFFFFF">10,036 μs</td><td align="right" bgcolor="#FFFFFF">9,934 μs</td><td align="right" bgcolor="#FFFFFF">10,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#A8D08D">479,000 (Δ = -402,000)</td><td align="right" bgcolor="#FFFFFF">479,000</td><td align="right" bgcolor="#FFFFFF">479,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#A8D08D">0,468 (Δ = -0,393)</td><td align="right" bgcolor="#FFFFFF">0,468</td><td align="right" bgcolor="#FFFFFF">0,468</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 442,365 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9627,353 ns</td><td align="right" bgcolor="#FF4949">10069,718 ns (Δ = +442,365 ns)</td><td align="right" bgcolor="#FFFFFF">9865,593 ns</td><td align="right" bgcolor="#FFFFFF">9784,188 ns</td><td align="right" bgcolor="#FFFFFF">9944,335 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,627 μs</td><td align="right" bgcolor="#FFFFFF">10,070 μs</td><td align="right" bgcolor="#FFFFFF">9,866 μs</td><td align="right" bgcolor="#FFFFFF">9,784 μs</td><td align="right" bgcolor="#FFFFFF">9,944 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 180427,120 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">440015,850 ns</td><td align="right" bgcolor="#FFFFFF">442774,903 ns</td><td align="right" bgcolor="#A8D08D">262434,520 ns (Δ = -180340,383 ns)</td><td align="right" bgcolor="#FFFFFF">262347,783 ns</td><td align="right" bgcolor="#FFFFFF">264647,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">440,016 μs</td><td align="right" bgcolor="#FFFFFF">442,775 μs</td><td align="right" bgcolor="#FFFFFF">262,435 μs</td><td align="right" bgcolor="#FFFFFF">262,348 μs</td><td align="right" bgcolor="#FFFFFF">264,647 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,440 ms</td><td align="right" bgcolor="#FFFFFF">0,443 ms</td><td align="right" bgcolor="#FFFFFF">0,262 ms</td><td align="right" bgcolor="#FFFFFF">0,262 ms</td><td align="right" bgcolor="#FFFFFF">0,265 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20460,000</td><td align="right" bgcolor="#FFFFFF">20460,000</td><td align="right" bgcolor="#A8D08D">10916,000 (Δ = -9544,000)</td><td align="right" bgcolor="#FFFFFF">10916,000</td><td align="right" bgcolor="#FFFFFF">10916,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">19,980</td><td align="right" bgcolor="#FFFFFF">19,980</td><td align="right" bgcolor="#A8D08D">10,660 (Δ = -9,320)</td><td align="right" bgcolor="#FFFFFF">10,660</td><td align="right" bgcolor="#FFFFFF">10,660</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 861,217 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2458,570 ns</td><td align="right" bgcolor="#FFFFFF">2450,527 ns</td><td align="right" bgcolor="#FF4949">3303,043 ns (Δ = +852,517 ns)</td><td align="right" bgcolor="#FFFFFF">3307,142 ns</td><td align="right" bgcolor="#FFFFFF">3311,743 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,459 μs</td><td align="right" bgcolor="#FFFFFF">2,451 μs</td><td align="right" bgcolor="#FFFFFF">3,303 μs</td><td align="right" bgcolor="#FFFFFF">3,307 μs</td><td align="right" bgcolor="#FFFFFF">3,312 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#A8D08D">750,000 (Δ = -262,000)</td><td align="right" bgcolor="#FFFFFF">750,000</td><td align="right" bgcolor="#FFFFFF">750,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#A8D08D">0,732 (Δ = -0,256)</td><td align="right" bgcolor="#FFFFFF">0,732</td><td align="right" bgcolor="#FFFFFF">0,732</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 751,078 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7670,153 ns</td><td align="right" bgcolor="#FFFFFF">7657,802 ns</td><td align="right" bgcolor="#FF4949">8408,880 ns (Δ = +751,078 ns)</td><td align="right" bgcolor="#FFFFFF">8333,150 ns</td><td align="right" bgcolor="#FFFFFF">8315,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,670 μs</td><td align="right" bgcolor="#FFFFFF">7,658 μs</td><td align="right" bgcolor="#FFFFFF">8,409 μs</td><td align="right" bgcolor="#FFFFFF">8,333 μs</td><td align="right" bgcolor="#FFFFFF">8,315 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">422,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">422,000</td><td align="right" bgcolor="#FFFFFF">422,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,412 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,412</td><td align="right" bgcolor="#FFFFFF">0,412</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 509,032 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#A8D08D">-2,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9699,128 ns</td><td align="right" bgcolor="#FFFFFF">9822,938 ns</td><td align="right" bgcolor="#FFFFFF">9940,533 ns</td><td align="right" bgcolor="#FF4949">10208,160 ns (Δ = +267,627 ns)</td><td align="right" bgcolor="#A8D08D">9909,269 ns (Δ = -298,891 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,699 μs</td><td align="right" bgcolor="#FFFFFF">9,823 μs</td><td align="right" bgcolor="#FFFFFF">9,941 μs</td><td align="right" bgcolor="#FFFFFF">10,208 μs</td><td align="right" bgcolor="#FFFFFF">9,909 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2551,378 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12324,108 ns</td><td align="right" bgcolor="#A8D08D">9815,483 ns (Δ = -2508,625 ns)</td><td align="right" bgcolor="#FFFFFF">9959,977 ns</td><td align="right" bgcolor="#FFFFFF">9826,790 ns</td><td align="right" bgcolor="#FFFFFF">9772,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,324 μs</td><td align="right" bgcolor="#FFFFFF">9,815 μs</td><td align="right" bgcolor="#FFFFFF">9,960 μs</td><td align="right" bgcolor="#FFFFFF">9,827 μs</td><td align="right" bgcolor="#FFFFFF">9,773 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 116,472 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">953,762 ns</td><td align="right" bgcolor="#FFFFFF">1058,210 ns</td><td align="right" bgcolor="#FFFFFF">957,873 ns</td><td align="right" bgcolor="#FFFFFF">941,738 ns</td><td align="right" bgcolor="#FFFFFF">957,998 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,954 μs</td><td align="right" bgcolor="#FFFFFF">1,058 μs</td><td align="right" bgcolor="#FFFFFF">0,958 μs</td><td align="right" bgcolor="#FFFFFF">0,942 μs</td><td align="right" bgcolor="#FFFFFF">0,958 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#A8D08D">881,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#A8D08D">0,860 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 450,572 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2604,620 ns</td><td align="right" bgcolor="#FFFFFF">2517,070 ns</td><td align="right" bgcolor="#FF4949">2946,582 ns (Δ = +429,512 ns)</td><td align="right" bgcolor="#FFFFFF">2967,642 ns</td><td align="right" bgcolor="#FFFFFF">2960,882 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,605 μs</td><td align="right" bgcolor="#FFFFFF">2,517 μs</td><td align="right" bgcolor="#FFFFFF">2,947 μs</td><td align="right" bgcolor="#FFFFFF">2,968 μs</td><td align="right" bgcolor="#FFFFFF">2,961 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 258,962 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3278,523 ns</td><td align="right" bgcolor="#FFFFFF">3273,672 ns</td><td align="right" bgcolor="#FFFFFF">3512,707 ns</td><td align="right" bgcolor="#FFFFFF">3532,633 ns</td><td align="right" bgcolor="#FFFFFF">3511,097 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,279 μs</td><td align="right" bgcolor="#FFFFFF">3,274 μs</td><td align="right" bgcolor="#FFFFFF">3,513 μs</td><td align="right" bgcolor="#FFFFFF">3,533 μs</td><td align="right" bgcolor="#FFFFFF">3,511 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 423,733 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2697,398 ns</td><td align="right" bgcolor="#FFFFFF">2585,250 ns</td><td align="right" bgcolor="#FF4949">3008,983 ns (Δ = +423,733 ns)</td><td align="right" bgcolor="#FFFFFF">2996,313 ns</td><td align="right" bgcolor="#FFFFFF">3003,545 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,697 μs</td><td align="right" bgcolor="#FFFFFF">2,585 μs</td><td align="right" bgcolor="#FFFFFF">3,009 μs</td><td align="right" bgcolor="#FFFFFF">2,996 μs</td><td align="right" bgcolor="#FFFFFF">3,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 253,487 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3306,308 ns</td><td align="right" bgcolor="#FFFFFF">3327,998 ns</td><td align="right" bgcolor="#FFFFFF">3558,593 ns</td><td align="right" bgcolor="#FFFFFF">3461,912 ns</td><td align="right" bgcolor="#FFFFFF">3559,795 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,306 μs</td><td align="right" bgcolor="#FFFFFF">3,328 μs</td><td align="right" bgcolor="#FFFFFF">3,559 μs</td><td align="right" bgcolor="#FFFFFF">3,462 μs</td><td align="right" bgcolor="#FFFFFF">3,560 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 493,715 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2589,608 ns</td><td align="right" bgcolor="#FFFFFF">2503,220 ns</td><td align="right" bgcolor="#FF4949">2996,935 ns (Δ = +493,715 ns)</td><td align="right" bgcolor="#FFFFFF">2975,543 ns</td><td align="right" bgcolor="#FFFFFF">2979,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,590 μs</td><td align="right" bgcolor="#FFFFFF">2,503 μs</td><td align="right" bgcolor="#FFFFFF">2,997 μs</td><td align="right" bgcolor="#FFFFFF">2,976 μs</td><td align="right" bgcolor="#FFFFFF">2,979 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 301,043 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3431,503 ns</td><td align="right" bgcolor="#FFFFFF">3283,920 ns</td><td align="right" bgcolor="#FFFFFF">3513,058 ns</td><td align="right" bgcolor="#FFFFFF">3584,963 ns</td><td align="right" bgcolor="#FFFFFF">3507,067 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,432 μs</td><td align="right" bgcolor="#FFFFFF">3,284 μs</td><td align="right" bgcolor="#FFFFFF">3,513 μs</td><td align="right" bgcolor="#FFFFFF">3,585 μs</td><td align="right" bgcolor="#FFFFFF">3,507 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 481,563 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2615,555 ns</td><td align="right" bgcolor="#FFFFFF">2583,112 ns</td><td align="right" bgcolor="#FF4949">3064,675 ns (Δ = +481,563 ns)</td><td align="right" bgcolor="#FFFFFF">2980,825 ns</td><td align="right" bgcolor="#FFFFFF">2981,690 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,616 μs</td><td align="right" bgcolor="#FFFFFF">2,583 μs</td><td align="right" bgcolor="#FFFFFF">3,065 μs</td><td align="right" bgcolor="#FFFFFF">2,981 μs</td><td align="right" bgcolor="#FFFFFF">2,982 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 235,828 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3329,472 ns</td><td align="right" bgcolor="#FFFFFF">3316,467 ns</td><td align="right" bgcolor="#FFFFFF">3535,252 ns</td><td align="right" bgcolor="#FFFFFF">3520,158 ns</td><td align="right" bgcolor="#FFFFFF">3552,295 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,329 μs</td><td align="right" bgcolor="#FFFFFF">3,316 μs</td><td align="right" bgcolor="#FFFFFF">3,535 μs</td><td align="right" bgcolor="#FFFFFF">3,520 μs</td><td align="right" bgcolor="#FFFFFF">3,552 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 545,482 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2575,437 ns</td><td align="right" bgcolor="#FFFFFF">2510,573 ns</td><td align="right" bgcolor="#FF4949">3056,055 ns (Δ = +545,482 ns)</td><td align="right" bgcolor="#FFFFFF">2972,670 ns</td><td align="right" bgcolor="#FFFFFF">2950,938 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,575 μs</td><td align="right" bgcolor="#FFFFFF">2,511 μs</td><td align="right" bgcolor="#FFFFFF">3,056 μs</td><td align="right" bgcolor="#FFFFFF">2,973 μs</td><td align="right" bgcolor="#FFFFFF">2,951 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 328,685 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3261,397 ns</td><td align="right" bgcolor="#FFFFFF">3277,052 ns</td><td align="right" bgcolor="#FF4949">3533,598 ns (Δ = +256,547 ns)</td><td align="right" bgcolor="#FFFFFF">3590,082 ns</td><td align="right" bgcolor="#FFFFFF">3488,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,261 μs</td><td align="right" bgcolor="#FFFFFF">3,277 μs</td><td align="right" bgcolor="#FFFFFF">3,534 μs</td><td align="right" bgcolor="#FFFFFF">3,590 μs</td><td align="right" bgcolor="#FFFFFF">3,489 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 383,742 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2693,975 ns</td><td align="right" bgcolor="#FFFFFF">2646,658 ns</td><td align="right" bgcolor="#FF4949">3021,900 ns (Δ = +375,242 ns)</td><td align="right" bgcolor="#FFFFFF">3030,400 ns</td><td align="right" bgcolor="#FFFFFF">3025,320 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,694 μs</td><td align="right" bgcolor="#FFFFFF">2,647 μs</td><td align="right" bgcolor="#FFFFFF">3,022 μs</td><td align="right" bgcolor="#FFFFFF">3,030 μs</td><td align="right" bgcolor="#FFFFFF">3,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 789,742 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,1 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3344,162 ns</td><td align="right" bgcolor="#FFFFFF">3335,543 ns</td><td align="right" bgcolor="#FFFFFF">3553,480 ns</td><td align="right" bgcolor="#FF4949">4125,285 ns (Δ = +571,805 ns)</td><td align="right" bgcolor="#A8D08D">3578,128 ns (Δ = -547,157 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,344 μs</td><td align="right" bgcolor="#FFFFFF">3,336 μs</td><td align="right" bgcolor="#FFFFFF">3,553 μs</td><td align="right" bgcolor="#FFFFFF">4,125 μs</td><td align="right" bgcolor="#FFFFFF">3,578 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 26,855 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">230,960 ns</td><td align="right" bgcolor="#FFFFFF">233,032 ns</td><td align="right" bgcolor="#FFFFFF">257,815 ns</td><td align="right" bgcolor="#FFFFFF">255,987 ns</td><td align="right" bgcolor="#FFFFFF">254,278 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,258 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 26,357 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">243,432 ns</td><td align="right" bgcolor="#FFFFFF">236,707 ns</td><td align="right" bgcolor="#FFFFFF">263,063 ns</td><td align="right" bgcolor="#FFFFFF">262,338 ns</td><td align="right" bgcolor="#FFFFFF">261,267 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,262 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 28,720 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">242,545 ns</td><td align="right" bgcolor="#FFFFFF">237,377 ns</td><td align="right" bgcolor="#FFFFFF">266,097 ns</td><td align="right" bgcolor="#FFFFFF">262,952 ns</td><td align="right" bgcolor="#FFFFFF">261,353 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 24,372 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,868 ns</td><td align="right" bgcolor="#FFFFFF">220,910 ns</td><td align="right" bgcolor="#FFFFFF">244,240 ns</td><td align="right" bgcolor="#FFFFFF">242,812 ns</td><td align="right" bgcolor="#FFFFFF">241,690 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 25,878 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,078 ns</td><td align="right" bgcolor="#FFFFFF">218,515 ns</td><td align="right" bgcolor="#FFFFFF">243,780 ns</td><td align="right" bgcolor="#FFFFFF">242,510 ns</td><td align="right" bgcolor="#FFFFFF">244,393 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 25,315 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,217 ns</td><td align="right" bgcolor="#FFFFFF">237,395 ns</td><td align="right" bgcolor="#FFFFFF">259,532 ns</td><td align="right" bgcolor="#FFFFFF">255,925 ns</td><td align="right" bgcolor="#FFFFFF">255,058 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 99,868 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">877,500 ns</td><td align="right" bgcolor="#FFFFFF">859,745 ns</td><td align="right" bgcolor="#FFFFFF">914,787 ns</td><td align="right" bgcolor="#FFFFFF">959,613 ns</td><td align="right" bgcolor="#FFFFFF">928,103 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,878 μs</td><td align="right" bgcolor="#FFFFFF">0,860 μs</td><td align="right" bgcolor="#FFFFFF">0,915 μs</td><td align="right" bgcolor="#FFFFFF">0,960 μs</td><td align="right" bgcolor="#FFFFFF">0,928 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -94,000)</td><td align="right" bgcolor="#FFFFFF">94,000</td><td align="right" bgcolor="#FFFFFF">94,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,092)</td><td align="right" bgcolor="#FFFFFF">0,092</td><td align="right" bgcolor="#FFFFFF">0,092</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 63,485 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,830 ns</td><td align="right" bgcolor="#FFFFFF">121,357 ns</td><td align="right" bgcolor="#FFFFFF">184,842 ns</td><td align="right" bgcolor="#FFFFFF">134,500 ns</td><td align="right" bgcolor="#FFFFFF">132,693 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 12,277 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">143,187 ns</td><td align="right" bgcolor="#FFFFFF">138,243 ns</td><td align="right" bgcolor="#FFFFFF">150,520 ns</td><td align="right" bgcolor="#FFFFFF">149,732 ns</td><td align="right" bgcolor="#FFFFFF">148,808 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 214,390 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1994,772 ns</td><td align="right" bgcolor="#FFFFFF">1927,376 ns</td><td align="right" bgcolor="#FFFFFF">1825,775 ns</td><td align="right" bgcolor="#FFFFFF">1780,382 ns</td><td align="right" bgcolor="#FFFFFF">1791,625 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,995 μs</td><td align="right" bgcolor="#FFFFFF">1,927 μs</td><td align="right" bgcolor="#FFFFFF">1,826 μs</td><td align="right" bgcolor="#FFFFFF">1,780 μs</td><td align="right" bgcolor="#FFFFFF">1,792 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -446,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,436)</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.3.0**

Slowest: 5.1.0

Δ: 541,068 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#A8D08D">-11,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3804,532 ns</td><td align="right" bgcolor="#FFFFFF">3714,972 ns</td><td align="right" bgcolor="#FF4949">4059,825 ns (Δ = +344,853 ns)</td><td align="right" bgcolor="#A8D08D">3607,087 ns (Δ = -452,738 ns)</td><td align="right" bgcolor="#FFFFFF">3518,757 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,805 μs</td><td align="right" bgcolor="#FFFFFF">3,715 μs</td><td align="right" bgcolor="#FFFFFF">4,060 μs</td><td align="right" bgcolor="#FFFFFF">3,607 μs</td><td align="right" bgcolor="#FFFFFF">3,519 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#A8D08D">594,000 (Δ = -512,000)</td><td align="right" bgcolor="#FFFFFF">594,000</td><td align="right" bgcolor="#FFFFFF">594,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#A8D08D">0,580 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">0,580</td><td align="right" bgcolor="#FFFFFF">0,580</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 37,138 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272,948 ns</td><td align="right" bgcolor="#FFFFFF">281,608 ns</td><td align="right" bgcolor="#FFFFFF">308,627 ns</td><td align="right" bgcolor="#FFFFFF">308,438 ns</td><td align="right" bgcolor="#FFFFFF">310,087 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,310 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 337,870 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3923,128 ns</td><td align="right" bgcolor="#FFFFFF">3752,877 ns</td><td align="right" bgcolor="#FFFFFF">3585,258 ns</td><td align="right" bgcolor="#FFFFFF">3644,585 ns</td><td align="right" bgcolor="#FFFFFF">3713,812 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,923 μs</td><td align="right" bgcolor="#FFFFFF">3,753 μs</td><td align="right" bgcolor="#FFFFFF">3,585 μs</td><td align="right" bgcolor="#FFFFFF">3,645 μs</td><td align="right" bgcolor="#FFFFFF">3,714 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#A8D08D">651,000 (Δ = -545,000)</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#A8D08D">0,636 (Δ = -0,532)</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 29,817 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">297,473 ns</td><td align="right" bgcolor="#FFFFFF">292,300 ns</td><td align="right" bgcolor="#FFFFFF">322,117 ns</td><td align="right" bgcolor="#FFFFFF">319,977 ns</td><td align="right" bgcolor="#FFFFFF">319,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,297 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 26,728 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">300,143 ns</td><td align="right" bgcolor="#FFFFFF">298,793 ns</td><td align="right" bgcolor="#FFFFFF">325,522 ns</td><td align="right" bgcolor="#FFFFFF">325,227 ns</td><td align="right" bgcolor="#FFFFFF">321,710 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,300 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td><td align="right" bgcolor="#FFFFFF">0,326 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 35,087 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">286,863 ns</td><td align="right" bgcolor="#FFFFFF">293,259 ns</td><td align="right" bgcolor="#FFFFFF">318,755 ns</td><td align="right" bgcolor="#FFFFFF">318,962 ns</td><td align="right" bgcolor="#FFFFFF">321,950 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 34,547 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">287,192 ns</td><td align="right" bgcolor="#FFFFFF">286,468 ns</td><td align="right" bgcolor="#FFFFFF">321,015 ns</td><td align="right" bgcolor="#FFFFFF">319,795 ns</td><td align="right" bgcolor="#FFFFFF">319,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 286,076 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1885,128 ns</td><td align="right" bgcolor="#FFFFFF">1826,963 ns</td><td align="right" bgcolor="#FFFFFF">1599,052 ns</td><td align="right" bgcolor="#FFFFFF">1652,157 ns</td><td align="right" bgcolor="#FFFFFF">1686,870 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,885 μs</td><td align="right" bgcolor="#FFFFFF">1,827 μs</td><td align="right" bgcolor="#FFFFFF">1,599 μs</td><td align="right" bgcolor="#FFFFFF">1,652 μs</td><td align="right" bgcolor="#FFFFFF">1,687 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">336,000 (Δ = -315,000)</td><td align="right" bgcolor="#FFFFFF">336,000</td><td align="right" bgcolor="#FFFFFF">336,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,328 (Δ = -0,308)</td><td align="right" bgcolor="#FFFFFF">0,328</td><td align="right" bgcolor="#FFFFFF">0,328</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 395,607 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3838,757 ns</td><td align="right" bgcolor="#FFFFFF">3599,820 ns</td><td align="right" bgcolor="#FFFFFF">3443,150 ns</td><td align="right" bgcolor="#FFFFFF">3476,637 ns</td><td align="right" bgcolor="#FFFFFF">3564,122 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,839 μs</td><td align="right" bgcolor="#FFFFFF">3,600 μs</td><td align="right" bgcolor="#FFFFFF">3,443 μs</td><td align="right" bgcolor="#FFFFFF">3,477 μs</td><td align="right" bgcolor="#FFFFFF">3,564 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#A8D08D">1368,000 (Δ = -619,000)</td><td align="right" bgcolor="#FFFFFF">1368,000</td><td align="right" bgcolor="#FFFFFF">1368,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#A8D08D">1,336 (Δ = -0,604)</td><td align="right" bgcolor="#FFFFFF">1,336</td><td align="right" bgcolor="#FFFFFF">1,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 526,170 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+178,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272,075 ns</td><td align="right" bgcolor="#FFFFFF">286,471 ns</td><td align="right" bgcolor="#FF4949">798,245 ns (Δ = +511,774 ns)</td><td align="right" bgcolor="#FFFFFF">787,938 ns</td><td align="right" bgcolor="#FFFFFF">787,943 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs</td><td align="right" bgcolor="#FFFFFF">0,788 μs</td><td align="right" bgcolor="#FFFFFF">0,788 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 56,717 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,900 ns</td><td align="right" bgcolor="#FFFFFF">44,310 ns</td><td align="right" bgcolor="#FFFFFF">101,027 ns</td><td align="right" bgcolor="#FFFFFF">99,782 ns</td><td align="right" bgcolor="#FFFFFF">99,957 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,127 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,453 ns</td><td align="right" bgcolor="#FFFFFF">6,430 ns</td><td align="right" bgcolor="#FFFFFF">6,335 ns</td><td align="right" bgcolor="#FFFFFF">6,352 ns</td><td align="right" bgcolor="#FFFFFF">6,327 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 0,093 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,527 ns</td><td align="right" bgcolor="#FFFFFF">7,437 ns</td><td align="right" bgcolor="#FFFFFF">7,530 ns</td><td align="right" bgcolor="#FFFFFF">7,490 ns</td><td align="right" bgcolor="#FFFFFF">7,480 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 261,897 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">897,273 ns</td><td align="right" bgcolor="#FFFFFF">1090,685 ns</td><td align="right" bgcolor="#FFFFFF">1159,170 ns</td><td align="right" bgcolor="#FFFFFF">1144,012 ns</td><td align="right" bgcolor="#FFFFFF">1129,130 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,897 μs</td><td align="right" bgcolor="#FFFFFF">1,091 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td><td align="right" bgcolor="#FFFFFF">1,144 μs</td><td align="right" bgcolor="#FFFFFF">1,129 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#A8D08D">-26,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">979,000</td><td align="right" bgcolor="#FF4949">1073,000 (Δ = +94,000)</td><td align="right" bgcolor="#A8D08D">791,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">791,000</td><td align="right" bgcolor="#FFFFFF">791,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,956</td><td align="right" bgcolor="#FF4949">1,048 (Δ = +0,092)</td><td align="right" bgcolor="#A8D08D">0,772 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,772</td><td align="right" bgcolor="#FFFFFF">0,772</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 60,987 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">435,242 ns</td><td align="right" bgcolor="#FFFFFF">468,697 ns</td><td align="right" bgcolor="#FFFFFF">496,228 ns</td><td align="right" bgcolor="#FFFFFF">469,920 ns</td><td align="right" bgcolor="#FFFFFF">449,108 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,435 μs</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,496 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">459,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">360,000</td><td align="right" bgcolor="#FFFFFF">360,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,448 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,352 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,352</td><td align="right" bgcolor="#FFFFFF">0,352</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 471,385 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,3 %</td><td align="right" bgcolor="#A8D08D">-14,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2024,035 ns</td><td align="right" bgcolor="#FF4949">2495,420 ns (Δ = +471,385 ns)</td><td align="right" bgcolor="#A8D08D">2134,580 ns (Δ = -360,840 ns)</td><td align="right" bgcolor="#FFFFFF">2133,565 ns</td><td align="right" bgcolor="#FFFFFF">2195,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,024 μs</td><td align="right" bgcolor="#FFFFFF">2,495 μs</td><td align="right" bgcolor="#FFFFFF">2,135 μs</td><td align="right" bgcolor="#FFFFFF">2,134 μs</td><td align="right" bgcolor="#FFFFFF">2,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3969,000</td><td align="right" bgcolor="#FF4949">4067,000 (Δ = +98,000)</td><td align="right" bgcolor="#A8D08D">2245,000 (Δ = -1822,000)</td><td align="right" bgcolor="#FFFFFF">2245,000</td><td align="right" bgcolor="#FFFFFF">2245,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,876</td><td align="right" bgcolor="#FF4949">3,972 (Δ = +0,096)</td><td align="right" bgcolor="#A8D08D">2,192 (Δ = -1,779)</td><td align="right" bgcolor="#FFFFFF">2,192</td><td align="right" bgcolor="#FFFFFF">2,192</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 212,168 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1087,808 ns</td><td align="right" bgcolor="#FFFFFF">958,908 ns</td><td align="right" bgcolor="#FFFFFF">890,615 ns</td><td align="right" bgcolor="#FFFFFF">875,640 ns</td><td align="right" bgcolor="#FFFFFF">917,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,088 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,876 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1857,000</td><td align="right" bgcolor="#FF4949">1860,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -865,000)</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,813</td><td align="right" bgcolor="#FF4949">1,816 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,845)</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,715 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,462 ns</td><td align="right" bgcolor="#FFFFFF">20,445 ns</td><td align="right" bgcolor="#FFFFFF">27,182 ns</td><td align="right" bgcolor="#FFFFFF">28,160 ns</td><td align="right" bgcolor="#FFFFFF">28,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#A8D08D">53,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">53,000</td><td align="right" bgcolor="#FFFFFF">53,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#A8D08D">0,052 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,052</td><td align="right" bgcolor="#FFFFFF">0,052</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 163,823 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">565,867 ns</td><td align="right" bgcolor="#FFFFFF">402,043 ns</td><td align="right" bgcolor="#FFFFFF">404,085 ns</td><td align="right" bgcolor="#FFFFFF">407,645 ns</td><td align="right" bgcolor="#FFFFFF">403,663 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,408 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 153,118 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">603,322 ns</td><td align="right" bgcolor="#FFFFFF">589,418 ns</td><td align="right" bgcolor="#FFFFFF">679,227 ns</td><td align="right" bgcolor="#FFFFFF">742,536 ns</td><td align="right" bgcolor="#FFFFFF">672,412 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,589 μs</td><td align="right" bgcolor="#FFFFFF">0,679 μs</td><td align="right" bgcolor="#FFFFFF">0,743 μs</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 104,937 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">755,592 ns</td><td align="right" bgcolor="#FFFFFF">708,760 ns</td><td align="right" bgcolor="#FFFFFF">813,697 ns</td><td align="right" bgcolor="#FFFFFF">813,420 ns</td><td align="right" bgcolor="#FFFFFF">800,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,813 μs</td><td align="right" bgcolor="#FFFFFF">0,801 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 367,397 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,4 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">894,020 ns</td><td align="right" bgcolor="#FFFFFF">848,645 ns</td><td align="right" bgcolor="#FFFFFF">962,092 ns</td><td align="right" bgcolor="#FF4949">1216,042 ns (Δ = +253,950 ns)</td><td align="right" bgcolor="#A8D08D">953,830 ns (Δ = -262,212 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,894 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">1,216 μs</td><td align="right" bgcolor="#FFFFFF">0,954 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 103,283 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1029,320 ns</td><td align="right" bgcolor="#FFFFFF">1012,973 ns</td><td align="right" bgcolor="#FFFFFF">1116,257 ns</td><td align="right" bgcolor="#FFFFFF">1114,665 ns</td><td align="right" bgcolor="#FFFFFF">1109,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">1,116 μs</td><td align="right" bgcolor="#FFFFFF">1,115 μs</td><td align="right" bgcolor="#FFFFFF">1,109 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 100,777 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1165,263 ns</td><td align="right" bgcolor="#FFFFFF">1165,742 ns</td><td align="right" bgcolor="#FFFFFF">1255,628 ns</td><td align="right" bgcolor="#FFFFFF">1249,255 ns</td><td align="right" bgcolor="#FFFFFF">1266,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,165 μs</td><td align="right" bgcolor="#FFFFFF">1,166 μs</td><td align="right" bgcolor="#FFFFFF">1,256 μs</td><td align="right" bgcolor="#FFFFFF">1,249 μs</td><td align="right" bgcolor="#FFFFFF">1,266 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 172,470 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1354,228 ns</td><td align="right" bgcolor="#FFFFFF">1384,517 ns</td><td align="right" bgcolor="#FFFFFF">1509,863 ns</td><td align="right" bgcolor="#FFFFFF">1510,158 ns</td><td align="right" bgcolor="#FFFFFF">1526,698 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,354 μs</td><td align="right" bgcolor="#FFFFFF">1,385 μs</td><td align="right" bgcolor="#FFFFFF">1,510 μs</td><td align="right" bgcolor="#FFFFFF">1,510 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 270,428 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1430,872 ns</td><td align="right" bgcolor="#FFFFFF">1515,455 ns</td><td align="right" bgcolor="#FFFFFF">1701,300 ns</td><td align="right" bgcolor="#FFFFFF">1649,413 ns</td><td align="right" bgcolor="#FFFFFF">1642,848 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,431 μs</td><td align="right" bgcolor="#FFFFFF">1,515 μs</td><td align="right" bgcolor="#FFFFFF">1,701 μs</td><td align="right" bgcolor="#FFFFFF">1,649 μs</td><td align="right" bgcolor="#FFFFFF">1,643 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 4,785 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,987 ns</td><td align="right" bgcolor="#FFFFFF">5,507 ns</td><td align="right" bgcolor="#FFFFFF">0,722 ns</td><td align="right" bgcolor="#FFFFFF">1,002 ns</td><td align="right" bgcolor="#FFFFFF">1,025 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 7,792 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,328 ns</td><td align="right" bgcolor="#FFFFFF">21,108 ns</td><td align="right" bgcolor="#FFFFFF">13,317 ns</td><td align="right" bgcolor="#FFFFFF">13,687 ns</td><td align="right" bgcolor="#FFFFFF">15,087 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 6,387 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,238 ns</td><td align="right" bgcolor="#FFFFFF">16,682 ns</td><td align="right" bgcolor="#FFFFFF">10,668 ns</td><td align="right" bgcolor="#FFFFFF">10,295 ns</td><td align="right" bgcolor="#FFFFFF">10,415 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 99,715 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">279,502 ns</td><td align="right" bgcolor="#FFFFFF">278,807 ns</td><td align="right" bgcolor="#FFFFFF">378,522 ns</td><td align="right" bgcolor="#FFFFFF">376,260 ns</td><td align="right" bgcolor="#FFFFFF">348,395 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,379 μs</td><td align="right" bgcolor="#FFFFFF">0,376 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#A8D08D">-37,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 103,158 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">604,785 ns</td><td align="right" bgcolor="#FFFFFF">647,025 ns</td><td align="right" bgcolor="#FFFFFF">707,943 ns</td><td align="right" bgcolor="#FFFFFF">698,332 ns</td><td align="right" bgcolor="#FFFFFF">689,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,708 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td><td align="right" bgcolor="#FFFFFF">0,689 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-32,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">385,000</td><td align="right" bgcolor="#A8D08D">352,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">238,000 (Δ = -114,000)</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,376</td><td align="right" bgcolor="#A8D08D">0,344 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,232 (Δ = -0,111)</td><td align="right" bgcolor="#FFFFFF">0,232</td><td align="right" bgcolor="#FFFFFF">0,232</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 151,635 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">512,490 ns</td><td align="right" bgcolor="#FFFFFF">501,970 ns</td><td align="right" bgcolor="#FFFFFF">646,862 ns</td><td align="right" bgcolor="#FFFFFF">653,605 ns</td><td align="right" bgcolor="#FFFFFF">641,597 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,512 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#A8D08D">-26,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">377,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -90,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,368</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,088)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 197,888 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">595,472 ns</td><td align="right" bgcolor="#FFFFFF">551,440 ns</td><td align="right" bgcolor="#FFFFFF">647,293 ns</td><td align="right" bgcolor="#FFFFFF">749,328 ns</td><td align="right" bgcolor="#FFFFFF">642,937 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,595 μs</td><td align="right" bgcolor="#FFFFFF">0,551 μs</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,749 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 116,517 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">741,888 ns</td><td align="right" bgcolor="#FFFFFF">701,750 ns</td><td align="right" bgcolor="#FFFFFF">818,267 ns</td><td align="right" bgcolor="#FFFFFF">809,827 ns</td><td align="right" bgcolor="#FFFFFF">804,212 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,742 μs</td><td align="right" bgcolor="#FFFFFF">0,702 μs</td><td align="right" bgcolor="#FFFFFF">0,818 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td><td align="right" bgcolor="#FFFFFF">0,804 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 103,829 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">879,505 ns</td><td align="right" bgcolor="#FFFFFF">862,428 ns</td><td align="right" bgcolor="#FFFFFF">943,352 ns</td><td align="right" bgcolor="#FFFFFF">966,257 ns</td><td align="right" bgcolor="#FFFFFF">956,387 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,880 μs</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,943 μs</td><td align="right" bgcolor="#FFFFFF">0,966 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 106,083 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1032,983 ns</td><td align="right" bgcolor="#FFFFFF">1014,182 ns</td><td align="right" bgcolor="#FFFFFF">1112,493 ns</td><td align="right" bgcolor="#FFFFFF">1113,468 ns</td><td align="right" bgcolor="#FFFFFF">1120,265 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,033 μs</td><td align="right" bgcolor="#FFFFFF">1,014 μs</td><td align="right" bgcolor="#FFFFFF">1,112 μs</td><td align="right" bgcolor="#FFFFFF">1,113 μs</td><td align="right" bgcolor="#FFFFFF">1,120 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 95,558 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1180,058 ns</td><td align="right" bgcolor="#FFFFFF">1176,815 ns</td><td align="right" bgcolor="#FFFFFF">1272,373 ns</td><td align="right" bgcolor="#FFFFFF">1251,457 ns</td><td align="right" bgcolor="#FFFFFF">1256,233 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,180 μs</td><td align="right" bgcolor="#FFFFFF">1,177 μs</td><td align="right" bgcolor="#FFFFFF">1,272 μs</td><td align="right" bgcolor="#FFFFFF">1,251 μs</td><td align="right" bgcolor="#FFFFFF">1,256 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 231,708 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1313,393 ns</td><td align="right" bgcolor="#FFFFFF">1368,843 ns</td><td align="right" bgcolor="#FFFFFF">1503,903 ns</td><td align="right" bgcolor="#FFFFFF">1506,987 ns</td><td align="right" bgcolor="#FFFFFF">1545,102 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,313 μs</td><td align="right" bgcolor="#FFFFFF">1,369 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td><td align="right" bgcolor="#FFFFFF">1,507 μs</td><td align="right" bgcolor="#FFFFFF">1,545 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 273,555 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1436,172 ns</td><td align="right" bgcolor="#FFFFFF">1510,723 ns</td><td align="right" bgcolor="#FFFFFF">1709,727 ns</td><td align="right" bgcolor="#FFFFFF">1656,930 ns</td><td align="right" bgcolor="#FFFFFF">1655,238 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,436 μs</td><td align="right" bgcolor="#FFFFFF">1,511 μs</td><td align="right" bgcolor="#FFFFFF">1,710 μs</td><td align="right" bgcolor="#FFFFFF">1,657 μs</td><td align="right" bgcolor="#FFFFFF">1,655 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 116,637 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">610,720 ns</td><td align="right" bgcolor="#FFFFFF">609,643 ns</td><td align="right" bgcolor="#FFFFFF">726,280 ns</td><td align="right" bgcolor="#FFFFFF">700,460 ns</td><td align="right" bgcolor="#FFFFFF">674,312 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,674 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 129,108 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">759,700 ns</td><td align="right" bgcolor="#FFFFFF">742,338 ns</td><td align="right" bgcolor="#FFFFFF">842,537 ns</td><td align="right" bgcolor="#FFFFFF">871,447 ns</td><td align="right" bgcolor="#FFFFFF">855,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td><td align="right" bgcolor="#FFFFFF">0,742 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#FFFFFF">0,855 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">274,000 (Δ = -144,000)</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FFFFFF">274,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,268 (Δ = -0,141)</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FFFFFF">0,268</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 195,847 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">894,430 ns</td><td align="right" bgcolor="#FFFFFF">900,495 ns</td><td align="right" bgcolor="#FFFFFF">1005,885 ns</td><td align="right" bgcolor="#FFFFFF">1090,277 ns</td><td align="right" bgcolor="#FFFFFF">989,192 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,894 μs</td><td align="right" bgcolor="#FFFFFF">0,900 μs</td><td align="right" bgcolor="#FFFFFF">1,006 μs</td><td align="right" bgcolor="#FFFFFF">1,090 μs</td><td align="right" bgcolor="#FFFFFF">0,989 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-35,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">500,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">324,000 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,488 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,316 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 153,875 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1043,938 ns</td><td align="right" bgcolor="#FFFFFF">1060,537 ns</td><td align="right" bgcolor="#FFFFFF">1197,813 ns</td><td align="right" bgcolor="#FFFFFF">1116,899 ns</td><td align="right" bgcolor="#FFFFFF">1128,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,061 μs</td><td align="right" bgcolor="#FFFFFF">1,198 μs</td><td align="right" bgcolor="#FFFFFF">1,117 μs</td><td align="right" bgcolor="#FFFFFF">1,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 155,013 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1169,200 ns</td><td align="right" bgcolor="#FFFFFF">1302,292 ns</td><td align="right" bgcolor="#FFFFFF">1324,213 ns</td><td align="right" bgcolor="#FFFFFF">1265,237 ns</td><td align="right" bgcolor="#FFFFFF">1248,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,169 μs</td><td align="right" bgcolor="#FFFFFF">1,302 μs</td><td align="right" bgcolor="#FFFFFF">1,324 μs</td><td align="right" bgcolor="#FFFFFF">1,265 μs</td><td align="right" bgcolor="#FFFFFF">1,249 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 139,833 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1292,772 ns</td><td align="right" bgcolor="#FFFFFF">1384,705 ns</td><td align="right" bgcolor="#FFFFFF">1432,605 ns</td><td align="right" bgcolor="#FFFFFF">1406,812 ns</td><td align="right" bgcolor="#FFFFFF">1412,483 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,293 μs</td><td align="right" bgcolor="#FFFFFF">1,385 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,407 μs</td><td align="right" bgcolor="#FFFFFF">1,412 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">737,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -270,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,720 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,264)</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 150,340 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1442,872 ns</td><td align="right" bgcolor="#FFFFFF">1439,238 ns</td><td align="right" bgcolor="#FFFFFF">1589,578 ns</td><td align="right" bgcolor="#FFFFFF">1579,065 ns</td><td align="right" bgcolor="#FFFFFF">1569,227 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,443 μs</td><td align="right" bgcolor="#FFFFFF">1,439 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,579 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">819,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -303,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,800 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,296)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 94,758 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">596,997 ns</td><td align="right" bgcolor="#FFFFFF">574,283 ns</td><td align="right" bgcolor="#FFFFFF">669,042 ns</td><td align="right" bgcolor="#FFFFFF">648,121 ns</td><td align="right" bgcolor="#FFFFFF">638,402 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,574 μs</td><td align="right" bgcolor="#FFFFFF">0,669 μs</td><td align="right" bgcolor="#FFFFFF">0,648 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 97,820 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">740,780 ns</td><td align="right" bgcolor="#FFFFFF">708,545 ns</td><td align="right" bgcolor="#FFFFFF">806,365 ns</td><td align="right" bgcolor="#FFFFFF">802,657 ns</td><td align="right" bgcolor="#FFFFFF">803,330 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,741 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 149,718 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">993,000 ns</td><td align="right" bgcolor="#FFFFFF">843,282 ns</td><td align="right" bgcolor="#FFFFFF">968,253 ns</td><td align="right" bgcolor="#FFFFFF">969,898 ns</td><td align="right" bgcolor="#FFFFFF">960,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,968 μs</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td><td align="right" bgcolor="#FFFFFF">0,960 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 145,732 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1057,718 ns</td><td align="right" bgcolor="#FFFFFF">1015,473 ns</td><td align="right" bgcolor="#FFFFFF">1161,205 ns</td><td align="right" bgcolor="#FFFFFF">1119,598 ns</td><td align="right" bgcolor="#FFFFFF">1105,640 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,058 μs</td><td align="right" bgcolor="#FFFFFF">1,015 μs</td><td align="right" bgcolor="#FFFFFF">1,161 μs</td><td align="right" bgcolor="#FFFFFF">1,120 μs</td><td align="right" bgcolor="#FFFFFF">1,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 121,726 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1190,954 ns</td><td align="right" bgcolor="#FFFFFF">1171,427 ns</td><td align="right" bgcolor="#FFFFFF">1293,153 ns</td><td align="right" bgcolor="#FFFFFF">1263,039 ns</td><td align="right" bgcolor="#FFFFFF">1263,507 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,191 μs</td><td align="right" bgcolor="#FFFFFF">1,171 μs</td><td align="right" bgcolor="#FFFFFF">1,293 μs</td><td align="right" bgcolor="#FFFFFF">1,263 μs</td><td align="right" bgcolor="#FFFFFF">1,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 241,928 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1309,720 ns</td><td align="right" bgcolor="#FFFFFF">1373,867 ns</td><td align="right" bgcolor="#FFFFFF">1551,648 ns</td><td align="right" bgcolor="#FFFFFF">1520,948 ns</td><td align="right" bgcolor="#FFFFFF">1527,080 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,310 μs</td><td align="right" bgcolor="#FFFFFF">1,374 μs</td><td align="right" bgcolor="#FFFFFF">1,552 μs</td><td align="right" bgcolor="#FFFFFF">1,521 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 256,163 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1429,168 ns</td><td align="right" bgcolor="#FFFFFF">1503,990 ns</td><td align="right" bgcolor="#FFFFFF">1668,662 ns</td><td align="right" bgcolor="#FFFFFF">1663,543 ns</td><td align="right" bgcolor="#FFFFFF">1685,332 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,429 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td><td align="right" bgcolor="#FFFFFF">1,669 μs</td><td align="right" bgcolor="#FFFFFF">1,664 μs</td><td align="right" bgcolor="#FFFFFF">1,685 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 84,988 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">599,408 ns</td><td align="right" bgcolor="#FFFFFF">581,638 ns</td><td align="right" bgcolor="#FFFFFF">666,627 ns</td><td align="right" bgcolor="#FFFFFF">646,647 ns</td><td align="right" bgcolor="#FFFFFF">658,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,599 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,667 μs</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 152,778 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">738,190 ns</td><td align="right" bgcolor="#FFFFFF">697,760 ns</td><td align="right" bgcolor="#FFFFFF">850,538 ns</td><td align="right" bgcolor="#FFFFFF">804,612 ns</td><td align="right" bgcolor="#FFFFFF">817,483 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td><td align="right" bgcolor="#FFFFFF">0,817 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 148,956 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">881,353 ns</td><td align="right" bgcolor="#FFFFFF">839,453 ns</td><td align="right" bgcolor="#FFFFFF">980,145 ns</td><td align="right" bgcolor="#FFFFFF">968,522 ns</td><td align="right" bgcolor="#FFFFFF">988,409 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,881 μs</td><td align="right" bgcolor="#FFFFFF">0,839 μs</td><td align="right" bgcolor="#FFFFFF">0,980 μs</td><td align="right" bgcolor="#FFFFFF">0,969 μs</td><td align="right" bgcolor="#FFFFFF">0,988 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 120,684 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1026,120 ns</td><td align="right" bgcolor="#FFFFFF">1011,713 ns</td><td align="right" bgcolor="#FFFFFF">1113,727 ns</td><td align="right" bgcolor="#FFFFFF">1132,398 ns</td><td align="right" bgcolor="#FFFFFF">1122,963 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,026 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">1,114 μs</td><td align="right" bgcolor="#FFFFFF">1,132 μs</td><td align="right" bgcolor="#FFFFFF">1,123 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 120,927 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1167,830 ns</td><td align="right" bgcolor="#FFFFFF">1174,017 ns</td><td align="right" bgcolor="#FFFFFF">1283,455 ns</td><td align="right" bgcolor="#FFFFFF">1288,757 ns</td><td align="right" bgcolor="#FFFFFF">1267,985 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,168 μs</td><td align="right" bgcolor="#FFFFFF">1,174 μs</td><td align="right" bgcolor="#FFFFFF">1,283 μs</td><td align="right" bgcolor="#FFFFFF">1,289 μs</td><td align="right" bgcolor="#FFFFFF">1,268 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 195,283 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1328,675 ns</td><td align="right" bgcolor="#FFFFFF">1365,210 ns</td><td align="right" bgcolor="#FFFFFF">1506,078 ns</td><td align="right" bgcolor="#FFFFFF">1513,710 ns</td><td align="right" bgcolor="#FFFFFF">1523,958 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,329 μs</td><td align="right" bgcolor="#FFFFFF">1,365 μs</td><td align="right" bgcolor="#FFFFFF">1,506 μs</td><td align="right" bgcolor="#FFFFFF">1,514 μs</td><td align="right" bgcolor="#FFFFFF">1,524 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 202,560 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1462,607 ns</td><td align="right" bgcolor="#FFFFFF">1486,775 ns</td><td align="right" bgcolor="#FFFFFF">1638,592 ns</td><td align="right" bgcolor="#FFFFFF">1650,693 ns</td><td align="right" bgcolor="#FFFFFF">1665,167 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,487 μs</td><td align="right" bgcolor="#FFFFFF">1,639 μs</td><td align="right" bgcolor="#FFFFFF">1,651 μs</td><td align="right" bgcolor="#FFFFFF">1,665 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 49,687 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">321,580 ns</td><td align="right" bgcolor="#FFFFFF">271,893 ns</td><td align="right" bgcolor="#FFFFFF">277,767 ns</td><td align="right" bgcolor="#FFFFFF">288,095 ns</td><td align="right" bgcolor="#FFFFFF">281,607 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 178,643 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">479,147 ns</td><td align="right" bgcolor="#FFFFFF">300,503 ns</td><td align="right" bgcolor="#FFFFFF">377,145 ns</td><td align="right" bgcolor="#FFFFFF">319,015 ns</td><td align="right" bgcolor="#FFFFFF">318,765 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,479 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,377 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 598,840 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3959,892 ns</td><td align="right" bgcolor="#FFFFFF">3976,778 ns</td><td align="right" bgcolor="#FF4949">4558,732 ns (Δ = +581,953 ns)</td><td align="right" bgcolor="#FFFFFF">4311,155 ns</td><td align="right" bgcolor="#FFFFFF">4322,733 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,960 μs</td><td align="right" bgcolor="#FFFFFF">3,977 μs</td><td align="right" bgcolor="#FFFFFF">4,559 μs</td><td align="right" bgcolor="#FFFFFF">4,311 μs</td><td align="right" bgcolor="#FFFFFF">4,323 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 516,048 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6881,825 ns</td><td align="right" bgcolor="#FFFFFF">6779,003 ns</td><td align="right" bgcolor="#FF4949">7247,615 ns (Δ = +468,612 ns)</td><td align="right" bgcolor="#FFFFFF">7266,785 ns</td><td align="right" bgcolor="#FFFFFF">7295,052 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,882 μs</td><td align="right" bgcolor="#FFFFFF">6,779 μs</td><td align="right" bgcolor="#FFFFFF">7,248 μs</td><td align="right" bgcolor="#FFFFFF">7,267 μs</td><td align="right" bgcolor="#FFFFFF">7,295 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 393,097 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5225,720 ns</td><td align="right" bgcolor="#FFFFFF">5167,750 ns</td><td align="right" bgcolor="#FF4949">5560,847 ns (Δ = +393,097 ns)</td><td align="right" bgcolor="#FFFFFF">5495,432 ns</td><td align="right" bgcolor="#FFFFFF">5515,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,226 μs</td><td align="right" bgcolor="#FFFFFF">5,168 μs</td><td align="right" bgcolor="#FFFFFF">5,561 μs</td><td align="right" bgcolor="#FFFFFF">5,495 μs</td><td align="right" bgcolor="#FFFFFF">5,515 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">348,000 (Δ = -328,000)</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,340 (Δ = -0,320)</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 566,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3996,825 ns</td><td align="right" bgcolor="#FFFFFF">3939,925 ns</td><td align="right" bgcolor="#FF4949">4506,383 ns (Δ = +566,458 ns)</td><td align="right" bgcolor="#FFFFFF">4289,562 ns</td><td align="right" bgcolor="#FFFFFF">4296,145 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,997 μs</td><td align="right" bgcolor="#FFFFFF">3,940 μs</td><td align="right" bgcolor="#FFFFFF">4,506 μs</td><td align="right" bgcolor="#FFFFFF">4,290 μs</td><td align="right" bgcolor="#FFFFFF">4,296 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 545,762 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6934,347 ns</td><td align="right" bgcolor="#FFFFFF">6724,378 ns</td><td align="right" bgcolor="#FF4949">7253,840 ns (Δ = +529,462 ns)</td><td align="right" bgcolor="#FFFFFF">7270,140 ns</td><td align="right" bgcolor="#FFFFFF">7208,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,934 μs</td><td align="right" bgcolor="#FFFFFF">6,724 μs</td><td align="right" bgcolor="#FFFFFF">7,254 μs</td><td align="right" bgcolor="#FFFFFF">7,270 μs</td><td align="right" bgcolor="#FFFFFF">7,209 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 758,740 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+9,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7952,740 ns</td><td align="right" bgcolor="#A8D08D">7671,637 ns (Δ = -281,103 ns)</td><td align="right" bgcolor="#FF4949">8430,377 ns (Δ = +758,740 ns)</td><td align="right" bgcolor="#FFFFFF">8290,173 ns</td><td align="right" bgcolor="#FFFFFF">8333,598 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,953 μs</td><td align="right" bgcolor="#FFFFFF">7,672 μs</td><td align="right" bgcolor="#FFFFFF">8,430 μs</td><td align="right" bgcolor="#FFFFFF">8,290 μs</td><td align="right" bgcolor="#FFFFFF">8,334 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -525,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,513)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 779,195 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#FF4949">+17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3435,442 ns</td><td align="right" bgcolor="#A8D08D">2656,247 ns (Δ = -779,195 ns)</td><td align="right" bgcolor="#FF4949">3123,285 ns (Δ = +467,038 ns)</td><td align="right" bgcolor="#FFFFFF">3145,967 ns</td><td align="right" bgcolor="#FFFFFF">3201,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,435 μs</td><td align="right" bgcolor="#FFFFFF">2,656 μs</td><td align="right" bgcolor="#FFFFFF">3,123 μs</td><td align="right" bgcolor="#FFFFFF">3,146 μs</td><td align="right" bgcolor="#FFFFFF">3,202 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 772,005 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FF4949">+17,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3421,818 ns</td><td align="right" bgcolor="#A8D08D">2649,813 ns (Δ = -772,005 ns)</td><td align="right" bgcolor="#FF4949">3105,880 ns (Δ = +456,067 ns)</td><td align="right" bgcolor="#FFFFFF">3130,492 ns</td><td align="right" bgcolor="#FFFFFF">3072,180 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,422 μs</td><td align="right" bgcolor="#FFFFFF">2,650 μs</td><td align="right" bgcolor="#FFFFFF">3,106 μs</td><td align="right" bgcolor="#FFFFFF">3,130 μs</td><td align="right" bgcolor="#FFFFFF">3,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1752,861 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,4 %</td><td align="right" bgcolor="#FF4949">+19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4451,263 ns</td><td align="right" bgcolor="#A8D08D">2698,402 ns (Δ = -1752,861 ns)</td><td align="right" bgcolor="#FF4949">3213,552 ns (Δ = +515,150 ns)</td><td align="right" bgcolor="#FFFFFF">3201,360 ns</td><td align="right" bgcolor="#FFFFFF">3216,008 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,451 μs</td><td align="right" bgcolor="#FFFFFF">2,698 μs</td><td align="right" bgcolor="#FFFFFF">3,214 μs</td><td align="right" bgcolor="#FFFFFF">3,201 μs</td><td align="right" bgcolor="#FFFFFF">3,216 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,3 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1888,000</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -893,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -430,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,844</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,872)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,420)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 59,718 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,792 ns</td><td align="right" bgcolor="#FFFFFF">143,753 ns</td><td align="right" bgcolor="#FFFFFF">185,510 ns</td><td align="right" bgcolor="#FFFFFF">148,195 ns</td><td align="right" bgcolor="#FFFFFF">154,350 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 18,447 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">129,270 ns</td><td align="right" bgcolor="#FFFFFF">139,303 ns</td><td align="right" bgcolor="#FFFFFF">142,750 ns</td><td align="right" bgcolor="#FFFFFF">147,717 ns</td><td align="right" bgcolor="#FFFFFF">147,143 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 22,483 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">120,993 ns</td><td align="right" bgcolor="#FFFFFF">136,205 ns</td><td align="right" bgcolor="#FFFFFF">138,130 ns</td><td align="right" bgcolor="#FFFFFF">143,477 ns</td><td align="right" bgcolor="#FFFFFF">140,633 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1277,203 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1712,163 ns</td><td align="right" bgcolor="#A8D08D">434,960 ns (Δ = -1277,203 ns)</td><td align="right" bgcolor="#FFFFFF">463,548 ns</td><td align="right" bgcolor="#FFFFFF">480,767 ns</td><td align="right" bgcolor="#FFFFFF">458,478 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,712 μs</td><td align="right" bgcolor="#FFFFFF">0,435 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,458 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1362,078 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1824,957 ns</td><td align="right" bgcolor="#A8D08D">462,878 ns (Δ = -1362,078 ns)</td><td align="right" bgcolor="#FFFFFF">484,527 ns</td><td align="right" bgcolor="#FFFFFF">551,815 ns</td><td align="right" bgcolor="#FFFFFF">496,220 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,825 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,485 μs</td><td align="right" bgcolor="#FFFFFF">0,552 μs</td><td align="right" bgcolor="#FFFFFF">0,496 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1257,125 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1597,275 ns</td><td align="right" bgcolor="#A8D08D">340,150 ns (Δ = -1257,125 ns)</td><td align="right" bgcolor="#FFFFFF">347,692 ns</td><td align="right" bgcolor="#FFFFFF">349,327 ns</td><td align="right" bgcolor="#FFFFFF">359,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,597 μs</td><td align="right" bgcolor="#FFFFFF">0,340 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-90,5 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,568 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,490 ns</td><td align="right" bgcolor="#FFFFFF">2,188 ns</td><td align="right" bgcolor="#FFFFFF">3,078 ns</td><td align="right" bgcolor="#FFFFFF">3,757 ns</td><td align="right" bgcolor="#FFFFFF">3,042 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,267 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,262 ns</td><td align="right" bgcolor="#FFFFFF">2,175 ns</td><td align="right" bgcolor="#FFFFFF">2,245 ns</td><td align="right" bgcolor="#FFFFFF">2,380 ns</td><td align="right" bgcolor="#FFFFFF">2,442 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 5,208 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,512 ns</td><td align="right" bgcolor="#FFFFFF">7,937 ns</td><td align="right" bgcolor="#FFFFFF">12,632 ns</td><td align="right" bgcolor="#FFFFFF">13,145 ns</td><td align="right" bgcolor="#FFFFFF">12,592 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,567 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,807 ns</td><td align="right" bgcolor="#FFFFFF">2,240 ns</td><td align="right" bgcolor="#FFFFFF">2,597 ns</td><td align="right" bgcolor="#FFFFFF">2,758 ns</td><td align="right" bgcolor="#FFFFFF">2,693 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 3,078 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,712 ns</td><td align="right" bgcolor="#FFFFFF">8,460 ns</td><td align="right" bgcolor="#FFFFFF">10,537 ns</td><td align="right" bgcolor="#FFFFFF">11,073 ns</td><td align="right" bgcolor="#FFFFFF">11,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 41,387 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,477 ns</td><td align="right" bgcolor="#FFFFFF">2,090 ns</td><td align="right" bgcolor="#FFFFFF">2,692 ns</td><td align="right" bgcolor="#FFFFFF">2,558 ns</td><td align="right" bgcolor="#FFFFFF">2,875 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 9,773 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">49,032 ns</td><td align="right" bgcolor="#FFFFFF">51,062 ns</td><td align="right" bgcolor="#FFFFFF">58,552 ns</td><td align="right" bgcolor="#FFFFFF">58,227 ns</td><td align="right" bgcolor="#FFFFFF">58,805 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,715 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,586 ns</td><td align="right" bgcolor="#FFFFFF">2,517 ns</td><td align="right" bgcolor="#FFFFFF">3,057 ns</td><td align="right" bgcolor="#FFFFFF">3,232 ns</td><td align="right" bgcolor="#FFFFFF">3,187 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,996 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,493 ns</td><td align="right" bgcolor="#FFFFFF">2,379 ns</td><td align="right" bgcolor="#FFFFFF">4,375 ns</td><td align="right" bgcolor="#FFFFFF">3,465 ns</td><td align="right" bgcolor="#FFFFFF">4,303 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 17,464 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,963 ns</td><td align="right" bgcolor="#FFFFFF">78,498 ns</td><td align="right" bgcolor="#FFFFFF">93,035 ns</td><td align="right" bgcolor="#FFFFFF">92,840 ns</td><td align="right" bgcolor="#FFFFFF">93,143 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,042 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,052 ns</td><td align="right" bgcolor="#FFFFFF">0,024 ns</td><td align="right" bgcolor="#FFFFFF">0,040 ns</td><td align="right" bgcolor="#FFFFFF">0,013 ns</td><td align="right" bgcolor="#FFFFFF">0,055 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 23,946 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,257 ns</td><td align="right" bgcolor="#FFFFFF">98,070 ns</td><td align="right" bgcolor="#FFFFFF">121,203 ns</td><td align="right" bgcolor="#FFFFFF">115,845 ns</td><td align="right" bgcolor="#FFFFFF">118,042 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.3.0**

Slowest: 5.2.0

Δ: 557,205 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,6 %</td><td align="right" bgcolor="#A8D08D">-14,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3191,003 ns</td><td align="right" bgcolor="#FFFFFF">3208,718 ns</td><td align="right" bgcolor="#FFFFFF">3257,325 ns</td><td align="right" bgcolor="#FF4949">3733,178 ns (Δ = +475,853 ns)</td><td align="right" bgcolor="#A8D08D">3175,973 ns (Δ = -557,205 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,191 μs</td><td align="right" bgcolor="#FFFFFF">3,209 μs</td><td align="right" bgcolor="#FFFFFF">3,257 μs</td><td align="right" bgcolor="#FFFFFF">3,733 μs</td><td align="right" bgcolor="#FFFFFF">3,176 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-48,0 %</td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1740,000</td><td align="right" bgcolor="#FF4949">1741,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">905,000 (Δ = -836,000)</td><td align="right" bgcolor="#A8D08D">889,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">889,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,699</td><td align="right" bgcolor="#FF4949">1,700 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,884 (Δ = -0,816)</td><td align="right" bgcolor="#A8D08D">0,868 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">0,868</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 2,578 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,698 ns</td><td align="right" bgcolor="#FFFFFF">23,533 ns</td><td align="right" bgcolor="#FFFFFF">25,277 ns</td><td align="right" bgcolor="#FFFFFF">24,537 ns</td><td align="right" bgcolor="#FFFFFF">23,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 1923718,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+57,2 %</td><td align="right" bgcolor="#A8D08D">-39,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3089127,195 ns</td><td align="right" bgcolor="#FF4949">4854586,620 ns (Δ = +1765459,425 ns)</td><td align="right" bgcolor="#A8D08D">2940420,107 ns (Δ = -1914166,513 ns)</td><td align="right" bgcolor="#FFFFFF">2942863,237 ns</td><td align="right" bgcolor="#FFFFFF">2930868,047 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3089,127 μs</td><td align="right" bgcolor="#FF4949">4854,587 μs (Δ = +1765,459 μs)</td><td align="right" bgcolor="#A8D08D">2940,420 μs (Δ = -1914,167 μs)</td><td align="right" bgcolor="#FFFFFF">2942,863 μs</td><td align="right" bgcolor="#FFFFFF">2930,868 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,089 ms</td><td align="right" bgcolor="#FFFFFF">4,855 ms</td><td align="right" bgcolor="#FFFFFF">2,940 ms</td><td align="right" bgcolor="#FFFFFF">2,943 ms</td><td align="right" bgcolor="#FFFFFF">2,931 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">55,000</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">52,000</td><td align="right" bgcolor="#FFFFFF">52,000</td><td align="right" bgcolor="#FFFFFF">52,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">52,000 (Δ = +45,000)</td><td align="right" bgcolor="#FFFFFF">52,000</td><td align="right" bgcolor="#FFFFFF">52,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-17,1 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175295,000</td><td align="right" bgcolor="#A8D08D">167378,000 (Δ = -7917,000)</td><td align="right" bgcolor="#A8D08D">138797,000 (Δ = -28581,000)</td><td align="right" bgcolor="#A8D08D">138748,000 (Δ = -49,000)</td><td align="right" bgcolor="#A8D08D">138737,000 (Δ = -11,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">171,187</td><td align="right" bgcolor="#A8D08D">163,455 (Δ = -7,731)</td><td align="right" bgcolor="#A8D08D">135,544 (Δ = -27,911)</td><td align="right" bgcolor="#A8D08D">135,496 (Δ = -0,048)</td><td align="right" bgcolor="#A8D08D">135,485 (Δ = -0,011)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,167</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = 0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 91103,203 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,4 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">633048,328 ns</td><td align="right" bgcolor="#FF4949">724151,532 ns (Δ = +91103,203 ns)</td><td align="right" bgcolor="#A8D08D">678666,857 ns (Δ = -45484,675 ns)</td><td align="right" bgcolor="#A8D08D">652297,413 ns (Δ = -26369,443 ns)</td><td align="right" bgcolor="#A8D08D">642189,367 ns (Δ = -10108,047 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">633,048 μs</td><td align="right" bgcolor="#FFFFFF">724,152 μs</td><td align="right" bgcolor="#FFFFFF">678,667 μs</td><td align="right" bgcolor="#FFFFFF">652,297 μs</td><td align="right" bgcolor="#FFFFFF">642,189 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,633 ms</td><td align="right" bgcolor="#FFFFFF">0,724 ms</td><td align="right" bgcolor="#FFFFFF">0,679 ms</td><td align="right" bgcolor="#FFFFFF">0,652 ms</td><td align="right" bgcolor="#FFFFFF">0,642 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +5,000)</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +30,000)</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">92174,000</td><td align="right" bgcolor="#A8D08D">91075,000 (Δ = -1099,000)</td><td align="right" bgcolor="#A8D08D">87355,000 (Δ = -3720,000)</td><td align="right" bgcolor="#A8D08D">87290,000 (Δ = -65,000)</td><td align="right" bgcolor="#FF4949">87316,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">90,014</td><td align="right" bgcolor="#A8D08D">88,940 (Δ = -1,073)</td><td align="right" bgcolor="#A8D08D">85,308 (Δ = -3,633)</td><td align="right" bgcolor="#A8D08D">85,244 (Δ = -0,063)</td><td align="right" bgcolor="#FF4949">85,270 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,083 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 345060,388 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,5 %</td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">863794,735 ns</td><td align="right" bgcolor="#FF4949">1196326,853 ns (Δ = +332532,118 ns)</td><td align="right" bgcolor="#A8D08D">853373,943 ns (Δ = -342952,910 ns)</td><td align="right" bgcolor="#FFFFFF">851266,465 ns</td><td align="right" bgcolor="#FFFFFF">855645,323 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">863,795 μs</td><td align="right" bgcolor="#FF4949">1196,327 μs (Δ = +332,532 μs)</td><td align="right" bgcolor="#A8D08D">853,374 μs (Δ = -342,953 μs)</td><td align="right" bgcolor="#FFFFFF">851,266 μs</td><td align="right" bgcolor="#FFFFFF">855,645 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,864 ms</td><td align="right" bgcolor="#FFFFFF">1,196 ms</td><td align="right" bgcolor="#FFFFFF">0,853 ms</td><td align="right" bgcolor="#FFFFFF">0,851 ms</td><td align="right" bgcolor="#FFFFFF">0,856 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">99032,000</td><td align="right" bgcolor="#A8D08D">97364,000 (Δ = -1668,000)</td><td align="right" bgcolor="#A8D08D">90795,000 (Δ = -6569,000)</td><td align="right" bgcolor="#A8D08D">90787,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">90762,000 (Δ = -25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">96,711</td><td align="right" bgcolor="#A8D08D">95,082 (Δ = -1,629)</td><td align="right" bgcolor="#A8D08D">88,667 (Δ = -6,415)</td><td align="right" bgcolor="#A8D08D">88,659 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">88,635 (Δ = -0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,006)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td></tr></table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,462 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">77,697 ns</td><td align="right" bgcolor="#FFFFFF">75,820 ns</td><td align="right" bgcolor="#FFFFFF">77,552 ns</td><td align="right" bgcolor="#FFFFFF">80,282 ns</td><td align="right" bgcolor="#FFFFFF">80,142 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,867 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,952 ns</td><td align="right" bgcolor="#FFFFFF">76,805 ns</td><td align="right" bgcolor="#FFFFFF">77,462 ns</td><td align="right" bgcolor="#FFFFFF">78,818 ns</td><td align="right" bgcolor="#FFFFFF">77,623 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 10,355 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,853 ns</td><td align="right" bgcolor="#FFFFFF">80,498 ns</td><td align="right" bgcolor="#FFFFFF">86,287 ns</td><td align="right" bgcolor="#FFFFFF">86,898 ns</td><td align="right" bgcolor="#FFFFFF">86,437 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 45,618 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,218 ns</td><td align="right" bgcolor="#FFFFFF">117,600 ns</td><td align="right" bgcolor="#FFFFFF">128,523 ns</td><td align="right" bgcolor="#FFFFFF">127,815 ns</td><td align="right" bgcolor="#FFFFFF">127,943 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 48,277 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">161,997 ns</td><td align="right" bgcolor="#FFFFFF">113,720 ns</td><td align="right" bgcolor="#FFFFFF">128,168 ns</td><td align="right" bgcolor="#FFFFFF">126,408 ns</td><td align="right" bgcolor="#FFFFFF">128,847 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 27,337 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">72,075 ns</td><td align="right" bgcolor="#FFFFFF">73,060 ns</td><td align="right" bgcolor="#FFFFFF">99,412 ns</td><td align="right" bgcolor="#FFFFFF">83,723 ns</td><td align="right" bgcolor="#FFFFFF">84,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 356,727 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3828,798 ns</td><td align="right" bgcolor="#FFFFFF">3729,300 ns</td><td align="right" bgcolor="#FF4949">4086,027 ns (Δ = +356,727 ns)</td><td align="right" bgcolor="#FFFFFF">3971,058 ns</td><td align="right" bgcolor="#FFFFFF">3952,548 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,829 μs</td><td align="right" bgcolor="#FFFFFF">3,729 μs</td><td align="right" bgcolor="#FFFFFF">4,086 μs</td><td align="right" bgcolor="#FFFFFF">3,971 μs</td><td align="right" bgcolor="#FFFFFF">3,953 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 183,755 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">827,347 ns</td><td align="right" bgcolor="#FFFFFF">812,417 ns</td><td align="right" bgcolor="#FFFFFF">981,950 ns</td><td align="right" bgcolor="#FFFFFF">984,228 ns</td><td align="right" bgcolor="#FFFFFF">996,172 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,827 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#FFFFFF">0,982 μs</td><td align="right" bgcolor="#FFFFFF">0,984 μs</td><td align="right" bgcolor="#FFFFFF">0,996 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 293,267 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4683,500 ns</td><td align="right" bgcolor="#FFFFFF">4554,620 ns</td><td align="right" bgcolor="#FF4949">4847,887 ns (Δ = +293,267 ns)</td><td align="right" bgcolor="#FFFFFF">4846,688 ns</td><td align="right" bgcolor="#FFFFFF">4787,567 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,684 μs</td><td align="right" bgcolor="#FFFFFF">4,555 μs</td><td align="right" bgcolor="#FFFFFF">4,848 μs</td><td align="right" bgcolor="#FFFFFF">4,847 μs</td><td align="right" bgcolor="#FFFFFF">4,788 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -283,000)</td><td align="right" bgcolor="#FFFFFF">303,000</td><td align="right" bgcolor="#FFFFFF">303,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,276)</td><td align="right" bgcolor="#FFFFFF">0,296</td><td align="right" bgcolor="#FFFFFF">0,296</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 231,263 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3856,922 ns</td><td align="right" bgcolor="#FFFFFF">3742,440 ns</td><td align="right" bgcolor="#FFFFFF">3973,703 ns</td><td align="right" bgcolor="#FFFFFF">3964,002 ns</td><td align="right" bgcolor="#FFFFFF">3971,067 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,857 μs</td><td align="right" bgcolor="#FFFFFF">3,742 μs</td><td align="right" bgcolor="#FFFFFF">3,974 μs</td><td align="right" bgcolor="#FFFFFF">3,964 μs</td><td align="right" bgcolor="#FFFFFF">3,971 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 251,252 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">828,857 ns</td><td align="right" bgcolor="#FFFFFF">821,127 ns</td><td align="right" bgcolor="#FFFFFF">974,870 ns</td><td align="right" bgcolor="#FFFFFF">986,645 ns</td><td align="right" bgcolor="#FFFFFF">1072,378 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,829 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,975 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 177,989 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">696,032 ns</td><td align="right" bgcolor="#FFFFFF">667,435 ns</td><td align="right" bgcolor="#FFFFFF">829,190 ns</td><td align="right" bgcolor="#FFFFFF">827,140 ns</td><td align="right" bgcolor="#FFFFFF">845,423 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,696 μs</td><td align="right" bgcolor="#FFFFFF">0,667 μs</td><td align="right" bgcolor="#FFFFFF">0,829 μs</td><td align="right" bgcolor="#FFFFFF">0,827 μs</td><td align="right" bgcolor="#FFFFFF">0,845 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">90,000</td><td align="right" bgcolor="#FFFFFF">90,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,088 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#FFFFFF">0,088</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 118,398 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">538,383 ns</td><td align="right" bgcolor="#FFFFFF">419,985 ns</td><td align="right" bgcolor="#FFFFFF">497,812 ns</td><td align="right" bgcolor="#FFFFFF">441,508 ns</td><td align="right" bgcolor="#FFFFFF">423,703 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,538 μs</td><td align="right" bgcolor="#FFFFFF">0,420 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td><td align="right" bgcolor="#FFFFFF">0,442 μs</td><td align="right" bgcolor="#FFFFFF">0,424 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 52,720 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">194,913 ns</td><td align="right" bgcolor="#FFFFFF">147,482 ns</td><td align="right" bgcolor="#FFFFFF">144,165 ns</td><td align="right" bgcolor="#FFFFFF">142,193 ns</td><td align="right" bgcolor="#FFFFFF">143,160 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 48,514 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,067 ns</td><td align="right" bgcolor="#FFFFFF">146,408 ns</td><td align="right" bgcolor="#FFFFFF">144,553 ns</td><td align="right" bgcolor="#FFFFFF">145,590 ns</td><td align="right" bgcolor="#FFFFFF">144,605 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 219770,740 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#A8D08D">-32,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">661477,837 ns</td><td align="right" bgcolor="#A8D08D">650694,110 ns (Δ = -10783,727 ns)</td><td align="right" bgcolor="#A8D08D">442292,312 ns (Δ = -208401,798 ns)</td><td align="right" bgcolor="#FFFFFF">445843,727 ns</td><td align="right" bgcolor="#FFFFFF">441707,097 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">661,478 μs</td><td align="right" bgcolor="#FFFFFF">650,694 μs</td><td align="right" bgcolor="#FFFFFF">442,292 μs</td><td align="right" bgcolor="#FFFFFF">445,844 μs</td><td align="right" bgcolor="#FFFFFF">441,707 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,661 ms</td><td align="right" bgcolor="#FFFFFF">0,651 ms</td><td align="right" bgcolor="#FFFFFF">0,442 ms</td><td align="right" bgcolor="#FFFFFF">0,446 ms</td><td align="right" bgcolor="#FFFFFF">0,442 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-38,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">110637,000</td><td align="right" bgcolor="#A8D08D">103132,000 (Δ = -7505,000)</td><td align="right" bgcolor="#A8D08D">63865,000 (Δ = -39267,000)</td><td align="right" bgcolor="#FF4949">63867,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">63865,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">108,044</td><td align="right" bgcolor="#A8D08D">100,715 (Δ = -7,329)</td><td align="right" bgcolor="#A8D08D">62,368 (Δ = -38,347)</td><td align="right" bgcolor="#FF4949">62,370 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">62,368 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,106</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = -0,037)</td><td align="right" bgcolor="#FF4949">0,061 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 203472,207 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">422355,470 ns</td><td align="right" bgcolor="#FFFFFF">418483,608 ns</td><td align="right" bgcolor="#A8D08D">219633,435 ns (Δ = -198850,173 ns)</td><td align="right" bgcolor="#FF4949">222030,863 ns (Δ = +2397,428 ns)</td><td align="right" bgcolor="#A8D08D">218883,263 ns (Δ = -3147,600 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">422,355 μs</td><td align="right" bgcolor="#FFFFFF">418,484 μs</td><td align="right" bgcolor="#FFFFFF">219,633 μs</td><td align="right" bgcolor="#FFFFFF">222,031 μs</td><td align="right" bgcolor="#FFFFFF">218,883 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,422 ms</td><td align="right" bgcolor="#FFFFFF">0,418 ms</td><td align="right" bgcolor="#FFFFFF">0,220 ms</td><td align="right" bgcolor="#FFFFFF">0,222 ms</td><td align="right" bgcolor="#FFFFFF">0,219 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">39191,000</td><td align="right" bgcolor="#A8D08D">37901,000 (Δ = -1290,000)</td><td align="right" bgcolor="#A8D08D">20021,000 (Δ = -17880,000)</td><td align="right" bgcolor="#FFFFFF">20021,000</td><td align="right" bgcolor="#FFFFFF">20021,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">38,272</td><td align="right" bgcolor="#A8D08D">37,013 (Δ = -1,260)</td><td align="right" bgcolor="#A8D08D">19,552 (Δ = -17,461)</td><td align="right" bgcolor="#FFFFFF">19,552</td><td align="right" bgcolor="#FFFFFF">19,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,037</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,019 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,019</td><td align="right" bgcolor="#FFFFFF">0,019</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 219431,462 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-36,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">567417,713 ns</td><td align="right" bgcolor="#A8D08D">556043,408 ns (Δ = -11374,305 ns)</td><td align="right" bgcolor="#A8D08D">350743,783 ns (Δ = -205299,625 ns)</td><td align="right" bgcolor="#FFFFFF">350611,920 ns</td><td align="right" bgcolor="#FFFFFF">347986,252 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">567,418 μs</td><td align="right" bgcolor="#FFFFFF">556,043 μs</td><td align="right" bgcolor="#FFFFFF">350,744 μs</td><td align="right" bgcolor="#FFFFFF">350,612 μs</td><td align="right" bgcolor="#FFFFFF">347,986 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,567 ms</td><td align="right" bgcolor="#FFFFFF">0,556 ms</td><td align="right" bgcolor="#FFFFFF">0,351 ms</td><td align="right" bgcolor="#FFFFFF">0,351 ms</td><td align="right" bgcolor="#FFFFFF">0,348 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">26,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">18,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">18,000</td><td align="right" bgcolor="#FFFFFF">18,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FF4949">8,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-41,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">87805,000</td><td align="right" bgcolor="#A8D08D">82272,000 (Δ = -5533,000)</td><td align="right" bgcolor="#A8D08D">47883,000 (Δ = -34389,000)</td><td align="right" bgcolor="#FFFFFF">47883,000</td><td align="right" bgcolor="#FFFFFF">47883,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">85,747</td><td align="right" bgcolor="#A8D08D">80,344 (Δ = -5,403)</td><td align="right" bgcolor="#A8D08D">46,761 (Δ = -33,583)</td><td align="right" bgcolor="#FFFFFF">46,761</td><td align="right" bgcolor="#FFFFFF">46,761</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,046 (Δ = -0,033)</td><td align="right" bgcolor="#FFFFFF">0,046</td><td align="right" bgcolor="#FFFFFF">0,046</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 255488,972 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1337596,858 ns</td><td align="right" bgcolor="#A8D08D">1294381,397 ns (Δ = -43215,462 ns)</td><td align="right" bgcolor="#A8D08D">1095298,420 ns (Δ = -199082,977 ns)</td><td align="right" bgcolor="#FFFFFF">1084509,695 ns</td><td align="right" bgcolor="#FFFFFF">1082107,887 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1337,597 μs</td><td align="right" bgcolor="#FFFFFF">1294,381 μs</td><td align="right" bgcolor="#FFFFFF">1095,298 μs</td><td align="right" bgcolor="#FFFFFF">1084,510 μs</td><td align="right" bgcolor="#FFFFFF">1082,108 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,338 ms</td><td align="right" bgcolor="#FFFFFF">1,294 ms</td><td align="right" bgcolor="#FFFFFF">1,095 ms</td><td align="right" bgcolor="#FFFFFF">1,085 ms</td><td align="right" bgcolor="#FFFFFF">1,082 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">107,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">72,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">72,000</td><td align="right" bgcolor="#FFFFFF">72,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#A8D08D">11,000 (Δ = -6,000)</td><td align="right" bgcolor="#FFFFFF">11,000</td><td align="right" bgcolor="#FFFFFF">11,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-38,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">337060,000</td><td align="right" bgcolor="#A8D08D">310251,000 (Δ = -26809,000)</td><td align="right" bgcolor="#A8D08D">190725,000 (Δ = -119526,000)</td><td align="right" bgcolor="#FFFFFF">190725,000</td><td align="right" bgcolor="#FFFFFF">190725,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">329,160</td><td align="right" bgcolor="#A8D08D">302,979 (Δ = -26,181)</td><td align="right" bgcolor="#A8D08D">186,255 (Δ = -116,725)</td><td align="right" bgcolor="#FFFFFF">186,255</td><td align="right" bgcolor="#FFFFFF">186,255</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">0,182 (Δ = -0,114)</td><td align="right" bgcolor="#FFFFFF">0,182</td><td align="right" bgcolor="#FFFFFF">0,182</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1149658,275 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17462857,995 ns</td><td align="right" bgcolor="#A8D08D">17210512,760 ns (Δ = -252345,235 ns)</td><td align="right" bgcolor="#FF4949">18209570,760 ns (Δ = +999058,000 ns)</td><td align="right" bgcolor="#FFFFFF">18360171,035 ns</td><td align="right" bgcolor="#FFFFFF">18195220,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17462,858 μs</td><td align="right" bgcolor="#A8D08D">17210,513 μs (Δ = -252,345 μs)</td><td align="right" bgcolor="#FF4949">18209,571 μs (Δ = +999,058 μs)</td><td align="right" bgcolor="#FFFFFF">18360,171 μs</td><td align="right" bgcolor="#FFFFFF">18195,220 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">17,463 ms</td><td align="right" bgcolor="#FFFFFF">17,211 ms</td><td align="right" bgcolor="#FFFFFF">18,210 ms</td><td align="right" bgcolor="#FFFFFF">18,360 ms</td><td align="right" bgcolor="#FFFFFF">18,195 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">491,000</td><td align="right" bgcolor="#A8D08D">478,000 (Δ = -13,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -179,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#A8D08D">159,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">99,000 (Δ = -60,000)</td><td align="right" bgcolor="#FFFFFF">99,000</td><td align="right" bgcolor="#FFFFFF">99,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1547039,000</td><td align="right" bgcolor="#A8D08D">1504725,000 (Δ = -42314,000)</td><td align="right" bgcolor="#A8D08D">785118,000 (Δ = -719607,000)</td><td align="right" bgcolor="#A8D08D">784819,000 (Δ = -299,000)</td><td align="right" bgcolor="#FF4949">784897,000 (Δ = +78,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1510,780</td><td align="right" bgcolor="#A8D08D">1469,458 (Δ = -41,322)</td><td align="right" bgcolor="#A8D08D">766,717 (Δ = -702,741)</td><td align="right" bgcolor="#A8D08D">766,425 (Δ = -0,292)</td><td align="right" bgcolor="#FF4949">766,501 (Δ = +0,076)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,475</td><td align="right" bgcolor="#A8D08D">1,435 (Δ = -0,040)</td><td align="right" bgcolor="#A8D08D">0,749 (Δ = -0,686)</td><td align="right" bgcolor="#A8D08D">0,748 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,749 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 135376,395 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,9 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1087660,040 ns</td><td align="right" bgcolor="#FFFFFF">1081341,510 ns</td><td align="right" bgcolor="#A8D08D">952283,645 ns (Δ = -129057,865 ns)</td><td align="right" bgcolor="#FF4949">963282,745 ns (Δ = +10999,100 ns)</td><td align="right" bgcolor="#FFFFFF">954113,307 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1087,660 μs</td><td align="right" bgcolor="#FFFFFF">1081,342 μs</td><td align="right" bgcolor="#FFFFFF">952,284 μs</td><td align="right" bgcolor="#FFFFFF">963,283 μs</td><td align="right" bgcolor="#FFFFFF">954,113 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,088 ms</td><td align="right" bgcolor="#FFFFFF">1,081 ms</td><td align="right" bgcolor="#FFFFFF">0,952 ms</td><td align="right" bgcolor="#FFFFFF">0,963 ms</td><td align="right" bgcolor="#FFFFFF">0,954 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">17,000 (Δ = -10,000)</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FF4949">17,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86985,000</td><td align="right" bgcolor="#A8D08D">85308,000 (Δ = -1677,000)</td><td align="right" bgcolor="#A8D08D">44809,000 (Δ = -40499,000)</td><td align="right" bgcolor="#FFFFFF">44809,000</td><td align="right" bgcolor="#FFFFFF">44809,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,946</td><td align="right" bgcolor="#A8D08D">83,309 (Δ = -1,638)</td><td align="right" bgcolor="#A8D08D">43,759 (Δ = -39,550)</td><td align="right" bgcolor="#FFFFFF">43,759</td><td align="right" bgcolor="#FFFFFF">43,759</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,083</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,039)</td><td align="right" bgcolor="#FFFFFF">0,043</td><td align="right" bgcolor="#FFFFFF">0,043</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 56431,635 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3223224,093 ns</td><td align="right" bgcolor="#A8D08D">3188617,642 ns (Δ = -34606,452 ns)</td><td align="right" bgcolor="#FF4949">3228570,560 ns (Δ = +39952,918 ns)</td><td align="right" bgcolor="#FFFFFF">3245049,277 ns</td><td align="right" bgcolor="#FFFFFF">3234802,522 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3223,224 μs</td><td align="right" bgcolor="#FFFFFF">3188,618 μs</td><td align="right" bgcolor="#FFFFFF">3228,571 μs</td><td align="right" bgcolor="#FFFFFF">3245,049 μs</td><td align="right" bgcolor="#FFFFFF">3234,803 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,223 ms</td><td align="right" bgcolor="#FFFFFF">3,189 ms</td><td align="right" bgcolor="#FFFFFF">3,229 ms</td><td align="right" bgcolor="#FFFFFF">3,245 ms</td><td align="right" bgcolor="#FFFFFF">3,235 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">89,000</td><td align="right" bgcolor="#A8D08D">87,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">54,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">54,000 (Δ = +29,000)</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#A8D08D">-48,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">281767,000</td><td align="right" bgcolor="#A8D08D">273857,000 (Δ = -7910,000)</td><td align="right" bgcolor="#A8D08D">142440,000 (Δ = -131417,000)</td><td align="right" bgcolor="#FFFFFF">142440,000</td><td align="right" bgcolor="#FFFFFF">142440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">275,163</td><td align="right" bgcolor="#A8D08D">267,438 (Δ = -7,725)</td><td align="right" bgcolor="#A8D08D">139,102 (Δ = -128,337)</td><td align="right" bgcolor="#FFFFFF">139,102</td><td align="right" bgcolor="#FFFFFF">139,102</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,269</td><td align="right" bgcolor="#A8D08D">0,261 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,125)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1131375,280 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,2 %</td><td align="right" bgcolor="#FF4949">+7,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13856912,187 ns</td><td align="right" bgcolor="#A8D08D">13547531,653 ns (Δ = -309380,533 ns)</td><td align="right" bgcolor="#FF4949">14561740,973 ns (Δ = +1014209,320 ns)</td><td align="right" bgcolor="#FFFFFF">14678906,933 ns</td><td align="right" bgcolor="#FFFFFF">14555274,890 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13856,912 μs</td><td align="right" bgcolor="#A8D08D">13547,532 μs (Δ = -309,381 μs)</td><td align="right" bgcolor="#FF4949">14561,741 μs (Δ = +1014,209 μs)</td><td align="right" bgcolor="#FFFFFF">14678,907 μs</td><td align="right" bgcolor="#FFFFFF">14555,275 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">13,857 ms</td><td align="right" bgcolor="#FFFFFF">13,548 ms</td><td align="right" bgcolor="#FFFFFF">14,562 ms</td><td align="right" bgcolor="#FFFFFF">14,679 ms</td><td align="right" bgcolor="#FFFFFF">14,555 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">401,000</td><td align="right" bgcolor="#A8D08D">387,000 (Δ = -14,000)</td><td align="right" bgcolor="#A8D08D">241,000 (Δ = -146,000)</td><td align="right" bgcolor="#FFFFFF">241,000</td><td align="right" bgcolor="#FFFFFF">241,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#A8D08D">104,000 (Δ = -7,000)</td><td align="right" bgcolor="#A8D08D">60,000 (Δ = -44,000)</td><td align="right" bgcolor="#FFFFFF">60,000</td><td align="right" bgcolor="#FFFFFF">60,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#A8D08D">-48,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1263087,000</td><td align="right" bgcolor="#A8D08D">1218717,000 (Δ = -44370,000)</td><td align="right" bgcolor="#A8D08D">634268,000 (Δ = -584449,000)</td><td align="right" bgcolor="#FFFFFF">634268,000</td><td align="right" bgcolor="#FFFFFF">634268,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1233,483</td><td align="right" bgcolor="#A8D08D">1190,153 (Δ = -43,330)</td><td align="right" bgcolor="#A8D08D">619,402 (Δ = -570,751)</td><td align="right" bgcolor="#FFFFFF">619,402</td><td align="right" bgcolor="#FFFFFF">619,402</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,205</td><td align="right" bgcolor="#A8D08D">1,162 (Δ = -0,042)</td><td align="right" bgcolor="#A8D08D">0,605 (Δ = -0,557)</td><td align="right" bgcolor="#FFFFFF">0,605</td><td align="right" bgcolor="#FFFFFF">0,605</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 213632,032 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1307772,693 ns</td><td align="right" bgcolor="#FFFFFF">1312121,963 ns</td><td align="right" bgcolor="#A8D08D">1098489,932 ns (Δ = -213632,032 ns)</td><td align="right" bgcolor="#FF4949">1113954,988 ns (Δ = +15465,057 ns)</td><td align="right" bgcolor="#FFFFFF">1106642,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1307,773 μs</td><td align="right" bgcolor="#FFFFFF">1312,122 μs</td><td align="right" bgcolor="#FFFFFF">1098,490 μs</td><td align="right" bgcolor="#FFFFFF">1113,955 μs</td><td align="right" bgcolor="#FFFFFF">1106,642 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,308 ms</td><td align="right" bgcolor="#FFFFFF">1,312 ms</td><td align="right" bgcolor="#FFFFFF">1,098 ms</td><td align="right" bgcolor="#FFFFFF">1,114 ms</td><td align="right" bgcolor="#FFFFFF">1,107 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">186,000</td><td align="right" bgcolor="#A8D08D">183,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">190,000 (Δ = +7,000)</td><td align="right" bgcolor="#FFFFFF">190,000</td><td align="right" bgcolor="#FFFFFF">190,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">27,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587161,000</td><td align="right" bgcolor="#A8D08D">577329,000 (Δ = -9832,000)</td><td align="right" bgcolor="#A8D08D">500543,000 (Δ = -76786,000)</td><td align="right" bgcolor="#A8D08D">500542,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">500538,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">573,399</td><td align="right" bgcolor="#A8D08D">563,798 (Δ = -9,602)</td><td align="right" bgcolor="#A8D08D">488,812 (Δ = -74,986)</td><td align="right" bgcolor="#A8D08D">488,811 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">488,807 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,560</td><td align="right" bgcolor="#A8D08D">0,551 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,073)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 210628,365 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">505536,370 ns</td><td align="right" bgcolor="#FFFFFF">504290,708 ns</td><td align="right" bgcolor="#A8D08D">294908,005 ns (Δ = -209382,703 ns)</td><td align="right" bgcolor="#FFFFFF">296724,413 ns</td><td align="right" bgcolor="#FFFFFF">297485,342 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">505,536 μs</td><td align="right" bgcolor="#FFFFFF">504,291 μs</td><td align="right" bgcolor="#FFFFFF">294,908 μs</td><td align="right" bgcolor="#FFFFFF">296,724 μs</td><td align="right" bgcolor="#FFFFFF">297,485 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,506 ms</td><td align="right" bgcolor="#FFFFFF">0,504 ms</td><td align="right" bgcolor="#FFFFFF">0,295 ms</td><td align="right" bgcolor="#FFFFFF">0,297 ms</td><td align="right" bgcolor="#FFFFFF">0,297 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FF4949">43,000 (Δ = +36,000)</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138504,000</td><td align="right" bgcolor="#A8D08D">136476,000 (Δ = -2028,000)</td><td align="right" bgcolor="#A8D08D">113846,000 (Δ = -22630,000)</td><td align="right" bgcolor="#FF4949">113848,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">113846,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">135,258</td><td align="right" bgcolor="#A8D08D">133,277 (Δ = -1,980)</td><td align="right" bgcolor="#A8D08D">111,178 (Δ = -22,100)</td><td align="right" bgcolor="#FF4949">111,180 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">111,178 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#A8D08D">0,130 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = -0,022)</td><td align="right" bgcolor="#FF4949">0,109 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 265151,795 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#A8D08D">-26,5 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FF4949">+2,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">894154,892 ns</td><td align="right" bgcolor="#A8D08D">869658,715 ns (Δ = -24496,177 ns)</td><td align="right" bgcolor="#A8D08D">638955,125 ns (Δ = -230703,590 ns)</td><td align="right" bgcolor="#A8D08D">629003,097 ns (Δ = -9952,028 ns)</td><td align="right" bgcolor="#FF4949">641477,153 ns (Δ = +12474,057 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">894,155 μs</td><td align="right" bgcolor="#FFFFFF">869,659 μs</td><td align="right" bgcolor="#FFFFFF">638,955 μs</td><td align="right" bgcolor="#FFFFFF">629,003 μs</td><td align="right" bgcolor="#FFFFFF">641,477 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,894 ms</td><td align="right" bgcolor="#FFFFFF">0,870 ms</td><td align="right" bgcolor="#FFFFFF">0,639 ms</td><td align="right" bgcolor="#FFFFFF">0,629 ms</td><td align="right" bgcolor="#FFFFFF">0,641 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.3.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">142,000 (Δ = +6,000)</td><td align="right" bgcolor="#FFFFFF">142,000</td><td align="right" bgcolor="#FFFFFF">142,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +19,000)</td><td align="right" bgcolor="#FF4949">44,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">142,000 (Δ = +98,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">437391,000</td><td align="right" bgcolor="#A8D08D">429259,000 (Δ = -8132,000)</td><td align="right" bgcolor="#A8D08D">372987,000 (Δ = -56272,000)</td><td align="right" bgcolor="#FF4949">373002,000 (Δ = +15,000)</td><td align="right" bgcolor="#FF4949">373003,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">427,140</td><td align="right" bgcolor="#A8D08D">419,198 (Δ = -7,941)</td><td align="right" bgcolor="#A8D08D">364,245 (Δ = -54,953)</td><td align="right" bgcolor="#FF4949">364,260 (Δ = +0,015)</td><td align="right" bgcolor="#FF4949">364,261 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,417</td><td align="right" bgcolor="#A8D08D">0,409 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,356 (Δ = -0,054)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 410033,685 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2789210,847 ns</td><td align="right" bgcolor="#A8D08D">2717012,383 ns (Δ = -72198,463 ns)</td><td align="right" bgcolor="#A8D08D">2379177,162 ns (Δ = -337835,222 ns)</td><td align="right" bgcolor="#FFFFFF">2384249,953 ns</td><td align="right" bgcolor="#FFFFFF">2403358,313 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2789,211 μs</td><td align="right" bgcolor="#FFFFFF">2717,012 μs</td><td align="right" bgcolor="#A8D08D">2379,177 μs (Δ = -337,835 μs)</td><td align="right" bgcolor="#FFFFFF">2384,250 μs</td><td align="right" bgcolor="#FFFFFF">2403,358 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,789 ms</td><td align="right" bgcolor="#FFFFFF">2,717 ms</td><td align="right" bgcolor="#FFFFFF">2,379 ms</td><td align="right" bgcolor="#FFFFFF">2,384 ms</td><td align="right" bgcolor="#FFFFFF">2,403 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">613,000</td><td align="right" bgcolor="#A8D08D">601,000 (Δ = -12,000)</td><td align="right" bgcolor="#FF4949">634,000 (Δ = +33,000)</td><td align="right" bgcolor="#FFFFFF">634,000</td><td align="right" bgcolor="#FFFFFF">634,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#A8D08D">99,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">95,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">95,000</td><td align="right" bgcolor="#FFFFFF">95,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-12,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1930831,000</td><td align="right" bgcolor="#A8D08D">1892626,000 (Δ = -38205,000)</td><td align="right" bgcolor="#A8D08D">1666054,000 (Δ = -226572,000)</td><td align="right" bgcolor="#FF4949">1666099,000 (Δ = +45,000)</td><td align="right" bgcolor="#FF4949">1666200,000 (Δ = +101,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1885,577</td><td align="right" bgcolor="#A8D08D">1848,268 (Δ = -37,310)</td><td align="right" bgcolor="#A8D08D">1627,006 (Δ = -221,262)</td><td align="right" bgcolor="#FF4949">1627,050 (Δ = +0,044)</td><td align="right" bgcolor="#FF4949">1627,148 (Δ = +0,099)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,841</td><td align="right" bgcolor="#A8D08D">1,805 (Δ = -0,036)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = -0,216)</td><td align="right" bgcolor="#FF4949">1,589 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,589 (Δ = +0,000)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 301,637 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">745,783 ns</td><td align="right" bgcolor="#FFFFFF">975,787 ns</td><td align="right" bgcolor="#FFFFFF">1047,421 ns</td><td align="right" bgcolor="#FFFFFF">1019,212 ns</td><td align="right" bgcolor="#FFFFFF">1010,627 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">0,976 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,019 μs</td><td align="right" bgcolor="#FFFFFF">1,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#A8D08D">-26,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -118,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -246,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,115)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,240)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 15,890 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,910 ns</td><td align="right" bgcolor="#FFFFFF">189,782 ns</td><td align="right" bgcolor="#FFFFFF">205,672 ns</td><td align="right" bgcolor="#FFFFFF">194,537 ns</td><td align="right" bgcolor="#FFFFFF">197,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 234,765 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2714,662 ns</td><td align="right" bgcolor="#FFFFFF">2938,418 ns</td><td align="right" bgcolor="#FFFFFF">2833,825 ns</td><td align="right" bgcolor="#FFFFFF">2703,653 ns</td><td align="right" bgcolor="#FFFFFF">2783,820 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,715 μs</td><td align="right" bgcolor="#FFFFFF">2,938 μs</td><td align="right" bgcolor="#FFFFFF">2,834 μs</td><td align="right" bgcolor="#FFFFFF">2,704 μs</td><td align="right" bgcolor="#FFFFFF">2,784 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#A8D08D">-39,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1401,000</td><td align="right" bgcolor="#FF4949">1409,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">848,000 (Δ = -561,000)</td><td align="right" bgcolor="#FFFFFF">848,000</td><td align="right" bgcolor="#FFFFFF">848,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,368</td><td align="right" bgcolor="#FF4949">1,376 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,828 (Δ = -0,548)</td><td align="right" bgcolor="#FFFFFF">0,828</td><td align="right" bgcolor="#FFFFFF">0,828</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 11,957 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">187,390 ns</td><td align="right" bgcolor="#FFFFFF">190,192 ns</td><td align="right" bgcolor="#FFFFFF">195,272 ns</td><td align="right" bgcolor="#FFFFFF">194,085 ns</td><td align="right" bgcolor="#FFFFFF">199,347 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1067,274 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6683,003 ns</td><td align="right" bgcolor="#A8D08D">6111,257 ns (Δ = -571,747 ns)</td><td align="right" bgcolor="#FFFFFF">5949,508 ns</td><td align="right" bgcolor="#A8D08D">5615,730 ns (Δ = -333,779 ns)</td><td align="right" bgcolor="#FF4949">5975,236 ns (Δ = +359,506 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,683 μs</td><td align="right" bgcolor="#FFFFFF">6,111 μs</td><td align="right" bgcolor="#FFFFFF">5,950 μs</td><td align="right" bgcolor="#FFFFFF">5,616 μs</td><td align="right" bgcolor="#FFFFFF">5,975 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#A8D08D">-40,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3147,000</td><td align="right" bgcolor="#A8D08D">3002,000 (Δ = -145,000)</td><td align="right" bgcolor="#A8D08D">1794,000 (Δ = -1208,000)</td><td align="right" bgcolor="#FFFFFF">1794,000</td><td align="right" bgcolor="#FFFFFF">1794,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,073</td><td align="right" bgcolor="#A8D08D">2,932 (Δ = -0,142)</td><td align="right" bgcolor="#A8D08D">1,752 (Δ = -1,180)</td><td align="right" bgcolor="#FFFFFF">1,752</td><td align="right" bgcolor="#FFFFFF">1,752</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,148 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,630 ns</td><td align="right" bgcolor="#FFFFFF">9,107 ns</td><td align="right" bgcolor="#FFFFFF">12,136 ns</td><td align="right" bgcolor="#FFFFFF">12,255 ns</td><td align="right" bgcolor="#FFFFFF">12,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 732,472 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20182,502 ns</td><td align="right" bgcolor="#FFFFFF">19952,633 ns</td><td align="right" bgcolor="#A8D08D">19551,420 ns (Δ = -401,213 ns)</td><td align="right" bgcolor="#FFFFFF">19450,030 ns</td><td align="right" bgcolor="#FFFFFF">19655,613 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20,183 μs</td><td align="right" bgcolor="#FFFFFF">19,953 μs</td><td align="right" bgcolor="#FFFFFF">19,551 μs</td><td align="right" bgcolor="#FFFFFF">19,450 μs</td><td align="right" bgcolor="#FFFFFF">19,656 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,6 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#A8D08D">5542,000 (Δ = -5452,000)</td><td align="right" bgcolor="#A8D08D">5526,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">5526,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#A8D08D">5,412 (Δ = -5,324)</td><td align="right" bgcolor="#A8D08D">5,396 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">5,396</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,005</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 4,048 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,012 ns</td><td align="right" bgcolor="#FFFFFF">25,737 ns</td><td align="right" bgcolor="#FFFFFF">29,500 ns</td><td align="right" bgcolor="#FFFFFF">29,437 ns</td><td align="right" bgcolor="#FFFFFF">29,785 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 8,165 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,152 ns</td><td align="right" bgcolor="#FFFFFF">19,547 ns</td><td align="right" bgcolor="#FFFFFF">26,317 ns</td><td align="right" bgcolor="#FFFFFF">25,328 ns</td><td align="right" bgcolor="#FFFFFF">25,388 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,122 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,553 ns</td><td align="right" bgcolor="#FFFFFF">20,458 ns</td><td align="right" bgcolor="#FFFFFF">28,445 ns</td><td align="right" bgcolor="#FFFFFF">28,580 ns</td><td align="right" bgcolor="#FFFFFF">27,268 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 8,023 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,974 ns</td><td align="right" bgcolor="#FFFFFF">25,728 ns</td><td align="right" bgcolor="#FFFFFF">33,752 ns</td><td align="right" bgcolor="#FFFFFF">33,580 ns</td><td align="right" bgcolor="#FFFFFF">33,413 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 40,832 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,158 ns</td><td align="right" bgcolor="#FFFFFF">265,970 ns</td><td align="right" bgcolor="#FFFFFF">303,402 ns</td><td align="right" bgcolor="#FFFFFF">304,990 ns</td><td align="right" bgcolor="#FFFFFF">304,133 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,303 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#A8D08D">66,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#A8D08D">0,064 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 6,787 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,580 ns</td><td align="right" bgcolor="#FFFFFF">78,795 ns</td><td align="right" bgcolor="#FFFFFF">72,793 ns</td><td align="right" bgcolor="#FFFFFF">74,602 ns</td><td align="right" bgcolor="#FFFFFF">72,862 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 265,313 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3279,075 ns</td><td align="right" bgcolor="#FFFFFF">3337,708 ns</td><td align="right" bgcolor="#FFFFFF">3518,373 ns</td><td align="right" bgcolor="#FFFFFF">3531,627 ns</td><td align="right" bgcolor="#FFFFFF">3544,388 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,279 μs</td><td align="right" bgcolor="#FFFFFF">3,338 μs</td><td align="right" bgcolor="#FFFFFF">3,518 μs</td><td align="right" bgcolor="#FFFFFF">3,532 μs</td><td align="right" bgcolor="#FFFFFF">3,544 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1886,243 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,5 %</td><td align="right" bgcolor="#FF4949">+13,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8125,048 ns</td><td align="right" bgcolor="#FF4949">8812,445 ns (Δ = +687,397 ns)</td><td align="right" bgcolor="#FF4949">10006,272 ns (Δ = +1193,827 ns)</td><td align="right" bgcolor="#FFFFFF">10011,292 ns</td><td align="right" bgcolor="#FFFFFF">9996,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,125 μs</td><td align="right" bgcolor="#FFFFFF">8,812 μs</td><td align="right" bgcolor="#FFFFFF">10,006 μs</td><td align="right" bgcolor="#FFFFFF">10,011 μs</td><td align="right" bgcolor="#FFFFFF">9,997 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 231,433 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3518,803 ns</td><td align="right" bgcolor="#FFFFFF">3291,882 ns</td><td align="right" bgcolor="#FFFFFF">3507,923 ns</td><td align="right" bgcolor="#FFFFFF">3521,457 ns</td><td align="right" bgcolor="#FFFFFF">3523,315 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,519 μs</td><td align="right" bgcolor="#FFFFFF">3,292 μs</td><td align="right" bgcolor="#FFFFFF">3,508 μs</td><td align="right" bgcolor="#FFFFFF">3,521 μs</td><td align="right" bgcolor="#FFFFFF">3,523 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1938,845 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,9 %</td><td align="right" bgcolor="#FF4949">+14,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8107,290 ns</td><td align="right" bgcolor="#FF4949">8749,357 ns (Δ = +642,067 ns)</td><td align="right" bgcolor="#FF4949">10046,135 ns (Δ = +1296,778 ns)</td><td align="right" bgcolor="#FFFFFF">9972,365 ns</td><td align="right" bgcolor="#FFFFFF">9956,245 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,107 μs</td><td align="right" bgcolor="#FFFFFF">8,749 μs</td><td align="right" bgcolor="#FFFFFF">10,046 μs</td><td align="right" bgcolor="#FFFFFF">9,972 μs</td><td align="right" bgcolor="#FFFFFF">9,956 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,310 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,150 ns</td><td align="right" bgcolor="#FFFFFF">7,137 ns</td><td align="right" bgcolor="#FFFFFF">8,447 ns</td><td align="right" bgcolor="#FFFFFF">8,362 ns</td><td align="right" bgcolor="#FFFFFF">8,205 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 89,233 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">740,617 ns</td><td align="right" bgcolor="#FFFFFF">701,772 ns</td><td align="right" bgcolor="#FFFFFF">651,383 ns</td><td align="right" bgcolor="#FFFFFF">659,280 ns</td><td align="right" bgcolor="#FFFFFF">658,230 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,741 μs</td><td align="right" bgcolor="#FFFFFF">0,702 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2,441 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,599 ns</td><td align="right" bgcolor="#FFFFFF">96,930 ns</td><td align="right" bgcolor="#FFFFFF">96,378 ns</td><td align="right" bgcolor="#FFFFFF">96,435 ns</td><td align="right" bgcolor="#FFFFFF">96,158 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 284,397 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2676,418 ns</td><td align="right" bgcolor="#A8D08D">2392,022 ns (Δ = -284,397 ns)</td><td align="right" bgcolor="#FFFFFF">2561,498 ns</td><td align="right" bgcolor="#FFFFFF">2418,385 ns</td><td align="right" bgcolor="#FFFFFF">2445,312 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,676 μs</td><td align="right" bgcolor="#FFFFFF">2,392 μs</td><td align="right" bgcolor="#FFFFFF">2,561 μs</td><td align="right" bgcolor="#FFFFFF">2,418 μs</td><td align="right" bgcolor="#FFFFFF">2,445 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 210,292 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1188,187 ns</td><td align="right" bgcolor="#FFFFFF">1023,532 ns</td><td align="right" bgcolor="#FFFFFF">983,717 ns</td><td align="right" bgcolor="#FFFFFF">1156,088 ns</td><td align="right" bgcolor="#FFFFFF">977,895 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,188 μs</td><td align="right" bgcolor="#FFFFFF">1,024 μs</td><td align="right" bgcolor="#FFFFFF">0,984 μs</td><td align="right" bgcolor="#FFFFFF">1,156 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">475,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -200,000)</td><td align="right" bgcolor="#FFFFFF">201,000</td><td align="right" bgcolor="#FFFFFF">201,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,464</td><td align="right" bgcolor="#A8D08D">0,392 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,195)</td><td align="right" bgcolor="#FFFFFF">0,196</td><td align="right" bgcolor="#FFFFFF">0,196</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 152,935 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">597,203 ns</td><td align="right" bgcolor="#FFFFFF">444,268 ns</td><td align="right" bgcolor="#FFFFFF">464,728 ns</td><td align="right" bgcolor="#FFFFFF">463,300 ns</td><td align="right" bgcolor="#FFFFFF">467,750 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,465 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,468 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,8 %</td><td align="right" bgcolor="#A8D08D">-49,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -148,000)</td><td align="right" bgcolor="#A8D08D">152,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">152,000</td><td align="right" bgcolor="#FFFFFF">152,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,145)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FFFFFF">0,148</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 89,893 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">752,357 ns</td><td align="right" bgcolor="#FFFFFF">712,465 ns</td><td align="right" bgcolor="#FFFFFF">666,150 ns</td><td align="right" bgcolor="#FFFFFF">662,463 ns</td><td align="right" bgcolor="#FFFFFF">663,398 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,752 μs</td><td align="right" bgcolor="#FFFFFF">0,712 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,662 μs</td><td align="right" bgcolor="#FFFFFF">0,663 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 3,132 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,053 ns</td><td align="right" bgcolor="#FFFFFF">97,618 ns</td><td align="right" bgcolor="#FFFFFF">98,275 ns</td><td align="right" bgcolor="#FFFFFF">98,185 ns</td><td align="right" bgcolor="#FFFFFF">100,750 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 11,128 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">118,000 ns</td><td align="right" bgcolor="#FFFFFF">108,363 ns</td><td align="right" bgcolor="#FFFFFF">106,872 ns</td><td align="right" bgcolor="#FFFFFF">110,747 ns</td><td align="right" bgcolor="#FFFFFF">110,608 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 4,278 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">99,672 ns</td><td align="right" bgcolor="#FFFFFF">102,218 ns</td><td align="right" bgcolor="#FFFFFF">102,055 ns</td><td align="right" bgcolor="#FFFFFF">98,985 ns</td><td align="right" bgcolor="#FFFFFF">103,263 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 97,495 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">529,902 ns</td><td align="right" bgcolor="#FFFFFF">574,163 ns</td><td align="right" bgcolor="#FFFFFF">627,397 ns</td><td align="right" bgcolor="#FFFFFF">593,143 ns</td><td align="right" bgcolor="#FFFFFF">568,445 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,530 μs</td><td align="right" bgcolor="#FFFFFF">0,574 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td><td align="right" bgcolor="#FFFFFF">0,568 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">315,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -155,000)</td><td align="right" bgcolor="#FF4949">176,000 (Δ = +16,000)</td><td align="right" bgcolor="#FFFFFF">176,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FF4949">0,308 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,151)</td><td align="right" bgcolor="#FF4949">0,172 (Δ = +0,016)</td><td align="right" bgcolor="#FFFFFF">0,172</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 11,378 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,373 ns</td><td align="right" bgcolor="#FFFFFF">105,052 ns</td><td align="right" bgcolor="#FFFFFF">93,673 ns</td><td align="right" bgcolor="#FFFFFF">100,030 ns</td><td align="right" bgcolor="#FFFFFF">102,245 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 125,567 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">851,203 ns</td><td align="right" bgcolor="#FFFFFF">921,387 ns</td><td align="right" bgcolor="#FFFFFF">976,770 ns</td><td align="right" bgcolor="#FFFFFF">970,045 ns</td><td align="right" bgcolor="#FFFFFF">936,022 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,921 μs</td><td align="right" bgcolor="#FFFFFF">0,977 μs</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FF4949">356,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -176,000)</td><td align="right" bgcolor="#FF4949">197,000 (Δ = +17,000)</td><td align="right" bgcolor="#FFFFFF">197,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FF4949">0,348 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,172)</td><td align="right" bgcolor="#FF4949">0,192 (Δ = +0,017)</td><td align="right" bgcolor="#FFFFFF">0,192</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 46,360 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">91,837 ns</td><td align="right" bgcolor="#FFFFFF">95,327 ns</td><td align="right" bgcolor="#FFFFFF">91,770 ns</td><td align="right" bgcolor="#FFFFFF">99,742 ns</td><td align="right" bgcolor="#FFFFFF">138,130 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 80,545 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,923 ns</td><td align="right" bgcolor="#FFFFFF">155,563 ns</td><td align="right" bgcolor="#FFFFFF">236,109 ns</td><td align="right" bgcolor="#FFFFFF">222,102 ns</td><td align="right" bgcolor="#FFFFFF">218,008 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 38,518 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,933 ns</td><td align="right" bgcolor="#FFFFFF">94,755 ns</td><td align="right" bgcolor="#FFFFFF">133,273 ns</td><td align="right" bgcolor="#FFFFFF">106,462 ns</td><td align="right" bgcolor="#FFFFFF">133,120 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 16,095 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">152,270 ns</td><td align="right" bgcolor="#FFFFFF">136,175 ns</td><td align="right" bgcolor="#FFFFFF">144,952 ns</td><td align="right" bgcolor="#FFFFFF">140,358 ns</td><td align="right" bgcolor="#FFFFFF">140,465 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-50,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 5.1.0

Δ: 122,472 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1333,023 ns</td><td align="right" bgcolor="#FFFFFF">1316,272 ns</td><td align="right" bgcolor="#FFFFFF">1351,872 ns</td><td align="right" bgcolor="#FFFFFF">1236,277 ns</td><td align="right" bgcolor="#FFFFFF">1229,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,333 μs</td><td align="right" bgcolor="#FFFFFF">1,316 μs</td><td align="right" bgcolor="#FFFFFF">1,352 μs</td><td align="right" bgcolor="#FFFFFF">1,236 μs</td><td align="right" bgcolor="#FFFFFF">1,229 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -131,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,128)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 13,962 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">646,313 ns</td><td align="right" bgcolor="#FFFFFF">652,332 ns</td><td align="right" bgcolor="#FFFFFF">638,370 ns</td><td align="right" bgcolor="#FFFFFF">641,118 ns</td><td align="right" bgcolor="#FFFFFF">651,497 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,646 μs</td><td align="right" bgcolor="#FFFFFF">0,652 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 13,957 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">629,943 ns</td><td align="right" bgcolor="#FFFFFF">642,750 ns</td><td align="right" bgcolor="#FFFFFF">643,900 ns</td><td align="right" bgcolor="#FFFFFF">640,738 ns</td><td align="right" bgcolor="#FFFFFF">638,782 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 16,575 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">619,077 ns</td><td align="right" bgcolor="#FFFFFF">602,502 ns</td><td align="right" bgcolor="#FFFFFF">608,570 ns</td><td align="right" bgcolor="#FFFFFF">614,112 ns</td><td align="right" bgcolor="#FFFFFF">608,738 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,614 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 91,547 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">768,680 ns</td><td align="right" bgcolor="#FFFFFF">731,630 ns</td><td align="right" bgcolor="#FFFFFF">677,133 ns</td><td align="right" bgcolor="#FFFFFF">725,755 ns</td><td align="right" bgcolor="#FFFFFF">682,972 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,769 μs</td><td align="right" bgcolor="#FFFFFF">0,732 μs</td><td align="right" bgcolor="#FFFFFF">0,677 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 5,908 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,200 ns</td><td align="right" bgcolor="#FFFFFF">122,308 ns</td><td align="right" bgcolor="#FFFFFF">120,597 ns</td><td align="right" bgcolor="#FFFFFF">120,685 ns</td><td align="right" bgcolor="#FFFFFF">119,292 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 7,148 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">138,017 ns</td><td align="right" bgcolor="#FFFFFF">131,913 ns</td><td align="right" bgcolor="#FFFFFF">130,868 ns</td><td align="right" bgcolor="#FFFFFF">131,813 ns</td><td align="right" bgcolor="#FFFFFF">134,672 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 23,237 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,430 ns</td><td align="right" bgcolor="#FFFFFF">120,203 ns</td><td align="right" bgcolor="#FFFFFF">143,440 ns</td><td align="right" bgcolor="#FFFFFF">123,362 ns</td><td align="right" bgcolor="#FFFFFF">121,933 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2231,918 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,3 %</td><td align="right" bgcolor="#FF4949">+5,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7369,378 ns</td><td align="right" bgcolor="#A8D08D">5137,460 ns (Δ = -2231,918 ns)</td><td align="right" bgcolor="#FF4949">5404,405 ns (Δ = +266,945 ns)</td><td align="right" bgcolor="#FFFFFF">5472,543 ns</td><td align="right" bgcolor="#FFFFFF">5457,207 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,369 μs</td><td align="right" bgcolor="#FFFFFF">5,137 μs</td><td align="right" bgcolor="#FFFFFF">5,404 μs</td><td align="right" bgcolor="#FFFFFF">5,473 μs</td><td align="right" bgcolor="#FFFFFF">5,457 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,5 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2945,000</td><td align="right" bgcolor="#A8D08D">2048,000 (Δ = -897,000)</td><td align="right" bgcolor="#A8D08D">1040,000 (Δ = -1008,000)</td><td align="right" bgcolor="#FF4949">1044,000 (Δ = +4,000)</td><td align="right" bgcolor="#FF4949">1053,000 (Δ = +9,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,876</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -0,876)</td><td align="right" bgcolor="#A8D08D">1,016 (Δ = -0,984)</td><td align="right" bgcolor="#FF4949">1,020 (Δ = +0,004)</td><td align="right" bgcolor="#FF4949">1,028 (Δ = +0,009)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 415,508 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1322,358 ns</td><td align="right" bgcolor="#A8D08D">906,850 ns (Δ = -415,508 ns)</td><td align="right" bgcolor="#FFFFFF">1047,863 ns</td><td align="right" bgcolor="#FFFFFF">1054,300 ns</td><td align="right" bgcolor="#FFFFFF">1065,565 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,322 μs</td><td align="right" bgcolor="#FFFFFF">0,907 μs</td><td align="right" bgcolor="#FFFFFF">1,048 μs</td><td align="right" bgcolor="#FFFFFF">1,054 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2401,743 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7106,270 ns</td><td align="right" bgcolor="#A8D08D">4704,527 ns (Δ = -2401,743 ns)</td><td align="right" bgcolor="#FFFFFF">4841,148 ns</td><td align="right" bgcolor="#FFFFFF">4850,952 ns</td><td align="right" bgcolor="#FFFFFF">4900,190 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,106 μs</td><td align="right" bgcolor="#FFFFFF">4,705 μs</td><td align="right" bgcolor="#FFFFFF">4,841 μs</td><td align="right" bgcolor="#FFFFFF">4,851 μs</td><td align="right" bgcolor="#FFFFFF">4,900 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FF4949">+0,5 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5092,000</td><td align="right" bgcolor="#A8D08D">3466,000 (Δ = -1626,000)</td><td align="right" bgcolor="#A8D08D">1765,000 (Δ = -1701,000)</td><td align="right" bgcolor="#FF4949">1774,000 (Δ = +9,000)</td><td align="right" bgcolor="#FF4949">1790,000 (Δ = +16,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,973</td><td align="right" bgcolor="#A8D08D">3,385 (Δ = -1,588)</td><td align="right" bgcolor="#A8D08D">1,724 (Δ = -1,661)</td><td align="right" bgcolor="#FF4949">1,732 (Δ = +0,009)</td><td align="right" bgcolor="#FF4949">1,748 (Δ = +0,016)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 408,397 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1315,115 ns</td><td align="right" bgcolor="#A8D08D">906,718 ns (Δ = -408,397 ns)</td><td align="right" bgcolor="#FFFFFF">1048,317 ns</td><td align="right" bgcolor="#FFFFFF">1052,863 ns</td><td align="right" bgcolor="#FFFFFF">1062,248 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,315 μs</td><td align="right" bgcolor="#FFFFFF">0,907 μs</td><td align="right" bgcolor="#FFFFFF">1,048 μs</td><td align="right" bgcolor="#FFFFFF">1,053 μs</td><td align="right" bgcolor="#FFFFFF">1,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 274,735 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">737,877 ns</td><td align="right" bgcolor="#FFFFFF">707,690 ns</td><td align="right" bgcolor="#FFFFFF">795,738 ns</td><td align="right" bgcolor="#FFFFFF">840,593 ns</td><td align="right" bgcolor="#FFFFFF">982,425 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#FFFFFF">0,708 μs</td><td align="right" bgcolor="#FFFFFF">0,796 μs</td><td align="right" bgcolor="#FFFFFF">0,841 μs</td><td align="right" bgcolor="#FFFFFF">0,982 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">291,000</td><td align="right" bgcolor="#A8D08D">266,000 (Δ = -25,000)</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,284</td><td align="right" bgcolor="#A8D08D">0,260 (Δ = -0,024)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 298,842 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1578,317 ns</td><td align="right" bgcolor="#A8D08D">1322,415 ns (Δ = -255,902 ns)</td><td align="right" bgcolor="#FFFFFF">1279,475 ns</td><td align="right" bgcolor="#FFFFFF">1311,308 ns</td><td align="right" bgcolor="#FFFFFF">1282,957 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,578 μs</td><td align="right" bgcolor="#FFFFFF">1,322 μs</td><td align="right" bgcolor="#FFFFFF">1,279 μs</td><td align="right" bgcolor="#FFFFFF">1,311 μs</td><td align="right" bgcolor="#FFFFFF">1,283 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-50,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">650,000</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -109,000)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -271,000)</td><td align="right" bgcolor="#FFFFFF">270,000</td><td align="right" bgcolor="#FFFFFF">270,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,635</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,106)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,265)</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#FFFFFF">0,264</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 160,935 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">884,547 ns</td><td align="right" bgcolor="#FFFFFF">723,758 ns</td><td align="right" bgcolor="#FFFFFF">724,502 ns</td><td align="right" bgcolor="#FFFFFF">723,612 ns</td><td align="right" bgcolor="#FFFFFF">727,092 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,724 μs</td><td align="right" bgcolor="#FFFFFF">0,725 μs</td><td align="right" bgcolor="#FFFFFF">0,724 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -164,000)</td><td align="right" bgcolor="#A8D08D">279,000 (Δ = -278,000)</td><td align="right" bgcolor="#FFFFFF">279,000</td><td align="right" bgcolor="#FFFFFF">279,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,160)</td><td align="right" bgcolor="#A8D08D">0,272 (Δ = -0,271)</td><td align="right" bgcolor="#FFFFFF">0,272</td><td align="right" bgcolor="#FFFFFF">0,272</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 27,225 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">190,253 ns</td><td align="right" bgcolor="#FFFFFF">165,437 ns</td><td align="right" bgcolor="#FFFFFF">163,028 ns</td><td align="right" bgcolor="#FFFFFF">163,580 ns</td><td align="right" bgcolor="#FFFFFF">165,667 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,008</td><td align="right" bgcolor="#FFFFFF">0,008</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 5.1.0

Δ: 107,842 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">772,340 ns</td><td align="right" bgcolor="#FFFFFF">739,723 ns</td><td align="right" bgcolor="#FFFFFF">798,440 ns</td><td align="right" bgcolor="#FFFFFF">692,093 ns</td><td align="right" bgcolor="#FFFFFF">690,598 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,772 μs</td><td align="right" bgcolor="#FFFFFF">0,740 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td><td align="right" bgcolor="#FFFFFF">0,691 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 5,568 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">132,103 ns</td><td align="right" bgcolor="#FFFFFF">132,488 ns</td><td align="right" bgcolor="#FFFFFF">126,920 ns</td><td align="right" bgcolor="#FFFFFF">128,708 ns</td><td align="right" bgcolor="#FFFFFF">130,712 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 336,197 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2761,252 ns</td><td align="right" bgcolor="#A8D08D">2441,545 ns (Δ = -319,707 ns)</td><td align="right" bgcolor="#FFFFFF">2425,055 ns</td><td align="right" bgcolor="#FFFFFF">2466,735 ns</td><td align="right" bgcolor="#FFFFFF">2491,457 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,761 μs</td><td align="right" bgcolor="#FFFFFF">2,442 μs</td><td align="right" bgcolor="#FFFFFF">2,425 μs</td><td align="right" bgcolor="#FFFFFF">2,467 μs</td><td align="right" bgcolor="#FFFFFF">2,491 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 82,707 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">170,927 ns</td><td align="right" bgcolor="#FFFFFF">172,260 ns</td><td align="right" bgcolor="#FFFFFF">247,405 ns</td><td align="right" bgcolor="#FFFFFF">251,363 ns</td><td align="right" bgcolor="#FFFFFF">253,633 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 3,210 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,765 ns</td><td align="right" bgcolor="#FFFFFF">11,650 ns</td><td align="right" bgcolor="#FFFFFF">14,213 ns</td><td align="right" bgcolor="#FFFFFF">14,218 ns</td><td align="right" bgcolor="#FFFFFF">14,860 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 8,560 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,695 ns</td><td align="right" bgcolor="#FFFFFF">32,027 ns</td><td align="right" bgcolor="#FFFFFF">40,587 ns</td><td align="right" bgcolor="#FFFFFF">39,862 ns</td><td align="right" bgcolor="#FFFFFF">39,742 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 11,325 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,790 ns</td><td align="right" bgcolor="#FFFFFF">36,437 ns</td><td align="right" bgcolor="#FFFFFF">47,762 ns</td><td align="right" bgcolor="#FFFFFF">47,245 ns</td><td align="right" bgcolor="#FFFFFF">46,697 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 7,598 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,462 ns</td><td align="right" bgcolor="#FFFFFF">32,347 ns</td><td align="right" bgcolor="#FFFFFF">39,945 ns</td><td align="right" bgcolor="#FFFFFF">39,705 ns</td><td align="right" bgcolor="#FFFFFF">37,720 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2,065 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,565 ns</td><td align="right" bgcolor="#FFFFFF">14,462 ns</td><td align="right" bgcolor="#FFFFFF">12,853 ns</td><td align="right" bgcolor="#FFFFFF">12,893 ns</td><td align="right" bgcolor="#FFFFFF">12,500 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1,265 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,777 ns</td><td align="right" bgcolor="#FFFFFF">20,130 ns</td><td align="right" bgcolor="#FFFFFF">21,042 ns</td><td align="right" bgcolor="#FFFFFF">20,010 ns</td><td align="right" bgcolor="#FFFFFF">20,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 6,737 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,023 ns</td><td align="right" bgcolor="#FFFFFF">24,762 ns</td><td align="right" bgcolor="#FFFFFF">31,498 ns</td><td align="right" bgcolor="#FFFFFF">31,153 ns</td><td align="right" bgcolor="#FFFFFF">29,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 65,430 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">444,377 ns</td><td align="right" bgcolor="#FFFFFF">443,897 ns</td><td align="right" bgcolor="#FFFFFF">508,838 ns</td><td align="right" bgcolor="#FFFFFF">501,710 ns</td><td align="right" bgcolor="#FFFFFF">509,327 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,509 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,509 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 40,195 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">167,127 ns</td><td align="right" bgcolor="#FFFFFF">176,713 ns</td><td align="right" bgcolor="#FFFFFF">207,322 ns</td><td align="right" bgcolor="#FFFFFF">207,085 ns</td><td align="right" bgcolor="#FFFFFF">205,662 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 0,503 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,965 ns</td><td align="right" bgcolor="#FFFFFF">25,588 ns</td><td align="right" bgcolor="#FFFFFF">25,462 ns</td><td align="right" bgcolor="#FFFFFF">25,482 ns</td><td align="right" bgcolor="#FFFFFF">25,770 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 8,987 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,412 ns</td><td align="right" bgcolor="#FFFFFF">29,100 ns</td><td align="right" bgcolor="#FFFFFF">38,087 ns</td><td align="right" bgcolor="#FFFFFF">35,873 ns</td><td align="right" bgcolor="#FFFFFF">36,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,110 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,962 ns</td><td align="right" bgcolor="#FFFFFF">8,427 ns</td><td align="right" bgcolor="#FFFFFF">10,675 ns</td><td align="right" bgcolor="#FFFFFF">11,537 ns</td><td align="right" bgcolor="#FFFFFF">10,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 2,078 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,283 ns</td><td align="right" bgcolor="#FFFFFF">9,532 ns</td><td align="right" bgcolor="#FFFFFF">10,395 ns</td><td align="right" bgcolor="#FFFFFF">11,297 ns</td><td align="right" bgcolor="#FFFFFF">11,362 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 20559,362 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35212,583 ns</td><td align="right" bgcolor="#A8D08D">16916,980 ns (Δ = -18295,603 ns)</td><td align="right" bgcolor="#A8D08D">14653,222 ns (Δ = -2263,758 ns)</td><td align="right" bgcolor="#FFFFFF">14673,130 ns</td><td align="right" bgcolor="#FF4949">15565,417 ns (Δ = +892,287 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">35,213 μs</td><td align="right" bgcolor="#FFFFFF">16,917 μs</td><td align="right" bgcolor="#FFFFFF">14,653 μs</td><td align="right" bgcolor="#FFFFFF">14,673 μs</td><td align="right" bgcolor="#FFFFFF">15,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7704,000</td><td align="right" bgcolor="#A8D08D">5784,000 (Δ = -1920,000)</td><td align="right" bgcolor="#A8D08D">3093,000 (Δ = -2691,000)</td><td align="right" bgcolor="#FFFFFF">3093,000</td><td align="right" bgcolor="#FF4949">3273,000 (Δ = +180,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,523</td><td align="right" bgcolor="#A8D08D">5,648 (Δ = -1,875)</td><td align="right" bgcolor="#A8D08D">3,021 (Δ = -2,628)</td><td align="right" bgcolor="#FFFFFF">3,021</td><td align="right" bgcolor="#FF4949">3,196 (Δ = +0,176)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,522 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,087 ns</td><td align="right" bgcolor="#FFFFFF">10,847 ns</td><td align="right" bgcolor="#FFFFFF">12,368 ns</td><td align="right" bgcolor="#FFFFFF">12,205 ns</td><td align="right" bgcolor="#FFFFFF">12,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2,330 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,083 ns</td><td align="right" bgcolor="#FFFFFF">14,497 ns</td><td align="right" bgcolor="#FFFFFF">13,003 ns</td><td align="right" bgcolor="#FFFFFF">13,537 ns</td><td align="right" bgcolor="#FFFFFF">12,753 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,268 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,188 ns</td><td align="right" bgcolor="#FFFFFF">13,860 ns</td><td align="right" bgcolor="#FFFFFF">15,128 ns</td><td align="right" bgcolor="#FFFFFF">14,218 ns</td><td align="right" bgcolor="#FFFFFF">14,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,192 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,795 ns</td><td align="right" bgcolor="#FFFFFF">14,458 ns</td><td align="right" bgcolor="#FFFFFF">12,967 ns</td><td align="right" bgcolor="#FFFFFF">12,603 ns</td><td align="right" bgcolor="#FFFFFF">13,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,747 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,838 ns</td><td align="right" bgcolor="#FFFFFF">15,400 ns</td><td align="right" bgcolor="#FFFFFF">14,265 ns</td><td align="right" bgcolor="#FFFFFF">14,092 ns</td><td align="right" bgcolor="#FFFFFF">14,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 10,323 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,575 ns</td><td align="right" bgcolor="#FFFFFF">35,215 ns</td><td align="right" bgcolor="#FFFFFF">45,462 ns</td><td align="right" bgcolor="#FFFFFF">44,308 ns</td><td align="right" bgcolor="#FFFFFF">45,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.3.0**

Slowest: 5.1.0

Δ: 690,457 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-64,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">895,445 ns</td><td align="right" bgcolor="#FFFFFF">892,300 ns</td><td align="right" bgcolor="#FFFFFF">1047,140 ns</td><td align="right" bgcolor="#FFFFFF">1005,190 ns</td><td align="right" bgcolor="#A8D08D">356,683 ns (Δ = -648,507 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,895 μs</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,005 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-83,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -86,000)</td><td align="right" bgcolor="#FFFFFF">94,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -78,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,084)</td><td align="right" bgcolor="#FFFFFF">0,092</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,076)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 7,552 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,485 ns</td><td align="right" bgcolor="#FFFFFF">17,848 ns</td><td align="right" bgcolor="#FFFFFF">25,400 ns</td><td align="right" bgcolor="#FFFFFF">18,793 ns</td><td align="right" bgcolor="#FFFFFF">19,608 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 66,883 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,235 ns</td><td align="right" bgcolor="#FFFFFF">218,490 ns</td><td align="right" bgcolor="#FFFFFF">285,373 ns</td><td align="right" bgcolor="#FFFFFF">284,682 ns</td><td align="right" bgcolor="#FFFFFF">280,107 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 9,892 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,072 ns</td><td align="right" bgcolor="#FFFFFF">34,537 ns</td><td align="right" bgcolor="#FFFFFF">43,963 ns</td><td align="right" bgcolor="#FFFFFF">40,447 ns</td><td align="right" bgcolor="#FFFFFF">42,252 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 60,423 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,602 ns</td><td align="right" bgcolor="#FFFFFF">105,170 ns</td><td align="right" bgcolor="#FFFFFF">124,220 ns</td><td align="right" bgcolor="#FFFFFF">152,770 ns</td><td align="right" bgcolor="#FFFFFF">164,025 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 12,788 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,345 ns</td><td align="right" bgcolor="#FFFFFF">27,785 ns</td><td align="right" bgcolor="#FFFFFF">40,573 ns</td><td align="right" bgcolor="#FFFFFF">39,245 ns</td><td align="right" bgcolor="#FFFFFF">37,117 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 112,535 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">292,797 ns</td><td align="right" bgcolor="#FFFFFF">294,877 ns</td><td align="right" bgcolor="#FFFFFF">403,797 ns</td><td align="right" bgcolor="#FFFFFF">391,067 ns</td><td align="right" bgcolor="#FFFFFF">405,332 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,391 μs</td><td align="right" bgcolor="#FFFFFF">0,405 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 253,763 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2141,670 ns</td><td align="right" bgcolor="#FFFFFF">2362,380 ns</td><td align="right" bgcolor="#FFFFFF">2140,850 ns</td><td align="right" bgcolor="#FFFFFF">2108,617 ns</td><td align="right" bgcolor="#FFFFFF">2175,208 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,142 μs</td><td align="right" bgcolor="#FFFFFF">2,362 μs</td><td align="right" bgcolor="#FFFFFF">2,141 μs</td><td align="right" bgcolor="#FFFFFF">2,109 μs</td><td align="right" bgcolor="#FFFFFF">2,175 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,1 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">864,000</td><td align="right" bgcolor="#FF4949">1020,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">643,000 (Δ = -377,000)</td><td align="right" bgcolor="#FFFFFF">643,000</td><td align="right" bgcolor="#FFFFFF">643,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,844</td><td align="right" bgcolor="#FF4949">0,996 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,628 (Δ = -0,368)</td><td align="right" bgcolor="#FFFFFF">0,628</td><td align="right" bgcolor="#FFFFFF">0,628</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 421,095 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,9 %</td><td align="right" bgcolor="#A8D08D">-17,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2177,448 ns</td><td align="right" bgcolor="#FF4949">2459,255 ns (Δ = +281,807 ns)</td><td align="right" bgcolor="#A8D08D">2038,160 ns (Δ = -421,095 ns)</td><td align="right" bgcolor="#FFFFFF">2239,615 ns</td><td align="right" bgcolor="#FFFFFF">2267,093 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,177 μs</td><td align="right" bgcolor="#FFFFFF">2,459 μs</td><td align="right" bgcolor="#FFFFFF">2,038 μs</td><td align="right" bgcolor="#FFFFFF">2,240 μs</td><td align="right" bgcolor="#FFFFFF">2,267 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,2 %</td><td align="right" bgcolor="#A8D08D">-36,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">856,000</td><td align="right" bgcolor="#FF4949">1012,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">639,000 (Δ = -373,000)</td><td align="right" bgcolor="#FFFFFF">639,000</td><td align="right" bgcolor="#FFFFFF">639,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,836</td><td align="right" bgcolor="#FF4949">0,988 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,624 (Δ = -0,364)</td><td align="right" bgcolor="#FFFFFF">0,624</td><td align="right" bgcolor="#FFFFFF">0,624</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 258,815 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2598,525 ns</td><td align="right" bgcolor="#FF4949">2857,340 ns (Δ = +258,815 ns)</td><td align="right" bgcolor="#FFFFFF">2669,113 ns</td><td align="right" bgcolor="#FFFFFF">2646,058 ns</td><td align="right" bgcolor="#FFFFFF">2664,320 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,599 μs</td><td align="right" bgcolor="#FFFFFF">2,857 μs</td><td align="right" bgcolor="#FFFFFF">2,669 μs</td><td align="right" bgcolor="#FFFFFF">2,646 μs</td><td align="right" bgcolor="#FFFFFF">2,664 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,9 %</td><td align="right" bgcolor="#A8D08D">-30,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1274,000</td><td align="right" bgcolor="#FF4949">1425,000 (Δ = +151,000)</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -430,000)</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,244</td><td align="right" bgcolor="#FF4949">1,392 (Δ = +0,147)</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,420)</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 266,630 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3057,523 ns</td><td align="right" bgcolor="#FF4949">3324,153 ns (Δ = +266,630 ns)</td><td align="right" bgcolor="#FFFFFF">3189,012 ns</td><td align="right" bgcolor="#FFFFFF">3070,663 ns</td><td align="right" bgcolor="#FFFFFF">3284,767 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,058 μs</td><td align="right" bgcolor="#FFFFFF">3,324 μs</td><td align="right" bgcolor="#FFFFFF">3,189 μs</td><td align="right" bgcolor="#FFFFFF">3,071 μs</td><td align="right" bgcolor="#FFFFFF">3,285 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,3 %</td><td align="right" bgcolor="#A8D08D">-32,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1482,000</td><td align="right" bgcolor="#FF4949">1635,000 (Δ = +153,000)</td><td align="right" bgcolor="#A8D08D">1106,000 (Δ = -529,000)</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,447</td><td align="right" bgcolor="#FF4949">1,597 (Δ = +0,149)</td><td align="right" bgcolor="#A8D08D">1,080 (Δ = -0,517)</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 17,927 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,947 ns</td><td align="right" bgcolor="#FFFFFF">104,382 ns</td><td align="right" bgcolor="#FFFFFF">120,360 ns</td><td align="right" bgcolor="#FFFFFF">122,308 ns</td><td align="right" bgcolor="#FFFFFF">118,517 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 17,268 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,523 ns</td><td align="right" bgcolor="#FFFFFF">103,018 ns</td><td align="right" bgcolor="#FFFFFF">120,287 ns</td><td align="right" bgcolor="#FFFFFF">119,840 ns</td><td align="right" bgcolor="#FFFFFF">119,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 721,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2652,455 ns</td><td align="right" bgcolor="#FF4949">3180,550 ns (Δ = +528,095 ns)</td><td align="right" bgcolor="#FFFFFF">3374,252 ns</td><td align="right" bgcolor="#FFFFFF">3193,743 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,652 μs</td><td align="right" bgcolor="#FFFFFF">3,181 μs</td><td align="right" bgcolor="#FFFFFF">3,374 μs</td><td align="right" bgcolor="#FFFFFF">3,194 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">971,000</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,948</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 66,974 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">267,618 ns</td><td align="right" bgcolor="#FFFFFF">200,643 ns</td><td align="right" bgcolor="#FFFFFF">259,228 ns</td><td align="right" bgcolor="#FFFFFF">238,618 ns</td><td align="right" bgcolor="#FFFFFF">226,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 60,512 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,683 ns</td><td align="right" bgcolor="#FFFFFF">195,643 ns</td><td align="right" bgcolor="#FFFFFF">254,195 ns</td><td align="right" bgcolor="#FFFFFF">212,763 ns</td><td align="right" bgcolor="#FFFFFF">228,180 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 61,127 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">215,105 ns</td><td align="right" bgcolor="#FFFFFF">219,850 ns</td><td align="right" bgcolor="#FFFFFF">233,172 ns</td><td align="right" bgcolor="#FFFFFF">231,692 ns</td><td align="right" bgcolor="#FFFFFF">276,232 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,276 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 39,087 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">194,277 ns</td><td align="right" bgcolor="#FFFFFF">195,835 ns</td><td align="right" bgcolor="#FFFFFF">233,363 ns</td><td align="right" bgcolor="#FFFFFF">216,940 ns</td><td align="right" bgcolor="#FFFFFF">227,837 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 101,867 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,518 ns</td><td align="right" bgcolor="#FFFFFF">192,917 ns</td><td align="right" bgcolor="#FFFFFF">209,585 ns</td><td align="right" bgcolor="#FFFFFF">294,783 ns</td><td align="right" bgcolor="#FFFFFF">232,522 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 148,405 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">992,312 ns</td><td align="right" bgcolor="#FFFFFF">1034,423 ns</td><td align="right" bgcolor="#FFFFFF">1107,442 ns</td><td align="right" bgcolor="#FFFFFF">1140,717 ns</td><td align="right" bgcolor="#FFFFFF">1115,520 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,992 μs</td><td align="right" bgcolor="#FFFFFF">1,034 μs</td><td align="right" bgcolor="#FFFFFF">1,107 μs</td><td align="right" bgcolor="#FFFFFF">1,141 μs</td><td align="right" bgcolor="#FFFFFF">1,116 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 136,565 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1027,025 ns</td><td align="right" bgcolor="#FFFFFF">987,492 ns</td><td align="right" bgcolor="#FFFFFF">1110,653 ns</td><td align="right" bgcolor="#FFFFFF">1124,057 ns</td><td align="right" bgcolor="#FFFFFF">1104,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,027 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td><td align="right" bgcolor="#FFFFFF">1,111 μs</td><td align="right" bgcolor="#FFFFFF">1,124 μs</td><td align="right" bgcolor="#FFFFFF">1,105 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 62,290 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">238,218 ns</td><td align="right" bgcolor="#FFFFFF">236,440 ns</td><td align="right" bgcolor="#FFFFFF">270,477 ns</td><td align="right" bgcolor="#FFFFFF">284,177 ns</td><td align="right" bgcolor="#FFFFFF">298,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td><td align="right" bgcolor="#FFFFFF">0,284 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 74,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">233,992 ns</td><td align="right" bgcolor="#FFFFFF">232,250 ns</td><td align="right" bgcolor="#FFFFFF">244,865 ns</td><td align="right" bgcolor="#FFFFFF">306,708 ns</td><td align="right" bgcolor="#FFFFFF">270,172 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 44,570 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">249,487 ns</td><td align="right" bgcolor="#FFFFFF">252,522 ns</td><td align="right" bgcolor="#FFFFFF">294,056 ns</td><td align="right" bgcolor="#FFFFFF">289,657 ns</td><td align="right" bgcolor="#FFFFFF">289,855 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 65,838 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">208,775 ns</td><td align="right" bgcolor="#FFFFFF">204,752 ns</td><td align="right" bgcolor="#FFFFFF">270,590 ns</td><td align="right" bgcolor="#FFFFFF">250,897 ns</td><td align="right" bgcolor="#FFFFFF">239,038 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 39,495 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,093 ns</td><td align="right" bgcolor="#FFFFFF">205,593 ns</td><td align="right" bgcolor="#FFFFFF">220,683 ns</td><td align="right" bgcolor="#FFFFFF">245,088 ns</td><td align="right" bgcolor="#FFFFFF">240,053 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 134,075 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">499,600 ns</td><td align="right" bgcolor="#FFFFFF">496,138 ns</td><td align="right" bgcolor="#FFFFFF">630,213 ns</td><td align="right" bgcolor="#FFFFFF">629,548 ns</td><td align="right" bgcolor="#FFFFFF">625,065 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,496 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,625 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">193,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 152,460 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">944,505 ns</td><td align="right" bgcolor="#FFFFFF">911,932 ns</td><td align="right" bgcolor="#FFFFFF">1042,133 ns</td><td align="right" bgcolor="#FFFFFF">1064,392 ns</td><td align="right" bgcolor="#FFFFFF">1045,745 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,945 μs</td><td align="right" bgcolor="#FFFFFF">0,912 μs</td><td align="right" bgcolor="#FFFFFF">1,042 μs</td><td align="right" bgcolor="#FFFFFF">1,064 μs</td><td align="right" bgcolor="#FFFFFF">1,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 142,119 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">928,605 ns</td><td align="right" bgcolor="#FFFFFF">912,720 ns</td><td align="right" bgcolor="#FFFFFF">960,893 ns</td><td align="right" bgcolor="#FFFFFF">1054,838 ns</td><td align="right" bgcolor="#FFFFFF">1047,195 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,913 μs</td><td align="right" bgcolor="#FFFFFF">0,961 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 44,138 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">238,663 ns</td><td align="right" bgcolor="#FFFFFF">238,208 ns</td><td align="right" bgcolor="#FFFFFF">276,558 ns</td><td align="right" bgcolor="#FFFFFF">282,347 ns</td><td align="right" bgcolor="#FFFFFF">272,528 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 53,280 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">211,737 ns</td><td align="right" bgcolor="#FFFFFF">216,568 ns</td><td align="right" bgcolor="#FFFFFF">265,017 ns</td><td align="right" bgcolor="#FFFFFF">244,707 ns</td><td align="right" bgcolor="#FFFFFF">244,165 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 152,433 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">331,690 ns</td><td align="right" bgcolor="#FFFFFF">334,748 ns</td><td align="right" bgcolor="#FFFFFF">482,798 ns</td><td align="right" bgcolor="#FFFFFF">476,137 ns</td><td align="right" bgcolor="#FFFFFF">484,123 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#FFFFFF">0,335 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,484 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 0,597 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,198 ns</td><td align="right" bgcolor="#FFFFFF">7,252 ns</td><td align="right" bgcolor="#FFFFFF">7,182 ns</td><td align="right" bgcolor="#FFFFFF">6,847 ns</td><td align="right" bgcolor="#FFFFFF">6,655 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 0,475 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,993 ns</td><td align="right" bgcolor="#FFFFFF">7,182 ns</td><td align="right" bgcolor="#FFFFFF">6,707 ns</td><td align="right" bgcolor="#FFFFFF">6,775 ns</td><td align="right" bgcolor="#FFFFFF">6,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 0,508 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,960 ns</td><td align="right" bgcolor="#FFFFFF">7,293 ns</td><td align="right" bgcolor="#FFFFFF">6,998 ns</td><td align="right" bgcolor="#FFFFFF">6,785 ns</td><td align="right" bgcolor="#FFFFFF">6,878 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 0,745 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,483 ns</td><td align="right" bgcolor="#FFFFFF">7,245 ns</td><td align="right" bgcolor="#FFFFFF">6,738 ns</td><td align="right" bgcolor="#FFFFFF">7,030 ns</td><td align="right" bgcolor="#FFFFFF">6,742 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,047 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,056 ns</td><td align="right" bgcolor="#FFFFFF">0,042 ns</td><td align="right" bgcolor="#FFFFFF">0,024 ns</td><td align="right" bgcolor="#FFFFFF">0,010 ns</td><td align="right" bgcolor="#FFFFFF">0,023 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 0,024 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ns</td><td align="right" bgcolor="#FFFFFF">0,036 ns</td><td align="right" bgcolor="#FFFFFF">0,015 ns</td><td align="right" bgcolor="#FFFFFF">0,032 ns</td><td align="right" bgcolor="#FFFFFF">0,012 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 0,115 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,590 ns</td><td align="right" bgcolor="#FFFFFF">0,580 ns</td><td align="right" bgcolor="#FFFFFF">0,537 ns</td><td align="right" bgcolor="#FFFFFF">0,643 ns</td><td align="right" bgcolor="#FFFFFF">0,652 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.1.0

Δ: 0,035 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,025 ns</td><td align="right" bgcolor="#FFFFFF">0,023 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,013 ns</td><td align="right" bgcolor="#FFFFFF">0,017 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,023 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,026 ns</td><td align="right" bgcolor="#FFFFFF">0,025 ns</td><td align="right" bgcolor="#FFFFFF">0,011 ns</td><td align="right" bgcolor="#FFFFFF">0,009 ns</td><td align="right" bgcolor="#FFFFFF">0,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,072 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,662 ns</td><td align="right" bgcolor="#FFFFFF">0,590 ns</td><td align="right" bgcolor="#FFFFFF">0,650 ns</td><td align="right" bgcolor="#FFFFFF">0,657 ns</td><td align="right" bgcolor="#FFFFFF">0,615 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 202,865 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">939,830 ns</td><td align="right" bgcolor="#FFFFFF">931,695 ns</td><td align="right" bgcolor="#FFFFFF">1101,708 ns</td><td align="right" bgcolor="#FFFFFF">1134,560 ns</td><td align="right" bgcolor="#FFFFFF">974,798 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,940 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td><td align="right" bgcolor="#FFFFFF">1,135 μs</td><td align="right" bgcolor="#FFFFFF">0,975 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#A8D08D">426,000 (Δ = -311,000)</td><td align="right" bgcolor="#FFFFFF">426,000</td><td align="right" bgcolor="#FFFFFF">426,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#A8D08D">0,416 (Δ = -0,304)</td><td align="right" bgcolor="#FFFFFF">0,416</td><td align="right" bgcolor="#FFFFFF">0,416</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 15483,387 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,1 %</td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29836,243 ns</td><td align="right" bgcolor="#A8D08D">16988,365 ns (Δ = -12847,878 ns)</td><td align="right" bgcolor="#A8D08D">14405,430 ns (Δ = -2582,935 ns)</td><td align="right" bgcolor="#FFFFFF">14352,857 ns</td><td align="right" bgcolor="#FF4949">15178,757 ns (Δ = +825,900 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">29,836 μs</td><td align="right" bgcolor="#FFFFFF">16,988 μs</td><td align="right" bgcolor="#FFFFFF">14,405 μs</td><td align="right" bgcolor="#FFFFFF">14,353 μs</td><td align="right" bgcolor="#FFFFFF">15,179 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7420,000</td><td align="right" bgcolor="#A8D08D">5707,000 (Δ = -1713,000)</td><td align="right" bgcolor="#A8D08D">3056,000 (Δ = -2651,000)</td><td align="right" bgcolor="#FFFFFF">3056,000</td><td align="right" bgcolor="#FF4949">3236,000 (Δ = +180,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,246</td><td align="right" bgcolor="#A8D08D">5,573 (Δ = -1,673)</td><td align="right" bgcolor="#A8D08D">2,984 (Δ = -2,589)</td><td align="right" bgcolor="#FFFFFF">2,984</td><td align="right" bgcolor="#FF4949">3,160 (Δ = +0,176)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td></tr></table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1164,967 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+948,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,868 ns</td><td align="right" bgcolor="#FF4949">1203,917 ns (Δ = +1089,048 ns)</td><td align="right" bgcolor="#FFFFFF">1279,835 ns</td><td align="right" bgcolor="#FFFFFF">1267,665 ns</td><td align="right" bgcolor="#FFFFFF">1253,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">1,204 μs</td><td align="right" bgcolor="#FFFFFF">1,280 μs</td><td align="right" bgcolor="#FFFFFF">1,268 μs</td><td align="right" bgcolor="#FFFFFF">1,253 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+151,9 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FF4949">393,000 (Δ = +237,000)</td><td align="right" bgcolor="#A8D08D">205,000 (Δ = -188,000)</td><td align="right" bgcolor="#FFFFFF">205,000</td><td align="right" bgcolor="#FFFFFF">205,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FF4949">0,384 (Δ = +0,231)</td><td align="right" bgcolor="#A8D08D">0,200 (Δ = -0,184)</td><td align="right" bgcolor="#FFFFFF">0,200</td><td align="right" bgcolor="#FFFFFF">0,200</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1124,627 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3800,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,762 ns</td><td align="right" bgcolor="#FF4949">1043,737 ns (Δ = +1016,975 ns)</td><td align="right" bgcolor="#FFFFFF">1143,037 ns</td><td align="right" bgcolor="#FFFFFF">1151,388 ns</td><td align="right" bgcolor="#FFFFFF">1141,970 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td><td align="right" bgcolor="#FFFFFF">1,151 μs</td><td align="right" bgcolor="#FFFFFF">1,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2,807 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,780 ns</td><td align="right" bgcolor="#FFFFFF">4,718 ns</td><td align="right" bgcolor="#FFFFFF">2,335 ns</td><td align="right" bgcolor="#FFFFFF">1,987 ns</td><td align="right" bgcolor="#FFFFFF">1,973 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 2844,643 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,2 %</td><td align="right" bgcolor="#A8D08D">-7,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16506,155 ns</td><td align="right" bgcolor="#FF4949">19350,798 ns (Δ = +2844,643 ns)</td><td align="right" bgcolor="#A8D08D">17877,083 ns (Δ = -1473,715 ns)</td><td align="right" bgcolor="#FFFFFF">17758,375 ns</td><td align="right" bgcolor="#FFFFFF">17988,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">16,506 μs</td><td align="right" bgcolor="#FFFFFF">19,351 μs</td><td align="right" bgcolor="#FFFFFF">17,877 μs</td><td align="right" bgcolor="#FFFFFF">17,758 μs</td><td align="right" bgcolor="#FFFFFF">17,988 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,3 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1204,000</td><td align="right" bgcolor="#FF4949">1461,000 (Δ = +257,000)</td><td align="right" bgcolor="#A8D08D">735,000 (Δ = -726,000)</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,176</td><td align="right" bgcolor="#FF4949">1,427 (Δ = +0,251)</td><td align="right" bgcolor="#A8D08D">0,718 (Δ = -0,709)</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 4542,177 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,2 %</td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#A8D08D">-5,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17327,785 ns</td><td align="right" bgcolor="#FF4949">21869,962 ns (Δ = +4542,177 ns)</td><td align="right" bgcolor="#A8D08D">19399,205 ns (Δ = -2470,757 ns)</td><td align="right" bgcolor="#A8D08D">18328,857 ns (Δ = -1070,348 ns)</td><td align="right" bgcolor="#FFFFFF">18473,788 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,328 μs</td><td align="right" bgcolor="#FFFFFF">21,870 μs</td><td align="right" bgcolor="#FFFFFF">19,399 μs</td><td align="right" bgcolor="#FFFFFF">18,329 μs</td><td align="right" bgcolor="#FFFFFF">18,474 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,3 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1204,000</td><td align="right" bgcolor="#FF4949">1461,000 (Δ = +257,000)</td><td align="right" bgcolor="#A8D08D">735,000 (Δ = -726,000)</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,176</td><td align="right" bgcolor="#FF4949">1,427 (Δ = +0,251)</td><td align="right" bgcolor="#A8D08D">0,718 (Δ = -0,709)</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


