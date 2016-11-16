# Benchmarks

Benchmark report generated on 16-nov-2016 11:37

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

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">302,011 ns</td><td align="right">302,533 ns</td></tr>
<tr>
<td align="right">0,302 μs</td><td align="right">0,303 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">35,805 ns</td><td align="right">35,882 ns</td></tr>
<tr>
<td align="right">0,036 μs</td><td align="right">0,036 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">5,337 ns</td><td align="right">5,398 ns</td></tr>
<tr>
<td align="right">0,005 μs</td><td align="right">0,005 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">5,950 ns</td><td align="right">6,001 ns</td></tr>
<tr>
<td align="right">0,006 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">9,572 ns</td><td align="right">9,580 ns</td><td align="right">9,568 ns</td><td align="right">9,935 ns</td><td align="right">9,862 ns</td><td align="right">9,867 ns</td></tr>
<tr>
<td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">18,297 ns</td><td align="right">18,088 ns</td><td align="right">18,227 ns</td><td align="right">18,135 ns</td><td align="right">18,333 ns</td><td align="right">18,708 ns</td></tr>
<tr>
<td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">14,061 ns</td><td align="right">14,631 ns</td><td align="right">14,828 ns</td><td align="right">14,869 ns</td><td align="right">14,869 ns</td><td align="right">15,171 ns</td></tr>
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
<td align="right">603,867 ns</td><td align="right">544,993 ns</td><td align="right">558,117 ns</td><td align="right">561,780 ns</td><td align="right">289,790 ns</td><td align="right">290,261 ns</td></tr>
<tr>
<td align="right">0,604 μs</td><td align="right">0,545 μs</td><td align="right">0,558 μs</td><td align="right">0,562 μs</td><td align="right">0,290 μs</td><td align="right">0,290 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.5.4**

Slowest: 4.3.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">867,694 ns</td><td align="right">884,344 ns</td><td align="right">868,725 ns</td><td align="right">873,329 ns</td><td align="right">598,202 ns</td><td align="right">609,815 ns</td></tr>
<tr>
<td align="right">0,868 μs</td><td align="right">0,884 μs</td><td align="right">0,869 μs</td><td align="right">0,873 μs</td><td align="right">0,598 μs</td><td align="right">0,610 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.5.4**

Slowest: 4.2.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">825,094 ns</td><td align="right">782,668 ns</td><td align="right">786,057 ns</td><td align="right">794,270 ns</td><td align="right">508,813 ns</td><td align="right">513,166 ns</td></tr>
<tr>
<td align="right">0,825 μs</td><td align="right">0,783 μs</td><td align="right">0,786 μs</td><td align="right">0,794 μs</td><td align="right">0,509 μs</td><td align="right">0,513 μs</td></tr>
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
<td align="right">133,158 ns</td><td align="right">152,002 ns</td><td align="right">177,175 ns</td><td align="right">154,444 ns</td><td align="right">155,509 ns</td><td align="right">155,637 ns</td></tr>
<tr>
<td align="right">0,133 μs</td><td align="right">0,152 μs</td><td align="right">0,177 μs</td><td align="right">0,154 μs</td><td align="right">0,156 μs</td><td align="right">0,156 μs</td></tr>
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
<td align="right">133,484 ns</td><td align="right">158,727 ns</td><td align="right">177,285 ns</td><td align="right">156,779 ns</td><td align="right">156,122 ns</td><td align="right">158,480 ns</td></tr>
<tr>
<td align="right">0,133 μs</td><td align="right">0,159 μs</td><td align="right">0,177 μs</td><td align="right">0,157 μs</td><td align="right">0,156 μs</td><td align="right">0,158 μs</td></tr>
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
<td align="right">126,243 ns</td><td align="right">159,772 ns</td><td align="right">175,291 ns</td><td align="right">151,667 ns</td><td align="right">147,391 ns</td><td align="right">147,594 ns</td></tr>
<tr>
<td align="right">0,126 μs</td><td align="right">0,160 μs</td><td align="right">0,175 μs</td><td align="right">0,152 μs</td><td align="right">0,147 μs</td><td align="right">0,148 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

Fastest: **4.2.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1417,535 ns</td><td align="right">1635,884 ns</td><td align="right">1899,685 ns</td><td align="right">2026,131 ns</td><td align="right">1713,206 ns</td><td align="right">1950,466 ns</td></tr>
<tr>
<td align="right">1,418 μs</td><td align="right">1,636 μs</td><td align="right">1,900 μs</td><td align="right">2,026 μs</td><td align="right">1,713 μs</td><td align="right">1,950 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1499,689 ns</td><td align="right">1669,865 ns</td><td align="right">1976,930 ns</td><td align="right">1845,921 ns</td><td align="right">1791,833 ns</td><td align="right">2022,593 ns</td></tr>
<tr>
<td align="right">1,500 μs</td><td align="right">1,670 μs</td><td align="right">1,977 μs</td><td align="right">1,846 μs</td><td align="right">1,792 μs</td><td align="right">2,023 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1289,465 ns</td><td align="right">1458,946 ns</td><td align="right">1684,632 ns</td><td align="right">1556,767 ns</td><td align="right">1556,916 ns</td><td align="right">1767,838 ns</td></tr>
<tr>
<td align="right">1,289 μs</td><td align="right">1,459 μs</td><td align="right">1,685 μs</td><td align="right">1,557 μs</td><td align="right">1,557 μs</td><td align="right">1,768 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">250459,413 ns</td><td align="right">256067,768 ns</td><td align="right">258179,706 ns</td><td align="right">269441,834 ns</td><td align="right">628944,977 ns</td><td align="right">624435,485 ns</td></tr>
<tr>
<td align="right">250,459 μs</td><td align="right">256,068 μs</td><td align="right">258,180 μs</td><td align="right">269,442 μs</td><td align="right">628,945 μs</td><td align="right">624,435 μs</td></tr>
<tr>
<td align="right">0,250 ms</td><td align="right">0,256 ms</td><td align="right">0,258 ms</td><td align="right">0,269 ms</td><td align="right">0,629 ms</td><td align="right">0,624 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">51086,306 ns</td><td align="right">51580,134 ns</td><td align="right">55087,257 ns</td><td align="right">58370,219 ns</td><td align="right">383881,039 ns</td><td align="right">384785,491 ns</td></tr>
<tr>
<td align="right">51,086 μs</td><td align="right">51,580 μs</td><td align="right">55,087 μs</td><td align="right">58,370 μs</td><td align="right">383,881 μs</td><td align="right">384,785 μs</td></tr>
<tr>
<td align="right">0,051 ms</td><td align="right">0,052 ms</td><td align="right">0,055 ms</td><td align="right">0,058 ms</td><td align="right">0,384 ms</td><td align="right">0,385 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">168335,770 ns</td><td align="right">170004,923 ns</td><td align="right">176033,835 ns</td><td align="right">186047,289 ns</td><td align="right">539235,386 ns</td><td align="right">541347,783 ns</td></tr>
<tr>
<td align="right">168,336 μs</td><td align="right">170,005 μs</td><td align="right">176,034 μs</td><td align="right">186,047 μs</td><td align="right">539,235 μs</td><td align="right">541,348 μs</td></tr>
<tr>
<td align="right">0,168 ms</td><td align="right">0,170 ms</td><td align="right">0,176 ms</td><td align="right">0,186 ms</td><td align="right">0,539 ms</td><td align="right">0,541 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">838883,290 ns</td><td align="right">856607,250 ns</td><td align="right">853563,465 ns</td><td align="right">924672,680 ns</td><td align="right">1335741,224 ns</td><td align="right">1332288,558 ns</td></tr>
<tr>
<td align="right">838,883 μs</td><td align="right">856,607 μs</td><td align="right">853,563 μs</td><td align="right">924,673 μs</td><td align="right">1335,741 μs</td><td align="right">1332,289 μs</td></tr>
<tr>
<td align="right">0,839 ms</td><td align="right">0,857 ms</td><td align="right">0,854 ms</td><td align="right">0,925 ms</td><td align="right">1,336 ms</td><td align="right">1,332 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.2.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td align="right">17411400,160 ns</td><td align="right">16855267,521 ns</td><td align="right">16910016,185 ns</td><td align="right">16923995,303 ns</td></tr>
<tr>
<td align="right">17411,400 μs</td><td align="right">16855,268 μs</td><td align="right">16910,016 μs</td><td align="right">16923,995 μs</td></tr>
<tr>
<td align="right">17,411 ms</td><td align="right">16,855 ms</td><td align="right">16,910 ms</td><td align="right">16,924 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td align="right">693422,470 ns</td><td align="right">699596,112 ns</td><td align="right">704799,149 ns</td><td align="right">713569,360 ns</td></tr>
<tr>
<td align="right">693,422 μs</td><td align="right">699,596 μs</td><td align="right">704,799 μs</td><td align="right">713,569 μs</td></tr>
<tr>
<td align="right">0,693 ms</td><td align="right">0,700 ms</td><td align="right">0,705 ms</td><td align="right">0,714 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td align="right">2882433,698 ns</td><td align="right">2884318,971 ns</td><td align="right">2798000,030 ns</td><td align="right">2889942,094 ns</td></tr>
<tr>
<td align="right">2882,434 μs</td><td align="right">2884,319 μs</td><td align="right">2798,000 μs</td><td align="right">2889,942 μs</td></tr>
<tr>
<td align="right">2,882 ms</td><td align="right">2,884 ms</td><td align="right">2,798 ms</td><td align="right">2,890 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th></tr>
<tr>
<td align="right">13347782,175 ns</td><td align="right">13377316,231 ns</td><td align="right">13269351,209 ns</td><td align="right">13484734,882 ns</td></tr>
<tr>
<td align="right">13347,782 μs</td><td align="right">13377,316 μs</td><td align="right">13269,351 μs</td><td align="right">13484,735 μs</td></tr>
<tr>
<td align="right">13,348 ms</td><td align="right">13,377 ms</td><td align="right">13,269 ms</td><td align="right">13,485 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">726296,735 ns</td><td align="right">715962,212 ns</td><td align="right">878217,040 ns</td><td align="right">895211,508 ns</td><td align="right">1344749,781 ns</td><td align="right">1319854,709 ns</td></tr>
<tr>
<td align="right">726,297 μs</td><td align="right">715,962 μs</td><td align="right">878,217 μs</td><td align="right">895,212 μs</td><td align="right">1344,750 μs</td><td align="right">1319,855 μs</td></tr>
<tr>
<td align="right">0,726 ms</td><td align="right">0,716 ms</td><td align="right">0,878 ms</td><td align="right">0,895 ms</td><td align="right">1,345 ms</td><td align="right">1,320 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">88550,151 ns</td><td align="right">90105,716 ns</td><td align="right">130372,025 ns</td><td align="right">139444,458 ns</td><td align="right">483900,852 ns</td><td align="right">476345,014 ns</td></tr>
<tr>
<td align="right">88,550 μs</td><td align="right">90,106 μs</td><td align="right">130,372 μs</td><td align="right">139,444 μs</td><td align="right">483,901 μs</td><td align="right">476,345 μs</td></tr>
<tr>
<td align="right">0,089 ms</td><td align="right">0,090 ms</td><td align="right">0,130 ms</td><td align="right">0,139 ms</td><td align="right">0,484 ms</td><td align="right">0,476 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">312891,039 ns</td><td align="right">327805,692 ns</td><td align="right">454729,399 ns</td><td align="right">493422,847 ns</td><td align="right">885392,520 ns</td><td align="right">872664,377 ns</td></tr>
<tr>
<td align="right">312,891 μs</td><td align="right">327,806 μs</td><td align="right">454,729 μs</td><td align="right">493,423 μs</td><td align="right">885,393 μs</td><td align="right">872,664 μs</td></tr>
<tr>
<td align="right">0,313 ms</td><td align="right">0,328 ms</td><td align="right">0,455 ms</td><td align="right">0,493 ms</td><td align="right">0,885 ms</td><td align="right">0,873 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1546151,722 ns</td><td align="right">1612522,702 ns</td><td align="right">2176901,244 ns</td><td align="right">2350182,370 ns</td><td align="right">2831898,771 ns</td><td align="right">2890305,035 ns</td></tr>
<tr>
<td align="right">1546,152 μs</td><td align="right">1612,523 μs</td><td align="right">2176,901 μs</td><td align="right">2350,182 μs</td><td align="right">2831,899 μs</td><td align="right">2890,305 μs</td></tr>
<tr>
<td align="right">1,546 ms</td><td align="right">1,613 ms</td><td align="right">2,177 ms</td><td align="right">2,350 ms</td><td align="right">2,832 ms</td><td align="right">2,890 ms</td></tr>
</table>

