# Benchmarks

Benchmark report generated on 02-jun-2017 14:24

Running the benchmarks took 01:50:58.9849802

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.6, OS=Windows 10 Redstone 2 (10.0.15063)

Processor=Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), ProcessorCount=8

Frequency=10000000 Hz, Resolution=100.0000 ns, Timer=UNKNOWN


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
* [PropertyBag_GetPropertyValue_Benchmark](#PropertyBag_GetPropertyValue_Benchmark)
  * [GetBoolValue](#PropertyBag_GetPropertyValue_Benchmark_GetBoolValue)
  * [GetIntValue](#PropertyBag_GetPropertyValue_Benchmark_GetIntValue)
  * [GetStringValue](#PropertyBag_GetPropertyValue_Benchmark_GetStringValue)
* [PropertyBag_SetPropertyValue_Benchmark](#PropertyBag_SetPropertyValue_Benchmark)
  * [SetBoolValue](#PropertyBag_SetPropertyValue_Benchmark_SetBoolValue)
  * [SetIntValue](#PropertyBag_SetPropertyValue_Benchmark_SetIntValue)
  * [SetStringValue](#PropertyBag_SetPropertyValue_Benchmark_SetStringValue)
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

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,613 ns</td><td align="right" bgcolor="#FFFFFF">123,325 ns</td><td align="right" bgcolor="#FFFFFF">122,688 ns</td><td align="right" bgcolor="#FF4949">245,644 ns</td><td align="right" bgcolor="#FFFFFF">245,875 ns</td><td align="right" bgcolor="#FFFFFF">252,582 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FF4949">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">450</td><td align="right">450</td><td align="right">450</td></tr>
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

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,388 ns</td><td align="right" bgcolor="#A8D08D">123,879 ns</td><td align="right" bgcolor="#FFFFFF">124,999 ns</td><td align="right" bgcolor="#FF4949">253,223 ns</td><td align="right" bgcolor="#FF4949">262,852 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#A8D08D">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FF4949">0,253 μs</td><td align="right" bgcolor="#FF4949">0,263 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">450</td><td align="right">450</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">136</td><td align="right">136</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,133</td><td align="right">0,133</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">102,249 ns</td><td align="right" bgcolor="#FF4949">105,476 ns</td><td align="right" bgcolor="#A8D08D">98,980 ns</td><td align="right" bgcolor="#FF4949">223,297 ns</td><td align="right" bgcolor="#FFFFFF">227,766 ns</td><td align="right" bgcolor="#FFFFFF">228,474 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FF4949">0,105 μs</td><td align="right" bgcolor="#A8D08D">0,099 μs</td><td align="right" bgcolor="#FF4949">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">310</td><td align="right">310</td><td align="right">310</td><td align="right">790</td><td align="right">790</td><td align="right">790</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">318,608 ns</td><td align="right" bgcolor="#FFFFFF">322,588 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,323 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">210</td><td align="right">210</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">64</td><td align="right">64</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,063</td><td align="right">0,063</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">109,918 ns</td><td align="right" bgcolor="#FFFFFF">109,641 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">310</td><td align="right">310</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,634 ns</td><td align="right" bgcolor="#FFFFFF">11,534 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2550</td><td align="right">2550</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,902 ns</td><td align="right" bgcolor="#FF4949">13,303 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FF4949">0,013 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2550</td><td align="right">1270</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,081 ns</td><td align="right" bgcolor="#FFFFFF">5,104 ns</td><td align="right" bgcolor="#A8D08D">4,791 ns</td><td align="right" bgcolor="#FF4949">5,644 ns</td><td align="right" bgcolor="#A8D08D">5,292 ns</td><td align="right" bgcolor="#FFFFFF">5,222 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs</td><td align="right" bgcolor="#FF4949">0,006 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,250 ns</td><td align="right" bgcolor="#FF4949">20,006 ns</td><td align="right" bgcolor="#A8D08D">18,211 ns</td><td align="right" bgcolor="#FF4949">19,092 ns</td><td align="right" bgcolor="#A8D08D">18,206 ns</td><td align="right" bgcolor="#FFFFFF">18,672 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FF4949">0,020 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs</td><td align="right" bgcolor="#FF4949">0,019 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2980</td><td align="right">2980</td><td align="right">2980</td><td align="right">2980</td><td align="right">2980</td><td align="right">2980</td></tr>
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

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,022 ns</td><td align="right" bgcolor="#FFFFFF">15,081 ns</td><td align="right" bgcolor="#FFFFFF">14,770 ns</td><td align="right" bgcolor="#FF4949">15,915 ns</td><td align="right" bgcolor="#A8D08D">15,373 ns</td><td align="right" bgcolor="#FFFFFF">15,716 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FF4949">0,016 μs</td><td align="right" bgcolor="#A8D08D">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1700</td><td align="right">1700</td><td align="right">1700</td><td align="right">1700</td><td align="right">1700</td><td align="right">1700</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">555,555 ns</td><td align="right" bgcolor="#FFFFFF">557,840 ns</td><td align="right" bgcolor="#FF4949">585,187 ns</td><td align="right" bgcolor="#A8D08D">566,219 ns</td><td align="right" bgcolor="#A8D08D">352,176 ns</td><td align="right" bgcolor="#FFFFFF">355,855 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,556 μs</td><td align="right" bgcolor="#FFFFFF">0,558 μs</td><td align="right" bgcolor="#FF4949">0,585 μs</td><td align="right" bgcolor="#A8D08D">0,566 μs</td><td align="right" bgcolor="#A8D08D">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,356 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">330</td><td align="right">330</td><td align="right">330</td><td align="right">380</td><td align="right">630</td><td align="right">530</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">200</td><td align="right">200</td><td align="right">200</td><td align="right">232</td><td align="right">192</td><td align="right">160</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,195</td><td align="right">0,195</td><td align="right">0,195</td><td align="right">0,227</td><td align="right">0,188</td><td align="right">0,156</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">870,290 ns</td><td align="right" bgcolor="#FF4949">914,031 ns</td><td align="right" bgcolor="#A8D08D">884,877 ns</td><td align="right" bgcolor="#FF4949">951,330 ns</td><td align="right" bgcolor="#A8D08D">689,849 ns</td><td align="right" bgcolor="#FFFFFF">682,459 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td><td align="right" bgcolor="#FF4949">0,914 μs</td><td align="right" bgcolor="#A8D08D">0,885 μs</td><td align="right" bgcolor="#FF4949">0,951 μs</td><td align="right" bgcolor="#A8D08D">0,690 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">650</td><td align="right">320</td><td align="right">650</td><td align="right">700</td><td align="right">630</td><td align="right">580</td></tr>
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

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">802,887 ns</td><td align="right" bgcolor="#FFFFFF">820,516 ns</td><td align="right" bgcolor="#FFFFFF">825,550 ns</td><td align="right" bgcolor="#FFFFFF">841,826 ns</td><td align="right" bgcolor="#A8D08D">598,807 ns</td><td align="right" bgcolor="#FFFFFF">597,272 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,826 μs</td><td align="right" bgcolor="#FFFFFF">0,842 μs</td><td align="right" bgcolor="#A8D08D">0,599 μs</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">630</td><td align="right">630</td><td align="right">630</td><td align="right">690</td><td align="right">620</td><td align="right">570</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">123,525 ns</td><td align="right" bgcolor="#FFFFFF">125,926 ns</td><td align="right" bgcolor="#FF4949">148,815 ns</td><td align="right" bgcolor="#A8D08D">125,063 ns</td><td align="right" bgcolor="#FF4949">207,391 ns</td><td align="right" bgcolor="#A8D08D">121,835 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FF4949">0,149 μs</td><td align="right" bgcolor="#A8D08D">0,125 μs</td><td align="right" bgcolor="#FF4949">0,207 μs</td><td align="right" bgcolor="#A8D08D">0,122 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">137,751 ns</td><td align="right" bgcolor="#A8D08D">124,051 ns</td><td align="right" bgcolor="#FF4949">146,105 ns</td><td align="right" bgcolor="#A8D08D">122,276 ns</td><td align="right" bgcolor="#FF4949">207,414 ns</td><td align="right" bgcolor="#A8D08D">120,981 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#A8D08D">0,124 μs</td><td align="right" bgcolor="#FF4949">0,146 μs</td><td align="right" bgcolor="#A8D08D">0,122 μs</td><td align="right" bgcolor="#FF4949">0,207 μs</td><td align="right" bgcolor="#A8D08D">0,121 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">140,203 ns</td><td align="right" bgcolor="#A8D08D">116,514 ns</td><td align="right" bgcolor="#FF4949">146,461 ns</td><td align="right" bgcolor="#A8D08D">121,832 ns</td><td align="right" bgcolor="#A8D08D">113,880 ns</td><td align="right" bgcolor="#FFFFFF">117,212 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#A8D08D">0,117 μs</td><td align="right" bgcolor="#FF4949">0,146 μs</td><td align="right" bgcolor="#A8D08D">0,122 μs</td><td align="right" bgcolor="#A8D08D">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1620,356 ns</td><td align="right" bgcolor="#A8D08D">1559,686 ns</td><td align="right" bgcolor="#FFFFFF">1598,329 ns</td><td align="right" bgcolor="#FF4949">1683,988 ns</td><td align="right" bgcolor="#FFFFFF">1691,544 ns</td><td align="right" bgcolor="#A8D08D">1348,186 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,620 μs</td><td align="right" bgcolor="#A8D08D">1,560 μs</td><td align="right" bgcolor="#FFFFFF">1,598 μs</td><td align="right" bgcolor="#FF4949">1,684 μs</td><td align="right" bgcolor="#FFFFFF">1,692 μs</td><td align="right" bgcolor="#A8D08D">1,348 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">390</td><td align="right">410</td><td align="right">410</td><td align="right">510</td><td align="right">510</td><td align="right">330</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1622,880 ns</td><td align="right" bgcolor="#FFFFFF">1650,339 ns</td><td align="right" bgcolor="#FFFFFF">1660,426 ns</td><td align="right" bgcolor="#FF4949">1784,290 ns</td><td align="right" bgcolor="#FFFFFF">1815,670 ns</td><td align="right" bgcolor="#A8D08D">1388,298 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,623 μs</td><td align="right" bgcolor="#FFFFFF">1,650 μs</td><td align="right" bgcolor="#FFFFFF">1,660 μs</td><td align="right" bgcolor="#FF4949">1,784 μs</td><td align="right" bgcolor="#FFFFFF">1,816 μs</td><td align="right" bgcolor="#A8D08D">1,388 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td align="right">4.3.0</td>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">390</td><td align="right">200</td><td align="right">410</td><td align="right">510</td><td align="right">510</td><td align="right">330</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1453,994 ns</td><td align="right" bgcolor="#FFFFFF">1460,908 ns</td><td align="right" bgcolor="#FFFFFF">1461,360 ns</td><td align="right" bgcolor="#FF4949">1529,921 ns</td><td align="right" bgcolor="#FFFFFF">1526,585 ns</td><td align="right" bgcolor="#A8D08D">1294,903 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,454 μs</td><td align="right" bgcolor="#FFFFFF">1,461 μs</td><td align="right" bgcolor="#FFFFFF">1,461 μs</td><td align="right" bgcolor="#FF4949">1,530 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td><td align="right" bgcolor="#A8D08D">1,295 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">370</td><td align="right">390</td><td align="right">390</td><td align="right">490</td><td align="right">490</td><td align="right">310</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">448</td><td align="right">480</td><td align="right">480</td><td align="right">600</td><td align="right">600</td><td align="right">384</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,438</td><td align="right">0,469</td><td align="right">0,469</td><td align="right">0,586</td><td align="right">0,586</td><td align="right">0,375</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.0**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">89,772 ns</td><td align="right" bgcolor="#FFFFFF">91,836 ns</td><td align="right" bgcolor="#FFFFFF">90,586 ns</td><td align="right" bgcolor="#A8D08D">73,726 ns</td><td align="right" bgcolor="#FFFFFF">73,989 ns</td><td align="right" bgcolor="#FF4949">76,581 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#A8D08D">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FF4949">0,077 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td></tr>
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


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">88,884 ns</td><td align="right" bgcolor="#FF4949">93,794 ns</td><td align="right" bgcolor="#A8D08D">89,096 ns</td><td align="right" bgcolor="#A8D08D">75,101 ns</td><td align="right" bgcolor="#FF4949">79,724 ns</td><td align="right" bgcolor="#A8D08D">72,918 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FF4949">0,094 μs</td><td align="right" bgcolor="#A8D08D">0,089 μs</td><td align="right" bgcolor="#A8D08D">0,075 μs</td><td align="right" bgcolor="#FF4949">0,080 μs</td><td align="right" bgcolor="#A8D08D">0,073 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,721 ns</td><td align="right" bgcolor="#FF4949">101,218 ns</td><td align="right" bgcolor="#A8D08D">97,218 ns</td><td align="right" bgcolor="#A8D08D">81,372 ns</td><td align="right" bgcolor="#FFFFFF">79,254 ns</td><td align="right" bgcolor="#FFFFFF">79,991 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FF4949">0,101 μs</td><td align="right" bgcolor="#A8D08D">0,097 μs</td><td align="right" bgcolor="#A8D08D">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,721 ns</td><td align="right" bgcolor="#FF4949">205,814 ns</td><td align="right" bgcolor="#A8D08D">197,646 ns</td><td align="right" bgcolor="#A8D08D">172,909 ns</td><td align="right" bgcolor="#A8D08D">167,766 ns</td><td align="right" bgcolor="#A8D08D">116,761 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FF4949">0,206 μs</td><td align="right" bgcolor="#A8D08D">0,198 μs</td><td align="right" bgcolor="#A8D08D">0,173 μs</td><td align="right" bgcolor="#A8D08D">0,168 μs</td><td align="right" bgcolor="#A8D08D">0,117 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,476 ns</td><td align="right" bgcolor="#A8D08D">188,565 ns</td><td align="right" bgcolor="#FFFFFF">189,492 ns</td><td align="right" bgcolor="#A8D08D">180,964 ns</td><td align="right" bgcolor="#A8D08D">165,649 ns</td><td align="right" bgcolor="#A8D08D">112,134 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#A8D08D">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#A8D08D">0,181 μs</td><td align="right" bgcolor="#A8D08D">0,166 μs</td><td align="right" bgcolor="#A8D08D">0,112 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">24</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,023</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,560 ns</td><td align="right" bgcolor="#FFFFFF">96,437 ns</td><td align="right" bgcolor="#FFFFFF">96,682 ns</td><td align="right" bgcolor="#A8D08D">70,433 ns</td><td align="right" bgcolor="#FFFFFF">69,292 ns</td><td align="right" bgcolor="#FFFFFF">70,140 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#A8D08D">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">278996,229 ns</td><td align="right" bgcolor="#FFFFFF">273397,547 ns</td><td align="right" bgcolor="#FF4949">291755,711 ns</td><td align="right" bgcolor="#FFFFFF">299182,393 ns</td><td align="right" bgcolor="#FF4949">758922,988 ns</td><td align="right" bgcolor="#FFFFFF">756081,829 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">278,996 μs</td><td align="right" bgcolor="#FFFFFF">273,398 μs</td><td align="right" bgcolor="#FF4949">291,756 μs</td><td align="right" bgcolor="#FFFFFF">299,182 μs</td><td align="right" bgcolor="#FF4949">758,923 μs</td><td align="right" bgcolor="#FFFFFF">756,082 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,279 ms</td><td align="right" bgcolor="#FFFFFF">0,273 ms</td><td align="right" bgcolor="#FF4949">0,292 ms</td><td align="right" bgcolor="#FFFFFF">0,299 ms</td><td align="right" bgcolor="#FF4949">0,759 ms</td><td align="right" bgcolor="#FFFFFF">0,756 ms</td></tr>
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
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
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
<td>Gen 0</td><td align="right">250</td><td align="right">250</td><td align="right">260</td><td align="right">270</td><td align="right">170</td><td align="right">170</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">80223</td><td align="right">80079</td><td align="right">81404</td><td align="right">85723</td><td align="right">110737</td><td align="right">106806</td><tr>
<td>Allocated Kilobytes</td><td align="right">78,343</td><td align="right">78,202</td><td align="right">79,496</td><td align="right">83,714</td><td align="right">108,142</td><td align="right">104,303</td><tr>
<td>Allocated Megabytes</td><td align="right">0,077</td><td align="right">0,076</td><td align="right">0,078</td><td align="right">0,082</td><td align="right">0,106</td><td align="right">0,102</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">55961,600 ns</td><td align="right" bgcolor="#FF4949">58389,541 ns</td><td align="right" bgcolor="#FF4949">61668,843 ns</td><td align="right" bgcolor="#FF4949">66653,503 ns</td><td align="right" bgcolor="#FF4949">500680,558 ns</td><td align="right" bgcolor="#FFFFFF">492905,698 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">55,962 μs</td><td align="right" bgcolor="#FF4949">58,390 μs</td><td align="right" bgcolor="#FF4949">61,669 μs</td><td align="right" bgcolor="#FF4949">66,654 μs</td><td align="right" bgcolor="#FF4949">500,681 μs</td><td align="right" bgcolor="#FFFFFF">492,906 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,056 ms</td><td align="right" bgcolor="#FF4949">0,058 ms</td><td align="right" bgcolor="#FF4949">0,062 ms</td><td align="right" bgcolor="#FF4949">0,067 ms</td><td align="right" bgcolor="#FF4949">0,501 ms</td><td align="right" bgcolor="#FFFFFF">0,493 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.0</td>
<td align="right">4.2.0</td>
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
<td>Gen 0</td><td align="right">510</td><td align="right">510</td><td align="right">260</td><td align="right">270</td><td align="right">60</td><td align="right">60</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">10</td><td align="right">10</td><td align="right">20</td><td align="right">20</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">19999</td><td align="right">19928</td><td align="right">20270</td><td align="right">21569</td><td align="right">39225</td><td align="right">38801</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,530</td><td align="right">19,461</td><td align="right">19,795</td><td align="right">21,063</td><td align="right">38,306</td><td align="right">37,892</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,021</td><td align="right">0,037</td><td align="right">0,037</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">186168,989 ns</td><td align="right" bgcolor="#FF4949">200141,274 ns</td><td align="right" bgcolor="#FF4949">207654,825 ns</td><td align="right" bgcolor="#FFFFFF">211231,520 ns</td><td align="right" bgcolor="#FF4949">664168,792 ns</td><td align="right" bgcolor="#FFFFFF">660930,661 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">186,169 μs</td><td align="right" bgcolor="#FF4949">200,141 μs</td><td align="right" bgcolor="#FF4949">207,655 μs</td><td align="right" bgcolor="#FFFFFF">211,232 μs</td><td align="right" bgcolor="#FF4949">664,169 μs</td><td align="right" bgcolor="#FFFFFF">660,931 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,186 ms</td><td align="right" bgcolor="#FF4949">0,200 ms</td><td align="right" bgcolor="#FF4949">0,208 ms</td><td align="right" bgcolor="#FFFFFF">0,211 ms</td><td align="right" bgcolor="#FF4949">0,664 ms</td><td align="right" bgcolor="#FFFFFF">0,661 ms</td></tr>
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
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
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
<td>Gen 0</td><td align="right">380</td><td align="right">380</td><td align="right">390</td><td align="right">420</td><td align="right">140</td><td align="right">130</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59385</td><td align="right">59242</td><td align="right">60582</td><td align="right">64970</td><td align="right">87914</td><td align="right">85931</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,993</td><td align="right">57,854</td><td align="right">59,162</td><td align="right">63,447</td><td align="right">85,854</td><td align="right">83,917</td><tr>
<td>Allocated Megabytes</td><td align="right">0,057</td><td align="right">0,056</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,082</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">914473,473 ns</td><td align="right" bgcolor="#FFFFFF">920363,716 ns</td><td align="right" bgcolor="#FF4949">1017377,432 ns</td><td align="right" bgcolor="#A8D08D">973172,808 ns</td><td align="right" bgcolor="#FF4949">1508066,306 ns</td><td align="right" bgcolor="#FF4949">1588195,043 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">914,473 μs</td><td align="right" bgcolor="#FFFFFF">920,364 μs</td><td align="right" bgcolor="#FF4949">1017,377 μs</td><td align="right" bgcolor="#A8D08D">973,173 μs</td><td align="right" bgcolor="#FF4949">1508,066 μs</td><td align="right" bgcolor="#FF4949">1588,195 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,914 ms</td><td align="right" bgcolor="#FFFFFF">0,920 ms</td><td align="right" bgcolor="#FF4949">1,017 ms</td><td align="right" bgcolor="#A8D08D">0,973 ms</td><td align="right" bgcolor="#FF4949">1,508 ms</td><td align="right" bgcolor="#FF4949">1,588 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.4.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.3.0</td>
<td align="right">4.4.0</td>
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
<td>Gen 0</td><td align="right">420</td><td align="right">210</td><td align="right">430</td><td align="right">230</td><td align="right">270</td><td align="right">260</td></tr>
<tr>
<td>Gen 1</td><td align="right">56</td><td align="right">20</td><td align="right">60</td><td align="right">30</td><td align="right">50</td><td align="right">50</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">263121</td><td align="right">262619</td><td align="right">268907</td><td align="right">288620</td><td align="right">337557</td><td align="right">327771</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,954</td><td align="right">256,464</td><td align="right">262,604</td><td align="right">281,855</td><td align="right">329,646</td><td align="right">320,089</td><tr>
<td>Allocated Megabytes</td><td align="right">0,251</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,322</td><td align="right">0,313</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19134781,458 ns</td><td align="right" bgcolor="#A8D08D">18484402,656 ns</td><td align="right" bgcolor="#A8D08D">17835637,604 ns</td><td align="right" bgcolor="#FF4949">19266795,469 ns</td><td align="right" bgcolor="#FFFFFF">19019880,156 ns</td><td align="right" bgcolor="#FF4949">22069710,313 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">19134,781 μs</td><td align="right" bgcolor="#A8D08D">18484,403 μs</td><td align="right" bgcolor="#A8D08D">17835,638 μs</td><td align="right" bgcolor="#FF4949">19266,795 μs</td><td align="right" bgcolor="#FFFFFF">19019,880 μs</td><td align="right" bgcolor="#FF4949">22069,710 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">19,135 ms</td><td align="right" bgcolor="#A8D08D">18,484 ms</td><td align="right" bgcolor="#A8D08D">17,836 ms</td><td align="right" bgcolor="#FF4949">19,267 ms</td><td align="right" bgcolor="#FFFFFF">19,020 ms</td><td align="right" bgcolor="#FF4949">22,070 ms</td></tr>
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
<td>Gen 0</td><td align="right">70</td><td align="right">70</td><td align="right">70</td><td align="right">70</td><td align="right">70</td><td align="right">70</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1430549</td><td align="right">1431056</td><td align="right">1452844</td><td align="right">1490721</td><td align="right">1560847</td><td align="right">1537040</td><tr>
<td>Allocated Kilobytes</td><td align="right">1397,021</td><td align="right">1397,516</td><td align="right">1418,793</td><td align="right">1455,782</td><td align="right">1524,265</td><td align="right">1501,016</td><tr>
<td>Allocated Megabytes</td><td align="right">1,364</td><td align="right">1,365</td><td align="right">1,386</td><td align="right">1,422</td><td align="right">1,489</td><td align="right">1,466</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">769387,770 ns</td><td align="right" bgcolor="#A8D08D">746763,687 ns</td><td align="right" bgcolor="#FF4949">780979,368 ns</td><td align="right" bgcolor="#FFFFFF">794272,198 ns</td><td align="right" bgcolor="#FF4949">1229282,900 ns</td><td align="right" bgcolor="#FFFFFF">1246504,692 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">769,388 μs</td><td align="right" bgcolor="#A8D08D">746,764 μs</td><td align="right" bgcolor="#FF4949">780,979 μs</td><td align="right" bgcolor="#FFFFFF">794,272 μs</td><td align="right" bgcolor="#FF4949">1229,283 μs</td><td align="right" bgcolor="#FFFFFF">1246,505 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,769 ms</td><td align="right" bgcolor="#A8D08D">0,747 ms</td><td align="right" bgcolor="#FF4949">0,781 ms</td><td align="right" bgcolor="#FFFFFF">0,794 ms</td><td align="right" bgcolor="#FF4949">1,229 ms</td><td align="right" bgcolor="#FFFFFF">1,247 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">100</td><td align="right">100</td><td align="right">100</td><td align="right">110</td><td align="right">60</td><td align="right">60</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">20</td><td align="right">30</td><td align="right">30</td><td align="right">20</td><td align="right">20</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66607</td><td align="right">66442</td><td align="right">67281</td><td align="right">69755</td><td align="right">87179</td><td align="right">86403</td><tr>
<td>Allocated Kilobytes</td><td align="right">65,046</td><td align="right">64,885</td><td align="right">65,704</td><td align="right">68,120</td><td align="right">85,136</td><td align="right">84,378</td><tr>
<td>Allocated Megabytes</td><td align="right">0,064</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,067</td><td align="right">0,083</td><td align="right">0,082</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2992379,466 ns</td><td align="right" bgcolor="#FFFFFF">2999354,863 ns</td><td align="right" bgcolor="#FFFFFF">3020235,762 ns</td><td align="right" bgcolor="#FFFFFF">3078765,794 ns</td><td align="right" bgcolor="#FF4949">3583988,446 ns</td><td align="right" bgcolor="#FFFFFF">3558246,566 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2992,379 μs</td><td align="right" bgcolor="#FFFFFF">2999,355 μs</td><td align="right" bgcolor="#FFFFFF">3020,236 μs</td><td align="right" bgcolor="#FFFFFF">3078,766 μs</td><td align="right" bgcolor="#FF4949">3583,988 μs</td><td align="right" bgcolor="#FFFFFF">3558,247 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,992 ms</td><td align="right" bgcolor="#FFFFFF">2,999 ms</td><td align="right" bgcolor="#FFFFFF">3,020 ms</td><td align="right" bgcolor="#FFFFFF">3,079 ms</td><td align="right" bgcolor="#FF4949">3,584 ms</td><td align="right" bgcolor="#FFFFFF">3,558 ms</td></tr>
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
<td align="right">4.2.0</td>
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">100</td><td align="right">110</td><td align="right">110</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">30</td><td align="right">30</td><td align="right">25</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">245636</td><td align="right">246147</td><td align="right">250253</td><td align="right">257587</td><td align="right">285752</td><td align="right">279785</td><tr>
<td>Allocated Kilobytes</td><td align="right">239,879</td><td align="right">240,378</td><td align="right">244,388</td><td align="right">251,550</td><td align="right">279,055</td><td align="right">273,228</td><tr>
<td>Allocated Megabytes</td><td align="right">0,234</td><td align="right">0,235</td><td align="right">0,239</td><td align="right">0,246</td><td align="right">0,273</td><td align="right">0,267</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14326726,680 ns</td><td align="right" bgcolor="#FFFFFF">14426433,320 ns</td><td align="right" bgcolor="#FFFFFF">14417188,633 ns</td><td align="right" bgcolor="#FFFFFF">14460631,406 ns</td><td align="right" bgcolor="#FF4949">15260111,797 ns</td><td align="right" bgcolor="#FFFFFF">15498352,899 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14326,727 μs</td><td align="right" bgcolor="#FFFFFF">14426,433 μs</td><td align="right" bgcolor="#FFFFFF">14417,189 μs</td><td align="right" bgcolor="#FFFFFF">14460,631 μs</td><td align="right" bgcolor="#FF4949">15260,112 μs</td><td align="right" bgcolor="#FFFFFF">15498,353 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,327 ms</td><td align="right" bgcolor="#FFFFFF">14,426 ms</td><td align="right" bgcolor="#FFFFFF">14,417 ms</td><td align="right" bgcolor="#FFFFFF">14,461 ms</td><td align="right" bgcolor="#FF4949">15,260 ms</td><td align="right" bgcolor="#FFFFFF">15,498 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">110</td><td align="right">110</td><td align="right">110</td><td align="right">110</td><td align="right">120</td><td align="right">60</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1144996</td><td align="right">1143169</td><td align="right">1166988</td><td align="right">1202065</td><td align="right">1266197</td><td align="right">1241624</td><tr>
<td>Allocated Kilobytes</td><td align="right">1118,160</td><td align="right">1116,376</td><td align="right">1139,637</td><td align="right">1173,892</td><td align="right">1236,521</td><td align="right">1212,523</td><tr>
<td>Allocated Megabytes</td><td align="right">1,092</td><td align="right">1,090</td><td align="right">1,113</td><td align="right">1,146</td><td align="right">1,208</td><td align="right">1,184</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">752575,762 ns</td><td align="right" bgcolor="#FFFFFF">771426,800 ns</td><td align="right" bgcolor="#FF4949">935318,053 ns</td><td align="right" bgcolor="#FFFFFF">956753,822 ns</td><td align="right" bgcolor="#FF4949">1488712,845 ns</td><td align="right" bgcolor="#FFFFFF">1472280,527 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">752,576 μs</td><td align="right" bgcolor="#FFFFFF">771,427 μs</td><td align="right" bgcolor="#FF4949">935,318 μs</td><td align="right" bgcolor="#FFFFFF">956,754 μs</td><td align="right" bgcolor="#FF4949">1488,713 μs</td><td align="right" bgcolor="#FFFFFF">1472,281 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,753 ms</td><td align="right" bgcolor="#FFFFFF">0,771 ms</td><td align="right" bgcolor="#FF4949">0,935 ms</td><td align="right" bgcolor="#FFFFFF">0,957 ms</td><td align="right" bgcolor="#FF4949">1,489 ms</td><td align="right" bgcolor="#FFFFFF">1,472 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.4</td>
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">880</td><td align="right">880</td><td align="right">890</td><td align="right">900</td><td align="right">230</td><td align="right">470</td></tr>
<tr>
<td>Gen 1</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">129</td><td align="right">40</td><td align="right">71</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544313</td><td align="right">544216</td><td align="right">550092</td><td align="right">559308</td><td align="right">587133</td><td align="right">583227</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,556</td><td align="right">531,461</td><td align="right">537,199</td><td align="right">546,199</td><td align="right">573,372</td><td align="right">569,558</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,533</td><td align="right">0,560</td><td align="right">0,556</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94686,735 ns</td><td align="right" bgcolor="#FFFFFF">95062,279 ns</td><td align="right" bgcolor="#FF4949">139527,873 ns</td><td align="right" bgcolor="#FF4949">151676,619 ns</td><td align="right" bgcolor="#FF4949">605176,865 ns</td><td align="right" bgcolor="#FFFFFF">601959,749 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">94,687 μs</td><td align="right" bgcolor="#FFFFFF">95,062 μs</td><td align="right" bgcolor="#FF4949">139,528 μs</td><td align="right" bgcolor="#FF4949">151,677 μs</td><td align="right" bgcolor="#FF4949">605,177 μs</td><td align="right" bgcolor="#FFFFFF">601,960 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,095 ms</td><td align="right" bgcolor="#FFFFFF">0,095 ms</td><td align="right" bgcolor="#FF4949">0,140 ms</td><td align="right" bgcolor="#FF4949">0,152 ms</td><td align="right" bgcolor="#FF4949">0,605 ms</td><td align="right" bgcolor="#FFFFFF">0,602 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
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
<td>Gen 0</td><td align="right">1500</td><td align="right">1500</td><td align="right">760</td><td align="right">780</td><td align="right">220</td><td align="right">220</td></tr>
<tr>
<td>Gen 1</td><td align="right">70</td><td align="right">51</td><td align="right">29</td><td align="right">30</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115961</td><td align="right">115910</td><td align="right">117560</td><td align="right">120560</td><td align="right">138493</td><td align="right">138115</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,243</td><td align="right">113,193</td><td align="right">114,805</td><td align="right">117,734</td><td align="right">135,247</td><td align="right">134,878</td><tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">330104,072 ns</td><td align="right" bgcolor="#FFFFFF">338621,292 ns</td><td align="right" bgcolor="#FF4949">497146,651 ns</td><td align="right" bgcolor="#FF4949">527023,301 ns</td><td align="right" bgcolor="#FF4949">1017232,058 ns</td><td align="right" bgcolor="#FFFFFF">1027024,013 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">330,104 μs</td><td align="right" bgcolor="#FFFFFF">338,621 μs</td><td align="right" bgcolor="#FF4949">497,147 μs</td><td align="right" bgcolor="#FF4949">527,023 μs</td><td align="right" bgcolor="#FF4949">1017,232 μs</td><td align="right" bgcolor="#FFFFFF">1027,024 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,330 ms</td><td align="right" bgcolor="#FFFFFF">0,339 ms</td><td align="right" bgcolor="#FF4949">0,497 ms</td><td align="right" bgcolor="#FF4949">0,527 ms</td><td align="right" bgcolor="#FF4949">1,017 ms</td><td align="right" bgcolor="#FFFFFF">1,027 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">1280</td><td align="right">1280</td><td align="right">650</td><td align="right">660</td><td align="right">350</td><td align="right">350</td></tr>
<tr>
<td>Gen 1</td><td align="right">100</td><td align="right">109</td><td align="right">58</td><td align="right">55</td><td align="right">40</td><td align="right">40</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396404</td><td align="right">396231</td><td align="right">402206</td><td align="right">411957</td><td align="right">437462</td><td align="right">435504</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,113</td><td align="right">386,944</td><td align="right">392,779</td><td align="right">402,302</td><td align="right">427,209</td><td align="right">425,297</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,415</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1627139,162 ns</td><td align="right" bgcolor="#FF4949">1689546,447 ns</td><td align="right" bgcolor="#FF4949">2352585,156 ns</td><td align="right" bgcolor="#FF4949">2698466,471 ns</td><td align="right" bgcolor="#FF4949">3165547,174 ns</td><td align="right" bgcolor="#FFFFFF">3126021,035 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1627,139 μs</td><td align="right" bgcolor="#FF4949">1689,546 μs</td><td align="right" bgcolor="#FF4949">2352,585 μs</td><td align="right" bgcolor="#FF4949">2698,466 μs</td><td align="right" bgcolor="#FF4949">3165,547 μs</td><td align="right" bgcolor="#FFFFFF">3126,021 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,627 ms</td><td align="right" bgcolor="#FF4949">1,690 ms</td><td align="right" bgcolor="#FF4949">2,353 ms</td><td align="right" bgcolor="#FF4949">2,698 ms</td><td align="right" bgcolor="#FF4949">3,166 ms</td><td align="right" bgcolor="#FFFFFF">3,126 ms</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
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
<td>Gen 0</td><td align="right">1460</td><td align="right">1460</td><td align="right">730</td><td align="right">750</td><td align="right">780</td><td align="right">770</td></tr>
<tr>
<td>Gen 1</td><td align="right">240</td><td align="right">240</td><td align="right">114</td><td align="right">120</td><td align="right">122</td><td align="right">124</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799947</td><td align="right">1799794</td><td align="right">1825970</td><td align="right">1868275</td><td align="right">1930911</td><td align="right">1921032</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,761</td><td align="right">1757,611</td><td align="right">1783,174</td><td align="right">1824,487</td><td align="right">1885,655</td><td align="right">1876,008</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,716</td><td align="right">1,741</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">1,832</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34752,045 ns</td><td align="right" bgcolor="#FF4949">38467,091 ns</td><td align="right" bgcolor="#A8D08D">35084,459 ns</td><td align="right" bgcolor="#A8D08D">34040,042 ns</td><td align="right" bgcolor="#FFFFFF">33970,247 ns</td><td align="right" bgcolor="#A8D08D">22440,535 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">34,752 μs</td><td align="right" bgcolor="#FF4949">38,467 μs</td><td align="right" bgcolor="#A8D08D">35,084 μs</td><td align="right" bgcolor="#A8D08D">34,040 μs</td><td align="right" bgcolor="#FFFFFF">33,970 μs</td><td align="right" bgcolor="#A8D08D">22,441 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FF4949">0,038 ms</td><td align="right" bgcolor="#A8D08D">0,035 ms</td><td align="right" bgcolor="#A8D08D">0,034 ms</td><td align="right" bgcolor="#FFFFFF">0,034 ms</td><td align="right" bgcolor="#A8D08D">0,022 ms</td></tr>
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
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
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
<td>Gen 0</td><td align="right">190</td><td align="right">190</td><td align="right">190</td><td align="right">190</td><td align="right">190</td><td align="right">300</td></tr>
<tr>
<td>Gen 1</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">65</td><td align="right">64</td><td align="right">105</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7543</td><td align="right">7639</td><td align="right">7639</td><td align="right">7535</td><td align="right">7511</td><td align="right">6075</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,366</td><td align="right">7,460</td><td align="right">7,460</td><td align="right">7,358</td><td align="right">7,335</td><td align="right">5,933</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


