# Benchmarks

Benchmark report generated on 15-nov-2016 12:52

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


# Table of contents
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

## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.4.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">134,360 ns</td><td align="right">154,999 ns</td><td align="right">177,196 ns</td><td align="right">155,488 ns</td><td align="right">156,377 ns</td></tr>
<tr>
<td align="right">0,134 μs</td><td align="right">0,155 μs</td><td align="right">0,177 μs</td><td align="right">0,155 μs</td><td align="right">0,156 μs</td></tr>
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
<td align="right">135,286 ns</td><td align="right">155,170 ns</td><td align="right">179,017 ns</td><td align="right">154,970 ns</td><td align="right">157,003 ns</td></tr>
<tr>
<td align="right">0,135 μs</td><td align="right">0,155 μs</td><td align="right">0,179 μs</td><td align="right">0,155 μs</td><td align="right">0,157 μs</td></tr>
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
<td align="right">126,500 ns</td><td align="right">150,434 ns</td><td align="right">172,893 ns</td><td align="right">149,412 ns</td><td align="right">147,998 ns</td></tr>
<tr>
<td align="right">0,126 μs</td><td align="right">0,150 μs</td><td align="right">0,173 μs</td><td align="right">0,149 μs</td><td align="right">0,148 μs</td></tr>
<tr>
<td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td><td align="right">0,000 ms</td></tr>
</table>

## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1402,897 ns</td><td align="right">1654,351 ns</td><td align="right">1775,562 ns</td><td align="right">1666,569 ns</td><td align="right">1717,308 ns</td></tr>
<tr>
<td align="right">1,403 μs</td><td align="right">1,654 μs</td><td align="right">1,776 μs</td><td align="right">1,667 μs</td><td align="right">1,717 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1486,212 ns</td><td align="right">1794,853 ns</td><td align="right">1872,308 ns</td><td align="right">1846,808 ns</td><td align="right">1779,526 ns</td></tr>
<tr>
<td align="right">1,486 μs</td><td align="right">1,795 μs</td><td align="right">1,872 μs</td><td align="right">1,847 μs</td><td align="right">1,780 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.4.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1425,612 ns</td><td align="right">1527,252 ns</td><td align="right">1485,016 ns</td><td align="right">1814,875 ns</td><td align="right">1786,702 ns</td></tr>
<tr>
<td align="right">1,426 μs</td><td align="right">1,527 μs</td><td align="right">1,485 μs</td><td align="right">1,815 μs</td><td align="right">1,787 μs</td></tr>
<tr>
<td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,001 ms</td><td align="right">0,002 ms</td><td align="right">0,002 ms</td></tr>
</table>

## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">253758,502 ns</td><td align="right">256776,075 ns</td><td align="right">258258,216 ns</td><td align="right">274977,051 ns</td><td align="right">625197,830 ns</td></tr>
<tr>
<td align="right">253,759 μs</td><td align="right">256,776 μs</td><td align="right">258,258 μs</td><td align="right">274,977 μs</td><td align="right">625,198 μs</td></tr>
<tr>
<td align="right">0,254 ms</td><td align="right">0,257 ms</td><td align="right">0,258 ms</td><td align="right">0,275 ms</td><td align="right">0,625 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">51704,893 ns</td><td align="right">52286,590 ns</td><td align="right">55158,707 ns</td><td align="right">59067,554 ns</td><td align="right">387838,735 ns</td></tr>
<tr>
<td align="right">51,705 μs</td><td align="right">52,287 μs</td><td align="right">55,159 μs</td><td align="right">59,068 μs</td><td align="right">387,839 μs</td></tr>
<tr>
<td align="right">0,052 ms</td><td align="right">0,052 ms</td><td align="right">0,055 ms</td><td align="right">0,059 ms</td><td align="right">0,388 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">167058,953 ns</td><td align="right">172406,325 ns</td><td align="right">179090,536 ns</td><td align="right">187467,441 ns</td><td align="right">531069,891 ns</td></tr>
<tr>
<td align="right">167,059 μs</td><td align="right">172,406 μs</td><td align="right">179,091 μs</td><td align="right">187,467 μs</td><td align="right">531,070 μs</td></tr>
<tr>
<td align="right">0,167 ms</td><td align="right">0,172 ms</td><td align="right">0,179 ms</td><td align="right">0,187 ms</td><td align="right">0,531 ms</td></tr>
</table>

### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">830003,054 ns</td><td align="right">867874,791 ns</td><td align="right">869711,351 ns</td><td align="right">940493,611 ns</td><td align="right">1323467,311 ns</td></tr>
<tr>
<td align="right">830,003 μs</td><td align="right">867,875 μs</td><td align="right">869,711 μs</td><td align="right">940,494 μs</td><td align="right">1323,467 μs</td></tr>
<tr>
<td align="right">0,830 ms</td><td align="right">0,868 ms</td><td align="right">0,870 ms</td><td align="right">0,940 ms</td><td align="right">1,323 ms</td></tr>
</table>

## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">16703470,361 ns</td><td align="right">16714399,506 ns</td><td align="right">17023907,568 ns</td><td align="right">17466815,061 ns</td></tr>
<tr>
<td align="right">16703,470 μs</td><td align="right">16714,400 μs</td><td align="right">17023,908 μs</td><td align="right">17466,815 μs</td></tr>
<tr>
<td align="right">16,703 ms</td><td align="right">16,714 ms</td><td align="right">17,024 ms</td><td align="right">17,467 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">697245,554 ns</td><td align="right">701311,099 ns</td><td align="right">703591,910 ns</td><td align="right">711486,966 ns</td></tr>
<tr>
<td align="right">697,246 μs</td><td align="right">701,311 μs</td><td align="right">703,592 μs</td><td align="right">711,487 μs</td></tr>
<tr>
<td align="right">0,697 ms</td><td align="right">0,701 ms</td><td align="right">0,704 ms</td><td align="right">0,711 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">2876358,184 ns</td><td align="right">2799030,688 ns</td><td align="right">2783620,817 ns</td><td align="right">2803865,423 ns</td></tr>
<tr>
<td align="right">2876,358 μs</td><td align="right">2799,031 μs</td><td align="right">2783,621 μs</td><td align="right">2803,865 μs</td></tr>
<tr>
<td align="right">2,876 ms</td><td align="right">2,799 ms</td><td align="right">2,784 ms</td><td align="right">2,804 ms</td></tr>
</table>

### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.3.0**

Slowest: Catel.Benchmarks.4.2.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th></tr>
<tr>
<td align="right">13658854,599 ns</td><td align="right">13322079,410 ns</td><td align="right">13346999,168 ns</td><td align="right">13455642,821 ns</td></tr>
<tr>
<td align="right">13658,855 μs</td><td align="right">13322,079 μs</td><td align="right">13346,999 μs</td><td align="right">13455,643 μs</td></tr>
<tr>
<td align="right">13,659 ms</td><td align="right">13,322 ms</td><td align="right">13,347 ms</td><td align="right">13,456 ms</td></tr>
</table>

## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

Fastest: **Catel.Benchmarks.4.4.0**

Slowest: Catel.Benchmarks.4.3.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">723975,347 ns</td><td align="right">728263,964 ns</td><td align="right">878329,452 ns</td><td align="right">900121,924 ns</td><td align="right">1313812,664 ns</td></tr>
<tr>
<td align="right">723,975 μs</td><td align="right">728,264 μs</td><td align="right">878,329 μs</td><td align="right">900,122 μs</td><td align="right">1313,813 μs</td></tr>
<tr>
<td align="right">0,724 ms</td><td align="right">0,728 ms</td><td align="right">0,878 ms</td><td align="right">0,900 ms</td><td align="right">1,314 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.3.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">88673,266 ns</td><td align="right">91049,875 ns</td><td align="right">132193,112 ns</td><td align="right">138354,284 ns</td><td align="right">479519,432 ns</td></tr>
<tr>
<td align="right">88,673 μs</td><td align="right">91,050 μs</td><td align="right">132,193 μs</td><td align="right">138,354 μs</td><td align="right">479,519 μs</td></tr>
<tr>
<td align="right">0,089 ms</td><td align="right">0,091 ms</td><td align="right">0,132 ms</td><td align="right">0,138 ms</td><td align="right">0,480 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

Fastest: **Catel.Benchmarks.4.5.4**

Slowest: Catel.Benchmarks.4.3.0


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">322623,825 ns</td><td align="right">323078,882 ns</td><td align="right">466722,221 ns</td><td align="right">490394,416 ns</td><td align="right">863349,094 ns</td></tr>
<tr>
<td align="right">322,624 μs</td><td align="right">323,079 μs</td><td align="right">466,722 μs</td><td align="right">490,394 μs</td><td align="right">863,349 μs</td></tr>
<tr>
<td align="right">0,323 ms</td><td align="right">0,323 ms</td><td align="right">0,467 ms</td><td align="right">0,490 ms</td><td align="right">0,863 ms</td></tr>
</table>

### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

Fastest: **Catel.Benchmarks.4.2.0**

Slowest: Catel.Benchmarks.4.5.4


<table>
<tr>
<th>Catel.Benchmarks.4.2.0</th><th>Catel.Benchmarks.4.3.0</th><th>Catel.Benchmarks.4.4.0</th><th>Catel.Benchmarks.4.5.0</th><th>Catel.Benchmarks.4.5.4</th></tr>
<tr>
<td align="right">1563116,423 ns</td><td align="right">1635764,118 ns</td><td align="right">2187647,980 ns</td><td align="right">2321153,581 ns</td><td align="right">2867191,697 ns</td></tr>
<tr>
<td align="right">1563,116 μs</td><td align="right">1635,764 μs</td><td align="right">2187,648 μs</td><td align="right">2321,154 μs</td><td align="right">2867,192 μs</td></tr>
<tr>
<td align="right">1,563 ms</td><td align="right">1,636 ms</td><td align="right">2,188 ms</td><td align="right">2,321 ms</td><td align="right">2,867 ms</td></tr>
</table>

