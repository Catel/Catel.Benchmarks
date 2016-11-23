# Benchmarks

Benchmark report generated on 23-nov-2016 23:08

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
* [ViewModelBase_Benchmark](#ViewModelBase_Benchmark)
  * [Construction](#ViewModelBase_Benchmark_Construction)

## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">305,225 ns</td><td align="right">302,533 ns</td></tr>
<tr>
<td align="right">0,305 μs</td><td align="right">0,303 μs</td></tr>
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
<td align="right">37,507 ns</td><td align="right">35,882 ns</td></tr>
<tr>
<td align="right">0,038 μs</td><td align="right">0,036 μs</td></tr>
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
<td align="right">5,494 ns</td><td align="right">5,398 ns</td></tr>
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
<td align="right">6,035 ns</td><td align="right">6,001 ns</td></tr>
<tr>
<td align="right">0,006 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">9,396 ns</td><td align="right">9,603 ns</td><td align="right">9,658 ns</td><td align="right">10,263 ns</td><td align="right">9,905 ns</td><td align="right">5,511 ns</td></tr>
<tr>
<td align="right">0,009 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,006 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.5.4**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">18,195 ns</td><td align="right">18,275 ns</td><td align="right">18,324 ns</td><td align="right">18,647 ns</td><td align="right">18,160 ns</td><td align="right">18,386 ns</td></tr>
<tr>
<td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.2.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">13,978 ns</td><td align="right">14,876 ns</td><td align="right">14,559 ns</td><td align="right">15,337 ns</td><td align="right">15,105 ns</td><td align="right">15,044 ns</td></tr>
<tr>
<td align="right">0,014 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">552,392 ns</td><td align="right">543,244 ns</td><td align="right">571,849 ns</td><td align="right">615,365 ns</td><td align="right">310,560 ns</td><td align="right">282,360 ns</td></tr>
<tr>
<td align="right">0,552 μs</td><td align="right">0,543 μs</td><td align="right">0,572 μs</td><td align="right">0,615 μs</td><td align="right">0,311 μs</td><td align="right">0,282 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **5.0.0**

Slowest: 4.4.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">837,259 ns</td><td align="right">864,796 ns</td><td align="right">867,287 ns</td><td align="right">849,704 ns</td><td align="right">599,774 ns</td><td align="right">585,402 ns</td></tr>
<tr>
<td align="right">0,837 μs</td><td align="right">0,865 μs</td><td align="right">0,867 μs</td><td align="right">0,850 μs</td><td align="right">0,600 μs</td><td align="right">0,585 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">770,808 ns</td><td align="right">768,706 ns</td><td align="right">768,409 ns</td><td align="right">777,968 ns</td><td align="right">562,349 ns</td><td align="right">510,701 ns</td></tr>
<tr>
<td align="right">0,771 μs</td><td align="right">0,769 μs</td><td align="right">0,768 μs</td><td align="right">0,778 μs</td><td align="right">0,562 μs</td><td align="right">0,511 μs</td></tr>
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
<td align="right">133,617 ns</td><td align="right">154,333 ns</td><td align="right">176,464 ns</td><td align="right">158,714 ns</td><td align="right">154,366 ns</td><td align="right">155,717 ns</td></tr>
<tr>
<td align="right">0,134 μs</td><td align="right">0,154 μs</td><td align="right">0,176 μs</td><td align="right">0,159 μs</td><td align="right">0,154 μs</td><td align="right">0,156 μs</td></tr>
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
<td align="right">136,130 ns</td><td align="right">156,614 ns</td><td align="right">177,626 ns</td><td align="right">156,998 ns</td><td align="right">157,609 ns</td><td align="right">157,023 ns</td></tr>
<tr>
<td align="right">0,136 μs</td><td align="right">0,157 μs</td><td align="right">0,178 μs</td><td align="right">0,157 μs</td><td align="right">0,158 μs</td><td align="right">0,157 μs</td></tr>
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
<td align="right">126,880 ns</td><td align="right">149,179 ns</td><td align="right">173,269 ns</td><td align="right">149,309 ns</td><td align="right">147,645 ns</td><td align="right">153,090 ns</td></tr>
<tr>
<td align="right">0,127 μs</td><td align="right">0,149 μs</td><td align="right">0,173 μs</td><td align="right">0,149 μs</td><td align="right">0,148 μs</td><td align="right">0,153 μs</td></tr>
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
<td align="right">1601,803 ns</td><td align="right">1660,327 ns</td><td align="right">1520,620 ns</td><td align="right">1820,596 ns</td><td align="right">1892,032 ns</td><td align="right">1399,320 ns</td></tr>
<tr>
<td align="right">1,602 μs</td><td align="right">1,660 μs</td><td align="right">1,521 μs</td><td align="right">1,821 μs</td><td align="right">1,892 μs</td><td align="right">1,399 μs</td></tr>
<tr>
<td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1506,226 ns</td><td align="right">1625,895 ns</td><td align="right">1617,764 ns</td><td align="right">1926,060 ns</td><td align="right">1684,920 ns</td><td align="right">1396,248 ns</td></tr>
<tr>
<td align="right">1,506 μs</td><td align="right">1,626 μs</td><td align="right">1,618 μs</td><td align="right">1,926 μs</td><td align="right">1,685 μs</td><td align="right">1,396 μs</td></tr>
<tr>
<td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1478,548 ns</td><td align="right">1375,609 ns</td><td align="right">1408,330 ns</td><td align="right">1519,240 ns</td><td align="right">1512,504 ns</td><td align="right">1213,078 ns</td></tr>
<tr>
<td align="right">1,479 μs</td><td align="right">1,376 μs</td><td align="right">1,408 μs</td><td align="right">1,519 μs</td><td align="right">1,513 μs</td><td align="right">1,213 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">254053,686 ns</td><td align="right">254070,953 ns</td><td align="right">262815,165 ns</td><td align="right">273101,409 ns</td><td align="right">684228,547 ns</td><td align="right">697312,597 ns</td></tr>
<tr>
<td align="right">254,054 μs</td><td align="right">254,071 μs</td><td align="right">262,815 μs</td><td align="right">273,101 μs</td><td align="right">684,229 μs</td><td align="right">697,313 μs</td></tr>
<tr>
<td align="right">0,254 ms</td><td align="right">0,254 ms</td><td align="right">0,263 ms</td><td align="right">0,273 ms</td><td align="right">0,684 ms</td><td align="right">0,697 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">51831,579 ns</td><td align="right">51916,135 ns</td><td align="right">57954,210 ns</td><td align="right">57994,150 ns</td><td align="right">426826,556 ns</td><td align="right">426090,254 ns</td></tr>
<tr>
<td align="right">51,832 μs</td><td align="right">51,916 μs</td><td align="right">57,954 μs</td><td align="right">57,994 μs</td><td align="right">426,827 μs</td><td align="right">426,090 μs</td></tr>
<tr>
<td align="right">0,052 ms</td><td align="right">0,052 ms</td><td align="right">0,058 ms</td><td align="right">0,058 ms</td><td align="right">0,427 ms</td><td align="right">0,426 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">172867,983 ns</td><td align="right">169813,116 ns</td><td align="right">179939,699 ns</td><td align="right">186242,655 ns</td><td align="right">575405,848 ns</td><td align="right">578357,640 ns</td></tr>
<tr>
<td align="right">172,868 μs</td><td align="right">169,813 μs</td><td align="right">179,940 μs</td><td align="right">186,243 μs</td><td align="right">575,406 μs</td><td align="right">578,358 μs</td></tr>
<tr>
<td align="right">0,173 ms</td><td align="right">0,170 ms</td><td align="right">0,180 ms</td><td align="right">0,186 ms</td><td align="right">0,575 ms</td><td align="right">0,578 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">857355,536 ns</td><td align="right">857467,210 ns</td><td align="right">885101,037 ns</td><td align="right">926414,875 ns</td><td align="right">1367355,727 ns</td><td align="right">1386286,585 ns</td></tr>
<tr>
<td align="right">857,356 μs</td><td align="right">857,467 μs</td><td align="right">885,101 μs</td><td align="right">926,415 μs</td><td align="right">1367,356 μs</td><td align="right">1386,287 μs</td></tr>
<tr>
<td align="right">0,857 ms</td><td align="right">0,857 ms</td><td align="right">0,885 ms</td><td align="right">0,926 ms</td><td align="right">1,367 ms</td><td align="right">1,386 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">17950536,510 ns</td><td align="right">16853080,766 ns</td><td align="right">17141231,031 ns</td><td align="right">16927254,248 ns</td><td align="right">18820603,225 ns</td><td align="right">17445108,742 ns</td></tr>
<tr>
<td align="right">17950,537 μs</td><td align="right">16853,081 μs</td><td align="right">17141,231 μs</td><td align="right">16927,254 μs</td><td align="right">18820,603 μs</td><td align="right">17445,109 μs</td></tr>
<tr>
<td align="right">17,951 ms</td><td align="right">16,853 ms</td><td align="right">17,141 ms</td><td align="right">16,927 ms</td><td align="right">18,821 ms</td><td align="right">17,445 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">705044,805 ns</td><td align="right">710124,279 ns</td><td align="right">706052,908 ns</td><td align="right">717292,273 ns</td><td align="right">1121476,811 ns</td><td align="right">1143489,768 ns</td></tr>
<tr>
<td align="right">705,045 μs</td><td align="right">710,124 μs</td><td align="right">706,053 μs</td><td align="right">717,292 μs</td><td align="right">1121,477 μs</td><td align="right">1143,490 μs</td></tr>
<tr>
<td align="right">0,705 ms</td><td align="right">0,710 ms</td><td align="right">0,706 ms</td><td align="right">0,717 ms</td><td align="right">1,121 ms</td><td align="right">1,143 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.4.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">2819345,600 ns</td><td align="right">2802595,727 ns</td><td align="right">2797340,627 ns</td><td align="right">2846512,144 ns</td><td align="right">3269198,134 ns</td><td align="right">3257766,669 ns</td></tr>
<tr>
<td align="right">2819,346 μs</td><td align="right">2802,596 μs</td><td align="right">2797,341 μs</td><td align="right">2846,512 μs</td><td align="right">3269,198 μs</td><td align="right">3257,767 μs</td></tr>
<tr>
<td align="right">2,819 ms</td><td align="right">2,803 ms</td><td align="right">2,797 ms</td><td align="right">2,847 ms</td><td align="right">3,269 ms</td><td align="right">3,258 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">13685613,987 ns</td><td align="right">13181783,962 ns</td><td align="right">13252394,566 ns</td><td align="right">13346558,597 ns</td><td align="right">14153938,418 ns</td><td align="right">14008624,159 ns</td></tr>
<tr>
<td align="right">13685,614 μs</td><td align="right">13181,784 μs</td><td align="right">13252,395 μs</td><td align="right">13346,559 μs</td><td align="right">14153,938 μs</td><td align="right">14008,624 μs</td></tr>
<tr>
<td align="right">13,686 ms</td><td align="right">13,182 ms</td><td align="right">13,252 ms</td><td align="right">13,347 ms</td><td align="right">14,154 ms</td><td align="right">14,009 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">716087,699 ns</td><td align="right">739647,732 ns</td><td align="right">876922,361 ns</td><td align="right">932483,425 ns</td><td align="right">1368339,423 ns</td><td align="right">1356756,097 ns</td></tr>
<tr>
<td align="right">716,088 μs</td><td align="right">739,648 μs</td><td align="right">876,922 μs</td><td align="right">932,483 μs</td><td align="right">1368,339 μs</td><td align="right">1356,756 μs</td></tr>
<tr>
<td align="right">0,716 ms</td><td align="right">0,740 ms</td><td align="right">0,877 ms</td><td align="right">0,932 ms</td><td align="right">1,368 ms</td><td align="right">1,357 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">89680,676 ns</td><td align="right">89277,361 ns</td><td align="right">132363,152 ns</td><td align="right">145195,942 ns</td><td align="right">529618,695 ns</td><td align="right">524537,003 ns</td></tr>
<tr>
<td align="right">89,681 μs</td><td align="right">89,277 μs</td><td align="right">132,363 μs</td><td align="right">145,196 μs</td><td align="right">529,619 μs</td><td align="right">524,537 μs</td></tr>
<tr>
<td align="right">0,090 ms</td><td align="right">0,089 ms</td><td align="right">0,132 ms</td><td align="right">0,145 ms</td><td align="right">0,530 ms</td><td align="right">0,525 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">319827,414 ns</td><td align="right">322964,149 ns</td><td align="right">464239,348 ns</td><td align="right">515051,456 ns</td><td align="right">933239,887 ns</td><td align="right">923625,340 ns</td></tr>
<tr>
<td align="right">319,827 μs</td><td align="right">322,964 μs</td><td align="right">464,239 μs</td><td align="right">515,051 μs</td><td align="right">933,240 μs</td><td align="right">923,625 μs</td></tr>
<tr>
<td align="right">0,320 ms</td><td align="right">0,323 ms</td><td align="right">0,464 ms</td><td align="right">0,515 ms</td><td align="right">0,933 ms</td><td align="right">0,924 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1562416,523 ns</td><td align="right">1596208,513 ns</td><td align="right">2188265,211 ns</td><td align="right">2362494,739 ns</td><td align="right">2938769,968 ns</td><td align="right">2952078,311 ns</td></tr>
<tr>
<td align="right">1562,417 μs</td><td align="right">1596,209 μs</td><td align="right">2188,265 μs</td><td align="right">2362,495 μs</td><td align="right">2938,770 μs</td><td align="right">2952,078 μs</td></tr>
<tr>
<td align="right">1,562 ms</td><td align="right">1,596 ms</td><td align="right">2,188 ms</td><td align="right">2,362 ms</td><td align="right">2,939 ms</td><td align="right">2,952 ms</td></tr>
</table>

## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">31166,244 ns</td><td align="right">32847,224 ns</td><td align="right">33651,092 ns</td><td align="right">34852,924 ns</td><td align="right">32927,461 ns</td><td align="right">22812,336 ns</td></tr>
<tr>
<td align="right">31,166 μs</td><td align="right">32,847 μs</td><td align="right">33,651 μs</td><td align="right">34,853 μs</td><td align="right">32,927 μs</td><td align="right">22,812 μs</td></tr>
<tr>
<td align="right">0,031 ms</td><td align="right">0,033 ms</td><td align="right">0,034 ms</td><td align="right">0,035 ms</td><td align="right">0,033 ms</td><td align="right">0,023 ms</td></tr>
</table>

