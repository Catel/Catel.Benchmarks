# Benchmarks

Benchmark report generated on 17-nov-2016 14:54

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

Fastest: **4.5.4**

Slowest: 5.0.0


<table>
<tr>
<th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">302,471 ns</td><td align="right">302,533 ns</td></tr>
<tr>
<td align="right">0,302 μs</td><td align="right">0,303 μs</td></tr>
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
<td align="right">35,913 ns</td><td align="right">35,882 ns</td></tr>
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
<td align="right">5,474 ns</td><td align="right">5,398 ns</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">10,151 ns</td><td align="right">9,887 ns</td><td align="right">9,686 ns</td><td align="right">10,786 ns</td><td align="right">10,087 ns</td><td align="right">5,475 ns</td></tr>
<tr>
<td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,010 μs</td><td align="right">0,011 μs</td><td align="right">0,010 μs</td><td align="right">0,005 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">20,006 ns</td><td align="right">18,387 ns</td><td align="right">19,257 ns</td><td align="right">20,218 ns</td><td align="right">18,323 ns</td><td align="right">18,275 ns</td></tr>
<tr>
<td align="right">0,020 μs</td><td align="right">0,018 μs</td><td align="right">0,019 μs</td><td align="right">0,020 μs</td><td align="right">0,018 μs</td><td align="right">0,018 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">15,924 ns</td><td align="right">14,865 ns</td><td align="right">14,814 ns</td><td align="right">16,164 ns</td><td align="right">15,019 ns</td><td align="right">14,889 ns</td></tr>
<tr>
<td align="right">0,016 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td><td align="right">0,016 μs</td><td align="right">0,015 μs</td><td align="right">0,015 μs</td></tr>
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
<td align="right">555,889 ns</td><td align="right">549,912 ns</td><td align="right">552,242 ns</td><td align="right">587,981 ns</td><td align="right">294,355 ns</td><td align="right">282,661 ns</td></tr>
<tr>
<td align="right">0,556 μs</td><td align="right">0,550 μs</td><td align="right">0,552 μs</td><td align="right">0,588 μs</td><td align="right">0,294 μs</td><td align="right">0,283 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

Fastest: **4.5.4**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">853,605 ns</td><td align="right">845,836 ns</td><td align="right">881,253 ns</td><td align="right">904,093 ns</td><td align="right">605,349 ns</td><td align="right">655,389 ns</td></tr>
<tr>
<td align="right">0,854 μs</td><td align="right">0,846 μs</td><td align="right">0,881 μs</td><td align="right">0,904 μs</td><td align="right">0,605 μs</td><td align="right">0,655 μs</td></tr>
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
<td align="right">786,109 ns</td><td align="right">776,831 ns</td><td align="right">817,759 ns</td><td align="right">880,080 ns</td><td align="right">509,936 ns</td><td align="right">512,987 ns</td></tr>
<tr>
<td align="right">0,786 μs</td><td align="right">0,777 μs</td><td align="right">0,818 μs</td><td align="right">0,880 μs</td><td align="right">0,510 μs</td><td align="right">0,513 μs</td></tr>
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
<td align="right">133,040 ns</td><td align="right">154,524 ns</td><td align="right">180,225 ns</td><td align="right">158,575 ns</td><td align="right">158,136 ns</td><td align="right">157,226 ns</td></tr>
<tr>
<td align="right">0,133 μs</td><td align="right">0,155 μs</td><td align="right">0,180 μs</td><td align="right">0,159 μs</td><td align="right">0,158 μs</td><td align="right">0,157 μs</td></tr>
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
<td align="right">133,820 ns</td><td align="right">155,763 ns</td><td align="right">179,971 ns</td><td align="right">159,434 ns</td><td align="right">156,537 ns</td><td align="right">162,008 ns</td></tr>
<tr>
<td align="right">0,134 μs</td><td align="right">0,156 μs</td><td align="right">0,180 μs</td><td align="right">0,159 μs</td><td align="right">0,157 μs</td><td align="right">0,162 μs</td></tr>
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
<td align="right">127,640 ns</td><td align="right">148,287 ns</td><td align="right">176,632 ns</td><td align="right">152,029 ns</td><td align="right">147,552 ns</td><td align="right">146,508 ns</td></tr>
<tr>
<td align="right">0,128 μs</td><td align="right">0,148 μs</td><td align="right">0,177 μs</td><td align="right">0,152 μs</td><td align="right">0,148 μs</td><td align="right">0,147 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1356,469 ns</td><td align="right">1537,931 ns</td><td align="right">1564,199 ns</td><td align="right">1756,294 ns</td><td align="right">1924,213 ns</td><td align="right">1410,638 ns</td></tr>
<tr>
<td align="right">1,356 μs</td><td align="right">1,538 μs</td><td align="right">1,564 μs</td><td align="right">1,756 μs</td><td align="right">1,924 μs</td><td align="right">1,411 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **5.0.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1820,822 ns</td><td align="right">1908,455 ns</td><td align="right">1672,938 ns</td><td align="right">1982,634 ns</td><td align="right">2059,326 ns</td><td align="right">1512,544 ns</td></tr>
<tr>
<td align="right">1,821 μs</td><td align="right">1,908 μs</td><td align="right">1,673 μs</td><td align="right">1,983 μs</td><td align="right">2,059 μs</td><td align="right">1,513 μs</td></tr>
<tr>
<td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1473,032 ns</td><td align="right">1383,606 ns</td><td align="right">1561,474 ns</td><td align="right">1666,596 ns</td><td align="right">1629,216 ns</td><td align="right">1153,065 ns</td></tr>
<tr>
<td align="right">1,473 μs</td><td align="right">1,384 μs</td><td align="right">1,561 μs</td><td align="right">1,667 μs</td><td align="right">1,629 μs</td><td align="right">1,153 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">264074,456 ns</td><td align="right">258630,270 ns</td><td align="right">265892,298 ns</td><td align="right">279936,137 ns</td><td align="right">701804,235 ns</td><td align="right">676775,983 ns</td></tr>
<tr>
<td align="right">264,074 μs</td><td align="right">258,630 μs</td><td align="right">265,892 μs</td><td align="right">279,936 μs</td><td align="right">701,804 μs</td><td align="right">676,776 μs</td></tr>
<tr>
<td align="right">0,264 ms</td><td align="right">0,259 ms</td><td align="right">0,266 ms</td><td align="right">0,280 ms</td><td align="right">0,702 ms</td><td align="right">0,677 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">54477,966 ns</td><td align="right">56025,649 ns</td><td align="right">54666,452 ns</td><td align="right">58438,911 ns</td><td align="right">435269,284 ns</td><td align="right">432006,586 ns</td></tr>
<tr>
<td align="right">54,478 μs</td><td align="right">56,026 μs</td><td align="right">54,666 μs</td><td align="right">58,439 μs</td><td align="right">435,269 μs</td><td align="right">432,007 μs</td></tr>
<tr>
<td align="right">0,054 ms</td><td align="right">0,056 ms</td><td align="right">0,055 ms</td><td align="right">0,058 ms</td><td align="right">0,435 ms</td><td align="right">0,432 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">174650,442 ns</td><td align="right">176159,594 ns</td><td align="right">177739,444 ns</td><td align="right">186256,406 ns</td><td align="right">581873,274 ns</td><td align="right">579116,234 ns</td></tr>
<tr>
<td align="right">174,650 μs</td><td align="right">176,160 μs</td><td align="right">177,739 μs</td><td align="right">186,256 μs</td><td align="right">581,873 μs</td><td align="right">579,116 μs</td></tr>
<tr>
<td align="right">0,175 ms</td><td align="right">0,176 ms</td><td align="right">0,178 ms</td><td align="right">0,186 ms</td><td align="right">0,582 ms</td><td align="right">0,579 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.2.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">881091,661 ns</td><td align="right">884835,083 ns</td><td align="right">884573,263 ns</td><td align="right">942858,573 ns</td><td align="right">1445299,300 ns</td><td align="right">1431866,643 ns</td></tr>
<tr>
<td align="right">881,092 μs</td><td align="right">884,835 μs</td><td align="right">884,573 μs</td><td align="right">942,859 μs</td><td align="right">1445,299 μs</td><td align="right">1431,867 μs</td></tr>
<tr>
<td align="right">0,881 ms</td><td align="right">0,885 ms</td><td align="right">0,885 ms</td><td align="right">0,943 ms</td><td align="right">1,445 ms</td><td align="right">1,432 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">16974024,819 ns</td><td align="right">16836855,019 ns</td><td align="right">16895604,950 ns</td><td align="right">17439959,538 ns</td><td align="right">17431893,916 ns</td></tr>
<tr>
<td align="right">16974,025 μs</td><td align="right">16836,855 μs</td><td align="right">16895,605 μs</td><td align="right">17439,960 μs</td><td align="right">17431,894 μs</td></tr>
<tr>
<td align="right">16,974 ms</td><td align="right">16,837 ms</td><td align="right">16,896 ms</td><td align="right">17,440 ms</td><td align="right">17,432 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.3.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">738826,421 ns</td><td align="right">703000,003 ns</td><td align="right">706751,489 ns</td><td align="right">720505,614 ns</td><td align="right">1102680,254 ns</td></tr>
<tr>
<td align="right">738,826 μs</td><td align="right">703,000 μs</td><td align="right">706,751 μs</td><td align="right">720,506 μs</td><td align="right">1102,680 μs</td></tr>
<tr>
<td align="right">0,739 ms</td><td align="right">0,703 ms</td><td align="right">0,707 ms</td><td align="right">0,721 ms</td><td align="right">1,103 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.4.0**

Slowest: 5.0.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">2839165,904 ns</td><td align="right">2849408,332 ns</td><td align="right">2812727,399 ns</td><td align="right">2909318,252 ns</td><td align="right">3249592,478 ns</td></tr>
<tr>
<td align="right">2839,166 μs</td><td align="right">2849,408 μs</td><td align="right">2812,727 μs</td><td align="right">2909,318 μs</td><td align="right">3249,592 μs</td></tr>
<tr>
<td align="right">2,839 ms</td><td align="right">2,849 ms</td><td align="right">2,813 ms</td><td align="right">2,909 ms</td><td align="right">3,250 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.4.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>5.0.0</th></tr>
<tr>
<td align="right">14060171,027 ns</td><td align="right">13340263,379 ns</td><td align="right">13325679,409 ns</td><td align="right">14323426,581 ns</td><td align="right">13880631,126 ns</td></tr>
<tr>
<td align="right">14060,171 μs</td><td align="right">13340,263 μs</td><td align="right">13325,679 μs</td><td align="right">14323,427 μs</td><td align="right">13880,631 μs</td></tr>
<tr>
<td align="right">14,060 ms</td><td align="right">13,340 ms</td><td align="right">13,326 ms</td><td align="right">14,323 ms</td><td align="right">13,881 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">753179,465 ns</td><td align="right">733776,768 ns</td><td align="right">868150,050 ns</td><td align="right">990957,303 ns</td><td align="right">1452579,218 ns</td><td align="right">1386418,762 ns</td></tr>
<tr>
<td align="right">753,179 μs</td><td align="right">733,777 μs</td><td align="right">868,150 μs</td><td align="right">990,957 μs</td><td align="right">1452,579 μs</td><td align="right">1386,419 μs</td></tr>
<tr>
<td align="right">0,753 ms</td><td align="right">0,734 ms</td><td align="right">0,868 ms</td><td align="right">0,991 ms</td><td align="right">1,453 ms</td><td align="right">1,386 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">95328,274 ns</td><td align="right">90567,987 ns</td><td align="right">130959,801 ns</td><td align="right">152428,778 ns</td><td align="right">531457,643 ns</td><td align="right">528359,066 ns</td></tr>
<tr>
<td align="right">95,328 μs</td><td align="right">90,568 μs</td><td align="right">130,960 μs</td><td align="right">152,429 μs</td><td align="right">531,458 μs</td><td align="right">528,359 μs</td></tr>
<tr>
<td align="right">0,095 ms</td><td align="right">0,091 ms</td><td align="right">0,131 ms</td><td align="right">0,152 ms</td><td align="right">0,531 ms</td><td align="right">0,528 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">335097,330 ns</td><td align="right">327458,206 ns</td><td align="right">459009,045 ns</td><td align="right">532839,562 ns</td><td align="right">944107,504 ns</td><td align="right">919589,776 ns</td></tr>
<tr>
<td align="right">335,097 μs</td><td align="right">327,458 μs</td><td align="right">459,009 μs</td><td align="right">532,840 μs</td><td align="right">944,108 μs</td><td align="right">919,590 μs</td></tr>
<tr>
<td align="right">0,335 ms</td><td align="right">0,327 ms</td><td align="right">0,459 ms</td><td align="right">0,533 ms</td><td align="right">0,944 ms</td><td align="right">0,920 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **4.3.0**

Slowest: 4.5.4


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">1732570,730 ns</td><td align="right">1603113,938 ns</td><td align="right">2230568,737 ns</td><td align="right">2497885,513 ns</td><td align="right">3072563,961 ns</td><td align="right">2953022,582 ns</td></tr>
<tr>
<td align="right">1732,571 μs</td><td align="right">1603,114 μs</td><td align="right">2230,569 μs</td><td align="right">2497,886 μs</td><td align="right">3072,564 μs</td><td align="right">2953,023 μs</td></tr>
<tr>
<td align="right">1,733 ms</td><td align="right">1,603 ms</td><td align="right">2,231 ms</td><td align="right">2,498 ms</td><td align="right">3,073 ms</td><td align="right">2,953 ms</td></tr>
</table>

## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

Fastest: **5.0.0**

Slowest: 4.5.0


<table>
<tr>
<th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td align="right">30800,571 ns</td><td align="right">33359,787 ns</td><td align="right">33415,775 ns</td><td align="right">34287,458 ns</td><td align="right">33752,348 ns</td><td align="right">22920,182 ns</td></tr>
<tr>
<td align="right">30,801 μs</td><td align="right">33,360 μs</td><td align="right">33,416 μs</td><td align="right">34,287 μs</td><td align="right">33,752 μs</td><td align="right">22,920 μs</td></tr>
<tr>
<td align="right">0,031 ms</td><td align="right">0,033 ms</td><td align="right">0,033 ms</td><td align="right">0,034 ms</td><td align="right">0,034 ms</td><td align="right">0,023 ms</td></tr>
</table>

