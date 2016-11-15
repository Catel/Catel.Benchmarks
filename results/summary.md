# Benchmarks

Benchmark report generated on 15-nov-2016 16:54

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

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">304,690 ns</td></tr>
<tr>
<td align="right">0,305 μs</td></tr>
<tr>
<td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">35,428 ns</td></tr>
<tr>
<td align="right">0,035 μs</td></tr>
<tr>
<td align="right">0,000 ms</td></tr>
</table>

## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">5,509 ns</td></tr>
<tr>
<td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">6,066 ns</td></tr>
<tr>
<td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">9,461 ns</td><td align="right">9,751 ns</td><td align="right">9,658 ns</td><td align="right">10,058 ns</td><td align="right">10,316 ns</td></tr>
<tr>
<td align="right">0,009 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">18,451 ns</td><td align="right">18,282 ns</td><td align="right">18,150 ns</td><td align="right">18,152 ns</td><td align="right">18,801 ns</td></tr>
<tr>
<td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">14,205 ns</td><td align="right">14,533 ns</td><td align="right">14,912 ns</td><td align="right">14,730 ns</td><td align="right">15,084 ns</td></tr>
<tr>
<td align="right">0,014 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">545,322 ns</td><td align="right">550,151 ns</td><td align="right">548,530 ns</td><td align="right">578,390 ns</td><td align="right">286,530 ns</td></tr>
<tr>
<td align="right">0,545 μs</td><td align="right">0,550 μs</td><td align="right">0,549 μs</td><td align="right">0,578 μs</td><td align="right">0,287 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">915,028 ns</td><td align="right">882,808 ns</td><td align="right">900,852 ns</td><td align="right">885,793 ns</td><td align="right">605,688 ns</td></tr>
<tr>
<td align="right">0,915 μs</td><td align="right">0,883 μs</td><td align="right">0,901 μs</td><td align="right">0,886 μs</td><td align="right">0,606 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">836,376 ns</td><td align="right">791,739 ns</td><td align="right">789,057 ns</td><td align="right">814,603 ns</td><td align="right">511,683 ns</td></tr>
<tr>
<td align="right">0,836 μs</td><td align="right">0,792 μs</td><td align="right">0,789 μs</td><td align="right">0,815 μs</td><td align="right">0,512 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.4.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">133,538 ns</td><td align="right">155,612 ns</td><td align="right">177,519 ns</td><td align="right">156,323 ns</td><td align="right">156,019 ns</td></tr>
<tr>
<td align="right">0,134 μs</td><td align="right">0,156 μs</td><td align="right">0,178 μs</td><td align="right">0,156 μs</td><td align="right">0,156 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.4.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">135,871 ns</td><td align="right">156,328 ns</td><td align="right">179,705 ns</td><td align="right">155,666 ns</td><td align="right">155,927 ns</td></tr>
<tr>
<td align="right">0,136 μs</td><td align="right">0,156 μs</td><td align="right">0,180 μs</td><td align="right">0,156 μs</td><td align="right">0,156 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.4.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">127,119 ns</td><td align="right">151,464 ns</td><td align="right">177,427 ns</td><td align="right">147,549 ns</td><td align="right">148,843 ns</td></tr>
<tr>
<td align="right">0,127 μs</td><td align="right">0,151 μs</td><td align="right">0,177 μs</td><td align="right">0,148 μs</td><td align="right">0,149 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1426,248 ns</td><td align="right">1617,916 ns</td><td align="right">1627,121 ns</td><td align="right">1659,318 ns</td><td align="right">1702,884 ns</td></tr>
<tr>
<td align="right">1,426 μs</td><td align="right">1,618 μs</td><td align="right">1,627 μs</td><td align="right">1,659 μs</td><td align="right">1,703 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1505,444 ns</td><td align="right">1668,260 ns</td><td align="right">1915,065 ns</td><td align="right">2027,898 ns</td><td align="right">2023,592 ns</td></tr>
<tr>
<td align="right">1,505 μs</td><td align="right">1,668 μs</td><td align="right">1,915 μs</td><td align="right">2,028 μs</td><td align="right">2,024 μs</td></tr>
<tr>
<td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1421,578 ns</td><td align="right">1411,737 ns</td><td align="right">1559,650 ns</td><td align="right">1510,417 ns</td><td align="right">1770,518 ns</td></tr>
<tr>
<td align="right">1,422 μs</td><td align="right">1,412 μs</td><td align="right">1,560 μs</td><td align="right">1,510 μs</td><td align="right">1,771 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">249748,159 ns</td><td align="right">255573,416 ns</td><td align="right">262350,924 ns</td><td align="right">273197,080 ns</td><td align="right">625765,145 ns</td></tr>
<tr>
<td align="right">249,748 μs</td><td align="right">255,573 μs</td><td align="right">262,351 μs</td><td align="right">273,197 μs</td><td align="right">625,765 μs</td></tr>
<tr>
<td align="right">0,250 ms</td><td align="right">0,256 ms</td><td align="right">0,262 ms</td><td align="right">0,273 ms</td><td align="right">0,626 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">52646,859 ns</td><td align="right">51917,008 ns</td><td align="right">53701,540 ns</td><td align="right">58025,758 ns</td><td align="right">385594,363 ns</td></tr>
<tr>
<td align="right">52,647 μs</td><td align="right">51,917 μs</td><td align="right">53,702 μs</td><td align="right">58,026 μs</td><td align="right">385,594 μs</td></tr>
<tr>
<td align="right">0,053 ms</td><td align="right">0,052 ms</td><td align="right">0,054 ms</td><td align="right">0,058 ms</td><td align="right">0,386 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">168013,648 ns</td><td align="right">171684,734 ns</td><td align="right">175901,426 ns</td><td align="right">188717,054 ns</td><td align="right">533982,494 ns</td></tr>
<tr>
<td align="right">168,014 μs</td><td align="right">171,685 μs</td><td align="right">175,901 μs</td><td align="right">188,717 μs</td><td align="right">533,982 μs</td></tr>
<tr>
<td align="right">0,168 ms</td><td align="right">0,172 ms</td><td align="right">0,176 ms</td><td align="right">0,189 ms</td><td align="right">0,534 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">844312,693 ns</td><td align="right">875771,631 ns</td><td align="right">886991,710 ns</td><td align="right">924632,009 ns</td><td align="right">1349369,961 ns</td></tr>
<tr>
<td align="right">844,313 μs</td><td align="right">875,772 μs</td><td align="right">886,992 μs</td><td align="right">924,632 μs</td><td align="right">1349,370 μs</td></tr>
<tr>
<td align="right">0,844 ms</td><td align="right">0,876 ms</td><td align="right">0,887 ms</td><td align="right">0,925 ms</td><td align="right">1,349 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">17363926,120 ns</td><td align="right">16941573,881 ns</td><td align="right">16787271,593 ns</td><td align="right">16968018,978 ns</td></tr>
<tr>
<td align="right">17363,926 μs</td><td align="right">16941,574 μs</td><td align="right">16787,272 μs</td><td align="right">16968,019 μs</td></tr>
<tr>
<td align="right">17,364 ms</td><td align="right">16,942 ms</td><td align="right">16,787 ms</td><td align="right">16,968 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">696814,078 ns</td><td align="right">711330,129 ns</td><td align="right">699867,167 ns</td><td align="right">713804,373 ns</td></tr>
<tr>
<td align="right">696,814 μs</td><td align="right">711,330 μs</td><td align="right">699,867 μs</td><td align="right">713,804 μs</td></tr>
<tr>
<td align="right">0,697 ms</td><td align="right">0,711 ms</td><td align="right">0,700 ms</td><td align="right">0,714 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">2800784,166 ns</td><td align="right">2785613,113 ns</td><td align="right">2773756,312 ns</td><td align="right">2813559,724 ns</td></tr>
<tr>
<td align="right">2800,784 μs</td><td align="right">2785,613 μs</td><td align="right">2773,756 μs</td><td align="right">2813,560 μs</td></tr>
<tr>
<td align="right">2,801 ms</td><td align="right">2,786 ms</td><td align="right">2,774 ms</td><td align="right">2,814 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">13666484,028 ns</td><td align="right">13409344,531 ns</td><td align="right">13200582,981 ns</td><td align="right">13345493,098 ns</td></tr>
<tr>
<td align="right">13666,484 μs</td><td align="right">13409,345 μs</td><td align="right">13200,583 μs</td><td align="right">13345,493 μs</td></tr>
<tr>
<td align="right">13,666 ms</td><td align="right">13,409 ms</td><td align="right">13,201 ms</td><td align="right">13,345 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">712591,663 ns</td><td align="right">724758,280 ns</td><td align="right">893178,157 ns</td><td align="right">901623,243 ns</td><td align="right">1306763,991 ns</td></tr>
<tr>
<td align="right">712,592 μs</td><td align="right">724,758 μs</td><td align="right">893,178 μs</td><td align="right">901,623 μs</td><td align="right">1306,764 μs</td></tr>
<tr>
<td align="right">0,713 ms</td><td align="right">0,725 ms</td><td align="right">0,893 ms</td><td align="right">0,902 ms</td><td align="right">1,307 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">87393,127 ns</td><td align="right">90321,317 ns</td><td align="right">135441,262 ns</td><td align="right">141624,592 ns</td><td align="right">478803,594 ns</td></tr>
<tr>
<td align="right">87,393 μs</td><td align="right">90,321 μs</td><td align="right">135,441 μs</td><td align="right">141,625 μs</td><td align="right">478,804 μs</td></tr>
<tr>
<td align="right">0,087 ms</td><td align="right">0,090 ms</td><td align="right">0,135 ms</td><td align="right">0,142 ms</td><td align="right">0,479 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">315460,775 ns</td><td align="right">316055,278 ns</td><td align="right">468307,869 ns</td><td align="right">499777,533 ns</td><td align="right">874039,343 ns</td></tr>
<tr>
<td align="right">315,461 μs</td><td align="right">316,055 μs</td><td align="right">468,308 μs</td><td align="right">499,778 μs</td><td align="right">874,039 μs</td></tr>
<tr>
<td align="right">0,315 ms</td><td align="right">0,316 ms</td><td align="right">0,468 ms</td><td align="right">0,500 ms</td><td align="right">0,874 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1556761,486 ns</td><td align="right">1569709,919 ns</td><td align="right">2224730,011 ns</td><td align="right">2330369,992 ns</td><td align="right">2857331,090 ns</td></tr>
<tr>
<td align="right">1556,761 μs</td><td align="right">1569,710 μs</td><td align="right">2224,730 μs</td><td align="right">2330,370 μs</td><td align="right">2857,331 μs</td></tr>
<tr>
<td align="right">1,557 ms</td><td align="right">1,570 ms</td><td align="right">2,225 ms</td><td align="right">2,330 ms</td><td align="right">2,857 ms</td></tr>
</table>

