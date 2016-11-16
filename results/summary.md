# Benchmarks

Benchmark report generated on 16-nov-2016 12:17

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


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

## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">303,208 ns</td><td align="right">302,533 ns</td></tr>
<tr>
<td align="right">0,303 μs</td><td align="right">0,303 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">35,964 ns</td><td align="right">35,882 ns</td></tr>
<tr>
<td align="right">0,036 μs</td><td align="right">0,036 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">5,445 ns</td><td align="right">5,398 ns</td></tr>
<tr>
<td align="right">0,005 μs</td><td align="right">0,005 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">6,061 ns</td><td align="right">6,001 ns</td></tr>
<tr>
<td align="right">0,006 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">9,538 ns</td><td align="right">9,724 ns</td><td align="right">9,620 ns</td><td align="right">9,970 ns</td><td align="right">10,129 ns</td><td align="right">9,838 ns</td></tr>
<tr>
<td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.5.0**

Slowest: 4.3.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">18,295 ns</td><td align="right">18,814 ns</td><td align="right">18,215 ns</td><td align="right">18,123 ns</td><td align="right">18,248 ns</td><td align="right">18,402 ns</td></tr>
<tr>
<td align="right">0,018 μs</td><td align="right">0,019 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">14,285 ns</td><td align="right">14,672 ns</td><td align="right">14,653 ns</td><td align="right">14,637 ns</td><td align="right">15,218 ns</td><td align="right">15,004 ns</td></tr>
<tr>
<td align="right">0,014 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **4.5.4**

Slowest: 4.2.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">573,849 ns</td><td align="right">548,228 ns</td><td align="right">543,835 ns</td><td align="right">550,345 ns</td><td align="right">286,121 ns</td><td align="right">556,718 ns</td></tr>
<tr>
<td align="right">0,574 μs</td><td align="right">0,548 μs</td><td align="right">0,544 μs</td><td align="right">0,550 μs</td><td align="right">0,286 μs</td><td align="right">0,557 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.5.4**

Slowest: 4.2.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">916,815 ns</td><td align="right">869,914 ns</td><td align="right">875,471 ns</td><td align="right">870,825 ns</td><td align="right">596,309 ns</td><td align="right">877,655 ns</td></tr>
<tr>
<td align="right">0,917 μs</td><td align="right">0,870 μs</td><td align="right">0,875 μs</td><td align="right">0,871 μs</td><td align="right">0,596 μs</td><td align="right">0,878 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.5.4**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">808,021 ns</td><td align="right">782,398 ns</td><td align="right">767,694 ns</td><td align="right">818,503 ns</td><td align="right">508,956 ns</td><td align="right">809,006 ns</td></tr>
<tr>
<td align="right">0,808 μs</td><td align="right">0,782 μs</td><td align="right">0,768 μs</td><td align="right">0,819 μs</td><td align="right">0,509 μs</td><td align="right">0,809 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">135,687 ns</td><td align="right">151,794 ns</td><td align="right">179,001 ns</td><td align="right">153,692 ns</td><td align="right">155,444 ns</td><td align="right">155,029 ns</td></tr>
<tr>
<td align="right">0,136 μs</td><td align="right">0,152 μs</td><td align="right">0,179 μs</td><td align="right">0,154 μs</td><td align="right">0,155 μs</td><td align="right">0,155 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">132,961 ns</td><td align="right">154,969 ns</td><td align="right">178,301 ns</td><td align="right">156,909 ns</td><td align="right">155,801 ns</td><td align="right">157,196 ns</td></tr>
<tr>
<td align="right">0,133 μs</td><td align="right">0,155 μs</td><td align="right">0,178 μs</td><td align="right">0,157 μs</td><td align="right">0,156 μs</td><td align="right">0,157 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

Fastest: **4.2.0**

Slowest: 4.4.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">126,153 ns</td><td align="right">148,975 ns</td><td align="right">177,429 ns</td><td align="right">146,826 ns</td><td align="right">147,736 ns</td><td align="right">146,597 ns</td></tr>
<tr>
<td align="right">0,126 μs</td><td align="right">0,149 μs</td><td align="right">0,177 μs</td><td align="right">0,147 μs</td><td align="right">0,148 μs</td><td align="right">0,147 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1397,598 ns</td><td align="right">1596,629 ns</td><td align="right">1859,458 ns</td><td align="right">1961,137 ns</td><td align="right">1971,750 ns</td><td align="right">1385,831 ns</td></tr>
<tr>
<td align="right">1,398 μs</td><td align="right">1,597 μs</td><td align="right">1,859 μs</td><td align="right">1,961 μs</td><td align="right">1,972 μs</td><td align="right">1,386 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1689,441 ns</td><td align="right">1663,498 ns</td><td align="right">1951,679 ns</td><td align="right">2100,920 ns</td><td align="right">1806,640 ns</td><td align="right">1441,591 ns</td></tr>
<tr>
<td align="right">1,689 μs</td><td align="right">1,663 μs</td><td align="right">1,952 μs</td><td align="right">2,101 μs</td><td align="right">1,807 μs</td><td align="right">1,442 μs</td></tr>
<tr>
<td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1283,326 ns</td><td align="right">1513,233 ns</td><td align="right">1391,863 ns</td><td align="right">1824,723 ns</td><td align="right">1833,737 ns</td><td align="right">1262,545 ns</td></tr>
<tr>
<td align="right">1,283 μs</td><td align="right">1,513 μs</td><td align="right">1,392 μs</td><td align="right">1,825 μs</td><td align="right">1,834 μs</td><td align="right">1,263 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">254184,980 ns</td><td align="right">254848,758 ns</td><td align="right">260530,598 ns</td><td align="right">270809,115 ns</td><td align="right">623594,891 ns</td><td align="right">614022,247 ns</td></tr>
<tr>
<td align="right">254,185 μs</td><td align="right">254,849 μs</td><td align="right">260,531 μs</td><td align="right">270,809 μs</td><td align="right">623,595 μs</td><td align="right">614,022 μs</td></tr>
<tr>
<td align="right">0,254 ms</td><td align="right">0,255 ms</td><td align="right">0,261 ms</td><td align="right">0,271 ms</td><td align="right">0,624 ms</td><td align="right">0,614 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">51167,078 ns</td><td align="right">51250,172 ns</td><td align="right">53828,388 ns</td><td align="right">58043,227 ns</td><td align="right">386135,670 ns</td><td align="right">383496,581 ns</td></tr>
<tr>
<td align="right">51,167 μs</td><td align="right">51,250 μs</td><td align="right">53,828 μs</td><td align="right">58,043 μs</td><td align="right">386,136 μs</td><td align="right">383,497 μs</td></tr>
<tr>
<td align="right">0,051 ms</td><td align="right">0,051 ms</td><td align="right">0,054 ms</td><td align="right">0,058 ms</td><td align="right">0,386 ms</td><td align="right">0,383 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">166905,190 ns</td><td align="right">170388,069 ns</td><td align="right">175376,488 ns</td><td align="right">187507,823 ns</td><td align="right">525767,910 ns</td><td align="right">531794,641 ns</td></tr>
<tr>
<td align="right">166,905 μs</td><td align="right">170,388 μs</td><td align="right">175,376 μs</td><td align="right">187,508 μs</td><td align="right">525,768 μs</td><td align="right">531,795 μs</td></tr>
<tr>
<td align="right">0,167 ms</td><td align="right">0,170 ms</td><td align="right">0,175 ms</td><td align="right">0,188 ms</td><td align="right">0,526 ms</td><td align="right">0,532 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">853272,663 ns</td><td align="right">855222,522 ns</td><td align="right">882522,493 ns</td><td align="right">928206,451 ns</td><td align="right">1324036,610 ns</td><td align="right">1287921,349 ns</td></tr>
<tr>
<td align="right">853,273 μs</td><td align="right">855,223 μs</td><td align="right">882,522 μs</td><td align="right">928,206 μs</td><td align="right">1324,037 μs</td><td align="right">1287,921 μs</td></tr>
<tr>
<td align="right">0,853 ms</td><td align="right">0,855 ms</td><td align="right">0,883 ms</td><td align="right">0,928 ms</td><td align="right">1,324 ms</td><td align="right">1,288 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">16774596,617 ns</td><td align="right">16708039,831 ns</td><td align="right">16740861,113 ns</td><td align="right">16854411,451 ns</td><td align="right">17443298,077 ns</td></tr>
<tr>
<td align="right">16774,597 μs</td><td align="right">16708,040 μs</td><td align="right">16740,861 μs</td><td align="right">16854,411 μs</td><td align="right">17443,298 μs</td></tr>
<tr>
<td align="right">16,775 ms</td><td align="right">16,708 ms</td><td align="right">16,741 ms</td><td align="right">16,854 ms</td><td align="right">17,443 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">736652,788 ns</td><td align="right">706163,823 ns</td><td align="right">702692,115 ns</td><td align="right">710580,525 ns</td><td align="right">1052795,215 ns</td></tr>
<tr>
<td align="right">736,653 μs</td><td align="right">706,164 μs</td><td align="right">702,692 μs</td><td align="right">710,581 μs</td><td align="right">1052,795 μs</td></tr>
<tr>
<td align="right">0,737 ms</td><td align="right">0,706 ms</td><td align="right">0,703 ms</td><td align="right">0,711 ms</td><td align="right">1,053 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">2800933,939 ns</td><td align="right">2792276,193 ns</td><td align="right">2765292,760 ns</td><td align="right">2811866,882 ns</td><td align="right">3187670,113 ns</td></tr>
<tr>
<td align="right">2800,934 μs</td><td align="right">2792,276 μs</td><td align="right">2765,293 μs</td><td align="right">2811,867 μs</td><td align="right">3187,670 μs</td></tr>
<tr>
<td align="right">2,801 ms</td><td align="right">2,792 ms</td><td align="right">2,765 ms</td><td align="right">2,812 ms</td><td align="right">3,188 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">13796917,841 ns</td><td align="right">13139135,043 ns</td><td align="right">13259077,811 ns</td><td align="right">13621336,283 ns</td><td align="right">13833473,957 ns</td></tr>
<tr>
<td align="right">13796,918 μs</td><td align="right">13139,135 μs</td><td align="right">13259,078 μs</td><td align="right">13621,336 μs</td><td align="right">13833,474 μs</td></tr>
<tr>
<td align="right">13,797 ms</td><td align="right">13,139 ms</td><td align="right">13,259 ms</td><td align="right">13,621 ms</td><td align="right">13,833 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">717334,745 ns</td><td align="right">743528,616 ns</td><td align="right">877312,049 ns</td><td align="right">910680,976 ns</td><td align="right">1381754,474 ns</td><td align="right">1305256,764 ns</td></tr>
<tr>
<td align="right">717,335 μs</td><td align="right">743,529 μs</td><td align="right">877,312 μs</td><td align="right">910,681 μs</td><td align="right">1381,754 μs</td><td align="right">1305,257 μs</td></tr>
<tr>
<td align="right">0,717 ms</td><td align="right">0,744 ms</td><td align="right">0,877 ms</td><td align="right">0,911 ms</td><td align="right">1,382 ms</td><td align="right">1,305 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">87442,592 ns</td><td align="right">89024,377 ns</td><td align="right">131392,165 ns</td><td align="right">144502,221 ns</td><td align="right">484620,766 ns</td><td align="right">472167,915 ns</td></tr>
<tr>
<td align="right">87,443 μs</td><td align="right">89,024 μs</td><td align="right">131,392 μs</td><td align="right">144,502 μs</td><td align="right">484,621 μs</td><td align="right">472,168 μs</td></tr>
<tr>
<td align="right">0,087 ms</td><td align="right">0,089 ms</td><td align="right">0,131 ms</td><td align="right">0,145 ms</td><td align="right">0,485 ms</td><td align="right">0,472 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">313666,044 ns</td><td align="right">322600,158 ns</td><td align="right">460197,656 ns</td><td align="right">497599,042 ns</td><td align="right">886468,109 ns</td><td align="right">857632,393 ns</td></tr>
<tr>
<td align="right">313,666 μs</td><td align="right">322,600 μs</td><td align="right">460,198 μs</td><td align="right">497,599 μs</td><td align="right">886,468 μs</td><td align="right">857,632 μs</td></tr>
<tr>
<td align="right">0,314 ms</td><td align="right">0,323 ms</td><td align="right">0,460 ms</td><td align="right">0,498 ms</td><td align="right">0,886 ms</td><td align="right">0,858 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1535926,916 ns</td><td align="right">1547344,550 ns</td><td align="right">2144261,283 ns</td><td align="right">2358654,762 ns</td><td align="right">2911548,416 ns</td><td align="right">2772257,202 ns</td></tr>
<tr>
<td align="right">1535,927 μs</td><td align="right">1547,345 μs</td><td align="right">2144,261 μs</td><td align="right">2358,655 μs</td><td align="right">2911,548 μs</td><td align="right">2772,257 μs</td></tr>
<tr>
<td align="right">1,536 ms</td><td align="right">1,547 ms</td><td align="right">2,144 ms</td><td align="right">2,359 ms</td><td align="right">2,912 ms</td><td align="right">2,772 ms</td></tr>
</table>

