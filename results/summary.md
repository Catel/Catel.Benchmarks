# Benchmarks

Benchmark report generated on 30-mrt-2018 16:11

Running the benchmarks took 03:31:17.5848077

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.13, OS=Windows 10.0.17133, VM=Hyper-V

Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), 1 CPU, 8 logical cores and 8 physical cores



## Important benchmarks

### High priority (current version slower than previous one)

3 item(s)

1. [AssemblyExtensions_Benchmark::InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion) v5.4.0 is **14,64%** (Δ: 1204,197 ns) slower than v5.3.0

2. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.4.0 is **4,83%** (Δ: 276,738 ns) slower than v5.3.0

3. [AssemblyExtensions_Benchmark::Title](#AssemblyExtensions_Benchmark_Title) v5.4.0 is **4,56%** (Δ: 445,608 ns) slower than v5.3.0



### Improved (current version faster than previous one)

4 item(s)

1. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.4.0 is **3,10%** (Δ: -74935,419 ns) faster than v5.3.0

2. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.4.0 is **2,61%** (Δ: -16635,833 ns) faster than v5.3.0

3. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.4.0 is **1,53%** (Δ: -16400,582 ns) faster than v5.3.0

4. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_500](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500) v5.4.0 is **1,37%** (Δ: -11794,797 ns) faster than v5.3.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 29,126 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,321 ns</td><td align="right" bgcolor="#FFFFFF">96,195 ns</td><td align="right" bgcolor="#FFFFFF">99,947 ns</td><td align="right" bgcolor="#FFFFFF">98,519 ns</td><td align="right" bgcolor="#FFFFFF">96,741 ns</td><td align="right" bgcolor="#FFFFFF">96,673 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 16,907 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,219 ns</td><td align="right" bgcolor="#FFFFFF">96,077 ns</td><td align="right" bgcolor="#FFFFFF">97,196 ns</td><td align="right" bgcolor="#FFFFFF">97,953 ns</td><td align="right" bgcolor="#FFFFFF">95,312 ns</td><td align="right" bgcolor="#FFFFFF">96,293 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 4,157 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,809 ns</td><td align="right" bgcolor="#FFFFFF">91,070 ns</td><td align="right" bgcolor="#FFFFFF">90,796 ns</td><td align="right" bgcolor="#FFFFFF">91,718 ns</td><td align="right" bgcolor="#FFFFFF">89,776 ns</td><td align="right" bgcolor="#FFFFFF">89,652 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 59,800 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">155,507 ns</td><td align="right" bgcolor="#FFFFFF">97,692 ns</td><td align="right" bgcolor="#FFFFFF">96,118 ns</td><td align="right" bgcolor="#FFFFFF">95,926 ns</td><td align="right" bgcolor="#FFFFFF">96,795 ns</td><td align="right" bgcolor="#FFFFFF">95,707 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,960 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,682 ns</td><td align="right" bgcolor="#FFFFFF">37,224 ns</td><td align="right" bgcolor="#FFFFFF">45,609 ns</td><td align="right" bgcolor="#FFFFFF">45,802 ns</td><td align="right" bgcolor="#FFFFFF">46,184 ns</td><td align="right" bgcolor="#FFFFFF">45,823 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 12,076 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,973 ns</td><td align="right" bgcolor="#FFFFFF">43,196 ns</td><td align="right" bgcolor="#FFFFFF">55,049 ns</td><td align="right" bgcolor="#FFFFFF">54,093 ns</td><td align="right" bgcolor="#FFFFFF">53,711 ns</td><td align="right" bgcolor="#FFFFFF">53,033 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 13,475 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,082 ns</td><td align="right" bgcolor="#FFFFFF">41,839 ns</td><td align="right" bgcolor="#FFFFFF">55,314 ns</td><td align="right" bgcolor="#FFFFFF">53,858 ns</td><td align="right" bgcolor="#FFFFFF">53,289 ns</td><td align="right" bgcolor="#FFFFFF">53,597 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 50,113 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">689,329 ns</td><td align="right" bgcolor="#FFFFFF">703,772 ns</td><td align="right" bgcolor="#FFFFFF">653,658 ns</td><td align="right" bgcolor="#FFFFFF">654,898 ns</td><td align="right" bgcolor="#FFFFFF">668,918 ns</td><td align="right" bgcolor="#FFFFFF">658,053 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,689 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,655 μs</td><td align="right" bgcolor="#FFFFFF">0,669 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 0,647 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,692 ns</td><td align="right" bgcolor="#FFFFFF">14,281 ns</td><td align="right" bgcolor="#FFFFFF">14,928 ns</td><td align="right" bgcolor="#FFFFFF">14,854 ns</td><td align="right" bgcolor="#FFFFFF">14,696 ns</td><td align="right" bgcolor="#FFFFFF">14,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,061 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,072 ns</td><td align="right" bgcolor="#FFFFFF">15,893 ns</td><td align="right" bgcolor="#FFFFFF">17,563 ns</td><td align="right" bgcolor="#FFFFFF">17,675 ns</td><td align="right" bgcolor="#FFFFFF">17,953 ns</td><td align="right" bgcolor="#FFFFFF">17,423 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,174 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,443 ns</td><td align="right" bgcolor="#FFFFFF">6,318 ns</td><td align="right" bgcolor="#FFFFFF">7,318 ns</td><td align="right" bgcolor="#FFFFFF">7,493 ns</td><td align="right" bgcolor="#FFFFFF">7,412 ns</td><td align="right" bgcolor="#FFFFFF">7,415 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 11,211 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">522,392 ns</td><td align="right" bgcolor="#FFFFFF">521,297 ns</td><td align="right" bgcolor="#FFFFFF">519,081 ns</td><td align="right" bgcolor="#FFFFFF">522,550 ns</td><td align="right" bgcolor="#FFFFFF">530,291 ns</td><td align="right" bgcolor="#FFFFFF">520,075 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,530 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,741 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,205 ns</td><td align="right" bgcolor="#FFFFFF">1,082 ns</td><td align="right" bgcolor="#FFFFFF">1,678 ns</td><td align="right" bgcolor="#FFFFFF">1,756 ns</td><td align="right" bgcolor="#FFFFFF">1,823 ns</td><td align="right" bgcolor="#FFFFFF">1,728 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,938 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,273 ns</td><td align="right" bgcolor="#FFFFFF">0,962 ns</td><td align="right" bgcolor="#FFFFFF">2,900 ns</td><td align="right" bgcolor="#FFFFFF">2,696 ns</td><td align="right" bgcolor="#FFFFFF">2,752 ns</td><td align="right" bgcolor="#FFFFFF">2,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,097 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,624 ns</td><td align="right" bgcolor="#FFFFFF">9,662 ns</td><td align="right" bgcolor="#FFFFFF">11,712 ns</td><td align="right" bgcolor="#FFFFFF">11,721 ns</td><td align="right" bgcolor="#FFFFFF">11,638 ns</td><td align="right" bgcolor="#FFFFFF">11,528 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 0,102 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,322 ns</td><td align="right" bgcolor="#FFFFFF">3,254 ns</td><td align="right" bgcolor="#FFFFFF">3,344 ns</td><td align="right" bgcolor="#FFFFFF">3,319 ns</td><td align="right" bgcolor="#FFFFFF">3,349 ns</td><td align="right" bgcolor="#FFFFFF">3,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,038 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,763 ns</td><td align="right" bgcolor="#FFFFFF">14,353 ns</td><td align="right" bgcolor="#FFFFFF">16,894 ns</td><td align="right" bgcolor="#FFFFFF">18,391 ns</td><td align="right" bgcolor="#FFFFFF">16,997 ns</td><td align="right" bgcolor="#FFFFFF">17,530 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 16,827 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,223 ns</td><td align="right" bgcolor="#FFFFFF">81,820 ns</td><td align="right" bgcolor="#FFFFFF">97,062 ns</td><td align="right" bgcolor="#FFFFFF">96,869 ns</td><td align="right" bgcolor="#FFFFFF">98,049 ns</td><td align="right" bgcolor="#FFFFFF">95,062 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 20,892 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">86,813 ns</td><td align="right" bgcolor="#FFFFFF">86,882 ns</td><td align="right" bgcolor="#FFFFFF">104,857 ns</td><td align="right" bgcolor="#FFFFFF">103,619 ns</td><td align="right" bgcolor="#FFFFFF">106,275 ns</td><td align="right" bgcolor="#FFFFFF">107,705 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 12,583 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,895 ns</td><td align="right" bgcolor="#FFFFFF">55,127 ns</td><td align="right" bgcolor="#FFFFFF">66,478 ns</td><td align="right" bgcolor="#FFFFFF">67,085 ns</td><td align="right" bgcolor="#FFFFFF">67,138 ns</td><td align="right" bgcolor="#FFFFFF">67,710 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 10,993 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">63,818 ns</td><td align="right" bgcolor="#FFFFFF">69,177 ns</td><td align="right" bgcolor="#FFFFFF">74,061 ns</td><td align="right" bgcolor="#FFFFFF">74,467 ns</td><td align="right" bgcolor="#FFFFFF">74,810 ns</td><td align="right" bgcolor="#FFFFFF">74,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 3,095 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,583 ns</td><td align="right" bgcolor="#FFFFFF">24,593 ns</td><td align="right" bgcolor="#FFFFFF">26,732 ns</td><td align="right" bgcolor="#FFFFFF">26,393 ns</td><td align="right" bgcolor="#FFFFFF">27,678 ns</td><td align="right" bgcolor="#FFFFFF">26,372 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -24,000)</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,023)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 12,294 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,613 ns</td><td align="right" bgcolor="#FFFFFF">57,243 ns</td><td align="right" bgcolor="#FFFFFF">69,537 ns</td><td align="right" bgcolor="#FFFFFF">62,934 ns</td><td align="right" bgcolor="#FFFFFF">64,639 ns</td><td align="right" bgcolor="#FFFFFF">64,435 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,477 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">65,657 ns</td><td align="right" bgcolor="#FFFFFF">64,497 ns</td><td align="right" bgcolor="#FFFFFF">70,155 ns</td><td align="right" bgcolor="#FFFFFF">71,973 ns</td><td align="right" bgcolor="#FFFFFF">69,998 ns</td><td align="right" bgcolor="#FFFFFF">70,170 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 12,071 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,474 ns</td><td align="right" bgcolor="#FFFFFF">38,388 ns</td><td align="right" bgcolor="#FFFFFF">50,458 ns</td><td align="right" bgcolor="#FFFFFF">43,028 ns</td><td align="right" bgcolor="#FFFFFF">43,676 ns</td><td align="right" bgcolor="#FFFFFF">46,392 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 5,324 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,914 ns</td><td align="right" bgcolor="#FFFFFF">46,983 ns</td><td align="right" bgcolor="#FFFFFF">50,624 ns</td><td align="right" bgcolor="#FFFFFF">50,354 ns</td><td align="right" bgcolor="#FFFFFF">52,238 ns</td><td align="right" bgcolor="#FFFFFF">51,976 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 875,959 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7497,565 ns</td><td align="right" bgcolor="#FFFFFF">7419,384 ns</td><td align="right" bgcolor="#FF4949">8295,343 ns (Δ = +875,959 ns)</td><td align="right" bgcolor="#FFFFFF">8259,933 ns</td><td align="right" bgcolor="#FFFFFF">8237,532 ns</td><td align="right" bgcolor="#FFFFFF">8187,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,498 μs</td><td align="right" bgcolor="#FFFFFF">7,419 μs</td><td align="right" bgcolor="#FFFFFF">8,295 μs</td><td align="right" bgcolor="#FFFFFF">8,260 μs</td><td align="right" bgcolor="#FFFFFF">8,238 μs</td><td align="right" bgcolor="#FFFFFF">8,187 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 910,020 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7458,601 ns</td><td align="right" bgcolor="#FFFFFF">7426,547 ns</td><td align="right" bgcolor="#FF4949">8295,228 ns (Δ = +868,682 ns)</td><td align="right" bgcolor="#FFFFFF">8230,725 ns</td><td align="right" bgcolor="#FFFFFF">8250,513 ns</td><td align="right" bgcolor="#FFFFFF">8336,567 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,459 μs</td><td align="right" bgcolor="#FFFFFF">7,427 μs</td><td align="right" bgcolor="#FFFFFF">8,295 μs</td><td align="right" bgcolor="#FFFFFF">8,231 μs</td><td align="right" bgcolor="#FFFFFF">8,251 μs</td><td align="right" bgcolor="#FFFFFF">8,337 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 6071,867 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14520,500 ns</td><td align="right" bgcolor="#FFFFFF">14591,259 ns</td><td align="right" bgcolor="#FF4949">20536,415 ns (Δ = +5945,156 ns)</td><td align="right" bgcolor="#FFFFFF">20563,235 ns</td><td align="right" bgcolor="#FFFFFF">20592,368 ns</td><td align="right" bgcolor="#FFFFFF">20511,331 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,521 μs</td><td align="right" bgcolor="#FFFFFF">14,591 μs</td><td align="right" bgcolor="#FFFFFF">20,536 μs</td><td align="right" bgcolor="#FFFFFF">20,563 μs</td><td align="right" bgcolor="#FFFFFF">20,592 μs</td><td align="right" bgcolor="#FFFFFF">20,511 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1364,000</td><td align="right" bgcolor="#FF4949">1376,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -688,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,332</td><td align="right" bgcolor="#FF4949">1,344 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,672)</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 3522,552 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+55,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5975,336 ns</td><td align="right" bgcolor="#FFFFFF">6036,355 ns</td><td align="right" bgcolor="#FF4949">9402,676 ns (Δ = +3366,321 ns)</td><td align="right" bgcolor="#FFFFFF">9399,716 ns</td><td align="right" bgcolor="#FFFFFF">9497,888 ns</td><td align="right" bgcolor="#FFFFFF">9476,915 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,975 μs</td><td align="right" bgcolor="#FFFFFF">6,036 μs</td><td align="right" bgcolor="#FFFFFF">9,403 μs</td><td align="right" bgcolor="#FFFFFF">9,400 μs</td><td align="right" bgcolor="#FFFFFF">9,498 μs</td><td align="right" bgcolor="#FFFFFF">9,477 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3011,000</td><td align="right" bgcolor="#FF4949">3043,000 (Δ = +32,000)</td><td align="right" bgcolor="#A8D08D">1524,000 (Δ = -1519,000)</td><td align="right" bgcolor="#FFFFFF">1524,000</td><td align="right" bgcolor="#FFFFFF">1524,000</td><td align="right" bgcolor="#FFFFFF">1524,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,940</td><td align="right" bgcolor="#FF4949">2,972 (Δ = +0,031)</td><td align="right" bgcolor="#A8D08D">1,488 (Δ = -1,483)</td><td align="right" bgcolor="#FFFFFF">1,488</td><td align="right" bgcolor="#FFFFFF">1,488</td><td align="right" bgcolor="#FFFFFF">1,488</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 571,394 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9470,151 ns</td><td align="right" bgcolor="#FFFFFF">9493,048 ns</td><td align="right" bgcolor="#FF4949">10041,545 ns (Δ = +548,497 ns)</td><td align="right" bgcolor="#FFFFFF">9837,007 ns</td><td align="right" bgcolor="#FFFFFF">9805,854 ns</td><td align="right" bgcolor="#FFFFFF">9952,015 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,470 μs</td><td align="right" bgcolor="#FFFFFF">9,493 μs</td><td align="right" bgcolor="#FFFFFF">10,042 μs</td><td align="right" bgcolor="#FFFFFF">9,837 μs</td><td align="right" bgcolor="#FFFFFF">9,806 μs</td><td align="right" bgcolor="#FFFFFF">9,952 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">430,000 (Δ = -406,000)</td><td align="right" bgcolor="#FFFFFF">430,000</td><td align="right" bgcolor="#FFFFFF">430,000</td><td align="right" bgcolor="#FFFFFF">430,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,420 (Δ = -0,396)</td><td align="right" bgcolor="#FFFFFF">0,420</td><td align="right" bgcolor="#FFFFFF">0,420</td><td align="right" bgcolor="#FFFFFF">0,420</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 420,541 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9672,293 ns</td><td align="right" bgcolor="#FFFFFF">9584,701 ns</td><td align="right" bgcolor="#FF4949">10005,243 ns (Δ = +420,541 ns)</td><td align="right" bgcolor="#FFFFFF">9901,386 ns</td><td align="right" bgcolor="#FFFFFF">9975,946 ns</td><td align="right" bgcolor="#FFFFFF">9862,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,672 μs</td><td align="right" bgcolor="#FFFFFF">9,585 μs</td><td align="right" bgcolor="#FFFFFF">10,005 μs</td><td align="right" bgcolor="#FFFFFF">9,901 μs</td><td align="right" bgcolor="#FFFFFF">9,976 μs</td><td align="right" bgcolor="#FFFFFF">9,863 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#A8D08D">479,000 (Δ = -402,000)</td><td align="right" bgcolor="#FFFFFF">479,000</td><td align="right" bgcolor="#FFFFFF">479,000</td><td align="right" bgcolor="#FFFFFF">479,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#A8D08D">0,468 (Δ = -0,393)</td><td align="right" bgcolor="#FFFFFF">0,468</td><td align="right" bgcolor="#FFFFFF">0,468</td><td align="right" bgcolor="#FFFFFF">0,468</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 622,039 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9364,787 ns</td><td align="right" bgcolor="#FF4949">9721,422 ns (Δ = +356,635 ns)</td><td align="right" bgcolor="#FFFFFF">9903,802 ns</td><td align="right" bgcolor="#FFFFFF">9762,056 ns</td><td align="right" bgcolor="#FFFFFF">9861,881 ns</td><td align="right" bgcolor="#FFFFFF">9986,825 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,365 μs</td><td align="right" bgcolor="#FFFFFF">9,721 μs</td><td align="right" bgcolor="#FFFFFF">9,904 μs</td><td align="right" bgcolor="#FFFFFF">9,762 μs</td><td align="right" bgcolor="#FFFFFF">9,862 μs</td><td align="right" bgcolor="#FFFFFF">9,987 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 175890,118 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">434405,282 ns</td><td align="right" bgcolor="#FFFFFF">436723,240 ns</td><td align="right" bgcolor="#A8D08D">260833,123 ns (Δ = -175890,118 ns)</td><td align="right" bgcolor="#FFFFFF">262264,990 ns</td><td align="right" bgcolor="#FFFFFF">261255,308 ns</td><td align="right" bgcolor="#FFFFFF">262948,850 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">434,405 μs</td><td align="right" bgcolor="#FFFFFF">436,723 μs</td><td align="right" bgcolor="#FFFFFF">260,833 μs</td><td align="right" bgcolor="#FFFFFF">262,265 μs</td><td align="right" bgcolor="#FFFFFF">261,255 μs</td><td align="right" bgcolor="#FFFFFF">262,949 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,434 ms</td><td align="right" bgcolor="#FFFFFF">0,437 ms</td><td align="right" bgcolor="#FFFFFF">0,261 ms</td><td align="right" bgcolor="#FFFFFF">0,262 ms</td><td align="right" bgcolor="#FFFFFF">0,261 ms</td><td align="right" bgcolor="#FFFFFF">0,263 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-46,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20459,500</td><td align="right" bgcolor="#FF4949">20460,000 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">10916,000 (Δ = -9544,000)</td><td align="right" bgcolor="#FFFFFF">10916,000</td><td align="right" bgcolor="#FFFFFF">10916,000</td><td align="right" bgcolor="#FFFFFF">10916,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">19,980</td><td align="right" bgcolor="#FF4949">19,980 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">10,660 (Δ = -9,320)</td><td align="right" bgcolor="#FFFFFF">10,660</td><td align="right" bgcolor="#FFFFFF">10,660</td><td align="right" bgcolor="#FFFFFF">10,660</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 827,435 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2457,080 ns</td><td align="right" bgcolor="#FFFFFF">2448,724 ns</td><td align="right" bgcolor="#FF4949">3263,906 ns (Δ = +815,182 ns)</td><td align="right" bgcolor="#FFFFFF">3276,159 ns</td><td align="right" bgcolor="#FFFFFF">3272,328 ns</td><td align="right" bgcolor="#FFFFFF">3235,137 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,457 μs</td><td align="right" bgcolor="#FFFFFF">2,449 μs</td><td align="right" bgcolor="#FFFFFF">3,264 μs</td><td align="right" bgcolor="#FFFFFF">3,276 μs</td><td align="right" bgcolor="#FFFFFF">3,272 μs</td><td align="right" bgcolor="#FFFFFF">3,235 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#A8D08D">750,000 (Δ = -262,000)</td><td align="right" bgcolor="#FFFFFF">750,000</td><td align="right" bgcolor="#FFFFFF">750,000</td><td align="right" bgcolor="#FFFFFF">750,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#A8D08D">0,732 (Δ = -0,256)</td><td align="right" bgcolor="#FFFFFF">0,732</td><td align="right" bgcolor="#FFFFFF">0,732</td><td align="right" bgcolor="#FFFFFF">0,732</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 1823,727 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7607,380 ns</td><td align="right" bgcolor="#FFFFFF">7612,338 ns</td><td align="right" bgcolor="#FF4949">8329,228 ns (Δ = +716,891 ns)</td><td align="right" bgcolor="#FFFFFF">8290,705 ns</td><td align="right" bgcolor="#FFFFFF">8226,909 ns</td><td align="right" bgcolor="#FF4949">9431,107 ns (Δ = +1204,197 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,607 μs</td><td align="right" bgcolor="#FFFFFF">7,612 μs</td><td align="right" bgcolor="#FFFFFF">8,329 μs</td><td align="right" bgcolor="#FFFFFF">8,291 μs</td><td align="right" bgcolor="#FFFFFF">8,227 μs</td><td align="right" bgcolor="#FFFFFF">9,431 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">422,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">422,000</td><td align="right" bgcolor="#FFFFFF">422,000</td><td align="right" bgcolor="#FFFFFF">422,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,412 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,412</td><td align="right" bgcolor="#FFFFFF">0,412</td><td align="right" bgcolor="#FFFFFF">0,412</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 379,702 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9597,452 ns</td><td align="right" bgcolor="#FFFFFF">9632,034 ns</td><td align="right" bgcolor="#FF4949">9921,253 ns (Δ = +289,219 ns)</td><td align="right" bgcolor="#FFFFFF">9977,153 ns</td><td align="right" bgcolor="#FFFFFF">9866,675 ns</td><td align="right" bgcolor="#FFFFFF">9880,403 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,597 μs</td><td align="right" bgcolor="#FFFFFF">9,632 μs</td><td align="right" bgcolor="#FFFFFF">9,921 μs</td><td align="right" bgcolor="#FFFFFF">9,977 μs</td><td align="right" bgcolor="#FFFFFF">9,867 μs</td><td align="right" bgcolor="#FFFFFF">9,880 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1281,592 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,8 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10895,803 ns</td><td align="right" bgcolor="#A8D08D">9614,210 ns (Δ = -1281,592 ns)</td><td align="right" bgcolor="#FF4949">9962,062 ns (Δ = +347,852 ns)</td><td align="right" bgcolor="#FFFFFF">9904,191 ns</td><td align="right" bgcolor="#FFFFFF">9766,379 ns</td><td align="right" bgcolor="#FF4949">10211,987 ns (Δ = +445,608 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,896 μs</td><td align="right" bgcolor="#FFFFFF">9,614 μs</td><td align="right" bgcolor="#FFFFFF">9,962 μs</td><td align="right" bgcolor="#FFFFFF">9,904 μs</td><td align="right" bgcolor="#FFFFFF">9,766 μs</td><td align="right" bgcolor="#FFFFFF">10,212 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 52,507 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">950,331 ns</td><td align="right" bgcolor="#FFFFFF">1002,838 ns</td><td align="right" bgcolor="#FFFFFF">952,636 ns</td><td align="right" bgcolor="#FFFFFF">953,593 ns</td><td align="right" bgcolor="#FFFFFF">955,818 ns</td><td align="right" bgcolor="#FFFFFF">970,715 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td><td align="right" bgcolor="#FFFFFF">0,953 μs</td><td align="right" bgcolor="#FFFFFF">0,954 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#A8D08D">881,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#A8D08D">0,860 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 492,479 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2564,723 ns</td><td align="right" bgcolor="#FFFFFF">2513,654 ns</td><td align="right" bgcolor="#FF4949">2956,736 ns (Δ = +443,082 ns)</td><td align="right" bgcolor="#FFFFFF">2964,756 ns</td><td align="right" bgcolor="#FFFFFF">2984,684 ns</td><td align="right" bgcolor="#FFFFFF">3006,133 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,565 μs</td><td align="right" bgcolor="#FFFFFF">2,514 μs</td><td align="right" bgcolor="#FFFFFF">2,957 μs</td><td align="right" bgcolor="#FFFFFF">2,965 μs</td><td align="right" bgcolor="#FFFFFF">2,985 μs</td><td align="right" bgcolor="#FFFFFF">3,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 221,230 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3339,553 ns</td><td align="right" bgcolor="#FFFFFF">3352,485 ns</td><td align="right" bgcolor="#FFFFFF">3536,437 ns</td><td align="right" bgcolor="#FFFFFF">3525,110 ns</td><td align="right" bgcolor="#FFFFFF">3483,834 ns</td><td align="right" bgcolor="#FFFFFF">3560,783 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,340 μs</td><td align="right" bgcolor="#FFFFFF">3,352 μs</td><td align="right" bgcolor="#FFFFFF">3,536 μs</td><td align="right" bgcolor="#FFFFFF">3,525 μs</td><td align="right" bgcolor="#FFFFFF">3,484 μs</td><td align="right" bgcolor="#FFFFFF">3,561 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 450,428 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2637,119 ns</td><td align="right" bgcolor="#FFFFFF">2581,977 ns</td><td align="right" bgcolor="#FF4949">3020,733 ns (Δ = +438,757 ns)</td><td align="right" bgcolor="#FFFFFF">3032,404 ns</td><td align="right" bgcolor="#FFFFFF">3000,388 ns</td><td align="right" bgcolor="#FFFFFF">3030,948 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,637 μs</td><td align="right" bgcolor="#FFFFFF">2,582 μs</td><td align="right" bgcolor="#FFFFFF">3,021 μs</td><td align="right" bgcolor="#FFFFFF">3,032 μs</td><td align="right" bgcolor="#FFFFFF">3,000 μs</td><td align="right" bgcolor="#FFFFFF">3,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 255,648 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3380,980 ns</td><td align="right" bgcolor="#FFFFFF">3425,538 ns</td><td align="right" bgcolor="#FFFFFF">3594,261 ns</td><td align="right" bgcolor="#FFFFFF">3504,508 ns</td><td align="right" bgcolor="#FFFFFF">3636,628 ns</td><td align="right" bgcolor="#FFFFFF">3559,883 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,381 μs</td><td align="right" bgcolor="#FFFFFF">3,426 μs</td><td align="right" bgcolor="#FFFFFF">3,594 μs</td><td align="right" bgcolor="#FFFFFF">3,505 μs</td><td align="right" bgcolor="#FFFFFF">3,637 μs</td><td align="right" bgcolor="#FFFFFF">3,560 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 524,521 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2579,237 ns</td><td align="right" bgcolor="#FFFFFF">2507,305 ns</td><td align="right" bgcolor="#FF4949">3005,872 ns (Δ = +498,567 ns)</td><td align="right" bgcolor="#FFFFFF">3008,652 ns</td><td align="right" bgcolor="#FFFFFF">3031,826 ns</td><td align="right" bgcolor="#FFFFFF">3022,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,579 μs</td><td align="right" bgcolor="#FFFFFF">2,507 μs</td><td align="right" bgcolor="#FFFFFF">3,006 μs</td><td align="right" bgcolor="#FFFFFF">3,009 μs</td><td align="right" bgcolor="#FFFFFF">3,032 μs</td><td align="right" bgcolor="#FFFFFF">3,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 164,780 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3420,776 ns</td><td align="right" bgcolor="#FFFFFF">3398,095 ns</td><td align="right" bgcolor="#FFFFFF">3562,875 ns</td><td align="right" bgcolor="#FFFFFF">3547,417 ns</td><td align="right" bgcolor="#FFFFFF">3474,393 ns</td><td align="right" bgcolor="#FFFFFF">3458,560 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,421 μs</td><td align="right" bgcolor="#FFFFFF">3,398 μs</td><td align="right" bgcolor="#FFFFFF">3,563 μs</td><td align="right" bgcolor="#FFFFFF">3,547 μs</td><td align="right" bgcolor="#FFFFFF">3,474 μs</td><td align="right" bgcolor="#FFFFFF">3,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 565,487 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2575,810 ns</td><td align="right" bgcolor="#FFFFFF">2563,393 ns</td><td align="right" bgcolor="#FF4949">3038,244 ns (Δ = +474,852 ns)</td><td align="right" bgcolor="#FFFFFF">3047,328 ns</td><td align="right" bgcolor="#FFFFFF">3128,879 ns</td><td align="right" bgcolor="#FFFFFF">3020,398 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,576 μs</td><td align="right" bgcolor="#FFFFFF">2,563 μs</td><td align="right" bgcolor="#FFFFFF">3,038 μs</td><td align="right" bgcolor="#FFFFFF">3,047 μs</td><td align="right" bgcolor="#FFFFFF">3,129 μs</td><td align="right" bgcolor="#FFFFFF">3,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 165,020 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3388,901 ns</td><td align="right" bgcolor="#FFFFFF">3409,564 ns</td><td align="right" bgcolor="#FFFFFF">3553,921 ns</td><td align="right" bgcolor="#FFFFFF">3521,496 ns</td><td align="right" bgcolor="#FFFFFF">3551,048 ns</td><td align="right" bgcolor="#FFFFFF">3531,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,389 μs</td><td align="right" bgcolor="#FFFFFF">3,410 μs</td><td align="right" bgcolor="#FFFFFF">3,554 μs</td><td align="right" bgcolor="#FFFFFF">3,521 μs</td><td align="right" bgcolor="#FFFFFF">3,551 μs</td><td align="right" bgcolor="#FFFFFF">3,531 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 513,481 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2540,577 ns</td><td align="right" bgcolor="#FFFFFF">2516,673 ns</td><td align="right" bgcolor="#FF4949">3013,416 ns (Δ = +496,743 ns)</td><td align="right" bgcolor="#FFFFFF">3000,891 ns</td><td align="right" bgcolor="#FFFFFF">2981,952 ns</td><td align="right" bgcolor="#FFFFFF">3030,153 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,541 μs</td><td align="right" bgcolor="#FFFFFF">2,517 μs</td><td align="right" bgcolor="#FFFFFF">3,013 μs</td><td align="right" bgcolor="#FFFFFF">3,001 μs</td><td align="right" bgcolor="#FFFFFF">2,982 μs</td><td align="right" bgcolor="#FFFFFF">3,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 221,644 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3335,209 ns</td><td align="right" bgcolor="#FFFFFF">3466,343 ns</td><td align="right" bgcolor="#FFFFFF">3556,852 ns</td><td align="right" bgcolor="#FFFFFF">3532,426 ns</td><td align="right" bgcolor="#FFFFFF">3498,275 ns</td><td align="right" bgcolor="#FFFFFF">3511,818 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,335 μs</td><td align="right" bgcolor="#FFFFFF">3,466 μs</td><td align="right" bgcolor="#FFFFFF">3,557 μs</td><td align="right" bgcolor="#FFFFFF">3,532 μs</td><td align="right" bgcolor="#FFFFFF">3,498 μs</td><td align="right" bgcolor="#FFFFFF">3,512 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 497,950 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2660,503 ns</td><td align="right" bgcolor="#FFFFFF">2613,712 ns</td><td align="right" bgcolor="#FF4949">3111,662 ns (Δ = +497,950 ns)</td><td align="right" bgcolor="#FFFFFF">3054,818 ns</td><td align="right" bgcolor="#FFFFFF">3030,522 ns</td><td align="right" bgcolor="#FFFFFF">3076,220 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,661 μs</td><td align="right" bgcolor="#FFFFFF">2,614 μs</td><td align="right" bgcolor="#FFFFFF">3,112 μs</td><td align="right" bgcolor="#FFFFFF">3,055 μs</td><td align="right" bgcolor="#FFFFFF">3,031 μs</td><td align="right" bgcolor="#FFFFFF">3,076 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 456,842 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3397,559 ns</td><td align="right" bgcolor="#FFFFFF">3428,198 ns</td><td align="right" bgcolor="#FFFFFF">3574,714 ns</td><td align="right" bgcolor="#FF4949">3854,401 ns (Δ = +279,686 ns)</td><td align="right" bgcolor="#A8D08D">3582,230 ns (Δ = -272,171 ns)</td><td align="right" bgcolor="#FFFFFF">3577,122 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,398 μs</td><td align="right" bgcolor="#FFFFFF">3,428 μs</td><td align="right" bgcolor="#FFFFFF">3,575 μs</td><td align="right" bgcolor="#FFFFFF">3,854 μs</td><td align="right" bgcolor="#FFFFFF">3,582 μs</td><td align="right" bgcolor="#FFFFFF">3,577 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 28,667 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,084 ns</td><td align="right" bgcolor="#FFFFFF">236,535 ns</td><td align="right" bgcolor="#FFFFFF">258,427 ns</td><td align="right" bgcolor="#FFFFFF">262,751 ns</td><td align="right" bgcolor="#FFFFFF">258,378 ns</td><td align="right" bgcolor="#FFFFFF">260,638 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,258 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,258 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 24,814 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">246,511 ns</td><td align="right" bgcolor="#FFFFFF">241,064 ns</td><td align="right" bgcolor="#FFFFFF">264,320 ns</td><td align="right" bgcolor="#FFFFFF">263,849 ns</td><td align="right" bgcolor="#FFFFFF">263,359 ns</td><td align="right" bgcolor="#FFFFFF">265,878 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,241 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 22,667 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">248,468 ns</td><td align="right" bgcolor="#FFFFFF">242,495 ns</td><td align="right" bgcolor="#FFFFFF">265,163 ns</td><td align="right" bgcolor="#FFFFFF">264,771 ns</td><td align="right" bgcolor="#FFFFFF">264,773 ns</td><td align="right" bgcolor="#FFFFFF">264,753 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 22,340 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,486 ns</td><td align="right" bgcolor="#FFFFFF">223,320 ns</td><td align="right" bgcolor="#FFFFFF">244,826 ns</td><td align="right" bgcolor="#FFFFFF">244,186 ns</td><td align="right" bgcolor="#FFFFFF">243,762 ns</td><td align="right" bgcolor="#FFFFFF">244,348 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 22,868 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">223,589 ns</td><td align="right" bgcolor="#FFFFFF">223,169 ns</td><td align="right" bgcolor="#FFFFFF">246,037 ns</td><td align="right" bgcolor="#FFFFFF">242,883 ns</td><td align="right" bgcolor="#FFFFFF">244,513 ns</td><td align="right" bgcolor="#FFFFFF">241,983 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 24,851 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">236,018 ns</td><td align="right" bgcolor="#FFFFFF">241,983 ns</td><td align="right" bgcolor="#FFFFFF">260,869 ns</td><td align="right" bgcolor="#FFFFFF">256,940 ns</td><td align="right" bgcolor="#FFFFFF">258,608 ns</td><td align="right" bgcolor="#FFFFFF">256,398 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 109,180 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">851,155 ns</td><td align="right" bgcolor="#FFFFFF">846,876 ns</td><td align="right" bgcolor="#FFFFFF">935,165 ns</td><td align="right" bgcolor="#FFFFFF">956,056 ns</td><td align="right" bgcolor="#FFFFFF">935,057 ns</td><td align="right" bgcolor="#FFFFFF">933,085 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,847 μs</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -94,000)</td><td align="right" bgcolor="#FFFFFF">94,000</td><td align="right" bgcolor="#FFFFFF">94,000</td><td align="right" bgcolor="#FFFFFF">94,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,092)</td><td align="right" bgcolor="#FFFFFF">0,092</td><td align="right" bgcolor="#FFFFFF">0,092</td><td align="right" bgcolor="#FFFFFF">0,092</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 39,342 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">120,908 ns</td><td align="right" bgcolor="#FFFFFF">120,013 ns</td><td align="right" bgcolor="#FFFFFF">159,355 ns</td><td align="right" bgcolor="#FFFFFF">133,949 ns</td><td align="right" bgcolor="#FFFFFF">132,961 ns</td><td align="right" bgcolor="#FFFFFF">133,555 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 12,383 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">140,136 ns</td><td align="right" bgcolor="#FFFFFF">140,494 ns</td><td align="right" bgcolor="#FFFFFF">150,213 ns</td><td align="right" bgcolor="#FFFFFF">149,029 ns</td><td align="right" bgcolor="#FFFFFF">149,025 ns</td><td align="right" bgcolor="#FFFFFF">152,518 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 237,996 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2026,585 ns</td><td align="right" bgcolor="#FFFFFF">2008,320 ns</td><td align="right" bgcolor="#FFFFFF">1825,863 ns</td><td align="right" bgcolor="#FFFFFF">1788,589 ns</td><td align="right" bgcolor="#FFFFFF">1802,621 ns</td><td align="right" bgcolor="#FFFFFF">1798,143 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,027 μs</td><td align="right" bgcolor="#FFFFFF">2,008 μs</td><td align="right" bgcolor="#FFFFFF">1,826 μs</td><td align="right" bgcolor="#FFFFFF">1,789 μs</td><td align="right" bgcolor="#FFFFFF">1,803 μs</td><td align="right" bgcolor="#FFFFFF">1,798 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -446,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,436)</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 384,338 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3795,136 ns</td><td align="right" bgcolor="#FFFFFF">3759,068 ns</td><td align="right" bgcolor="#FFFFFF">3680,080 ns</td><td align="right" bgcolor="#FFFFFF">3480,780 ns</td><td align="right" bgcolor="#FFFFFF">3441,352 ns</td><td align="right" bgcolor="#FFFFFF">3410,798 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,795 μs</td><td align="right" bgcolor="#FFFFFF">3,759 μs</td><td align="right" bgcolor="#FFFFFF">3,680 μs</td><td align="right" bgcolor="#FFFFFF">3,481 μs</td><td align="right" bgcolor="#FFFFFF">3,441 μs</td><td align="right" bgcolor="#FFFFFF">3,411 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#A8D08D">594,000 (Δ = -512,000)</td><td align="right" bgcolor="#FFFFFF">594,000</td><td align="right" bgcolor="#FFFFFF">594,000</td><td align="right" bgcolor="#FFFFFF">594,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#A8D08D">0,580 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">0,580</td><td align="right" bgcolor="#FFFFFF">0,580</td><td align="right" bgcolor="#FFFFFF">0,580</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 33,140 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">273,037 ns</td><td align="right" bgcolor="#FFFFFF">277,803 ns</td><td align="right" bgcolor="#FFFFFF">305,733 ns</td><td align="right" bgcolor="#FFFFFF">305,899 ns</td><td align="right" bgcolor="#FFFFFF">306,177 ns</td><td align="right" bgcolor="#FFFFFF">306,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 554,437 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3946,752 ns</td><td align="right" bgcolor="#FFFFFF">3942,473 ns</td><td align="right" bgcolor="#A8D08D">3470,525 ns (Δ = -471,948 ns)</td><td align="right" bgcolor="#FFFFFF">3525,192 ns</td><td align="right" bgcolor="#FFFFFF">3550,305 ns</td><td align="right" bgcolor="#FFFFFF">3392,315 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,947 μs</td><td align="right" bgcolor="#FFFFFF">3,942 μs</td><td align="right" bgcolor="#FFFFFF">3,471 μs</td><td align="right" bgcolor="#FFFFFF">3,525 μs</td><td align="right" bgcolor="#FFFFFF">3,550 μs</td><td align="right" bgcolor="#FFFFFF">3,392 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#A8D08D">651,000 (Δ = -545,000)</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#A8D08D">0,636 (Δ = -0,532)</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 42,944 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">292,297 ns</td><td align="right" bgcolor="#FFFFFF">289,479 ns</td><td align="right" bgcolor="#FFFFFF">326,122 ns</td><td align="right" bgcolor="#FFFFFF">325,470 ns</td><td align="right" bgcolor="#FFFFFF">326,069 ns</td><td align="right" bgcolor="#FFFFFF">332,423 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td><td align="right" bgcolor="#FFFFFF">0,326 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,326 μs</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 38,143 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">294,512 ns</td><td align="right" bgcolor="#FFFFFF">293,047 ns</td><td align="right" bgcolor="#FFFFFF">328,102 ns</td><td align="right" bgcolor="#FFFFFF">328,788 ns</td><td align="right" bgcolor="#FFFFFF">328,457 ns</td><td align="right" bgcolor="#FFFFFF">331,190 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td><td align="right" bgcolor="#FFFFFF">0,331 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 42,528 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">285,508 ns</td><td align="right" bgcolor="#FFFFFF">289,575 ns</td><td align="right" bgcolor="#FFFFFF">323,371 ns</td><td align="right" bgcolor="#FFFFFF">323,767 ns</td><td align="right" bgcolor="#FFFFFF">325,543 ns</td><td align="right" bgcolor="#FFFFFF">328,035 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,323 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td><td align="right" bgcolor="#FFFFFF">0,326 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 43,002 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">285,412 ns</td><td align="right" bgcolor="#FFFFFF">285,994 ns</td><td align="right" bgcolor="#FFFFFF">324,498 ns</td><td align="right" bgcolor="#FFFFFF">324,564 ns</td><td align="right" bgcolor="#FFFFFF">323,566 ns</td><td align="right" bgcolor="#FFFFFF">328,413 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 301,153 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1979,556 ns</td><td align="right" bgcolor="#FFFFFF">1831,561 ns</td><td align="right" bgcolor="#FFFFFF">1685,147 ns</td><td align="right" bgcolor="#FFFFFF">1691,943 ns</td><td align="right" bgcolor="#FFFFFF">1678,403 ns</td><td align="right" bgcolor="#FFFFFF">1735,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,980 μs</td><td align="right" bgcolor="#FFFFFF">1,832 μs</td><td align="right" bgcolor="#FFFFFF">1,685 μs</td><td align="right" bgcolor="#FFFFFF">1,692 μs</td><td align="right" bgcolor="#FFFFFF">1,678 μs</td><td align="right" bgcolor="#FFFFFF">1,735 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">336,000 (Δ = -315,000)</td><td align="right" bgcolor="#FFFFFF">336,000</td><td align="right" bgcolor="#FFFFFF">336,000</td><td align="right" bgcolor="#FFFFFF">336,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,328 (Δ = -0,308)</td><td align="right" bgcolor="#FFFFFF">0,328</td><td align="right" bgcolor="#FFFFFF">0,328</td><td align="right" bgcolor="#FFFFFF">0,328</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 498,021 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3898,809 ns</td><td align="right" bgcolor="#A8D08D">3533,068 ns (Δ = -365,742 ns)</td><td align="right" bgcolor="#FFFFFF">3500,894 ns</td><td align="right" bgcolor="#FFFFFF">3470,078 ns</td><td align="right" bgcolor="#FFFFFF">3492,078 ns</td><td align="right" bgcolor="#FFFFFF">3400,788 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,899 μs</td><td align="right" bgcolor="#FFFFFF">3,533 μs</td><td align="right" bgcolor="#FFFFFF">3,501 μs</td><td align="right" bgcolor="#FFFFFF">3,470 μs</td><td align="right" bgcolor="#FFFFFF">3,492 μs</td><td align="right" bgcolor="#FFFFFF">3,401 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#A8D08D">1368,000 (Δ = -619,000)</td><td align="right" bgcolor="#FFFFFF">1368,000</td><td align="right" bgcolor="#FFFFFF">1368,000</td><td align="right" bgcolor="#FFFFFF">1368,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#A8D08D">1,336 (Δ = -0,604)</td><td align="right" bgcolor="#FFFFFF">1,336</td><td align="right" bgcolor="#FFFFFF">1,336</td><td align="right" bgcolor="#FFFFFF">1,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 594,897 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+187,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">288,609 ns</td><td align="right" bgcolor="#FFFFFF">293,456 ns</td><td align="right" bgcolor="#FF4949">842,878 ns (Δ = +549,421 ns)</td><td align="right" bgcolor="#FFFFFF">836,459 ns</td><td align="right" bgcolor="#FFFFFF">836,467 ns</td><td align="right" bgcolor="#FFFFFF">883,507 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 56,990 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,606 ns</td><td align="right" bgcolor="#FFFFFF">44,143 ns</td><td align="right" bgcolor="#FFFFFF">101,133 ns</td><td align="right" bgcolor="#FFFFFF">100,404 ns</td><td align="right" bgcolor="#FFFFFF">100,057 ns</td><td align="right" bgcolor="#FFFFFF">100,442 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 0,586 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,453 ns</td><td align="right" bgcolor="#FFFFFF">6,370 ns</td><td align="right" bgcolor="#FFFFFF">6,356 ns</td><td align="right" bgcolor="#FFFFFF">6,365 ns</td><td align="right" bgcolor="#FFFFFF">6,393 ns</td><td align="right" bgcolor="#FFFFFF">6,942 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 0,192 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,426 ns</td><td align="right" bgcolor="#FFFFFF">7,407 ns</td><td align="right" bgcolor="#FFFFFF">7,578 ns</td><td align="right" bgcolor="#FFFFFF">7,556 ns</td><td align="right" bgcolor="#FFFFFF">7,510 ns</td><td align="right" bgcolor="#FFFFFF">7,598 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 245,994 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">903,255 ns</td><td align="right" bgcolor="#FFFFFF">1092,832 ns</td><td align="right" bgcolor="#FFFFFF">1149,249 ns</td><td align="right" bgcolor="#FFFFFF">1137,889 ns</td><td align="right" bgcolor="#FFFFFF">1127,319 ns</td><td align="right" bgcolor="#FFFFFF">1131,383 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,903 μs</td><td align="right" bgcolor="#FFFFFF">1,093 μs</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td><td align="right" bgcolor="#FFFFFF">1,138 μs</td><td align="right" bgcolor="#FFFFFF">1,127 μs</td><td align="right" bgcolor="#FFFFFF">1,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#A8D08D">-26,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">979,000</td><td align="right" bgcolor="#FF4949">1073,000 (Δ = +94,000)</td><td align="right" bgcolor="#A8D08D">791,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">791,000</td><td align="right" bgcolor="#FFFFFF">791,000</td><td align="right" bgcolor="#FFFFFF">791,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,956</td><td align="right" bgcolor="#FF4949">1,048 (Δ = +0,092)</td><td align="right" bgcolor="#A8D08D">0,772 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,772</td><td align="right" bgcolor="#FFFFFF">0,772</td><td align="right" bgcolor="#FFFFFF">0,772</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 41,735 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">444,069 ns</td><td align="right" bgcolor="#FFFFFF">460,927 ns</td><td align="right" bgcolor="#FFFFFF">485,804 ns</td><td align="right" bgcolor="#FFFFFF">472,823 ns</td><td align="right" bgcolor="#FFFFFF">455,350 ns</td><td align="right" bgcolor="#FFFFFF">460,550 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,486 μs</td><td align="right" bgcolor="#FFFFFF">0,473 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">459,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">360,000</td><td align="right" bgcolor="#FFFFFF">360,000</td><td align="right" bgcolor="#FFFFFF">360,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,448 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,352 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,352</td><td align="right" bgcolor="#FFFFFF">0,352</td><td align="right" bgcolor="#FFFFFF">0,352</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 438,322 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,6 %</td><td align="right" bgcolor="#A8D08D">-13,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2030,998 ns</td><td align="right" bgcolor="#FF4949">2469,320 ns (Δ = +438,322 ns)</td><td align="right" bgcolor="#A8D08D">2149,200 ns (Δ = -320,120 ns)</td><td align="right" bgcolor="#FFFFFF">2156,422 ns</td><td align="right" bgcolor="#FFFFFF">2174,267 ns</td><td align="right" bgcolor="#FFFFFF">2111,115 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,031 μs</td><td align="right" bgcolor="#FFFFFF">2,469 μs</td><td align="right" bgcolor="#FFFFFF">2,149 μs</td><td align="right" bgcolor="#FFFFFF">2,156 μs</td><td align="right" bgcolor="#FFFFFF">2,174 μs</td><td align="right" bgcolor="#FFFFFF">2,111 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3969,000</td><td align="right" bgcolor="#FF4949">4067,000 (Δ = +98,000)</td><td align="right" bgcolor="#A8D08D">2245,000 (Δ = -1822,000)</td><td align="right" bgcolor="#FFFFFF">2245,000</td><td align="right" bgcolor="#FFFFFF">2245,000</td><td align="right" bgcolor="#FFFFFF">2245,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,876</td><td align="right" bgcolor="#FF4949">3,972 (Δ = +0,096)</td><td align="right" bgcolor="#A8D08D">2,192 (Δ = -1,779)</td><td align="right" bgcolor="#FFFFFF">2,192</td><td align="right" bgcolor="#FFFFFF">2,192</td><td align="right" bgcolor="#FFFFFF">2,192</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 149,247 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1015,007 ns</td><td align="right" bgcolor="#FFFFFF">951,692 ns</td><td align="right" bgcolor="#FFFFFF">897,708 ns</td><td align="right" bgcolor="#FFFFFF">879,229 ns</td><td align="right" bgcolor="#FFFFFF">899,648 ns</td><td align="right" bgcolor="#FFFFFF">865,760 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,015 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,898 μs</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td><td align="right" bgcolor="#FFFFFF">0,900 μs</td><td align="right" bgcolor="#FFFFFF">0,866 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1858,500</td><td align="right" bgcolor="#FF4949">1860,000 (Δ = +1,500)</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -865,000)</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,815</td><td align="right" bgcolor="#FF4949">1,816 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,845)</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 9,366 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,868 ns</td><td align="right" bgcolor="#FFFFFF">20,224 ns</td><td align="right" bgcolor="#FFFFFF">26,920 ns</td><td align="right" bgcolor="#FFFFFF">28,112 ns</td><td align="right" bgcolor="#FFFFFF">28,553 ns</td><td align="right" bgcolor="#FFFFFF">29,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#A8D08D">53,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">53,000</td><td align="right" bgcolor="#FFFFFF">53,000</td><td align="right" bgcolor="#FFFFFF">53,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#A8D08D">0,052 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,052</td><td align="right" bgcolor="#FFFFFF">0,052</td><td align="right" bgcolor="#FFFFFF">0,052</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 143,091 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">546,176 ns</td><td align="right" bgcolor="#FFFFFF">406,468 ns</td><td align="right" bgcolor="#FFFFFF">403,085 ns</td><td align="right" bgcolor="#FFFFFF">405,485 ns</td><td align="right" bgcolor="#FFFFFF">404,313 ns</td><td align="right" bgcolor="#FFFFFF">420,410 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,546 μs</td><td align="right" bgcolor="#FFFFFF">0,406 μs</td><td align="right" bgcolor="#FFFFFF">0,403 μs</td><td align="right" bgcolor="#FFFFFF">0,405 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,420 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 150,773 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">630,717 ns</td><td align="right" bgcolor="#FFFFFF">588,714 ns</td><td align="right" bgcolor="#FFFFFF">675,332 ns</td><td align="right" bgcolor="#FFFFFF">724,447 ns</td><td align="right" bgcolor="#FFFFFF">697,078 ns</td><td align="right" bgcolor="#FFFFFF">739,487 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,631 μs</td><td align="right" bgcolor="#FFFFFF">0,589 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,724 μs</td><td align="right" bgcolor="#FFFFFF">0,697 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 135,830 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">762,268 ns</td><td align="right" bgcolor="#FFFFFF">703,383 ns</td><td align="right" bgcolor="#FFFFFF">832,179 ns</td><td align="right" bgcolor="#FFFFFF">839,213 ns</td><td align="right" bgcolor="#FFFFFF">816,443 ns</td><td align="right" bgcolor="#FFFFFF">836,875 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,762 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,832 μs</td><td align="right" bgcolor="#FFFFFF">0,839 μs</td><td align="right" bgcolor="#FFFFFF">0,816 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 263,192 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">919,656 ns</td><td align="right" bgcolor="#FFFFFF">841,171 ns</td><td align="right" bgcolor="#FFFFFF">994,569 ns</td><td align="right" bgcolor="#FFFFFF">1104,363 ns</td><td align="right" bgcolor="#FFFFFF">972,348 ns</td><td align="right" bgcolor="#FFFFFF">1003,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,920 μs</td><td align="right" bgcolor="#FFFFFF">0,841 μs</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">1,104 μs</td><td align="right" bgcolor="#FFFFFF">0,972 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 170,256 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1065,325 ns</td><td align="right" bgcolor="#FFFFFF">1013,214 ns</td><td align="right" bgcolor="#FFFFFF">1144,493 ns</td><td align="right" bgcolor="#FFFFFF">1128,205 ns</td><td align="right" bgcolor="#FFFFFF">1183,470 ns</td><td align="right" bgcolor="#FFFFFF">1131,893 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">1,144 μs</td><td align="right" bgcolor="#FFFFFF">1,128 μs</td><td align="right" bgcolor="#FFFFFF">1,183 μs</td><td align="right" bgcolor="#FFFFFF">1,132 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 142,449 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1175,173 ns</td><td align="right" bgcolor="#FFFFFF">1154,854 ns</td><td align="right" bgcolor="#FFFFFF">1263,778 ns</td><td align="right" bgcolor="#FFFFFF">1272,333 ns</td><td align="right" bgcolor="#FFFFFF">1276,647 ns</td><td align="right" bgcolor="#FFFFFF">1297,303 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,175 μs</td><td align="right" bgcolor="#FFFFFF">1,155 μs</td><td align="right" bgcolor="#FFFFFF">1,264 μs</td><td align="right" bgcolor="#FFFFFF">1,272 μs</td><td align="right" bgcolor="#FFFFFF">1,277 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 240,936 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1325,814 ns</td><td align="right" bgcolor="#FFFFFF">1359,818 ns</td><td align="right" bgcolor="#FFFFFF">1566,750 ns</td><td align="right" bgcolor="#FFFFFF">1522,767 ns</td><td align="right" bgcolor="#FFFFFF">1539,415 ns</td><td align="right" bgcolor="#FFFFFF">1527,505 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,326 μs</td><td align="right" bgcolor="#FFFFFF">1,360 μs</td><td align="right" bgcolor="#FFFFFF">1,567 μs</td><td align="right" bgcolor="#FFFFFF">1,523 μs</td><td align="right" bgcolor="#FFFFFF">1,539 μs</td><td align="right" bgcolor="#FFFFFF">1,528 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 376,554 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1458,846 ns</td><td align="right" bgcolor="#FFFFFF">1516,932 ns</td><td align="right" bgcolor="#FFFFFF">1698,594 ns</td><td align="right" bgcolor="#FFFFFF">1781,323 ns</td><td align="right" bgcolor="#FFFFFF">1686,262 ns</td><td align="right" bgcolor="#FFFFFF">1835,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,459 μs</td><td align="right" bgcolor="#FFFFFF">1,517 μs</td><td align="right" bgcolor="#FFFFFF">1,699 μs</td><td align="right" bgcolor="#FFFFFF">1,781 μs</td><td align="right" bgcolor="#FFFFFF">1,686 μs</td><td align="right" bgcolor="#FFFFFF">1,835 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 4,709 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,155 ns</td><td align="right" bgcolor="#FFFFFF">5,404 ns</td><td align="right" bgcolor="#FFFFFF">0,814 ns</td><td align="right" bgcolor="#FFFFFF">0,950 ns</td><td align="right" bgcolor="#FFFFFF">0,859 ns</td><td align="right" bgcolor="#FFFFFF">0,695 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 8,578 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,442 ns</td><td align="right" bgcolor="#FFFFFF">21,193 ns</td><td align="right" bgcolor="#FFFFFF">12,738 ns</td><td align="right" bgcolor="#FFFFFF">13,635 ns</td><td align="right" bgcolor="#FFFFFF">14,517 ns</td><td align="right" bgcolor="#FFFFFF">12,615 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 6,507 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,418 ns</td><td align="right" bgcolor="#FFFFFF">16,268 ns</td><td align="right" bgcolor="#FFFFFF">10,290 ns</td><td align="right" bgcolor="#FFFFFF">9,952 ns</td><td align="right" bgcolor="#FFFFFF">10,051 ns</td><td align="right" bgcolor="#FFFFFF">9,762 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 97,689 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">279,812 ns</td><td align="right" bgcolor="#FFFFFF">276,073 ns</td><td align="right" bgcolor="#FFFFFF">367,376 ns</td><td align="right" bgcolor="#FFFFFF">368,966 ns</td><td align="right" bgcolor="#FFFFFF">356,549 ns</td><td align="right" bgcolor="#FFFFFF">373,762 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,276 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td><td align="right" bgcolor="#FFFFFF">0,369 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs</td><td align="right" bgcolor="#FFFFFF">0,374 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#A8D08D">-37,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 127,324 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">615,019 ns</td><td align="right" bgcolor="#FFFFFF">626,013 ns</td><td align="right" bgcolor="#FFFFFF">702,739 ns</td><td align="right" bgcolor="#FFFFFF">701,498 ns</td><td align="right" bgcolor="#FFFFFF">742,343 ns</td><td align="right" bgcolor="#FFFFFF">695,917 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,701 μs</td><td align="right" bgcolor="#FFFFFF">0,742 μs</td><td align="right" bgcolor="#FFFFFF">0,696 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-32,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">385,000</td><td align="right" bgcolor="#A8D08D">352,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">238,000 (Δ = -114,000)</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,376</td><td align="right" bgcolor="#A8D08D">0,344 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,232 (Δ = -0,111)</td><td align="right" bgcolor="#FFFFFF">0,232</td><td align="right" bgcolor="#FFFFFF">0,232</td><td align="right" bgcolor="#FFFFFF">0,232</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 152,525 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">521,786 ns</td><td align="right" bgcolor="#FFFFFF">507,358 ns</td><td align="right" bgcolor="#FFFFFF">637,120 ns</td><td align="right" bgcolor="#FFFFFF">638,643 ns</td><td align="right" bgcolor="#FFFFFF">659,883 ns</td><td align="right" bgcolor="#FFFFFF">618,397 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td><td align="right" bgcolor="#FFFFFF">0,507 μs</td><td align="right" bgcolor="#FFFFFF">0,637 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,660 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#A8D08D">-26,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">377,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -90,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,368</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,088)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 165,555 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">615,050 ns</td><td align="right" bgcolor="#FFFFFF">557,726 ns</td><td align="right" bgcolor="#FFFFFF">667,785 ns</td><td align="right" bgcolor="#FFFFFF">723,281 ns</td><td align="right" bgcolor="#FFFFFF">652,599 ns</td><td align="right" bgcolor="#FFFFFF">654,387 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,558 μs</td><td align="right" bgcolor="#FFFFFF">0,668 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,653 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 181,073 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">751,075 ns</td><td align="right" bgcolor="#FFFFFF">697,482 ns</td><td align="right" bgcolor="#FFFFFF">847,607 ns</td><td align="right" bgcolor="#FFFFFF">805,342 ns</td><td align="right" bgcolor="#FFFFFF">827,582 ns</td><td align="right" bgcolor="#FFFFFF">878,555 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td><td align="right" bgcolor="#FFFFFF">0,697 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td><td align="right" bgcolor="#FFFFFF">0,828 μs</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 140,439 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">902,600 ns</td><td align="right" bgcolor="#FFFFFF">846,583 ns</td><td align="right" bgcolor="#FFFFFF">968,580 ns</td><td align="right" bgcolor="#FFFFFF">968,927 ns</td><td align="right" bgcolor="#FFFFFF">952,826 ns</td><td align="right" bgcolor="#FFFFFF">987,022 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,903 μs</td><td align="right" bgcolor="#FFFFFF">0,847 μs</td><td align="right" bgcolor="#FFFFFF">0,969 μs</td><td align="right" bgcolor="#FFFFFF">0,969 μs</td><td align="right" bgcolor="#FFFFFF">0,953 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 133,142 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1054,516 ns</td><td align="right" bgcolor="#FFFFFF">1013,358 ns</td><td align="right" bgcolor="#FFFFFF">1142,754 ns</td><td align="right" bgcolor="#FFFFFF">1136,953 ns</td><td align="right" bgcolor="#FFFFFF">1146,500 ns</td><td align="right" bgcolor="#FFFFFF">1143,382 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td><td align="right" bgcolor="#FFFFFF">1,137 μs</td><td align="right" bgcolor="#FFFFFF">1,146 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 121,268 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1203,164 ns</td><td align="right" bgcolor="#FFFFFF">1159,119 ns</td><td align="right" bgcolor="#FFFFFF">1280,388 ns</td><td align="right" bgcolor="#FFFFFF">1252,503 ns</td><td align="right" bgcolor="#FFFFFF">1273,317 ns</td><td align="right" bgcolor="#FFFFFF">1277,922 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,203 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td><td align="right" bgcolor="#FFFFFF">1,280 μs</td><td align="right" bgcolor="#FFFFFF">1,253 μs</td><td align="right" bgcolor="#FFFFFF">1,273 μs</td><td align="right" bgcolor="#FFFFFF">1,278 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 258,673 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1310,432 ns</td><td align="right" bgcolor="#FFFFFF">1382,683 ns</td><td align="right" bgcolor="#FFFFFF">1503,444 ns</td><td align="right" bgcolor="#FFFFFF">1534,813 ns</td><td align="right" bgcolor="#FFFFFF">1569,105 ns</td><td align="right" bgcolor="#FFFFFF">1542,110 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,310 μs</td><td align="right" bgcolor="#FFFFFF">1,383 μs</td><td align="right" bgcolor="#FFFFFF">1,503 μs</td><td align="right" bgcolor="#FFFFFF">1,535 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td><td align="right" bgcolor="#FFFFFF">1,542 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 306,671 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1449,583 ns</td><td align="right" bgcolor="#FFFFFF">1500,776 ns</td><td align="right" bgcolor="#FF4949">1756,254 ns (Δ = +255,479 ns)</td><td align="right" bgcolor="#FFFFFF">1685,587 ns</td><td align="right" bgcolor="#FFFFFF">1696,941 ns</td><td align="right" bgcolor="#FFFFFF">1686,503 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,450 μs</td><td align="right" bgcolor="#FFFFFF">1,501 μs</td><td align="right" bgcolor="#FFFFFF">1,756 μs</td><td align="right" bgcolor="#FFFFFF">1,686 μs</td><td align="right" bgcolor="#FFFFFF">1,697 μs</td><td align="right" bgcolor="#FFFFFF">1,687 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 140,018 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">621,357 ns</td><td align="right" bgcolor="#FFFFFF">596,758 ns</td><td align="right" bgcolor="#FFFFFF">699,729 ns</td><td align="right" bgcolor="#FFFFFF">704,478 ns</td><td align="right" bgcolor="#FFFFFF">736,776 ns</td><td align="right" bgcolor="#FFFFFF">720,015 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,621 μs</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,737 μs</td><td align="right" bgcolor="#FFFFFF">0,720 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 140,832 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">766,313 ns</td><td align="right" bgcolor="#FFFFFF">735,325 ns</td><td align="right" bgcolor="#FFFFFF">868,139 ns</td><td align="right" bgcolor="#FFFFFF">869,107 ns</td><td align="right" bgcolor="#FFFFFF">876,157 ns</td><td align="right" bgcolor="#FFFFFF">869,095 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,766 μs</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,868 μs</td><td align="right" bgcolor="#FFFFFF">0,869 μs</td><td align="right" bgcolor="#FFFFFF">0,876 μs</td><td align="right" bgcolor="#FFFFFF">0,869 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">274,000 (Δ = -144,000)</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FFFFFF">274,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,268 (Δ = -0,141)</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FFFFFF">0,268</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 188,764 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">906,602 ns</td><td align="right" bgcolor="#FFFFFF">879,033 ns</td><td align="right" bgcolor="#FFFFFF">1024,787 ns</td><td align="right" bgcolor="#FFFFFF">1067,796 ns</td><td align="right" bgcolor="#FFFFFF">1004,895 ns</td><td align="right" bgcolor="#FFFFFF">1037,912 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,907 μs</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td><td align="right" bgcolor="#FFFFFF">1,025 μs</td><td align="right" bgcolor="#FFFFFF">1,068 μs</td><td align="right" bgcolor="#FFFFFF">1,005 μs</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-35,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">500,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">324,000 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,488 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,316 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 127,043 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1032,608 ns</td><td align="right" bgcolor="#FFFFFF">1035,163 ns</td><td align="right" bgcolor="#FFFFFF">1159,651 ns</td><td align="right" bgcolor="#FFFFFF">1124,016 ns</td><td align="right" bgcolor="#FFFFFF">1125,500 ns</td><td align="right" bgcolor="#FFFFFF">1156,872 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,033 μs</td><td align="right" bgcolor="#FFFFFF">1,035 μs</td><td align="right" bgcolor="#FFFFFF">1,160 μs</td><td align="right" bgcolor="#FFFFFF">1,124 μs</td><td align="right" bgcolor="#FFFFFF">1,126 μs</td><td align="right" bgcolor="#FFFFFF">1,157 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 153,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1161,526 ns</td><td align="right" bgcolor="#FFFFFF">1224,396 ns</td><td align="right" bgcolor="#FFFFFF">1315,098 ns</td><td align="right" bgcolor="#FFFFFF">1275,427 ns</td><td align="right" bgcolor="#FFFFFF">1273,661 ns</td><td align="right" bgcolor="#FFFFFF">1294,703 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,162 μs</td><td align="right" bgcolor="#FFFFFF">1,224 μs</td><td align="right" bgcolor="#FFFFFF">1,315 μs</td><td align="right" bgcolor="#FFFFFF">1,275 μs</td><td align="right" bgcolor="#FFFFFF">1,274 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 156,207 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1298,373 ns</td><td align="right" bgcolor="#FFFFFF">1329,834 ns</td><td align="right" bgcolor="#FFFFFF">1428,204 ns</td><td align="right" bgcolor="#FFFFFF">1417,775 ns</td><td align="right" bgcolor="#FFFFFF">1411,278 ns</td><td align="right" bgcolor="#FFFFFF">1454,580 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,298 μs</td><td align="right" bgcolor="#FFFFFF">1,330 μs</td><td align="right" bgcolor="#FFFFFF">1,428 μs</td><td align="right" bgcolor="#FFFFFF">1,418 μs</td><td align="right" bgcolor="#FFFFFF">1,411 μs</td><td align="right" bgcolor="#FFFFFF">1,455 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">737,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -270,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,720 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,264)</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 194,660 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1438,449 ns</td><td align="right" bgcolor="#FFFFFF">1417,868 ns</td><td align="right" bgcolor="#FFFFFF">1612,528 ns</td><td align="right" bgcolor="#FFFFFF">1578,305 ns</td><td align="right" bgcolor="#FFFFFF">1590,352 ns</td><td align="right" bgcolor="#FFFFFF">1542,742 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,438 μs</td><td align="right" bgcolor="#FFFFFF">1,418 μs</td><td align="right" bgcolor="#FFFFFF">1,613 μs</td><td align="right" bgcolor="#FFFFFF">1,578 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,543 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">819,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -303,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,800 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,296)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 129,016 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">613,772 ns</td><td align="right" bgcolor="#FFFFFF">561,533 ns</td><td align="right" bgcolor="#FFFFFF">678,801 ns</td><td align="right" bgcolor="#FFFFFF">669,770 ns</td><td align="right" bgcolor="#FFFFFF">683,960 ns</td><td align="right" bgcolor="#FFFFFF">690,548 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,614 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,679 μs</td><td align="right" bgcolor="#FFFFFF">0,670 μs</td><td align="right" bgcolor="#FFFFFF">0,684 μs</td><td align="right" bgcolor="#FFFFFF">0,691 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 156,927 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">756,430 ns</td><td align="right" bgcolor="#FFFFFF">699,891 ns</td><td align="right" bgcolor="#FFFFFF">827,731 ns</td><td align="right" bgcolor="#FFFFFF">823,823 ns</td><td align="right" bgcolor="#FFFFFF">856,818 ns</td><td align="right" bgcolor="#FFFFFF">837,935 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,828 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">0,857 μs</td><td align="right" bgcolor="#FFFFFF">0,838 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 152,109 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">971,354 ns</td><td align="right" bgcolor="#FFFFFF">834,615 ns</td><td align="right" bgcolor="#FFFFFF">986,724 ns</td><td align="right" bgcolor="#FFFFFF">969,758 ns</td><td align="right" bgcolor="#FFFFFF">972,528 ns</td><td align="right" bgcolor="#FFFFFF">985,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">0,835 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 169,807 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1044,197 ns</td><td align="right" bgcolor="#FFFFFF">1013,578 ns</td><td align="right" bgcolor="#FFFFFF">1157,417 ns</td><td align="right" bgcolor="#FFFFFF">1139,888 ns</td><td align="right" bgcolor="#FFFFFF">1113,731 ns</td><td align="right" bgcolor="#FFFFFF">1183,385 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,014 μs</td><td align="right" bgcolor="#FFFFFF">1,157 μs</td><td align="right" bgcolor="#FFFFFF">1,140 μs</td><td align="right" bgcolor="#FFFFFF">1,114 μs</td><td align="right" bgcolor="#FFFFFF">1,183 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 121,946 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1182,950 ns</td><td align="right" bgcolor="#FFFFFF">1165,351 ns</td><td align="right" bgcolor="#FFFFFF">1285,501 ns</td><td align="right" bgcolor="#FFFFFF">1259,348 ns</td><td align="right" bgcolor="#FFFFFF">1277,973 ns</td><td align="right" bgcolor="#FFFFFF">1287,297 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,183 μs</td><td align="right" bgcolor="#FFFFFF">1,165 μs</td><td align="right" bgcolor="#FFFFFF">1,286 μs</td><td align="right" bgcolor="#FFFFFF">1,259 μs</td><td align="right" bgcolor="#FFFFFF">1,278 μs</td><td align="right" bgcolor="#FFFFFF">1,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 329,768 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1321,749 ns</td><td align="right" bgcolor="#FFFFFF">1375,086 ns</td><td align="right" bgcolor="#FFFFFF">1538,487 ns</td><td align="right" bgcolor="#FFFFFF">1550,509 ns</td><td align="right" bgcolor="#FFFFFF">1523,671 ns</td><td align="right" bgcolor="#FFFFFF">1651,517 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,322 μs</td><td align="right" bgcolor="#FFFFFF">1,375 μs</td><td align="right" bgcolor="#FFFFFF">1,538 μs</td><td align="right" bgcolor="#FFFFFF">1,551 μs</td><td align="right" bgcolor="#FFFFFF">1,524 μs</td><td align="right" bgcolor="#FFFFFF">1,652 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 278,057 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1423,502 ns</td><td align="right" bgcolor="#FFFFFF">1530,075 ns</td><td align="right" bgcolor="#FFFFFF">1667,641 ns</td><td align="right" bgcolor="#FFFFFF">1656,196 ns</td><td align="right" bgcolor="#FFFFFF">1701,558 ns</td><td align="right" bgcolor="#FFFFFF">1695,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,424 μs</td><td align="right" bgcolor="#FFFFFF">1,530 μs</td><td align="right" bgcolor="#FFFFFF">1,668 μs</td><td align="right" bgcolor="#FFFFFF">1,656 μs</td><td align="right" bgcolor="#FFFFFF">1,702 μs</td><td align="right" bgcolor="#FFFFFF">1,695 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 130,723 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">612,095 ns</td><td align="right" bgcolor="#FFFFFF">565,025 ns</td><td align="right" bgcolor="#FFFFFF">661,262 ns</td><td align="right" bgcolor="#FFFFFF">670,861 ns</td><td align="right" bgcolor="#FFFFFF">674,838 ns</td><td align="right" bgcolor="#FFFFFF">695,748 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,612 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,661 μs</td><td align="right" bgcolor="#FFFFFF">0,671 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,696 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 175,471 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">735,357 ns</td><td align="right" bgcolor="#FFFFFF">693,418 ns</td><td align="right" bgcolor="#FFFFFF">868,889 ns</td><td align="right" bgcolor="#FFFFFF">831,552 ns</td><td align="right" bgcolor="#FFFFFF">835,460 ns</td><td align="right" bgcolor="#FFFFFF">825,297 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,869 μs</td><td align="right" bgcolor="#FFFFFF">0,832 μs</td><td align="right" bgcolor="#FFFFFF">0,835 μs</td><td align="right" bgcolor="#FFFFFF">0,825 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 150,998 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">893,062 ns</td><td align="right" bgcolor="#FFFFFF">832,509 ns</td><td align="right" bgcolor="#FFFFFF">979,628 ns</td><td align="right" bgcolor="#FFFFFF">983,508 ns</td><td align="right" bgcolor="#FFFFFF">977,543 ns</td><td align="right" bgcolor="#FFFFFF">974,370 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,893 μs</td><td align="right" bgcolor="#FFFFFF">0,833 μs</td><td align="right" bgcolor="#FFFFFF">0,980 μs</td><td align="right" bgcolor="#FFFFFF">0,984 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 135,143 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1025,097 ns</td><td align="right" bgcolor="#FFFFFF">1010,321 ns</td><td align="right" bgcolor="#FFFFFF">1145,464 ns</td><td align="right" bgcolor="#FFFFFF">1125,457 ns</td><td align="right" bgcolor="#FFFFFF">1131,783 ns</td><td align="right" bgcolor="#FFFFFF">1144,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,025 μs</td><td align="right" bgcolor="#FFFFFF">1,010 μs</td><td align="right" bgcolor="#FFFFFF">1,145 μs</td><td align="right" bgcolor="#FFFFFF">1,125 μs</td><td align="right" bgcolor="#FFFFFF">1,132 μs</td><td align="right" bgcolor="#FFFFFF">1,144 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 148,878 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1170,345 ns</td><td align="right" bgcolor="#FFFFFF">1159,067 ns</td><td align="right" bgcolor="#FFFFFF">1297,251 ns</td><td align="right" bgcolor="#FFFFFF">1295,301 ns</td><td align="right" bgcolor="#FFFFFF">1265,213 ns</td><td align="right" bgcolor="#FFFFFF">1307,945 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,170 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td><td align="right" bgcolor="#FFFFFF">1,265 μs</td><td align="right" bgcolor="#FFFFFF">1,308 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 195,396 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1336,232 ns</td><td align="right" bgcolor="#FFFFFF">1385,109 ns</td><td align="right" bgcolor="#FFFFFF">1531,628 ns</td><td align="right" bgcolor="#FFFFFF">1531,019 ns</td><td align="right" bgcolor="#FFFFFF">1517,278 ns</td><td align="right" bgcolor="#FFFFFF">1509,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,336 μs</td><td align="right" bgcolor="#FFFFFF">1,385 μs</td><td align="right" bgcolor="#FFFFFF">1,532 μs</td><td align="right" bgcolor="#FFFFFF">1,531 μs</td><td align="right" bgcolor="#FFFFFF">1,517 μs</td><td align="right" bgcolor="#FFFFFF">1,509 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 233,371 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1453,406 ns</td><td align="right" bgcolor="#FFFFFF">1481,753 ns</td><td align="right" bgcolor="#FFFFFF">1661,844 ns</td><td align="right" bgcolor="#FFFFFF">1683,734 ns</td><td align="right" bgcolor="#FFFFFF">1654,286 ns</td><td align="right" bgcolor="#FFFFFF">1686,777 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,453 μs</td><td align="right" bgcolor="#FFFFFF">1,482 μs</td><td align="right" bgcolor="#FFFFFF">1,662 μs</td><td align="right" bgcolor="#FFFFFF">1,684 μs</td><td align="right" bgcolor="#FFFFFF">1,654 μs</td><td align="right" bgcolor="#FFFFFF">1,687 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 38,673 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">312,594 ns</td><td align="right" bgcolor="#FFFFFF">273,922 ns</td><td align="right" bgcolor="#FFFFFF">280,367 ns</td><td align="right" bgcolor="#FFFFFF">284,165 ns</td><td align="right" bgcolor="#FFFFFF">282,273 ns</td><td align="right" bgcolor="#FFFFFF">279,472 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,284 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 117,098 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">419,691 ns</td><td align="right" bgcolor="#FFFFFF">302,593 ns</td><td align="right" bgcolor="#FFFFFF">346,155 ns</td><td align="right" bgcolor="#FFFFFF">318,241 ns</td><td align="right" bgcolor="#FFFFFF">318,840 ns</td><td align="right" bgcolor="#FFFFFF">322,475 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,420 μs</td><td align="right" bgcolor="#FFFFFF">0,303 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,318 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 573,258 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3897,613 ns</td><td align="right" bgcolor="#FFFFFF">3932,637 ns</td><td align="right" bgcolor="#FF4949">4470,872 ns (Δ = +538,235 ns)</td><td align="right" bgcolor="#FFFFFF">4330,517 ns</td><td align="right" bgcolor="#FFFFFF">4331,053 ns</td><td align="right" bgcolor="#FFFFFF">4359,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,898 μs</td><td align="right" bgcolor="#FFFFFF">3,933 μs</td><td align="right" bgcolor="#FFFFFF">4,471 μs</td><td align="right" bgcolor="#FFFFFF">4,331 μs</td><td align="right" bgcolor="#FFFFFF">4,331 μs</td><td align="right" bgcolor="#FFFFFF">4,360 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 607,445 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6776,753 ns</td><td align="right" bgcolor="#FFFFFF">6712,700 ns</td><td align="right" bgcolor="#FF4949">7264,441 ns (Δ = +551,741 ns)</td><td align="right" bgcolor="#FFFFFF">7320,145 ns</td><td align="right" bgcolor="#FFFFFF">7298,759 ns</td><td align="right" bgcolor="#FFFFFF">7283,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,777 μs</td><td align="right" bgcolor="#FFFFFF">6,713 μs</td><td align="right" bgcolor="#FFFFFF">7,264 μs</td><td align="right" bgcolor="#FFFFFF">7,320 μs</td><td align="right" bgcolor="#FFFFFF">7,299 μs</td><td align="right" bgcolor="#FFFFFF">7,283 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 764,986 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5242,308 ns</td><td align="right" bgcolor="#FFFFFF">5237,368 ns</td><td align="right" bgcolor="#FF4949">5779,228 ns (Δ = +541,860 ns)</td><td align="right" bgcolor="#FFFFFF">5738,813 ns</td><td align="right" bgcolor="#FFFFFF">5725,615 ns</td><td align="right" bgcolor="#FF4949">6002,353 ns (Δ = +276,738 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,242 μs</td><td align="right" bgcolor="#FFFFFF">5,237 μs</td><td align="right" bgcolor="#FFFFFF">5,779 μs</td><td align="right" bgcolor="#FFFFFF">5,739 μs</td><td align="right" bgcolor="#FFFFFF">5,726 μs</td><td align="right" bgcolor="#FFFFFF">6,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">348,000 (Δ = -328,000)</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,340 (Δ = -0,320)</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 517,099 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3901,555 ns</td><td align="right" bgcolor="#FFFFFF">3899,348 ns</td><td align="right" bgcolor="#FF4949">4416,447 ns (Δ = +517,099 ns)</td><td align="right" bgcolor="#FFFFFF">4343,131 ns</td><td align="right" bgcolor="#FFFFFF">4310,465 ns</td><td align="right" bgcolor="#FFFFFF">4329,087 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,902 μs</td><td align="right" bgcolor="#FFFFFF">3,899 μs</td><td align="right" bgcolor="#FFFFFF">4,416 μs</td><td align="right" bgcolor="#FFFFFF">4,343 μs</td><td align="right" bgcolor="#FFFFFF">4,310 μs</td><td align="right" bgcolor="#FFFFFF">4,329 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 542,571 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6821,773 ns</td><td align="right" bgcolor="#FFFFFF">6712,445 ns</td><td align="right" bgcolor="#FF4949">7255,016 ns (Δ = +542,571 ns)</td><td align="right" bgcolor="#FFFFFF">7246,091 ns</td><td align="right" bgcolor="#FFFFFF">7233,594 ns</td><td align="right" bgcolor="#FFFFFF">7203,667 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,822 μs</td><td align="right" bgcolor="#FFFFFF">6,712 μs</td><td align="right" bgcolor="#FFFFFF">7,255 μs</td><td align="right" bgcolor="#FFFFFF">7,246 μs</td><td align="right" bgcolor="#FFFFFF">7,234 μs</td><td align="right" bgcolor="#FFFFFF">7,204 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1023,900 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7916,164 ns</td><td align="right" bgcolor="#FFFFFF">7769,148 ns</td><td align="right" bgcolor="#FF4949">8666,827 ns (Δ = +897,679 ns)</td><td align="right" bgcolor="#FFFFFF">8518,777 ns</td><td align="right" bgcolor="#FFFFFF">8606,981 ns</td><td align="right" bgcolor="#FFFFFF">8793,048 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,916 μs</td><td align="right" bgcolor="#FFFFFF">7,769 μs</td><td align="right" bgcolor="#FFFFFF">8,667 μs</td><td align="right" bgcolor="#FFFFFF">8,519 μs</td><td align="right" bgcolor="#FFFFFF">8,607 μs</td><td align="right" bgcolor="#FFFFFF">8,793 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -525,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,513)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 786,492 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#FF4949">+15,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3470,297 ns</td><td align="right" bgcolor="#A8D08D">2683,805 ns (Δ = -786,492 ns)</td><td align="right" bgcolor="#FF4949">3088,139 ns (Δ = +404,334 ns)</td><td align="right" bgcolor="#FFFFFF">3106,223 ns</td><td align="right" bgcolor="#FFFFFF">3193,558 ns</td><td align="right" bgcolor="#FFFFFF">3072,865 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,470 μs</td><td align="right" bgcolor="#FFFFFF">2,684 μs</td><td align="right" bgcolor="#FFFFFF">3,088 μs</td><td align="right" bgcolor="#FFFFFF">3,106 μs</td><td align="right" bgcolor="#FFFFFF">3,194 μs</td><td align="right" bgcolor="#FFFFFF">3,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 774,147 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,4 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3449,343 ns</td><td align="right" bgcolor="#A8D08D">2675,196 ns (Δ = -774,147 ns)</td><td align="right" bgcolor="#FF4949">3083,522 ns (Δ = +408,326 ns)</td><td align="right" bgcolor="#FFFFFF">3103,311 ns</td><td align="right" bgcolor="#FFFFFF">3123,354 ns</td><td align="right" bgcolor="#FFFFFF">3186,970 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,449 μs</td><td align="right" bgcolor="#FFFFFF">2,675 μs</td><td align="right" bgcolor="#FFFFFF">3,084 μs</td><td align="right" bgcolor="#FFFFFF">3,103 μs</td><td align="right" bgcolor="#FFFFFF">3,123 μs</td><td align="right" bgcolor="#FFFFFF">3,187 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1672,467 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,1 %</td><td align="right" bgcolor="#FF4949">+16,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4384,041 ns</td><td align="right" bgcolor="#A8D08D">2711,573 ns (Δ = -1672,467 ns)</td><td align="right" bgcolor="#FF4949">3166,880 ns (Δ = +455,307 ns)</td><td align="right" bgcolor="#FFFFFF">3158,822 ns</td><td align="right" bgcolor="#FFFFFF">3191,861 ns</td><td align="right" bgcolor="#FFFFFF">3164,815 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,384 μs</td><td align="right" bgcolor="#FFFFFF">2,712 μs</td><td align="right" bgcolor="#FFFFFF">3,167 μs</td><td align="right" bgcolor="#FFFFFF">3,159 μs</td><td align="right" bgcolor="#FFFFFF">3,192 μs</td><td align="right" bgcolor="#FFFFFF">3,165 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,3 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1888,000</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -893,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -430,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,844</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,872)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,420)</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 38,564 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,584 ns</td><td align="right" bgcolor="#FFFFFF">142,190 ns</td><td align="right" bgcolor="#FFFFFF">165,148 ns</td><td align="right" bgcolor="#FFFFFF">146,763 ns</td><td align="right" bgcolor="#FFFFFF">158,523 ns</td><td align="right" bgcolor="#FFFFFF">145,537 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 19,166 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,051 ns</td><td align="right" bgcolor="#FFFFFF">140,977 ns</td><td align="right" bgcolor="#FFFFFF">143,792 ns</td><td align="right" bgcolor="#FFFFFF">145,634 ns</td><td align="right" bgcolor="#FFFFFF">145,433 ns</td><td align="right" bgcolor="#FFFFFF">146,217 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 22,876 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">119,159 ns</td><td align="right" bgcolor="#FFFFFF">137,367 ns</td><td align="right" bgcolor="#FFFFFF">136,716 ns</td><td align="right" bgcolor="#FFFFFF">139,598 ns</td><td align="right" bgcolor="#FFFFFF">138,082 ns</td><td align="right" bgcolor="#FFFFFF">142,035 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1420,096 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-76,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1851,774 ns</td><td align="right" bgcolor="#A8D08D">431,678 ns (Δ = -1420,096 ns)</td><td align="right" bgcolor="#FFFFFF">458,786 ns</td><td align="right" bgcolor="#FFFFFF">496,362 ns</td><td align="right" bgcolor="#FFFFFF">455,934 ns</td><td align="right" bgcolor="#FFFFFF">455,567 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,852 μs</td><td align="right" bgcolor="#FFFFFF">0,432 μs</td><td align="right" bgcolor="#FFFFFF">0,459 μs</td><td align="right" bgcolor="#FFFFFF">0,496 μs</td><td align="right" bgcolor="#FFFFFF">0,456 μs</td><td align="right" bgcolor="#FFFFFF">0,456 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1398,156 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1858,887 ns</td><td align="right" bgcolor="#A8D08D">460,731 ns (Δ = -1398,156 ns)</td><td align="right" bgcolor="#FFFFFF">486,697 ns</td><td align="right" bgcolor="#FFFFFF">536,181 ns</td><td align="right" bgcolor="#FFFFFF">489,937 ns</td><td align="right" bgcolor="#FFFFFF">486,828 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,859 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,490 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1347,051 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-79,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1690,373 ns</td><td align="right" bgcolor="#A8D08D">343,323 ns (Δ = -1347,051 ns)</td><td align="right" bgcolor="#FFFFFF">348,038 ns</td><td align="right" bgcolor="#FFFFFF">347,686 ns</td><td align="right" bgcolor="#FFFFFF">353,273 ns</td><td align="right" bgcolor="#FFFFFF">349,522 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,690 μs</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td><td align="right" bgcolor="#FFFFFF">0,353 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-90,5 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1,804 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,224 ns</td><td align="right" bgcolor="#FFFFFF">2,213 ns</td><td align="right" bgcolor="#FFFFFF">3,153 ns</td><td align="right" bgcolor="#FFFFFF">3,453 ns</td><td align="right" bgcolor="#FFFFFF">3,526 ns</td><td align="right" bgcolor="#FFFFFF">4,017 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,185 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,236 ns</td><td align="right" bgcolor="#FFFFFF">2,170 ns</td><td align="right" bgcolor="#FFFFFF">2,240 ns</td><td align="right" bgcolor="#FFFFFF">2,355 ns</td><td align="right" bgcolor="#FFFFFF">2,355 ns</td><td align="right" bgcolor="#FFFFFF">2,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 5,009 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,268 ns</td><td align="right" bgcolor="#FFFFFF">7,982 ns</td><td align="right" bgcolor="#FFFFFF">12,352 ns</td><td align="right" bgcolor="#FFFFFF">12,727 ns</td><td align="right" bgcolor="#FFFFFF">12,991 ns</td><td align="right" bgcolor="#FFFFFF">12,732 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1,367 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,544 ns</td><td align="right" bgcolor="#FFFFFF">2,258 ns</td><td align="right" bgcolor="#FFFFFF">2,543 ns</td><td align="right" bgcolor="#FFFFFF">2,668 ns</td><td align="right" bgcolor="#FFFFFF">2,749 ns</td><td align="right" bgcolor="#FFFFFF">3,625 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 3,039 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,598 ns</td><td align="right" bgcolor="#FFFFFF">8,480 ns</td><td align="right" bgcolor="#FFFFFF">11,388 ns</td><td align="right" bgcolor="#FFFFFF">10,958 ns</td><td align="right" bgcolor="#FFFFFF">11,519 ns</td><td align="right" bgcolor="#FFFFFF">10,905 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 20,692 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,840 ns</td><td align="right" bgcolor="#FFFFFF">2,148 ns</td><td align="right" bgcolor="#FFFFFF">2,702 ns</td><td align="right" bgcolor="#FFFFFF">2,610 ns</td><td align="right" bgcolor="#FFFFFF">2,779 ns</td><td align="right" bgcolor="#FFFFFF">2,530 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 10,232 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,610 ns</td><td align="right" bgcolor="#FFFFFF">51,302 ns</td><td align="right" bgcolor="#FFFFFF">58,163 ns</td><td align="right" bgcolor="#FFFFFF">58,184 ns</td><td align="right" bgcolor="#FFFFFF">58,003 ns</td><td align="right" bgcolor="#FFFFFF">58,842 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 0,729 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,545 ns</td><td align="right" bgcolor="#FFFFFF">2,513 ns</td><td align="right" bgcolor="#FFFFFF">3,083 ns</td><td align="right" bgcolor="#FFFFFF">3,182 ns</td><td align="right" bgcolor="#FFFFFF">3,240 ns</td><td align="right" bgcolor="#FFFFFF">3,242 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1,903 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,443 ns</td><td align="right" bgcolor="#FFFFFF">2,451 ns</td><td align="right" bgcolor="#FFFFFF">4,346 ns</td><td align="right" bgcolor="#FFFFFF">3,876 ns</td><td align="right" bgcolor="#FFFFFF">3,878 ns</td><td align="right" bgcolor="#FFFFFF">3,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 15,520 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,774 ns</td><td align="right" bgcolor="#FFFFFF">77,344 ns</td><td align="right" bgcolor="#FFFFFF">92,514 ns</td><td align="right" bgcolor="#FFFFFF">92,820 ns</td><td align="right" bgcolor="#FFFFFF">92,864 ns</td><td align="right" bgcolor="#FFFFFF">91,975 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 0,056 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,052 ns</td><td align="right" bgcolor="#FFFFFF">0,038 ns</td><td align="right" bgcolor="#FFFFFF">0,021 ns</td><td align="right" bgcolor="#FFFFFF">0,022 ns</td><td align="right" bgcolor="#FFFFFF">0,061 ns</td><td align="right" bgcolor="#FFFFFF">0,077 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 24,197 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,178 ns</td><td align="right" bgcolor="#FFFFFF">98,043 ns</td><td align="right" bgcolor="#FFFFFF">121,375 ns</td><td align="right" bgcolor="#FFFFFF">121,298 ns</td><td align="right" bgcolor="#FFFFFF">117,635 ns</td><td align="right" bgcolor="#FFFFFF">118,563 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 336,297 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3305,692 ns</td><td align="right" bgcolor="#FFFFFF">3418,118 ns</td><td align="right" bgcolor="#A8D08D">3162,460 ns (Δ = -255,658 ns)</td><td align="right" bgcolor="#FFFFFF">3355,304 ns</td><td align="right" bgcolor="#A8D08D">3081,821 ns (Δ = -273,483 ns)</td><td align="right" bgcolor="#FFFFFF">3314,133 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,306 μs</td><td align="right" bgcolor="#FFFFFF">3,418 μs</td><td align="right" bgcolor="#FFFFFF">3,162 μs</td><td align="right" bgcolor="#FFFFFF">3,355 μs</td><td align="right" bgcolor="#FFFFFF">3,082 μs</td><td align="right" bgcolor="#FFFFFF">3,314 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-48,0 %</td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1739,000</td><td align="right" bgcolor="#FF4949">1741,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">905,000 (Δ = -836,000)</td><td align="right" bgcolor="#A8D08D">889,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">889,000</td><td align="right" bgcolor="#FFFFFF">889,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,698</td><td align="right" bgcolor="#FF4949">1,700 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">0,884 (Δ = -0,816)</td><td align="right" bgcolor="#A8D08D">0,868 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">0,868</td><td align="right" bgcolor="#FFFFFF">0,868</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,106 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,734 ns</td><td align="right" bgcolor="#FFFFFF">24,795 ns</td><td align="right" bgcolor="#FFFFFF">25,547 ns</td><td align="right" bgcolor="#FFFFFF">25,840 ns</td><td align="right" bgcolor="#FFFFFF">24,933 ns</td><td align="right" bgcolor="#FFFFFF">23,963 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 1105795,932 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,5 %</td><td align="right" bgcolor="#A8D08D">-27,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3132477,096 ns</td><td align="right" bgcolor="#FF4949">4025089,865 ns (Δ = +892612,769 ns)</td><td align="right" bgcolor="#A8D08D">2939180,783 ns (Δ = -1085909,083 ns)</td><td align="right" bgcolor="#FFFFFF">2919293,933 ns</td><td align="right" bgcolor="#FFFFFF">2933670,209 ns</td><td align="right" bgcolor="#FFFFFF">2939130,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3132,477 μs</td><td align="right" bgcolor="#FF4949">4025,090 μs (Δ = +892,613 μs)</td><td align="right" bgcolor="#A8D08D">2939,181 μs (Δ = -1085,909 μs)</td><td align="right" bgcolor="#FFFFFF">2919,294 μs</td><td align="right" bgcolor="#FFFFFF">2933,670 μs</td><td align="right" bgcolor="#FFFFFF">2939,130 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,132 ms</td><td align="right" bgcolor="#FFFFFF">4,025 ms</td><td align="right" bgcolor="#FFFFFF">2,939 ms</td><td align="right" bgcolor="#FFFFFF">2,919 ms</td><td align="right" bgcolor="#FFFFFF">2,934 ms</td><td align="right" bgcolor="#FFFFFF">2,939 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">55,000</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">52,500 (Δ = +0,500)</td><td align="right" bgcolor="#FFFFFF">52,500</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">53,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">7,500 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">52,500 (Δ = +45,000)</td><td align="right" bgcolor="#FFFFFF">52,500</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">53,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#A8D08D">-17,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175319,500</td><td align="right" bgcolor="#A8D08D">167334,500 (Δ = -7985,000)</td><td align="right" bgcolor="#A8D08D">138891,500 (Δ = -28443,000)</td><td align="right" bgcolor="#A8D08D">138872,000 (Δ = -19,500)</td><td align="right" bgcolor="#A8D08D">138744,500 (Δ = -127,500)</td><td align="right" bgcolor="#FF4949">138998,000 (Δ = +253,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">171,210</td><td align="right" bgcolor="#A8D08D">163,413 (Δ = -7,798)</td><td align="right" bgcolor="#A8D08D">135,636 (Δ = -27,776)</td><td align="right" bgcolor="#A8D08D">135,617 (Δ = -0,019)</td><td align="right" bgcolor="#A8D08D">135,493 (Δ = -0,125)</td><td align="right" bgcolor="#FF4949">135,740 (Δ = +0,248)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,167</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,133 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 92133,163 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,8 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#A8D08D">-2,2 %</td><td align="right" bgcolor="#A8D08D">-2,1 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">655216,671 ns</td><td align="right" bgcolor="#FF4949">713076,093 ns (Δ = +57859,423 ns)</td><td align="right" bgcolor="#A8D08D">665957,220 ns (Δ = -47118,873 ns)</td><td align="right" bgcolor="#A8D08D">651398,794 ns (Δ = -14558,426 ns)</td><td align="right" bgcolor="#A8D08D">637578,763 ns (Δ = -13820,031 ns)</td><td align="right" bgcolor="#A8D08D">620942,930 ns (Δ = -16635,833 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">655,217 μs</td><td align="right" bgcolor="#FFFFFF">713,076 μs</td><td align="right" bgcolor="#FFFFFF">665,957 μs</td><td align="right" bgcolor="#FFFFFF">651,399 μs</td><td align="right" bgcolor="#FFFFFF">637,579 μs</td><td align="right" bgcolor="#FFFFFF">620,943 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,655 ms</td><td align="right" bgcolor="#FFFFFF">0,713 ms</td><td align="right" bgcolor="#FFFFFF">0,666 ms</td><td align="right" bgcolor="#FFFFFF">0,651 ms</td><td align="right" bgcolor="#FFFFFF">0,638 ms</td><td align="right" bgcolor="#FFFFFF">0,621 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +5,000)</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +30,000)</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">92150,500</td><td align="right" bgcolor="#A8D08D">91073,000 (Δ = -1077,500)</td><td align="right" bgcolor="#A8D08D">87373,000 (Δ = -3700,000)</td><td align="right" bgcolor="#A8D08D">87280,000 (Δ = -93,000)</td><td align="right" bgcolor="#FF4949">87340,000 (Δ = +60,000)</td><td align="right" bgcolor="#A8D08D">87253,000 (Δ = -87,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,991</td><td align="right" bgcolor="#A8D08D">88,938 (Δ = -1,052)</td><td align="right" bgcolor="#A8D08D">85,325 (Δ = -3,613)</td><td align="right" bgcolor="#A8D08D">85,234 (Δ = -0,091)</td><td align="right" bgcolor="#FF4949">85,293 (Δ = +0,059)</td><td align="right" bgcolor="#A8D08D">85,208 (Δ = -0,085)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,083 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = 0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 194375,920 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,4 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,2 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">877660,869 ns</td><td align="right" bgcolor="#FF4949">1038735,274 ns (Δ = +161074,405 ns)</td><td align="right" bgcolor="#A8D08D">848957,623 ns (Δ = -189777,652 ns)</td><td align="right" bgcolor="#FFFFFF">844359,354 ns</td><td align="right" bgcolor="#FF4949">862735,304 ns (Δ = +18375,950 ns)</td><td align="right" bgcolor="#A8D08D">850940,507 ns (Δ = -11794,797 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">877,661 μs</td><td align="right" bgcolor="#FFFFFF">1038,735 μs</td><td align="right" bgcolor="#FFFFFF">848,958 μs</td><td align="right" bgcolor="#FFFFFF">844,359 μs</td><td align="right" bgcolor="#FFFFFF">862,735 μs</td><td align="right" bgcolor="#FFFFFF">850,941 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,878 ms</td><td align="right" bgcolor="#FFFFFF">1,039 ms</td><td align="right" bgcolor="#FFFFFF">0,849 ms</td><td align="right" bgcolor="#FFFFFF">0,844 ms</td><td align="right" bgcolor="#FFFFFF">0,863 ms</td><td align="right" bgcolor="#FFFFFF">0,851 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#FFFFFF">34,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">99031,000</td><td align="right" bgcolor="#A8D08D">97353,500 (Δ = -1677,500)</td><td align="right" bgcolor="#A8D08D">90782,000 (Δ = -6571,500)</td><td align="right" bgcolor="#FF4949">90794,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">90756,000 (Δ = -38,000)</td><td align="right" bgcolor="#FF4949">90798,000 (Δ = +42,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">96,710</td><td align="right" bgcolor="#A8D08D">95,072 (Δ = -1,638)</td><td align="right" bgcolor="#A8D08D">88,654 (Δ = -6,417)</td><td align="right" bgcolor="#FF4949">88,666 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">88,629 (Δ = -0,037)</td><td align="right" bgcolor="#FF4949">88,670 (Δ = +0,041)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,006)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td></tr></table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,186 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">77,117 ns</td><td align="right" bgcolor="#FFFFFF">76,978 ns</td><td align="right" bgcolor="#FFFFFF">77,797 ns</td><td align="right" bgcolor="#FFFFFF">79,164 ns</td><td align="right" bgcolor="#FFFFFF">78,741 ns</td><td align="right" bgcolor="#FFFFFF">78,547 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 2,653 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">76,498 ns</td><td align="right" bgcolor="#FFFFFF">77,093 ns</td><td align="right" bgcolor="#FFFFFF">77,543 ns</td><td align="right" bgcolor="#FFFFFF">78,188 ns</td><td align="right" bgcolor="#FFFFFF">78,405 ns</td><td align="right" bgcolor="#FFFFFF">79,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 8,637 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">86,462 ns</td><td align="right" bgcolor="#FFFFFF">81,585 ns</td><td align="right" bgcolor="#FFFFFF">86,954 ns</td><td align="right" bgcolor="#FFFFFF">87,775 ns</td><td align="right" bgcolor="#FFFFFF">86,265 ns</td><td align="right" bgcolor="#FFFFFF">90,222 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 45,800 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">164,582 ns</td><td align="right" bgcolor="#FFFFFF">118,782 ns</td><td align="right" bgcolor="#FFFFFF">128,480 ns</td><td align="right" bgcolor="#FFFFFF">127,353 ns</td><td align="right" bgcolor="#FFFFFF">127,600 ns</td><td align="right" bgcolor="#FFFFFF">125,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 48,635 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,765 ns</td><td align="right" bgcolor="#FFFFFF">114,130 ns</td><td align="right" bgcolor="#FFFFFF">128,438 ns</td><td align="right" bgcolor="#FFFFFF">127,440 ns</td><td align="right" bgcolor="#FFFFFF">128,087 ns</td><td align="right" bgcolor="#FFFFFF">127,068 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 18,220 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">73,466 ns</td><td align="right" bgcolor="#FFFFFF">74,083 ns</td><td align="right" bgcolor="#FFFFFF">91,686 ns</td><td align="right" bgcolor="#FFFFFF">84,033 ns</td><td align="right" bgcolor="#FFFFFF">83,531 ns</td><td align="right" bgcolor="#FFFFFF">83,427 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 210,879 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3829,307 ns</td><td align="right" bgcolor="#FFFFFF">3795,230 ns</td><td align="right" bgcolor="#FFFFFF">4006,109 ns</td><td align="right" bgcolor="#FFFFFF">3953,489 ns</td><td align="right" bgcolor="#FFFFFF">3916,545 ns</td><td align="right" bgcolor="#FFFFFF">3932,410 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,829 μs</td><td align="right" bgcolor="#FFFFFF">3,795 μs</td><td align="right" bgcolor="#FFFFFF">4,006 μs</td><td align="right" bgcolor="#FFFFFF">3,953 μs</td><td align="right" bgcolor="#FFFFFF">3,917 μs</td><td align="right" bgcolor="#FFFFFF">3,932 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 111,620 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">869,688 ns</td><td align="right" bgcolor="#FFFFFF">862,028 ns</td><td align="right" bgcolor="#FFFFFF">966,046 ns</td><td align="right" bgcolor="#FFFFFF">973,648 ns</td><td align="right" bgcolor="#FFFFFF">957,562 ns</td><td align="right" bgcolor="#FFFFFF">941,603 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,966 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td><td align="right" bgcolor="#FFFFFF">0,958 μs</td><td align="right" bgcolor="#FFFFFF">0,942 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 304,115 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4708,073 ns</td><td align="right" bgcolor="#FFFFFF">4751,800 ns</td><td align="right" bgcolor="#FFFFFF">4959,132 ns</td><td align="right" bgcolor="#FFFFFF">4928,713 ns</td><td align="right" bgcolor="#FFFFFF">4907,717 ns</td><td align="right" bgcolor="#FFFFFF">5012,188 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,708 μs</td><td align="right" bgcolor="#FFFFFF">4,752 μs</td><td align="right" bgcolor="#FFFFFF">4,959 μs</td><td align="right" bgcolor="#FFFFFF">4,929 μs</td><td align="right" bgcolor="#FFFFFF">4,908 μs</td><td align="right" bgcolor="#FFFFFF">5,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -283,000)</td><td align="right" bgcolor="#FFFFFF">303,000</td><td align="right" bgcolor="#FFFFFF">303,000</td><td align="right" bgcolor="#FFFFFF">303,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,276)</td><td align="right" bgcolor="#FFFFFF">0,296</td><td align="right" bgcolor="#FFFFFF">0,296</td><td align="right" bgcolor="#FFFFFF">0,296</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 168,653 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3874,808 ns</td><td align="right" bgcolor="#FFFFFF">3799,916 ns</td><td align="right" bgcolor="#FFFFFF">3968,568 ns</td><td align="right" bgcolor="#FFFFFF">3962,421 ns</td><td align="right" bgcolor="#FFFFFF">3939,096 ns</td><td align="right" bgcolor="#FFFFFF">3866,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,875 μs</td><td align="right" bgcolor="#FFFFFF">3,800 μs</td><td align="right" bgcolor="#FFFFFF">3,969 μs</td><td align="right" bgcolor="#FFFFFF">3,962 μs</td><td align="right" bgcolor="#FFFFFF">3,939 μs</td><td align="right" bgcolor="#FFFFFF">3,867 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 139,665 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">856,624 ns</td><td align="right" bgcolor="#FFFFFF">865,783 ns</td><td align="right" bgcolor="#FFFFFF">968,214 ns</td><td align="right" bgcolor="#FFFFFF">964,793 ns</td><td align="right" bgcolor="#FFFFFF">996,290 ns</td><td align="right" bgcolor="#FFFFFF">946,985 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,857 μs</td><td align="right" bgcolor="#FFFFFF">0,866 μs</td><td align="right" bgcolor="#FFFFFF">0,968 μs</td><td align="right" bgcolor="#FFFFFF">0,965 μs</td><td align="right" bgcolor="#FFFFFF">0,996 μs</td><td align="right" bgcolor="#FFFFFF">0,947 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 67,252 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">769,108 ns</td><td align="right" bgcolor="#FFFFFF">756,072 ns</td><td align="right" bgcolor="#FFFFFF">807,871 ns</td><td align="right" bgcolor="#FFFFFF">806,433 ns</td><td align="right" bgcolor="#FFFFFF">823,324 ns</td><td align="right" bgcolor="#FFFFFF">820,607 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,769 μs</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,808 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,823 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">90,000</td><td align="right" bgcolor="#FFFFFF">90,000</td><td align="right" bgcolor="#FFFFFF">90,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,088 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#FFFFFF">0,088</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 114,906 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">537,329 ns</td><td align="right" bgcolor="#FFFFFF">422,423 ns</td><td align="right" bgcolor="#FFFFFF">460,911 ns</td><td align="right" bgcolor="#FFFFFF">431,207 ns</td><td align="right" bgcolor="#FFFFFF">424,981 ns</td><td align="right" bgcolor="#FFFFFF">428,232 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,537 μs</td><td align="right" bgcolor="#FFFFFF">0,422 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,431 μs</td><td align="right" bgcolor="#FFFFFF">0,425 μs</td><td align="right" bgcolor="#FFFFFF">0,428 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 53,670 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">196,252 ns</td><td align="right" bgcolor="#FFFFFF">153,520 ns</td><td align="right" bgcolor="#FFFFFF">143,588 ns</td><td align="right" bgcolor="#FFFFFF">142,582 ns</td><td align="right" bgcolor="#FFFFFF">143,430 ns</td><td align="right" bgcolor="#FFFFFF">143,333 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 51,435 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,865 ns</td><td align="right" bgcolor="#FFFFFF">144,903 ns</td><td align="right" bgcolor="#FFFFFF">144,968 ns</td><td align="right" bgcolor="#FFFFFF">145,263 ns</td><td align="right" bgcolor="#FFFFFF">144,430 ns</td><td align="right" bgcolor="#FFFFFF">145,148 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 213973,280 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#A8D08D">-31,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">653917,083 ns</td><td align="right" bgcolor="#A8D08D">645436,394 ns (Δ = -8480,689 ns)</td><td align="right" bgcolor="#A8D08D">439943,803 ns (Δ = -205492,591 ns)</td><td align="right" bgcolor="#FFFFFF">442880,786 ns</td><td align="right" bgcolor="#FFFFFF">440528,497 ns</td><td align="right" bgcolor="#FFFFFF">444591,465 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">653,917 μs</td><td align="right" bgcolor="#FFFFFF">645,436 μs</td><td align="right" bgcolor="#FFFFFF">439,944 μs</td><td align="right" bgcolor="#FFFFFF">442,881 μs</td><td align="right" bgcolor="#FFFFFF">440,528 μs</td><td align="right" bgcolor="#FFFFFF">444,591 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,654 ms</td><td align="right" bgcolor="#FFFFFF">0,645 ms</td><td align="right" bgcolor="#FFFFFF">0,440 ms</td><td align="right" bgcolor="#FFFFFF">0,443 ms</td><td align="right" bgcolor="#FFFFFF">0,441 ms</td><td align="right" bgcolor="#FFFFFF">0,445 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-38,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">110638,000</td><td align="right" bgcolor="#A8D08D">103130,000 (Δ = -7508,000)</td><td align="right" bgcolor="#A8D08D">63863,000 (Δ = -39267,000)</td><td align="right" bgcolor="#FF4949">63865,000 (Δ = +2,000)</td><td align="right" bgcolor="#FF4949">63867,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">63863,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">108,045</td><td align="right" bgcolor="#A8D08D">100,713 (Δ = -7,332)</td><td align="right" bgcolor="#A8D08D">62,366 (Δ = -38,347)</td><td align="right" bgcolor="#FF4949">62,368 (Δ = +0,002)</td><td align="right" bgcolor="#FF4949">62,370 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">62,366 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,106</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = -0,037)</td><td align="right" bgcolor="#FF4949">0,061 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,061 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 198454,993 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">416443,885 ns</td><td align="right" bgcolor="#FFFFFF">417960,198 ns</td><td align="right" bgcolor="#A8D08D">219922,497 ns (Δ = -198037,701 ns)</td><td align="right" bgcolor="#FFFFFF">220688,221 ns</td><td align="right" bgcolor="#FFFFFF">219505,205 ns</td><td align="right" bgcolor="#FFFFFF">220380,743 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">416,444 μs</td><td align="right" bgcolor="#FFFFFF">417,960 μs</td><td align="right" bgcolor="#FFFFFF">219,922 μs</td><td align="right" bgcolor="#FFFFFF">220,688 μs</td><td align="right" bgcolor="#FFFFFF">219,505 μs</td><td align="right" bgcolor="#FFFFFF">220,381 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,416 ms</td><td align="right" bgcolor="#FFFFFF">0,418 ms</td><td align="right" bgcolor="#FFFFFF">0,220 ms</td><td align="right" bgcolor="#FFFFFF">0,221 ms</td><td align="right" bgcolor="#FFFFFF">0,220 ms</td><td align="right" bgcolor="#FFFFFF">0,220 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">39191,000</td><td align="right" bgcolor="#A8D08D">37901,000 (Δ = -1290,000)</td><td align="right" bgcolor="#A8D08D">20021,000 (Δ = -17880,000)</td><td align="right" bgcolor="#FFFFFF">20021,000</td><td align="right" bgcolor="#FFFFFF">20021,000</td><td align="right" bgcolor="#FFFFFF">20021,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">38,272</td><td align="right" bgcolor="#A8D08D">37,013 (Δ = -1,260)</td><td align="right" bgcolor="#A8D08D">19,552 (Δ = -17,461)</td><td align="right" bgcolor="#FFFFFF">19,552</td><td align="right" bgcolor="#FFFFFF">19,552</td><td align="right" bgcolor="#FFFFFF">19,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,037</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,019 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,019</td><td align="right" bgcolor="#FFFFFF">0,019</td><td align="right" bgcolor="#FFFFFF">0,019</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 215348,274 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#A8D08D">-36,4 %</td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562901,386 ns</td><td align="right" bgcolor="#A8D08D">552921,639 ns (Δ = -9979,747 ns)</td><td align="right" bgcolor="#A8D08D">351659,768 ns (Δ = -201261,871 ns)</td><td align="right" bgcolor="#A8D08D">347553,112 ns (Δ = -4106,657 ns)</td><td align="right" bgcolor="#FFFFFF">348003,504 ns</td><td align="right" bgcolor="#FFFFFF">350474,642 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">562,901 μs</td><td align="right" bgcolor="#FFFFFF">552,922 μs</td><td align="right" bgcolor="#FFFFFF">351,660 μs</td><td align="right" bgcolor="#FFFFFF">347,553 μs</td><td align="right" bgcolor="#FFFFFF">348,004 μs</td><td align="right" bgcolor="#FFFFFF">350,475 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,563 ms</td><td align="right" bgcolor="#FFFFFF">0,553 ms</td><td align="right" bgcolor="#FFFFFF">0,352 ms</td><td align="right" bgcolor="#FFFFFF">0,348 ms</td><td align="right" bgcolor="#FFFFFF">0,348 ms</td><td align="right" bgcolor="#FFFFFF">0,350 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">26,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">18,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">18,000</td><td align="right" bgcolor="#FFFFFF">18,000</td><td align="right" bgcolor="#FFFFFF">18,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FF4949">8,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-41,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">87804,500</td><td align="right" bgcolor="#A8D08D">82272,000 (Δ = -5532,500)</td><td align="right" bgcolor="#A8D08D">47883,000 (Δ = -34389,000)</td><td align="right" bgcolor="#FFFFFF">47883,000</td><td align="right" bgcolor="#FFFFFF">47883,000</td><td align="right" bgcolor="#FFFFFF">47883,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">85,747</td><td align="right" bgcolor="#A8D08D">80,344 (Δ = -5,403)</td><td align="right" bgcolor="#A8D08D">46,761 (Δ = -33,583)</td><td align="right" bgcolor="#FFFFFF">46,761</td><td align="right" bgcolor="#FFFFFF">46,761</td><td align="right" bgcolor="#FFFFFF">46,761</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,046 (Δ = -0,033)</td><td align="right" bgcolor="#FFFFFF">0,046</td><td align="right" bgcolor="#FFFFFF">0,046</td><td align="right" bgcolor="#FFFFFF">0,046</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 285145,476 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,9 %</td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1343134,726 ns</td><td align="right" bgcolor="#A8D08D">1303581,982 ns (Δ = -39552,744 ns)</td><td align="right" bgcolor="#A8D08D">1084666,293 ns (Δ = -218915,688 ns)</td><td align="right" bgcolor="#FFFFFF">1081114,303 ns</td><td align="right" bgcolor="#FFFFFF">1074389,832 ns</td><td align="right" bgcolor="#A8D08D">1057989,250 ns (Δ = -16400,582 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1343,135 μs</td><td align="right" bgcolor="#FFFFFF">1303,582 μs</td><td align="right" bgcolor="#FFFFFF">1084,666 μs</td><td align="right" bgcolor="#FFFFFF">1081,114 μs</td><td align="right" bgcolor="#FFFFFF">1074,390 μs</td><td align="right" bgcolor="#FFFFFF">1057,989 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,343 ms</td><td align="right" bgcolor="#FFFFFF">1,304 ms</td><td align="right" bgcolor="#FFFFFF">1,085 ms</td><td align="right" bgcolor="#FFFFFF">1,081 ms</td><td align="right" bgcolor="#FFFFFF">1,074 ms</td><td align="right" bgcolor="#FFFFFF">1,058 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">107,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">72,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">72,000</td><td align="right" bgcolor="#FFFFFF">72,000</td><td align="right" bgcolor="#FFFFFF">72,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#A8D08D">11,000 (Δ = -6,000)</td><td align="right" bgcolor="#FFFFFF">11,000</td><td align="right" bgcolor="#FFFFFF">11,000</td><td align="right" bgcolor="#FFFFFF">11,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-38,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">337060,500</td><td align="right" bgcolor="#A8D08D">310253,500 (Δ = -26807,000)</td><td align="right" bgcolor="#A8D08D">190725,000 (Δ = -119528,500)</td><td align="right" bgcolor="#FFFFFF">190725,000</td><td align="right" bgcolor="#FFFFFF">190725,000</td><td align="right" bgcolor="#FFFFFF">190725,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">329,161</td><td align="right" bgcolor="#A8D08D">302,982 (Δ = -26,179)</td><td align="right" bgcolor="#A8D08D">186,255 (Δ = -116,727)</td><td align="right" bgcolor="#FFFFFF">186,255</td><td align="right" bgcolor="#FFFFFF">186,255</td><td align="right" bgcolor="#FFFFFF">186,255</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">0,182 (Δ = -0,114)</td><td align="right" bgcolor="#FFFFFF">0,182</td><td align="right" bgcolor="#FFFFFF">0,182</td><td align="right" bgcolor="#FFFFFF">0,182</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1241114,205 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17309562,233 ns</td><td align="right" bgcolor="#A8D08D">17057332,137 ns (Δ = -252230,097 ns)</td><td align="right" bgcolor="#FF4949">18192483,364 ns (Δ = +1135151,228 ns)</td><td align="right" bgcolor="#FFFFFF">18298446,342 ns</td><td align="right" bgcolor="#FFFFFF">18204481,835 ns</td><td align="right" bgcolor="#FFFFFF">18263376,884 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17309,562 μs</td><td align="right" bgcolor="#A8D08D">17057,332 μs (Δ = -252,230 μs)</td><td align="right" bgcolor="#FF4949">18192,483 μs (Δ = +1135,151 μs)</td><td align="right" bgcolor="#FFFFFF">18298,446 μs</td><td align="right" bgcolor="#FFFFFF">18204,482 μs</td><td align="right" bgcolor="#FFFFFF">18263,377 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">17,310 ms</td><td align="right" bgcolor="#FFFFFF">17,057 ms</td><td align="right" bgcolor="#FFFFFF">18,192 ms</td><td align="right" bgcolor="#FFFFFF">18,298 ms</td><td align="right" bgcolor="#FFFFFF">18,204 ms</td><td align="right" bgcolor="#FFFFFF">18,263 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">491,500</td><td align="right" bgcolor="#A8D08D">478,000 (Δ = -13,500)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -179,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">163,500</td><td align="right" bgcolor="#A8D08D">159,000 (Δ = -4,500)</td><td align="right" bgcolor="#A8D08D">99,000 (Δ = -60,000)</td><td align="right" bgcolor="#FFFFFF">99,000</td><td align="right" bgcolor="#FFFFFF">99,000</td><td align="right" bgcolor="#FFFFFF">99,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1547783,500</td><td align="right" bgcolor="#A8D08D">1504725,000 (Δ = -43058,500)</td><td align="right" bgcolor="#A8D08D">784968,500 (Δ = -719756,500)</td><td align="right" bgcolor="#A8D08D">784782,000 (Δ = -186,500)</td><td align="right" bgcolor="#FF4949">784821,000 (Δ = +39,000)</td><td align="right" bgcolor="#FF4949">784880,000 (Δ = +59,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1511,507</td><td align="right" bgcolor="#A8D08D">1469,458 (Δ = -42,049)</td><td align="right" bgcolor="#A8D08D">766,571 (Δ = -702,887)</td><td align="right" bgcolor="#A8D08D">766,389 (Δ = -0,182)</td><td align="right" bgcolor="#FF4949">766,427 (Δ = +0,038)</td><td align="right" bgcolor="#FF4949">766,484 (Δ = +0,058)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,476</td><td align="right" bgcolor="#A8D08D">1,435 (Δ = -0,041)</td><td align="right" bgcolor="#A8D08D">0,749 (Δ = -0,686)</td><td align="right" bgcolor="#A8D08D">0,748 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,748 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,749 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 129194,964 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1077941,097 ns</td><td align="right" bgcolor="#FFFFFF">1080921,259 ns</td><td align="right" bgcolor="#A8D08D">951726,295 ns (Δ = -129194,964 ns)</td><td align="right" bgcolor="#FFFFFF">956052,198 ns</td><td align="right" bgcolor="#FFFFFF">952304,643 ns</td><td align="right" bgcolor="#FFFFFF">956320,605 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1077,941 μs</td><td align="right" bgcolor="#FFFFFF">1080,921 μs</td><td align="right" bgcolor="#FFFFFF">951,726 μs</td><td align="right" bgcolor="#FFFFFF">956,052 μs</td><td align="right" bgcolor="#FFFFFF">952,305 μs</td><td align="right" bgcolor="#FFFFFF">956,321 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,078 ms</td><td align="right" bgcolor="#FFFFFF">1,081 ms</td><td align="right" bgcolor="#FFFFFF">0,952 ms</td><td align="right" bgcolor="#FFFFFF">0,956 ms</td><td align="right" bgcolor="#FFFFFF">0,952 ms</td><td align="right" bgcolor="#FFFFFF">0,956 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">17,000 (Δ = -10,000)</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FF4949">17,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#FFFFFF">17,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86979,500</td><td align="right" bgcolor="#A8D08D">85308,000 (Δ = -1671,500)</td><td align="right" bgcolor="#A8D08D">44809,000 (Δ = -40499,000)</td><td align="right" bgcolor="#FFFFFF">44809,000</td><td align="right" bgcolor="#FFFFFF">44809,000</td><td align="right" bgcolor="#FFFFFF">44809,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,941</td><td align="right" bgcolor="#A8D08D">83,309 (Δ = -1,632)</td><td align="right" bgcolor="#A8D08D">43,759 (Δ = -39,550)</td><td align="right" bgcolor="#FFFFFF">43,759</td><td align="right" bgcolor="#FFFFFF">43,759</td><td align="right" bgcolor="#FFFFFF">43,759</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,083</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,039)</td><td align="right" bgcolor="#FFFFFF">0,043</td><td align="right" bgcolor="#FFFFFF">0,043</td><td align="right" bgcolor="#FFFFFF">0,043</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 108847,553 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FF4949">+2,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3206125,914 ns</td><td align="right" bgcolor="#A8D08D">3149482,282 ns (Δ = -56643,632 ns)</td><td align="right" bgcolor="#FF4949">3229995,886 ns (Δ = +80513,603 ns)</td><td align="right" bgcolor="#FFFFFF">3258329,835 ns</td><td align="right" bgcolor="#FFFFFF">3231930,085 ns</td><td align="right" bgcolor="#FFFFFF">3241956,332 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3206,126 μs</td><td align="right" bgcolor="#FFFFFF">3149,482 μs</td><td align="right" bgcolor="#FFFFFF">3229,996 μs</td><td align="right" bgcolor="#FFFFFF">3258,330 μs</td><td align="right" bgcolor="#FFFFFF">3231,930 μs</td><td align="right" bgcolor="#FFFFFF">3241,956 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,206 ms</td><td align="right" bgcolor="#FFFFFF">3,149 ms</td><td align="right" bgcolor="#FFFFFF">3,230 ms</td><td align="right" bgcolor="#FFFFFF">3,258 ms</td><td align="right" bgcolor="#FFFFFF">3,232 ms</td><td align="right" bgcolor="#FFFFFF">3,242 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">89,000</td><td align="right" bgcolor="#A8D08D">87,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">54,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">26,500</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -1,500)</td><td align="right" bgcolor="#FF4949">54,000 (Δ = +29,000)</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td><td align="right" bgcolor="#FFFFFF">54,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#A8D08D">-48,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">281847,000</td><td align="right" bgcolor="#A8D08D">273857,000 (Δ = -7990,000)</td><td align="right" bgcolor="#A8D08D">142440,000 (Δ = -131417,000)</td><td align="right" bgcolor="#FFFFFF">142440,000</td><td align="right" bgcolor="#FFFFFF">142440,000</td><td align="right" bgcolor="#FFFFFF">142440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">275,241</td><td align="right" bgcolor="#A8D08D">267,438 (Δ = -7,803)</td><td align="right" bgcolor="#A8D08D">139,102 (Δ = -128,337)</td><td align="right" bgcolor="#FFFFFF">139,102</td><td align="right" bgcolor="#FFFFFF">139,102</td><td align="right" bgcolor="#FFFFFF">139,102</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,269</td><td align="right" bgcolor="#A8D08D">0,261 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,125)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1227095,438 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13707248,586 ns</td><td align="right" bgcolor="#A8D08D">13464304,448 ns (Δ = -242944,137 ns)</td><td align="right" bgcolor="#FF4949">14616708,654 ns (Δ = +1152404,206 ns)</td><td align="right" bgcolor="#FFFFFF">14681095,610 ns</td><td align="right" bgcolor="#FFFFFF">14557083,816 ns</td><td align="right" bgcolor="#FFFFFF">14691399,887 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13707,249 μs</td><td align="right" bgcolor="#FFFFFF">13464,304 μs</td><td align="right" bgcolor="#FF4949">14616,709 μs (Δ = +1152,404 μs)</td><td align="right" bgcolor="#FFFFFF">14681,096 μs</td><td align="right" bgcolor="#FFFFFF">14557,084 μs</td><td align="right" bgcolor="#FFFFFF">14691,400 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">13,707 ms</td><td align="right" bgcolor="#FFFFFF">13,464 ms</td><td align="right" bgcolor="#FFFFFF">14,617 ms</td><td align="right" bgcolor="#FFFFFF">14,681 ms</td><td align="right" bgcolor="#FFFFFF">14,557 ms</td><td align="right" bgcolor="#FFFFFF">14,691 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">401,000</td><td align="right" bgcolor="#A8D08D">387,000 (Δ = -14,000)</td><td align="right" bgcolor="#A8D08D">241,000 (Δ = -146,000)</td><td align="right" bgcolor="#FFFFFF">241,000</td><td align="right" bgcolor="#FFFFFF">241,000</td><td align="right" bgcolor="#FFFFFF">241,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#A8D08D">102,500 (Δ = -8,500)</td><td align="right" bgcolor="#A8D08D">60,000 (Δ = -42,500)</td><td align="right" bgcolor="#FFFFFF">60,000</td><td align="right" bgcolor="#FFFFFF">60,000</td><td align="right" bgcolor="#FFFFFF">60,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#A8D08D">-47,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1262956,000</td><td align="right" bgcolor="#A8D08D">1218280,500 (Δ = -44675,500)</td><td align="right" bgcolor="#A8D08D">634268,000 (Δ = -584012,500)</td><td align="right" bgcolor="#FFFFFF">634268,000</td><td align="right" bgcolor="#FFFFFF">634268,000</td><td align="right" bgcolor="#FFFFFF">634268,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1233,355</td><td align="right" bgcolor="#A8D08D">1189,727 (Δ = -43,628)</td><td align="right" bgcolor="#A8D08D">619,402 (Δ = -570,325)</td><td align="right" bgcolor="#FFFFFF">619,402</td><td align="right" bgcolor="#FFFFFF">619,402</td><td align="right" bgcolor="#FFFFFF">619,402</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#A8D08D">1,162 (Δ = -0,043)</td><td align="right" bgcolor="#A8D08D">0,605 (Δ = -0,557)</td><td align="right" bgcolor="#FFFFFF">0,605</td><td align="right" bgcolor="#FFFFFF">0,605</td><td align="right" bgcolor="#FFFFFF">0,605</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 212121,753 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1307054,436 ns</td><td align="right" bgcolor="#FFFFFF">1297990,463 ns</td><td align="right" bgcolor="#A8D08D">1094932,683 ns (Δ = -203057,781 ns)</td><td align="right" bgcolor="#FFFFFF">1103168,620 ns</td><td align="right" bgcolor="#FFFFFF">1106856,732 ns</td><td align="right" bgcolor="#FFFFFF">1106499,172 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1307,054 μs</td><td align="right" bgcolor="#FFFFFF">1297,990 μs</td><td align="right" bgcolor="#FFFFFF">1094,933 μs</td><td align="right" bgcolor="#FFFFFF">1103,169 μs</td><td align="right" bgcolor="#FFFFFF">1106,857 μs</td><td align="right" bgcolor="#FFFFFF">1106,499 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,307 ms</td><td align="right" bgcolor="#FFFFFF">1,298 ms</td><td align="right" bgcolor="#FFFFFF">1,095 ms</td><td align="right" bgcolor="#FFFFFF">1,103 ms</td><td align="right" bgcolor="#FFFFFF">1,107 ms</td><td align="right" bgcolor="#FFFFFF">1,106 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">186,000</td><td align="right" bgcolor="#A8D08D">183,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">190,000 (Δ = +7,000)</td><td align="right" bgcolor="#FFFFFF">190,000</td><td align="right" bgcolor="#FFFFFF">190,000</td><td align="right" bgcolor="#FFFFFF">190,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,500</td><td align="right" bgcolor="#A8D08D">29,500 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">27,000 (Δ = -2,500)</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587187,000</td><td align="right" bgcolor="#A8D08D">577306,000 (Δ = -9881,000)</td><td align="right" bgcolor="#A8D08D">500564,000 (Δ = -76742,000)</td><td align="right" bgcolor="#A8D08D">500558,500 (Δ = -5,500)</td><td align="right" bgcolor="#A8D08D">500546,000 (Δ = -12,500)</td><td align="right" bgcolor="#FF4949">500570,000 (Δ = +24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">573,425</td><td align="right" bgcolor="#A8D08D">563,775 (Δ = -9,649)</td><td align="right" bgcolor="#A8D08D">488,832 (Δ = -74,943)</td><td align="right" bgcolor="#A8D08D">488,827 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">488,814 (Δ = -0,012)</td><td align="right" bgcolor="#FF4949">488,838 (Δ = +0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,560</td><td align="right" bgcolor="#A8D08D">0,551 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,073)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,477 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 206792,779 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">504666,004 ns</td><td align="right" bgcolor="#FFFFFF">503833,923 ns</td><td align="right" bgcolor="#A8D08D">297873,225 ns (Δ = -205960,698 ns)</td><td align="right" bgcolor="#FFFFFF">298908,941 ns</td><td align="right" bgcolor="#FFFFFF">299499,385 ns</td><td align="right" bgcolor="#FFFFFF">299315,363 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">504,666 μs</td><td align="right" bgcolor="#FFFFFF">503,834 μs</td><td align="right" bgcolor="#FFFFFF">297,873 μs</td><td align="right" bgcolor="#FFFFFF">298,909 μs</td><td align="right" bgcolor="#FFFFFF">299,499 μs</td><td align="right" bgcolor="#FFFFFF">299,315 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,505 ms</td><td align="right" bgcolor="#FFFFFF">0,504 ms</td><td align="right" bgcolor="#FFFFFF">0,298 ms</td><td align="right" bgcolor="#FFFFFF">0,299 ms</td><td align="right" bgcolor="#FFFFFF">0,299 ms</td><td align="right" bgcolor="#FFFFFF">0,299 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FF4949">43,000 (Δ = +36,000)</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138507,500</td><td align="right" bgcolor="#A8D08D">136487,500 (Δ = -2020,000)</td><td align="right" bgcolor="#A8D08D">113847,000 (Δ = -22640,500)</td><td align="right" bgcolor="#FF4949">113849,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">113847,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">113846,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">135,261</td><td align="right" bgcolor="#A8D08D">133,289 (Δ = -1,973)</td><td align="right" bgcolor="#A8D08D">111,179 (Δ = -22,110)</td><td align="right" bgcolor="#FF4949">111,181 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">111,179 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">111,178 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#A8D08D">0,130 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = -0,022)</td><td align="right" bgcolor="#FF4949">0,109 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 250402,925 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-26,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">885203,463 ns</td><td align="right" bgcolor="#A8D08D">868371,088 ns (Δ = -16832,374 ns)</td><td align="right" bgcolor="#A8D08D">634800,538 ns (Δ = -233570,551 ns)</td><td align="right" bgcolor="#FFFFFF">637155,561 ns</td><td align="right" bgcolor="#FFFFFF">643482,792 ns</td><td align="right" bgcolor="#FFFFFF">644271,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">885,203 μs</td><td align="right" bgcolor="#FFFFFF">868,371 μs</td><td align="right" bgcolor="#FFFFFF">634,801 μs</td><td align="right" bgcolor="#FFFFFF">637,156 μs</td><td align="right" bgcolor="#FFFFFF">643,483 μs</td><td align="right" bgcolor="#FFFFFF">644,271 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,885 ms</td><td align="right" bgcolor="#FFFFFF">0,868 ms</td><td align="right" bgcolor="#FFFFFF">0,635 ms</td><td align="right" bgcolor="#FFFFFF">0,637 ms</td><td align="right" bgcolor="#FFFFFF">0,643 ms</td><td align="right" bgcolor="#FFFFFF">0,644 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.3.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">142,000 (Δ = +6,000)</td><td align="right" bgcolor="#FFFFFF">142,000</td><td align="right" bgcolor="#FFFFFF">142,000</td><td align="right" bgcolor="#FFFFFF">142,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">29,000 (Δ = +14,000)</td><td align="right" bgcolor="#FF4949">93,000 (Δ = +64,000)</td><td align="right" bgcolor="#FF4949">142,000 (Δ = +49,000)</td><td align="right" bgcolor="#FFFFFF">142,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">437405,500</td><td align="right" bgcolor="#A8D08D">429260,500 (Δ = -8145,000)</td><td align="right" bgcolor="#A8D08D">372964,500 (Δ = -56296,000)</td><td align="right" bgcolor="#FF4949">373018,000 (Δ = +53,500)</td><td align="right" bgcolor="#FF4949">373035,500 (Δ = +17,500)</td><td align="right" bgcolor="#FF4949">373121,000 (Δ = +85,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">427,154</td><td align="right" bgcolor="#A8D08D">419,200 (Δ = -7,954)</td><td align="right" bgcolor="#A8D08D">364,223 (Δ = -54,977)</td><td align="right" bgcolor="#FF4949">364,275 (Δ = +0,052)</td><td align="right" bgcolor="#FF4949">364,292 (Δ = +0,017)</td><td align="right" bgcolor="#FF4949">364,376 (Δ = +0,083)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,417</td><td align="right" bgcolor="#A8D08D">0,409 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,356 (Δ = -0,054)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 453630,812 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2797262,020 ns</td><td align="right" bgcolor="#FFFFFF">2792095,888 ns</td><td align="right" bgcolor="#A8D08D">2398898,613 ns (Δ = -393197,275 ns)</td><td align="right" bgcolor="#FFFFFF">2398936,603 ns</td><td align="right" bgcolor="#FFFFFF">2418566,627 ns</td><td align="right" bgcolor="#A8D08D">2343631,208 ns (Δ = -74935,419 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2797,262 μs</td><td align="right" bgcolor="#FFFFFF">2792,096 μs</td><td align="right" bgcolor="#A8D08D">2398,899 μs (Δ = -393,197 μs)</td><td align="right" bgcolor="#FFFFFF">2398,937 μs</td><td align="right" bgcolor="#FFFFFF">2418,567 μs</td><td align="right" bgcolor="#FFFFFF">2343,631 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,797 ms</td><td align="right" bgcolor="#FFFFFF">2,792 ms</td><td align="right" bgcolor="#FFFFFF">2,399 ms</td><td align="right" bgcolor="#FFFFFF">2,399 ms</td><td align="right" bgcolor="#FFFFFF">2,419 ms</td><td align="right" bgcolor="#FFFFFF">2,344 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">613,000</td><td align="right" bgcolor="#A8D08D">601,000 (Δ = -12,000)</td><td align="right" bgcolor="#FF4949">634,000 (Δ = +33,000)</td><td align="right" bgcolor="#FFFFFF">634,000</td><td align="right" bgcolor="#FFFFFF">634,000</td><td align="right" bgcolor="#FFFFFF">634,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#A8D08D">99,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">95,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">95,000</td><td align="right" bgcolor="#FFFFFF">95,000</td><td align="right" bgcolor="#FFFFFF">95,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-12,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1930887,000</td><td align="right" bgcolor="#A8D08D">1892572,500 (Δ = -38314,500)</td><td align="right" bgcolor="#A8D08D">1666002,500 (Δ = -226570,000)</td><td align="right" bgcolor="#A8D08D">1665979,500 (Δ = -23,000)</td><td align="right" bgcolor="#FF4949">1666063,500 (Δ = +84,000)</td><td align="right" bgcolor="#A8D08D">1665987,000 (Δ = -76,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1885,632</td><td align="right" bgcolor="#A8D08D">1848,215 (Δ = -37,417)</td><td align="right" bgcolor="#A8D08D">1626,956 (Δ = -221,260)</td><td align="right" bgcolor="#A8D08D">1626,933 (Δ = -0,022)</td><td align="right" bgcolor="#FF4949">1627,015 (Δ = +0,082)</td><td align="right" bgcolor="#A8D08D">1626,940 (Δ = -0,075)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,841</td><td align="right" bgcolor="#A8D08D">1,805 (Δ = -0,037)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = -0,216)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">1,589 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = 0,000)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 290,937 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">755,639 ns</td><td align="right" bgcolor="#FFFFFF">962,295 ns</td><td align="right" bgcolor="#FFFFFF">1019,966 ns</td><td align="right" bgcolor="#FFFFFF">1011,370 ns</td><td align="right" bgcolor="#FFFFFF">1046,576 ns</td><td align="right" bgcolor="#FFFFFF">1025,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">1,020 μs</td><td align="right" bgcolor="#FFFFFF">1,011 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#A8D08D">-26,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -118,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -246,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,115)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,240)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 11,635 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">190,244 ns</td><td align="right" bgcolor="#FFFFFF">190,061 ns</td><td align="right" bgcolor="#FFFFFF">201,696 ns</td><td align="right" bgcolor="#FFFFFF">195,304 ns</td><td align="right" bgcolor="#FFFFFF">197,466 ns</td><td align="right" bgcolor="#FFFFFF">194,968 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 354,755 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2868,041 ns</td><td align="right" bgcolor="#FFFFFF">3062,373 ns</td><td align="right" bgcolor="#A8D08D">2764,359 ns (Δ = -298,014 ns)</td><td align="right" bgcolor="#FFFFFF">2714,541 ns</td><td align="right" bgcolor="#FFFFFF">2807,278 ns</td><td align="right" bgcolor="#FFFFFF">2707,618 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,868 μs</td><td align="right" bgcolor="#FFFFFF">3,062 μs</td><td align="right" bgcolor="#FFFFFF">2,764 μs</td><td align="right" bgcolor="#FFFFFF">2,715 μs</td><td align="right" bgcolor="#FFFFFF">2,807 μs</td><td align="right" bgcolor="#FFFFFF">2,708 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#A8D08D">-39,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1401,000</td><td align="right" bgcolor="#FF4949">1409,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">848,000 (Δ = -561,000)</td><td align="right" bgcolor="#FFFFFF">848,000</td><td align="right" bgcolor="#FFFFFF">848,000</td><td align="right" bgcolor="#FFFFFF">848,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,368</td><td align="right" bgcolor="#FF4949">1,376 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,828 (Δ = -0,548)</td><td align="right" bgcolor="#FFFFFF">0,828</td><td align="right" bgcolor="#FFFFFF">0,828</td><td align="right" bgcolor="#FFFFFF">0,828</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 11,624 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">187,143 ns</td><td align="right" bgcolor="#FFFFFF">188,976 ns</td><td align="right" bgcolor="#FFFFFF">193,882 ns</td><td align="right" bgcolor="#FFFFFF">195,206 ns</td><td align="right" bgcolor="#FFFFFF">198,767 ns</td><td align="right" bgcolor="#FFFFFF">195,642 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1217,963 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6838,276 ns</td><td align="right" bgcolor="#A8D08D">6298,803 ns (Δ = -539,473 ns)</td><td align="right" bgcolor="#A8D08D">5778,217 ns (Δ = -520,586 ns)</td><td align="right" bgcolor="#FFFFFF">5620,313 ns</td><td align="right" bgcolor="#FF4949">5883,220 ns (Δ = +262,906 ns)</td><td align="right" bgcolor="#FFFFFF">5657,757 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,838 μs</td><td align="right" bgcolor="#FFFFFF">6,299 μs</td><td align="right" bgcolor="#FFFFFF">5,778 μs</td><td align="right" bgcolor="#FFFFFF">5,620 μs</td><td align="right" bgcolor="#FFFFFF">5,883 μs</td><td align="right" bgcolor="#FFFFFF">5,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-40,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3146,500</td><td align="right" bgcolor="#A8D08D">3003,500 (Δ = -143,000)</td><td align="right" bgcolor="#A8D08D">1794,000 (Δ = -1209,500)</td><td align="right" bgcolor="#FFFFFF">1794,000</td><td align="right" bgcolor="#FFFFFF">1794,000</td><td align="right" bgcolor="#FFFFFF">1794,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,073</td><td align="right" bgcolor="#A8D08D">2,933 (Δ = -0,140)</td><td align="right" bgcolor="#A8D08D">1,752 (Δ = -1,181)</td><td align="right" bgcolor="#FFFFFF">1,752</td><td align="right" bgcolor="#FFFFFF">1,752</td><td align="right" bgcolor="#FFFFFF">1,752</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 3,001 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,501 ns</td><td align="right" bgcolor="#FFFFFF">9,196 ns</td><td align="right" bgcolor="#FFFFFF">12,196 ns</td><td align="right" bgcolor="#FFFFFF">11,814 ns</td><td align="right" bgcolor="#FFFFFF">11,870 ns</td><td align="right" bgcolor="#FFFFFF">11,012 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 1034,628 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20381,141 ns</td><td align="right" bgcolor="#FFFFFF">20203,555 ns</td><td align="right" bgcolor="#A8D08D">19459,107 ns (Δ = -744,448 ns)</td><td align="right" bgcolor="#FFFFFF">19433,164 ns</td><td align="right" bgcolor="#FFFFFF">19431,727 ns</td><td align="right" bgcolor="#FFFFFF">19346,513 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20,381 μs</td><td align="right" bgcolor="#FFFFFF">20,204 μs</td><td align="right" bgcolor="#FFFFFF">19,459 μs</td><td align="right" bgcolor="#FFFFFF">19,433 μs</td><td align="right" bgcolor="#FFFFFF">19,432 μs</td><td align="right" bgcolor="#FFFFFF">19,347 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,6 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#A8D08D">5542,000 (Δ = -5452,000)</td><td align="right" bgcolor="#A8D08D">5526,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">5526,000</td><td align="right" bgcolor="#FFFFFF">5526,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#A8D08D">5,412 (Δ = -5,324)</td><td align="right" bgcolor="#A8D08D">5,396 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">5,396</td><td align="right" bgcolor="#FFFFFF">5,396</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#FFFFFF">0,005</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,702 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,805 ns</td><td align="right" bgcolor="#FFFFFF">25,387 ns</td><td align="right" bgcolor="#FFFFFF">29,941 ns</td><td align="right" bgcolor="#FFFFFF">30,089 ns</td><td align="right" bgcolor="#FFFFFF">29,745 ns</td><td align="right" bgcolor="#FFFFFF">29,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 7,554 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,164 ns</td><td align="right" bgcolor="#FFFFFF">18,839 ns</td><td align="right" bgcolor="#FFFFFF">25,718 ns</td><td align="right" bgcolor="#FFFFFF">25,225 ns</td><td align="right" bgcolor="#FFFFFF">25,280 ns</td><td align="right" bgcolor="#FFFFFF">25,078 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 9,014 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,541 ns</td><td align="right" bgcolor="#FFFFFF">20,877 ns</td><td align="right" bgcolor="#FFFFFF">28,371 ns</td><td align="right" bgcolor="#FFFFFF">28,485 ns</td><td align="right" bgcolor="#FFFFFF">29,555 ns</td><td align="right" bgcolor="#FFFFFF">28,397 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 8,456 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,993 ns</td><td align="right" bgcolor="#FFFFFF">25,875 ns</td><td align="right" bgcolor="#FFFFFF">34,331 ns</td><td align="right" bgcolor="#FFFFFF">34,120 ns</td><td align="right" bgcolor="#FFFFFF">33,878 ns</td><td align="right" bgcolor="#FFFFFF">34,042 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 43,779 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">270,901 ns</td><td align="right" bgcolor="#FFFFFF">268,125 ns</td><td align="right" bgcolor="#FFFFFF">311,904 ns</td><td align="right" bgcolor="#FFFFFF">306,005 ns</td><td align="right" bgcolor="#FFFFFF">302,808 ns</td><td align="right" bgcolor="#FFFFFF">301,748 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,303 μs</td><td align="right" bgcolor="#FFFFFF">0,302 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#A8D08D">66,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#A8D08D">0,064 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 7,859 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,419 ns</td><td align="right" bgcolor="#FFFFFF">79,002 ns</td><td align="right" bgcolor="#FFFFFF">73,721 ns</td><td align="right" bgcolor="#FFFFFF">74,679 ns</td><td align="right" bgcolor="#FFFFFF">72,750 ns</td><td align="right" bgcolor="#FFFFFF">72,560 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 225,198 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3376,595 ns</td><td align="right" bgcolor="#FFFFFF">3421,020 ns</td><td align="right" bgcolor="#FFFFFF">3512,621 ns</td><td align="right" bgcolor="#FFFFFF">3578,433 ns</td><td align="right" bgcolor="#FFFFFF">3537,948 ns</td><td align="right" bgcolor="#FFFFFF">3601,793 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,377 μs</td><td align="right" bgcolor="#FFFFFF">3,421 μs</td><td align="right" bgcolor="#FFFFFF">3,513 μs</td><td align="right" bgcolor="#FFFFFF">3,578 μs</td><td align="right" bgcolor="#FFFFFF">3,538 μs</td><td align="right" bgcolor="#FFFFFF">3,602 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1512,745 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8399,159 ns</td><td align="right" bgcolor="#FF4949">9093,350 ns (Δ = +694,191 ns)</td><td align="right" bgcolor="#FF4949">9847,359 ns (Δ = +754,009 ns)</td><td align="right" bgcolor="#FFFFFF">9911,904 ns</td><td align="right" bgcolor="#FFFFFF">9883,549 ns</td><td align="right" bgcolor="#FFFFFF">9711,450 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,399 μs</td><td align="right" bgcolor="#FFFFFF">9,093 μs</td><td align="right" bgcolor="#FFFFFF">9,847 μs</td><td align="right" bgcolor="#FFFFFF">9,912 μs</td><td align="right" bgcolor="#FFFFFF">9,884 μs</td><td align="right" bgcolor="#FFFFFF">9,711 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 136,634 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3487,816 ns</td><td align="right" bgcolor="#FFFFFF">3390,927 ns</td><td align="right" bgcolor="#FFFFFF">3482,431 ns</td><td align="right" bgcolor="#FFFFFF">3527,561 ns</td><td align="right" bgcolor="#FFFFFF">3516,240 ns</td><td align="right" bgcolor="#FFFFFF">3478,393 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,488 μs</td><td align="right" bgcolor="#FFFFFF">3,391 μs</td><td align="right" bgcolor="#FFFFFF">3,482 μs</td><td align="right" bgcolor="#FFFFFF">3,528 μs</td><td align="right" bgcolor="#FFFFFF">3,516 μs</td><td align="right" bgcolor="#FFFFFF">3,478 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1506,097 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#FF4949">+9,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8379,518 ns</td><td align="right" bgcolor="#FF4949">9014,198 ns (Δ = +634,680 ns)</td><td align="right" bgcolor="#FF4949">9885,616 ns (Δ = +871,418 ns)</td><td align="right" bgcolor="#FFFFFF">9834,706 ns</td><td align="right" bgcolor="#FFFFFF">9833,381 ns</td><td align="right" bgcolor="#FFFFFF">9704,005 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,380 μs</td><td align="right" bgcolor="#FFFFFF">9,014 μs</td><td align="right" bgcolor="#FFFFFF">9,886 μs</td><td align="right" bgcolor="#FFFFFF">9,835 μs</td><td align="right" bgcolor="#FFFFFF">9,833 μs</td><td align="right" bgcolor="#FFFFFF">9,704 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,466 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,153 ns</td><td align="right" bgcolor="#FFFFFF">7,127 ns</td><td align="right" bgcolor="#FFFFFF">8,585 ns</td><td align="right" bgcolor="#FFFFFF">8,593 ns</td><td align="right" bgcolor="#FFFFFF">8,238 ns</td><td align="right" bgcolor="#FFFFFF">8,260 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 75,672 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">730,084 ns</td><td align="right" bgcolor="#FFFFFF">703,751 ns</td><td align="right" bgcolor="#FFFFFF">654,413 ns</td><td align="right" bgcolor="#FFFFFF">658,378 ns</td><td align="right" bgcolor="#FFFFFF">674,640 ns</td><td align="right" bgcolor="#FFFFFF">673,907 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,730 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,674 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 7,743 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,917 ns</td><td align="right" bgcolor="#FFFFFF">96,804 ns</td><td align="right" bgcolor="#FFFFFF">96,566 ns</td><td align="right" bgcolor="#FFFFFF">95,296 ns</td><td align="right" bgcolor="#FFFFFF">98,145 ns</td><td align="right" bgcolor="#FFFFFF">103,039 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 323,615 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2721,143 ns</td><td align="right" bgcolor="#A8D08D">2397,528 ns (Δ = -323,615 ns)</td><td align="right" bgcolor="#FFFFFF">2470,228 ns</td><td align="right" bgcolor="#FFFFFF">2415,907 ns</td><td align="right" bgcolor="#FFFFFF">2436,408 ns</td><td align="right" bgcolor="#FFFFFF">2422,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,721 μs</td><td align="right" bgcolor="#FFFFFF">2,398 μs</td><td align="right" bgcolor="#FFFFFF">2,470 μs</td><td align="right" bgcolor="#FFFFFF">2,416 μs</td><td align="right" bgcolor="#FFFFFF">2,436 μs</td><td align="right" bgcolor="#FFFFFF">2,422 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 198,615 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1186,441 ns</td><td align="right" bgcolor="#FFFFFF">1018,303 ns</td><td align="right" bgcolor="#FFFFFF">988,595 ns</td><td align="right" bgcolor="#FFFFFF">1071,550 ns</td><td align="right" bgcolor="#FFFFFF">987,826 ns</td><td align="right" bgcolor="#FFFFFF">998,301 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,186 μs</td><td align="right" bgcolor="#FFFFFF">1,018 μs</td><td align="right" bgcolor="#FFFFFF">0,989 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td><td align="right" bgcolor="#FFFFFF">0,988 μs</td><td align="right" bgcolor="#FFFFFF">0,998 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">475,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -200,000)</td><td align="right" bgcolor="#FFFFFF">201,000</td><td align="right" bgcolor="#FFFFFF">201,000</td><td align="right" bgcolor="#FFFFFF">201,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,464</td><td align="right" bgcolor="#A8D08D">0,392 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,195)</td><td align="right" bgcolor="#FFFFFF">0,196</td><td align="right" bgcolor="#FFFFFF">0,196</td><td align="right" bgcolor="#FFFFFF">0,196</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 161,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">597,703 ns</td><td align="right" bgcolor="#FFFFFF">436,131 ns</td><td align="right" bgcolor="#FFFFFF">462,997 ns</td><td align="right" bgcolor="#FFFFFF">462,328 ns</td><td align="right" bgcolor="#FFFFFF">465,013 ns</td><td align="right" bgcolor="#FFFFFF">461,479 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,598 μs</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,462 μs</td><td align="right" bgcolor="#FFFFFF">0,465 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,8 %</td><td align="right" bgcolor="#A8D08D">-49,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -148,000)</td><td align="right" bgcolor="#A8D08D">152,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">152,000</td><td align="right" bgcolor="#FFFFFF">152,000</td><td align="right" bgcolor="#FFFFFF">152,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,145)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FFFFFF">0,148</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 68,827 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">734,969 ns</td><td align="right" bgcolor="#FFFFFF">714,860 ns</td><td align="right" bgcolor="#FFFFFF">666,142 ns</td><td align="right" bgcolor="#FFFFFF">669,010 ns</td><td align="right" bgcolor="#FFFFFF">674,673 ns</td><td align="right" bgcolor="#FFFFFF">670,262 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,715 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,669 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,670 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 6,010 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,786 ns</td><td align="right" bgcolor="#FFFFFF">98,278 ns</td><td align="right" bgcolor="#FFFFFF">98,388 ns</td><td align="right" bgcolor="#FFFFFF">97,968 ns</td><td align="right" bgcolor="#FFFFFF">103,535 ns</td><td align="right" bgcolor="#FFFFFF">103,977 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 12,471 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,831 ns</td><td align="right" bgcolor="#FFFFFF">109,377 ns</td><td align="right" bgcolor="#FFFFFF">106,549 ns</td><td align="right" bgcolor="#FFFFFF">113,099 ns</td><td align="right" bgcolor="#FFFFFF">116,167 ns</td><td align="right" bgcolor="#FFFFFF">119,020 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 7,149 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,973 ns</td><td align="right" bgcolor="#FFFFFF">106,160 ns</td><td align="right" bgcolor="#FFFFFF">100,147 ns</td><td align="right" bgcolor="#FFFFFF">99,011 ns</td><td align="right" bgcolor="#FFFFFF">100,583 ns</td><td align="right" bgcolor="#FFFFFF">104,643 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 90,909 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">535,946 ns</td><td align="right" bgcolor="#FFFFFF">574,582 ns</td><td align="right" bgcolor="#FFFFFF">596,955 ns</td><td align="right" bgcolor="#FFFFFF">593,051 ns</td><td align="right" bgcolor="#FFFFFF">586,190 ns</td><td align="right" bgcolor="#FFFFFF">626,855 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">315,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -155,000)</td><td align="right" bgcolor="#FF4949">176,000 (Δ = +16,000)</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FF4949">0,308 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,151)</td><td align="right" bgcolor="#FF4949">0,172 (Δ = +0,016)</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 8,553 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,413 ns</td><td align="right" bgcolor="#FFFFFF">101,513 ns</td><td align="right" bgcolor="#FFFFFF">93,838 ns</td><td align="right" bgcolor="#FFFFFF">99,639 ns</td><td align="right" bgcolor="#FFFFFF">102,391 ns</td><td align="right" bgcolor="#FFFFFF">101,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 124,227 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">856,407 ns</td><td align="right" bgcolor="#FFFFFF">915,447 ns</td><td align="right" bgcolor="#FFFFFF">924,363 ns</td><td align="right" bgcolor="#FFFFFF">961,562 ns</td><td align="right" bgcolor="#FFFFFF">949,176 ns</td><td align="right" bgcolor="#FFFFFF">980,633 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,856 μs</td><td align="right" bgcolor="#FFFFFF">0,915 μs</td><td align="right" bgcolor="#FFFFFF">0,924 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">0,949 μs</td><td align="right" bgcolor="#FFFFFF">0,981 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FF4949">356,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -176,000)</td><td align="right" bgcolor="#FF4949">197,000 (Δ = +17,000)</td><td align="right" bgcolor="#FFFFFF">197,000</td><td align="right" bgcolor="#FFFFFF">197,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FF4949">0,348 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,172)</td><td align="right" bgcolor="#FF4949">0,192 (Δ = +0,017)</td><td align="right" bgcolor="#FFFFFF">0,192</td><td align="right" bgcolor="#FFFFFF">0,192</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 26,941 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,057 ns</td><td align="right" bgcolor="#FFFFFF">95,299 ns</td><td align="right" bgcolor="#FFFFFF">93,096 ns</td><td align="right" bgcolor="#FFFFFF">100,013 ns</td><td align="right" bgcolor="#FFFFFF">118,998 ns</td><td align="right" bgcolor="#FFFFFF">104,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 70,764 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,283 ns</td><td align="right" bgcolor="#FFFFFF">156,899 ns</td><td align="right" bgcolor="#FFFFFF">227,048 ns</td><td align="right" bgcolor="#FFFFFF">219,444 ns</td><td align="right" bgcolor="#FFFFFF">218,913 ns</td><td align="right" bgcolor="#FFFFFF">215,908 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 27,720 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94,706 ns</td><td align="right" bgcolor="#FFFFFF">94,638 ns</td><td align="right" bgcolor="#FFFFFF">120,940 ns</td><td align="right" bgcolor="#FFFFFF">122,358 ns</td><td align="right" bgcolor="#FFFFFF">121,053 ns</td><td align="right" bgcolor="#FFFFFF">108,983 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 17,659 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,903 ns</td><td align="right" bgcolor="#FFFFFF">139,244 ns</td><td align="right" bgcolor="#FFFFFF">143,349 ns</td><td align="right" bgcolor="#FFFFFF">140,789 ns</td><td align="right" bgcolor="#FFFFFF">140,972 ns</td><td align="right" bgcolor="#FFFFFF">141,757 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-50,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 107,367 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1329,557 ns</td><td align="right" bgcolor="#FFFFFF">1304,363 ns</td><td align="right" bgcolor="#FFFFFF">1290,387 ns</td><td align="right" bgcolor="#FFFFFF">1222,190 ns</td><td align="right" bgcolor="#FFFFFF">1234,991 ns</td><td align="right" bgcolor="#FFFFFF">1247,785 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,330 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td><td align="right" bgcolor="#FFFFFF">1,290 μs</td><td align="right" bgcolor="#FFFFFF">1,222 μs</td><td align="right" bgcolor="#FFFFFF">1,235 μs</td><td align="right" bgcolor="#FFFFFF">1,248 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -131,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,128)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 12,559 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">643,368 ns</td><td align="right" bgcolor="#FFFFFF">649,400 ns</td><td align="right" bgcolor="#FFFFFF">636,841 ns</td><td align="right" bgcolor="#FFFFFF">638,836 ns</td><td align="right" bgcolor="#FFFFFF">644,013 ns</td><td align="right" bgcolor="#FFFFFF">645,753 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,649 μs</td><td align="right" bgcolor="#FFFFFF">0,637 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,646 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 45,449 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">629,646 ns</td><td align="right" bgcolor="#FFFFFF">637,968 ns</td><td align="right" bgcolor="#FFFFFF">675,095 ns</td><td align="right" bgcolor="#FFFFFF">641,466 ns</td><td align="right" bgcolor="#FFFFFF">639,690 ns</td><td align="right" bgcolor="#FFFFFF">661,000 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,640 μs</td><td align="right" bgcolor="#FFFFFF">0,661 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 9,014 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">613,860 ns</td><td align="right" bgcolor="#FFFFFF">609,039 ns</td><td align="right" bgcolor="#FFFFFF">617,104 ns</td><td align="right" bgcolor="#FFFFFF">613,865 ns</td><td align="right" bgcolor="#FFFFFF">609,257 ns</td><td align="right" bgcolor="#FFFFFF">608,090 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,614 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,614 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,608 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 83,871 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">770,003 ns</td><td align="right" bgcolor="#FFFFFF">763,768 ns</td><td align="right" bgcolor="#FFFFFF">686,938 ns</td><td align="right" bgcolor="#FFFFFF">706,053 ns</td><td align="right" bgcolor="#FFFFFF">693,284 ns</td><td align="right" bgcolor="#FFFFFF">686,132 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,770 μs</td><td align="right" bgcolor="#FFFFFF">0,764 μs</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,686 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 8,318 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,818 ns</td><td align="right" bgcolor="#FFFFFF">121,366 ns</td><td align="right" bgcolor="#FFFFFF">119,500 ns</td><td align="right" bgcolor="#FFFFFF">122,014 ns</td><td align="right" bgcolor="#FFFFFF">122,151 ns</td><td align="right" bgcolor="#FFFFFF">120,588 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 7,847 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,550 ns</td><td align="right" bgcolor="#FFFFFF">131,703 ns</td><td align="right" bgcolor="#FFFFFF">134,457 ns</td><td align="right" bgcolor="#FFFFFF">136,301 ns</td><td align="right" bgcolor="#FFFFFF">136,008 ns</td><td align="right" bgcolor="#FFFFFF">138,463 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 11,631 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,016 ns</td><td align="right" bgcolor="#FFFFFF">120,108 ns</td><td align="right" bgcolor="#FFFFFF">131,739 ns</td><td align="right" bgcolor="#FFFFFF">131,689 ns</td><td align="right" bgcolor="#FFFFFF">124,537 ns</td><td align="right" bgcolor="#FFFFFF">124,822 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2209,648 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,1 %</td><td align="right" bgcolor="#FF4949">+7,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7344,933 ns</td><td align="right" bgcolor="#A8D08D">5135,285 ns (Δ = -2209,648 ns)</td><td align="right" bgcolor="#FF4949">5500,752 ns (Δ = +365,467 ns)</td><td align="right" bgcolor="#FFFFFF">5543,830 ns</td><td align="right" bgcolor="#FFFFFF">5583,775 ns</td><td align="right" bgcolor="#FFFFFF">5630,235 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,345 μs</td><td align="right" bgcolor="#FFFFFF">5,135 μs</td><td align="right" bgcolor="#FFFFFF">5,501 μs</td><td align="right" bgcolor="#FFFFFF">5,544 μs</td><td align="right" bgcolor="#FFFFFF">5,584 μs</td><td align="right" bgcolor="#FFFFFF">5,630 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,5 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2945,000</td><td align="right" bgcolor="#A8D08D">2048,000 (Δ = -897,000)</td><td align="right" bgcolor="#A8D08D">1040,000 (Δ = -1008,000)</td><td align="right" bgcolor="#FF4949">1044,000 (Δ = +4,000)</td><td align="right" bgcolor="#FF4949">1053,000 (Δ = +9,000)</td><td align="right" bgcolor="#FFFFFF">1053,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,876</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -0,876)</td><td align="right" bgcolor="#A8D08D">1,016 (Δ = -0,984)</td><td align="right" bgcolor="#FF4949">1,020 (Δ = +0,004)</td><td align="right" bgcolor="#FF4949">1,028 (Δ = +0,009)</td><td align="right" bgcolor="#FFFFFF">1,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 419,307 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1323,022 ns</td><td align="right" bgcolor="#A8D08D">903,715 ns (Δ = -419,307 ns)</td><td align="right" bgcolor="#FFFFFF">1049,758 ns</td><td align="right" bgcolor="#FFFFFF">1055,678 ns</td><td align="right" bgcolor="#FFFFFF">1064,033 ns</td><td align="right" bgcolor="#FFFFFF">1059,010 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,323 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">1,050 μs</td><td align="right" bgcolor="#FFFFFF">1,056 μs</td><td align="right" bgcolor="#FFFFFF">1,064 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2384,716 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7059,718 ns</td><td align="right" bgcolor="#A8D08D">4675,003 ns (Δ = -2384,716 ns)</td><td align="right" bgcolor="#FFFFFF">4914,073 ns</td><td align="right" bgcolor="#FFFFFF">4951,571 ns</td><td align="right" bgcolor="#FFFFFF">5006,373 ns</td><td align="right" bgcolor="#FFFFFF">5060,387 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,060 μs</td><td align="right" bgcolor="#FFFFFF">4,675 μs</td><td align="right" bgcolor="#FFFFFF">4,914 μs</td><td align="right" bgcolor="#FFFFFF">4,952 μs</td><td align="right" bgcolor="#FFFFFF">5,006 μs</td><td align="right" bgcolor="#FFFFFF">5,060 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FF4949">+0,5 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5092,000</td><td align="right" bgcolor="#A8D08D">3466,500 (Δ = -1625,500)</td><td align="right" bgcolor="#A8D08D">1765,000 (Δ = -1701,500)</td><td align="right" bgcolor="#FF4949">1774,000 (Δ = +9,000)</td><td align="right" bgcolor="#FF4949">1790,000 (Δ = +16,000)</td><td align="right" bgcolor="#FFFFFF">1790,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,973</td><td align="right" bgcolor="#A8D08D">3,385 (Δ = -1,587)</td><td align="right" bgcolor="#A8D08D">1,724 (Δ = -1,662)</td><td align="right" bgcolor="#FF4949">1,732 (Δ = +0,009)</td><td align="right" bgcolor="#FF4949">1,748 (Δ = +0,016)</td><td align="right" bgcolor="#FFFFFF">1,748</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 411,620 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1315,478 ns</td><td align="right" bgcolor="#A8D08D">903,858 ns (Δ = -411,620 ns)</td><td align="right" bgcolor="#FFFFFF">1049,628 ns</td><td align="right" bgcolor="#FFFFFF">1055,245 ns</td><td align="right" bgcolor="#FFFFFF">1065,348 ns</td><td align="right" bgcolor="#FFFFFF">1059,970 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,315 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">1,050 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,060 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 246,511 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">735,499 ns</td><td align="right" bgcolor="#FFFFFF">711,105 ns</td><td align="right" bgcolor="#FFFFFF">785,055 ns</td><td align="right" bgcolor="#FFFFFF">875,160 ns</td><td align="right" bgcolor="#FFFFFF">957,616 ns</td><td align="right" bgcolor="#FFFFFF">895,047 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,711 μs</td><td align="right" bgcolor="#FFFFFF">0,785 μs</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">0,958 μs</td><td align="right" bgcolor="#FFFFFF">0,895 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">291,000</td><td align="right" bgcolor="#A8D08D">266,000 (Δ = -25,000)</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,284</td><td align="right" bgcolor="#A8D08D">0,260 (Δ = -0,024)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 290,138 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1572,283 ns</td><td align="right" bgcolor="#FFFFFF">1328,513 ns</td><td align="right" bgcolor="#FFFFFF">1282,145 ns</td><td align="right" bgcolor="#FFFFFF">1295,133 ns</td><td align="right" bgcolor="#FFFFFF">1296,974 ns</td><td align="right" bgcolor="#FFFFFF">1302,539 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,572 μs</td><td align="right" bgcolor="#FFFFFF">1,329 μs</td><td align="right" bgcolor="#FFFFFF">1,282 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,303 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-50,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">650,500</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -109,500)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -271,000)</td><td align="right" bgcolor="#FFFFFF">270,000</td><td align="right" bgcolor="#FFFFFF">270,000</td><td align="right" bgcolor="#FFFFFF">270,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,635</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,107)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,265)</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#FFFFFF">0,264</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 167,379 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">886,027 ns</td><td align="right" bgcolor="#FFFFFF">718,647 ns</td><td align="right" bgcolor="#FFFFFF">726,897 ns</td><td align="right" bgcolor="#FFFFFF">723,089 ns</td><td align="right" bgcolor="#FFFFFF">734,498 ns</td><td align="right" bgcolor="#FFFFFF">729,941 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,886 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,734 μs</td><td align="right" bgcolor="#FFFFFF">0,730 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -164,000)</td><td align="right" bgcolor="#A8D08D">279,000 (Δ = -278,000)</td><td align="right" bgcolor="#FFFFFF">279,000</td><td align="right" bgcolor="#FFFFFF">279,000</td><td align="right" bgcolor="#FFFFFF">279,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,160)</td><td align="right" bgcolor="#A8D08D">0,272 (Δ = -0,271)</td><td align="right" bgcolor="#FFFFFF">0,272</td><td align="right" bgcolor="#FFFFFF">0,272</td><td align="right" bgcolor="#FFFFFF">0,272</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 25,949 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">189,057 ns</td><td align="right" bgcolor="#FFFFFF">165,222 ns</td><td align="right" bgcolor="#FFFFFF">163,108 ns</td><td align="right" bgcolor="#FFFFFF">163,544 ns</td><td align="right" bgcolor="#FFFFFF">169,770 ns</td><td align="right" bgcolor="#FFFFFF">175,180 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,008</td><td align="right" bgcolor="#FFFFFF">0,008</td><td align="right" bgcolor="#FFFFFF">0,008</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 71,558 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">760,524 ns</td><td align="right" bgcolor="#FFFFFF">746,355 ns</td><td align="right" bgcolor="#FFFFFF">742,925 ns</td><td align="right" bgcolor="#FFFFFF">688,966 ns</td><td align="right" bgcolor="#FFFFFF">690,343 ns</td><td align="right" bgcolor="#FFFFFF">705,185 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,761 μs</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">0,743 μs</td><td align="right" bgcolor="#FFFFFF">0,689 μs</td><td align="right" bgcolor="#FFFFFF">0,690 μs</td><td align="right" bgcolor="#FFFFFF">0,705 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 21,403 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">133,888 ns</td><td align="right" bgcolor="#FFFFFF">132,437 ns</td><td align="right" bgcolor="#FFFFFF">128,503 ns</td><td align="right" bgcolor="#FFFFFF">128,612 ns</td><td align="right" bgcolor="#FFFFFF">133,100 ns</td><td align="right" bgcolor="#FFFFFF">149,905 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 357,292 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2789,521 ns</td><td align="right" bgcolor="#A8D08D">2458,948 ns (Δ = -330,573 ns)</td><td align="right" bgcolor="#FFFFFF">2432,229 ns</td><td align="right" bgcolor="#FFFFFF">2470,975 ns</td><td align="right" bgcolor="#FFFFFF">2478,313 ns</td><td align="right" bgcolor="#FFFFFF">2477,070 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,790 μs</td><td align="right" bgcolor="#FFFFFF">2,459 μs</td><td align="right" bgcolor="#FFFFFF">2,432 μs</td><td align="right" bgcolor="#FFFFFF">2,471 μs</td><td align="right" bgcolor="#FFFFFF">2,478 μs</td><td align="right" bgcolor="#FFFFFF">2,477 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 84,345 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">172,040 ns</td><td align="right" bgcolor="#FFFFFF">172,888 ns</td><td align="right" bgcolor="#FFFFFF">250,876 ns</td><td align="right" bgcolor="#FFFFFF">252,995 ns</td><td align="right" bgcolor="#FFFFFF">252,956 ns</td><td align="right" bgcolor="#FFFFFF">256,385 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,173 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 2,907 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,730 ns</td><td align="right" bgcolor="#FFFFFF">11,740 ns</td><td align="right" bgcolor="#FFFFFF">14,103 ns</td><td align="right" bgcolor="#FFFFFF">14,356 ns</td><td align="right" bgcolor="#FFFFFF">14,637 ns</td><td align="right" bgcolor="#FFFFFF">14,537 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 9,212 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,707 ns</td><td align="right" bgcolor="#FFFFFF">32,143 ns</td><td align="right" bgcolor="#FFFFFF">41,354 ns</td><td align="right" bgcolor="#FFFFFF">40,177 ns</td><td align="right" bgcolor="#FFFFFF">40,182 ns</td><td align="right" bgcolor="#FFFFFF">41,202 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 12,104 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,552 ns</td><td align="right" bgcolor="#FFFFFF">36,439 ns</td><td align="right" bgcolor="#FFFFFF">48,543 ns</td><td align="right" bgcolor="#FFFFFF">47,270 ns</td><td align="right" bgcolor="#FFFFFF">46,952 ns</td><td align="right" bgcolor="#FFFFFF">47,678 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,138 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,368 ns</td><td align="right" bgcolor="#FFFFFF">32,293 ns</td><td align="right" bgcolor="#FFFFFF">39,753 ns</td><td align="right" bgcolor="#FFFFFF">39,648 ns</td><td align="right" bgcolor="#FFFFFF">40,431 ns</td><td align="right" bgcolor="#FFFFFF">40,307 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 2,430 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,775 ns</td><td align="right" bgcolor="#FFFFFF">14,730 ns</td><td align="right" bgcolor="#FFFFFF">12,809 ns</td><td align="right" bgcolor="#FFFFFF">12,586 ns</td><td align="right" bgcolor="#FFFFFF">12,457 ns</td><td align="right" bgcolor="#FFFFFF">12,345 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 1,256 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,635 ns</td><td align="right" bgcolor="#FFFFFF">20,056 ns</td><td align="right" bgcolor="#FFFFFF">20,891 ns</td><td align="right" bgcolor="#FFFFFF">20,307 ns</td><td align="right" bgcolor="#FFFFFF">20,132 ns</td><td align="right" bgcolor="#FFFFFF">20,052 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 7,925 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,558 ns</td><td align="right" bgcolor="#FFFFFF">25,013 ns</td><td align="right" bgcolor="#FFFFFF">32,344 ns</td><td align="right" bgcolor="#FFFFFF">31,382 ns</td><td align="right" bgcolor="#FFFFFF">30,943 ns</td><td align="right" bgcolor="#FFFFFF">32,937 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 92,845 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">446,853 ns</td><td align="right" bgcolor="#FFFFFF">443,648 ns</td><td align="right" bgcolor="#FFFFFF">515,555 ns</td><td align="right" bgcolor="#FFFFFF">507,967 ns</td><td align="right" bgcolor="#FFFFFF">519,532 ns</td><td align="right" bgcolor="#FFFFFF">536,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td><td align="right" bgcolor="#FFFFFF">0,508 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 59,055 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,545 ns</td><td align="right" bgcolor="#FFFFFF">174,363 ns</td><td align="right" bgcolor="#FFFFFF">208,800 ns</td><td align="right" bgcolor="#FFFFFF">209,600 ns</td><td align="right" bgcolor="#FFFFFF">208,058 ns</td><td align="right" bgcolor="#FFFFFF">208,830 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 1,023 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,766 ns</td><td align="right" bgcolor="#FFFFFF">25,901 ns</td><td align="right" bgcolor="#FFFFFF">26,515 ns</td><td align="right" bgcolor="#FFFFFF">26,460 ns</td><td align="right" bgcolor="#FFFFFF">26,518 ns</td><td align="right" bgcolor="#FFFFFF">26,788 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 8,803 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,862 ns</td><td align="right" bgcolor="#FFFFFF">29,048 ns</td><td align="right" bgcolor="#FFFFFF">37,528 ns</td><td align="right" bgcolor="#FFFFFF">36,934 ns</td><td align="right" bgcolor="#FFFFFF">36,565 ns</td><td align="right" bgcolor="#FFFFFF">37,852 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 2,948 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,949 ns</td><td align="right" bgcolor="#FFFFFF">8,518 ns</td><td align="right" bgcolor="#FFFFFF">10,423 ns</td><td align="right" bgcolor="#FFFFFF">10,857 ns</td><td align="right" bgcolor="#FFFFFF">10,072 ns</td><td align="right" bgcolor="#FFFFFF">11,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1,796 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,518 ns</td><td align="right" bgcolor="#FFFFFF">9,656 ns</td><td align="right" bgcolor="#FFFFFF">10,873 ns</td><td align="right" bgcolor="#FFFFFF">11,313 ns</td><td align="right" bgcolor="#FFFFFF">10,928 ns</td><td align="right" bgcolor="#FFFFFF">10,468 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 20610,271 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,8 %</td><td align="right" bgcolor="#A8D08D">-11,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35244,848 ns</td><td align="right" bgcolor="#A8D08D">16649,516 ns (Δ = -18595,332 ns)</td><td align="right" bgcolor="#A8D08D">14743,688 ns (Δ = -1905,828 ns)</td><td align="right" bgcolor="#FFFFFF">14634,577 ns</td><td align="right" bgcolor="#FF4949">15308,000 ns (Δ = +673,423 ns)</td><td align="right" bgcolor="#FFFFFF">15163,747 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">35,245 μs</td><td align="right" bgcolor="#FFFFFF">16,650 μs</td><td align="right" bgcolor="#FFFFFF">14,744 μs</td><td align="right" bgcolor="#FFFFFF">14,635 μs</td><td align="right" bgcolor="#FFFFFF">15,308 μs</td><td align="right" bgcolor="#FFFFFF">15,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7704,000</td><td align="right" bgcolor="#A8D08D">5786,000 (Δ = -1918,000)</td><td align="right" bgcolor="#A8D08D">3093,000 (Δ = -2693,000)</td><td align="right" bgcolor="#FFFFFF">3093,000</td><td align="right" bgcolor="#FF4949">3273,000 (Δ = +180,000)</td><td align="right" bgcolor="#FFFFFF">3273,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,523</td><td align="right" bgcolor="#A8D08D">5,650 (Δ = -1,873)</td><td align="right" bgcolor="#A8D08D">3,021 (Δ = -2,630)</td><td align="right" bgcolor="#FFFFFF">3,021</td><td align="right" bgcolor="#FF4949">3,196 (Δ = +0,176)</td><td align="right" bgcolor="#FFFFFF">3,196</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 2,503 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,183 ns</td><td align="right" bgcolor="#FFFFFF">11,000 ns</td><td align="right" bgcolor="#FFFFFF">12,603 ns</td><td align="right" bgcolor="#FFFFFF">12,615 ns</td><td align="right" bgcolor="#FFFFFF">12,751 ns</td><td align="right" bgcolor="#FFFFFF">13,503 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 2,703 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,994 ns</td><td align="right" bgcolor="#FFFFFF">14,693 ns</td><td align="right" bgcolor="#FFFFFF">13,673 ns</td><td align="right" bgcolor="#FFFFFF">12,968 ns</td><td align="right" bgcolor="#FFFFFF">12,623 ns</td><td align="right" bgcolor="#FFFFFF">12,292 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1,903 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,021 ns</td><td align="right" bgcolor="#FFFFFF">13,758 ns</td><td align="right" bgcolor="#FFFFFF">14,797 ns</td><td align="right" bgcolor="#FFFFFF">14,403 ns</td><td align="right" bgcolor="#FFFFFF">14,417 ns</td><td align="right" bgcolor="#FFFFFF">15,660 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,392 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,859 ns</td><td align="right" bgcolor="#FFFFFF">14,594 ns</td><td align="right" bgcolor="#FFFFFF">12,903 ns</td><td align="right" bgcolor="#FFFFFF">12,467 ns</td><td align="right" bgcolor="#FFFFFF">13,202 ns</td><td align="right" bgcolor="#FFFFFF">12,510 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 2,532 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,360 ns</td><td align="right" bgcolor="#FFFFFF">15,496 ns</td><td align="right" bgcolor="#FFFFFF">14,223 ns</td><td align="right" bgcolor="#FFFFFF">14,041 ns</td><td align="right" bgcolor="#FFFFFF">14,060 ns</td><td align="right" bgcolor="#FFFFFF">13,828 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 10,572 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,946 ns</td><td align="right" bgcolor="#FFFFFF">36,051 ns</td><td align="right" bgcolor="#FFFFFF">45,581 ns</td><td align="right" bgcolor="#FFFFFF">44,952 ns</td><td align="right" bgcolor="#FFFFFF">45,411 ns</td><td align="right" bgcolor="#FFFFFF">46,623 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.3.0**

Slowest: 5.1.0

Δ: 672,321 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-64,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">876,931 ns</td><td align="right" bgcolor="#FFFFFF">892,798 ns</td><td align="right" bgcolor="#FFFFFF">1029,084 ns</td><td align="right" bgcolor="#FFFFFF">1001,556 ns</td><td align="right" bgcolor="#A8D08D">356,763 ns (Δ = -644,793 ns)</td><td align="right" bgcolor="#FFFFFF">359,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,877 μs</td><td align="right" bgcolor="#FFFFFF">0,893 μs</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,002 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-83,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -86,000)</td><td align="right" bgcolor="#FFFFFF">94,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -78,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,084)</td><td align="right" bgcolor="#FFFFFF">0,092</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,076)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 4,062 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,216 ns</td><td align="right" bgcolor="#FFFFFF">17,803 ns</td><td align="right" bgcolor="#FFFFFF">21,865 ns</td><td align="right" bgcolor="#FFFFFF">19,191 ns</td><td align="right" bgcolor="#FFFFFF">18,935 ns</td><td align="right" bgcolor="#FFFFFF">19,515 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 63,946 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,748 ns</td><td align="right" bgcolor="#FFFFFF">218,408 ns</td><td align="right" bgcolor="#FFFFFF">282,354 ns</td><td align="right" bgcolor="#FFFFFF">281,844 ns</td><td align="right" bgcolor="#FFFFFF">278,839 ns</td><td align="right" bgcolor="#FFFFFF">276,055 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,276 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 14,953 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,117 ns</td><td align="right" bgcolor="#FFFFFF">35,607 ns</td><td align="right" bgcolor="#FFFFFF">49,070 ns</td><td align="right" bgcolor="#FFFFFF">40,176 ns</td><td align="right" bgcolor="#FFFFFF">41,002 ns</td><td align="right" bgcolor="#FFFFFF">40,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 77,085 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,553 ns</td><td align="right" bgcolor="#FFFFFF">112,698 ns</td><td align="right" bgcolor="#FFFFFF">125,066 ns</td><td align="right" bgcolor="#FFFFFF">140,658 ns</td><td align="right" bgcolor="#FFFFFF">144,548 ns</td><td align="right" bgcolor="#FFFFFF">181,638 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 11,159 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,788 ns</td><td align="right" bgcolor="#FFFFFF">28,512 ns</td><td align="right" bgcolor="#FFFFFF">39,428 ns</td><td align="right" bgcolor="#FFFFFF">39,671 ns</td><td align="right" bgcolor="#FFFFFF">37,638 ns</td><td align="right" bgcolor="#FFFFFF">39,335 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 149,311 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">290,313 ns</td><td align="right" bgcolor="#FFFFFF">293,159 ns</td><td align="right" bgcolor="#FFFFFF">418,796 ns</td><td align="right" bgcolor="#FFFFFF">419,462 ns</td><td align="right" bgcolor="#FFFFFF">439,624 ns</td><td align="right" bgcolor="#FFFFFF">430,335 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,440 μs</td><td align="right" bgcolor="#FFFFFF">0,430 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 437,791 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,2 %</td><td align="right" bgcolor="#A8D08D">-13,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2184,123 ns</td><td align="right" bgcolor="#FF4949">2471,752 ns (Δ = +287,628 ns)</td><td align="right" bgcolor="#A8D08D">2131,517 ns (Δ = -340,235 ns)</td><td align="right" bgcolor="#FFFFFF">2072,478 ns</td><td align="right" bgcolor="#FFFFFF">2078,918 ns</td><td align="right" bgcolor="#FFFFFF">2033,961 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,184 μs</td><td align="right" bgcolor="#FFFFFF">2,472 μs</td><td align="right" bgcolor="#FFFFFF">2,132 μs</td><td align="right" bgcolor="#FFFFFF">2,072 μs</td><td align="right" bgcolor="#FFFFFF">2,079 μs</td><td align="right" bgcolor="#FFFFFF">2,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,1 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">864,000</td><td align="right" bgcolor="#FF4949">1020,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">643,000 (Δ = -377,000)</td><td align="right" bgcolor="#FFFFFF">643,000</td><td align="right" bgcolor="#FFFFFF">643,000</td><td align="right" bgcolor="#FFFFFF">643,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,844</td><td align="right" bgcolor="#FF4949">0,996 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,628 (Δ = -0,368)</td><td align="right" bgcolor="#FFFFFF">0,628</td><td align="right" bgcolor="#FFFFFF">0,628</td><td align="right" bgcolor="#FFFFFF">0,628</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 547,978 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2301,847 ns</td><td align="right" bgcolor="#FFFFFF">2527,947 ns</td><td align="right" bgcolor="#A8D08D">2037,196 ns (Δ = -490,751 ns)</td><td align="right" bgcolor="#FFFFFF">2153,872 ns</td><td align="right" bgcolor="#FFFFFF">2103,916 ns</td><td align="right" bgcolor="#FFFFFF">1979,968 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,302 μs</td><td align="right" bgcolor="#FFFFFF">2,528 μs</td><td align="right" bgcolor="#FFFFFF">2,037 μs</td><td align="right" bgcolor="#FFFFFF">2,154 μs</td><td align="right" bgcolor="#FFFFFF">2,104 μs</td><td align="right" bgcolor="#FFFFFF">1,980 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,2 %</td><td align="right" bgcolor="#A8D08D">-36,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">856,000</td><td align="right" bgcolor="#FF4949">1012,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">639,000 (Δ = -373,000)</td><td align="right" bgcolor="#FFFFFF">639,000</td><td align="right" bgcolor="#FFFFFF">639,000</td><td align="right" bgcolor="#FFFFFF">639,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,836</td><td align="right" bgcolor="#FF4949">0,988 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,624 (Δ = -0,364)</td><td align="right" bgcolor="#FFFFFF">0,624</td><td align="right" bgcolor="#FFFFFF">0,624</td><td align="right" bgcolor="#FFFFFF">0,624</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 387,168 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,7 %</td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2652,612 ns</td><td align="right" bgcolor="#FF4949">2935,499 ns (Δ = +282,888 ns)</td><td align="right" bgcolor="#A8D08D">2592,148 ns (Δ = -343,352 ns)</td><td align="right" bgcolor="#FFFFFF">2668,161 ns</td><td align="right" bgcolor="#FFFFFF">2625,228 ns</td><td align="right" bgcolor="#FFFFFF">2548,332 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,653 μs</td><td align="right" bgcolor="#FFFFFF">2,935 μs</td><td align="right" bgcolor="#FFFFFF">2,592 μs</td><td align="right" bgcolor="#FFFFFF">2,668 μs</td><td align="right" bgcolor="#FFFFFF">2,625 μs</td><td align="right" bgcolor="#FFFFFF">2,548 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,9 %</td><td align="right" bgcolor="#A8D08D">-30,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1274,000</td><td align="right" bgcolor="#FF4949">1425,000 (Δ = +151,000)</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -430,000)</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td><td align="right" bgcolor="#FFFFFF">995,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,244</td><td align="right" bgcolor="#FF4949">1,392 (Δ = +0,147)</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,420)</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td><td align="right" bgcolor="#FFFFFF">0,972</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 313,293 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#A8D08D">-8,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3070,849 ns</td><td align="right" bgcolor="#FF4949">3339,493 ns (Δ = +268,644 ns)</td><td align="right" bgcolor="#A8D08D">3058,731 ns (Δ = -280,763 ns)</td><td align="right" bgcolor="#FFFFFF">3026,201 ns</td><td align="right" bgcolor="#FFFFFF">3195,871 ns</td><td align="right" bgcolor="#FFFFFF">3071,413 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,071 μs</td><td align="right" bgcolor="#FFFFFF">3,339 μs</td><td align="right" bgcolor="#FFFFFF">3,059 μs</td><td align="right" bgcolor="#FFFFFF">3,026 μs</td><td align="right" bgcolor="#FFFFFF">3,196 μs</td><td align="right" bgcolor="#FFFFFF">3,071 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,3 %</td><td align="right" bgcolor="#A8D08D">-32,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1481,500</td><td align="right" bgcolor="#FF4949">1634,000 (Δ = +152,500)</td><td align="right" bgcolor="#A8D08D">1106,000 (Δ = -528,000)</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,447</td><td align="right" bgcolor="#FF4949">1,596 (Δ = +0,149)</td><td align="right" bgcolor="#A8D08D">1,080 (Δ = -0,516)</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 18,831 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,780 ns</td><td align="right" bgcolor="#FFFFFF">104,580 ns</td><td align="right" bgcolor="#FFFFFF">121,277 ns</td><td align="right" bgcolor="#FFFFFF">123,411 ns</td><td align="right" bgcolor="#FFFFFF">118,511 ns</td><td align="right" bgcolor="#FFFFFF">118,038 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 19,826 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">111,998 ns</td><td align="right" bgcolor="#FFFFFF">103,897 ns</td><td align="right" bgcolor="#FFFFFF">119,743 ns</td><td align="right" bgcolor="#FFFFFF">119,723 ns</td><td align="right" bgcolor="#FFFFFF">118,657 ns</td><td align="right" bgcolor="#FFFFFF">123,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 541,527 ns


<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2678,605 ns</td><td align="right" bgcolor="#FF4949">3117,144 ns (Δ = +438,539 ns)</td><td align="right" bgcolor="#FFFFFF">3220,132 ns</td><td align="right" bgcolor="#FFFFFF">3131,656 ns</td><td align="right" bgcolor="#FFFFFF">3117,033 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,679 μs</td><td align="right" bgcolor="#FFFFFF">3,117 μs</td><td align="right" bgcolor="#FFFFFF">3,220 μs</td><td align="right" bgcolor="#FFFFFF">3,132 μs</td><td align="right" bgcolor="#FFFFFF">3,117 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">971,000</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,948</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 22,286 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">229,712 ns</td><td align="right" bgcolor="#FFFFFF">210,768 ns</td><td align="right" bgcolor="#FFFFFF">229,731 ns</td><td align="right" bgcolor="#FFFFFF">219,818 ns</td><td align="right" bgcolor="#FFFFFF">213,568 ns</td><td align="right" bgcolor="#FFFFFF">207,445 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 34,845 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,153 ns</td><td align="right" bgcolor="#FFFFFF">194,141 ns</td><td align="right" bgcolor="#FFFFFF">226,998 ns</td><td align="right" bgcolor="#FFFFFF">208,326 ns</td><td align="right" bgcolor="#FFFFFF">214,948 ns</td><td align="right" bgcolor="#FFFFFF">205,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 37,559 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">215,836 ns</td><td align="right" bgcolor="#FFFFFF">231,445 ns</td><td align="right" bgcolor="#FFFFFF">229,576 ns</td><td align="right" bgcolor="#FFFFFF">231,408 ns</td><td align="right" bgcolor="#FFFFFF">253,395 ns</td><td align="right" bgcolor="#FFFFFF">226,447 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 26,390 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,528 ns</td><td align="right" bgcolor="#FFFFFF">206,198 ns</td><td align="right" bgcolor="#FFFFFF">219,918 ns</td><td align="right" bgcolor="#FFFFFF">210,285 ns</td><td align="right" bgcolor="#FFFFFF">217,428 ns</td><td align="right" bgcolor="#FFFFFF">204,610 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 46,884 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">200,996 ns</td><td align="right" bgcolor="#FFFFFF">216,260 ns</td><td align="right" bgcolor="#FFFFFF">208,134 ns</td><td align="right" bgcolor="#FFFFFF">247,880 ns</td><td align="right" bgcolor="#FFFFFF">218,587 ns</td><td align="right" bgcolor="#FFFFFF">203,515 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 106,856 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">975,741 ns</td><td align="right" bgcolor="#FFFFFF">1024,385 ns</td><td align="right" bgcolor="#FFFFFF">1067,232 ns</td><td align="right" bgcolor="#FFFFFF">1082,597 ns</td><td align="right" bgcolor="#FFFFFF">1069,603 ns</td><td align="right" bgcolor="#FFFFFF">1076,312 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,976 μs</td><td align="right" bgcolor="#FFFFFF">1,024 μs</td><td align="right" bgcolor="#FFFFFF">1,067 μs</td><td align="right" bgcolor="#FFFFFF">1,083 μs</td><td align="right" bgcolor="#FFFFFF">1,070 μs</td><td align="right" bgcolor="#FFFFFF">1,076 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 104,977 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">985,726 ns</td><td align="right" bgcolor="#FFFFFF">1006,723 ns</td><td align="right" bgcolor="#FFFFFF">1090,702 ns</td><td align="right" bgcolor="#FFFFFF">1075,036 ns</td><td align="right" bgcolor="#FFFFFF">1065,170 ns</td><td align="right" bgcolor="#FFFFFF">1036,842 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,986 μs</td><td align="right" bgcolor="#FFFFFF">1,007 μs</td><td align="right" bgcolor="#FFFFFF">1,091 μs</td><td align="right" bgcolor="#FFFFFF">1,075 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,037 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 35,841 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">237,249 ns</td><td align="right" bgcolor="#FFFFFF">255,092 ns</td><td align="right" bgcolor="#FFFFFF">259,948 ns</td><td align="right" bgcolor="#FFFFFF">265,166 ns</td><td align="right" bgcolor="#FFFFFF">273,090 ns</td><td align="right" bgcolor="#FFFFFF">245,393 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 41,315 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">233,770 ns</td><td align="right" bgcolor="#FFFFFF">260,483 ns</td><td align="right" bgcolor="#FFFFFF">245,257 ns</td><td align="right" bgcolor="#FFFFFF">275,085 ns</td><td align="right" bgcolor="#FFFFFF">259,379 ns</td><td align="right" bgcolor="#FFFFFF">243,848 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,275 μs</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 29,271 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">251,602 ns</td><td align="right" bgcolor="#FFFFFF">264,763 ns</td><td align="right" bgcolor="#FFFFFF">280,873 ns</td><td align="right" bgcolor="#FFFFFF">277,882 ns</td><td align="right" bgcolor="#FFFFFF">277,358 ns</td><td align="right" bgcolor="#FFFFFF">263,718 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,281 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 39,527 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,797 ns</td><td align="right" bgcolor="#FFFFFF">217,825 ns</td><td align="right" bgcolor="#FFFFFF">246,323 ns</td><td align="right" bgcolor="#FFFFFF">231,902 ns</td><td align="right" bgcolor="#FFFFFF">226,144 ns</td><td align="right" bgcolor="#FFFFFF">213,665 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 15,697 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">213,953 ns</td><td align="right" bgcolor="#FFFFFF">218,106 ns</td><td align="right" bgcolor="#FFFFFF">218,878 ns</td><td align="right" bgcolor="#FFFFFF">229,650 ns</td><td align="right" bgcolor="#FFFFFF">226,907 ns</td><td align="right" bgcolor="#FFFFFF">217,000 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 104,481 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">499,968 ns</td><td align="right" bgcolor="#FFFFFF">546,411 ns</td><td align="right" bgcolor="#FFFFFF">604,448 ns</td><td align="right" bgcolor="#FFFFFF">578,982 ns</td><td align="right" bgcolor="#FFFFFF">574,972 ns</td><td align="right" bgcolor="#FFFFFF">527,898 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,546 μs</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td><td align="right" bgcolor="#FFFFFF">0,579 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,528 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">193,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 96,282 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">918,197 ns</td><td align="right" bgcolor="#FFFFFF">929,411 ns</td><td align="right" bgcolor="#FFFFFF">1003,636 ns</td><td align="right" bgcolor="#FFFFFF">1014,478 ns</td><td align="right" bgcolor="#FFFFFF">1004,779 ns</td><td align="right" bgcolor="#FFFFFF">983,150 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,918 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">1,004 μs</td><td align="right" bgcolor="#FFFFFF">1,014 μs</td><td align="right" bgcolor="#FFFFFF">1,005 μs</td><td align="right" bgcolor="#FFFFFF">0,983 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 104,641 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">912,420 ns</td><td align="right" bgcolor="#FFFFFF">926,404 ns</td><td align="right" bgcolor="#FFFFFF">965,303 ns</td><td align="right" bgcolor="#FFFFFF">1017,061 ns</td><td align="right" bgcolor="#FFFFFF">1011,773 ns</td><td align="right" bgcolor="#FFFFFF">977,483 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,912 μs</td><td align="right" bgcolor="#FFFFFF">0,926 μs</td><td align="right" bgcolor="#FFFFFF">0,965 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">0,977 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 33,144 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">235,386 ns</td><td align="right" bgcolor="#FFFFFF">237,237 ns</td><td align="right" bgcolor="#FFFFFF">262,052 ns</td><td align="right" bgcolor="#FFFFFF">265,089 ns</td><td align="right" bgcolor="#FFFFFF">266,437 ns</td><td align="right" bgcolor="#FFFFFF">268,530 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,262 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 35,609 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">210,118 ns</td><td align="right" bgcolor="#FFFFFF">223,963 ns</td><td align="right" bgcolor="#FFFFFF">245,728 ns</td><td align="right" bgcolor="#FFFFFF">232,232 ns</td><td align="right" bgcolor="#FFFFFF">236,363 ns</td><td align="right" bgcolor="#FFFFFF">219,267 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 153,011 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">328,744 ns</td><td align="right" bgcolor="#FFFFFF">348,938 ns</td><td align="right" bgcolor="#FFFFFF">480,565 ns</td><td align="right" bgcolor="#FFFFFF">474,543 ns</td><td align="right" bgcolor="#FFFFFF">481,755 ns</td><td align="right" bgcolor="#FFFFFF">476,812 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,475 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,477 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,653 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,423 ns</td><td align="right" bgcolor="#FFFFFF">7,017 ns</td><td align="right" bgcolor="#FFFFFF">7,027 ns</td><td align="right" bgcolor="#FFFFFF">6,816 ns</td><td align="right" bgcolor="#FFFFFF">6,771 ns</td><td align="right" bgcolor="#FFFFFF">7,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 0,662 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,408 ns</td><td align="right" bgcolor="#FFFFFF">7,363 ns</td><td align="right" bgcolor="#FFFFFF">6,747 ns</td><td align="right" bgcolor="#FFFFFF">6,758 ns</td><td align="right" bgcolor="#FFFFFF">6,782 ns</td><td align="right" bgcolor="#FFFFFF">7,095 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,713 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,563 ns</td><td align="right" bgcolor="#FFFFFF">7,516 ns</td><td align="right" bgcolor="#FFFFFF">6,904 ns</td><td align="right" bgcolor="#FFFFFF">6,849 ns</td><td align="right" bgcolor="#FFFFFF">7,375 ns</td><td align="right" bgcolor="#FFFFFF">7,165 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,719 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,431 ns</td><td align="right" bgcolor="#FFFFFF">7,283 ns</td><td align="right" bgcolor="#FFFFFF">6,784 ns</td><td align="right" bgcolor="#FFFFFF">7,043 ns</td><td align="right" bgcolor="#FFFFFF">6,712 ns</td><td align="right" bgcolor="#FFFFFF">6,968 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,058 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,070 ns</td><td align="right" bgcolor="#FFFFFF">0,027 ns</td><td align="right" bgcolor="#FFFFFF">0,020 ns</td><td align="right" bgcolor="#FFFFFF">0,013 ns</td><td align="right" bgcolor="#FFFFFF">0,011 ns</td><td align="right" bgcolor="#FFFFFF">0,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 0,053 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,036 ns</td><td align="right" bgcolor="#FFFFFF">0,039 ns</td><td align="right" bgcolor="#FFFFFF">0,009 ns</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#FFFFFF">0,017 ns</td><td align="right" bgcolor="#FFFFFF">0,062 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 0,251 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,601 ns</td><td align="right" bgcolor="#FFFFFF">0,589 ns</td><td align="right" bgcolor="#FFFFFF">0,578 ns</td><td align="right" bgcolor="#FFFFFF">0,643 ns</td><td align="right" bgcolor="#FFFFFF">0,640 ns</td><td align="right" bgcolor="#FFFFFF">0,828 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 0,029 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,024 ns</td><td align="right" bgcolor="#FFFFFF">0,025 ns</td><td align="right" bgcolor="#FFFFFF">0,037 ns</td><td align="right" bgcolor="#FFFFFF">0,012 ns</td><td align="right" bgcolor="#FFFFFF">0,039 ns</td><td align="right" bgcolor="#FFFFFF">0,009 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 5.2.0

Δ: 0,045 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,018 ns</td><td align="right" bgcolor="#FFFFFF">0,035 ns</td><td align="right" bgcolor="#FFFFFF">0,039 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,003 ns</td><td align="right" bgcolor="#FFFFFF">0,015 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 0,056 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,646 ns</td><td align="right" bgcolor="#FFFFFF">0,608 ns</td><td align="right" bgcolor="#FFFFFF">0,660 ns</td><td align="right" bgcolor="#FFFFFF">0,661 ns</td><td align="right" bgcolor="#FFFFFF">0,609 ns</td><td align="right" bgcolor="#FFFFFF">0,605 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 123,222 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">935,788 ns</td><td align="right" bgcolor="#FFFFFF">987,517 ns</td><td align="right" bgcolor="#FFFFFF">1050,045 ns</td><td align="right" bgcolor="#FFFFFF">1059,011 ns</td><td align="right" bgcolor="#FFFFFF">985,368 ns</td><td align="right" bgcolor="#FFFFFF">993,688 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,988 μs</td><td align="right" bgcolor="#FFFFFF">1,050 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#A8D08D">426,000 (Δ = -311,000)</td><td align="right" bgcolor="#FFFFFF">426,000</td><td align="right" bgcolor="#FFFFFF">426,000</td><td align="right" bgcolor="#FFFFFF">426,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#A8D08D">0,416 (Δ = -0,304)</td><td align="right" bgcolor="#FFFFFF">0,416</td><td align="right" bgcolor="#FFFFFF">0,416</td><td align="right" bgcolor="#FFFFFF">0,416</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 15265,004 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,1 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29689,834 ns</td><td align="right" bgcolor="#A8D08D">16595,309 ns (Δ = -13094,525 ns)</td><td align="right" bgcolor="#A8D08D">14424,830 ns (Δ = -2170,479 ns)</td><td align="right" bgcolor="#FFFFFF">14464,269 ns</td><td align="right" bgcolor="#FF4949">15141,953 ns (Δ = +677,684 ns)</td><td align="right" bgcolor="#FFFFFF">14969,758 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">29,690 μs</td><td align="right" bgcolor="#FFFFFF">16,595 μs</td><td align="right" bgcolor="#FFFFFF">14,425 μs</td><td align="right" bgcolor="#FFFFFF">14,464 μs</td><td align="right" bgcolor="#FFFFFF">15,142 μs</td><td align="right" bgcolor="#FFFFFF">14,970 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7419,500</td><td align="right" bgcolor="#A8D08D">5707,500 (Δ = -1712,000)</td><td align="right" bgcolor="#A8D08D">3056,000 (Δ = -2651,500)</td><td align="right" bgcolor="#FFFFFF">3056,000</td><td align="right" bgcolor="#FF4949">3236,000 (Δ = +180,000)</td><td align="right" bgcolor="#FFFFFF">3236,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,246</td><td align="right" bgcolor="#A8D08D">5,574 (Δ = -1,672)</td><td align="right" bgcolor="#A8D08D">2,984 (Δ = -2,589)</td><td align="right" bgcolor="#FFFFFF">2,984</td><td align="right" bgcolor="#FF4949">3,160 (Δ = +0,176)</td><td align="right" bgcolor="#FFFFFF">3,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td></tr></table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1209,849 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+963,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">115,761 ns</td><td align="right" bgcolor="#FF4949">1231,015 ns (Δ = +1115,254 ns)</td><td align="right" bgcolor="#FFFFFF">1269,262 ns</td><td align="right" bgcolor="#FFFFFF">1325,610 ns</td><td align="right" bgcolor="#FFFFFF">1295,370 ns</td><td align="right" bgcolor="#FFFFFF">1306,798 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">1,231 μs</td><td align="right" bgcolor="#FFFFFF">1,269 μs</td><td align="right" bgcolor="#FFFFFF">1,326 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td><td align="right" bgcolor="#FFFFFF">1,307 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+151,9 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FF4949">393,000 (Δ = +237,000)</td><td align="right" bgcolor="#A8D08D">205,000 (Δ = -188,000)</td><td align="right" bgcolor="#FFFFFF">205,000</td><td align="right" bgcolor="#FFFFFF">205,000</td><td align="right" bgcolor="#FFFFFF">205,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FF4949">0,384 (Δ = +0,231)</td><td align="right" bgcolor="#A8D08D">0,200 (Δ = -0,184)</td><td align="right" bgcolor="#FFFFFF">0,200</td><td align="right" bgcolor="#FFFFFF">0,200</td><td align="right" bgcolor="#FFFFFF">0,200</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1131,638 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3792,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,508 ns</td><td align="right" bgcolor="#FF4949">1031,791 ns (Δ = +1005,283 ns)</td><td align="right" bgcolor="#FFFFFF">1130,695 ns</td><td align="right" bgcolor="#FFFFFF">1158,147 ns</td><td align="right" bgcolor="#FFFFFF">1146,753 ns</td><td align="right" bgcolor="#FFFFFF">1130,727 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">1,032 μs</td><td align="right" bgcolor="#FFFFFF">1,131 μs</td><td align="right" bgcolor="#FFFFFF">1,158 μs</td><td align="right" bgcolor="#FFFFFF">1,147 μs</td><td align="right" bgcolor="#FFFFFF">1,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 2,743 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,713 ns</td><td align="right" bgcolor="#FFFFFF">4,721 ns</td><td align="right" bgcolor="#FFFFFF">2,155 ns</td><td align="right" bgcolor="#FFFFFF">2,142 ns</td><td align="right" bgcolor="#FFFFFF">1,978 ns</td><td align="right" bgcolor="#FFFFFF">2,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3060,402 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,8 %</td><td align="right" bgcolor="#A8D08D">-8,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16277,092 ns</td><td align="right" bgcolor="#FF4949">19337,493 ns (Δ = +3060,402 ns)</td><td align="right" bgcolor="#A8D08D">17760,278 ns (Δ = -1577,215 ns)</td><td align="right" bgcolor="#FFFFFF">17807,948 ns</td><td align="right" bgcolor="#FFFFFF">17828,583 ns</td><td align="right" bgcolor="#FFFFFF">17923,157 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">16,277 μs</td><td align="right" bgcolor="#FFFFFF">19,337 μs</td><td align="right" bgcolor="#FFFFFF">17,760 μs</td><td align="right" bgcolor="#FFFFFF">17,808 μs</td><td align="right" bgcolor="#FFFFFF">17,829 μs</td><td align="right" bgcolor="#FFFFFF">17,923 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,4 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1203,000</td><td align="right" bgcolor="#FF4949">1460,500 (Δ = +257,500)</td><td align="right" bgcolor="#A8D08D">735,000 (Δ = -725,500)</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,175</td><td align="right" bgcolor="#FF4949">1,426 (Δ = +0,251)</td><td align="right" bgcolor="#A8D08D">0,718 (Δ = -0,708)</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3817,584 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#A8D08D">-11,8 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17348,877 ns</td><td align="right" bgcolor="#FF4949">21166,461 ns (Δ = +3817,584 ns)</td><td align="right" bgcolor="#A8D08D">18663,737 ns (Δ = -2502,724 ns)</td><td align="right" bgcolor="#A8D08D">18389,658 ns (Δ = -274,079 ns)</td><td align="right" bgcolor="#FFFFFF">18302,477 ns</td><td align="right" bgcolor="#FFFFFF">18304,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,349 μs</td><td align="right" bgcolor="#FFFFFF">21,166 μs</td><td align="right" bgcolor="#FFFFFF">18,664 μs</td><td align="right" bgcolor="#FFFFFF">18,390 μs</td><td align="right" bgcolor="#FFFFFF">18,302 μs</td><td align="right" bgcolor="#FFFFFF">18,305 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,4 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1203,000</td><td align="right" bgcolor="#FF4949">1460,500 (Δ = +257,500)</td><td align="right" bgcolor="#A8D08D">735,000 (Δ = -725,500)</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td><td align="right" bgcolor="#FFFFFF">735,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,175</td><td align="right" bgcolor="#FF4949">1,426 (Δ = +0,251)</td><td align="right" bgcolor="#A8D08D">0,718 (Δ = -0,708)</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td><td align="right" bgcolor="#FFFFFF">0,718</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


