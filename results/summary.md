# Benchmarks

Benchmark report generated on 21-jun-2017 15:59

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



## Important benchmarks

### High priority (current version slower than previous one)

52 item(s)

1. [Assembly_ReflectionExtensions_Benchmark](#Assembly_ReflectionExtensions_Benchmark) v5.0.0 is **246109,50%** (Δ: 1767,887 ns) slower than v4.5.4

2. [TypeFactory_Benchmark](#TypeFactory_Benchmark) v5.0.0 is **168799,82%** (Δ: 4265,807 ns) slower than v4.5.4

3. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **79794,60%** (Δ: 873,727 ns) slower than v4.5.4

4. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **56374,82%** (Δ: 1475,817 ns) slower than v4.5.4

5. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **35164,63%** (Δ: 383,390 ns) slower than v4.5.4

6. [MethodInfo_ReflectionExtensions_Benchmark](#MethodInfo_ReflectionExtensions_Benchmark) v5.0.0 is **27101,00%** (Δ: 300,474 ns) slower than v4.5.4

7. [TypeFactory_Benchmark](#TypeFactory_Benchmark) v5.0.0 is **14630,21%** (Δ: 540,760 ns) slower than v4.5.4

8. [TypeFactory_Benchmark](#TypeFactory_Benchmark) v5.0.0 is **11323,32%** (Δ: 327,317 ns) slower than v4.5.4

9. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **11266,44%** (Δ: 306,963 ns) slower than v4.5.4

10. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **9418,69%** (Δ: 603,601 ns) slower than v4.5.4

11. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **4839,54%** (Δ: 122,498 ns) slower than v4.5.4

12. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **3610,68%** (Δ: 119,545 ns) slower than v4.5.4

13. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **3199,98%** (Δ: 100,169 ns) slower than v4.5.4

14. [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark) v5.0.0 is **1682,75%** (Δ: 184,436 ns) slower than v4.5.4

15. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **693,07%** (Δ: 80,382 ns) slower than v4.5.4

16. [ServiceLocator_Benchmark](#ServiceLocator_Benchmark) v5.0.0 is **558,06%** (Δ: 60,907 ns) slower than v4.5.4

17. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **391,45%** (Δ: 50,466 ns) slower than v4.5.4

18. [TypeExtensions_Benchmark](#TypeExtensions_Benchmark) v5.0.0 is **318,09%** (Δ: 34,593 ns) slower than v4.5.4

19. [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark) v5.0.0 is **307,20%** (Δ: 36,676 ns) slower than v4.5.4

20. [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark) v5.0.0 is **218,73%** (Δ: 29,284 ns) slower than v4.5.4

21. [CacheStorage_Benchmark](#CacheStorage_Benchmark) v5.0.0 is **70,16%** (Δ: 30,433 ns) slower than v4.5.4

22. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **67,68%** (Δ: 44,812 ns) slower than v4.5.4

23. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **61,48%** (Δ: 19,268 ns) slower than v4.5.4

24. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **59,92%** (Δ: 19,373 ns) slower than v4.5.4

25. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **52,66%** (Δ: 16,869 ns) slower than v4.5.4

26. [CacheStorage_Benchmark](#CacheStorage_Benchmark) v5.0.0 is **35,96%** (Δ: 14,760 ns) slower than v4.5.4

27. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **34,29%** (Δ: 34,759 ns) slower than v4.5.4

28. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **30,09%** (Δ: 19,305 ns) slower than v4.5.4

29. [PropertyBag_GetPropertyValue_Benchmark](#PropertyBag_GetPropertyValue_Benchmark) v5.0.0 is **26,74%** (Δ: 32,647 ns) slower than v4.5.4

30. [ModelBase_GetValue_Benchmark](#ModelBase_GetValue_Benchmark) v5.0.0 is **25,33%** (Δ: 21,622 ns) slower than v4.5.4

31. [TypeExtensions_Benchmark](#TypeExtensions_Benchmark) v5.0.0 is **24,14%** (Δ: 10,073 ns) slower than v4.5.4

32. [ModelBase_GetValue_Benchmark](#ModelBase_GetValue_Benchmark) v5.0.0 is **23,62%** (Δ: 19,334 ns) slower than v4.5.4

33. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **23,57%** (Δ: 17,513 ns) slower than v4.5.4

34. [CacheStorage_Benchmark](#CacheStorage_Benchmark) v5.0.0 is **17,61%** (Δ: 7,656 ns) slower than v4.5.4

35. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **17,48%** (Δ: 9,278 ns) slower than v4.5.4

36. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **9,66%** (Δ: 10,785 ns) slower than v4.5.4

37. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **6,55%** (Δ: 8,282 ns) slower than v4.5.4

38. [ModelBase_GetValue_Benchmark](#ModelBase_GetValue_Benchmark) v5.0.0 is **6,34%** (Δ: 4,713 ns) slower than v4.5.4

39. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **3,02%** (Δ: 9,223 ns) slower than v4.5.4

40. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **2,23%** (Δ: 3,881 ns) slower than v4.5.4

41. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **2,07%** (Δ: 4,601 ns) slower than v4.5.4

42. [PropertyBag_GetPropertyValue_Benchmark](#PropertyBag_GetPropertyValue_Benchmark) v5.0.0 is **1,89%** (Δ: 2,575 ns) slower than v4.5.4

43. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,86%** (Δ: 2,023 ns) slower than v4.5.4

44. [TypeExtensions_Benchmark](#TypeExtensions_Benchmark) v5.0.0 is **0,39%** (Δ: 1,307 ns) slower than v4.5.4

45. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,31%** (Δ: 3,478 ns) slower than v4.5.4

46. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,27%** (Δ: 1,040 ns) slower than v4.5.4

47. [TypeExtensions_Benchmark](#TypeExtensions_Benchmark) v5.0.0 is **0,20%** (Δ: 1,147 ns) slower than v4.5.4

48. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,08%** (Δ: 0,570 ns) slower than v4.5.4

49. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,05%** (Δ: 0,696 ns) slower than v4.5.4

50. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,03%** (Δ: 0,316 ns) slower than v4.5.4

51. [Log_Disabled_Benchmark](#Log_Disabled_Benchmark) v5.0.0 is **0,02%** (Δ: 0,407 ns) slower than v4.5.4

52. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,01%** (Δ: 0,387 ns) slower than v4.5.4



### Improved (current version faster than previous one)

78 item(s)

1. [Serialization_Json_Benchmark](#Serialization_Json_Benchmark) v5.0.0 is **3853310308871,46%** (Δ: -19397816,517 ns) faster than v4.5.4

2. [Serialization_Json_Benchmark](#Serialization_Json_Benchmark) v5.0.0 is **2456776421925,78%** (Δ: -15443934,487 ns) faster than v4.5.4

3. [Serialization_Json_Benchmark](#Serialization_Json_Benchmark) v5.0.0 is **117584558409,43%** (Δ: -3203626,319 ns) faster than v4.5.4

4. [Serialization_Xml_Benchmark](#Serialization_Xml_Benchmark) v5.0.0 is **91384734901,78%** (Δ: -2797748,030 ns) faster than v4.5.4

5. [Serialization_Binary_Benchmark](#Serialization_Binary_Benchmark) v5.0.0 is **18734732524,41%** (Δ: -1151264,743 ns) faster than v4.5.4

6. [Serialization_Xml_Benchmark](#Serialization_Xml_Benchmark) v5.0.0 is **17199052276,31%** (Δ: -1096267,358 ns) faster than v4.5.4

7. [Serialization_Json_Benchmark](#Serialization_Json_Benchmark) v5.0.0 is **10623608050,41%** (Δ: -822906,007 ns) faster than v4.5.4

8. [Serialization_Xml_Benchmark](#Serialization_Xml_Benchmark) v5.0.0 is **6542235795,35%** (Δ: -600803,208 ns) faster than v4.5.4

9. [Serialization_Binary_Benchmark](#Serialization_Binary_Benchmark) v5.0.0 is **2691042929,67%** (Δ: -331813,203 ns) faster than v4.5.4

10. [Serialization_Binary_Benchmark](#Serialization_Binary_Benchmark) v5.0.0 is **1567096189,88%** (Δ: -221763,760 ns) faster than v4.5.4

11. [Serialization_Xml_Benchmark](#Serialization_Xml_Benchmark) v5.0.0 is **1027416413,40%** (Δ: -162460,968 ns) faster than v4.5.4

12. [Serialization_Binary_Benchmark](#Serialization_Binary_Benchmark) v5.0.0 is **262505087,02%** (Δ: -49822,976 ns) faster than v4.5.4

13. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **5228847,50%** (Δ: -16490,216 ns) faster than v4.5.4

14. [ViewModelBase_Benchmark](#ViewModelBase_Benchmark) v5.0.0 is **2905029,13%** (Δ: -11147,422 ns) faster than v4.5.4

15. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **169183,22%** (Δ: -2051,920 ns) faster than v4.5.4

16. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **155317,76%** (Δ: -2026,857 ns) faster than v4.5.4

17. [ModelBase_EqualityComparer_Benchmark](#ModelBase_EqualityComparer_Benchmark) v5.0.0 is **112452,11%** (Δ: -2200,784 ns) faster than v4.5.4

18. [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark) v5.0.0 is **108864,44%** (Δ: -1825,093 ns) faster than v4.5.4

19. [AssemblyExtensions_Benchmark](#AssemblyExtensions_Benchmark) v5.0.0 is **65610,94%** (Δ: -626,853 ns) faster than v4.5.4

20. [ModelBase_EqualityComparer_Benchmark](#ModelBase_EqualityComparer_Benchmark) v5.0.0 is **47963,84%** (Δ: -1184,173 ns) faster than v4.5.4

21. [ModelBase_Constructor_Benchmark](#ModelBase_Constructor_Benchmark) v5.0.0 is **38985,56%** (Δ: -992,597 ns) faster than v4.5.4

22. [ModelBase_SetValue_Benchmark](#ModelBase_SetValue_Benchmark) v5.0.0 is **22893,53%** (Δ: -1291,553 ns) faster than v4.5.4

23. [ModelBase_SetValue_Benchmark](#ModelBase_SetValue_Benchmark) v5.0.0 is **22397,63%** (Δ: -1288,733 ns) faster than v4.5.4

24. [ModelBase_SetValue_Benchmark](#ModelBase_SetValue_Benchmark) v5.0.0 is **17234,93%** (Δ: -1155,395 ns) faster than v4.5.4

25. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **14125,69%** (Δ: -345,141 ns) faster than v4.5.4

26. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **13804,08%** (Δ: -460,330 ns) faster than v4.5.4

27. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **13557,62%** (Δ: -448,842 ns) faster than v4.5.4

28. [ServiceLocator_Benchmark](#ServiceLocator_Benchmark) v5.0.0 is **11476,65%** (Δ: -288,042 ns) faster than v4.5.4

29. [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark) v5.0.0 is **8661,70%** (Δ: -197,461 ns) faster than v4.5.4

30. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **8644,14%** (Δ: -260,473 ns) faster than v4.5.4

31. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **8194,32%** (Δ: -201,396 ns) faster than v4.5.4

32. [MethodInfo_ReflectionExtensions_Benchmark](#MethodInfo_ReflectionExtensions_Benchmark) v5.0.0 is **7765,42%** (Δ: -169,810 ns) faster than v4.5.4

33. [TypeFactory_Benchmark](#TypeFactory_Benchmark) v5.0.0 is **6696,38%** (Δ: -204,257 ns) faster than v4.5.4

34. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **6023,74%** (Δ: -391,204 ns) faster than v4.5.4

35. [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark) v5.0.0 is **3348,80%** (Δ: -104,420 ns) faster than v4.5.4

36. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **2190,77%** (Δ: -172,757 ns) faster than v4.5.4

37. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **1920,18%** (Δ: -112,969 ns) faster than v4.5.4

38. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **1533,44%** (Δ: -210,383 ns) faster than v4.5.4

39. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **995,91%** (Δ: -93,390 ns) faster than v4.5.4

40. [MemberInfoExtensions_Benchmark](#MemberInfoExtensions_Benchmark) v5.0.0 is **291,06%** (Δ: -74,010 ns) faster than v4.5.4

41. [PropertyBag_SetPropertyValue_Benchmark](#PropertyBag_SetPropertyValue_Benchmark) v5.0.0 is **103,75%** (Δ: -60,140 ns) faster than v4.5.4

42. [PropertyBag_SetPropertyValue_Benchmark](#PropertyBag_SetPropertyValue_Benchmark) v5.0.0 is **96,52%** (Δ: -53,670 ns) faster than v4.5.4

43. [MemberInfoExtensions_Benchmark](#MemberInfoExtensions_Benchmark) v5.0.0 is **84,73%** (Δ: -25,871 ns) faster than v4.5.4

44. [ScopeManager_Benchmark](#ScopeManager_Benchmark) v5.0.0 is **76,99%** (Δ: -35,977 ns) faster than v4.5.4

45. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **73,19%** (Δ: -46,998 ns) faster than v4.5.4

46. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **61,83%** (Δ: -31,030 ns) faster than v4.5.4

47. [FastDateTime_vs_DateTime_Benchmark](#FastDateTime_vs_DateTime_Benchmark) v5.0.0 is **57,42%** (Δ: -16,950 ns) faster than v4.5.4

48. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **54,56%** (Δ: -30,088 ns) faster than v4.5.4

49. [ScopeManager_Benchmark](#ScopeManager_Benchmark) v5.0.0 is **48,38%** (Δ: -25,146 ns) faster than v4.5.4

50. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **38,68%** (Δ: -28,640 ns) faster than v4.5.4

51. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **34,09%** (Δ: -34,822 ns) faster than v4.5.4

52. [CacheStorage_Benchmark](#CacheStorage_Benchmark) v5.0.0 is **31,05%** (Δ: -12,909 ns) faster than v4.5.4

53. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **30,27%** (Δ: -16,348 ns) faster than v4.5.4

54. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **25,45%** (Δ: -32,313 ns) faster than v4.5.4

55. [ServiceLocator_Benchmark](#ServiceLocator_Benchmark) v5.0.0 is **24,85%** (Δ: -12,418 ns) faster than v4.5.4

56. [CacheStorage_Benchmark](#CacheStorage_Benchmark) v5.0.0 is **24,53%** (Δ: -9,846 ns) faster than v4.5.4

57. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **24,03%** (Δ: -11,120 ns) faster than v4.5.4

58. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **21,45%** (Δ: -29,899 ns) faster than v4.5.4

59. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **12,66%** (Δ: -9,643 ns) faster than v4.5.4

60. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **11,84%** (Δ: -6,341 ns) faster than v4.5.4

61. [Enum_Benchmark](#Enum_Benchmark) v5.0.0 is **7,00%** (Δ: -5,092 ns) faster than v4.5.4

62. [FastDateTime_vs_DateTime_Benchmark](#FastDateTime_vs_DateTime_Benchmark) v5.0.0 is **5,46%** (Δ: -4,736 ns) faster than v4.5.4

63. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **4,95%** (Δ: -7,638 ns) faster than v4.5.4

64. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **4,90%** (Δ: -10,105 ns) faster than v4.5.4

65. [PropertyBag_SetPropertyValue_Benchmark](#PropertyBag_SetPropertyValue_Benchmark) v5.0.0 is **2,03%** (Δ: -2,787 ns) faster than v4.5.4

66. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **2,02%** (Δ: -8,330 ns) faster than v4.5.4

67. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **1,61%** (Δ: -3,889 ns) faster than v4.5.4

68. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **1,09%** (Δ: -3,920 ns) faster than v4.5.4

69. [FastDateTime_vs_DateTime_UtcNow_Benchmark](#FastDateTime_vs_DateTime_UtcNow_Benchmark) v5.0.0 is **0,59%** (Δ: -3,823 ns) faster than v4.5.4

70. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,56%** (Δ: -1,496 ns) faster than v4.5.4

71. [WeakEventListener_Benchmark](#WeakEventListener_Benchmark) v5.0.0 is **0,52%** (Δ: -1,850 ns) faster than v4.5.4

72. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,48%** (Δ: -2,638 ns) faster than v4.5.4

73. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,19%** (Δ: -1,989 ns) faster than v4.5.4

74. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,18%** (Δ: -1,091 ns) faster than v4.5.4

75. [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark) v5.0.0 is **0,12%** (Δ: -0,720 ns) faster than v4.5.4

76. [WeakEventListener_Benchmark](#WeakEventListener_Benchmark) v5.0.0 is **0,04%** (Δ: -0,753 ns) faster than v4.5.4

77. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,03%** (Δ: -0,420 ns) faster than v4.5.4

78. [Argument_Benchmark](#Argument_Benchmark) v5.0.0 is **0,01%** (Δ: -0,397 ns) faster than v4.5.4



## Table of contents
* [Argument_Benchmark](#Argument_Benchmark)
  * [ImplementsInterface](#Argument_Benchmark_ImplementsInterface)
  * [ImplementsInterface_Generic](#Argument_Benchmark_ImplementsInterface_Generic)
  * [ImplementsOneOfTheInterfaces](#Argument_Benchmark_ImplementsOneOfTheInterfaces)
  * [ImplementsOneOfTheInterfaces_Object](#Argument_Benchmark_ImplementsOneOfTheInterfaces_Object)
  * [InheritsFrom](#Argument_Benchmark_InheritsFrom)
  * [InheritsFrom_Generic](#Argument_Benchmark_InheritsFrom_Generic)
  * [InheritsFrom_Object](#Argument_Benchmark_InheritsFrom_Object)
  * [IsMatch](#Argument_Benchmark_IsMatch)
  * [IsMaximum](#Argument_Benchmark_IsMaximum)
  * [IsMinimal](#Argument_Benchmark_IsMinimal)
  * [IsNotEmpty](#Argument_Benchmark_IsNotEmpty)
  * [IsNotMatch](#Argument_Benchmark_IsNotMatch)
  * [IsNotNull](#Argument_Benchmark_IsNotNull)
  * [IsNotNullOrEmpty](#Argument_Benchmark_IsNotNullOrEmpty)
  * [IsNotNullOrEmpty_Guid](#Argument_Benchmark_IsNotNullOrEmpty_Guid)
  * [IsNotNullOrEmptyArray](#Argument_Benchmark_IsNotNullOrEmptyArray)
  * [IsNotNullOrWhitespace](#Argument_Benchmark_IsNotNullOrWhitespace)
  * [IsNotOfOneOfTheTypes](#Argument_Benchmark_IsNotOfOneOfTheTypes)
  * [IsNotOfOneOfTheTypes_Object](#Argument_Benchmark_IsNotOfOneOfTheTypes_Object)
  * [IsNotOfType](#Argument_Benchmark_IsNotOfType)
  * [IsNotOfType_Object](#Argument_Benchmark_IsNotOfType_Object)
  * [IsNotOutOfRange](#Argument_Benchmark_IsNotOutOfRange)
  * [IsOfOneOfTheTypes](#Argument_Benchmark_IsOfOneOfTheTypes)
  * [IsOfOneOfTheTypes_Object](#Argument_Benchmark_IsOfOneOfTheTypes_Object)
  * [IsOfType](#Argument_Benchmark_IsOfType)
  * [IsOfType_Object](#Argument_Benchmark_IsOfType_Object)
* [Assembly_ReflectionExtensions_Benchmark](#Assembly_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributesEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetExportedTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx)
  * [GetTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetTypesEx)
* [AssemblyExtensions__Benchmark](#AssemblyExtensions__Benchmark)
  * [Company](#AssemblyExtensions__Benchmark_Company)
  * [Copyright](#AssemblyExtensions__Benchmark_Copyright)
  * [Description](#AssemblyExtensions__Benchmark_Description)
  * [GetBuildDateTime](#AssemblyExtensions__Benchmark_GetBuildDateTime)
  * [GetDirectory](#AssemblyExtensions__Benchmark_GetDirectory)
  * [InformationalVersion](#AssemblyExtensions__Benchmark_InformationalVersion)
  * [Product](#AssemblyExtensions__Benchmark_Product)
  * [Title](#AssemblyExtensions__Benchmark_Title)
  * [Version](#AssemblyExtensions__Benchmark_Version)
* [AssemblyExtensions_Benchmark](#AssemblyExtensions_Benchmark)
  * [Company](#AssemblyExtensions_Benchmark_Company)
  * [Copyright](#AssemblyExtensions_Benchmark_Copyright)
  * [Description](#AssemblyExtensions_Benchmark_Description)
  * [GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime)
  * [GetDirectory](#AssemblyExtensions_Benchmark_GetDirectory)
  * [InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion)
  * [Product](#AssemblyExtensions_Benchmark_Product)
  * [Title](#AssemblyExtensions_Benchmark_Title)
  * [Version](#AssemblyExtensions_Benchmark_Version)
* [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark)
  * [GetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member)
  * [GetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type)
  * [GetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member)
  * [GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type)
  * [IsDecoratedWithAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member)
  * [IsDecoratedWithAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type)
  * [IsDecoratedWithAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member)
  * [IsDecoratedWithAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type)
  * [TryGetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member)
  * [TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type)
  * [TryGetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member)
  * [TryGetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type)
* [CacheStorage_Benchmark](#CacheStorage_Benchmark)
  * [Clear_Cache](#CacheStorage_Benchmark_Clear_Cache)
  * [GetFromCacheOrFetch](#CacheStorage_Benchmark_GetFromCacheOrFetch)
  * [GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy](#CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy)
  * [GetValue_From_An_Already_Initialized_Cache](#CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache)
  * [Overwrite_An_Existing_Cached_Value](#CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value)
  * [RemoveItem_From_Cache](#CacheStorage_Benchmark_RemoveItem_From_Cache)
* [Enum_Benchmark](#Enum_Benchmark)
  * [ConvertFromOtherEnumValue](#Enum_Benchmark_ConvertFromOtherEnumValue)
  * [GetName](#Enum_Benchmark_GetName)
  * [GetName_Long](#Enum_Benchmark_GetName_Long)
  * [GetNames](#Enum_Benchmark_GetNames)
  * [GetValues](#Enum_Benchmark_GetValues)
  * [Parse](#Enum_Benchmark_Parse)
  * [ToList](#Enum_Benchmark_ToList)
  * [TryParse](#Enum_Benchmark_TryParse)
  * [TryParse_IgnoreCase](#Enum_Benchmark_TryParse_IgnoreCase)
  * [TryParse_IgnoreCase_Nullable](#Enum_Benchmark_TryParse_IgnoreCase_Nullable)
  * [TryParse_Nullable](#Enum_Benchmark_TryParse_Nullable)
* [FastDateTime_vs_DateTime_Benchmark](#FastDateTime_vs_DateTime_Benchmark)
  * [DateTime_Now](#FastDateTime_vs_DateTime_Benchmark_DateTime_Now)
  * [FastDateTime_Now](#FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now)
* [FastDateTime_vs_DateTime_UtcNow_Benchmark](#FastDateTime_vs_DateTime_UtcNow_Benchmark)
  * [DateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow)
  * [FastDateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow)
* [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark)
  * [FastBindingList_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert)
  * [FastBindingList_BashRemove](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove)
  * [FastObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert)
  * [ObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert)
* [Log_Disabled_Benchmark](#Log_Disabled_Benchmark)
  * [Log_Info](#Log_Disabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [Log_Enabled_Benchmark](#Log_Enabled_Benchmark)
  * [Log_Info](#Log_Enabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [MemberInfoExtensions_Benchmark](#MemberInfoExtensions_Benchmark)
  * [GetSignature_Constructor](#MemberInfoExtensions_Benchmark_GetSignature_Constructor)
  * [GetSignature_Method](#MemberInfoExtensions_Benchmark_GetSignature_Method)
* [MethodInfo_ReflectionExtensions_Benchmark](#MethodInfo_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType)
  * [GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd)
  * [GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
* [ModelBase_Constructor_Benchmark](#ModelBase_Constructor_Benchmark)
  * [Constructor](#ModelBase_Constructor_Benchmark_Constructor)
* [ModelBase_EqualityComparer_Benchmark](#ModelBase_EqualityComparer_Benchmark)
  * [EqualityComparer](#ModelBase_EqualityComparer_Benchmark_EqualityComparer)
  * [GetHashCode_](#ModelBase_EqualityComparer_Benchmark_GetHashCode_)
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
* [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_AttributeType](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType)
  * [GetCustomAttributesEx_AttributeType__Inheritd](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd)
  * [GetCustomAttributesEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
* [ScopeManager_Benchmark](#ScopeManager_Benchmark)
  * [Get_Existing_ScopeManager](#ScopeManager_Benchmark_Get_Existing_ScopeManager)
  * [Get_New_ScopeManager](#ScopeManager_Benchmark_Get_New_ScopeManager)
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
* [ServiceLocator_Benchmark](#ServiceLocator_Benchmark)
  * [RegisterType](#ServiceLocator_Benchmark_RegisterType)
  * [ResolveType_Singleton](#ServiceLocator_Benchmark_ResolveType_Singleton)
  * [ResolveType_Transient](#ServiceLocator_Benchmark_ResolveType_Transient)
  * [ResolveType_With_Singleton_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency)
  * [ResolveType_With_Transient_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency)
* [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark)
  * [ContainsGenericParametersEx](#Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx)
  * [GetAssemblyEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyEx)
  * [GetAssemblyFullNameEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx)
  * [GetBaseTypeEx](#Type_ReflectionExtensions_Benchmark_GetBaseTypeEx)
  * [GetConstructorEx](#Type_ReflectionExtensions_Benchmark_GetConstructorEx)
  * [GetConstructorsEx](#Type_ReflectionExtensions_Benchmark_GetConstructorsEx)
  * [GetCustomAttributeEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
  * [GetElementTypeEx](#Type_ReflectionExtensions_Benchmark_GetElementTypeEx)
  * [GetEventEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static)
  * [GetEventEx_Instance](#Type_ReflectionExtensions_Benchmark_GetEventEx_Instance)
  * [GetEventEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags)
  * [GetEventsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static)
  * [GetEventsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance)
  * [GetFieldEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static)
  * [GetFieldEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags)
  * [GetFieldEx_Instance](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance)
  * [GetFieldEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags)
  * [GetFieldsEx](#Type_ReflectionExtensions_Benchmark_GetFieldsEx)
  * [GetFieldsEx_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags)
  * [GetFieldsEx_Static](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static)
  * [GetFieldsEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags)
  * [GetGenericArgumentsEx](#Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx)
  * [GetGenericTypeDefinitionEx](#Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx)
  * [GetInterfacesEx](#Type_ReflectionExtensions_Benchmark_GetInterfacesEx)
  * [GetMemberEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static)
  * [GetMemberEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags)
  * [GetMemberEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance)
  * [GetMemberEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags)
  * [GetMethodEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static)
  * [GetMethodEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags)
  * [GetMethodEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance)
  * [GetMethodEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags)
  * [GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static)
  * [GetMethodsEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags)
  * [GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance)
  * [GetMethodsEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags)
  * [GetParentTypes](#Type_ReflectionExtensions_Benchmark_GetParentTypes)
  * [GetPropertiesEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static)
  * [GetPropertiesEx_Instance](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance)
  * [GetPropertiesEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags)
  * [GetPropertyEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static)
  * [GetPropertyEx_Instance](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance)
  * [GetPropertyEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags)
  * [GetSafeFullName](#Type_ReflectionExtensions_Benchmark_GetSafeFullName)
  * [GetTypeInfo](#Type_ReflectionExtensions_Benchmark_GetTypeInfo)
  * [HasBaseTypeEx](#Type_ReflectionExtensions_Benchmark_HasBaseTypeEx)
  * [ImplementsInterfaceEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx)
  * [ImplementsInterfacesEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx)
  * [IsAbstractEx](#Type_ReflectionExtensions_Benchmark_IsAbstractEx)
  * [IsArrayEx](#Type_ReflectionExtensions_Benchmark_IsArrayEx)
  * [IsAssignableFromEx](#Type_ReflectionExtensions_Benchmark_IsAssignableFromEx)
  * [IsCatelType](#Type_ReflectionExtensions_Benchmark_IsCatelType)
  * [IsClassEx](#Type_ReflectionExtensions_Benchmark_IsClassEx)
  * [IsCOMObjectEx](#Type_ReflectionExtensions_Benchmark_IsCOMObjectEx)
  * [IsEnumEx](#Type_ReflectionExtensions_Benchmark_IsEnumEx)
  * [IsGenericTypeDefinitionEx](#Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx)
  * [IsGenericTypeEx](#Type_ReflectionExtensions_Benchmark_IsGenericTypeEx)
  * [IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx)
  * [IsInterfaceEx](#Type_ReflectionExtensions_Benchmark_IsInterfaceEx)
  * [IsNestedPublicEx](#Type_ReflectionExtensions_Benchmark_IsNestedPublicEx)
  * [IsPrimitiveEx](#Type_ReflectionExtensions_Benchmark_IsPrimitiveEx)
  * [IsPublicEx](#Type_ReflectionExtensions_Benchmark_IsPublicEx)
  * [IsSerializableEx](#Type_ReflectionExtensions_Benchmark_IsSerializableEx)
  * [IsValueTypeEx](#Type_ReflectionExtensions_Benchmark_IsValueTypeEx)
* [TypeExtensions_Benchmark](#TypeExtensions_Benchmark)
  * [GetCollectionElementType](#TypeExtensions_Benchmark_GetCollectionElementType)
  * [IsBasicType](#TypeExtensions_Benchmark_IsBasicType)
  * [IsClassType](#TypeExtensions_Benchmark_IsClassType)
  * [IsCollection](#TypeExtensions_Benchmark_IsCollection)
  * [IsDictionary](#TypeExtensions_Benchmark_IsDictionary)
  * [IsModelBase](#TypeExtensions_Benchmark_IsModelBase)
  * [IsNullableType](#TypeExtensions_Benchmark_IsNullableType)
* [TypeFactory_Benchmark](#TypeFactory_Benchmark)
  * [CreateInstance](#TypeFactory_Benchmark_CreateInstance)
  * [CreateInstance_PropertyInjection](#TypeFactory_Benchmark_CreateInstance_PropertyInjection)
  * [CreateInstanceWithParameters](#TypeFactory_Benchmark_CreateInstanceWithParameters)
  * [CreateInstanceWithParametersAndAutoCompletion](#TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion)
* [ViewModelBase_Benchmark](#ViewModelBase_Benchmark)
  * [Construction](#ViewModelBase_Benchmark_Construction)
* [WeakEventListener_Benchmark](#WeakEventListener_Benchmark)
  * [CollectionChanged_Notification](#WeakEventListener_Benchmark_CollectionChanged_Notification)
  * [GenericEvent_Notification](#WeakEventListener_Benchmark_GenericEvent_Notification)
  * [PropertyChanged_Notification](#WeakEventListener_Benchmark_PropertyChanged_Notification)
  * [SubscribeToWeakGenericEvent](#WeakEventListener_Benchmark_SubscribeToWeakGenericEvent)
  * [SubscribeToWeakPropertyChangedEvent](#WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent)

## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 6,466 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">113,778 ns</td><td align="right" bgcolor="#FFFFFF">111,092 ns (Δ = -2,686 ns)</td><td align="right" bgcolor="#FF4949">114,559 ns (Δ = +3,468 ns)</td><td align="right" bgcolor="#FFFFFF">112,800 ns (Δ = -1,759 ns)</td><td align="right" bgcolor="#A8D08D">108,093 ns (Δ = -4,707 ns)</td><td align="right" bgcolor="#FFFFFF">109,518 ns (Δ = +1,424 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,115 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,113 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,108 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,110 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 39,230 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#FF4949">+17,7 %</td><td align="right" bgcolor="#A8D08D">-21,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">145,653 ns</td><td align="right" bgcolor="#A8D08D">114,549 ns (Δ = -31,104 ns)</td><td align="right" bgcolor="#FF4949">121,768 ns (Δ = +7,220 ns)</td><td align="right" bgcolor="#A8D08D">114,722 ns (Δ = -7,046 ns)</td><td align="right" bgcolor="#FF4949">135,063 ns (Δ = +20,341 ns)</td><td align="right" bgcolor="#A8D08D">106,423 ns (Δ = -28,640 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#A8D08D">0,115 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FF4949">0,122 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,115 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,135 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,106 μs (Δ = -0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 48,647 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td><td align="right" bgcolor="#FF4949">+19,7 %</td><td align="right" bgcolor="#A8D08D">-30,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">110,182 ns</td><td align="right" bgcolor="#FFFFFF">107,087 ns (Δ = -3,095 ns)</td><td align="right" bgcolor="#FF4949">112,833 ns (Δ = +5,747 ns)</td><td align="right" bgcolor="#FF4949">130,087 ns (Δ = +17,253 ns)</td><td align="right" bgcolor="#FF4949">155,733 ns (Δ = +25,647 ns)</td><td align="right" bgcolor="#A8D08D">108,736 ns (Δ = -46,998 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,113 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,130 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FF4949">0,156 μs (Δ = +0,026 μs)</td><td align="right" bgcolor="#A8D08D">0,109 μs (Δ = -0,047 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 34,759 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#A8D08D">-21,1 %</td><td align="right" bgcolor="#FF4949">+35,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">113,804 ns</td><td align="right" bgcolor="#FFFFFF">114,886 ns (Δ = +1,082 ns)</td><td align="right" bgcolor="#FFFFFF">116,184 ns (Δ = +1,298 ns)</td><td align="right" bgcolor="#FF4949">125,034 ns (Δ = +8,849 ns)</td><td align="right" bgcolor="#A8D08D">98,664 ns (Δ = -26,369 ns)</td><td align="right" bgcolor="#FF4949">133,423 ns (Δ = +34,759 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,116 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,125 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,099 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FF4949">0,133 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 2,275 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,982 ns</td><td align="right" bgcolor="#FFFFFF">39,033 ns (Δ = -0,949 ns)</td><td align="right" bgcolor="#FF4949">40,576 ns (Δ = +1,542 ns)</td><td align="right" bgcolor="#A8D08D">39,256 ns (Δ = -1,320 ns)</td><td align="right" bgcolor="#FFFFFF">38,301 ns (Δ = -0,955 ns)</td><td align="right" bgcolor="#FFFFFF">38,931 ns (Δ = +0,630 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,038 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,039 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 35,070 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FF4949">+52,8 %</td><td align="right" bgcolor="#FF4949">+8,4 %</td><td align="right" bgcolor="#A8D08D">-41,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,683 ns</td><td align="right" bgcolor="#FFFFFF">44,920 ns (Δ = +1,237 ns)</td><td align="right" bgcolor="#FF4949">47,542 ns (Δ = +2,622 ns)</td><td align="right" bgcolor="#FF4949">72,660 ns (Δ = +25,118 ns)</td><td align="right" bgcolor="#FF4949">78,753 ns (Δ = +6,093 ns)</td><td align="right" bgcolor="#A8D08D">46,440 ns (Δ = -32,313 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,048 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,073 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FF4949">0,079 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,046 μs (Δ = -0,032 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 3,493 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#A8D08D">-7,6 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">45,622 ns</td><td align="right" bgcolor="#FFFFFF">45,120 ns (Δ = -0,502 ns)</td><td align="right" bgcolor="#FFFFFF">44,901 ns (Δ = -0,219 ns)</td><td align="right" bgcolor="#FFFFFF">46,099 ns (Δ = +1,199 ns)</td><td align="right" bgcolor="#A8D08D">42,607 ns (Δ = -3,493 ns)</td><td align="right" bgcolor="#FF4949">44,630 ns (Δ = +2,023 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,045 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,043 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,045 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 494,874 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FF4949">+65,6 %</td><td align="right" bgcolor="#A8D08D">-36,9 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">737,537 ns</td><td align="right" bgcolor="#A8D08D">690,596 ns (Δ = -46,941 ns)</td><td align="right" bgcolor="#FF4949">715,735 ns (Δ = +25,139 ns)</td><td align="right" bgcolor="#FF4949">1185,470 ns (Δ = +469,735 ns)</td><td align="right" bgcolor="#A8D08D">747,642 ns (Δ = -437,828 ns)</td><td align="right" bgcolor="#FFFFFF">735,250 ns (Δ = -12,392 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#A8D08D">0,691 μs (Δ = -0,047 μs)</td><td align="right" bgcolor="#FF4949">0,716 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FF4949">1,185 μs (Δ = +0,470 μs)</td><td align="right" bgcolor="#A8D08D">0,748 μs (Δ = -0,438 μs)</td><td align="right" bgcolor="#FFFFFF">0,735 μs (Δ = -0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 9,078 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,5 %</td><td align="right" bgcolor="#FF4949">+12,3 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FF4949">+38,0 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,553 ns</td><td align="right" bgcolor="#A8D08D">15,162 ns (Δ = -4,391 ns)</td><td align="right" bgcolor="#FF4949">17,023 ns (Δ = +1,861 ns)</td><td align="right" bgcolor="#FF4949">17,560 ns (Δ = +0,537 ns)</td><td align="right" bgcolor="#FF4949">24,240 ns (Δ = +6,680 ns)</td><td align="right" bgcolor="#A8D08D">15,910 ns (Δ = -8,330 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,017 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,024 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 3,684 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#A8D08D">-14,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,897 ns</td><td align="right" bgcolor="#A8D08D">18,337 ns (Δ = -0,560 ns)</td><td align="right" bgcolor="#FFFFFF">17,831 ns (Δ = -0,506 ns)</td><td align="right" bgcolor="#FF4949">19,433 ns (Δ = +1,602 ns)</td><td align="right" bgcolor="#A8D08D">18,387 ns (Δ = -1,047 ns)</td><td align="right" bgcolor="#A8D08D">15,749 ns (Δ = -2,638 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,018 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **4.5.0**

Slowest: 4.3.0

Δ: 2,561 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,9 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FF4949">+25,5 %</td><td align="right" bgcolor="#A8D08D">-5,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,832 ns</td><td align="right" bgcolor="#FF4949">8,684 ns (Δ = +0,853 ns)</td><td align="right" bgcolor="#A8D08D">8,067 ns (Δ = -0,618 ns)</td><td align="right" bgcolor="#A8D08D">6,123 ns (Δ = -1,943 ns)</td><td align="right" bgcolor="#FF4949">7,683 ns (Δ = +1,560 ns)</td><td align="right" bgcolor="#A8D08D">7,263 ns (Δ = -0,420 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,006 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 41,753 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">543,018 ns</td><td align="right" bgcolor="#FFFFFF">554,204 ns (Δ = +11,187 ns)</td><td align="right" bgcolor="#A8D08D">528,633 ns (Δ = -25,571 ns)</td><td align="right" bgcolor="#FFFFFF">518,780 ns (Δ = -9,853 ns)</td><td align="right" bgcolor="#FF4949">553,300 ns (Δ = +34,520 ns)</td><td align="right" bgcolor="#FFFFFF">560,533 ns (Δ = +7,233 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,529 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">0,519 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,553 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FFFFFF">0,561 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 0,478 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,7 %</td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+33,2 %</td><td align="right" bgcolor="#A8D08D">-24,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,370 ns</td><td align="right" bgcolor="#A8D08D">1,156 ns (Δ = -0,214 ns)</td><td align="right" bgcolor="#FF4949">1,213 ns (Δ = +0,058 ns)</td><td align="right" bgcolor="#FFFFFF">1,227 ns (Δ = +0,013 ns)</td><td align="right" bgcolor="#FF4949">1,633 ns (Δ = +0,407 ns)</td><td align="right" bgcolor="#A8D08D">1,237 ns (Δ = -0,397 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,001 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 0,793 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,1 %</td><td align="right" bgcolor="#A8D08D">-14,0 %</td><td align="right" bgcolor="#FF4949">+10,5 %</td><td align="right" bgcolor="#A8D08D">-43,4 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,478 ns</td><td align="right" bgcolor="#FF4949">1,717 ns (Δ = +0,238 ns)</td><td align="right" bgcolor="#A8D08D">1,477 ns (Δ = -0,240 ns)</td><td align="right" bgcolor="#FF4949">1,632 ns (Δ = +0,155 ns)</td><td align="right" bgcolor="#A8D08D">0,924 ns (Δ = -0,708 ns)</td><td align="right" bgcolor="#FFFFFF">0,925 ns (Δ = +0,001 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,001 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 4,589 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,9 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+39,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,753 ns</td><td align="right" bgcolor="#FF4949">10,149 ns (Δ = +2,396 ns)</td><td align="right" bgcolor="#A8D08D">9,753 ns (Δ = -0,396 ns)</td><td align="right" bgcolor="#A8D08D">9,320 ns (Δ = -0,433 ns)</td><td align="right" bgcolor="#A8D08D">8,863 ns (Δ = -0,457 ns)</td><td align="right" bgcolor="#FF4949">12,341 ns (Δ = +3,478 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,012 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 0,879 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#A8D08D">-10,8 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FF4949">+12,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,869 ns</td><td align="right" bgcolor="#FF4949">4,036 ns (Δ = +0,167 ns)</td><td align="right" bgcolor="#A8D08D">3,600 ns (Δ = -0,436 ns)</td><td align="right" bgcolor="#FF4949">3,760 ns (Δ = +0,160 ns)</td><td align="right" bgcolor="#A8D08D">3,157 ns (Δ = -0,603 ns)</td><td align="right" bgcolor="#FF4949">3,543 ns (Δ = +0,387 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,004 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,003 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 0,675 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,040 ns</td><td align="right" bgcolor="#FFFFFF">14,798 ns (Δ = -0,242 ns)</td><td align="right" bgcolor="#FFFFFF">15,003 ns (Δ = +0,205 ns)</td><td align="right" bgcolor="#FFFFFF">15,391 ns (Δ = +0,388 ns)</td><td align="right" bgcolor="#A8D08D">14,793 ns (Δ = -0,598 ns)</td><td align="right" bgcolor="#FFFFFF">14,716 ns (Δ = -0,078 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 46,624 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,0 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FF4949">+45,4 %</td><td align="right" bgcolor="#A8D08D">-31,8 %</td><td align="right" bgcolor="#FF4949">+10,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,733 ns</td><td align="right" bgcolor="#A8D08D">83,018 ns (Δ = -42,716 ns)</td><td align="right" bgcolor="#A8D08D">79,780 ns (Δ = -3,238 ns)</td><td align="right" bgcolor="#FF4949">115,973 ns (Δ = +36,193 ns)</td><td align="right" bgcolor="#A8D08D">79,109 ns (Δ = -36,864 ns)</td><td align="right" bgcolor="#FF4949">87,391 ns (Δ = +8,282 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#A8D08D">0,083 μs (Δ = -0,043 μs)</td><td align="right" bgcolor="#A8D08D">0,080 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,116 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#A8D08D">0,079 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FF4949">0,087 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 49,205 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+57,8 %</td><td align="right" bgcolor="#A8D08D">-35,6 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+12,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,165 ns</td><td align="right" bgcolor="#FF4949">134,370 ns (Δ = +49,205 ns)</td><td align="right" bgcolor="#A8D08D">86,577 ns (Δ = -47,793 ns)</td><td align="right" bgcolor="#FFFFFF">88,943 ns (Δ = +2,367 ns)</td><td align="right" bgcolor="#FFFFFF">89,550 ns (Δ = +0,607 ns)</td><td align="right" bgcolor="#FF4949">100,335 ns (Δ = +10,785 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FF4949">0,134 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">0,087 μs (Δ = -0,048 μs)</td><td align="right" bgcolor="#FFFFFF">0,089 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,090 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,100 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 8,860 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#FF4949">+8,1 %</td><td align="right" bgcolor="#A8D08D">-11,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">55,953 ns</td><td align="right" bgcolor="#FF4949">59,570 ns (Δ = +3,617 ns)</td><td align="right" bgcolor="#A8D08D">57,178 ns (Δ = -2,393 ns)</td><td align="right" bgcolor="#FF4949">59,960 ns (Δ = +2,783 ns)</td><td align="right" bgcolor="#FF4949">64,813 ns (Δ = +4,853 ns)</td><td align="right" bgcolor="#A8D08D">57,175 ns (Δ = -7,638 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FF4949">0,060 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,057 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,060 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,065 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,057 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 31,183 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,3 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,083 ns</td><td align="right" bgcolor="#A8D08D">65,369 ns (Δ = -29,714 ns)</td><td align="right" bgcolor="#FFFFFF">63,901 ns (Δ = -1,468 ns)</td><td align="right" bgcolor="#FFFFFF">64,856 ns (Δ = +0,955 ns)</td><td align="right" bgcolor="#FFFFFF">64,263 ns (Δ = -0,593 ns)</td><td align="right" bgcolor="#FFFFFF">65,554 ns (Δ = +1,290 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#A8D08D">0,065 μs (Δ = -0,030 μs)</td><td align="right" bgcolor="#FFFFFF">0,064 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,065 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,064 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,066 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 15,728 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+43,3 %</td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FF4949">+14,1 %</td><td align="right" bgcolor="#A8D08D">-14,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,700 ns</td><td align="right" bgcolor="#FF4949">39,703 ns (Δ = +12,003 ns)</td><td align="right" bgcolor="#A8D08D">28,323 ns (Δ = -11,380 ns)</td><td align="right" bgcolor="#A8D08D">24,450 ns (Δ = -3,873 ns)</td><td align="right" bgcolor="#FF4949">27,896 ns (Δ = +3,446 ns)</td><td align="right" bgcolor="#A8D08D">23,976 ns (Δ = -3,920 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FF4949">0,040 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,028 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,028 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3,881 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58,227 ns</td><td align="right" bgcolor="#FF4949">60,851 ns (Δ = +2,624 ns)</td><td align="right" bgcolor="#A8D08D">58,025 ns (Δ = -2,826 ns)</td><td align="right" bgcolor="#FFFFFF">59,367 ns (Δ = +1,342 ns)</td><td align="right" bgcolor="#A8D08D">57,546 ns (Δ = -1,821 ns)</td><td align="right" bgcolor="#FF4949">61,427 ns (Δ = +3,881 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FF4949">0,061 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,058 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,059 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,058 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,061 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 35,207 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,2 %</td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+54,6 %</td><td align="right" bgcolor="#A8D08D">-35,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,680 ns</td><td align="right" bgcolor="#FF4949">85,990 ns (Δ = +23,310 ns)</td><td align="right" bgcolor="#A8D08D">64,315 ns (Δ = -21,675 ns)</td><td align="right" bgcolor="#FFFFFF">63,327 ns (Δ = -0,988 ns)</td><td align="right" bgcolor="#FF4949">97,887 ns (Δ = +34,560 ns)</td><td align="right" bgcolor="#A8D08D">63,064 ns (Δ = -34,822 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FF4949">0,086 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,064 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FFFFFF">0,063 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,098 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#A8D08D">0,063 μs (Δ = -0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 31,543 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,1 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+71,9 %</td><td align="right" bgcolor="#A8D08D">-41,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,198 ns</td><td align="right" bgcolor="#FF4949">50,705 ns (Δ = +10,507 ns)</td><td align="right" bgcolor="#A8D08D">41,207 ns (Δ = -9,498 ns)</td><td align="right" bgcolor="#FFFFFF">41,727 ns (Δ = +0,520 ns)</td><td align="right" bgcolor="#FF4949">71,741 ns (Δ = +30,014 ns)</td><td align="right" bgcolor="#A8D08D">41,842 ns (Δ = -29,899 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FF4949">0,051 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,072 μs (Δ = +0,030 μs)</td><td align="right" bgcolor="#A8D08D">0,042 μs (Δ = -0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 30,883 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,7 %</td><td align="right" bgcolor="#FF4949">+18,5 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-25,3 %</td><td align="right" bgcolor="#FF4949">+10,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,920 ns</td><td align="right" bgcolor="#A8D08D">48,787 ns (Δ = -27,133 ns)</td><td align="right" bgcolor="#FF4949">57,827 ns (Δ = +9,040 ns)</td><td align="right" bgcolor="#FF4949">60,283 ns (Δ = +2,457 ns)</td><td align="right" bgcolor="#A8D08D">45,037 ns (Δ = -15,247 ns)</td><td align="right" bgcolor="#FF4949">49,638 ns (Δ = +4,601 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#A8D08D">0,049 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,058 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#FF4949">0,060 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,045 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">0,050 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 379,165 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7680,250 ns</td><td align="right" bgcolor="#FFFFFF">7794,370 ns (Δ = +114,120 ns)</td><td align="right" bgcolor="#FFFFFF">7714,362 ns (Δ = -80,008 ns)</td><td align="right" bgcolor="#FF4949">8051,482 ns (Δ = +337,120 ns)</td><td align="right" bgcolor="#A8D08D">7744,896 ns (Δ = -306,586 ns)</td><td align="right" bgcolor="#FFFFFF">7672,317 ns (Δ = -72,579 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,680 μs</td><td align="right" bgcolor="#FFFFFF">7,794 μs (Δ = +0,114 μs)</td><td align="right" bgcolor="#FFFFFF">7,714 μs (Δ = -0,080 μs)</td><td align="right" bgcolor="#FF4949">8,051 μs (Δ = +0,337 μs)</td><td align="right" bgcolor="#A8D08D">7,745 μs (Δ = -0,307 μs)</td><td align="right" bgcolor="#FFFFFF">7,672 μs (Δ = -0,073 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 209,250 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7703,943 ns</td><td align="right" bgcolor="#FFFFFF">7701,787 ns (Δ = -2,156 ns)</td><td align="right" bgcolor="#FFFFFF">7575,103 ns (Δ = -126,683 ns)</td><td align="right" bgcolor="#FFFFFF">7784,353 ns (Δ = +209,250 ns)</td><td align="right" bgcolor="#FFFFFF">7683,802 ns (Δ = -100,552 ns)</td><td align="right" bgcolor="#FFFFFF">7715,063 ns (Δ = +31,262 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,704 μs</td><td align="right" bgcolor="#FFFFFF">7,702 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">7,575 μs (Δ = -0,127 μs)</td><td align="right" bgcolor="#FFFFFF">7,784 μs (Δ = +0,209 μs)</td><td align="right" bgcolor="#FFFFFF">7,684 μs (Δ = -0,101 μs)</td><td align="right" bgcolor="#FFFFFF">7,715 μs (Δ = +0,031 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 1985,124 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FF4949">+12,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13703,873 ns</td><td align="right" bgcolor="#FFFFFF">13921,111 ns (Δ = +217,238 ns)</td><td align="right" bgcolor="#FF4949">15688,998 ns (Δ = +1767,887 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,704 μs</td><td align="right" bgcolor="#FFFFFF">13,921 μs (Δ = +0,217 μs)</td><td align="right" bgcolor="#FF4949">15,689 μs (Δ = +1,768 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,016 ms (Δ = +0,002 ms)</td></tr>
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
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1212</td><td align="right">1229</td><td align="right">1229</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,184</td><td align="right">1,200</td><td align="right">1,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 123,697 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5572,933 ns</td><td align="right" bgcolor="#FFFFFF">5508,817 ns (Δ = -64,117 ns)</td><td align="right" bgcolor="#FFFFFF">5596,247 ns (Δ = +87,430 ns)</td><td align="right" bgcolor="#FFFFFF">5472,550 ns (Δ = -123,697 ns)</td><td align="right" bgcolor="#FFFFFF">5483,837 ns (Δ = +11,287 ns)</td><td align="right" bgcolor="#FFFFFF">5495,044 ns (Δ = +11,208 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,573 μs</td><td align="right" bgcolor="#FFFFFF">5,509 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#FFFFFF">5,596 μs (Δ = +0,087 μs)</td><td align="right" bgcolor="#FFFFFF">5,473 μs (Δ = -0,124 μs)</td><td align="right" bgcolor="#FFFFFF">5,484 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#FFFFFF">5,495 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">2662</td><td align="right">2662</td><td align="right">2662</td><td align="right">2662</td><td align="right">2695</td><td align="right">2695</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,600</td><td align="right">2,600</td><td align="right">2,600</td><td align="right">2,600</td><td align="right">2,632</td><td align="right">2,632</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td></tr>
</table>


## <a name="AssemblyExtensions__Benchmark"></a>AssemblyExtensions__Benchmark

### <a name="AssemblyExtensions__Benchmark_Company"></a>Company

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9558,343 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,558 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">832</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,813</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9830,104 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,830 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">880</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,859</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Description"></a>Description

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9359,122 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,359 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">881935,341 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">881,935 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,882 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.2.0</td>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">50</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">35328</td><tr>
<td>Allocated Kilobytes</td><td align="right">34,500</td><tr>
<td>Allocated Megabytes</td><td align="right">0,034</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2783,894 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,784 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">410</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7630,665 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,631 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">70</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">768</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,750</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Product"></a>Product

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9817,318 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,817 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Title"></a>Title

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10362,241 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,362 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Version"></a>Version

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">969,730 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1020</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1232</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,203</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 553,691 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9931,073 ns</td><td align="right" bgcolor="#FFFFFF">10192,577 ns (Δ = +261,503 ns)</td><td align="right" bgcolor="#FFFFFF">10310,631 ns (Δ = +118,054 ns)</td><td align="right" bgcolor="#FFFFFF">10027,760 ns (Δ = -282,871 ns)</td><td align="right" bgcolor="#FFFFFF">9756,940 ns (Δ = -270,820 ns)</td><td align="right" bgcolor="#FFFFFF">9788,489 ns (Δ = +31,549 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,931 μs</td><td align="right" bgcolor="#FFFFFF">10,193 μs (Δ = +0,262 μs)</td><td align="right" bgcolor="#FFFFFF">10,311 μs (Δ = +0,118 μs)</td><td align="right" bgcolor="#FFFFFF">10,028 μs (Δ = -0,283 μs)</td><td align="right" bgcolor="#FFFFFF">9,757 μs (Δ = -0,271 μs)</td><td align="right" bgcolor="#FFFFFF">9,788 μs (Δ = +0,032 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 1656,099 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,0 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11582,869 ns</td><td align="right" bgcolor="#A8D08D">9955,590 ns (Δ = -1627,279 ns)</td><td align="right" bgcolor="#FFFFFF">9926,770 ns (Δ = -28,820 ns)</td><td align="right" bgcolor="#FFFFFF">10040,123 ns (Δ = +113,353 ns)</td><td align="right" bgcolor="#FFFFFF">10112,663 ns (Δ = +72,540 ns)</td><td align="right" bgcolor="#FFFFFF">10174,553 ns (Δ = +61,890 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">11,583 μs</td><td align="right" bgcolor="#A8D08D">9,956 μs (Δ = -1,627 μs)</td><td align="right" bgcolor="#FFFFFF">9,927 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FFFFFF">10,040 μs (Δ = +0,113 μs)</td><td align="right" bgcolor="#FFFFFF">10,113 μs (Δ = +0,073 μs)</td><td align="right" bgcolor="#FFFFFF">10,175 μs (Δ = +0,062 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 205,267 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9842,611 ns</td><td align="right" bgcolor="#FFFFFF">9783,662 ns (Δ = -58,949 ns)</td><td align="right" bgcolor="#FFFFFF">9648,637 ns (Δ = -135,025 ns)</td><td align="right" bgcolor="#FFFFFF">9762,140 ns (Δ = +113,503 ns)</td><td align="right" bgcolor="#FFFFFF">9665,270 ns (Δ = -96,870 ns)</td><td align="right" bgcolor="#FFFFFF">9637,344 ns (Δ = -27,926 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,843 μs</td><td align="right" bgcolor="#FFFFFF">9,784 μs (Δ = -0,059 μs)</td><td align="right" bgcolor="#FFFFFF">9,649 μs (Δ = -0,135 μs)</td><td align="right" bgcolor="#FFFFFF">9,762 μs (Δ = +0,114 μs)</td><td align="right" bgcolor="#FFFFFF">9,665 μs (Δ = -0,097 μs)</td><td align="right" bgcolor="#FFFFFF">9,637 μs (Δ = -0,028 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 431665,398 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-46,1 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">926508,020 ns</td><td align="right" bgcolor="#FFFFFF">934834,683 ns (Δ = +8326,663 ns)</td><td align="right" bgcolor="#FFFFFF">936679,922 ns (Δ = +1845,239 ns)</td><td align="right" bgcolor="#A8D08D">505014,524 ns (Δ = -431665,398 ns)</td><td align="right" bgcolor="#FFFFFF">509127,080 ns (Δ = +4112,556 ns)</td><td align="right" bgcolor="#FFFFFF">506380,602 ns (Δ = -2746,478 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">926,508 μs</td><td align="right" bgcolor="#FFFFFF">934,835 μs (Δ = +8,327 μs)</td><td align="right" bgcolor="#FFFFFF">936,680 μs (Δ = +1,845 μs)</td><td align="right" bgcolor="#A8D08D">505,015 μs (Δ = -431,665 μs)</td><td align="right" bgcolor="#FFFFFF">509,127 μs (Δ = +4,113 μs)</td><td align="right" bgcolor="#FFFFFF">506,381 μs (Δ = -2,746 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,927 ms</td><td align="right" bgcolor="#FFFFFF">0,935 ms (Δ = +0,008 ms)</td><td align="right" bgcolor="#FFFFFF">0,937 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,505 ms (Δ = -0,432 ms)</td><td align="right" bgcolor="#FFFFFF">0,509 ms (Δ = +0,004 ms)</td><td align="right" bgcolor="#FFFFFF">0,506 ms (Δ = -0,003 ms)</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">50</td><td align="right">50</td><td align="right">50</td><td align="right">20</td><td align="right">20</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">10</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">35330</td><td align="right">35328</td><td align="right">35331</td><td align="right">20370</td><td align="right">20370</td><td align="right">20370</td><tr>
<td>Allocated Kilobytes</td><td align="right">34,502</td><td align="right">34,500</td><td align="right">34,503</td><td align="right">19,893</td><td align="right">19,893</td><td align="right">19,893</td><tr>
<td>Allocated Megabytes</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 57,039 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2917,347 ns</td><td align="right" bgcolor="#FFFFFF">2955,873 ns (Δ = +38,527 ns)</td><td align="right" bgcolor="#FFFFFF">2902,250 ns (Δ = -53,623 ns)</td><td align="right" bgcolor="#FFFFFF">2909,474 ns (Δ = +7,224 ns)</td><td align="right" bgcolor="#FFFFFF">2908,318 ns (Δ = -1,157 ns)</td><td align="right" bgcolor="#FFFFFF">2959,289 ns (Δ = +50,971 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,917 μs</td><td align="right" bgcolor="#FFFFFF">2,956 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#FFFFFF">2,902 μs (Δ = -0,054 μs)</td><td align="right" bgcolor="#FFFFFF">2,909 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">2,908 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">2,959 μs (Δ = +0,051 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 449,197 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+5,3 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7839,321 ns</td><td align="right" bgcolor="#FFFFFF">7869,973 ns (Δ = +30,652 ns)</td><td align="right" bgcolor="#FFFFFF">7827,753 ns (Δ = -42,219 ns)</td><td align="right" bgcolor="#FF4949">8242,050 ns (Δ = +414,297 ns)</td><td align="right" bgcolor="#A8D08D">7960,137 ns (Δ = -281,913 ns)</td><td align="right" bgcolor="#FFFFFF">7792,853 ns (Δ = -167,283 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,839 μs</td><td align="right" bgcolor="#FFFFFF">7,870 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">7,828 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#FF4949">8,242 μs (Δ = +0,414 μs)</td><td align="right" bgcolor="#A8D08D">7,960 μs (Δ = -0,282 μs)</td><td align="right" bgcolor="#FFFFFF">7,793 μs (Δ = -0,167 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 619,342 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9830,364 ns</td><td align="right" bgcolor="#FFFFFF">10128,473 ns (Δ = +298,109 ns)</td><td align="right" bgcolor="#FFFFFF">10345,787 ns (Δ = +217,313 ns)</td><td align="right" bgcolor="#FFFFFF">10449,707 ns (Δ = +103,920 ns)</td><td align="right" bgcolor="#A8D08D">9962,787 ns (Δ = -486,920 ns)</td><td align="right" bgcolor="#FFFFFF">9985,469 ns (Δ = +22,682 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,830 μs</td><td align="right" bgcolor="#FFFFFF">10,128 μs (Δ = +0,298 μs)</td><td align="right" bgcolor="#FFFFFF">10,346 μs (Δ = +0,217 μs)</td><td align="right" bgcolor="#FFFFFF">10,450 μs (Δ = +0,104 μs)</td><td align="right" bgcolor="#A8D08D">9,963 μs (Δ = -0,487 μs)</td><td align="right" bgcolor="#FFFFFF">9,985 μs (Δ = +0,023 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 626,853 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#A8D08D">-6,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9937,320 ns</td><td align="right" bgcolor="#FFFFFF">10007,076 ns (Δ = +69,756 ns)</td><td align="right" bgcolor="#FFFFFF">9928,440 ns (Δ = -78,636 ns)</td><td align="right" bgcolor="#FFFFFF">10000,767 ns (Δ = +72,327 ns)</td><td align="right" bgcolor="#FF4949">10466,713 ns (Δ = +465,947 ns)</td><td align="right" bgcolor="#A8D08D">9839,860 ns (Δ = -626,853 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,937 μs</td><td align="right" bgcolor="#FFFFFF">10,007 μs (Δ = +0,070 μs)</td><td align="right" bgcolor="#FFFFFF">9,928 μs (Δ = -0,079 μs)</td><td align="right" bgcolor="#FFFFFF">10,001 μs (Δ = +0,072 μs)</td><td align="right" bgcolor="#FF4949">10,467 μs (Δ = +0,466 μs)</td><td align="right" bgcolor="#A8D08D">9,840 μs (Δ = -0,627 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 94,587 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1073,527 ns</td><td align="right" bgcolor="#A8D08D">1029,171 ns (Δ = -44,356 ns)</td><td align="right" bgcolor="#FFFFFF">1029,913 ns (Δ = +0,742 ns)</td><td align="right" bgcolor="#FFFFFF">1026,071 ns (Δ = -3,842 ns)</td><td align="right" bgcolor="#A8D08D">985,783 ns (Δ = -40,288 ns)</td><td align="right" bgcolor="#FFFFFF">978,940 ns (Δ = -6,843 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,074 μs</td><td align="right" bgcolor="#A8D08D">1,029 μs (Δ = -0,044 μs)</td><td align="right" bgcolor="#FFFFFF">1,030 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">1,026 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,986 μs (Δ = -0,040 μs)</td><td align="right" bgcolor="#FFFFFF">0,979 μs (Δ = -0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 118,857 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3113,373 ns</td><td align="right" bgcolor="#FFFFFF">3052,920 ns (Δ = -60,453 ns)</td><td align="right" bgcolor="#FFFFFF">2994,517 ns (Δ = -58,403 ns)</td><td align="right" bgcolor="#FFFFFF">3029,867 ns (Δ = +35,350 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,113 μs</td><td align="right" bgcolor="#FFFFFF">3,053 μs (Δ = -0,060 μs)</td><td align="right" bgcolor="#FFFFFF">2,995 μs (Δ = -0,058 μs)</td><td align="right" bgcolor="#FFFFFF">3,030 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 86,988 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3675,460 ns</td><td align="right" bgcolor="#FFFFFF">3669,010 ns (Δ = -6,450 ns)</td><td align="right" bgcolor="#FFFFFF">3708,973 ns (Δ = +39,963 ns)</td><td align="right" bgcolor="#FFFFFF">3755,998 ns (Δ = +47,024 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,675 μs</td><td align="right" bgcolor="#FFFFFF">3,669 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">3,709 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#FFFFFF">3,756 μs (Δ = +0,047 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 136,120 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3238,753 ns</td><td align="right" bgcolor="#A8D08D">3131,872 ns (Δ = -106,882 ns)</td><td align="right" bgcolor="#FFFFFF">3207,053 ns (Δ = +75,182 ns)</td><td align="right" bgcolor="#A8D08D">3102,633 ns (Δ = -104,420 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,239 μs</td><td align="right" bgcolor="#A8D08D">3,132 μs (Δ = -0,107 μs)</td><td align="right" bgcolor="#FFFFFF">3,207 μs (Δ = +0,075 μs)</td><td align="right" bgcolor="#A8D08D">3,103 μs (Δ = -0,104 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 345,141 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#A8D08D">-8,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3813,860 ns</td><td align="right" bgcolor="#FFFFFF">3893,544 ns (Δ = +79,684 ns)</td><td align="right" bgcolor="#FF4949">4092,733 ns (Δ = +199,189 ns)</td><td align="right" bgcolor="#A8D08D">3747,593 ns (Δ = -345,141 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,814 μs</td><td align="right" bgcolor="#FFFFFF">3,894 μs (Δ = +0,080 μs)</td><td align="right" bgcolor="#FF4949">4,093 μs (Δ = +0,199 μs)</td><td align="right" bgcolor="#A8D08D">3,748 μs (Δ = -0,345 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 295,280 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,2 %</td><td align="right" bgcolor="#A8D08D">-8,9 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3037,563 ns</td><td align="right" bgcolor="#FF4949">3315,630 ns (Δ = +278,067 ns)</td><td align="right" bgcolor="#A8D08D">3020,350 ns (Δ = -295,280 ns)</td><td align="right" bgcolor="#FF4949">3139,895 ns (Δ = +119,545 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,038 μs</td><td align="right" bgcolor="#FF4949">3,316 μs (Δ = +0,278 μs)</td><td align="right" bgcolor="#A8D08D">3,020 μs (Δ = -0,295 μs)</td><td align="right" bgcolor="#FF4949">3,140 μs (Δ = +0,120 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 795,401 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,2 %</td><td align="right" bgcolor="#A8D08D">-17,8 %</td><td align="right" bgcolor="#FF4949">+8,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3779,077 ns</td><td align="right" bgcolor="#FF4949">4465,691 ns (Δ = +686,614 ns)</td><td align="right" bgcolor="#A8D08D">3670,290 ns (Δ = -795,401 ns)</td><td align="right" bgcolor="#FF4949">3977,253 ns (Δ = +306,963 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,779 μs</td><td align="right" bgcolor="#FF4949">4,466 μs (Δ = +0,687 μs)</td><td align="right" bgcolor="#A8D08D">3,670 μs (Δ = -0,795 μs)</td><td align="right" bgcolor="#FF4949">3,977 μs (Δ = +0,307 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 260,473 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3090,507 ns</td><td align="right" bgcolor="#FFFFFF">3110,702 ns (Δ = +20,196 ns)</td><td align="right" bgcolor="#FF4949">3318,627 ns (Δ = +207,924 ns)</td><td align="right" bgcolor="#A8D08D">3058,153 ns (Δ = -260,473 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,091 μs</td><td align="right" bgcolor="#FFFFFF">3,111 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#FF4949">3,319 μs (Δ = +0,208 μs)</td><td align="right" bgcolor="#A8D08D">3,058 μs (Δ = -0,260 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 112,593 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3808,443 ns</td><td align="right" bgcolor="#FFFFFF">3780,730 ns (Δ = -27,713 ns)</td><td align="right" bgcolor="#FFFFFF">3695,850 ns (Δ = -84,880 ns)</td><td align="right" bgcolor="#FFFFFF">3782,945 ns (Δ = +87,095 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,808 μs</td><td align="right" bgcolor="#FFFFFF">3,781 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FFFFFF">3,696 μs (Δ = -0,085 μs)</td><td align="right" bgcolor="#FFFFFF">3,783 μs (Δ = +0,087 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 182,896 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3112,203 ns</td><td align="right" bgcolor="#FFFFFF">3111,851 ns (Δ = -0,352 ns)</td><td align="right" bgcolor="#FFFFFF">3194,578 ns (Δ = +82,726 ns)</td><td align="right" bgcolor="#FF4949">3294,747 ns (Δ = +100,169 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,112 μs</td><td align="right" bgcolor="#FFFFFF">3,112 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">3,195 μs (Δ = +0,083 μs)</td><td align="right" bgcolor="#FF4949">3,295 μs (Δ = +0,100 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 265,624 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3756,134 ns</td><td align="right" bgcolor="#FF4949">3989,749 ns (Δ = +233,615 ns)</td><td align="right" bgcolor="#A8D08D">3724,124 ns (Δ = -265,624 ns)</td><td align="right" bgcolor="#FFFFFF">3761,771 ns (Δ = +37,647 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,756 μs</td><td align="right" bgcolor="#FF4949">3,990 μs (Δ = +0,234 μs)</td><td align="right" bgcolor="#A8D08D">3,724 μs (Δ = -0,266 μs)</td><td align="right" bgcolor="#FFFFFF">3,762 μs (Δ = +0,038 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 150,178 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3212,560 ns</td><td align="right" bgcolor="#FFFFFF">3182,097 ns (Δ = -30,463 ns)</td><td align="right" bgcolor="#A8D08D">3062,382 ns (Δ = -119,714 ns)</td><td align="right" bgcolor="#FFFFFF">3150,460 ns (Δ = +88,078 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,213 μs</td><td align="right" bgcolor="#FFFFFF">3,182 μs (Δ = -0,030 μs)</td><td align="right" bgcolor="#A8D08D">3,062 μs (Δ = -0,120 μs)</td><td align="right" bgcolor="#FFFFFF">3,150 μs (Δ = +0,088 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 1591,207 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FF4949">+38,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4904,387 ns</td><td align="right" bgcolor="#A8D08D">3704,517 ns (Δ = -1199,870 ns)</td><td align="right" bgcolor="#FF4949">3819,907 ns (Δ = +115,390 ns)</td><td align="right" bgcolor="#FF4949">5295,723 ns (Δ = +1475,817 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,904 μs</td><td align="right" bgcolor="#A8D08D">3,705 μs (Δ = -1,200 μs)</td><td align="right" bgcolor="#FF4949">3,820 μs (Δ = +0,115 μs)</td><td align="right" bgcolor="#FF4949">5,296 μs (Δ = +1,476 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,001 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 170,646 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,1 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+185,9 %</td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FF4949">+13,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,487 ns</td><td align="right" bgcolor="#A8D08D">90,324 ns (Δ = -10,162 ns)</td><td align="right" bgcolor="#FFFFFF">91,258 ns (Δ = +0,933 ns)</td><td align="right" bgcolor="#FF4949">260,933 ns (Δ = +169,676 ns)</td><td align="right" bgcolor="#A8D08D">230,538 ns (Δ = -30,396 ns)</td><td align="right" bgcolor="#FF4949">260,970 ns (Δ = +30,433 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#A8D08D">0,090 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,091 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,261 μs (Δ = +0,170 μs)</td><td align="right" bgcolor="#A8D08D">0,231 μs (Δ = -0,030 μs)</td><td align="right" bgcolor="#FF4949">0,261 μs (Δ = +0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 155,218 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+123,6 %</td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">131,027 ns</td><td align="right" bgcolor="#FFFFFF">129,428 ns (Δ = -1,598 ns)</td><td align="right" bgcolor="#A8D08D">125,593 ns (Δ = -3,836 ns)</td><td align="right" bgcolor="#FF4949">280,810 ns (Δ = +155,218 ns)</td><td align="right" bgcolor="#A8D08D">243,633 ns (Δ = -37,177 ns)</td><td align="right" bgcolor="#FF4949">258,393 ns (Δ = +14,760 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,126 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,281 μs (Δ = +0,155 μs)</td><td align="right" bgcolor="#A8D08D">0,244 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FF4949">0,258 μs (Δ = +0,015 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">139</td><td align="right">139</td><td align="right">139</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,136</td><td align="right">0,136</td><td align="right">0,136</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 145,622 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+117,1 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">129,095 ns</td><td align="right" bgcolor="#A8D08D">124,484 ns (Δ = -4,611 ns)</td><td align="right" bgcolor="#FFFFFF">124,404 ns (Δ = -0,079 ns)</td><td align="right" bgcolor="#FF4949">270,027 ns (Δ = +145,622 ns)</td><td align="right" bgcolor="#FFFFFF">263,482 ns (Δ = -6,544 ns)</td><td align="right" bgcolor="#FFFFFF">258,563 ns (Δ = -4,919 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#A8D08D">0,124 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,124 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,270 μs (Δ = +0,146 μs)</td><td align="right" bgcolor="#FFFFFF">0,263 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,259 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">139</td><td align="right">139</td><td align="right">139</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,136</td><td align="right">0,136</td><td align="right">0,136</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 139,280 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,4 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#FF4949">+108,8 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,283 ns</td><td align="right" bgcolor="#FF4949">108,730 ns (Δ = +7,447 ns)</td><td align="right" bgcolor="#FF4949">114,910 ns (Δ = +6,180 ns)</td><td align="right" bgcolor="#FF4949">239,987 ns (Δ = +125,077 ns)</td><td align="right" bgcolor="#FFFFFF">240,563 ns (Δ = +0,577 ns)</td><td align="right" bgcolor="#A8D08D">227,654 ns (Δ = -12,909 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FF4949">0,109 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FF4949">0,115 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,240 μs (Δ = +0,125 μs)</td><td align="right" bgcolor="#FFFFFF">0,241 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,228 μs (Δ = -0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">123</td><td align="right">123</td><td align="right">123</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,120</td><td align="right">0,120</td><td align="right">0,120</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 145,532 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,7 %</td><td align="right" bgcolor="#FF4949">+12,8 %</td><td align="right" bgcolor="#FF4949">+119,5 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">140,233 ns</td><td align="right" bgcolor="#A8D08D">98,638 ns (Δ = -41,595 ns)</td><td align="right" bgcolor="#FF4949">111,243 ns (Δ = +12,606 ns)</td><td align="right" bgcolor="#FF4949">244,169 ns (Δ = +132,926 ns)</td><td align="right" bgcolor="#A8D08D">230,007 ns (Δ = -14,163 ns)</td><td align="right" bgcolor="#FF4949">237,662 ns (Δ = +7,656 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#A8D08D">0,099 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#FF4949">0,111 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FF4949">0,244 μs (Δ = +0,133 μs)</td><td align="right" bgcolor="#A8D08D">0,230 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,238 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">123</td><td align="right">123</td><td align="right">123</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,120</td><td align="right">0,120</td><td align="right">0,120</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 159,606 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+162,3 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">89,571 ns</td><td align="right" bgcolor="#FF4949">93,877 ns (Δ = +4,306 ns)</td><td align="right" bgcolor="#FFFFFF">92,952 ns (Δ = -0,925 ns)</td><td align="right" bgcolor="#FF4949">243,802 ns (Δ = +150,850 ns)</td><td align="right" bgcolor="#FFFFFF">249,177 ns (Δ = +5,375 ns)</td><td align="right" bgcolor="#A8D08D">239,331 ns (Δ = -9,846 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FF4949">0,094 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,093 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,244 μs (Δ = +0,151 μs)</td><td align="right" bgcolor="#FFFFFF">0,249 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,239 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 745,270 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#FF4949">+59,6 %</td><td align="right" bgcolor="#A8D08D">-40,5 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1006,130 ns</td><td align="right" bgcolor="#FFFFFF">1033,967 ns (Δ = +27,837 ns)</td><td align="right" bgcolor="#FF4949">1097,257 ns (Δ = +63,290 ns)</td><td align="right" bgcolor="#FF4949">1751,400 ns (Δ = +654,143 ns)</td><td align="right" bgcolor="#A8D08D">1041,816 ns (Δ = -709,584 ns)</td><td align="right" bgcolor="#FFFFFF">1012,277 ns (Δ = -29,539 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,006 μs</td><td align="right" bgcolor="#FFFFFF">1,034 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FF4949">1,097 μs (Δ = +0,063 μs)</td><td align="right" bgcolor="#FF4949">1,751 μs (Δ = +0,654 μs)</td><td align="right" bgcolor="#A8D08D">1,042 μs (Δ = -0,710 μs)</td><td align="right" bgcolor="#FFFFFF">1,012 μs (Δ = -0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 92,035 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+50,6 %</td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#FF4949">+20,8 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">149,038 ns</td><td align="right" bgcolor="#FF4949">224,495 ns (Δ = +75,457 ns)</td><td align="right" bgcolor="#A8D08D">173,487 ns (Δ = -51,008 ns)</td><td align="right" bgcolor="#FF4949">209,533 ns (Δ = +36,047 ns)</td><td align="right" bgcolor="#A8D08D">137,552 ns (Δ = -71,981 ns)</td><td align="right" bgcolor="#A8D08D">132,460 ns (Δ = -5,092 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FF4949">0,224 μs (Δ = +0,075 μs)</td><td align="right" bgcolor="#A8D08D">0,173 μs (Δ = -0,051 μs)</td><td align="right" bgcolor="#FF4949">0,210 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#A8D08D">0,138 μs (Δ = -0,072 μs)</td><td align="right" bgcolor="#A8D08D">0,132 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 23,491 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-13,9 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,458 ns</td><td align="right" bgcolor="#FFFFFF">160,874 ns (Δ = -2,584 ns)</td><td align="right" bgcolor="#FFFFFF">159,538 ns (Δ = -1,336 ns)</td><td align="right" bgcolor="#FF4949">169,567 ns (Δ = +10,029 ns)</td><td align="right" bgcolor="#A8D08D">146,076 ns (Δ = -23,491 ns)</td><td align="right" bgcolor="#FFFFFF">146,900 ns (Δ = +0,824 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,161 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,160 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,170 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,146 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,147 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">30</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,029</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 109,450 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2093,650 ns</td><td align="right" bgcolor="#A8D08D">2020,796 ns (Δ = -72,854 ns)</td><td align="right" bgcolor="#FFFFFF">2048,110 ns (Δ = +27,314 ns)</td><td align="right" bgcolor="#FFFFFF">2039,093 ns (Δ = -9,017 ns)</td><td align="right" bgcolor="#FFFFFF">1987,923 ns (Δ = -51,170 ns)</td><td align="right" bgcolor="#FFFFFF">1984,200 ns (Δ = -3,723 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,094 μs</td><td align="right" bgcolor="#A8D08D">2,021 μs (Δ = -0,073 μs)</td><td align="right" bgcolor="#FFFFFF">2,048 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#FFFFFF">2,039 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">1,988 μs (Δ = -0,051 μs)</td><td align="right" bgcolor="#FFFFFF">1,984 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1112,957 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FF4949">+26,3 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3925,178 ns</td><td align="right" bgcolor="#FFFFFF">3956,607 ns (Δ = +31,429 ns)</td><td align="right" bgcolor="#FFFFFF">3942,022 ns (Δ = -14,584 ns)</td><td align="right" bgcolor="#FF4949">4980,330 ns (Δ = +1038,308 ns)</td><td align="right" bgcolor="#A8D08D">4068,769 ns (Δ = -911,561 ns)</td><td align="right" bgcolor="#A8D08D">3867,373 ns (Δ = -201,396 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,925 μs</td><td align="right" bgcolor="#FFFFFF">3,957 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">3,942 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">4,980 μs (Δ = +1,038 μs)</td><td align="right" bgcolor="#A8D08D">4,069 μs (Δ = -0,912 μs)</td><td align="right" bgcolor="#A8D08D">3,867 μs (Δ = -0,201 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 28,948 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">322,733 ns</td><td align="right" bgcolor="#FF4949">338,907 ns (Δ = +16,173 ns)</td><td align="right" bgcolor="#A8D08D">309,959 ns (Δ = -28,948 ns)</td><td align="right" bgcolor="#FFFFFF">317,247 ns (Δ = +7,287 ns)</td><td align="right" bgcolor="#FFFFFF">314,827 ns (Δ = -2,420 ns)</td><td align="right" bgcolor="#FFFFFF">315,600 ns (Δ = +0,773 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,323 μs</td><td align="right" bgcolor="#FF4949">0,339 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#A8D08D">0,310 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FFFFFF">0,317 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,315 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,316 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 339,702 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4031,560 ns</td><td align="right" bgcolor="#FF4949">4290,420 ns (Δ = +258,860 ns)</td><td align="right" bgcolor="#FFFFFF">4283,777 ns (Δ = -6,643 ns)</td><td align="right" bgcolor="#FFFFFF">4165,470 ns (Δ = -118,307 ns)</td><td align="right" bgcolor="#A8D08D">3950,718 ns (Δ = -214,752 ns)</td><td align="right" bgcolor="#FF4949">4073,216 ns (Δ = +122,498 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,032 μs</td><td align="right" bgcolor="#FF4949">4,290 μs (Δ = +0,259 μs)</td><td align="right" bgcolor="#FFFFFF">4,284 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">4,165 μs (Δ = -0,118 μs)</td><td align="right" bgcolor="#A8D08D">3,951 μs (Δ = -0,215 μs)</td><td align="right" bgcolor="#FF4949">4,073 μs (Δ = +0,122 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 181,573 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#A8D08D">-31,2 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">490,860 ns</td><td align="right" bgcolor="#A8D08D">474,940 ns (Δ = -15,920 ns)</td><td align="right" bgcolor="#FFFFFF">482,020 ns (Δ = +7,080 ns)</td><td align="right" bgcolor="#A8D08D">331,553 ns (Δ = -150,467 ns)</td><td align="right" bgcolor="#A8D08D">309,288 ns (Δ = -22,266 ns)</td><td align="right" bgcolor="#FF4949">328,660 ns (Δ = +19,373 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,491 μs</td><td align="right" bgcolor="#A8D08D">0,475 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,482 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,332 μs (Δ = -0,150 μs)</td><td align="right" bgcolor="#A8D08D">0,309 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FF4949">0,329 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 4521,210 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-93,1 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4711,973 ns</td><td align="right" bgcolor="#A8D08D">4533,200 ns (Δ = -178,773 ns)</td><td align="right" bgcolor="#FF4949">4833,397 ns (Δ = +300,197 ns)</td><td align="right" bgcolor="#A8D08D">333,553 ns (Δ = -4499,844 ns)</td><td align="right" bgcolor="#A8D08D">312,187 ns (Δ = -21,366 ns)</td><td align="right" bgcolor="#FF4949">329,056 ns (Δ = +16,869 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,712 μs</td><td align="right" bgcolor="#A8D08D">4,533 μs (Δ = -0,179 μs)</td><td align="right" bgcolor="#FF4949">4,833 μs (Δ = +0,300 μs)</td><td align="right" bgcolor="#A8D08D">0,334 μs (Δ = -4,500 μs)</td><td align="right" bgcolor="#A8D08D">0,312 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FF4949">0,329 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,004 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1180</td><td align="right">1180</td><td align="right">1180</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,152</td><td align="right">1,152</td><td align="right">1,152</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 206,723 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+12,2 %</td><td align="right" bgcolor="#FF4949">+115,9 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">136,809 ns</td><td align="right" bgcolor="#A8D08D">131,640 ns (Δ = -5,169 ns)</td><td align="right" bgcolor="#FF4949">147,733 ns (Δ = +16,093 ns)</td><td align="right" bgcolor="#FF4949">318,898 ns (Δ = +171,164 ns)</td><td align="right" bgcolor="#FFFFFF">319,096 ns (Δ = +0,198 ns)</td><td align="right" bgcolor="#FF4949">338,363 ns (Δ = +19,268 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#A8D08D">0,132 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,148 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FF4949">0,319 μs (Δ = +0,171 μs)</td><td align="right" bgcolor="#FFFFFF">0,319 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,338 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 176,593 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#A8D08D">-29,2 %</td><td align="right" bgcolor="#A8D08D">-11,0 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">474,130 ns</td><td align="right" bgcolor="#A8D08D">458,281 ns (Δ = -15,849 ns)</td><td align="right" bgcolor="#FF4949">477,963 ns (Δ = +19,682 ns)</td><td align="right" bgcolor="#A8D08D">338,630 ns (Δ = -139,333 ns)</td><td align="right" bgcolor="#A8D08D">301,370 ns (Δ = -37,260 ns)</td><td align="right" bgcolor="#FFFFFF">307,863 ns (Δ = +6,493 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td><td align="right" bgcolor="#A8D08D">0,458 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FF4949">0,478 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,339 μs (Δ = -0,139 μs)</td><td align="right" bgcolor="#A8D08D">0,301 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FFFFFF">0,308 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 16,950 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">338,743 ns</td><td align="right" bgcolor="#A8D08D">321,793 ns (Δ = -16,950 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,339 μs</td><td align="right" bgcolor="#A8D08D">0,322 μs (Δ = -0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">66</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,064</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 4,736 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">115,357 ns</td><td align="right" bgcolor="#A8D08D">110,621 ns (Δ = -4,736 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#A8D08D">0,111 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 0,312 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,937 ns</td><td align="right" bgcolor="#FFFFFF">14,249 ns (Δ = +0,312 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 3,823 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,483 ns</td><td align="right" bgcolor="#A8D08D">11,660 ns (Δ = -3,823 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#A8D08D">0,012 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 37,441 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">913,849 ns</td><td align="right" bgcolor="#A8D08D">876,408 ns (Δ = -37,441 ns)</td><td align="right" bgcolor="#FFFFFF">899,609 ns (Δ = +23,201 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#A8D08D">0,876 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FFFFFF">0,900 μs (Δ = +0,023 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1062</td><td align="right">1062</td><td align="right">1062</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,037</td><td align="right">1,037</td><td align="right">1,037</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 12,600 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">496,730 ns</td><td align="right" bgcolor="#FFFFFF">493,033 ns (Δ = -3,697 ns)</td><td align="right" bgcolor="#FFFFFF">484,130 ns (Δ = -8,903 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,493 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,484 μs (Δ = -0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">418</td><td align="right">418</td><td align="right">418</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,408</td><td align="right">0,408</td><td align="right">0,408</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 622,753 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FF4949">+37,3 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1438,933 ns</td><td align="right" bgcolor="#FFFFFF">1474,103 ns (Δ = +35,170 ns)</td><td align="right" bgcolor="#FF4949">2023,420 ns (Δ = +549,317 ns)</td><td align="right" bgcolor="#FFFFFF">2061,687 ns (Δ = +38,267 ns)</td><td align="right" bgcolor="#A8D08D">1979,911 ns (Δ = -81,776 ns)</td><td align="right" bgcolor="#FFFFFF">2012,560 ns (Δ = +32,649 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,439 μs</td><td align="right" bgcolor="#FFFFFF">1,474 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FF4949">2,023 μs (Δ = +0,549 μs)</td><td align="right" bgcolor="#FFFFFF">2,062 μs (Δ = +0,038 μs)</td><td align="right" bgcolor="#A8D08D">1,980 μs (Δ = -0,082 μs)</td><td align="right" bgcolor="#FFFFFF">2,013 μs (Δ = +0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">3413</td><td align="right">3413</td><td align="right">3413</td><td align="right">4052</td><td align="right">4050</td><td align="right">4050</td><tr>
<td>Allocated Kilobytes</td><td align="right">3,333</td><td align="right">3,333</td><td align="right">3,333</td><td align="right">3,957</td><td align="right">3,955</td><td align="right">3,955</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,004</td><td align="right">0,004</td><td align="right">0,004</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 217,833 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+20,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">878,980 ns</td><td align="right" bgcolor="#FF4949">923,253 ns (Δ = +44,273 ns)</td><td align="right" bgcolor="#FFFFFF">946,160 ns (Δ = +22,907 ns)</td><td align="right" bgcolor="#FFFFFF">959,424 ns (Δ = +13,264 ns)</td><td align="right" bgcolor="#A8D08D">912,378 ns (Δ = -47,046 ns)</td><td align="right" bgcolor="#FF4949">1096,813 ns (Δ = +184,436 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td><td align="right" bgcolor="#FF4949">0,923 μs (Δ = +0,044 μs)</td><td align="right" bgcolor="#FFFFFF">0,946 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,959 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,912 μs (Δ = -0,047 μs)</td><td align="right" bgcolor="#FF4949">1,097 μs (Δ = +0,184 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 1,559 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FF4949">+7,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,580 ns</td><td align="right" bgcolor="#A8D08D">5,021 ns (Δ = -1,559 ns)</td><td align="right" bgcolor="#FF4949">5,238 ns (Δ = +0,217 ns)</td><td align="right" bgcolor="#FF4949">5,457 ns (Δ = +0,219 ns)</td><td align="right" bgcolor="#FF4949">5,700 ns (Δ = +0,243 ns)</td><td align="right" bgcolor="#FF4949">6,107 ns (Δ = +0,407 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 2,090 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,803 ns</td><td align="right" bgcolor="#FFFFFF">22,190 ns (Δ = -0,613 ns)</td><td align="right" bgcolor="#FFFFFF">21,890 ns (Δ = -0,300 ns)</td><td align="right" bgcolor="#FF4949">23,600 ns (Δ = +1,710 ns)</td><td align="right" bgcolor="#A8D08D">21,736 ns (Δ = -1,864 ns)</td><td align="right" bgcolor="#FFFFFF">21,510 ns (Δ = -0,226 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,024 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **4.5.0**

Slowest: 4.3.0

Δ: 1,491 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,467 ns</td><td align="right" bgcolor="#FFFFFF">18,867 ns (Δ = +0,400 ns)</td><td align="right" bgcolor="#FFFFFF">18,558 ns (Δ = -0,309 ns)</td><td align="right" bgcolor="#A8D08D">17,376 ns (Δ = -1,182 ns)</td><td align="right" bgcolor="#FF4949">18,046 ns (Δ = +0,670 ns)</td><td align="right" bgcolor="#FFFFFF">17,551 ns (Δ = -0,494 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 247,192 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#A8D08D">-40,7 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">605,390 ns</td><td align="right" bgcolor="#A8D08D">581,153 ns (Δ = -24,237 ns)</td><td align="right" bgcolor="#FFFFFF">598,947 ns (Δ = +17,793 ns)</td><td align="right" bgcolor="#FFFFFF">603,607 ns (Δ = +4,660 ns)</td><td align="right" bgcolor="#A8D08D">358,198 ns (Δ = -245,409 ns)</td><td align="right" bgcolor="#FFFFFF">368,727 ns (Δ = +10,529 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#A8D08D">0,581 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FFFFFF">0,599 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FFFFFF">0,604 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,358 μs (Δ = -0,245 μs)</td><td align="right" bgcolor="#FFFFFF">0,369 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">205</td><td align="right">205</td><td align="right">205</td><td align="right">238</td><td align="right">197</td><td align="right">164</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,200</td><td align="right">0,200</td><td align="right">0,200</td><td align="right">0,232</td><td align="right">0,192</td><td align="right">0,160</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 201,967 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">915,533 ns</td><td align="right" bgcolor="#FFFFFF">917,864 ns (Δ = +2,331 ns)</td><td align="right" bgcolor="#FFFFFF">905,338 ns (Δ = -12,527 ns)</td><td align="right" bgcolor="#FFFFFF">923,570 ns (Δ = +18,233 ns)</td><td align="right" bgcolor="#A8D08D">724,771 ns (Δ = -198,799 ns)</td><td align="right" bgcolor="#FFFFFF">721,603 ns (Δ = -3,168 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,916 μs</td><td align="right" bgcolor="#FFFFFF">0,918 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,905 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,924 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,725 μs (Δ = -0,199 μs)</td><td align="right" bgcolor="#FFFFFF">0,722 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">393</td><td align="right">393</td><td align="right">393</td><td align="right">426</td><td align="right">385</td><td align="right">352</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,416</td><td align="right">0,376</td><td align="right">0,344</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 237,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#A8D08D">-27,7 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">842,216 ns</td><td align="right" bgcolor="#FFFFFF">850,916 ns (Δ = +8,701 ns)</td><td align="right" bgcolor="#FFFFFF">836,955 ns (Δ = -13,961 ns)</td><td align="right" bgcolor="#FFFFFF">849,038 ns (Δ = +12,083 ns)</td><td align="right" bgcolor="#A8D08D">613,917 ns (Δ = -235,121 ns)</td><td align="right" bgcolor="#FFFFFF">623,350 ns (Δ = +9,433 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,842 μs</td><td align="right" bgcolor="#FFFFFF">0,851 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,837 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,849 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,614 μs (Δ = -0,235 μs)</td><td align="right" bgcolor="#FFFFFF">0,623 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">385</td><td align="right">385</td><td align="right">385</td><td align="right">418</td><td align="right">377</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,376</td><td align="right">0,376</td><td align="right">0,376</td><td align="right">0,408</td><td align="right">0,368</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 139,378 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#FF4949">+60,9 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#A8D08D">-7,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">188,123 ns</td><td align="right" bgcolor="#FFFFFF">189,622 ns (Δ = +1,498 ns)</td><td align="right" bgcolor="#FF4949">201,904 ns (Δ = +12,283 ns)</td><td align="right" bgcolor="#FF4949">324,880 ns (Δ = +122,976 ns)</td><td align="right" bgcolor="#FFFFFF">327,501 ns (Δ = +2,621 ns)</td><td align="right" bgcolor="#A8D08D">301,630 ns (Δ = -25,871 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,202 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">0,325 μs (Δ = +0,123 μs)</td><td align="right" bgcolor="#FFFFFF">0,328 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,302 μs (Δ = -0,026 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 164,310 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+57,6 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#A8D08D">-18,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">249,539 ns</td><td align="right" bgcolor="#FF4949">262,070 ns (Δ = +12,531 ns)</td><td align="right" bgcolor="#FFFFFF">262,517 ns (Δ = +0,447 ns)</td><td align="right" bgcolor="#FF4949">413,849 ns (Δ = +151,332 ns)</td><td align="right" bgcolor="#A8D08D">393,267 ns (Δ = -20,582 ns)</td><td align="right" bgcolor="#A8D08D">319,257 ns (Δ = -74,010 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,250 μs</td><td align="right" bgcolor="#FF4949">0,262 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,263 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,414 μs (Δ = +0,151 μs)</td><td align="right" bgcolor="#A8D08D">0,393 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#A8D08D">0,319 μs (Δ = -0,074 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 316,100 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4447,587 ns</td><td align="right" bgcolor="#FFFFFF">4546,653 ns (Δ = +99,067 ns)</td><td align="right" bgcolor="#FFFFFF">4443,300 ns (Δ = -103,353 ns)</td><td align="right" bgcolor="#FFFFFF">4423,600 ns (Δ = -19,700 ns)</td><td align="right" bgcolor="#A8D08D">4230,553 ns (Δ = -193,047 ns)</td><td align="right" bgcolor="#FFFFFF">4325,253 ns (Δ = +94,700 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,448 μs</td><td align="right" bgcolor="#FFFFFF">4,547 μs (Δ = +0,099 μs)</td><td align="right" bgcolor="#FFFFFF">4,443 μs (Δ = -0,103 μs)</td><td align="right" bgcolor="#FFFFFF">4,424 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#A8D08D">4,231 μs (Δ = -0,193 μs)</td><td align="right" bgcolor="#FFFFFF">4,325 μs (Δ = +0,095 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 530,351 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7795,680 ns</td><td align="right" bgcolor="#A8D08D">7330,297 ns (Δ = -465,383 ns)</td><td align="right" bgcolor="#FFFFFF">7424,350 ns (Δ = +94,053 ns)</td><td align="right" bgcolor="#FF4949">7789,177 ns (Δ = +364,827 ns)</td><td align="right" bgcolor="#FFFFFF">7860,648 ns (Δ = +71,471 ns)</td><td align="right" bgcolor="#FFFFFF">7790,480 ns (Δ = -70,168 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,796 μs</td><td align="right" bgcolor="#A8D08D">7,330 μs (Δ = -0,465 μs)</td><td align="right" bgcolor="#FFFFFF">7,424 μs (Δ = +0,094 μs)</td><td align="right" bgcolor="#FF4949">7,789 μs (Δ = +0,365 μs)</td><td align="right" bgcolor="#FFFFFF">7,861 μs (Δ = +0,071 μs)</td><td align="right" bgcolor="#FFFFFF">7,790 μs (Δ = -0,070 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 204,157 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6014,902 ns</td><td align="right" bgcolor="#FFFFFF">5969,343 ns (Δ = -45,559 ns)</td><td align="right" bgcolor="#FFFFFF">5842,270 ns (Δ = -127,073 ns)</td><td align="right" bgcolor="#FFFFFF">5864,298 ns (Δ = +22,028 ns)</td><td align="right" bgcolor="#FFFFFF">5810,746 ns (Δ = -53,552 ns)</td><td align="right" bgcolor="#FFFFFF">5863,443 ns (Δ = +52,698 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,015 μs</td><td align="right" bgcolor="#FFFFFF">5,969 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FFFFFF">5,842 μs (Δ = -0,127 μs)</td><td align="right" bgcolor="#FFFFFF">5,864 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#FFFFFF">5,811 μs (Δ = -0,054 μs)</td><td align="right" bgcolor="#FFFFFF">5,863 μs (Δ = +0,053 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 1605,427 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#FF4949">+33,6 %</td><td align="right" bgcolor="#A8D08D">-25,7 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4418,280 ns</td><td align="right" bgcolor="#FFFFFF">4496,062 ns (Δ = +77,782 ns)</td><td align="right" bgcolor="#FF4949">6008,623 ns (Δ = +1512,562 ns)</td><td align="right" bgcolor="#A8D08D">4465,722 ns (Δ = -1542,901 ns)</td><td align="right" bgcolor="#FFFFFF">4573,007 ns (Δ = +107,284 ns)</td><td align="right" bgcolor="#A8D08D">4403,197 ns (Δ = -169,810 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,418 μs</td><td align="right" bgcolor="#FFFFFF">4,496 μs (Δ = +0,078 μs)</td><td align="right" bgcolor="#FF4949">6,009 μs (Δ = +1,513 μs)</td><td align="right" bgcolor="#A8D08D">4,466 μs (Δ = -1,543 μs)</td><td align="right" bgcolor="#FFFFFF">4,573 μs (Δ = +0,107 μs)</td><td align="right" bgcolor="#A8D08D">4,403 μs (Δ = -0,170 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 4840,039 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,7 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12136,139 ns</td><td align="right" bgcolor="#A8D08D">7565,082 ns (Δ = -4571,057 ns)</td><td align="right" bgcolor="#FFFFFF">7395,906 ns (Δ = -169,177 ns)</td><td align="right" bgcolor="#FFFFFF">7296,100 ns (Δ = -99,806 ns)</td><td align="right" bgcolor="#FF4949">7556,100 ns (Δ = +260,000 ns)</td><td align="right" bgcolor="#FFFFFF">7538,452 ns (Δ = -17,648 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,136 μs</td><td align="right" bgcolor="#A8D08D">7,565 μs (Δ = -4,571 μs)</td><td align="right" bgcolor="#FFFFFF">7,396 μs (Δ = -0,169 μs)</td><td align="right" bgcolor="#FFFFFF">7,296 μs (Δ = -0,100 μs)</td><td align="right" bgcolor="#FF4949">7,556 μs (Δ = +0,260 μs)</td><td align="right" bgcolor="#FFFFFF">7,538 μs (Δ = -0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 410,322 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9116,476 ns</td><td align="right" bgcolor="#FFFFFF">9048,609 ns (Δ = -67,867 ns)</td><td align="right" bgcolor="#FF4949">9348,857 ns (Δ = +300,248 ns)</td><td align="right" bgcolor="#A8D08D">8938,535 ns (Δ = -410,322 ns)</td><td align="right" bgcolor="#FFFFFF">9019,423 ns (Δ = +80,888 ns)</td><td align="right" bgcolor="#FF4949">9319,897 ns (Δ = +300,474 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,116 μs</td><td align="right" bgcolor="#FFFFFF">9,049 μs (Δ = -0,068 μs)</td><td align="right" bgcolor="#FF4949">9,349 μs (Δ = +0,300 μs)</td><td align="right" bgcolor="#A8D08D">8,939 μs (Δ = -0,410 μs)</td><td align="right" bgcolor="#FFFFFF">9,019 μs (Δ = +0,081 μs)</td><td align="right" bgcolor="#FF4949">9,320 μs (Δ = +0,300 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1880,914 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#A8D08D">-18,4 %</td><td align="right" bgcolor="#A8D08D">-25,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4464,500 ns</td><td align="right" bgcolor="#FFFFFF">4506,860 ns (Δ = +42,360 ns)</td><td align="right" bgcolor="#FF4949">4681,007 ns (Δ = +174,147 ns)</td><td align="right" bgcolor="#FFFFFF">4815,951 ns (Δ = +134,944 ns)</td><td align="right" bgcolor="#A8D08D">3927,633 ns (Δ = -888,318 ns)</td><td align="right" bgcolor="#A8D08D">2935,037 ns (Δ = -992,597 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,465 μs</td><td align="right" bgcolor="#FFFFFF">4,507 μs (Δ = +0,042 μs)</td><td align="right" bgcolor="#FF4949">4,681 μs (Δ = +0,174 μs)</td><td align="right" bgcolor="#FFFFFF">4,816 μs (Δ = +0,135 μs)</td><td align="right" bgcolor="#A8D08D">3,928 μs (Δ = -0,888 μs)</td><td align="right" bgcolor="#A8D08D">2,935 μs (Δ = -0,993 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">1925</td><td align="right">2081</td><td align="right">2081</td><td align="right">1729</td><td align="right">1720</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,880</td><td align="right">2,032</td><td align="right">2,032</td><td align="right">1,688</td><td align="right">1,680</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 2578,493 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,7 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#A8D08D">-29,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5444,727 ns</td><td align="right" bgcolor="#A8D08D">4535,477 ns (Δ = -909,250 ns)</td><td align="right" bgcolor="#FFFFFF">4651,643 ns (Δ = +116,167 ns)</td><td align="right" bgcolor="#A8D08D">4251,380 ns (Δ = -400,263 ns)</td><td align="right" bgcolor="#A8D08D">4050,407 ns (Δ = -200,973 ns)</td><td align="right" bgcolor="#A8D08D">2866,233 ns (Δ = -1184,173 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,445 μs</td><td align="right" bgcolor="#A8D08D">4,535 μs (Δ = -0,909 μs)</td><td align="right" bgcolor="#FFFFFF">4,652 μs (Δ = +0,116 μs)</td><td align="right" bgcolor="#A8D08D">4,251 μs (Δ = -0,400 μs)</td><td align="right" bgcolor="#A8D08D">4,050 μs (Δ = -0,201 μs)</td><td align="right" bgcolor="#A8D08D">2,866 μs (Δ = -1,184 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">1925</td><td align="right">2081</td><td align="right">2081</td><td align="right">1729</td><td align="right">1720</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,880</td><td align="right">2,032</td><td align="right">2,032</td><td align="right">1,688</td><td align="right">1,680</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3448,883 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,7 %</td><td align="right" bgcolor="#A8D08D">-10,6 %</td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-43,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5495,273 ns</td><td align="right" bgcolor="#FF4949">6357,737 ns (Δ = +862,463 ns)</td><td align="right" bgcolor="#A8D08D">5681,360 ns (Δ = -676,377 ns)</td><td align="right" bgcolor="#A8D08D">5337,705 ns (Δ = -343,655 ns)</td><td align="right" bgcolor="#A8D08D">5109,638 ns (Δ = -228,067 ns)</td><td align="right" bgcolor="#A8D08D">2908,853 ns (Δ = -2200,784 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,495 μs</td><td align="right" bgcolor="#FF4949">6,358 μs (Δ = +0,862 μs)</td><td align="right" bgcolor="#A8D08D">5,681 μs (Δ = -0,676 μs)</td><td align="right" bgcolor="#A8D08D">5,338 μs (Δ = -0,344 μs)</td><td align="right" bgcolor="#A8D08D">5,110 μs (Δ = -0,228 μs)</td><td align="right" bgcolor="#A8D08D">2,909 μs (Δ = -2,201 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,002 ms)</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Allocated Bytes</td><td align="right">2089</td><td align="right">2253</td><td align="right">2253</td><td align="right">1901</td><td align="right">1892</td><td align="right">1032</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,040</td><td align="right">2,200</td><td align="right">2,200</td><td align="right">1,856</td><td align="right">1,848</td><td align="right">1,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 20,096 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+15,5 %</td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FF4949">+3,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,982 ns</td><td align="right" bgcolor="#FFFFFF">127,337 ns (Δ = +0,355 ns)</td><td align="right" bgcolor="#FF4949">147,078 ns (Δ = +19,741 ns)</td><td align="right" bgcolor="#A8D08D">127,001 ns (Δ = -20,077 ns)</td><td align="right" bgcolor="#FF4949">134,467 ns (Δ = +7,466 ns)</td><td align="right" bgcolor="#FF4949">139,180 ns (Δ = +4,713 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,147 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,127 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FF4949">0,134 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FF4949">0,139 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 25,670 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+16,2 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FF4949">+15,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,808 ns</td><td align="right" bgcolor="#FFFFFF">127,264 ns (Δ = +0,457 ns)</td><td align="right" bgcolor="#FF4949">147,828 ns (Δ = +20,564 ns)</td><td align="right" bgcolor="#A8D08D">129,411 ns (Δ = -18,417 ns)</td><td align="right" bgcolor="#A8D08D">122,158 ns (Δ = -7,253 ns)</td><td align="right" bgcolor="#FF4949">141,493 ns (Δ = +19,334 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,148 μs (Δ = +0,021 μs)</td><td align="right" bgcolor="#A8D08D">0,129 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,122 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,141 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 27,078 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+15,8 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FF4949">+18,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">123,768 ns</td><td align="right" bgcolor="#FFFFFF">124,582 ns (Δ = +0,814 ns)</td><td align="right" bgcolor="#FF4949">144,227 ns (Δ = +19,645 ns)</td><td align="right" bgcolor="#A8D08D">117,881 ns (Δ = -26,346 ns)</td><td align="right" bgcolor="#FFFFFF">117,149 ns (Δ = -0,732 ns)</td><td align="right" bgcolor="#FF4949">138,771 ns (Δ = +21,622 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,144 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,118 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">0,117 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,139 μs (Δ = +0,022 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 1327,696 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,7 %</td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#A8D08D">-74,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1355,070 ns</td><td align="right" bgcolor="#FF4949">1527,103 ns (Δ = +172,033 ns)</td><td align="right" bgcolor="#FF4949">1652,013 ns (Δ = +124,910 ns)</td><td align="right" bgcolor="#FF4949">1776,920 ns (Δ = +124,907 ns)</td><td align="right" bgcolor="#FFFFFF">1737,957 ns (Δ = -38,963 ns)</td><td align="right" bgcolor="#A8D08D">449,224 ns (Δ = -1288,733 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,355 μs</td><td align="right" bgcolor="#FF4949">1,527 μs (Δ = +0,172 μs)</td><td align="right" bgcolor="#FF4949">1,652 μs (Δ = +0,125 μs)</td><td align="right" bgcolor="#FF4949">1,777 μs (Δ = +0,125 μs)</td><td align="right" bgcolor="#FFFFFF">1,738 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#A8D08D">0,449 μs (Δ = -1,289 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">631</td><td align="right">631</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,616</td><td align="right">0,616</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1350,473 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#FF4949">+9,7 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#A8D08D">-72,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1620,938 ns</td><td align="right" bgcolor="#FFFFFF">1603,678 ns (Δ = -17,259 ns)</td><td align="right" bgcolor="#FF4949">1670,102 ns (Δ = +66,424 ns)</td><td align="right" bgcolor="#FF4949">1831,478 ns (Δ = +161,376 ns)</td><td align="right" bgcolor="#A8D08D">1772,558 ns (Δ = -58,920 ns)</td><td align="right" bgcolor="#A8D08D">481,004 ns (Δ = -1291,553 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,621 μs</td><td align="right" bgcolor="#FFFFFF">1,604 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FF4949">1,670 μs (Δ = +0,066 μs)</td><td align="right" bgcolor="#FF4949">1,831 μs (Δ = +0,161 μs)</td><td align="right" bgcolor="#A8D08D">1,773 μs (Δ = -0,059 μs)</td><td align="right" bgcolor="#A8D08D">0,481 μs (Δ = -1,292 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">631</td><td align="right">631</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,616</td><td align="right">0,616</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1241,337 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#FF4949">+12,0 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#A8D08D">-77,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1282,527 ns</td><td align="right" bgcolor="#FF4949">1368,739 ns (Δ = +86,213 ns)</td><td align="right" bgcolor="#FF4949">1532,978 ns (Δ = +164,239 ns)</td><td align="right" bgcolor="#FFFFFF">1577,633 ns (Δ = +44,655 ns)</td><td align="right" bgcolor="#A8D08D">1491,692 ns (Δ = -85,942 ns)</td><td align="right" bgcolor="#A8D08D">336,297 ns (Δ = -1155,395 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,283 μs</td><td align="right" bgcolor="#FF4949">1,369 μs (Δ = +0,086 μs)</td><td align="right" bgcolor="#FF4949">1,533 μs (Δ = +0,164 μs)</td><td align="right" bgcolor="#FFFFFF">1,578 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#A8D08D">1,492 μs (Δ = -0,086 μs)</td><td align="right" bgcolor="#A8D08D">0,336 μs (Δ = -1,155 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">451</td><td align="right">483</td><td align="right">483</td><td align="right">606</td><td align="right">606</td><td align="right">57</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,440</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,592</td><td align="right">0,592</td><td align="right">0,056</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 23,056 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,444 ns</td><td align="right" bgcolor="#FFFFFF">91,749 ns (Δ = -1,695 ns)</td><td align="right" bgcolor="#FF4949">97,800 ns (Δ = +6,051 ns)</td><td align="right" bgcolor="#A8D08D">76,780 ns (Δ = -21,020 ns)</td><td align="right" bgcolor="#FFFFFF">74,744 ns (Δ = -2,036 ns)</td><td align="right" bgcolor="#FFFFFF">76,183 ns (Δ = +1,439 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,098 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,077 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,075 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,076 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 26,756 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-23,8 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+3,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,553 ns</td><td align="right" bgcolor="#FFFFFF">92,853 ns (Δ = +0,299 ns)</td><td align="right" bgcolor="#FF4949">100,130 ns (Δ = +7,277 ns)</td><td align="right" bgcolor="#A8D08D">76,291 ns (Δ = -23,839 ns)</td><td align="right" bgcolor="#A8D08D">73,374 ns (Δ = -2,917 ns)</td><td align="right" bgcolor="#FF4949">75,949 ns (Δ = +2,575 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,100 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,076 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#A8D08D">0,073 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,076 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 5.0.0

Δ: 32,647 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td><td align="right" bgcolor="#A8D08D">-15,7 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+39,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">99,584 ns</td><td align="right" bgcolor="#A8D08D">96,497 ns (Δ = -3,088 ns)</td><td align="right" bgcolor="#FFFFFF">99,473 ns (Δ = +2,977 ns)</td><td align="right" bgcolor="#A8D08D">83,902 ns (Δ = -15,571 ns)</td><td align="right" bgcolor="#FFFFFF">81,913 ns (Δ = -1,989 ns)</td><td align="right" bgcolor="#FF4949">114,560 ns (Δ = +32,647 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#A8D08D">0,096 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,099 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,084 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,082 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,115 μs (Δ = +0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 88,267 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-29,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201,167 ns</td><td align="right" bgcolor="#FF4949">214,437 ns (Δ = +13,270 ns)</td><td align="right" bgcolor="#A8D08D">205,614 ns (Δ = -8,822 ns)</td><td align="right" bgcolor="#A8D08D">179,849 ns (Δ = -25,765 ns)</td><td align="right" bgcolor="#FFFFFF">179,840 ns (Δ = -0,009 ns)</td><td align="right" bgcolor="#A8D08D">126,170 ns (Δ = -53,670 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FF4949">0,214 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,206 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,180 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">0,180 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,126 μs (Δ = -0,054 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 88,139 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#A8D08D">-34,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">200,511 ns</td><td align="right" bgcolor="#FFFFFF">195,718 ns (Δ = -4,793 ns)</td><td align="right" bgcolor="#FFFFFF">199,309 ns (Δ = +3,592 ns)</td><td align="right" bgcolor="#A8D08D">174,600 ns (Δ = -24,709 ns)</td><td align="right" bgcolor="#FFFFFF">172,512 ns (Δ = -2,088 ns)</td><td align="right" bgcolor="#A8D08D">112,372 ns (Δ = -60,140 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,199 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,175 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FFFFFF">0,173 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,112 μs (Δ = -0,060 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 66,427 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#A8D08D">-7,4 %</td><td align="right" bgcolor="#FF4949">+39,8 %</td><td align="right" bgcolor="#A8D08D">-46,7 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,694 ns</td><td align="right" bgcolor="#FF4949">105,333 ns (Δ = +9,640 ns)</td><td align="right" bgcolor="#A8D08D">97,582 ns (Δ = -7,751 ns)</td><td align="right" bgcolor="#FF4949">136,372 ns (Δ = +38,789 ns)</td><td align="right" bgcolor="#A8D08D">72,731 ns (Δ = -63,641 ns)</td><td align="right" bgcolor="#A8D08D">69,944 ns (Δ = -2,787 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FF4949">0,105 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,098 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">0,136 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#A8D08D">0,073 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#A8D08D">0,070 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 237,607 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4311,583 ns</td><td align="right" bgcolor="#A8D08D">4148,930 ns (Δ = -162,653 ns)</td><td align="right" bgcolor="#FF4949">4346,040 ns (Δ = +197,110 ns)</td><td align="right" bgcolor="#FFFFFF">4363,176 ns (Δ = +17,136 ns)</td><td align="right" bgcolor="#FFFFFF">4386,537 ns (Δ = +23,361 ns)</td><td align="right" bgcolor="#A8D08D">4189,076 ns (Δ = -197,461 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,312 μs</td><td align="right" bgcolor="#A8D08D">4,149 μs (Δ = -0,163 μs)</td><td align="right" bgcolor="#FF4949">4,346 μs (Δ = +0,197 μs)</td><td align="right" bgcolor="#FFFFFF">4,363 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">4,387 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#A8D08D">4,189 μs (Δ = -0,197 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 878,303 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FF4949">+101,2 %</td><td align="right" bgcolor="#A8D08D">-51,2 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">851,848 ns</td><td align="right" bgcolor="#FFFFFF">840,129 ns (Δ = -11,720 ns)</td><td align="right" bgcolor="#FFFFFF">852,727 ns (Δ = +12,598 ns)</td><td align="right" bgcolor="#FF4949">1715,900 ns (Δ = +863,173 ns)</td><td align="right" bgcolor="#A8D08D">837,597 ns (Δ = -878,303 ns)</td><td align="right" bgcolor="#FF4949">874,273 ns (Δ = +36,676 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,852 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FFFFFF">0,853 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FF4949">1,716 μs (Δ = +0,863 μs)</td><td align="right" bgcolor="#A8D08D">0,838 μs (Δ = -0,878 μs)</td><td align="right" bgcolor="#FF4949">0,874 μs (Δ = +0,037 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 192,442 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5422,052 ns</td><td align="right" bgcolor="#FFFFFF">5267,003 ns (Δ = -155,049 ns)</td><td align="right" bgcolor="#FFFFFF">5364,837 ns (Δ = +97,833 ns)</td><td align="right" bgcolor="#FFFFFF">5229,610 ns (Δ = -135,227 ns)</td><td align="right" bgcolor="#FFFFFF">5273,164 ns (Δ = +43,554 ns)</td><td align="right" bgcolor="#FFFFFF">5265,343 ns (Δ = -7,821 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,422 μs</td><td align="right" bgcolor="#FFFFFF">5,267 μs (Δ = -0,155 μs)</td><td align="right" bgcolor="#FFFFFF">5,365 μs (Δ = +0,098 μs)</td><td align="right" bgcolor="#FFFFFF">5,230 μs (Δ = -0,135 μs)</td><td align="right" bgcolor="#FFFFFF">5,273 μs (Δ = +0,044 μs)</td><td align="right" bgcolor="#FFFFFF">5,265 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1825,093 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+38,5 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FF4949">+34,6 %</td><td align="right" bgcolor="#A8D08D">-30,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4431,627 ns</td><td align="right" bgcolor="#A8D08D">4212,368 ns (Δ = -219,258 ns)</td><td align="right" bgcolor="#FF4949">5834,063 ns (Δ = +1621,695 ns)</td><td align="right" bgcolor="#A8D08D">4430,948 ns (Δ = -1403,116 ns)</td><td align="right" bgcolor="#FF4949">5964,870 ns (Δ = +1533,923 ns)</td><td align="right" bgcolor="#A8D08D">4139,777 ns (Δ = -1825,093 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,432 μs</td><td align="right" bgcolor="#A8D08D">4,212 μs (Δ = -0,219 μs)</td><td align="right" bgcolor="#FF4949">5,834 μs (Δ = +1,622 μs)</td><td align="right" bgcolor="#A8D08D">4,431 μs (Δ = -1,403 μs)</td><td align="right" bgcolor="#FF4949">5,965 μs (Δ = +1,534 μs)</td><td align="right" bgcolor="#A8D08D">4,140 μs (Δ = -1,825 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,002 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 168,061 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FF4949">+16,9 %</td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">830,040 ns</td><td align="right" bgcolor="#FFFFFF">841,267 ns (Δ = +11,227 ns)</td><td align="right" bgcolor="#FFFFFF">853,775 ns (Δ = +12,508 ns)</td><td align="right" bgcolor="#FF4949">998,101 ns (Δ = +144,326 ns)</td><td align="right" bgcolor="#A8D08D">834,547 ns (Δ = -163,554 ns)</td><td align="right" bgcolor="#FFFFFF">850,177 ns (Δ = +15,630 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,830 μs</td><td align="right" bgcolor="#FFFFFF">0,841 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,854 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FF4949">0,998 μs (Δ = +0,144 μs)</td><td align="right" bgcolor="#A8D08D">0,835 μs (Δ = -0,164 μs)</td><td align="right" bgcolor="#FFFFFF">0,850 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 114,764 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FF4949">+14,5 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">802,689 ns</td><td align="right" bgcolor="#A8D08D">777,617 ns (Δ = -25,072 ns)</td><td align="right" bgcolor="#A8D08D">752,503 ns (Δ = -25,113 ns)</td><td align="right" bgcolor="#FF4949">861,664 ns (Δ = +109,161 ns)</td><td align="right" bgcolor="#A8D08D">746,900 ns (Δ = -114,764 ns)</td><td align="right" bgcolor="#FF4949">776,184 ns (Δ = +29,284 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td><td align="right" bgcolor="#A8D08D">0,778 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#A8D08D">0,753 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FF4949">0,862 μs (Δ = +0,109 μs)</td><td align="right" bgcolor="#A8D08D">0,747 μs (Δ = -0,115 μs)</td><td align="right" bgcolor="#FF4949">0,776 μs (Δ = +0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 196,432 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#A8D08D">-46,2 %</td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#A8D08D">-16,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">374,462 ns</td><td align="right" bgcolor="#FFFFFF">363,767 ns (Δ = -10,695 ns)</td><td align="right" bgcolor="#A8D08D">195,888 ns (Δ = -167,879 ns)</td><td align="right" bgcolor="#FF4949">208,007 ns (Δ = +12,119 ns)</td><td align="right" bgcolor="#FFFFFF">214,007 ns (Δ = +6,000 ns)</td><td align="right" bgcolor="#A8D08D">178,030 ns (Δ = -35,977 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,374 μs</td><td align="right" bgcolor="#FFFFFF">0,364 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,196 μs (Δ = -0,168 μs)</td><td align="right" bgcolor="#FF4949">0,208 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FFFFFF">0,214 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,178 μs (Δ = -0,036 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 203,903 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-8,7 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">365,870 ns</td><td align="right" bgcolor="#FFFFFF">371,147 ns (Δ = +5,277 ns)</td><td align="right" bgcolor="#A8D08D">198,404 ns (Δ = -172,743 ns)</td><td align="right" bgcolor="#FF4949">210,737 ns (Δ = +12,333 ns)</td><td align="right" bgcolor="#A8D08D">192,389 ns (Δ = -18,348 ns)</td><td align="right" bgcolor="#A8D08D">167,243 ns (Δ = -25,146 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,371 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,198 μs (Δ = -0,173 μs)</td><td align="right" bgcolor="#FF4949">0,211 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,192 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,167 μs (Δ = -0,025 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 513534,034 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td><td align="right" bgcolor="#FF4949">+136,3 %</td><td align="right" bgcolor="#A8D08D">-40,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">311989,007 ns</td><td align="right" bgcolor="#A8D08D">297477,373 ns (Δ = -14511,633 ns)</td><td align="right" bgcolor="#FFFFFF">304974,770 ns (Δ = +7497,397 ns)</td><td align="right" bgcolor="#FF4949">343271,276 ns (Δ = +38296,506 ns)</td><td align="right" bgcolor="#FF4949">811011,408 ns (Δ = +467740,132 ns)</td><td align="right" bgcolor="#A8D08D">479198,204 ns (Δ = -331813,203 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">311,989 μs</td><td align="right" bgcolor="#A8D08D">297,477 μs (Δ = -14,512 μs)</td><td align="right" bgcolor="#FFFFFF">304,975 μs (Δ = +7,497 μs)</td><td align="right" bgcolor="#FF4949">343,271 μs (Δ = +38,297 μs)</td><td align="right" bgcolor="#FF4949">811,011 μs (Δ = +467,740 μs)</td><td align="right" bgcolor="#A8D08D">479,198 μs (Δ = -331,813 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,312 ms</td><td align="right" bgcolor="#A8D08D">0,297 ms (Δ = -0,015 ms)</td><td align="right" bgcolor="#FFFFFF">0,305 ms (Δ = +0,007 ms)</td><td align="right" bgcolor="#FF4949">0,343 ms (Δ = +0,038 ms)</td><td align="right" bgcolor="#FF4949">0,811 ms (Δ = +0,468 ms)</td><td align="right" bgcolor="#A8D08D">0,479 ms (Δ = -0,332 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">130</td><td align="right">170</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">5</td><td align="right">5</td><td align="right">10</td><td align="right">10</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">80227</td><td align="right">80086</td><td align="right">81402</td><td align="right">85729</td><td align="right">110578</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">78,347</td><td align="right">78,209</td><td align="right">79,494</td><td align="right">83,720</td><td align="right">107,986</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,077</td><td align="right">0,076</td><td align="right">0,078</td><td align="right">0,082</td><td align="right">0,105</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 464441,126 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FF4949">+653,0 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">63225,317 ns</td><td align="right" bgcolor="#FFFFFF">62434,445 ns (Δ = -790,872 ns)</td><td align="right" bgcolor="#FF4949">66086,173 ns (Δ = +3651,728 ns)</td><td align="right" bgcolor="#FF4949">69974,143 ns (Δ = +3887,970 ns)</td><td align="right" bgcolor="#FF4949">526875,571 ns (Δ = +456901,428 ns)</td><td align="right" bgcolor="#A8D08D">477052,596 ns (Δ = -49822,976 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">63,225 μs</td><td align="right" bgcolor="#FFFFFF">62,434 μs (Δ = -0,791 μs)</td><td align="right" bgcolor="#FF4949">66,086 μs (Δ = +3,652 μs)</td><td align="right" bgcolor="#FF4949">69,974 μs (Δ = +3,888 μs)</td><td align="right" bgcolor="#FF4949">526,876 μs (Δ = +456,901 μs)</td><td align="right" bgcolor="#A8D08D">477,053 μs (Δ = -49,823 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,063 ms</td><td align="right" bgcolor="#FFFFFF">0,062 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,066 ms (Δ = +0,004 ms)</td><td align="right" bgcolor="#FF4949">0,070 ms (Δ = +0,004 ms)</td><td align="right" bgcolor="#FF4949">0,527 ms (Δ = +0,457 ms)</td><td align="right" bgcolor="#A8D08D">0,477 ms (Δ = -0,050 ms)</td></tr>
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
<td>Gen 0</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">30</td><td align="right">50</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">20005</td><td align="right">19932</td><td align="right">20276</td><td align="right">21570</td><td align="right">39119</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,536</td><td align="right">19,465</td><td align="right">19,801</td><td align="right">21,064</td><td align="right">38,202</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,021</td><td align="right">0,037</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 497235,661 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#FF4949">+199,6 %</td><td align="right" bgcolor="#A8D08D">-31,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">210211,657 ns</td><td align="right" bgcolor="#FFFFFF">209415,502 ns (Δ = -796,154 ns)</td><td align="right" bgcolor="#FFFFFF">211330,180 ns (Δ = +1914,678 ns)</td><td align="right" bgcolor="#FF4949">235879,040 ns (Δ = +24548,860 ns)</td><td align="right" bgcolor="#FF4949">706651,163 ns (Δ = +470772,123 ns)</td><td align="right" bgcolor="#A8D08D">484887,403 ns (Δ = -221763,760 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">210,212 μs</td><td align="right" bgcolor="#FFFFFF">209,416 μs (Δ = -0,796 μs)</td><td align="right" bgcolor="#FFFFFF">211,330 μs (Δ = +1,915 μs)</td><td align="right" bgcolor="#FF4949">235,879 μs (Δ = +24,549 μs)</td><td align="right" bgcolor="#FF4949">706,651 μs (Δ = +470,772 μs)</td><td align="right" bgcolor="#A8D08D">484,887 μs (Δ = -221,764 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,210 ms</td><td align="right" bgcolor="#FFFFFF">0,209 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,211 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#FF4949">0,236 ms (Δ = +0,025 ms)</td><td align="right" bgcolor="#FF4949">0,707 ms (Δ = +0,471 ms)</td><td align="right" bgcolor="#A8D08D">0,485 ms (Δ = -0,222 ms)</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">100</td><td align="right">130</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59385</td><td align="right">59245</td><td align="right">60582</td><td align="right">64972</td><td align="right">87735</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,993</td><td align="right">57,856</td><td align="right">59,162</td><td align="right">63,449</td><td align="right">85,679</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,057</td><td align="right">0,057</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1151264,743 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FF4949">+51,3 %</td><td align="right" bgcolor="#A8D08D">-70,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1055871,596 ns</td><td align="right" bgcolor="#A8D08D">1001070,764 ns (Δ = -54800,831 ns)</td><td align="right" bgcolor="#FF4949">1042661,340 ns (Δ = +41590,576 ns)</td><td align="right" bgcolor="#FF4949">1075284,753 ns (Δ = +32623,413 ns)</td><td align="right" bgcolor="#FF4949">1627317,490 ns (Δ = +552032,737 ns)</td><td align="right" bgcolor="#A8D08D">476052,747 ns (Δ = -1151264,743 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1055,872 μs</td><td align="right" bgcolor="#A8D08D">1001,071 μs (Δ = -54,801 μs)</td><td align="right" bgcolor="#FF4949">1042,661 μs (Δ = +41,591 μs)</td><td align="right" bgcolor="#FF4949">1075,285 μs (Δ = +32,623 μs)</td><td align="right" bgcolor="#FF4949">1627,317 μs (Δ = +552,033 μs)</td><td align="right" bgcolor="#A8D08D">476,053 μs (Δ = -1151,265 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,056 ms</td><td align="right" bgcolor="#A8D08D">1,001 ms (Δ = -0,055 ms)</td><td align="right" bgcolor="#FF4949">1,043 ms (Δ = +0,042 ms)</td><td align="right" bgcolor="#FF4949">1,075 ms (Δ = +0,033 ms)</td><td align="right" bgcolor="#FF4949">1,627 ms (Δ = +0,552 ms)</td><td align="right" bgcolor="#A8D08D">0,476 ms (Δ = -1,151 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">410</td><td align="right">410</td><td align="right">420</td><td align="right">450</td><td align="right">530</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">50</td><td align="right">50</td><td align="right">59</td><td align="right">60</td><td align="right">90</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">263118</td><td align="right">262614</td><td align="right">268908</td><td align="right">288618</td><td align="right">337030</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,951</td><td align="right">256,459</td><td align="right">262,605</td><td align="right">281,854</td><td align="right">329,131</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,251</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,321</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 19397816,517 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#A8D08D">-97,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19050279,753 ns</td><td align="right" bgcolor="#FFFFFF">19473778,727 ns (Δ = +423498,973 ns)</td><td align="right" bgcolor="#FFFFFF">19206270,860 ns (Δ = -267507,867 ns)</td><td align="right" bgcolor="#FFFFFF">19445131,177 ns (Δ = +238860,317 ns)</td><td align="right" bgcolor="#FFFFFF">19864660,053 ns (Δ = +419528,876 ns)</td><td align="right" bgcolor="#A8D08D">466843,536 ns (Δ = -19397816,517 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">19050,280 μs</td><td align="right" bgcolor="#FFFFFF">19473,779 μs (Δ = +423,499 μs)</td><td align="right" bgcolor="#FFFFFF">19206,271 μs (Δ = -267,508 μs)</td><td align="right" bgcolor="#FFFFFF">19445,131 μs (Δ = +238,860 μs)</td><td align="right" bgcolor="#FFFFFF">19864,660 μs (Δ = +419,529 μs)</td><td align="right" bgcolor="#A8D08D">466,844 μs (Δ = -19397,817 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">19,050 ms</td><td align="right" bgcolor="#FFFFFF">19,474 ms (Δ = +0,423 ms)</td><td align="right" bgcolor="#FFFFFF">19,206 ms (Δ = -0,268 ms)</td><td align="right" bgcolor="#FFFFFF">19,445 ms (Δ = +0,239 ms)</td><td align="right" bgcolor="#FFFFFF">19,865 ms (Δ = +0,420 ms)</td><td align="right" bgcolor="#A8D08D">0,467 ms (Δ = -19,398 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2260</td><td align="right">2260</td><td align="right">2293</td><td align="right">2351</td><td align="right">2478</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">750</td><td align="right">750</td><td align="right">760</td><td align="right">780</td><td align="right">820</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1427697</td><td align="right">1427268</td><td align="right">1448486</td><td align="right">1486336</td><td align="right">1563452</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">1394,235</td><td align="right">1393,816</td><td align="right">1414,537</td><td align="right">1451,500</td><td align="right">1526,809</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">1,362</td><td align="right">1,361</td><td align="right">1,381</td><td align="right">1,417</td><td align="right">1,491</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 822906,007 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+60,0 %</td><td align="right" bgcolor="#A8D08D">-63,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">791962,400 ns</td><td align="right" bgcolor="#FFFFFF">810577,053 ns (Δ = +18614,653 ns)</td><td align="right" bgcolor="#FFFFFF">799011,993 ns (Δ = -11565,060 ns)</td><td align="right" bgcolor="#FFFFFF">806727,715 ns (Δ = +7715,722 ns)</td><td align="right" bgcolor="#FF4949">1290986,816 ns (Δ = +484259,101 ns)</td><td align="right" bgcolor="#A8D08D">468080,809 ns (Δ = -822906,007 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">791,962 μs</td><td align="right" bgcolor="#FFFFFF">810,577 μs (Δ = +18,615 μs)</td><td align="right" bgcolor="#FFFFFF">799,012 μs (Δ = -11,565 μs)</td><td align="right" bgcolor="#FFFFFF">806,728 μs (Δ = +7,716 μs)</td><td align="right" bgcolor="#FF4949">1290,987 μs (Δ = +484,259 μs)</td><td align="right" bgcolor="#A8D08D">468,081 μs (Δ = -822,906 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,792 ms</td><td align="right" bgcolor="#FFFFFF">0,811 ms (Δ = +0,019 ms)</td><td align="right" bgcolor="#FFFFFF">0,799 ms (Δ = -0,012 ms)</td><td align="right" bgcolor="#FFFFFF">0,807 ms (Δ = +0,008 ms)</td><td align="right" bgcolor="#FF4949">1,291 ms (Δ = +0,484 ms)</td><td align="right" bgcolor="#A8D08D">0,468 ms (Δ = -0,823 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">100</td><td align="right">100</td><td align="right">100</td><td align="right">100</td><td align="right">130</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">20</td><td align="right">30</td><td align="right">20</td><td align="right">40</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66625</td><td align="right">66456</td><td align="right">67298</td><td align="right">69734</td><td align="right">87270</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">65,063</td><td align="right">64,898</td><td align="right">65,721</td><td align="right">68,100</td><td align="right">85,225</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">0,064</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,067</td><td align="right">0,083</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 3203626,319 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,5 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td><td align="right" bgcolor="#A8D08D">-87,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3167029,556 ns</td><td align="right" bgcolor="#FF4949">3278471,113 ns (Δ = +111441,558 ns)</td><td align="right" bgcolor="#A8D08D">3166845,062 ns (Δ = -111626,051 ns)</td><td align="right" bgcolor="#FFFFFF">3162647,678 ns (Δ = -4197,384 ns)</td><td align="right" bgcolor="#FF4949">3670358,110 ns (Δ = +507710,432 ns)</td><td align="right" bgcolor="#A8D08D">466731,791 ns (Δ = -3203626,319 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3167,030 μs</td><td align="right" bgcolor="#FF4949">3278,471 μs (Δ = +111,442 μs)</td><td align="right" bgcolor="#A8D08D">3166,845 μs (Δ = -111,626 μs)</td><td align="right" bgcolor="#FFFFFF">3162,648 μs (Δ = -4,197 μs)</td><td align="right" bgcolor="#FF4949">3670,358 μs (Δ = +507,710 μs)</td><td align="right" bgcolor="#A8D08D">466,732 μs (Δ = -3203,626 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,167 ms</td><td align="right" bgcolor="#FF4949">3,278 ms (Δ = +0,111 ms)</td><td align="right" bgcolor="#A8D08D">3,167 ms (Δ = -0,112 ms)</td><td align="right" bgcolor="#FFFFFF">3,163 ms (Δ = -0,004 ms)</td><td align="right" bgcolor="#FF4949">3,670 ms (Δ = +0,508 ms)</td><td align="right" bgcolor="#A8D08D">0,467 ms (Δ = -3,204 ms)</td></tr>
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
<td align="right">4.5.0</td>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">380</td><td align="right">380</td><td align="right">390</td><td align="right">400</td><td align="right">440</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">100</td><td align="right">101</td><td align="right">109</td><td align="right">110</td><td align="right">110</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">245395</td><td align="right">245471</td><td align="right">249437</td><td align="right">257284</td><td align="right">282849</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">239,644</td><td align="right">239,718</td><td align="right">243,591</td><td align="right">251,254</td><td align="right">276,220</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">0,234</td><td align="right">0,234</td><td align="right">0,238</td><td align="right">0,245</td><td align="right">0,270</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 15443934,487 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td><td align="right" bgcolor="#A8D08D">-97,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14913415,969 ns</td><td align="right" bgcolor="#FFFFFF">15010918,407 ns (Δ = +97502,438 ns)</td><td align="right" bgcolor="#FFFFFF">14937707,751 ns (Δ = -73210,656 ns)</td><td align="right" bgcolor="#FFFFFF">15096950,122 ns (Δ = +159242,371 ns)</td><td align="right" bgcolor="#FF4949">15907710,720 ns (Δ = +810760,598 ns)</td><td align="right" bgcolor="#A8D08D">463776,233 ns (Δ = -15443934,487 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14913,416 μs</td><td align="right" bgcolor="#FFFFFF">15010,918 μs (Δ = +97,502 μs)</td><td align="right" bgcolor="#FFFFFF">14937,708 μs (Δ = -73,211 μs)</td><td align="right" bgcolor="#FFFFFF">15096,950 μs (Δ = +159,242 μs)</td><td align="right" bgcolor="#FF4949">15907,711 μs (Δ = +810,761 μs)</td><td align="right" bgcolor="#A8D08D">463,776 μs (Δ = -15443,934 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,913 ms</td><td align="right" bgcolor="#FFFFFF">15,011 ms (Δ = +0,098 ms)</td><td align="right" bgcolor="#FFFFFF">14,938 ms (Δ = -0,073 ms)</td><td align="right" bgcolor="#FFFFFF">15,097 ms (Δ = +0,159 ms)</td><td align="right" bgcolor="#FF4949">15,908 ms (Δ = +0,811 ms)</td><td align="right" bgcolor="#A8D08D">0,464 ms (Δ = -15,444 ms)</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1810</td><td align="right">1810</td><td align="right">1840</td><td align="right">1900</td><td align="right">2000</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">575</td><td align="right">549</td><td align="right">521</td><td align="right">510</td><td align="right">570</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1144688</td><td align="right">1143423</td><td align="right">1161604</td><td align="right">1200482</td><td align="right">1265187</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">1117,859</td><td align="right">1116,624</td><td align="right">1134,379</td><td align="right">1172,346</td><td align="right">1235,534</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">1,092</td><td align="right">1,090</td><td align="right">1,108</td><td align="right">1,145</td><td align="right">1,207</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1096267,358 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FF4949">+23,8 %</td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#FF4949">+50,4 %</td><td align="right" bgcolor="#A8D08D">-69,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">790460,507 ns</td><td align="right" bgcolor="#FFFFFF">783711,093 ns (Δ = -6749,413 ns)</td><td align="right" bgcolor="#FF4949">970136,943 ns (Δ = +186425,850 ns)</td><td align="right" bgcolor="#FF4949">1043436,403 ns (Δ = +73299,460 ns)</td><td align="right" bgcolor="#FF4949">1568873,883 ns (Δ = +525437,480 ns)</td><td align="right" bgcolor="#A8D08D">472606,525 ns (Δ = -1096267,358 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">790,461 μs</td><td align="right" bgcolor="#FFFFFF">783,711 μs (Δ = -6,749 μs)</td><td align="right" bgcolor="#FF4949">970,137 μs (Δ = +186,426 μs)</td><td align="right" bgcolor="#FF4949">1043,436 μs (Δ = +73,299 μs)</td><td align="right" bgcolor="#FF4949">1568,874 μs (Δ = +525,437 μs)</td><td align="right" bgcolor="#A8D08D">472,607 μs (Δ = -1096,267 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,790 ms</td><td align="right" bgcolor="#FFFFFF">0,784 ms (Δ = -0,007 ms)</td><td align="right" bgcolor="#FF4949">0,970 ms (Δ = +0,186 ms)</td><td align="right" bgcolor="#FF4949">1,043 ms (Δ = +0,073 ms)</td><td align="right" bgcolor="#FF4949">1,569 ms (Δ = +0,525 ms)</td><td align="right" bgcolor="#A8D08D">0,473 ms (Δ = -1,096 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">860</td><td align="right">860</td><td align="right">870</td><td align="right">880</td><td align="right">920</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">151</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544310</td><td align="right">544218</td><td align="right">550091</td><td align="right">559326</td><td align="right">586975</td><td align="right">29255</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,553</td><td align="right">531,463</td><td align="right">537,198</td><td align="right">546,217</td><td align="right">573,218</td><td align="right">28,569</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,533</td><td align="right">0,560</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 535945,731 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FF4949">+59,6 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#FF4949">+287,1 %</td><td align="right" bgcolor="#A8D08D">-25,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">99137,657 ns</td><td align="right" bgcolor="#FFFFFF">96462,427 ns (Δ = -2675,230 ns)</td><td align="right" bgcolor="#FF4949">153966,843 ns (Δ = +57504,417 ns)</td><td align="right" bgcolor="#FF4949">163374,987 ns (Δ = +9408,143 ns)</td><td align="right" bgcolor="#FF4949">632408,158 ns (Δ = +469033,171 ns)</td><td align="right" bgcolor="#A8D08D">469947,190 ns (Δ = -162460,968 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">99,138 μs</td><td align="right" bgcolor="#FFFFFF">96,462 μs (Δ = -2,675 μs)</td><td align="right" bgcolor="#FF4949">153,967 μs (Δ = +57,504 μs)</td><td align="right" bgcolor="#FF4949">163,375 μs (Δ = +9,408 μs)</td><td align="right" bgcolor="#FF4949">632,408 μs (Δ = +469,033 μs)</td><td align="right" bgcolor="#A8D08D">469,947 μs (Δ = -162,461 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,099 ms</td><td align="right" bgcolor="#FFFFFF">0,096 ms (Δ = -0,003 ms)</td><td align="right" bgcolor="#FF4949">0,154 ms (Δ = +0,058 ms)</td><td align="right" bgcolor="#FF4949">0,163 ms (Δ = +0,009 ms)</td><td align="right" bgcolor="#FF4949">0,632 ms (Δ = +0,469 ms)</td><td align="right" bgcolor="#A8D08D">0,470 ms (Δ = -0,162 ms)</td></tr>
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
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">210</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115962</td><td align="right">115911</td><td align="right">117563</td><td align="right">120565</td><td align="right">138410</td><td align="right">29254</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,244</td><td align="right">113,194</td><td align="right">114,808</td><td align="right">117,739</td><td align="right">135,166</td><td align="right">28,568</td><tr>
<td>Allocated Megabytes</td><td align="right">0,111</td><td align="right">0,111</td><td align="right">0,112</td><td align="right">0,115</td><td align="right">0,132</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 739220,323 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FF4949">+43,9 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#FF4949">+94,5 %</td><td align="right" bgcolor="#A8D08D">-55,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">349694,600 ns</td><td align="right" bgcolor="#FF4949">360873,504 ns (Δ = +11178,904 ns)</td><td align="right" bgcolor="#FF4949">519222,076 ns (Δ = +158348,571 ns)</td><td align="right" bgcolor="#FF4949">559935,703 ns (Δ = +40713,627 ns)</td><td align="right" bgcolor="#FF4949">1088914,923 ns (Δ = +528979,220 ns)</td><td align="right" bgcolor="#A8D08D">488111,715 ns (Δ = -600803,208 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">349,695 μs</td><td align="right" bgcolor="#FF4949">360,874 μs (Δ = +11,179 μs)</td><td align="right" bgcolor="#FF4949">519,222 μs (Δ = +158,349 μs)</td><td align="right" bgcolor="#FF4949">559,936 μs (Δ = +40,714 μs)</td><td align="right" bgcolor="#FF4949">1088,915 μs (Δ = +528,979 μs)</td><td align="right" bgcolor="#A8D08D">488,112 μs (Δ = -600,803 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,350 ms</td><td align="right" bgcolor="#FF4949">0,361 ms (Δ = +0,011 ms)</td><td align="right" bgcolor="#FF4949">0,519 ms (Δ = +0,158 ms)</td><td align="right" bgcolor="#FF4949">0,560 ms (Δ = +0,041 ms)</td><td align="right" bgcolor="#FF4949">1,089 ms (Δ = +0,529 ms)</td><td align="right" bgcolor="#A8D08D">0,488 ms (Δ = -0,601 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">620</td><td align="right">620</td><td align="right">630</td><td align="right">650</td><td align="right">690</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">50</td><td align="right">50</td><td align="right">51</td><td align="right">58</td><td align="right">80</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396416</td><td align="right">396236</td><td align="right">402205</td><td align="right">411961</td><td align="right">437228</td><td align="right">29256</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,125</td><td align="right">386,949</td><td align="right">392,778</td><td align="right">402,306</td><td align="right">426,980</td><td align="right">28,570</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2797748,030 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FF4949">+48,6 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FF4949">+23,6 %</td><td align="right" bgcolor="#A8D08D">-85,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1769762,053 ns</td><td align="right" bgcolor="#A8D08D">1705806,389 ns (Δ = -63955,664 ns)</td><td align="right" bgcolor="#FF4949">2535287,523 ns (Δ = +829481,134 ns)</td><td align="right" bgcolor="#FF4949">2643359,840 ns (Δ = +108072,317 ns)</td><td align="right" bgcolor="#FF4949">3266367,590 ns (Δ = +623007,750 ns)</td><td align="right" bgcolor="#A8D08D">468619,560 ns (Δ = -2797748,030 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1769,762 μs</td><td align="right" bgcolor="#A8D08D">1705,806 μs (Δ = -63,956 μs)</td><td align="right" bgcolor="#FF4949">2535,288 μs (Δ = +829,481 μs)</td><td align="right" bgcolor="#FF4949">2643,360 μs (Δ = +108,072 μs)</td><td align="right" bgcolor="#FF4949">3266,368 μs (Δ = +623,008 μs)</td><td align="right" bgcolor="#A8D08D">468,620 μs (Δ = -2797,748 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,770 ms</td><td align="right" bgcolor="#A8D08D">1,706 ms (Δ = -0,064 ms)</td><td align="right" bgcolor="#FF4949">2,535 ms (Δ = +0,829 ms)</td><td align="right" bgcolor="#FF4949">2,643 ms (Δ = +0,108 ms)</td><td align="right" bgcolor="#FF4949">3,266 ms (Δ = +0,623 ms)</td><td align="right" bgcolor="#A8D08D">0,469 ms (Δ = -2,798 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2850</td><td align="right">2850</td><td align="right">2890</td><td align="right">2960</td><td align="right">3060</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">470</td><td align="right">470</td><td align="right">468</td><td align="right">488</td><td align="right">502</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799924</td><td align="right">1799766</td><td align="right">1825939</td><td align="right">1868250</td><td align="right">1930197</td><td align="right">29256</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,738</td><td align="right">1757,584</td><td align="right">1783,144</td><td align="right">1824,463</td><td align="right">1884,958</td><td align="right">28,570</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,716</td><td align="right">1,741</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">0,028</td></tr>
</table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 1849,040 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">-63,5 %</td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2702,735 ns</td><td align="right" bgcolor="#FFFFFF">2765,287 ns (Δ = +62,552 ns)</td><td align="right" bgcolor="#A8D08D">2670,450 ns (Δ = -94,837 ns)</td><td align="right" bgcolor="#A8D08D">974,850 ns (Δ = -1695,600 ns)</td><td align="right" bgcolor="#A8D08D">916,247 ns (Δ = -58,603 ns)</td><td align="right" bgcolor="#FF4949">977,153 ns (Δ = +60,907 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,703 μs</td><td align="right" bgcolor="#FFFFFF">2,765 μs (Δ = +0,063 μs)</td><td align="right" bgcolor="#A8D08D">2,670 μs (Δ = -0,095 μs)</td><td align="right" bgcolor="#A8D08D">0,975 μs (Δ = -1,696 μs)</td><td align="right" bgcolor="#A8D08D">0,916 μs (Δ = -0,059 μs)</td><td align="right" bgcolor="#FF4949">0,977 μs (Δ = +0,061 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1049</td><td align="right">1049</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,024</td><td align="right">1,024</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 24,904 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">194,595 ns</td><td align="right" bgcolor="#FFFFFF">195,231 ns (Δ = +0,636 ns)</td><td align="right" bgcolor="#FF4949">209,353 ns (Δ = +14,122 ns)</td><td align="right" bgcolor="#A8D08D">196,387 ns (Δ = -12,967 ns)</td><td align="right" bgcolor="#A8D08D">187,349 ns (Δ = -9,038 ns)</td><td align="right" bgcolor="#FFFFFF">184,449 ns (Δ = -2,900 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,209 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,196 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,187 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,184 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 850,078 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+19,7 %</td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3560,847 ns</td><td align="right" bgcolor="#A8D08D">3263,913 ns (Δ = -296,933 ns)</td><td align="right" bgcolor="#A8D08D">3134,288 ns (Δ = -129,625 ns)</td><td align="right" bgcolor="#FF4949">3752,790 ns (Δ = +618,502 ns)</td><td align="right" bgcolor="#FF4949">3984,367 ns (Δ = +231,577 ns)</td><td align="right" bgcolor="#A8D08D">3696,325 ns (Δ = -288,042 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,561 μs</td><td align="right" bgcolor="#A8D08D">3,264 μs (Δ = -0,297 μs)</td><td align="right" bgcolor="#A8D08D">3,134 μs (Δ = -0,130 μs)</td><td align="right" bgcolor="#FF4949">3,753 μs (Δ = +0,619 μs)</td><td align="right" bgcolor="#FF4949">3,984 μs (Δ = +0,232 μs)</td><td align="right" bgcolor="#A8D08D">3,696 μs (Δ = -0,288 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">1235</td><td align="right">1211</td><td align="right">1211</td><td align="right">1440</td><td align="right">1440</td><td align="right">1448</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,206</td><td align="right">1,183</td><td align="right">1,183</td><td align="right">1,406</td><td align="right">1,406</td><td align="right">1,414</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 27,303 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,1 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">214,990 ns</td><td align="right" bgcolor="#A8D08D">193,206 ns (Δ = -21,784 ns)</td><td align="right" bgcolor="#FF4949">208,180 ns (Δ = +14,974 ns)</td><td align="right" bgcolor="#A8D08D">197,386 ns (Δ = -10,794 ns)</td><td align="right" bgcolor="#FFFFFF">200,105 ns (Δ = +2,719 ns)</td><td align="right" bgcolor="#A8D08D">187,687 ns (Δ = -12,418 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#A8D08D">0,193 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FF4949">0,208 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,197 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,200 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,188 μs (Δ = -0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 1662,658 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8177,163 ns</td><td align="right" bgcolor="#A8D08D">6904,093 ns (Δ = -1273,070 ns)</td><td align="right" bgcolor="#FFFFFF">7111,807 ns (Δ = +207,713 ns)</td><td align="right" bgcolor="#FF4949">7831,034 ns (Δ = +719,228 ns)</td><td align="right" bgcolor="#FF4949">8566,751 ns (Δ = +735,717 ns)</td><td align="right" bgcolor="#FFFFFF">8367,237 ns (Δ = -199,514 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,177 μs</td><td align="right" bgcolor="#A8D08D">6,904 μs (Δ = -1,273 μs)</td><td align="right" bgcolor="#FFFFFF">7,112 μs (Δ = +0,208 μs)</td><td align="right" bgcolor="#FF4949">7,831 μs (Δ = +0,719 μs)</td><td align="right" bgcolor="#FF4949">8,567 μs (Δ = +0,736 μs)</td><td align="right" bgcolor="#FFFFFF">8,367 μs (Δ = -0,200 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
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
<td>Allocated Bytes</td><td align="right">2736</td><td align="right">2687</td><td align="right">2687</td><td align="right">3145</td><td align="right">3145</td><td align="right">3006</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,672</td><td align="right">2,624</td><td align="right">2,624</td><td align="right">3,071</td><td align="right">3,071</td><td align="right">2,936</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td></tr>
</table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 1,616 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,940 ns</td><td align="right" bgcolor="#FFFFFF">26,753 ns (Δ = -0,187 ns)</td><td align="right" bgcolor="#FFFFFF">27,418 ns (Δ = +0,664 ns)</td><td align="right" bgcolor="#FFFFFF">26,920 ns (Δ = -0,498 ns)</td><td align="right" bgcolor="#A8D08D">25,802 ns (Δ = -1,118 ns)</td><td align="right" bgcolor="#FFFFFF">26,600 ns (Δ = +0,798 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 1,133 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,993 ns</td><td align="right" bgcolor="#FF4949">19,763 ns (Δ = +0,769 ns)</td><td align="right" bgcolor="#FFFFFF">19,503 ns (Δ = -0,259 ns)</td><td align="right" bgcolor="#FFFFFF">19,132 ns (Δ = -0,372 ns)</td><td align="right" bgcolor="#FFFFFF">18,630 ns (Δ = -0,502 ns)</td><td align="right" bgcolor="#FFFFFF">18,910 ns (Δ = +0,280 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FF4949">0,020 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 3,450 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#A8D08D">-14,1 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,816 ns</td><td align="right" bgcolor="#A8D08D">22,750 ns (Δ = -1,066 ns)</td><td align="right" bgcolor="#FF4949">24,490 ns (Δ = +1,740 ns)</td><td align="right" bgcolor="#A8D08D">21,040 ns (Δ = -3,450 ns)</td><td align="right" bgcolor="#FFFFFF">21,629 ns (Δ = +0,589 ns)</td><td align="right" bgcolor="#FFFFFF">21,563 ns (Δ = -0,066 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#A8D08D">0,023 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,024 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 0,602 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,693 ns</td><td align="right" bgcolor="#FFFFFF">30,651 ns (Δ = -0,043 ns)</td><td align="right" bgcolor="#FFFFFF">31,043 ns (Δ = +0,392 ns)</td><td align="right" bgcolor="#FFFFFF">30,641 ns (Δ = -0,403 ns)</td><td align="right" bgcolor="#FFFFFF">31,243 ns (Δ = +0,602 ns)</td><td align="right" bgcolor="#FFFFFF">30,844 ns (Δ = -0,399 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 22,869 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">311,913 ns</td><td align="right" bgcolor="#A8D08D">300,190 ns (Δ = -11,723 ns)</td><td align="right" bgcolor="#FF4949">314,303 ns (Δ = +14,113 ns)</td><td align="right" bgcolor="#FFFFFF">321,923 ns (Δ = +7,620 ns)</td><td align="right" bgcolor="#A8D08D">300,580 ns (Δ = -21,343 ns)</td><td align="right" bgcolor="#FFFFFF">299,054 ns (Δ = -1,526 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#A8D08D">0,300 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FF4949">0,314 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,322 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,301 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,299 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 2,027 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,302 ns</td><td align="right" bgcolor="#FFFFFF">94,513 ns (Δ = -0,789 ns)</td><td align="right" bgcolor="#FFFFFF">94,658 ns (Δ = +0,144 ns)</td><td align="right" bgcolor="#FFFFFF">94,013 ns (Δ = -0,644 ns)</td><td align="right" bgcolor="#FFFFFF">93,276 ns (Δ = -0,738 ns)</td><td align="right" bgcolor="#FFFFFF">93,398 ns (Δ = +0,122 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,095 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,094 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,093 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,093 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 313,730 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3838,307 ns</td><td align="right" bgcolor="#FFFFFF">3928,270 ns (Δ = +89,963 ns)</td><td align="right" bgcolor="#A8D08D">3695,603 ns (Δ = -232,667 ns)</td><td align="right" bgcolor="#FFFFFF">3788,326 ns (Δ = +92,722 ns)</td><td align="right" bgcolor="#FFFFFF">3708,783 ns (Δ = -79,543 ns)</td><td align="right" bgcolor="#FFFFFF">3614,540 ns (Δ = -94,243 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,838 μs</td><td align="right" bgcolor="#FFFFFF">3,928 μs (Δ = +0,090 μs)</td><td align="right" bgcolor="#A8D08D">3,696 μs (Δ = -0,233 μs)</td><td align="right" bgcolor="#FFFFFF">3,788 μs (Δ = +0,093 μs)</td><td align="right" bgcolor="#FFFFFF">3,709 μs (Δ = -0,080 μs)</td><td align="right" bgcolor="#FFFFFF">3,615 μs (Δ = -0,094 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 606,237 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9031,789 ns</td><td align="right" bgcolor="#FFFFFF">9004,917 ns (Δ = -26,872 ns)</td><td align="right" bgcolor="#FFFFFF">8949,180 ns (Δ = -55,737 ns)</td><td align="right" bgcolor="#FFFFFF">8970,596 ns (Δ = +21,416 ns)</td><td align="right" bgcolor="#FFFFFF">9172,027 ns (Δ = +201,431 ns)</td><td align="right" bgcolor="#FF4949">9555,417 ns (Δ = +383,390 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,032 μs</td><td align="right" bgcolor="#FFFFFF">9,005 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FFFFFF">8,949 μs (Δ = -0,056 μs)</td><td align="right" bgcolor="#FFFFFF">8,971 μs (Δ = +0,021 μs)</td><td align="right" bgcolor="#FFFFFF">9,172 μs (Δ = +0,201 μs)</td><td align="right" bgcolor="#FF4949">9,555 μs (Δ = +0,383 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">811</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,792</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 190,927 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3756,433 ns</td><td align="right" bgcolor="#FFFFFF">3836,720 ns (Δ = +80,287 ns)</td><td align="right" bgcolor="#FFFFFF">3834,898 ns (Δ = -1,822 ns)</td><td align="right" bgcolor="#FFFFFF">3809,940 ns (Δ = -24,958 ns)</td><td align="right" bgcolor="#A8D08D">3690,537 ns (Δ = -119,403 ns)</td><td align="right" bgcolor="#FFFFFF">3645,793 ns (Δ = -44,743 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,756 μs</td><td align="right" bgcolor="#FFFFFF">3,837 μs (Δ = +0,080 μs)</td><td align="right" bgcolor="#FFFFFF">3,835 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">3,810 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#A8D08D">3,691 μs (Δ = -0,119 μs)</td><td align="right" bgcolor="#FFFFFF">3,646 μs (Δ = -0,045 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 1114,673 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9038,320 ns</td><td align="right" bgcolor="#FFFFFF">9156,402 ns (Δ = +118,082 ns)</td><td align="right" bgcolor="#FFFFFF">8891,727 ns (Δ = -264,676 ns)</td><td align="right" bgcolor="#FFFFFF">8978,807 ns (Δ = +87,080 ns)</td><td align="right" bgcolor="#FFFFFF">9132,673 ns (Δ = +153,867 ns)</td><td align="right" bgcolor="#FF4949">10006,400 ns (Δ = +873,727 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,038 μs</td><td align="right" bgcolor="#FFFFFF">9,156 μs (Δ = +0,118 μs)</td><td align="right" bgcolor="#FFFFFF">8,892 μs (Δ = -0,265 μs)</td><td align="right" bgcolor="#FFFFFF">8,979 μs (Δ = +0,087 μs)</td><td align="right" bgcolor="#FFFFFF">9,133 μs (Δ = +0,154 μs)</td><td align="right" bgcolor="#FF4949">10,006 μs (Δ = +0,874 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">811</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,792</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 1,163 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+5,5 %</td><td align="right" bgcolor="#A8D08D">-11,9 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+9,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,991 ns</td><td align="right" bgcolor="#FF4949">8,297 ns (Δ = +0,306 ns)</td><td align="right" bgcolor="#FF4949">8,753 ns (Δ = +0,457 ns)</td><td align="right" bgcolor="#A8D08D">7,709 ns (Δ = -1,044 ns)</td><td align="right" bgcolor="#FFFFFF">7,590 ns (Δ = -0,119 ns)</td><td align="right" bgcolor="#FF4949">8,286 ns (Δ = +0,696 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,008 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 169,923 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,3 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">873,520 ns</td><td align="right" bgcolor="#A8D08D">748,287 ns (Δ = -125,233 ns)</td><td align="right" bgcolor="#A8D08D">717,579 ns (Δ = -30,707 ns)</td><td align="right" bgcolor="#FFFFFF">703,597 ns (Δ = -13,983 ns)</td><td align="right" bgcolor="#FFFFFF">707,903 ns (Δ = +4,307 ns)</td><td align="right" bgcolor="#FFFFFF">705,217 ns (Δ = -2,687 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,874 μs</td><td align="right" bgcolor="#A8D08D">0,748 μs (Δ = -0,125 μs)</td><td align="right" bgcolor="#A8D08D">0,718 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FFFFFF">0,704 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,708 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,705 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 37,800 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,3 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">161,905 ns</td><td align="right" bgcolor="#A8D08D">137,143 ns (Δ = -24,763 ns)</td><td align="right" bgcolor="#FFFFFF">137,344 ns (Δ = +0,202 ns)</td><td align="right" bgcolor="#FFFFFF">137,150 ns (Δ = -0,194 ns)</td><td align="right" bgcolor="#A8D08D">124,105 ns (Δ = -13,045 ns)</td><td align="right" bgcolor="#FFFFFF">127,407 ns (Δ = +3,302 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#A8D08D">0,137 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FFFFFF">0,137 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,137 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,124 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 470,290 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-15,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3008,697 ns</td><td align="right" bgcolor="#A8D08D">2906,390 ns (Δ = -102,307 ns)</td><td align="right" bgcolor="#FFFFFF">2958,397 ns (Δ = +52,007 ns)</td><td align="right" bgcolor="#FFFFFF">2927,256 ns (Δ = -31,141 ns)</td><td align="right" bgcolor="#FFFFFF">2998,737 ns (Δ = +71,481 ns)</td><td align="right" bgcolor="#A8D08D">2538,407 ns (Δ = -460,330 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,009 μs</td><td align="right" bgcolor="#A8D08D">2,906 μs (Δ = -0,102 μs)</td><td align="right" bgcolor="#FFFFFF">2,958 μs (Δ = +0,052 μs)</td><td align="right" bgcolor="#FFFFFF">2,927 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FFFFFF">2,999 μs (Δ = +0,071 μs)</td><td align="right" bgcolor="#A8D08D">2,538 μs (Δ = -0,460 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">205</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 202,377 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#A8D08D">-13,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1263,051 ns</td><td align="right" bgcolor="#FFFFFF">1297,743 ns (Δ = +34,692 ns)</td><td align="right" bgcolor="#FFFFFF">1260,983 ns (Δ = -36,760 ns)</td><td align="right" bgcolor="#FFFFFF">1278,942 ns (Δ = +17,959 ns)</td><td align="right" bgcolor="#FFFFFF">1268,123 ns (Δ = -10,819 ns)</td><td align="right" bgcolor="#A8D08D">1095,367 ns (Δ = -172,757 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,263 μs</td><td align="right" bgcolor="#FFFFFF">1,298 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FFFFFF">1,261 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FFFFFF">1,279 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FFFFFF">1,268 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">1,095 μs (Δ = -0,173 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">410</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,400</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 252,742 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#A8D08D">-28,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">771,235 ns</td><td align="right" bgcolor="#FFFFFF">763,360 ns (Δ = -7,875 ns)</td><td align="right" bgcolor="#FFFFFF">752,902 ns (Δ = -10,458 ns)</td><td align="right" bgcolor="#FFFFFF">757,713 ns (Δ = +4,811 ns)</td><td align="right" bgcolor="#A8D08D">728,877 ns (Δ = -28,837 ns)</td><td align="right" bgcolor="#A8D08D">518,493 ns (Δ = -210,383 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,771 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,753 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,758 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,729 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#A8D08D">0,518 μs (Δ = -0,210 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">311</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,304</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 190,014 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,3 %</td><td align="right" bgcolor="#A8D08D">-21,0 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">717,627 ns</td><td align="right" bgcolor="#FF4949">906,327 ns (Δ = +188,700 ns)</td><td align="right" bgcolor="#A8D08D">716,313 ns (Δ = -190,014 ns)</td><td align="right" bgcolor="#FFFFFF">724,018 ns (Δ = +7,705 ns)</td><td align="right" bgcolor="#FFFFFF">723,190 ns (Δ = -0,828 ns)</td><td align="right" bgcolor="#FFFFFF">721,420 ns (Δ = -1,770 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td><td align="right" bgcolor="#FF4949">0,906 μs (Δ = +0,189 μs)</td><td align="right" bgcolor="#A8D08D">0,716 μs (Δ = -0,190 μs)</td><td align="right" bgcolor="#FFFFFF">0,724 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,723 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,721 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 62,759 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,7 %</td><td align="right" bgcolor="#A8D08D">-30,4 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">157,787 ns</td><td align="right" bgcolor="#FF4949">206,250 ns (Δ = +48,463 ns)</td><td align="right" bgcolor="#A8D08D">143,491 ns (Δ = -62,759 ns)</td><td align="right" bgcolor="#FFFFFF">146,678 ns (Δ = +3,187 ns)</td><td align="right" bgcolor="#FF4949">160,693 ns (Δ = +14,015 ns)</td><td align="right" bgcolor="#FFFFFF">159,573 ns (Δ = -1,120 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FF4949">0,206 μs (Δ = +0,048 μs)</td><td align="right" bgcolor="#A8D08D">0,143 μs (Δ = -0,063 μs)</td><td align="right" bgcolor="#FFFFFF">0,147 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,161 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,160 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 19,305 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FF4949">+12,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">160,058 ns</td><td align="right" bgcolor="#FF4949">173,870 ns (Δ = +13,812 ns)</td><td align="right" bgcolor="#A8D08D">157,415 ns (Δ = -16,455 ns)</td><td align="right" bgcolor="#FFFFFF">160,837 ns (Δ = +3,422 ns)</td><td align="right" bgcolor="#A8D08D">155,865 ns (Δ = -4,972 ns)</td><td align="right" bgcolor="#FF4949">175,170 ns (Δ = +19,305 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td><td align="right" bgcolor="#FF4949">0,174 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,157 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,161 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,156 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,175 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 36,286 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,8 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#FF4949">+25,4 %</td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">176,623 ns</td><td align="right" bgcolor="#A8D08D">150,454 ns (Δ = -26,169 ns)</td><td align="right" bgcolor="#A8D08D">142,958 ns (Δ = -7,496 ns)</td><td align="right" bgcolor="#FF4949">179,243 ns (Δ = +36,286 ns)</td><td align="right" bgcolor="#A8D08D">147,698 ns (Δ = -31,546 ns)</td><td align="right" bgcolor="#FFFFFF">148,133 ns (Δ = +0,436 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#A8D08D">0,150 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#A8D08D">0,143 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,179 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#A8D08D">0,148 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FFFFFF">0,148 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 39,543 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">590,609 ns</td><td align="right" bgcolor="#FFFFFF">582,580 ns (Δ = -8,029 ns)</td><td align="right" bgcolor="#FFFFFF">567,350 ns (Δ = -15,230 ns)</td><td align="right" bgcolor="#FFFFFF">584,180 ns (Δ = +16,830 ns)</td><td align="right" bgcolor="#FFFFFF">588,777 ns (Δ = +4,597 ns)</td><td align="right" bgcolor="#FFFFFF">606,893 ns (Δ = +18,117 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td><td align="right" bgcolor="#FFFFFF">0,583 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,567 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,584 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,589 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,607 μs (Δ = +0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">279</td><td align="right">319</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,272</td><td align="right">0,312</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 13,517 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#A8D08D">-7,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">133,691 ns</td><td align="right" bgcolor="#FFFFFF">134,272 ns (Δ = +0,581 ns)</td><td align="right" bgcolor="#FFFFFF">135,187 ns (Δ = +0,915 ns)</td><td align="right" bgcolor="#FFFFFF">133,852 ns (Δ = -1,335 ns)</td><td align="right" bgcolor="#FFFFFF">131,312 ns (Δ = -2,540 ns)</td><td align="right" bgcolor="#A8D08D">121,669 ns (Δ = -9,643 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,135 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,134 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,131 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,122 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 80,382 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FF4949">+9,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">883,833 ns</td><td align="right" bgcolor="#FFFFFF">866,473 ns (Δ = -17,360 ns)</td><td align="right" bgcolor="#FF4949">897,402 ns (Δ = +30,929 ns)</td><td align="right" bgcolor="#FFFFFF">889,773 ns (Δ = -7,629 ns)</td><td align="right" bgcolor="#A8D08D">862,223 ns (Δ = -27,551 ns)</td><td align="right" bgcolor="#FF4949">942,604 ns (Δ = +80,382 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td><td align="right" bgcolor="#FFFFFF">0,866 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FF4949">0,897 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">0,890 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,862 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,943 μs (Δ = +0,080 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">336</td><td align="right">360</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,328</td><td align="right">0,352</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 23,215 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FF4949">+13,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,905 ns</td><td align="right" bgcolor="#FFFFFF">131,663 ns (Δ = +2,758 ns)</td><td align="right" bgcolor="#FFFFFF">130,764 ns (Δ = -0,899 ns)</td><td align="right" bgcolor="#FF4949">139,398 ns (Δ = +8,633 ns)</td><td align="right" bgcolor="#A8D08D">134,607 ns (Δ = -4,791 ns)</td><td align="right" bgcolor="#FF4949">152,120 ns (Δ = +17,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,131 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,139 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,135 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,152 μs (Δ = +0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 47,248 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,0 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FF4949">+27,8 %</td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">160,418 ns</td><td align="right" bgcolor="#FF4949">171,653 ns (Δ = +11,236 ns)</td><td align="right" bgcolor="#A8D08D">160,347 ns (Δ = -11,307 ns)</td><td align="right" bgcolor="#FF4949">204,863 ns (Δ = +44,517 ns)</td><td align="right" bgcolor="#A8D08D">157,616 ns (Δ = -47,248 ns)</td><td align="right" bgcolor="#FFFFFF">158,384 ns (Δ = +0,769 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td><td align="right" bgcolor="#FF4949">0,172 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,160 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,205 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#A8D08D">0,158 μs (Δ = -0,047 μs)</td><td align="right" bgcolor="#FFFFFF">0,158 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 6,512 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,499 ns</td><td align="right" bgcolor="#FFFFFF">105,163 ns (Δ = +0,664 ns)</td><td align="right" bgcolor="#FFFFFF">103,543 ns (Δ = -1,621 ns)</td><td align="right" bgcolor="#FF4949">110,054 ns (Δ = +6,512 ns)</td><td align="right" bgcolor="#A8D08D">105,347 ns (Δ = -4,708 ns)</td><td align="right" bgcolor="#FFFFFF">104,867 ns (Δ = -0,480 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,104 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,110 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,105 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,105 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 33,283 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,5 %</td><td align="right" bgcolor="#FF4949">+7,7 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td><td align="right" bgcolor="#A8D08D">-15,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">200,187 ns</td><td align="right" bgcolor="#A8D08D">187,158 ns (Δ = -13,029 ns)</td><td align="right" bgcolor="#FF4949">201,503 ns (Δ = +14,345 ns)</td><td align="right" bgcolor="#A8D08D">193,311 ns (Δ = -8,192 ns)</td><td align="right" bgcolor="#FFFFFF">199,250 ns (Δ = +5,939 ns)</td><td align="right" bgcolor="#A8D08D">168,220 ns (Δ = -31,030 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#A8D08D">0,187 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">0,202 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,193 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,199 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,168 μs (Δ = -0,031 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">197</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,192</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 38,810 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1374,667 ns</td><td align="right" bgcolor="#FFFFFF">1370,210 ns (Δ = -4,457 ns)</td><td align="right" bgcolor="#FFFFFF">1409,020 ns (Δ = +38,810 ns)</td><td align="right" bgcolor="#FFFFFF">1376,356 ns (Δ = -32,664 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,375 μs</td><td align="right" bgcolor="#FFFFFF">1,370 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">1,409 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#FFFFFF">1,376 μs (Δ = -0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">270</td><td align="right">270</td><td align="right">270</td><td align="right">270</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,264</td><td align="right">0,264</td><td align="right">0,264</td><td align="right">0,264</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 39,302 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">772,268 ns</td><td align="right" bgcolor="#FFFFFF">777,732 ns (Δ = +5,463 ns)</td><td align="right" bgcolor="#FFFFFF">757,400 ns (Δ = -20,332 ns)</td><td align="right" bgcolor="#FFFFFF">738,430 ns (Δ = -18,970 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,772 μs</td><td align="right" bgcolor="#FFFFFF">0,778 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,757 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">0,738 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 51,784 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+6,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">774,357 ns</td><td align="right" bgcolor="#FFFFFF">778,171 ns (Δ = +3,814 ns)</td><td align="right" bgcolor="#FFFFFF">775,675 ns (Δ = -2,496 ns)</td><td align="right" bgcolor="#FF4949">826,141 ns (Δ = +50,466 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,774 μs</td><td align="right" bgcolor="#FFFFFF">0,778 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,776 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,826 μs (Δ = +0,050 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">41</td><td align="right">41</td><td align="right">41</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,040</td><td align="right">0,040</td><td align="right">0,040</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 28,366 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">761,402 ns</td><td align="right" bgcolor="#FFFFFF">748,232 ns (Δ = -13,170 ns)</td><td align="right" bgcolor="#FFFFFF">747,522 ns (Δ = -0,710 ns)</td><td align="right" bgcolor="#FFFFFF">733,037 ns (Δ = -14,485 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,761 μs</td><td align="right" bgcolor="#FFFFFF">0,748 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,748 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,733 μs (Δ = -0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 66,741 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#A8D08D">-8,4 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">742,035 ns</td><td align="right" bgcolor="#FF4949">790,571 ns (Δ = +48,536 ns)</td><td align="right" bgcolor="#A8D08D">723,830 ns (Δ = -66,741 ns)</td><td align="right" bgcolor="#FF4949">746,530 ns (Δ = +22,700 ns)</td><td align="right" bgcolor="#FFFFFF">739,960 ns (Δ = -6,570 ns)</td><td align="right" bgcolor="#FFFFFF">744,303 ns (Δ = +4,343 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,742 μs</td><td align="right" bgcolor="#FF4949">0,791 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">0,724 μs (Δ = -0,067 μs)</td><td align="right" bgcolor="#FF4949">0,747 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,740 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,744 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 30,088 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FF4949">+9,2 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">171,142 ns</td><td align="right" bgcolor="#FFFFFF">170,032 ns (Δ = -1,111 ns)</td><td align="right" bgcolor="#FFFFFF">165,337 ns (Δ = -4,695 ns)</td><td align="right" bgcolor="#FF4949">180,597 ns (Δ = +15,260 ns)</td><td align="right" bgcolor="#FFFFFF">181,333 ns (Δ = +0,737 ns)</td><td align="right" bgcolor="#A8D08D">151,246 ns (Δ = -30,088 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,165 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,181 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,181 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,151 μs (Δ = -0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 18,303 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">187,630 ns</td><td align="right" bgcolor="#FF4949">198,757 ns (Δ = +11,127 ns)</td><td align="right" bgcolor="#A8D08D">183,333 ns (Δ = -15,423 ns)</td><td align="right" bgcolor="#FFFFFF">187,178 ns (Δ = +3,845 ns)</td><td align="right" bgcolor="#FFFFFF">186,794 ns (Δ = -0,384 ns)</td><td align="right" bgcolor="#A8D08D">180,453 ns (Δ = -6,341 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FF4949">0,199 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,183 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,187 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,187 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,180 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 17,409 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FF4949">+5,5 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td><td align="right" bgcolor="#A8D08D">-8,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">177,067 ns</td><td align="right" bgcolor="#A8D08D">167,734 ns (Δ = -9,332 ns)</td><td align="right" bgcolor="#FF4949">177,027 ns (Δ = +9,292 ns)</td><td align="right" bgcolor="#A8D08D">169,833 ns (Δ = -7,194 ns)</td><td align="right" bgcolor="#FF4949">185,143 ns (Δ = +15,311 ns)</td><td align="right" bgcolor="#A8D08D">168,796 ns (Δ = -16,348 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#A8D08D">0,168 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FF4949">0,177 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,170 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,185 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,169 μs (Δ = -0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2051,920 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#A8D08D">-24,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8049,023 ns</td><td align="right" bgcolor="#FFFFFF">8200,140 ns (Δ = +151,117 ns)</td><td align="right" bgcolor="#FFFFFF">8078,458 ns (Δ = -121,682 ns)</td><td align="right" bgcolor="#FFFFFF">8120,363 ns (Δ = +41,906 ns)</td><td align="right" bgcolor="#FFFFFF">8245,118 ns (Δ = +124,754 ns)</td><td align="right" bgcolor="#A8D08D">6193,198 ns (Δ = -2051,920 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,049 μs</td><td align="right" bgcolor="#FFFFFF">8,200 μs (Δ = +0,151 μs)</td><td align="right" bgcolor="#FFFFFF">8,078 μs (Δ = -0,122 μs)</td><td align="right" bgcolor="#FFFFFF">8,120 μs (Δ = +0,042 μs)</td><td align="right" bgcolor="#FFFFFF">8,245 μs (Δ = +0,125 μs)</td><td align="right" bgcolor="#A8D08D">6,193 μs (Δ = -2,052 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2900</td><td align="right">2900</td><td align="right">2899</td><td align="right">2900</td><td align="right">2978</td><td align="right">2228</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,832</td><td align="right">2,832</td><td align="right">2,831</td><td align="right">2,832</td><td align="right">2,908</td><td align="right">2,176</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,002</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 391,204 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#A8D08D">-25,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1498,304 ns</td><td align="right" bgcolor="#FFFFFF">1499,296 ns (Δ = +0,991 ns)</td><td align="right" bgcolor="#FFFFFF">1491,297 ns (Δ = -7,999 ns)</td><td align="right" bgcolor="#FFFFFF">1522,143 ns (Δ = +30,847 ns)</td><td align="right" bgcolor="#FFFFFF">1539,793 ns (Δ = +17,650 ns)</td><td align="right" bgcolor="#A8D08D">1148,589 ns (Δ = -391,204 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,498 μs</td><td align="right" bgcolor="#FFFFFF">1,499 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">1,491 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">1,522 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">1,540 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#A8D08D">1,149 μs (Δ = -0,391 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2026,857 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#A8D08D">-26,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7636,927 ns</td><td align="right" bgcolor="#FFFFFF">7649,253 ns (Δ = +12,327 ns)</td><td align="right" bgcolor="#FFFFFF">7616,140 ns (Δ = -33,113 ns)</td><td align="right" bgcolor="#FFFFFF">7573,789 ns (Δ = -42,351 ns)</td><td align="right" bgcolor="#FFFFFF">7662,987 ns (Δ = +89,198 ns)</td><td align="right" bgcolor="#A8D08D">5636,130 ns (Δ = -2026,857 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,637 μs</td><td align="right" bgcolor="#FFFFFF">7,649 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FFFFFF">7,616 μs (Δ = -0,033 μs)</td><td align="right" bgcolor="#FFFFFF">7,574 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#FFFFFF">7,663 μs (Δ = +0,089 μs)</td><td align="right" bgcolor="#A8D08D">5,636 μs (Δ = -2,027 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">5005</td><td align="right">5005</td><td align="right">5005</td><td align="right">5005</td><td align="right">5117</td><td align="right">3724</td><tr>
<td>Allocated Kilobytes</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,997</td><td align="right">3,637</td><tr>
<td>Allocated Megabytes</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,004</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 632,153 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#FF4949">+38,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1540,856 ns</td><td align="right" bgcolor="#FFFFFF">1531,865 ns (Δ = -8,991 ns)</td><td align="right" bgcolor="#FFFFFF">1543,940 ns (Δ = +12,075 ns)</td><td align="right" bgcolor="#FFFFFF">1532,607 ns (Δ = -11,333 ns)</td><td align="right" bgcolor="#FFFFFF">1560,417 ns (Δ = +27,810 ns)</td><td align="right" bgcolor="#FF4949">2164,018 ns (Δ = +603,601 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,541 μs</td><td align="right" bgcolor="#FFFFFF">1,532 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">1,544 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FFFFFF">1,533 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FFFFFF">1,560 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FF4949">2,164 μs (Δ = +0,604 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 15,342 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">837,080 ns</td><td align="right" bgcolor="#FFFFFF">823,342 ns (Δ = -13,738 ns)</td><td align="right" bgcolor="#FFFFFF">825,331 ns (Δ = +1,989 ns)</td><td align="right" bgcolor="#FFFFFF">835,718 ns (Δ = +10,387 ns)</td><td align="right" bgcolor="#FFFFFF">821,738 ns (Δ = -13,980 ns)</td><td align="right" bgcolor="#FFFFFF">822,446 ns (Δ = +0,708 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td><td align="right" bgcolor="#FFFFFF">0,823 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,825 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,836 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,822 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,822 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">270</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,264</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 112,969 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1636,877 ns</td><td align="right" bgcolor="#FFFFFF">1665,120 ns (Δ = +28,243 ns)</td><td align="right" bgcolor="#FFFFFF">1663,884 ns (Δ = -1,236 ns)</td><td align="right" bgcolor="#FFFFFF">1655,320 ns (Δ = -8,564 ns)</td><td align="right" bgcolor="#FFFFFF">1699,751 ns (Δ = +44,431 ns)</td><td align="right" bgcolor="#A8D08D">1586,782 ns (Δ = -112,969 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,637 μs</td><td align="right" bgcolor="#FFFFFF">1,665 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FFFFFF">1,664 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">1,655 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">1,700 μs (Δ = +0,044 μs)</td><td align="right" bgcolor="#A8D08D">1,587 μs (Δ = -0,113 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">655</td><td align="right">655</td><td align="right">655</td><td align="right">655</td><td align="right">672</td><td align="right">623</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,656</td><td align="right">0,608</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 93,390 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#A8D08D">-8,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1047,628 ns</td><td align="right" bgcolor="#FFFFFF">1017,803 ns (Δ = -29,824 ns)</td><td align="right" bgcolor="#FFFFFF">1019,094 ns (Δ = +1,291 ns)</td><td align="right" bgcolor="#FFFFFF">1024,302 ns (Δ = +5,207 ns)</td><td align="right" bgcolor="#FF4949">1066,403 ns (Δ = +42,102 ns)</td><td align="right" bgcolor="#A8D08D">973,013 ns (Δ = -93,390 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,048 μs</td><td align="right" bgcolor="#FFFFFF">1,018 μs (Δ = -0,030 μs)</td><td align="right" bgcolor="#FFFFFF">1,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">1,024 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FF4949">1,066 μs (Δ = +0,042 μs)</td><td align="right" bgcolor="#A8D08D">0,973 μs (Δ = -0,093 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">713</td><td align="right">713</td><td align="right">713</td><td align="right">713</td><td align="right">737</td><td align="right">664</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,720</td><td align="right">0,648</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 12,973 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">305,960 ns</td><td align="right" bgcolor="#FFFFFF">311,837 ns (Δ = +5,877 ns)</td><td align="right" bgcolor="#FFFFFF">310,607 ns (Δ = -1,230 ns)</td><td align="right" bgcolor="#FFFFFF">317,707 ns (Δ = +7,100 ns)</td><td align="right" bgcolor="#A8D08D">306,773 ns (Δ = -10,933 ns)</td><td align="right" bgcolor="#FFFFFF">304,733 ns (Δ = -2,040 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,311 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,318 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,307 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,305 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">41</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,040</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 28,083 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">725,624 ns</td><td align="right" bgcolor="#FF4949">752,813 ns (Δ = +27,189 ns)</td><td align="right" bgcolor="#A8D08D">724,730 ns (Δ = -28,083 ns)</td><td align="right" bgcolor="#FF4949">752,511 ns (Δ = +27,781 ns)</td><td align="right" bgcolor="#FFFFFF">732,098 ns (Δ = -20,413 ns)</td><td align="right" bgcolor="#FFFFFF">733,241 ns (Δ = +1,143 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FF4949">0,753 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#A8D08D">0,725 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,753 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FFFFFF">0,732 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">0,733 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 24,542 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FF4949">+10,7 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#FF4949">+4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">183,938 ns</td><td align="right" bgcolor="#A8D08D">173,145 ns (Δ = -10,793 ns)</td><td align="right" bgcolor="#FF4949">191,680 ns (Δ = +18,535 ns)</td><td align="right" bgcolor="#A8D08D">176,685 ns (Δ = -14,995 ns)</td><td align="right" bgcolor="#FF4949">188,409 ns (Δ = +11,724 ns)</td><td align="right" bgcolor="#FF4949">197,687 ns (Δ = +9,278 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#A8D08D">0,173 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,192 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#A8D08D">0,177 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">0,188 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">0,198 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 448,842 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-14,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2965,593 ns</td><td align="right" bgcolor="#FFFFFF">2967,410 ns (Δ = +1,818 ns)</td><td align="right" bgcolor="#FFFFFF">2952,439 ns (Δ = -14,971 ns)</td><td align="right" bgcolor="#FFFFFF">3008,913 ns (Δ = +56,474 ns)</td><td align="right" bgcolor="#FFFFFF">3020,576 ns (Δ = +11,662 ns)</td><td align="right" bgcolor="#A8D08D">2571,733 ns (Δ = -448,842 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,966 μs</td><td align="right" bgcolor="#FFFFFF">2,967 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">2,952 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">3,009 μs (Δ = +0,056 μs)</td><td align="right" bgcolor="#FFFFFF">3,021 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">2,572 μs (Δ = -0,449 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">205</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 11,120 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-5,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">207,737 ns</td><td align="right" bgcolor="#FF4949">216,137 ns (Δ = +8,400 ns)</td><td align="right" bgcolor="#A8D08D">205,017 ns (Δ = -11,120 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FF4949">0,216 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,205 μs (Δ = -0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">311</td><td align="right">311</td><td align="right">311</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,304</td><td align="right">0,304</td><td align="right">0,304</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 0,602 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,683 ns</td><td align="right" bgcolor="#FFFFFF">14,580 ns (Δ = -0,103 ns)</td><td align="right" bgcolor="#FFFFFF">15,010 ns (Δ = +0,430 ns)</td><td align="right" bgcolor="#FFFFFF">15,182 ns (Δ = +0,172 ns)</td><td align="right" bgcolor="#A8D08D">14,589 ns (Δ = -0,593 ns)</td><td align="right" bgcolor="#FF4949">15,159 ns (Δ = +0,570 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 1,140 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,040 ns</td><td align="right" bgcolor="#FFFFFF">36,727 ns (Δ = -0,313 ns)</td><td align="right" bgcolor="#FFFFFF">35,900 ns (Δ = -0,827 ns)</td><td align="right" bgcolor="#FFFFFF">36,743 ns (Δ = +0,843 ns)</td><td align="right" bgcolor="#FFFFFF">36,121 ns (Δ = -0,622 ns)</td><td align="right" bgcolor="#FFFFFF">36,430 ns (Δ = +0,309 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 10,105 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td><td align="right" bgcolor="#A8D08D">-20,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,070 ns</td><td align="right" bgcolor="#FF4949">41,880 ns (Δ = +1,810 ns)</td><td align="right" bgcolor="#A8D08D">40,526 ns (Δ = -1,354 ns)</td><td align="right" bgcolor="#FFFFFF">41,133 ns (Δ = +0,608 ns)</td><td align="right" bgcolor="#FF4949">48,500 ns (Δ = +7,367 ns)</td><td align="right" bgcolor="#A8D08D">38,395 ns (Δ = -10,105 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FF4949">0,042 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,049 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,038 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 1,526 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,411 ns</td><td align="right" bgcolor="#FFFFFF">35,588 ns (Δ = -0,824 ns)</td><td align="right" bgcolor="#FFFFFF">36,627 ns (Δ = +1,039 ns)</td><td align="right" bgcolor="#FFFFFF">36,731 ns (Δ = +0,104 ns)</td><td align="right" bgcolor="#FFFFFF">37,113 ns (Δ = +0,382 ns)</td><td align="right" bgcolor="#A8D08D">35,618 ns (Δ = -1,496 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,036 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 0,819 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#A8D08D">-5,1 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,723 ns</td><td align="right" bgcolor="#FFFFFF">15,810 ns (Δ = +0,087 ns)</td><td align="right" bgcolor="#FFFFFF">15,680 ns (Δ = -0,130 ns)</td><td align="right" bgcolor="#FFFFFF">15,924 ns (Δ = +0,244 ns)</td><td align="right" bgcolor="#A8D08D">15,106 ns (Δ = -0,819 ns)</td><td align="right" bgcolor="#FFFFFF">15,156 ns (Δ = +0,050 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 1,609 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,180 ns</td><td align="right" bgcolor="#FF4949">21,623 ns (Δ = +1,443 ns)</td><td align="right" bgcolor="#FFFFFF">21,216 ns (Δ = -0,408 ns)</td><td align="right" bgcolor="#FFFFFF">21,789 ns (Δ = +0,573 ns)</td><td align="right" bgcolor="#A8D08D">20,983 ns (Δ = -0,806 ns)</td><td align="right" bgcolor="#FFFFFF">20,669 ns (Δ = -0,314 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FF4949">0,022 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,021 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,021 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 10,803 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#FF4949">+38,8 %</td><td align="right" bgcolor="#A8D08D">-29,1 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,400 ns</td><td align="right" bgcolor="#A8D08D">25,220 ns (Δ = -1,180 ns)</td><td align="right" bgcolor="#FFFFFF">25,960 ns (Δ = +0,740 ns)</td><td align="right" bgcolor="#FF4949">36,023 ns (Δ = +10,063 ns)</td><td align="right" bgcolor="#A8D08D">25,547 ns (Δ = -10,476 ns)</td><td align="right" bgcolor="#FFFFFF">25,809 ns (Δ = +0,262 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#A8D08D">0,025 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,036 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 14,965 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">467,813 ns</td><td align="right" bgcolor="#FFFFFF">461,018 ns (Δ = -6,795 ns)</td><td align="right" bgcolor="#FFFFFF">467,657 ns (Δ = +6,638 ns)</td><td align="right" bgcolor="#FFFFFF">470,327 ns (Δ = +2,670 ns)</td><td align="right" bgcolor="#FFFFFF">475,983 ns (Δ = +5,657 ns)</td><td align="right" bgcolor="#FFFFFF">473,443 ns (Δ = -2,540 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,468 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,468 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,470 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,476 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,473 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 46,938 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+29,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,884 ns</td><td align="right" bgcolor="#FFFFFF">152,722 ns (Δ = -4,162 ns)</td><td align="right" bgcolor="#FFFFFF">148,898 ns (Δ = -3,824 ns)</td><td align="right" bgcolor="#FFFFFF">149,942 ns (Δ = +1,043 ns)</td><td align="right" bgcolor="#FFFFFF">151,024 ns (Δ = +1,083 ns)</td><td align="right" bgcolor="#FF4949">195,837 ns (Δ = +44,812 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,149 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,150 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,151 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,196 μs (Δ = +0,045 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 6,359 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,2 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,233 ns</td><td align="right" bgcolor="#A8D08D">26,373 ns (Δ = -5,860 ns)</td><td align="right" bgcolor="#FF4949">27,324 ns (Δ = +0,951 ns)</td><td align="right" bgcolor="#A8D08D">25,874 ns (Δ = -1,450 ns)</td><td align="right" bgcolor="#FFFFFF">26,180 ns (Δ = +0,306 ns)</td><td align="right" bgcolor="#FF4949">27,220 ns (Δ = +1,040 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,027 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,027 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 11,367 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#FF4949">+28,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,597 ns</td><td align="right" bgcolor="#FF4949">34,157 ns (Δ = +3,560 ns)</td><td align="right" bgcolor="#FFFFFF">34,876 ns (Δ = +0,719 ns)</td><td align="right" bgcolor="#FFFFFF">34,351 ns (Δ = -0,525 ns)</td><td align="right" bgcolor="#A8D08D">32,740 ns (Δ = -1,611 ns)</td><td align="right" bgcolor="#FF4949">41,963 ns (Δ = +9,223 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FF4949">0,034 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,035 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,034 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,033 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,042 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 1,866 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#A8D08D">-18,2 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,975 ns</td><td align="right" bgcolor="#FFFFFF">10,240 ns (Δ = +0,265 ns)</td><td align="right" bgcolor="#A8D08D">8,374 ns (Δ = -1,866 ns)</td><td align="right" bgcolor="#FF4949">8,690 ns (Δ = +0,316 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 2,853 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,3 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#A8D08D">-20,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,860 ns</td><td align="right" bgcolor="#FF4949">10,383 ns (Δ = +0,523 ns)</td><td align="right" bgcolor="#FFFFFF">10,373 ns (Δ = -0,010 ns)</td><td align="right" bgcolor="#FFFFFF">10,430 ns (Δ = +0,058 ns)</td><td align="right" bgcolor="#A8D08D">9,567 ns (Δ = -0,863 ns)</td><td align="right" bgcolor="#A8D08D">7,578 ns (Δ = -1,989 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 17417,008 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30412,069 ns</td><td align="right" bgcolor="#FF4949">32396,106 ns (Δ = +1984,037 ns)</td><td align="right" bgcolor="#A8D08D">31038,272 ns (Δ = -1357,833 ns)</td><td align="right" bgcolor="#FF4949">32635,579 ns (Δ = +1597,307 ns)</td><td align="right" bgcolor="#FFFFFF">31708,788 ns (Δ = -926,792 ns)</td><td align="right" bgcolor="#A8D08D">15218,572 ns (Δ = -16490,216 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">30,412 μs</td><td align="right" bgcolor="#FF4949">32,396 μs (Δ = +1,984 μs)</td><td align="right" bgcolor="#A8D08D">31,038 μs (Δ = -1,358 μs)</td><td align="right" bgcolor="#FF4949">32,636 μs (Δ = +1,597 μs)</td><td align="right" bgcolor="#FFFFFF">31,709 μs (Δ = -0,927 μs)</td><td align="right" bgcolor="#A8D08D">15,219 μs (Δ = -16,490 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#FF4949">0,032 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,031 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,033 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#FFFFFF">0,032 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,015 ms (Δ = -0,016 ms)</td></tr>
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
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">2</td><td align="right">2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7870</td><td align="right">7966</td><td align="right">7965</td><td align="right">7861</td><td align="right">7853</td><td align="right">5813</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,686</td><td align="right">7,779</td><td align="right">7,778</td><td align="right">7,677</td><td align="right">7,669</td><td align="right">5,677</td><tr>
<td>Allocated Megabytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 1,700 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,653 ns</td><td align="right" bgcolor="#FF4949">12,393 ns (Δ = +0,740 ns)</td><td align="right" bgcolor="#A8D08D">11,703 ns (Δ = -0,690 ns)</td><td align="right" bgcolor="#FFFFFF">11,604 ns (Δ = -0,099 ns)</td><td align="right" bgcolor="#A8D08D">10,693 ns (Δ = -0,911 ns)</td><td align="right" bgcolor="#FFFFFF">10,990 ns (Δ = +0,297 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FF4949">0,012 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,012 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,011 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 2,913 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,7 %</td><td align="right" bgcolor="#A8D08D">-14,8 %</td><td align="right" bgcolor="#FF4949">+16,0 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,607 ns</td><td align="right" bgcolor="#FF4949">15,883 ns (Δ = +2,277 ns)</td><td align="right" bgcolor="#A8D08D">13,537 ns (Δ = -2,347 ns)</td><td align="right" bgcolor="#FF4949">15,707 ns (Δ = +2,170 ns)</td><td align="right" bgcolor="#FF4949">16,450 ns (Δ = +0,743 ns)</td><td align="right" bgcolor="#A8D08D">15,359 ns (Δ = -1,091 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 0,963 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,247 ns</td><td align="right" bgcolor="#A8D08D">14,283 ns (Δ = -0,963 ns)</td><td align="right" bgcolor="#FF4949">15,093 ns (Δ = +0,810 ns)</td><td align="right" bgcolor="#FFFFFF">14,851 ns (Δ = -0,242 ns)</td><td align="right" bgcolor="#FFFFFF">14,627 ns (Δ = -0,224 ns)</td><td align="right" bgcolor="#FFFFFF">14,290 ns (Δ = -0,337 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 0,634 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,891 ns</td><td align="right" bgcolor="#FFFFFF">15,802 ns (Δ = -0,089 ns)</td><td align="right" bgcolor="#FFFFFF">15,493 ns (Δ = -0,309 ns)</td><td align="right" bgcolor="#FFFFFF">15,420 ns (Δ = -0,073 ns)</td><td align="right" bgcolor="#FFFFFF">15,440 ns (Δ = +0,020 ns)</td><td align="right" bgcolor="#FFFFFF">15,257 ns (Δ = -0,183 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 0,963 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,337 ns</td><td align="right" bgcolor="#FF4949">17,047 ns (Δ = +0,710 ns)</td><td align="right" bgcolor="#FFFFFF">16,919 ns (Δ = -0,128 ns)</td><td align="right" bgcolor="#FFFFFF">16,694 ns (Δ = -0,225 ns)</td><td align="right" bgcolor="#FF4949">17,300 ns (Δ = +0,606 ns)</td><td align="right" bgcolor="#A8D08D">16,580 ns (Δ = -0,720 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FF4949">0,017 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,017 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 5,199 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-9,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,717 ns</td><td align="right" bgcolor="#A8D08D">41,447 ns (Δ = -1,270 ns)</td><td align="right" bgcolor="#FFFFFF">41,916 ns (Δ = +0,469 ns)</td><td align="right" bgcolor="#FFFFFF">41,165 ns (Δ = -0,751 ns)</td><td align="right" bgcolor="#FFFFFF">41,407 ns (Δ = +0,242 ns)</td><td align="right" bgcolor="#A8D08D">37,518 ns (Δ = -3,889 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,038 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 176,620 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1096,120 ns</td><td align="right" bgcolor="#A8D08D">973,987 ns (Δ = -122,133 ns)</td><td align="right" bgcolor="#A8D08D">919,500 ns (Δ = -54,487 ns)</td><td align="right" bgcolor="#FF4949">954,093 ns (Δ = +34,593 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,096 μs</td><td align="right" bgcolor="#A8D08D">0,974 μs (Δ = -0,122 μs)</td><td align="right" bgcolor="#A8D08D">0,920 μs (Δ = -0,054 μs)</td><td align="right" bgcolor="#FF4949">0,954 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,176</td><td align="right">0,176</td><td align="right">0,176</td><td align="right">0,176</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 15,491 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#FF4949">+75,2 %</td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,703 ns</td><td align="right" bgcolor="#FFFFFF">17,833 ns (Δ = +0,129 ns)</td><td align="right" bgcolor="#FF4949">18,734 ns (Δ = +0,902 ns)</td><td align="right" bgcolor="#FF4949">32,818 ns (Δ = +14,084 ns)</td><td align="right" bgcolor="#A8D08D">17,327 ns (Δ = -15,491 ns)</td><td align="right" bgcolor="#FF4949">18,473 ns (Δ = +1,147 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,033 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 20,269 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">251,737 ns</td><td align="right" bgcolor="#A8D08D">243,508 ns (Δ = -8,228 ns)</td><td align="right" bgcolor="#FFFFFF">244,136 ns (Δ = +0,628 ns)</td><td align="right" bgcolor="#FF4949">259,950 ns (Δ = +15,814 ns)</td><td align="right" bgcolor="#A8D08D">239,681 ns (Δ = -20,269 ns)</td><td align="right" bgcolor="#FF4949">249,753 ns (Δ = +10,073 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td><td align="right" bgcolor="#A8D08D">0,244 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,244 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,260 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#A8D08D">0,240 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FF4949">0,250 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 11,192 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,8 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">47,150 ns</td><td align="right" bgcolor="#A8D08D">38,753 ns (Δ = -8,397 ns)</td><td align="right" bgcolor="#FF4949">42,440 ns (Δ = +3,687 ns)</td><td align="right" bgcolor="#A8D08D">39,377 ns (Δ = -3,063 ns)</td><td align="right" bgcolor="#A8D08D">36,530 ns (Δ = -2,847 ns)</td><td align="right" bgcolor="#FFFFFF">35,958 ns (Δ = -0,572 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">0,042 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,037 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 105,459 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+85,8 %</td><td align="right" bgcolor="#A8D08D">-45,1 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,130 ns</td><td align="right" bgcolor="#FFFFFF">122,122 ns (Δ = -3,008 ns)</td><td align="right" bgcolor="#FF4949">226,957 ns (Δ = +104,835 ns)</td><td align="right" bgcolor="#A8D08D">124,543 ns (Δ = -102,414 ns)</td><td align="right" bgcolor="#FFFFFF">121,498 ns (Δ = -3,045 ns)</td><td align="right" bgcolor="#FFFFFF">122,487 ns (Δ = +0,989 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,227 μs (Δ = +0,105 μs)</td><td align="right" bgcolor="#A8D08D">0,125 μs (Δ = -0,102 μs)</td><td align="right" bgcolor="#FFFFFF">0,121 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,122 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 1,793 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,566 ns</td><td align="right" bgcolor="#FFFFFF">31,560 ns (Δ = -0,006 ns)</td><td align="right" bgcolor="#A8D08D">29,773 ns (Δ = -1,787 ns)</td><td align="right" bgcolor="#FF4949">31,080 ns (Δ = +1,307 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,030 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,031 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 95,007 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+23,8 %</td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">361,053 ns</td><td align="right" bgcolor="#FFFFFF">356,944 ns (Δ = -4,109 ns)</td><td align="right" bgcolor="#FFFFFF">359,200 ns (Δ = +2,256 ns)</td><td align="right" bgcolor="#FF4949">444,700 ns (Δ = +85,500 ns)</td><td align="right" bgcolor="#A8D08D">349,693 ns (Δ = -95,007 ns)</td><td align="right" bgcolor="#FFFFFF">353,163 ns (Δ = +3,470 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,359 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,445 μs (Δ = +0,086 μs)</td><td align="right" bgcolor="#A8D08D">0,350 μs (Δ = -0,095 μs)</td><td align="right" bgcolor="#FFFFFF">0,353 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 1002,117 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#A8D08D">-11,0 %</td><td align="right" bgcolor="#FF4949">+26,6 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#FF4949">+20,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2553,464 ns</td><td align="right" bgcolor="#FFFFFF">2520,427 ns (Δ = -33,037 ns)</td><td align="right" bgcolor="#A8D08D">2244,133 ns (Δ = -276,293 ns)</td><td align="right" bgcolor="#FF4949">2840,243 ns (Δ = +596,110 ns)</td><td align="right" bgcolor="#A8D08D">2705,490 ns (Δ = -134,753 ns)</td><td align="right" bgcolor="#FF4949">3246,250 ns (Δ = +540,760 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,553 μs</td><td align="right" bgcolor="#FFFFFF">2,520 μs (Δ = -0,033 μs)</td><td align="right" bgcolor="#A8D08D">2,244 μs (Δ = -0,276 μs)</td><td align="right" bgcolor="#FF4949">2,840 μs (Δ = +0,596 μs)</td><td align="right" bgcolor="#A8D08D">2,705 μs (Δ = -0,135 μs)</td><td align="right" bgcolor="#FF4949">3,246 μs (Δ = +0,541 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">661</td><td align="right">637</td><td align="right">637</td><td align="right">907</td><td align="right">907</td><td align="right">1055</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,646</td><td align="right">0,622</td><td align="right">0,622</td><td align="right">0,886</td><td align="right">0,886</td><td align="right">1,030</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 905,757 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FF4949">+38,0 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2659,067 ns</td><td align="right" bgcolor="#A8D08D">2453,300 ns (Δ = -205,767 ns)</td><td align="right" bgcolor="#FFFFFF">2386,187 ns (Δ = -67,113 ns)</td><td align="right" bgcolor="#FF4949">3291,943 ns (Δ = +905,757 ns)</td><td align="right" bgcolor="#FFFFFF">3278,417 ns (Δ = -13,527 ns)</td><td align="right" bgcolor="#A8D08D">3074,160 ns (Δ = -204,257 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,659 μs</td><td align="right" bgcolor="#A8D08D">2,453 μs (Δ = -0,206 μs)</td><td align="right" bgcolor="#FFFFFF">2,386 μs (Δ = -0,067 μs)</td><td align="right" bgcolor="#FF4949">3,292 μs (Δ = +0,906 μs)</td><td align="right" bgcolor="#FFFFFF">3,278 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#A8D08D">3,074 μs (Δ = -0,204 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">661</td><td align="right">637</td><td align="right">637</td><td align="right">899</td><td align="right">899</td><td align="right">1047</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,646</td><td align="right">0,622</td><td align="right">0,622</td><td align="right">0,878</td><td align="right">0,878</td><td align="right">1,022</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 811,077 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FF4949">+26,6 %</td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3286,837 ns</td><td align="right" bgcolor="#A8D08D">3187,010 ns (Δ = -99,827 ns)</td><td align="right" bgcolor="#A8D08D">3045,473 ns (Δ = -141,537 ns)</td><td align="right" bgcolor="#FF4949">3856,550 ns (Δ = +811,077 ns)</td><td align="right" bgcolor="#A8D08D">3459,440 ns (Δ = -397,110 ns)</td><td align="right" bgcolor="#FF4949">3786,757 ns (Δ = +327,317 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,287 μs</td><td align="right" bgcolor="#A8D08D">3,187 μs (Δ = -0,100 μs)</td><td align="right" bgcolor="#A8D08D">3,045 μs (Δ = -0,142 μs)</td><td align="right" bgcolor="#FF4949">3,857 μs (Δ = +0,811 μs)</td><td align="right" bgcolor="#A8D08D">3,459 μs (Δ = -0,397 μs)</td><td align="right" bgcolor="#FF4949">3,787 μs (Δ = +0,327 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">924</td><td align="right">899</td><td align="right">899</td><td align="right">1317</td><td align="right">1317</td><td align="right">1465</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,902</td><td align="right">0,878</td><td align="right">0,878</td><td align="right">1,286</td><td align="right">1,286</td><td align="right">1,431</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 4757,013 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#FF4949">+14,5 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+107,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3634,451 ns</td><td align="right" bgcolor="#FFFFFF">3719,287 ns (Δ = +84,836 ns)</td><td align="right" bgcolor="#A8D08D">3465,837 ns (Δ = -253,450 ns)</td><td align="right" bgcolor="#FF4949">3969,967 ns (Δ = +504,130 ns)</td><td align="right" bgcolor="#FFFFFF">3957,043 ns (Δ = -12,923 ns)</td><td align="right" bgcolor="#FF4949">8222,850 ns (Δ = +4265,807 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,634 μs</td><td align="right" bgcolor="#FFFFFF">3,719 μs (Δ = +0,085 μs)</td><td align="right" bgcolor="#A8D08D">3,466 μs (Δ = -0,253 μs)</td><td align="right" bgcolor="#FF4949">3,970 μs (Δ = +0,504 μs)</td><td align="right" bgcolor="#FFFFFF">3,957 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">8,223 μs (Δ = +4,266 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,004 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">1129</td><td align="right">1104</td><td align="right">1104</td><td align="right">1522</td><td align="right">1522</td><td align="right">1678</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,103</td><td align="right">1,078</td><td align="right">1,078</td><td align="right">1,486</td><td align="right">1,486</td><td align="right">1,639</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,002</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 20955,204 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#FF4949">+29,8 %</td><td align="right" bgcolor="#A8D08D">-27,3 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26253,909 ns</td><td align="right" bgcolor="#FFFFFF">26301,828 ns (Δ = +47,919 ns)</td><td align="right" bgcolor="#FF4949">27630,092 ns (Δ = +1328,264 ns)</td><td align="right" bgcolor="#FF4949">35867,880 ns (Δ = +8237,788 ns)</td><td align="right" bgcolor="#A8D08D">26060,098 ns (Δ = -9807,782 ns)</td><td align="right" bgcolor="#A8D08D">14912,676 ns (Δ = -11147,422 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">26,254 μs</td><td align="right" bgcolor="#FFFFFF">26,302 μs (Δ = +0,048 μs)</td><td align="right" bgcolor="#FF4949">27,630 μs (Δ = +1,328 μs)</td><td align="right" bgcolor="#FF4949">35,868 μs (Δ = +8,238 μs)</td><td align="right" bgcolor="#A8D08D">26,060 μs (Δ = -9,808 μs)</td><td align="right" bgcolor="#A8D08D">14,913 μs (Δ = -11,147 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,026 ms</td><td align="right" bgcolor="#FFFFFF">0,026 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,028 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,036 ms (Δ = +0,008 ms)</td><td align="right" bgcolor="#A8D08D">0,026 ms (Δ = -0,010 ms)</td><td align="right" bgcolor="#A8D08D">0,015 ms (Δ = -0,011 ms)</td></tr>
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
<td align="right">4.4.0</td>
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
<td>Allocated Bytes</td><td align="right">7581</td><td align="right">7675</td><td align="right">7677</td><td align="right">7574</td><td align="right">7566</td><td align="right">5732</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,403</td><td align="right">7,495</td><td align="right">7,497</td><td align="right">7,396</td><td align="right">7,389</td><td align="right">5,598</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,005</td></tr>
</table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 33,150 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,8 %</td><td align="right" bgcolor="#FF4949">+27,7 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#A8D08D">-19,6 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">137,693 ns</td><td align="right" bgcolor="#A8D08D">118,722 ns (Δ = -18,972 ns)</td><td align="right" bgcolor="#FF4949">151,640 ns (Δ = +32,918 ns)</td><td align="right" bgcolor="#FFFFFF">151,733 ns (Δ = +0,093 ns)</td><td align="right" bgcolor="#A8D08D">121,933 ns (Δ = -29,800 ns)</td><td align="right" bgcolor="#FFFFFF">118,583 ns (Δ = -3,350 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#A8D08D">0,119 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#FF4949">0,152 μs (Δ = +0,033 μs)</td><td align="right" bgcolor="#FFFFFF">0,152 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,122 μs (Δ = -0,030 μs)</td><td align="right" bgcolor="#FFFFFF">0,119 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 2,500 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#A8D08D">-6,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28,943 ns</td><td align="right" bgcolor="#A8D08D">26,975 ns (Δ = -1,968 ns)</td><td align="right" bgcolor="#FF4949">27,970 ns (Δ = +0,995 ns)</td><td align="right" bgcolor="#FFFFFF">27,607 ns (Δ = -0,363 ns)</td><td align="right" bgcolor="#FFFFFF">28,293 ns (Δ = +0,687 ns)</td><td align="right" bgcolor="#A8D08D">26,443 ns (Δ = -1,850 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#A8D08D">0,027 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,028 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,753 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,7 %</td><td align="right" bgcolor="#FF4949">+10,6 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#A8D08D">-14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,277 ns</td><td align="right" bgcolor="#A8D08D">4,762 ns (Δ = -0,514 ns)</td><td align="right" bgcolor="#FF4949">5,269 ns (Δ = +0,507 ns)</td><td align="right" bgcolor="#FFFFFF">5,210 ns (Δ = -0,059 ns)</td><td align="right" bgcolor="#FF4949">5,373 ns (Δ = +0,163 ns)</td><td align="right" bgcolor="#A8D08D">4,620 ns (Δ = -0,753 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,005 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 685,531 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17697,917 ns</td><td align="right" bgcolor="#FFFFFF">17489,957 ns (Δ = -207,960 ns)</td><td align="right" bgcolor="#FFFFFF">17347,422 ns (Δ = -142,534 ns)</td><td align="right" bgcolor="#FFFFFF">17585,180 ns (Δ = +237,758 ns)</td><td align="right" bgcolor="#FFFFFF">18032,953 ns (Δ = +447,773 ns)</td><td align="right" bgcolor="#FFFFFF">18015,580 ns (Δ = -17,373 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,698 μs</td><td align="right" bgcolor="#FFFFFF">17,490 μs (Δ = -0,208 μs)</td><td align="right" bgcolor="#FFFFFF">17,347 μs (Δ = -0,143 μs)</td><td align="right" bgcolor="#FFFFFF">17,585 μs (Δ = +0,238 μs)</td><td align="right" bgcolor="#FFFFFF">18,033 μs (Δ = +0,448 μs)</td><td align="right" bgcolor="#FFFFFF">18,016 μs (Δ = -0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,017 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1225</td><td align="right">1224</td><td align="right">1224</td><td align="right">1225</td><td align="right">1225</td><td align="right">1225</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,196</td><td align="right">1,195</td><td align="right">1,195</td><td align="right">1,196</td><td align="right">1,196</td><td align="right">1,196</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 459,380 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19237,630 ns</td><td align="right" bgcolor="#FFFFFF">18960,732 ns (Δ = -276,898 ns)</td><td align="right" bgcolor="#FFFFFF">19187,524 ns (Δ = +226,793 ns)</td><td align="right" bgcolor="#FFFFFF">19225,769 ns (Δ = +38,245 ns)</td><td align="right" bgcolor="#FFFFFF">19146,753 ns (Δ = -79,016 ns)</td><td align="right" bgcolor="#FFFFFF">18778,250 ns (Δ = -368,503 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">19,238 μs</td><td align="right" bgcolor="#FFFFFF">18,961 μs (Δ = -0,277 μs)</td><td align="right" bgcolor="#FFFFFF">19,188 μs (Δ = +0,227 μs)</td><td align="right" bgcolor="#FFFFFF">19,226 μs (Δ = +0,038 μs)</td><td align="right" bgcolor="#FFFFFF">19,147 μs (Δ = -0,079 μs)</td><td align="right" bgcolor="#FFFFFF">18,778 μs (Δ = -0,369 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = 0,000 ms)</td></tr>
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
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
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
<td>Allocated Bytes</td><td align="right">1226</td><td align="right">1224</td><td align="right">1224</td><td align="right">1225</td><td align="right">1225</td><td align="right">1225</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,197</td><td align="right">1,195</td><td align="right">1,195</td><td align="right">1,196</td><td align="right">1,196</td><td align="right">1,196</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


