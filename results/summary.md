# Benchmarks

Benchmark report generated on 28-nov-2016 18:18

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
## Table of contents
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

## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">301,550 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,302 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td></tr>
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
<td align="right">4.5.4</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">40</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,039</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">36,159 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,036 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">5,264 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,005 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">6,080 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,006 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,000 ms</td></tr>
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
<th> </th><th>4.5.4</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">9,698 ns</td><td align="right">9,657 ns</td><td align="right">9,620 ns</td><td align="right">9,960 ns</td><td align="right">10,181 ns</td><td align="right">5,469 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,005 μs</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1705</td><td align="right">1709</td><td align="right">1677</td><td align="right">1709</td><td align="right">745</td><td align="right">0</td></tr>
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

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">18,256 ns</td><td align="right">18,134 ns</td><td align="right">18,261 ns</td><td align="right">18,137 ns</td><td align="right">18,820 ns</td><td align="right">18,419 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td><td align="right">0,018 μs</td></tr>
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
<td align="right">4.5.4</td>
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
<td>Gen 0</td><td align="right">2043</td><td align="right">2039</td><td align="right">2043</td><td align="right">2023</td><td align="right">2023</td><td align="right">2035</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">14,464 ns</td><td align="right">14,556 ns</td><td align="right">14,673 ns</td><td align="right">15,078 ns</td><td align="right">15,193 ns</td><td align="right">14,776 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,014 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
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
<td align="right">4.5.4</td>
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
<td>Gen 0</td><td align="right">1067</td><td align="right">1067</td><td align="right">1075</td><td align="right">1071</td><td align="right">1047</td><td align="right">1071</td></tr>
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

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">566,014 ns</td><td align="right">543,937 ns</td><td align="right">544,566 ns</td><td align="right">562,431 ns</td><td align="right">285,403 ns</td><td align="right">281,891 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,566 μs</td><td align="right">0,544 μs</td><td align="right">0,545 μs</td><td align="right">0,562 μs</td><td align="right">0,285 μs</td><td align="right">0,282 μs</td></tr>
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
<td>Gen 0</td><td align="right">70</td><td align="right">98</td><td align="right">78</td><td align="right">127</td><td align="right">345</td><td align="right">277</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">224</td><td align="right">224</td><td align="right">224</td><td align="right">256</td><td align="right">216</td><td align="right">192</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,219</td><td align="right">0,219</td><td align="right">0,219</td><td align="right">0,250</td><td align="right">0,211</td><td align="right">0,188</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">847,060 ns</td><td align="right">857,506 ns</td><td align="right">895,872 ns</td><td align="right">861,429 ns</td><td align="right">581,095 ns</td><td align="right">685,473 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,847 μs</td><td align="right">0,858 μs</td><td align="right">0,896 μs</td><td align="right">0,861 μs</td><td align="right">0,581 μs</td><td align="right">0,685 μs</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">72</td><td align="right">56</td><td align="right">68</td><td align="right">79</td><td align="right">269</td><td align="right">265</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">392</td><td align="right">392</td><td align="right">392</td><td align="right">424</td><td align="right">384</td><td align="right">384</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,383</td><td align="right">0,383</td><td align="right">0,383</td><td align="right">0,414</td><td align="right">0,375</td><td align="right">0,375</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">783,263 ns</td><td align="right">778,394 ns</td><td align="right">781,315 ns</td><td align="right">775,871 ns</td><td align="right">511,810 ns</td><td align="right">526,183 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,783 μs</td><td align="right">0,778 μs</td><td align="right">0,781 μs</td><td align="right">0,776 μs</td><td align="right">0,512 μs</td><td align="right">0,526 μs</td></tr>
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
<td>Gen 0</td><td align="right">41</td><td align="right">37</td><td align="right">33</td><td align="right">71</td><td align="right">285</td><td align="right">285</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">384</td><td align="right">384</td><td align="right">384</td><td align="right">416</td><td align="right">376</td><td align="right">376</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,375</td><td align="right">0,375</td><td align="right">0,375</td><td align="right">0,406</td><td align="right">0,367</td><td align="right">0,367</td><tr>
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
<td>Average ns / operation</td><td align="right">137,326 ns</td><td align="right">152,935 ns</td><td align="right">179,785 ns</td><td align="right">156,275 ns</td><td align="right">154,039 ns</td><td align="right">164,082 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,137 μs</td><td align="right">0,153 μs</td><td align="right">0,180 μs</td><td align="right">0,156 μs</td><td align="right">0,154 μs</td><td align="right">0,164 μs</td></tr>
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
<td>Average ns / operation</td><td align="right">136,195 ns</td><td align="right">155,755 ns</td><td align="right">184,897 ns</td><td align="right">156,051 ns</td><td align="right">154,207 ns</td><td align="right">155,178 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,136 μs</td><td align="right">0,156 μs</td><td align="right">0,185 μs</td><td align="right">0,156 μs</td><td align="right">0,154 μs</td><td align="right">0,155 μs</td></tr>
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
<td>Average ns / operation</td><td align="right">134,692 ns</td><td align="right">150,122 ns</td><td align="right">174,470 ns</td><td align="right">147,942 ns</td><td align="right">148,982 ns</td><td align="right">152,997 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">0,135 μs</td><td align="right">0,150 μs</td><td align="right">0,174 μs</td><td align="right">0,148 μs</td><td align="right">0,149 μs</td><td align="right">0,153 μs</td></tr>
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

Slowest: 4.4.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1456,180 ns</td><td align="right">1573,691 ns</td><td align="right">1785,713 ns</td><td align="right">1785,257 ns</td><td align="right">1704,883 ns</td><td align="right">1406,091 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,456 μs</td><td align="right">1,574 μs</td><td align="right">1,786 μs</td><td align="right">1,785 μs</td><td align="right">1,705 μs</td><td align="right">1,406 μs</td></tr>
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
<td>Gen 0</td><td align="right">101</td><td align="right">0</td><td align="right">0</td><td align="right">12</td><td align="right">8</td><td align="right">56</td></tr>
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

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1842,152 ns</td><td align="right">1857,887 ns</td><td align="right">1684,471 ns</td><td align="right">1871,545 ns</td><td align="right">1833,565 ns</td><td align="right">1707,470 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,842 μs</td><td align="right">1,858 μs</td><td align="right">1,684 μs</td><td align="right">1,872 μs</td><td align="right">1,834 μs</td><td align="right">1,707 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
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
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">12</td><td align="right">0</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1325,190 ns</td><td align="right">1602,482 ns</td><td align="right">1513,290 ns</td><td align="right">1642,135 ns</td><td align="right">1716,334 ns</td><td align="right">1481,200 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1,325 μs</td><td align="right">1,602 μs</td><td align="right">1,513 μs</td><td align="right">1,642 μs</td><td align="right">1,716 μs</td><td align="right">1,481 μs</td></tr>
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
<td align="right">4.5.4</td>
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
<td>Gen 0</td><td align="right">102</td><td align="right">105</td><td align="right">97</td><td align="right">12</td><td align="right">4</td><td align="right">53</td></tr>
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
<td>Average ns / operation</td><td align="right">250812,634 ns</td><td align="right">252524,094 ns</td><td align="right">258839,221 ns</td><td align="right">268027,305 ns</td><td align="right">673549,229 ns</td><td align="right">664868,733 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">250,813 μs</td><td align="right">252,524 μs</td><td align="right">258,839 μs</td><td align="right">268,027 μs</td><td align="right">673,549 μs</td><td align="right">664,869 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,251 ms</td><td align="right">0,253 ms</td><td align="right">0,259 ms</td><td align="right">0,268 ms</td><td align="right">0,674 ms</td><td align="right">0,665 ms</td></tr>
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
<td>Gen 0</td><td align="right">44</td><td align="right">32</td><td align="right">16</td><td align="right">55</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">79520</td><td align="right">79520</td><td align="right">80840</td><td align="right">85166</td><td align="right">110028</td><td align="right">109863</td><tr>
<td>Allocated Kilobytes</td><td align="right">77,656</td><td align="right">77,656</td><td align="right">78,945</td><td align="right">83,170</td><td align="right">107,449</td><td align="right">107,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,076</td><td align="right">0,076</td><td align="right">0,077</td><td align="right">0,081</td><td align="right">0,105</td><td align="right">0,105</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">51281,239 ns</td><td align="right">51740,183 ns</td><td align="right">56436,173 ns</td><td align="right">58391,408 ns</td><td align="right">426562,228 ns</td><td align="right">429854,279 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">51,281 μs</td><td align="right">51,740 μs</td><td align="right">56,436 μs</td><td align="right">58,391 μs</td><td align="right">426,562 μs</td><td align="right">429,854 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,051 ms</td><td align="right">0,052 ms</td><td align="right">0,056 ms</td><td align="right">0,058 ms</td><td align="right">0,427 ms</td><td align="right">0,430 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">36</td><td align="right">24</td><td align="right">28</td><td align="right">27</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">19824</td><td align="right">19824</td><td align="right">20166</td><td align="right">21464</td><td align="right">39041</td><td align="right">38943</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,359</td><td align="right">19,359</td><td align="right">19,693</td><td align="right">20,961</td><td align="right">38,126</td><td align="right">38,030</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,020</td><td align="right">0,037</td><td align="right">0,037</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">172972,419 ns</td><td align="right">168855,736 ns</td><td align="right">174666,827 ns</td><td align="right">186157,299 ns</td><td align="right">574976,536 ns</td><td align="right">573056,760 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">172,972 μs</td><td align="right">168,856 μs</td><td align="right">174,667 μs</td><td align="right">186,157 μs</td><td align="right">574,977 μs</td><td align="right">573,057 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,173 ms</td><td align="right">0,169 ms</td><td align="right">0,175 ms</td><td align="right">0,186 ms</td><td align="right">0,575 ms</td><td align="right">0,573 ms</td></tr>
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
<td>Gen 0</td><td align="right">118</td><td align="right">126</td><td align="right">141</td><td align="right">160</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59121</td><td align="right">59122</td><td align="right">60459</td><td align="right">64846</td><td align="right">87643</td><td align="right">87470</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,735</td><td align="right">57,736</td><td align="right">59,042</td><td align="right">63,326</td><td align="right">85,589</td><td align="right">85,420</td><tr>
<td>Allocated Megabytes</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,083</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">836690,005 ns</td><td align="right">844760,400 ns</td><td align="right">853369,352 ns</td><td align="right">918912,341 ns</td><td align="right">1390346,617 ns</td><td align="right">1373715,981 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">836,690 μs</td><td align="right">844,760 μs</td><td align="right">853,369 μs</td><td align="right">918,912 μs</td><td align="right">1390,347 μs</td><td align="right">1373,716 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,837 ms</td><td align="right">0,845 ms</td><td align="right">0,853 ms</td><td align="right">0,919 ms</td><td align="right">1,390 ms</td><td align="right">1,374 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">18</td><td align="right">18</td><td align="right">10</td><td align="right">17</td><td align="right">55</td><td align="right">55</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">262613</td><td align="right">262613</td><td align="right">268903</td><td align="right">288600</td><td align="right">337023</td><td align="right">336489</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,458</td><td align="right">256,458</td><td align="right">262,601</td><td align="right">281,836</td><td align="right">329,124</td><td align="right">328,603</td><tr>
<td>Allocated Megabytes</td><td align="right">0,250</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,321</td><td align="right">0,321</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.2.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">17707791,256 ns</td><td align="right">16643548,379 ns</td><td align="right">16686178,864 ns</td><td align="right">16837246,789 ns</td><td align="right">17604434,165 ns</td><td align="right">17600016,512 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">17707,791 μs</td><td align="right">16643,548 μs</td><td align="right">16686,179 μs</td><td align="right">16837,247 μs</td><td align="right">17604,434 μs</td><td align="right">17600,017 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">17,708 ms</td><td align="right">16,644 ms</td><td align="right">16,686 ms</td><td align="right">16,837 ms</td><td align="right">17,604 ms</td><td align="right">17,600 ms</td></tr>
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
<td align="right">5.0.0</td>
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
<td>Allocated Bytes</td><td align="right">1429262</td><td align="right">1429262</td><td align="right">1455125</td><td align="right">1483791</td><td align="right">1559567</td><td align="right">1561615</td><tr>
<td>Allocated Kilobytes</td><td align="right">1395,764</td><td align="right">1395,764</td><td align="right">1421,021</td><td align="right">1449,015</td><td align="right">1523,015</td><td align="right">1525,015</td><tr>
<td>Allocated Megabytes</td><td align="right">1,363</td><td align="right">1,363</td><td align="right">1,388</td><td align="right">1,415</td><td align="right">1,487</td><td align="right">1,489</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">707661,350 ns</td><td align="right">696030,201 ns</td><td align="right">702259,784 ns</td><td align="right">706557,296 ns</td><td align="right">1103130,132 ns</td><td align="right">1125059,922 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">707,661 μs</td><td align="right">696,030 μs</td><td align="right">702,260 μs</td><td align="right">706,557 μs</td><td align="right">1103,130 μs</td><td align="right">1125,060 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,708 ms</td><td align="right">0,696 ms</td><td align="right">0,702 ms</td><td align="right">0,707 ms</td><td align="right">1,103 ms</td><td align="right">1,125 ms</td></tr>
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
<td>Allocated Bytes</td><td align="right">66421</td><td align="right">66421</td><td align="right">67376</td><td align="right">69216</td><td align="right">87723</td><td align="right">87450</td><tr>
<td>Allocated Kilobytes</td><td align="right">64,864</td><td align="right">64,864</td><td align="right">65,797</td><td align="right">67,594</td><td align="right">85,667</td><td align="right">85,400</td><tr>
<td>Allocated Megabytes</td><td align="right">0,063</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,066</td><td align="right">0,084</td><td align="right">0,083</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">2930971,583 ns</td><td align="right">2784500,705 ns</td><td align="right">2770844,770 ns</td><td align="right">2856742,526 ns</td><td align="right">3240579,156 ns</td><td align="right">3287312,107 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">2930,972 μs</td><td align="right">2784,501 μs</td><td align="right">2770,845 μs</td><td align="right">2856,743 μs</td><td align="right">3240,579 μs</td><td align="right">3287,312 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">2,931 ms</td><td align="right">2,785 ms</td><td align="right">2,771 ms</td><td align="right">2,857 ms</td><td align="right">3,241 ms</td><td align="right">3,287 ms</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">246724</td><td align="right">246750</td><td align="right">248783</td><td align="right">256130</td><td align="right">283650</td><td align="right">283522</td><tr>
<td>Allocated Kilobytes</td><td align="right">240,941</td><td align="right">240,967</td><td align="right">242,952</td><td align="right">250,127</td><td align="right">277,002</td><td align="right">276,877</td><tr>
<td>Allocated Megabytes</td><td align="right">0,235</td><td align="right">0,235</td><td align="right">0,237</td><td align="right">0,244</td><td align="right">0,271</td><td align="right">0,270</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">13827455,555 ns</td><td align="right">13175829,622 ns</td><td align="right">13079657,448 ns</td><td align="right">13687555,589 ns</td><td align="right">13956728,823 ns</td><td align="right">14519394,194 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">13827,456 μs</td><td align="right">13175,830 μs</td><td align="right">13079,657 μs</td><td align="right">13687,556 μs</td><td align="right">13956,729 μs</td><td align="right">14519,394 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">13,827 ms</td><td align="right">13,176 ms</td><td align="right">13,080 ms</td><td align="right">13,688 ms</td><td align="right">13,957 ms</td><td align="right">14,519 ms</td></tr>
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
<td align="right">5.0.0</td>
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
<td>Allocated Bytes</td><td align="right">1150026</td><td align="right">1150026</td><td align="right">1159270</td><td align="right">1203723</td><td align="right">1267211</td><td align="right">1268233</td><tr>
<td>Allocated Kilobytes</td><td align="right">1123,072</td><td align="right">1123,072</td><td align="right">1132,100</td><td align="right">1175,511</td><td align="right">1237,511</td><td align="right">1238,509</td><tr>
<td>Allocated Megabytes</td><td align="right">1,097</td><td align="right">1,097</td><td align="right">1,106</td><td align="right">1,148</td><td align="right">1,209</td><td align="right">1,209</td></tr>
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
<td>Average ns / operation</td><td align="right">715116,162 ns</td><td align="right">728415,322 ns</td><td align="right">881286,859 ns</td><td align="right">902004,830 ns</td><td align="right">1379594,818 ns</td><td align="right">1359817,152 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">715,116 μs</td><td align="right">728,415 μs</td><td align="right">881,287 μs</td><td align="right">902,005 μs</td><td align="right">1379,595 μs</td><td align="right">1359,817 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,715 ms</td><td align="right">0,728 ms</td><td align="right">0,881 ms</td><td align="right">0,902 ms</td><td align="right">1,380 ms</td><td align="right">1,360 ms</td></tr>
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
<td>Gen 0</td><td align="right">520</td><td align="right">528</td><td align="right">178</td><td align="right">194</td><td align="right">205</td><td align="right">205</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544348</td><td align="right">544341</td><td align="right">550235</td><td align="right">559516</td><td align="right">587122</td><td align="right">587002</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,590</td><td align="right">531,583</td><td align="right">537,339</td><td align="right">546,402</td><td align="right">573,361</td><td align="right">573,244</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,534</td><td align="right">0,560</td><td align="right">0,560</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">88379,910 ns</td><td align="right">90252,173 ns</td><td align="right">132565,810 ns</td><td align="right">142241,454 ns</td><td align="right">521297,913 ns</td><td align="right">529197,025 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">88,380 μs</td><td align="right">90,252 μs</td><td align="right">132,566 μs</td><td align="right">142,241 μs</td><td align="right">521,298 μs</td><td align="right">529,197 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,088 ms</td><td align="right">0,090 ms</td><td align="right">0,133 ms</td><td align="right">0,142 ms</td><td align="right">0,521 ms</td><td align="right">0,529 ms</td></tr>
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
<td>Gen 0</td><td align="right">411</td><td align="right">981</td><td align="right">422</td><td align="right">430</td><td align="right">29</td><td align="right">33</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115961</td><td align="right">115961</td><td align="right">117638</td><td align="right">120588</td><td align="right">138491</td><td align="right">138417</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,243</td><td align="right">113,243</td><td align="right">114,881</td><td align="right">117,762</td><td align="right">135,245</td><td align="right">135,173</td><tr>
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
<td>Average ns / operation</td><td align="right">328026,194 ns</td><td align="right">329265,156 ns</td><td align="right">465127,015 ns</td><td align="right">492736,113 ns</td><td align="right">924344,185 ns</td><td align="right">926576,750 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">328,026 μs</td><td align="right">329,265 μs</td><td align="right">465,127 μs</td><td align="right">492,736 μs</td><td align="right">924,344 μs</td><td align="right">926,577 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,328 ms</td><td align="right">0,329 ms</td><td align="right">0,465 ms</td><td align="right">0,493 ms</td><td align="right">0,924 ms</td><td align="right">0,927 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">808</td><td align="right">808</td><td align="right">328</td><td align="right">327</td><td align="right">119</td><td align="right">127</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396409</td><td align="right">396408</td><td align="right">402325</td><td align="right">412037</td><td align="right">437381</td><td align="right">437253</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,118</td><td align="right">387,117</td><td align="right">392,896</td><td align="right">402,380</td><td align="right">427,130</td><td align="right">427,005</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,417</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">1549548,484 ns</td><td align="right">1592555,552 ns</td><td align="right">2198560,640 ns</td><td align="right">2365637,139 ns</td><td align="right">2849535,467 ns</td><td align="right">3058245,584 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">1549,548 μs</td><td align="right">1592,556 μs</td><td align="right">2198,561 μs</td><td align="right">2365,637 μs</td><td align="right">2849,535 μs</td><td align="right">3058,246 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">1,550 ms</td><td align="right">1,593 ms</td><td align="right">2,199 ms</td><td align="right">2,366 ms</td><td align="right">2,850 ms</td><td align="right">3,058 ms</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">416</td><td align="right">948</td><td align="right">404</td><td align="right">431</td><td align="right">433</td><td align="right">434</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">48</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1800006</td><td align="right">1799911</td><td align="right">1826443</td><td align="right">1868794</td><td align="right">1930773</td><td align="right">1930305</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,818</td><td align="right">1757,726</td><td align="right">1783,636</td><td align="right">1824,994</td><td align="right">1885,521</td><td align="right">1885,063</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,717</td><td align="right">1,742</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">1,841</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right">30806,568 ns</td><td align="right">33383,024 ns</td><td align="right">34109,391 ns</td><td align="right">35128,758 ns</td><td align="right">32428,208 ns</td><td align="right">23127,913 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right">30,807 μs</td><td align="right">33,383 μs</td><td align="right">34,109 μs</td><td align="right">35,129 μs</td><td align="right">32,428 μs</td><td align="right">23,128 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right">0,031 ms</td><td align="right">0,033 ms</td><td align="right">0,034 ms</td><td align="right">0,035 ms</td><td align="right">0,032 ms</td><td align="right">0,023 ms</td></tr>
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
<td>Gen 0</td><td align="right">1</td><td align="right">0</td><td align="right">0</td><td align="right">7</td><td align="right">0</td><td align="right">73</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7625</td><td align="right">7747</td><td align="right">7676</td><td align="right">7541</td><td align="right">7548</td><td align="right">6195</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,446</td><td align="right">7,565</td><td align="right">7,496</td><td align="right">7,364</td><td align="right">7,371</td><td align="right">6,050</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


