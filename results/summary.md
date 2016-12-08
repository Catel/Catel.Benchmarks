# Benchmarks

Benchmark report generated on 08-dec-2016 09:30

Running the benchmarks took 01:03:14.9146947

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.

## Host environment information

BenchmarkDotNet=v0.10.0-develop

OS=Microsoft Windows NT 6.2.9200.0

Processor=Intel(R) Core(TM) i7-3960X CPU 3.30GHz, ProcessorCount=8

Frequency=3222557 Hz, Resolution=310.3126 ns, Timer=TSC

Host Runtime=Clr 4.0.30319.42000, Arch=32-bit RELEASE [AttachedDebugger]

GC=Concurrent Workstation

JitModules=clrjit-v4.6.1586.0


## Table of contents
* [CacheStorage_Benchmark](#CacheStorage_Benchmark)
  * [GetFromCacheOrFetch](#CacheStorage_Benchmark_GetFromCacheOrFetch)
  * [GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy](#CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy)
  * [GetValue_From_An_Already_Initialized_Cache](#CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache)
* [FastDateTime_vs_DateTime_Benchmark](#FastDateTime_vs_DateTime_Benchmark)
  * [DateTime_Now](#FastDateTime_vs_DateTime_Benchmark_DateTime_Now)
  * [FastDateTime_Now](#FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now)
* [FastDateTime_vs_DateTime_UtcNow_Benchmark](#FastDateTime_vs_DateTime_UtcNow_Benchmark)
  * [DateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow)
  * [FastDateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow)
* [Log_Disabled_Benchmark](#Log_Disabled_Benchmark)
  * [Log_Info](#Log_Disabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [Log_Enabled_Benchmark](#Log_Enabled_Benchmark)
  * [Log_Info](#Log_Enabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [ModelBase_GetValue_Benchmark](#ModelBase_GetValue_Benchmark)
  * [GetBoolValue](#ModelBase_GetValue_Benchmark_GetBoolValue)
  * [GetIntValue](#ModelBase_GetValue_Benchmark_GetIntValue)
  * [GetStringValue](#ModelBase_GetValue_Benchmark_GetStringValue)
* [ModelBase_SetValue_Benchmark](#ModelBase_SetValue_Benchmark)
  * [SetBoolValue](#ModelBase_SetValue_Benchmark_SetBoolValue)
  * [SetIntValue](#ModelBase_SetValue_Benchmark_SetIntValue)
  * [SetStringValue](#ModelBase_SetValue_Benchmark_SetStringValue)
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
* [ViewModelBase_Benchmark](#ViewModelBase_Benchmark)
  * [Construction](#ViewModelBase_Benchmark_Construction)

## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">122,227 ns</td><td align="right">143,395 ns</td><td align="right">142,636 ns</td><td align="right">275,208 ns</td><td align="right">269,129 ns</td><td align="right">267,717 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,122 μs</td><td align="right">0,143 μs</td><td align="right">0,143 μs</td><td align="right">0,275 μs</td><td align="right">0,269 μs</td><td align="right">0,268 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">130</td><td align="right">138</td><td align="right">130</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">136</td><td align="right">136</td><td align="right">136</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,133</td><td align="right">0,133</td><td align="right">0,133</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">123,160 ns</td><td align="right">145,383 ns</td><td align="right">145,735 ns</td><td align="right">276,027 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,123 μs</td><td align="right">0,145 μs</td><td align="right">0,146 μs</td><td align="right">0,276 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">122</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">136</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,133</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">96,416 ns</td><td align="right">105,332 ns</td><td align="right">105,555 ns</td><td align="right">234,141 ns</td><td align="right">237,502 ns</td><td align="right">232,719 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,096 μs</td><td align="right">0,105 μs</td><td align="right">0,106 μs</td><td align="right">0,234 μs</td><td align="right">0,238 μs</td><td align="right">0,233 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">101</td><td align="right">101</td><td align="right">85</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,117</td><td align="right">0,117</td><td align="right">0,117</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">301,905 ns</td><td align="right">301,933 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,302 μs</td><td align="right">0,302 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td>Allocated Bytes</td><td align="right">40</td><td align="right">40</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,039</td><td align="right">0,039</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">35,120 ns</td><td align="right">35,672 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,035 μs</td><td align="right">0,036 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">5,483 ns</td><td align="right">5,478 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,005 μs</td><td align="right">0,005 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">6,041 ns</td><td align="right">6,077 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,006 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">9,653 ns</td><td align="right">9,306 ns</td><td align="right">9,570 ns</td><td align="right">10,237 ns</td><td align="right">10,229 ns</td><td align="right">5,562 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,010 μs</td><td align="right">0,009 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Gen 0</td><td align="right">737</td><td align="right">1701</td><td align="right">1705</td><td align="right">749</td><td align="right">721</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">18,296 ns</td><td align="right">17,973 ns</td><td align="right">18,565 ns</td><td align="right">18,877 ns</td><td align="right">18,808 ns</td><td align="right">18,864 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td><td align="right">0,019 μs</td><td align="right">0,019 μs</td><td align="right">0,019 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Gen 0</td><td align="right">2031</td><td align="right">2027</td><td align="right">2043</td><td align="right">2031</td><td align="right">2031</td><td align="right">2023</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">56</td><td align="right">56</td><td align="right">56</td><td align="right">56</td><td align="right">56</td><td align="right">56</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,055</td><td align="right">0,055</td><td align="right">0,055</td><td align="right">0,055</td><td align="right">0,055</td><td align="right">0,055</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">14,832 ns</td><td align="right">13,986 ns</td><td align="right">14,559 ns</td><td align="right">14,979 ns</td><td align="right">14,862 ns</td><td align="right">14,913 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,015 μs</td><td align="right">0,014 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">1071</td><td align="right">1067</td><td align="right">1071</td><td align="right">1075</td><td align="right">1071</td><td align="right">1059</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">32</td><td align="right">32</td><td align="right">32</td><td align="right">32</td><td align="right">32</td><td align="right">32</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,031</td><td align="right">0,031</td><td align="right">0,031</td><td align="right">0,031</td><td align="right">0,031</td><td align="right">0,031</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">543,203 ns</td><td align="right">538,220 ns</td><td align="right">548,089 ns</td><td align="right">556,829 ns</td><td align="right">288,857 ns</td><td align="right">277,223 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,543 μs</td><td align="right">0,538 μs</td><td align="right">0,548 μs</td><td align="right">0,557 μs</td><td align="right">0,289 μs</td><td align="right">0,277 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">90</td><td align="right">90</td><td align="right">78</td><td align="right">135</td><td align="right">333</td><td align="right">206</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">224</td><td align="right">224</td><td align="right">224</td><td align="right">256</td><td align="right">216</td><td align="right">160</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,219</td><td align="right">0,219</td><td align="right">0,219</td><td align="right">0,250</td><td align="right">0,211</td><td align="right">0,156</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">845,024 ns</td><td align="right">861,554 ns</td><td align="right">857,620 ns</td><td align="right">975,709 ns</td><td align="right">594,934 ns</td><td align="right">620,091 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,845 μs</td><td align="right">0,862 μs</td><td align="right">0,858 μs</td><td align="right">0,976 μs</td><td align="right">0,595 μs</td><td align="right">0,620 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">68</td><td align="right">72</td><td align="right">64</td><td align="right">67</td><td align="right">285</td><td align="right">247</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">392</td><td align="right">392</td><td align="right">392</td><td align="right">424</td><td align="right">384</td><td align="right">352</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,383</td><td align="right">0,383</td><td align="right">0,383</td><td align="right">0,414</td><td align="right">0,375</td><td align="right">0,344</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">775,744 ns</td><td align="right">767,375 ns</td><td align="right">786,876 ns</td><td align="right">777,761 ns</td><td align="right">509,392 ns</td><td align="right">504,148 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,776 μs</td><td align="right">0,767 μs</td><td align="right">0,787 μs</td><td align="right">0,778 μs</td><td align="right">0,509 μs</td><td align="right">0,504 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">41</td><td align="right">57</td><td align="right">57</td><td align="right">83</td><td align="right">281</td><td align="right">240</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">384</td><td align="right">384</td><td align="right">384</td><td align="right">416</td><td align="right">376</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,375</td><td align="right">0,375</td><td align="right">0,375</td><td align="right">0,406</td><td align="right">0,367</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">131,399 ns</td><td align="right">153,102 ns</td><td align="right">174,914 ns</td><td align="right">155,991 ns</td><td align="right">153,972 ns</td><td align="right">157,013 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,131 μs</td><td align="right">0,153 μs</td><td align="right">0,175 μs</td><td align="right">0,156 μs</td><td align="right">0,154 μs</td><td align="right">0,157 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">132,275 ns</td><td align="right">161,848 ns</td><td align="right">177,211 ns</td><td align="right">156,109 ns</td><td align="right">154,040 ns</td><td align="right">155,700 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,132 μs</td><td align="right">0,162 μs</td><td align="right">0,177 μs</td><td align="right">0,156 μs</td><td align="right">0,154 μs</td><td align="right">0,156 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">128,277 ns</td><td align="right">149,643 ns</td><td align="right">173,261 ns</td><td align="right">147,606 ns</td><td align="right">147,311 ns</td><td align="right">147,520 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,128 μs</td><td align="right">0,150 μs</td><td align="right">0,173 μs</td><td align="right">0,148 μs</td><td align="right">0,147 μs</td><td align="right">0,148 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
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


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1409,387 ns</td><td align="right">1643,837 ns</td><td align="right">1668,441 ns</td><td align="right">1799,848 ns</td><td align="right">1768,981 ns</td><td align="right">1345,502 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,409 μs</td><td align="right">1,644 μs</td><td align="right">1,668 μs</td><td align="right">1,800 μs</td><td align="right">1,769 μs</td><td align="right">1,346 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">113</td><td align="right">0</td><td align="right">0</td><td align="right">4</td><td align="right">12</td><td align="right">68</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">472</td><td align="right">504</td><td align="right">504</td><td align="right">624</td><td align="right">624</td><td align="right">408</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,461</td><td align="right">0,492</td><td align="right">0,492</td><td align="right">0,609</td><td align="right">0,609</td><td align="right">0,398</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1628,483 ns</td><td align="right">1672,462 ns</td><td align="right">1774,639 ns</td><td align="right">1713,037 ns</td><td align="right">1919,123 ns</td><td align="right">1324,557 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,628 μs</td><td align="right">1,672 μs</td><td align="right">1,775 μs</td><td align="right">1,713 μs</td><td align="right">1,919 μs</td><td align="right">1,325 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">113</td><td align="right">0</td><td align="right">0</td><td align="right">8</td><td align="right">12</td><td align="right">64</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">472</td><td align="right">504</td><td align="right">504</td><td align="right">624</td><td align="right">624</td><td align="right">408</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,461</td><td align="right">0,492</td><td align="right">0,492</td><td align="right">0,609</td><td align="right">0,609</td><td align="right">0,398</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1398,817 ns</td><td align="right">1407,735 ns</td><td align="right">1470,580 ns</td><td align="right">1674,029 ns</td><td align="right">1590,622 ns</td><td align="right">1164,700 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,399 μs</td><td align="right">1,408 μs</td><td align="right">1,471 μs</td><td align="right">1,674 μs</td><td align="right">1,591 μs</td><td align="right">1,165 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">82</td><td align="right">109</td><td align="right">109</td><td align="right">152</td><td align="right">168</td><td align="right">29</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">448</td><td align="right">480</td><td align="right">480</td><td align="right">600</td><td align="right">600</td><td align="right">384</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,438</td><td align="right">0,469</td><td align="right">0,469</td><td align="right">0,586</td><td align="right">0,586</td><td align="right">0,375</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">250575,641 ns</td><td align="right">252080,481 ns</td><td align="right">262872,466 ns</td><td align="right">270053,601 ns</td><td align="right">670569,059 ns</td><td align="right">663113,897 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">250,576 μs</td><td align="right">252,080 μs</td><td align="right">262,872 μs</td><td align="right">270,054 μs</td><td align="right">670,569 μs</td><td align="right">663,114 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,251 ms</td><td align="right">0,252 ms</td><td align="right">0,263 ms</td><td align="right">0,270 ms</td><td align="right">0,671 ms</td><td align="right">0,663 ms</td></tr>
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
<td align="right">4.5.0</td>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">32</td><td align="right">40</td><td align="right">32</td><td align="right">47</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">79520</td><td align="right">79521</td><td align="right">80840</td><td align="right">85166</td><td align="right">110028</td><td align="right">108648</td><tr>
<td>Allocated Kilobytes</td><td align="right">77,656</td><td align="right">77,657</td><td align="right">78,945</td><td align="right">83,170</td><td align="right">107,449</td><td align="right">106,102</td><tr>
<td>Allocated Megabytes</td><td align="right">0,076</td><td align="right">0,076</td><td align="right">0,077</td><td align="right">0,081</td><td align="right">0,105</td><td align="right">0,104</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">50353,709 ns</td><td align="right">52729,063 ns</td><td align="right">56338,321 ns</td><td align="right">57867,727 ns</td><td align="right">423134,284 ns</td><td align="right">420578,826 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">50,354 μs</td><td align="right">52,729 μs</td><td align="right">56,338 μs</td><td align="right">57,868 μs</td><td align="right">423,134 μs</td><td align="right">420,579 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,050 ms</td><td align="right">0,053 ms</td><td align="right">0,056 ms</td><td align="right">0,058 ms</td><td align="right">0,423 ms</td><td align="right">0,421 ms</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">36</td><td align="right">36</td><td align="right">36</td><td align="right">47</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">19824</td><td align="right">19824</td><td align="right">20166</td><td align="right">21464</td><td align="right">39041</td><td align="right">38591</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,359</td><td align="right">19,359</td><td align="right">19,693</td><td align="right">20,961</td><td align="right">38,126</td><td align="right">37,687</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,020</td><td align="right">0,037</td><td align="right">0,037</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">170409,387 ns</td><td align="right">173010,086 ns</td><td align="right">182441,548 ns</td><td align="right">183185,510 ns</td><td align="right">568491,650 ns</td><td align="right">569289,430 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">170,409 μs</td><td align="right">173,010 μs</td><td align="right">182,442 μs</td><td align="right">183,186 μs</td><td align="right">568,492 μs</td><td align="right">569,289 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,170 ms</td><td align="right">0,173 ms</td><td align="right">0,182 ms</td><td align="right">0,183 ms</td><td align="right">0,568 ms</td><td align="right">0,569 ms</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">118</td><td align="right">118</td><td align="right">129</td><td align="right">160</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59122</td><td align="right">59121</td><td align="right">60459</td><td align="right">64846</td><td align="right">87644</td><td align="right">86192</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,736</td><td align="right">57,735</td><td align="right">59,042</td><td align="right">63,326</td><td align="right">85,590</td><td align="right">84,172</td><tr>
<td>Allocated Megabytes</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,082</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">869651,510 ns</td><td align="right">851998,903 ns</td><td align="right">877779,599 ns</td><td align="right">921756,978 ns</td><td align="right">1367246,096 ns</td><td align="right">1358553,199 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">869,652 μs</td><td align="right">851,999 μs</td><td align="right">877,780 μs</td><td align="right">921,757 μs</td><td align="right">1367,246 μs</td><td align="right">1358,553 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,870 ms</td><td align="right">0,852 ms</td><td align="right">0,878 ms</td><td align="right">0,922 ms</td><td align="right">1,367 ms</td><td align="right">1,359 ms</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
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
<td>Gen 0</td><td align="right">14</td><td align="right">14</td><td align="right">14</td><td align="right">21</td><td align="right">47</td><td align="right">59</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">262613</td><td align="right">262613</td><td align="right">268899</td><td align="right">288596</td><td align="right">337022</td><td align="right">330726</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,458</td><td align="right">256,458</td><td align="right">262,597</td><td align="right">281,832</td><td align="right">329,123</td><td align="right">322,975</td><tr>
<td>Allocated Megabytes</td><td align="right">0,250</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,321</td><td align="right">0,315</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">17402176,026 ns</td><td align="right">16593257,791 ns</td><td align="right">16713437,238 ns</td><td align="right">16781747,383 ns</td><td align="right">17614972,282 ns</td><td align="right">17324725,144 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">17402,176 μs</td><td align="right">16593,258 μs</td><td align="right">16713,437 μs</td><td align="right">16781,747 μs</td><td align="right">17614,972 μs</td><td align="right">17324,725 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">17,402 ms</td><td align="right">16,593 ms</td><td align="right">16,713 ms</td><td align="right">16,782 ms</td><td align="right">17,615 ms</td><td align="right">17,325 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">1429262</td><td align="right">1429262</td><td align="right">1455125</td><td align="right">1483791</td><td align="right">1559567</td><td align="right">1558541</td><tr>
<td>Allocated Kilobytes</td><td align="right">1395,764</td><td align="right">1395,764</td><td align="right">1421,021</td><td align="right">1449,015</td><td align="right">1523,015</td><td align="right">1522,013</td><tr>
<td>Allocated Megabytes</td><td align="right">1,363</td><td align="right">1,363</td><td align="right">1,388</td><td align="right">1,415</td><td align="right">1,487</td><td align="right">1,486</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">693299,242 ns</td><td align="right">696734,306 ns</td><td align="right">703925,207 ns</td><td align="right">711441,951 ns</td><td align="right">1103686,690 ns</td><td align="right">1091509,893 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">693,299 μs</td><td align="right">696,734 μs</td><td align="right">703,925 μs</td><td align="right">711,442 μs</td><td align="right">1103,687 μs</td><td align="right">1091,510 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,693 ms</td><td align="right">0,697 ms</td><td align="right">0,704 ms</td><td align="right">0,711 ms</td><td align="right">1,104 ms</td><td align="right">1,092 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">66433</td><td align="right">66433</td><td align="right">67376</td><td align="right">69216</td><td align="right">87721</td><td align="right">86665</td><tr>
<td>Allocated Kilobytes</td><td align="right">64,876</td><td align="right">64,876</td><td align="right">65,797</td><td align="right">67,594</td><td align="right">85,665</td><td align="right">84,634</td><tr>
<td>Allocated Megabytes</td><td align="right">0,063</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,066</td><td align="right">0,084</td><td align="right">0,083</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">2768003,470 ns</td><td align="right">2790006,572 ns</td><td align="right">2770446,050 ns</td><td align="right">2788929,529 ns</td><td align="right">3236314,713 ns</td><td align="right">3208357,800 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">2768,003 μs</td><td align="right">2790,007 μs</td><td align="right">2770,446 μs</td><td align="right">2788,930 μs</td><td align="right">3236,315 μs</td><td align="right">3208,358 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">2,768 ms</td><td align="right">2,790 ms</td><td align="right">2,770 ms</td><td align="right">2,789 ms</td><td align="right">3,236 ms</td><td align="right">3,208 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">246733</td><td align="right">246725</td><td align="right">248783</td><td align="right">256130</td><td align="right">283650</td><td align="right">281474</td><tr>
<td>Allocated Kilobytes</td><td align="right">240,950</td><td align="right">240,942</td><td align="right">242,952</td><td align="right">250,127</td><td align="right">277,002</td><td align="right">274,877</td><tr>
<td>Allocated Megabytes</td><td align="right">0,235</td><td align="right">0,235</td><td align="right">0,237</td><td align="right">0,244</td><td align="right">0,271</td><td align="right">0,268</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">13110833,642 ns</td><td align="right">13194537,735 ns</td><td align="right">13137860,545 ns</td><td align="right">13315286,523 ns</td><td align="right">13981905,667 ns</td><td align="right">14158849,634 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">13110,834 μs</td><td align="right">13194,538 μs</td><td align="right">13137,861 μs</td><td align="right">13315,287 μs</td><td align="right">13981,906 μs</td><td align="right">14158,850 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">13,111 ms</td><td align="right">13,195 ms</td><td align="right">13,138 ms</td><td align="right">13,315 ms</td><td align="right">13,982 ms</td><td align="right">14,159 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">1150026</td><td align="right">1150026</td><td align="right">1159270</td><td align="right">1203723</td><td align="right">1267211</td><td align="right">1255433</td><tr>
<td>Allocated Kilobytes</td><td align="right">1123,072</td><td align="right">1123,072</td><td align="right">1132,100</td><td align="right">1175,511</td><td align="right">1237,511</td><td align="right">1226,009</td><tr>
<td>Allocated Megabytes</td><td align="right">1,097</td><td align="right">1,097</td><td align="right">1,106</td><td align="right">1,148</td><td align="right">1,209</td><td align="right">1,197</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">710672,952 ns</td><td align="right">713087,933 ns</td><td align="right">860653,075 ns</td><td align="right">901437,217 ns</td><td align="right">1340999,643 ns</td><td align="right">1348150,853 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">710,673 μs</td><td align="right">713,088 μs</td><td align="right">860,653 μs</td><td align="right">901,437 μs</td><td align="right">1341,000 μs</td><td align="right">1348,151 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,711 ms</td><td align="right">0,713 ms</td><td align="right">0,861 ms</td><td align="right">0,901 ms</td><td align="right">1,341 ms</td><td align="right">1,348 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">528</td><td align="right">516</td><td align="right">174</td><td align="right">202</td><td align="right">209</td><td align="right">209</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544345</td><td align="right">544349</td><td align="right">550231</td><td align="right">559505</td><td align="right">587110</td><td align="right">585800</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,587</td><td align="right">531,591</td><td align="right">537,335</td><td align="right">546,392</td><td align="right">573,350</td><td align="right">572,070</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,534</td><td align="right">0,560</td><td align="right">0,559</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">89042,126 ns</td><td align="right">86139,082 ns</td><td align="right">128190,975 ns</td><td align="right">141219,319 ns</td><td align="right">509877,562 ns</td><td align="right">514893,958 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">89,042 μs</td><td align="right">86,139 μs</td><td align="right">128,191 μs</td><td align="right">141,219 μs</td><td align="right">509,878 μs</td><td align="right">514,894 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,089 ms</td><td align="right">0,086 ms</td><td align="right">0,128 ms</td><td align="right">0,141 ms</td><td align="right">0,510 ms</td><td align="right">0,515 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">969</td><td align="right">977</td><td align="right">414</td><td align="right">422</td><td align="right">17</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115961</td><td align="right">115961</td><td align="right">117638</td><td align="right">120589</td><td align="right">138488</td><td align="right">138054</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,243</td><td align="right">113,243</td><td align="right">114,881</td><td align="right">117,763</td><td align="right">135,242</td><td align="right">134,818</td><tr>
<td>Allocated Megabytes</td><td align="right">0,111</td><td align="right">0,111</td><td align="right">0,112</td><td align="right">0,115</td><td align="right">0,132</td><td align="right">0,132</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">309453,470 ns</td><td align="right">310592,011 ns</td><td align="right">447209,481 ns</td><td align="right">502668,734 ns</td><td align="right">915491,548 ns</td><td align="right">915704,652 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">309,453 μs</td><td align="right">310,592 μs</td><td align="right">447,209 μs</td><td align="right">502,669 μs</td><td align="right">915,492 μs</td><td align="right">915,705 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,309 ms</td><td align="right">0,311 ms</td><td align="right">0,447 ms</td><td align="right">0,503 ms</td><td align="right">0,915 ms</td><td align="right">0,916 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">812</td><td align="right">820</td><td align="right">348</td><td align="right">363</td><td align="right">123</td><td align="right">107</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396412</td><td align="right">396404</td><td align="right">402326</td><td align="right">412033</td><td align="right">437406</td><td align="right">436058</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,121</td><td align="right">387,113</td><td align="right">392,896</td><td align="right">402,376</td><td align="right">427,154</td><td align="right">425,838</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,416</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1563714,294 ns</td><td align="right">1561240,486 ns</td><td align="right">2169791,208 ns</td><td align="right">2257862,668 ns</td><td align="right">2878593,600 ns</td><td align="right">2927218,456 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1563,714 μs</td><td align="right">1561,240 μs</td><td align="right">2169,791 μs</td><td align="right">2257,863 μs</td><td align="right">2878,594 μs</td><td align="right">2927,218 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">1,564 ms</td><td align="right">1,561 ms</td><td align="right">2,170 ms</td><td align="right">2,258 ms</td><td align="right">2,879 ms</td><td align="right">2,927 ms</td></tr>
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
<td align="right">4.4.0</td>
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
<td align="right">4.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">952</td><td align="right">416</td><td align="right">388</td><td align="right">411</td><td align="right">429</td><td align="right">418</td></tr>
<tr>
<td>Gen 1</td><td align="right">52</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799898</td><td align="right">1800015</td><td align="right">1826460</td><td align="right">1868703</td><td align="right">1930729</td><td align="right">1924383</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,713</td><td align="right">1757,827</td><td align="right">1783,652</td><td align="right">1824,905</td><td align="right">1885,478</td><td align="right">1879,280</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,717</td><td align="right">1,742</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">1,835</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">33909,666 ns</td><td align="right">34381,279 ns</td><td align="right">34754,180 ns</td><td align="right">33659,856 ns</td><td align="right">32424,348 ns</td><td align="right">23382,522 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">33,910 μs</td><td align="right">34,381 μs</td><td align="right">34,754 μs</td><td align="right">33,660 μs</td><td align="right">32,424 μs</td><td align="right">23,383 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,034 ms</td><td align="right">0,034 ms</td><td align="right">0,035 ms</td><td align="right">0,034 ms</td><td align="right">0,032 ms</td><td align="right">0,023 ms</td></tr>
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
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
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
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">114</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7651</td><td align="right">7747</td><td align="right">7676</td><td align="right">7572</td><td align="right">7530</td><td align="right">6149</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,472</td><td align="right">7,565</td><td align="right">7,496</td><td align="right">7,395</td><td align="right">7,354</td><td align="right">6,005</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


