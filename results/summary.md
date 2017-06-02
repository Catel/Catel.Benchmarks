# Benchmarks

Benchmark report generated on 02-jun-2017 10:56

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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">120,121 ns</td><td align="right" bgcolor="#FFFFFF">121,469 ns</td><td align="right" bgcolor="#FFFFFF">120,611 ns</td><td align="right" bgcolor="#FF4949">246,835 ns</td><td align="right" bgcolor="#FFFFFF">242,016 ns</td><td align="right" bgcolor="#FFFFFF">246,987 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FF4949">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td></tr>
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
<td>Gen 0</td><td align="right">225</td><td align="right">285</td><td align="right">225</td><td align="right">675</td><td align="right">675</td><td align="right">675</td></tr>
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

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">121,893 ns</td><td align="right" bgcolor="#FFFFFF">121,641 ns</td><td align="right" bgcolor="#FFFFFF">122,328 ns</td><td align="right" bgcolor="#FF4949">252,996 ns</td><td align="right" bgcolor="#FFFFFF">249,272 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FF4949">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th></tr>
<tr>
<td>Gen 0</td><td align="right">225</td><td align="right">225</td><td align="right">225</td><td align="right">675</td><td align="right">675</td></tr>
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

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,071 ns</td><td align="right" bgcolor="#FFFFFF">96,925 ns</td><td align="right" bgcolor="#A8D08D">93,937 ns</td><td align="right" bgcolor="#FF4949">228,946 ns</td><td align="right" bgcolor="#FFFFFF">224,634 ns</td><td align="right" bgcolor="#FFFFFF">218,594 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#A8D08D">0,094 μs</td><td align="right" bgcolor="#FF4949">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">465</td><td align="right">465</td><td align="right">465</td><td align="right">585</td><td align="right">1185</td><td align="right">1185</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">316,220 ns</td><td align="right" bgcolor="#FFFFFF">320,135 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td></tr>
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
<td>Gen 0</td><td align="right">315</td><td align="right">315</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">108,188 ns</td><td align="right" bgcolor="#FFFFFF">108,145 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td></tr>
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
<td>Gen 0</td><td align="right">465</td><td align="right">465</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,645 ns</td><td align="right" bgcolor="#FFFFFF">11,512 ns</td></tr>
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
<td>Gen 0</td><td align="right">3825</td><td align="right">3825</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,775 ns</td><td align="right" bgcolor="#FFFFFF">12,727 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr>
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
<td>Gen 0</td><td align="right">3825</td><td align="right">3825</td></tr>
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

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,992 ns</td><td align="right" bgcolor="#FFFFFF">4,945 ns</td><td align="right" bgcolor="#FFFFFF">4,982 ns</td><td align="right" bgcolor="#FF4949">5,213 ns</td><td align="right" bgcolor="#FFFFFF">5,180 ns</td><td align="right" bgcolor="#FFFFFF">5,219 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FF4949">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,794 ns</td><td align="right" bgcolor="#A8D08D">17,781 ns</td><td align="right" bgcolor="#FF4949">18,742 ns</td><td align="right" bgcolor="#FFFFFF">18,623 ns</td><td align="right" bgcolor="#FFFFFF">18,289 ns</td><td align="right" bgcolor="#FFFFFF">18,247 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs</td><td align="right" bgcolor="#FF4949">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">5066</td><td align="right">4470</td><td align="right">4470</td><td align="right">5662</td><td align="right">4470</td><td align="right">4470</td></tr>
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

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,955 ns</td><td align="right" bgcolor="#A8D08D">14,446 ns</td><td align="right" bgcolor="#FFFFFF">14,439 ns</td><td align="right" bgcolor="#FF4949">15,188 ns</td><td align="right" bgcolor="#FFFFFF">15,156 ns</td><td align="right" bgcolor="#FFFFFF">15,512 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#A8D08D">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FF4949">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2550</td><td align="right">2550</td><td align="right">3400</td><td align="right">2550</td><td align="right">4080</td><td align="right">2550</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">568,913 ns</td><td align="right" bgcolor="#A8D08D">549,913 ns</td><td align="right" bgcolor="#FFFFFF">562,566 ns</td><td align="right" bgcolor="#FFFFFF">569,825 ns</td><td align="right" bgcolor="#A8D08D">442,703 ns</td><td align="right" bgcolor="#A8D08D">346,256 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,569 μs</td><td align="right" bgcolor="#A8D08D">0,550 μs</td><td align="right" bgcolor="#FFFFFF">0,563 μs</td><td align="right" bgcolor="#FFFFFF">0,570 μs</td><td align="right" bgcolor="#A8D08D">0,443 μs</td><td align="right" bgcolor="#A8D08D">0,346 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">858</td><td align="right">495</td><td align="right">825</td><td align="right">608</td><td align="right">945</td><td align="right">1007</td></tr>
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

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">895,107 ns</td><td align="right" bgcolor="#FFFFFF">875,064 ns</td><td align="right" bgcolor="#FFFFFF">883,620 ns</td><td align="right" bgcolor="#FFFFFF">876,391 ns</td><td align="right" bgcolor="#A8D08D">747,612 ns</td><td align="right" bgcolor="#A8D08D">669,535 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,895 μs</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td><td align="right" bgcolor="#FFFFFF">0,876 μs</td><td align="right" bgcolor="#A8D08D">0,748 μs</td><td align="right" bgcolor="#A8D08D">0,670 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">975</td><td align="right">975</td><td align="right">1170</td><td align="right">1050</td><td align="right">945</td><td align="right">870</td></tr>
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

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">813,804 ns</td><td align="right" bgcolor="#FFFFFF">799,502 ns</td><td align="right" bgcolor="#FFFFFF">809,514 ns</td><td align="right" bgcolor="#FFFFFF">812,000 ns</td><td align="right" bgcolor="#A8D08D">595,730 ns</td><td align="right" bgcolor="#FFFFFF">585,540 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,800 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#A8D08D">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs</td></tr>
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
<td>Gen 0</td><td align="right">1008</td><td align="right">945</td><td align="right">945</td><td align="right">1035</td><td align="right">930</td><td align="right">855</td></tr>
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

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,640 ns</td><td align="right" bgcolor="#FFFFFF">125,438 ns</td><td align="right" bgcolor="#FF4949">143,713 ns</td><td align="right" bgcolor="#A8D08D">121,375 ns</td><td align="right" bgcolor="#FFFFFF">122,308 ns</td><td align="right" bgcolor="#FFFFFF">119,191 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FF4949">0,144 μs</td><td align="right" bgcolor="#A8D08D">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">119,935 ns</td><td align="right" bgcolor="#FFFFFF">121,650 ns</td><td align="right" bgcolor="#FF4949">144,413 ns</td><td align="right" bgcolor="#A8D08D">126,046 ns</td><td align="right" bgcolor="#FF4949">208,105 ns</td><td align="right" bgcolor="#A8D08D">120,101 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FF4949">0,144 μs</td><td align="right" bgcolor="#A8D08D">0,126 μs</td><td align="right" bgcolor="#FF4949">0,208 μs</td><td align="right" bgcolor="#A8D08D">0,120 μs</td></tr>
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


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,949 ns</td><td align="right" bgcolor="#FF4949">128,725 ns</td><td align="right" bgcolor="#FF4949">141,531 ns</td><td align="right" bgcolor="#A8D08D">114,184 ns</td><td align="right" bgcolor="#FFFFFF">113,960 ns</td><td align="right" bgcolor="#FFFFFF">112,312 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FF4949">0,129 μs</td><td align="right" bgcolor="#FF4949">0,142 μs</td><td align="right" bgcolor="#A8D08D">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr>
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

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1674,262 ns</td><td align="right" bgcolor="#A8D08D">1564,675 ns</td><td align="right" bgcolor="#FF4949">1625,202 ns</td><td align="right" bgcolor="#FFFFFF">1673,432 ns</td><td align="right" bgcolor="#FFFFFF">1642,373 ns</td><td align="right" bgcolor="#A8D08D">1353,861 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,674 μs</td><td align="right" bgcolor="#A8D08D">1,565 μs</td><td align="right" bgcolor="#FF4949">1,625 μs</td><td align="right" bgcolor="#FFFFFF">1,673 μs</td><td align="right" bgcolor="#FFFFFF">1,642 μs</td><td align="right" bgcolor="#A8D08D">1,354 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td>Gen 0</td><td align="right">585</td><td align="right">615</td><td align="right">738</td><td align="right">765</td><td align="right">765</td><td align="right">495</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1717,114 ns</td><td align="right" bgcolor="#FFFFFF">1704,175 ns</td><td align="right" bgcolor="#A8D08D">1592,737 ns</td><td align="right" bgcolor="#FF4949">1794,517 ns</td><td align="right" bgcolor="#FF4949">2042,450 ns</td><td align="right" bgcolor="#A8D08D">1355,651 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,717 μs</td><td align="right" bgcolor="#FFFFFF">1,704 μs</td><td align="right" bgcolor="#A8D08D">1,593 μs</td><td align="right" bgcolor="#FF4949">1,795 μs</td><td align="right" bgcolor="#FF4949">2,042 μs</td><td align="right" bgcolor="#A8D08D">1,356 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td>Gen 0</td><td align="right">585</td><td align="right">615</td><td align="right">615</td><td align="right">765</td><td align="right">765</td><td align="right">528</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1368,907 ns</td><td align="right" bgcolor="#A8D08D">1325,960 ns</td><td align="right" bgcolor="#FF4949">1388,004 ns</td><td align="right" bgcolor="#FF4949">1559,613 ns</td><td align="right" bgcolor="#A8D08D">1507,306 ns</td><td align="right" bgcolor="#A8D08D">1203,929 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,369 μs</td><td align="right" bgcolor="#A8D08D">1,326 μs</td><td align="right" bgcolor="#FF4949">1,388 μs</td><td align="right" bgcolor="#FF4949">1,560 μs</td><td align="right" bgcolor="#A8D08D">1,507 μs</td><td align="right" bgcolor="#A8D08D">1,204 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">592</td><td align="right">858</td><td align="right">585</td><td align="right">735</td><td align="right">735</td><td align="right">465</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">89,793 ns</td><td align="right" bgcolor="#FFFFFF">89,286 ns</td><td align="right" bgcolor="#FFFFFF">89,133 ns</td><td align="right" bgcolor="#A8D08D">74,208 ns</td><td align="right" bgcolor="#FFFFFF">73,462 ns</td><td align="right" bgcolor="#FFFFFF">72,025 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#A8D08D">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td></tr>
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


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">89,935 ns</td><td align="right" bgcolor="#FFFFFF">89,624 ns</td><td align="right" bgcolor="#FFFFFF">88,237 ns</td><td align="right" bgcolor="#A8D08D">73,025 ns</td><td align="right" bgcolor="#FFFFFF">73,660 ns</td><td align="right" bgcolor="#FFFFFF">73,173 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#A8D08D">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr>
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


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,427 ns</td><td align="right" bgcolor="#FFFFFF">95,890 ns</td><td align="right" bgcolor="#FFFFFF">94,720 ns</td><td align="right" bgcolor="#A8D08D">78,613 ns</td><td align="right" bgcolor="#FFFFFF">79,425 ns</td><td align="right" bgcolor="#FFFFFF">77,438 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#A8D08D">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr>
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


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">197,241 ns</td><td align="right" bgcolor="#FFFFFF">196,513 ns</td><td align="right" bgcolor="#FFFFFF">194,230 ns</td><td align="right" bgcolor="#A8D08D">167,784 ns</td><td align="right" bgcolor="#FFFFFF">166,527 ns</td><td align="right" bgcolor="#A8D08D">115,115 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#A8D08D">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#A8D08D">0,115 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">225</td><td align="right">225</td><td align="right">225</td><td align="right">225</td><td align="right">225</td><td align="right">0</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,672 ns</td><td align="right" bgcolor="#FFFFFF">189,058 ns</td><td align="right" bgcolor="#FFFFFF">189,124 ns</td><td align="right" bgcolor="#A8D08D">165,839 ns</td><td align="right" bgcolor="#FFFFFF">165,965 ns</td><td align="right" bgcolor="#A8D08D">110,291 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#A8D08D">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#A8D08D">0,110 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms</td></tr>
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
<td>Gen 0</td><td align="right">225</td><td align="right">225</td><td align="right">225</td><td align="right">330</td><td align="right">315</td><td align="right">0</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,567 ns</td><td align="right" bgcolor="#FFFFFF">94,735 ns</td><td align="right" bgcolor="#FFFFFF">96,335 ns</td><td align="right" bgcolor="#A8D08D">70,109 ns</td><td align="right" bgcolor="#FFFFFF">68,187 ns</td><td align="right" bgcolor="#FF4949">70,783 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#A8D08D">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FF4949">0,071 μs</td></tr>
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


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">275350,562 ns</td><td align="right" bgcolor="#FFFFFF">273340,166 ns</td><td align="right" bgcolor="#FF4949">284869,142 ns</td><td align="right" bgcolor="#FFFFFF">292684,857 ns</td><td align="right" bgcolor="#FF4949">753217,005 ns</td><td align="right" bgcolor="#FFFFFF">744250,945 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">275,351 μs</td><td align="right" bgcolor="#FFFFFF">273,340 μs</td><td align="right" bgcolor="#FF4949">284,869 μs</td><td align="right" bgcolor="#FFFFFF">292,685 μs</td><td align="right" bgcolor="#FF4949">753,217 μs</td><td align="right" bgcolor="#FFFFFF">744,251 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td><td align="right" bgcolor="#FFFFFF">0,273 ms</td><td align="right" bgcolor="#FF4949">0,285 ms</td><td align="right" bgcolor="#FFFFFF">0,293 ms</td><td align="right" bgcolor="#FF4949">0,753 ms</td><td align="right" bgcolor="#FFFFFF">0,744 ms</td></tr>
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
<td>Gen 0</td><td align="right">375</td><td align="right">375</td><td align="right">390</td><td align="right">405</td><td align="right">255</td><td align="right">255</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">45</td><td align="right">45</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">80223</td><td align="right">80079</td><td align="right">81403</td><td align="right">85723</td><td align="right">110736</td><td align="right">106806</td><tr>
<td>Allocated Kilobytes</td><td align="right">78,343</td><td align="right">78,202</td><td align="right">79,495</td><td align="right">83,714</td><td align="right">108,141</td><td align="right">104,303</td><tr>
<td>Allocated Megabytes</td><td align="right">0,077</td><td align="right">0,076</td><td align="right">0,078</td><td align="right">0,082</td><td align="right">0,106</td><td align="right">0,102</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58037,457 ns</td><td align="right" bgcolor="#FFFFFF">57024,081 ns</td><td align="right" bgcolor="#FF4949">59474,804 ns</td><td align="right" bgcolor="#FF4949">64484,751 ns</td><td align="right" bgcolor="#FF4949">497195,280 ns</td><td align="right" bgcolor="#FFFFFF">491286,894 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">58,037 μs</td><td align="right" bgcolor="#FFFFFF">57,024 μs</td><td align="right" bgcolor="#FF4949">59,475 μs</td><td align="right" bgcolor="#FF4949">64,485 μs</td><td align="right" bgcolor="#FF4949">497,195 μs</td><td align="right" bgcolor="#FFFFFF">491,287 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,058 ms</td><td align="right" bgcolor="#FFFFFF">0,057 ms</td><td align="right" bgcolor="#FF4949">0,059 ms</td><td align="right" bgcolor="#FF4949">0,064 ms</td><td align="right" bgcolor="#FF4949">0,497 ms</td><td align="right" bgcolor="#FFFFFF">0,491 ms</td></tr>
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
<td>Gen 0</td><td align="right">1224</td><td align="right">765</td><td align="right">390</td><td align="right">405</td><td align="right">90</td><td align="right">90</td></tr>
<tr>
<td>Gen 1</td><td align="right">48</td><td align="right">30</td><td align="right">15</td><td align="right">15</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">19999</td><td align="right">19928</td><td align="right">20270</td><td align="right">21569</td><td align="right">39225</td><td align="right">38801</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,530</td><td align="right">19,461</td><td align="right">19,795</td><td align="right">21,063</td><td align="right">38,306</td><td align="right">37,892</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,021</td><td align="right">0,037</td><td align="right">0,037</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201412,251 ns</td><td align="right" bgcolor="#A8D08D">184230,239 ns</td><td align="right" bgcolor="#FF4949">194143,846 ns</td><td align="right" bgcolor="#FFFFFF">198508,862 ns</td><td align="right" bgcolor="#FF4949">659218,211 ns</td><td align="right" bgcolor="#FFFFFF">650878,071 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">201,412 μs</td><td align="right" bgcolor="#A8D08D">184,230 μs</td><td align="right" bgcolor="#FF4949">194,144 μs</td><td align="right" bgcolor="#FFFFFF">198,509 μs</td><td align="right" bgcolor="#FF4949">659,218 μs</td><td align="right" bgcolor="#FFFFFF">650,878 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,201 ms</td><td align="right" bgcolor="#A8D08D">0,184 ms</td><td align="right" bgcolor="#FF4949">0,194 ms</td><td align="right" bgcolor="#FFFFFF">0,199 ms</td><td align="right" bgcolor="#FF4949">0,659 ms</td><td align="right" bgcolor="#FFFFFF">0,651 ms</td></tr>
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
<td>Gen 0</td><td align="right">570</td><td align="right">570</td><td align="right">585</td><td align="right">630</td><td align="right">210</td><td align="right">195</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">30</td><td align="right">45</td><td align="right">45</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59384</td><td align="right">59242</td><td align="right">60582</td><td align="right">64970</td><td align="right">87914</td><td align="right">85931</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,992</td><td align="right">57,854</td><td align="right">59,162</td><td align="right">63,447</td><td align="right">85,854</td><td align="right">83,917</td><tr>
<td>Allocated Megabytes</td><td align="right">0,057</td><td align="right">0,056</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,082</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">963589,160 ns</td><td align="right" bgcolor="#A8D08D">907739,982 ns</td><td align="right" bgcolor="#FF4949">937438,822 ns</td><td align="right" bgcolor="#FF4949">966982,732 ns</td><td align="right" bgcolor="#FF4949">1486250,742 ns</td><td align="right" bgcolor="#FFFFFF">1483136,732 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">963,589 μs</td><td align="right" bgcolor="#A8D08D">907,740 μs</td><td align="right" bgcolor="#FF4949">937,439 μs</td><td align="right" bgcolor="#FF4949">966,983 μs</td><td align="right" bgcolor="#FF4949">1486,251 μs</td><td align="right" bgcolor="#FFFFFF">1483,137 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,964 ms</td><td align="right" bgcolor="#A8D08D">0,908 ms</td><td align="right" bgcolor="#FF4949">0,937 ms</td><td align="right" bgcolor="#FF4949">0,967 ms</td><td align="right" bgcolor="#FF4949">1,486 ms</td><td align="right" bgcolor="#FFFFFF">1,483 ms</td></tr>
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
<td align="right">4.5.0</td>
<td align="right">4.4.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">630</td><td align="right">630</td><td align="right">645</td><td align="right">345</td><td align="right">405</td><td align="right">390</td></tr>
<tr>
<td>Gen 1</td><td align="right">84</td><td align="right">75</td><td align="right">90</td><td align="right">45</td><td align="right">75</td><td align="right">75</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">263122</td><td align="right">262616</td><td align="right">268910</td><td align="right">288620</td><td align="right">337554</td><td align="right">327787</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,955</td><td align="right">256,461</td><td align="right">262,607</td><td align="right">281,855</td><td align="right">329,643</td><td align="right">320,104</td><tr>
<td>Allocated Megabytes</td><td align="right">0,251</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,322</td><td align="right">0,313</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18356338,143 ns</td><td align="right" bgcolor="#FFFFFF">17930872,760 ns</td><td align="right" bgcolor="#FFFFFF">17971804,107 ns</td><td align="right" bgcolor="#FFFFFF">18026533,462 ns</td><td align="right" bgcolor="#FF4949">18764256,272 ns</td><td align="right" bgcolor="#FFFFFF">18768181,563 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18356,338 μs</td><td align="right" bgcolor="#FFFFFF">17930,873 μs</td><td align="right" bgcolor="#FFFFFF">17971,804 μs</td><td align="right" bgcolor="#FFFFFF">18026,533 μs</td><td align="right" bgcolor="#FF4949">18764,256 μs</td><td align="right" bgcolor="#FFFFFF">18768,182 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">18,356 ms</td><td align="right" bgcolor="#FFFFFF">17,931 ms</td><td align="right" bgcolor="#FFFFFF">17,972 ms</td><td align="right" bgcolor="#FFFFFF">18,027 ms</td><td align="right" bgcolor="#FF4949">18,764 ms</td><td align="right" bgcolor="#FFFFFF">18,768 ms</td></tr>
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
<td align="right">4.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">105</td><td align="right">700</td><td align="right">119</td><td align="right">105</td><td align="right">105</td><td align="right">105</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">200</td><td align="right">34</td><td align="right">30</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1430549</td><td align="right">1431056</td><td align="right">1452571</td><td align="right">1490723</td><td align="right">1560847</td><td align="right">1537040</td><tr>
<td>Allocated Kilobytes</td><td align="right">1397,021</td><td align="right">1397,516</td><td align="right">1418,526</td><td align="right">1455,784</td><td align="right">1524,265</td><td align="right">1501,016</td><tr>
<td>Allocated Megabytes</td><td align="right">1,364</td><td align="right">1,365</td><td align="right">1,385</td><td align="right">1,422</td><td align="right">1,489</td><td align="right">1,466</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">762351,849 ns</td><td align="right" bgcolor="#FFFFFF">744862,168 ns</td><td align="right" bgcolor="#FFFFFF">754537,919 ns</td><td align="right" bgcolor="#FFFFFF">769751,659 ns</td><td align="right" bgcolor="#FF4949">1233808,188 ns</td><td align="right" bgcolor="#FFFFFF">1211859,328 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">762,352 μs</td><td align="right" bgcolor="#FFFFFF">744,862 μs</td><td align="right" bgcolor="#FFFFFF">754,538 μs</td><td align="right" bgcolor="#FFFFFF">769,752 μs</td><td align="right" bgcolor="#FF4949">1233,808 μs</td><td align="right" bgcolor="#FFFFFF">1211,859 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,762 ms</td><td align="right" bgcolor="#FFFFFF">0,745 ms</td><td align="right" bgcolor="#FFFFFF">0,755 ms</td><td align="right" bgcolor="#FFFFFF">0,770 ms</td><td align="right" bgcolor="#FF4949">1,234 ms</td><td align="right" bgcolor="#FFFFFF">1,212 ms</td></tr>
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
<td>Gen 0</td><td align="right">150</td><td align="right">150</td><td align="right">150</td><td align="right">165</td><td align="right">90</td><td align="right">90</td></tr>
<tr>
<td>Gen 1</td><td align="right">45</td><td align="right">30</td><td align="right">45</td><td align="right">45</td><td align="right">30</td><td align="right">30</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66606</td><td align="right">66442</td><td align="right">67281</td><td align="right">69755</td><td align="right">87173</td><td align="right">86424</td><tr>
<td>Allocated Kilobytes</td><td align="right">65,045</td><td align="right">64,885</td><td align="right">65,704</td><td align="right">68,120</td><td align="right">85,130</td><td align="right">84,398</td><tr>
<td>Allocated Megabytes</td><td align="right">0,064</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,067</td><td align="right">0,083</td><td align="right">0,082</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3028862,793 ns</td><td align="right" bgcolor="#FFFFFF">3034786,355 ns</td><td align="right" bgcolor="#FF4949">3187480,410 ns</td><td align="right" bgcolor="#A8D08D">3014357,266 ns</td><td align="right" bgcolor="#FF4949">3596501,146 ns</td><td align="right" bgcolor="#FFFFFF">3496882,884 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3028,863 μs</td><td align="right" bgcolor="#FFFFFF">3034,786 μs</td><td align="right" bgcolor="#FF4949">3187,480 μs</td><td align="right" bgcolor="#A8D08D">3014,357 μs</td><td align="right" bgcolor="#FF4949">3596,501 μs</td><td align="right" bgcolor="#FFFFFF">3496,883 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,029 ms</td><td align="right" bgcolor="#FFFFFF">3,035 ms</td><td align="right" bgcolor="#FF4949">3,187 ms</td><td align="right" bgcolor="#A8D08D">3,014 ms</td><td align="right" bgcolor="#FF4949">3,597 ms</td><td align="right" bgcolor="#FFFFFF">3,497 ms</td></tr>
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
<td>Gen 0</td><td align="right">135</td><td align="right">135</td><td align="right">135</td><td align="right">170</td><td align="right">165</td><td align="right">165</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">45</td><td align="right">45</td><td align="right">43</td><td align="right">45</td><td align="right">45</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">245634</td><td align="right">246147</td><td align="right">250243</td><td align="right">257595</td><td align="right">285752</td><td align="right">279785</td><tr>
<td>Allocated Kilobytes</td><td align="right">239,877</td><td align="right">240,378</td><td align="right">244,378</td><td align="right">251,558</td><td align="right">279,055</td><td align="right">273,228</td><tr>
<td>Allocated Megabytes</td><td align="right">0,234</td><td align="right">0,235</td><td align="right">0,239</td><td align="right">0,246</td><td align="right">0,273</td><td align="right">0,267</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14218864,967 ns</td><td align="right" bgcolor="#FFFFFF">14213849,291 ns</td><td align="right" bgcolor="#FF4949">15156057,109 ns</td><td align="right" bgcolor="#A8D08D">14421660,649 ns</td><td align="right" bgcolor="#FFFFFF">14838944,018 ns</td><td align="right" bgcolor="#FFFFFF">14888927,645 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14218,865 μs</td><td align="right" bgcolor="#FFFFFF">14213,849 μs</td><td align="right" bgcolor="#FF4949">15156,057 μs</td><td align="right" bgcolor="#A8D08D">14421,661 μs</td><td align="right" bgcolor="#FFFFFF">14838,944 μs</td><td align="right" bgcolor="#FFFFFF">14888,928 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,219 ms</td><td align="right" bgcolor="#FFFFFF">14,214 ms</td><td align="right" bgcolor="#FF4949">15,156 ms</td><td align="right" bgcolor="#A8D08D">14,422 ms</td><td align="right" bgcolor="#FFFFFF">14,839 ms</td><td align="right" bgcolor="#FFFFFF">14,889 ms</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Gen 0</td><td align="right">165</td><td align="right">165</td><td align="right">165</td><td align="right">165</td><td align="right">180</td><td align="right">180</td></tr>
<tr>
<td>Gen 1</td><td align="right">45</td><td align="right">45</td><td align="right">45</td><td align="right">45</td><td align="right">45</td><td align="right">45</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1144996</td><td align="right">1143319</td><td align="right">1166988</td><td align="right">1202064</td><td align="right">1266197</td><td align="right">1241898</td><tr>
<td>Allocated Kilobytes</td><td align="right">1118,160</td><td align="right">1116,522</td><td align="right">1139,637</td><td align="right">1173,891</td><td align="right">1236,521</td><td align="right">1212,791</td><tr>
<td>Allocated Megabytes</td><td align="right">1,092</td><td align="right">1,090</td><td align="right">1,113</td><td align="right">1,146</td><td align="right">1,208</td><td align="right">1,184</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">736482,721 ns</td><td align="right" bgcolor="#FF4949">776716,456 ns</td><td align="right" bgcolor="#FF4949">907421,491 ns</td><td align="right" bgcolor="#FF4949">944012,740 ns</td><td align="right" bgcolor="#FF4949">1441733,097 ns</td><td align="right" bgcolor="#FFFFFF">1467758,675 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">736,483 μs</td><td align="right" bgcolor="#FF4949">776,716 μs</td><td align="right" bgcolor="#FF4949">907,421 μs</td><td align="right" bgcolor="#FF4949">944,013 μs</td><td align="right" bgcolor="#FF4949">1441,733 μs</td><td align="right" bgcolor="#FFFFFF">1467,759 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FF4949">0,777 ms</td><td align="right" bgcolor="#FF4949">0,907 ms</td><td align="right" bgcolor="#FF4949">0,944 ms</td><td align="right" bgcolor="#FF4949">1,442 ms</td><td align="right" bgcolor="#FFFFFF">1,468 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2112</td><td align="right">1320</td><td align="right">1335</td><td align="right">1350</td><td align="right">705</td><td align="right">705</td></tr>
<tr>
<td>Gen 1</td><td align="right">292</td><td align="right">181</td><td align="right">180</td><td align="right">192</td><td align="right">120</td><td align="right">108</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544313</td><td align="right">544212</td><td align="right">550086</td><td align="right">559305</td><td align="right">587104</td><td align="right">583219</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,556</td><td align="right">531,457</td><td align="right">537,193</td><td align="right">546,196</td><td align="right">573,344</td><td align="right">569,550</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,533</td><td align="right">0,560</td><td align="right">0,556</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92965,802 ns</td><td align="right" bgcolor="#FFFFFF">95053,641 ns</td><td align="right" bgcolor="#FF4949">139167,108 ns</td><td align="right" bgcolor="#FF4949">150403,845 ns</td><td align="right" bgcolor="#FF4949">585252,624 ns</td><td align="right" bgcolor="#FFFFFF">585495,586 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">92,966 μs</td><td align="right" bgcolor="#FFFFFF">95,054 μs</td><td align="right" bgcolor="#FF4949">139,167 μs</td><td align="right" bgcolor="#FF4949">150,404 μs</td><td align="right" bgcolor="#FF4949">585,253 μs</td><td align="right" bgcolor="#FFFFFF">585,496 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,093 ms</td><td align="right" bgcolor="#FFFFFF">0,095 ms</td><td align="right" bgcolor="#FF4949">0,139 ms</td><td align="right" bgcolor="#FF4949">0,150 ms</td><td align="right" bgcolor="#FF4949">0,585 ms</td><td align="right" bgcolor="#FFFFFF">0,585 ms</td></tr>
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
<td>Gen 0</td><td align="right">2400</td><td align="right">2250</td><td align="right">1140</td><td align="right">1170</td><td align="right">330</td><td align="right">330</td></tr>
<tr>
<td>Gen 1</td><td align="right">112</td><td align="right">76</td><td align="right">44</td><td align="right">45</td><td align="right">45</td><td align="right">45</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115961</td><td align="right">115909</td><td align="right">117560</td><td align="right">120561</td><td align="right">138495</td><td align="right">138107</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,243</td><td align="right">113,192</td><td align="right">114,805</td><td align="right">117,735</td><td align="right">135,249</td><td align="right">134,870</td><tr>
<td>Allocated Megabytes</td><td align="right">0,111</td><td align="right">0,111</td><td align="right">0,112</td><td align="right">0,115</td><td align="right">0,132</td><td align="right">0,132</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">331511,262 ns</td><td align="right" bgcolor="#FFFFFF">335924,154 ns</td><td align="right" bgcolor="#FF4949">496169,277 ns</td><td align="right" bgcolor="#FF4949">515439,492 ns</td><td align="right" bgcolor="#FF4949">1007785,452 ns</td><td align="right" bgcolor="#FFFFFF">1006749,918 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">331,511 μs</td><td align="right" bgcolor="#FFFFFF">335,924 μs</td><td align="right" bgcolor="#FF4949">496,169 μs</td><td align="right" bgcolor="#FF4949">515,439 μs</td><td align="right" bgcolor="#FF4949">1007,785 μs</td><td align="right" bgcolor="#FFFFFF">1006,750 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,332 ms</td><td align="right" bgcolor="#FFFFFF">0,336 ms</td><td align="right" bgcolor="#FF4949">0,496 ms</td><td align="right" bgcolor="#FF4949">0,515 ms</td><td align="right" bgcolor="#FF4949">1,008 ms</td><td align="right" bgcolor="#FFFFFF">1,007 ms</td></tr>
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
<td align="right">5.0.0</td>
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
<td>Gen 0</td><td align="right">1920</td><td align="right">1920</td><td align="right">1950</td><td align="right">990</td><td align="right">525</td><td align="right">525</td></tr>
<tr>
<td>Gen 1</td><td align="right">165</td><td align="right">165</td><td align="right">170</td><td align="right">82</td><td align="right">60</td><td align="right">60</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396417</td><td align="right">396236</td><td align="right">402196</td><td align="right">411951</td><td align="right">437383</td><td align="right">435476</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,126</td><td align="right">386,949</td><td align="right">392,770</td><td align="right">402,296</td><td align="right">427,132</td><td align="right">425,270</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,415</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1624078,052 ns</td><td align="right" bgcolor="#FFFFFF">1654548,167 ns</td><td align="right" bgcolor="#FF4949">2281299,316 ns</td><td align="right" bgcolor="#FF4949">2458125,070 ns</td><td align="right" bgcolor="#FF4949">3048982,617 ns</td><td align="right" bgcolor="#FFFFFF">3086688,285 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1624,078 μs</td><td align="right" bgcolor="#FFFFFF">1654,548 μs</td><td align="right" bgcolor="#FF4949">2281,299 μs</td><td align="right" bgcolor="#FF4949">2458,125 μs</td><td align="right" bgcolor="#FF4949">3048,983 μs</td><td align="right" bgcolor="#FFFFFF">3086,688 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,624 ms</td><td align="right" bgcolor="#FFFFFF">1,655 ms</td><td align="right" bgcolor="#FF4949">2,281 ms</td><td align="right" bgcolor="#FF4949">2,458 ms</td><td align="right" bgcolor="#FF4949">3,049 ms</td><td align="right" bgcolor="#FFFFFF">3,087 ms</td></tr>
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
<td>Gen 0</td><td align="right">2628</td><td align="right">2190</td><td align="right">1095</td><td align="right">1125</td><td align="right">1170</td><td align="right">1155</td></tr>
<tr>
<td>Gen 1</td><td align="right">432</td><td align="right">360</td><td align="right">172</td><td align="right">180</td><td align="right">185</td><td align="right">189</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799941</td><td align="right">1799782</td><td align="right">1825939</td><td align="right">1868295</td><td align="right">1930644</td><td align="right">1921165</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,755</td><td align="right">1757,600</td><td align="right">1783,144</td><td align="right">1824,507</td><td align="right">1885,395</td><td align="right">1876,138</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,716</td><td align="right">1,741</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">1,832</td></tr>
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
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34933,355 ns</td><td align="right" bgcolor="#FFFFFF">34713,335 ns</td><td align="right" bgcolor="#FFFFFF">35275,914 ns</td><td align="right" bgcolor="#A8D08D">34034,155 ns</td><td align="right" bgcolor="#FFFFFF">33805,335 ns</td><td align="right" bgcolor="#A8D08D">23092,638 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">34,933 μs</td><td align="right" bgcolor="#FFFFFF">34,713 μs</td><td align="right" bgcolor="#FFFFFF">35,276 μs</td><td align="right" bgcolor="#A8D08D">34,034 μs</td><td align="right" bgcolor="#FFFFFF">33,805 μs</td><td align="right" bgcolor="#A8D08D">23,093 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#A8D08D">0,034 ms</td><td align="right" bgcolor="#FFFFFF">0,034 ms</td><td align="right" bgcolor="#A8D08D">0,023 ms</td></tr>
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
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">570</td><td align="right">513</td><td align="right">684</td><td align="right">551</td><td align="right">874</td><td align="right">570</td></tr>
<tr>
<td>Gen 1</td><td align="right">200</td><td align="right">178</td><td align="right">237</td><td align="right">187</td><td align="right">300</td><td align="right">203</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7546</td><td align="right">7654</td><td align="right">7755</td><td align="right">7542</td><td align="right">7578</td><td align="right">6146</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,369</td><td align="right">7,475</td><td align="right">7,573</td><td align="right">7,365</td><td align="right">7,400</td><td align="right">6,002</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


