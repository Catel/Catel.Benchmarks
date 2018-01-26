# Benchmarks

Benchmark report generated on 26-jan-2018 15:46

Running the benchmarks took 02:30:12.3091803

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.9, OS=Windows 10.0.17083

Processor=Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), ProcessorCount=8



## Important benchmarks

### High priority (current version slower than previous one)

174 item(s)

1. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v5.2.0 is **201355802320,05%** (Δ: 1173626,417 ns) slower than v5.0.0

2. [Serialization_Json_Benchmark::SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models) v5.2.0 is **153107837868,51%** (Δ: 1127828,785 ns) slower than v5.0.0

3. [Assembly_ReflectionExtensions_Benchmark::GetExportedTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx) v5.2.0 is **855695,44%** (Δ: 5870,045 ns) slower than v5.0.0

4. [Assembly_ReflectionExtensions_Benchmark::GetTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetTypesEx) v5.2.0 is **204903,67%** (Δ: 3405,898 ns) slower than v5.0.0

5. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.2.0 is **112237,91%** (Δ: 1295,338 ns) slower than v5.0.0

6. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.2.0 is **108851,93%** (Δ: 1250,478 ns) slower than v5.0.0

7. [Assembly_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.2.0 is **63720,71%** (Δ: 859,655 ns) slower than v5.0.0

8. [Assembly_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.2.0 is **56145,90%** (Δ: 749,433 ns) slower than v5.0.0

9. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.2.0 is **53594,08%** (Δ: 697,105 ns) slower than v5.0.0

10. [AssemblyExtensions_Benchmark::InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion) v5.2.0 is **45665,43%** (Δ: 594,253 ns) slower than v5.0.0

11. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.2.0 is **39577,79%** (Δ: 593,947 ns) slower than v5.0.0

12. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.2.0 is **38479,32%** (Δ: 582,912 ns) slower than v5.0.0

13. [AssemblyExtensions_Benchmark::Company](#AssemblyExtensions_Benchmark_Company) v5.2.0 is **37384,63%** (Δ: 393,823 ns) slower than v5.0.0

14. [AssemblyExtensions_Benchmark::Description](#AssemblyExtensions_Benchmark_Description) v5.2.0 is **37039,74%** (Δ: 391,025 ns) slower than v5.0.0

15. [AssemblyExtensions_Benchmark::Copyright](#AssemblyExtensions_Benchmark_Copyright) v5.2.0 is **34782,95%** (Δ: 361,407 ns) slower than v5.0.0

16. [AssemblyExtensions_Benchmark::Product](#AssemblyExtensions_Benchmark_Product) v5.2.0 is **29455,54%** (Δ: 308,260 ns) slower than v5.0.0

17. [AssemblyExtensions_Benchmark::GetDirectory](#AssemblyExtensions_Benchmark_GetDirectory) v5.2.0 is **22059,88%** (Δ: 903,092 ns) slower than v5.0.0

18. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.2.0 is **19705,57%** (Δ: 377,357 ns) slower than v5.0.0

19. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member) v5.2.0 is **18620,73%** (Δ: 728,385 ns) slower than v5.0.0

20. [ModelBase_EqualityComparer_Benchmark::EqualityComparer](#ModelBase_EqualityComparer_Benchmark_EqualityComparer) v5.2.0 is **15986,19%** (Δ: 586,980 ns) slower than v5.0.0

21. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member) v5.2.0 is **15835,40%** (Δ: 604,598 ns) slower than v5.0.0

22. [ModelBase_EqualityComparer_Benchmark::GetHashCode_](#ModelBase_EqualityComparer_Benchmark_GetHashCode_) v5.2.0 is **15654,89%** (Δ: 565,652 ns) slower than v5.0.0

23. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.2.0 is **15275,71%** (Δ: 389,125 ns) slower than v5.0.0

24. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.2.0 is **15140,23%** (Δ: 386,180 ns) slower than v5.0.0

25. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type) v5.2.0 is **14086,51%** (Δ: 426,513 ns) slower than v5.0.0

26. [ModelBase_Constructor_Benchmark::Constructor](#ModelBase_Constructor_Benchmark_Constructor) v5.2.0 is **13014,35%** (Δ: 474,333 ns) slower than v5.0.0

27. [ValidatableModelBase_Constructor_Benchmark::Constructor](#ValidatableModelBase_Constructor_Benchmark_Constructor) v5.2.0 is **12426,36%** (Δ: 436,788 ns) slower than v5.0.0

28. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type) v5.2.0 is **12407,16%** (Δ: 377,882 ns) slower than v5.0.0

29. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static) v5.2.0 is **11759,21%** (Δ: 224,495 ns) slower than v5.0.0

30. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member) v5.2.0 is **11213,34%** (Δ: 440,133 ns) slower than v5.0.0

31. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member) v5.2.0 is **11025,39%** (Δ: 424,473 ns) slower than v5.0.0

32. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member) v5.2.0 is **11023,83%** (Δ: 431,432 ns) slower than v5.0.0

33. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member) v5.2.0 is **10801,42%** (Δ: 410,558 ns) slower than v5.0.0

34. [Log_Error_Benchmark::Log_Error_Format_6_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments) v5.2.0 is **10541,76%** (Δ: 782,925 ns) slower than v5.0.0

35. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.2.0 is **10350,19%** (Δ: 273,107 ns) slower than v5.0.0

36. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.2.0 is **10190,20%** (Δ: 223,032 ns) slower than v5.0.0

37. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type) v5.2.0 is **10062,64%** (Δ: 305,302 ns) slower than v5.0.0

38. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type) v5.2.0 is **9848,25%** (Δ: 297,123 ns) slower than v5.0.0

39. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type) v5.2.0 is **9508,73%** (Δ: 285,107 ns) slower than v5.0.0

40. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.2.0 is **8750,96%** (Δ: 265,488 ns) slower than v5.0.0

41. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type) v5.2.0 is **7925,53%** (Δ: 236,051 ns) slower than v5.0.0

42. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.2.0 is **7903,82%** (Δ: 238,335 ns) slower than v5.0.0

43. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance) v5.2.0 is **6897,26%** (Δ: 146,077 ns) slower than v5.0.0

44. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.2.0 is **6891,51%** (Δ: 181,953 ns) slower than v5.0.0

45. [ObjectToStringHelper_Benchmark::ToString_](#ObjectToStringHelper_Benchmark_ToString_) v5.2.0 is **5041,06%** (Δ: 153,395 ns) slower than v5.0.0

46. [Log_Debug_Benchmark::Log_Debug_Format_7_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments) v5.2.0 is **3836,93%** (Δ: 257,950 ns) slower than v5.0.0

47. [Log_Error_Benchmark::Log_Error_Format_7_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments) v5.2.0 is **3018,79%** (Δ: 202,613 ns) slower than v5.0.0

48. [Log_Status_Benchmark::Log_Status_Format_7_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments) v5.2.0 is **2829,91%** (Δ: 188,898 ns) slower than v5.0.0

49. [Log_Debug_Benchmark::Log_Debug_Format_6_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments) v5.2.0 is **2538,69%** (Δ: 188,578 ns) slower than v5.0.0

50. [Log_Warning_Benchmark::Log_Warning_Format_7_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments) v5.2.0 is **2195,04%** (Δ: 146,720 ns) slower than v5.0.0

51. [ValidationContext_Benchmark::GetErrors](#ValidationContext_Benchmark_GetErrors) v5.2.0 is **2135,07%** (Δ: 213,687 ns) slower than v5.0.0

52. [Log_Warning_Benchmark::Log_Warning_Format_6_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments) v5.2.0 is **2095,30%** (Δ: 149,275 ns) slower than v5.0.0

53. [WeakEventListener_Benchmark::GenericEvent_Notification](#WeakEventListener_Benchmark_GenericEvent_Notification) v5.2.0 is **1977,33%** (Δ: 201,337 ns) slower than v5.0.0

54. [Log_Error_Benchmark::Log_Error_Format_5_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments) v5.2.0 is **1952,26%** (Δ: 169,892 ns) slower than v5.0.0

55. [Log_Info_Benchmark::Log_Info_Format_6_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments) v5.2.0 is **1948,28%** (Δ: 151,137 ns) slower than v5.0.0

56. [TypeExtensions_Benchmark::GetCollectionElementType](#TypeExtensions_Benchmark_GetCollectionElementType) v5.2.0 is **1845,62%** (Δ: 197,923 ns) slower than v5.0.0

57. [Log_Status_Benchmark::Log_Status_Format_6_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments) v5.2.0 is **1829,42%** (Δ: 133,960 ns) slower than v5.0.0

58. [Log_Info_Benchmark::Log_Info_Format_7_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments) v5.2.0 is **1690,99%** (Δ: 117,237 ns) slower than v5.0.0

59. [ValidationSummary_Benchmark::Initialization](#ValidationSummary_Benchmark_Initialization) v5.2.0 is **1510,15%** (Δ: 164,860 ns) slower than v5.0.0

60. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.2.0 is **1510,05%** (Δ: 185,290 ns) slower than v5.0.0

61. [Log_Debug_Benchmark::Log_Debug_Format_5_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments) v5.2.0 is **1495,02%** (Δ: 129,535 ns) slower than v5.0.0

62. [Log_Info_Benchmark::Log_Info_Format_5_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments) v5.2.0 is **1432,42%** (Δ: 123,718 ns) slower than v5.0.0

63. [Log_Error_Benchmark::Log_Error_Format_4_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments) v5.2.0 is **1394,49%** (Δ: 138,935 ns) slower than v5.0.0

64. [FastDateTime_vs_DateTime_Benchmark::DateTime_Now](#FastDateTime_vs_DateTime_Benchmark_DateTime_Now) v5.2.0 is **1389,84%** (Δ: 510,590 ns) slower than v5.0.0

65. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.2.0 is **1354,69%** (Δ: 159,432 ns) slower than v5.0.0

66. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags) v5.2.0 is **1338,30%** (Δ: 147,505 ns) slower than v5.0.0

67. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags) v5.2.0 is **1300,88%** (Δ: 143,398 ns) slower than v5.0.0

68. [ValidationContext_Benchmark::GetValidations](#ValidationContext_Benchmark_GetValidations) v5.2.0 is **1258,92%** (Δ: 254,208 ns) slower than v5.0.0

69. [Log_Debug_Benchmark::Log_Debug_Format_4_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments) v5.2.0 is **1221,65%** (Δ: 116,697 ns) slower than v5.0.0

70. [Log_Warning_Benchmark::Log_Warning_Format_5_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments) v5.2.0 is **1204,64%** (Δ: 104,127 ns) slower than v5.0.0

71. [ValidationContext_Benchmark::GetWarningCount](#ValidationContext_Benchmark_GetWarningCount) v5.2.0 is **1195,96%** (Δ: 128,690 ns) slower than v5.0.0

72. [Log_Status_Benchmark::Log_Status_Format_4_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments) v5.2.0 is **1155,06%** (Δ: 113,717 ns) slower than v5.0.0

73. [Log_Info_Benchmark::Log_Info_Format_4_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments) v5.2.0 is **1147,98%** (Δ: 112,880 ns) slower than v5.0.0

74. [Log_Status_Benchmark::Log_Status_Format_5_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments) v5.2.0 is **1118,72%** (Δ: 96,240 ns) slower than v5.0.0

75. [Log_Warning_Benchmark::Log_Warning_Format_3_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments) v5.2.0 is **1093,25%** (Δ: 131,168 ns) slower than v5.0.0

76. [Type_ReflectionExtensions_Benchmark::GetParentTypes](#Type_ReflectionExtensions_Benchmark_GetParentTypes) v5.2.0 is **1090,38%** (Δ: 151,423 ns) slower than v5.0.0

77. [Log_Debug_Benchmark::Log_Debug_Format_3_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments) v5.2.0 is **1089,69%** (Δ: 131,487 ns) slower than v5.0.0

78. [Log_Warning_Benchmark::Log_Warning_Format_4_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments) v5.2.0 is **1067,60%** (Δ: 105,103 ns) slower than v5.0.0

79. [Log_Status_Benchmark::Log_Status_Format_3_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments) v5.2.0 is **1060,62%** (Δ: 126,820 ns) slower than v5.0.0

80. [Log_Error_Benchmark::Log_Error_Format_3_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments) v5.2.0 is **1024,66%** (Δ: 122,722 ns) slower than v5.0.0

81. [Log_Error_Benchmark::Log_Error_Format_2_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments) v5.2.0 is **978,48%** (Δ: 142,187 ns) slower than v5.0.0

82. [Log_Warning_Benchmark::Log_Warning_Format_2_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments) v5.2.0 is **922,97%** (Δ: 131,442 ns) slower than v5.0.0

83. [Log_Debug_Benchmark::Log_Debug_Format_2_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments) v5.2.0 is **906,42%** (Δ: 130,868 ns) slower than v5.0.0

84. [Log_Info_Benchmark::Log_Info_Format_2_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments) v5.2.0 is **902,93%** (Δ: 123,318 ns) slower than v5.0.0

85. [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark::FastBindingList_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert) v5.2.0 is **894,14%** (Δ: 83,818 ns) slower than v5.0.0

86. [Log_Info_Benchmark::Log_Info_Format_3_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments) v5.2.0 is **888,00%** (Δ: 99,505 ns) slower than v5.0.0

87. [Log_Status_Benchmark::Log_Status_Format_2_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments) v5.2.0 is **753,61%** (Δ: 107,442 ns) slower than v5.0.0

88. [Enum_Benchmark::ConvertFromOtherEnumValue](#Enum_Benchmark_ConvertFromOtherEnumValue) v5.2.0 is **713,21%** (Δ: 83,740 ns) slower than v5.0.0

89. [ValidationContext_Benchmark::GetWarnings](#ValidationContext_Benchmark_GetWarnings) v5.2.0 is **671,60%** (Δ: 72,297 ns) slower than v5.0.0

90. [Log_Error_Benchmark::Log_Error_Format_1_Format_Argument](#Log_Error_Benchmark_Log_Error_Format_1_Format_Argument) v5.2.0 is **655,96%** (Δ: 118,063 ns) slower than v5.0.0

91. [Log_Enabled_Benchmark::Log_Info_Format_WithoutBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing) v5.2.0 is **636,81%** (Δ: 126,278 ns) slower than v5.0.0

92. [Log_Warning_Benchmark::Log_Warning_Format_1_Format_Argument](#Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument) v5.2.0 is **625,04%** (Δ: 112,885 ns) slower than v5.0.0

93. [Log_Enabled_Benchmark::Log_Info_Format_WithBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithBoxing) v5.2.0 is **615,91%** (Δ: 104,903 ns) slower than v5.0.0

94. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.2.0 is **577,50%** (Δ: 83,540 ns) slower than v5.0.0

95. [ValidationContext_Benchmark::Initialization](#ValidationContext_Benchmark_Initialization) v5.2.0 is **554,84%** (Δ: 173,713 ns) slower than v5.0.0

96. [Log_Info_Benchmark::Log_Info_Format_1_Format_Argument](#Log_Info_Benchmark_Log_Info_Format_1_Format_Argument) v5.2.0 is **528,32%** (Δ: 89,935 ns) slower than v5.0.0

97. [Log_Debug_Benchmark::Log_Debug_Format_1_Format_Argument](#Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument) v5.2.0 is **522,75%** (Δ: 88,915 ns) slower than v5.0.0

98. [Log_Status_Benchmark::Log_Status_Format_1_Format_Argument](#Log_Status_Benchmark_Log_Status_Format_1_Format_Argument) v5.2.0 is **457,94%** (Δ: 81,833 ns) slower than v5.0.0

99. [ResourceHelper_Benchmark::GetString](#ResourceHelper_Benchmark_GetString) v5.2.0 is **327,72%** (Δ: 78,355 ns) slower than v5.0.0

100. [Log_Enabled_Benchmark::Log_Info](#Log_Enabled_Benchmark_Log_Info) v5.2.0 is **321,56%** (Δ: 118,172 ns) slower than v5.0.0

101. [MemberInfoExtensions_Benchmark::GetSignature_Constructor](#MemberInfoExtensions_Benchmark_GetSignature_Constructor) v5.2.0 is **314,93%** (Δ: 113,834 ns) slower than v5.0.0

102. [Type_ReflectionExtensions_Benchmark::IsCatelType](#Type_ReflectionExtensions_Benchmark_IsCatelType) v5.2.0 is **295,09%** (Δ: 65,315 ns) slower than v5.0.0

103. [Type_ReflectionExtensions_Benchmark::GetFieldsEx_Static](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static) v5.2.0 is **286,66%** (Δ: 31,442 ns) slower than v5.0.0

104. [TypeExtensions_Benchmark::IsNullableType](#TypeExtensions_Benchmark_IsNullableType) v5.2.0 is **286,57%** (Δ: 98,623 ns) slower than v5.0.0

105. [ModelBase_SetValue_Benchmark::SetBoolValue](#ModelBase_SetValue_Benchmark_SetBoolValue) v5.2.0 is **239,25%** (Δ: 55,418 ns) slower than v5.0.0

106. [MemberInfoExtensions_Benchmark::GetSignature_Method](#MemberInfoExtensions_Benchmark_GetSignature_Method) v5.2.0 is **209,94%** (Δ: 70,105 ns) slower than v5.0.0

107. [Type_ReflectionExtensions_Benchmark::GetEventsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance) v5.2.0 is **171,08%** (Δ: 40,418 ns) slower than v5.0.0

108. [Type_ReflectionExtensions_Benchmark::GetSafeFullName](#Type_ReflectionExtensions_Benchmark_GetSafeFullName) v5.2.0 is **133,33%** (Δ: 77,727 ns) slower than v5.0.0

109. [TypeExtensions_Benchmark::IsClassType](#TypeExtensions_Benchmark_IsClassType) v5.2.0 is **130,35%** (Δ: 58,857 ns) slower than v5.0.0

110. [ValidationContext_Benchmark::GetBusinessRuleWarnings](#ValidationContext_Benchmark_GetBusinessRuleWarnings) v5.2.0 is **127,83%** (Δ: 66,187 ns) slower than v5.0.0

111. [ModelBase_SetValue_Benchmark::SetIntValue](#ModelBase_SetValue_Benchmark_SetIntValue) v5.2.0 is **127,45%** (Δ: 28,262 ns) slower than v5.0.0

112. [Enum_Benchmark::TryParse](#Enum_Benchmark_TryParse) v5.2.0 is **121,69%** (Δ: 41,983 ns) slower than v5.0.0

113. [ModelBase_SetValue_Benchmark::SetStringValue](#ModelBase_SetValue_Benchmark_SetStringValue) v5.2.0 is **120,08%** (Δ: 35,387 ns) slower than v5.0.0

114. [ValidationContext_Benchmark::GetFieldErrorCount](#ValidationContext_Benchmark_GetFieldErrorCount) v5.2.0 is **117,26%** (Δ: 49,473 ns) slower than v5.0.0

115. [Enum_Benchmark::TryParse_IgnoreCase](#Enum_Benchmark_TryParse_IgnoreCase) v5.2.0 is **103,24%** (Δ: 35,390 ns) slower than v5.0.0

116. [Type_ReflectionExtensions_Benchmark::GetGenericArgumentsEx](#Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx) v5.2.0 is **93,98%** (Δ: 60,458 ns) slower than v5.0.0

117. [Type_ReflectionExtensions_Benchmark::GetConstructorEx](#Type_ReflectionExtensions_Benchmark_GetConstructorEx) v5.2.0 is **90,09%** (Δ: 33,473 ns) slower than v5.0.0

118. [ValidationContext_Benchmark::GetFieldValidations](#ValidationContext_Benchmark_GetFieldValidations) v5.2.0 is **89,46%** (Δ: 35,368 ns) slower than v5.0.0

119. [Enum_Benchmark::TryParse_Nullable](#Enum_Benchmark_TryParse_Nullable) v5.2.0 is **86,54%** (Δ: 30,218 ns) slower than v5.0.0

120. [Enum_Benchmark::Parse](#Enum_Benchmark_Parse) v5.2.0 is **76,73%** (Δ: 27,025 ns) slower than v5.0.0

121. [ValidationContext_Benchmark::GetBusinessRuleWarningCount](#ValidationContext_Benchmark_GetBusinessRuleWarningCount) v5.2.0 is **62,31%** (Δ: 31,728 ns) slower than v5.0.0

122. [Enum_Benchmark::TryParse_IgnoreCase_Nullable](#Enum_Benchmark_TryParse_IgnoreCase_Nullable) v5.2.0 is **61,52%** (Δ: 20,948 ns) slower than v5.0.0

123. [ValidationContext_Benchmark::GetFieldWarnings](#ValidationContext_Benchmark_GetFieldWarnings) v5.2.0 is **61,07%** (Δ: 29,455 ns) slower than v5.0.0

124. [Type_ReflectionExtensions_Benchmark::IsClassEx](#Type_ReflectionExtensions_Benchmark_IsClassEx) v5.2.0 is **60,58%** (Δ: 35,025 ns) slower than v5.0.0

125. [CacheStorage_Benchmark::GetFromCacheOrFetch](#CacheStorage_Benchmark_GetFromCacheOrFetch) v5.2.0 is **51,16%** (Δ: 21,438 ns) slower than v5.0.0

126. [CacheStorage_Benchmark::RemoveItem_From_Cache](#CacheStorage_Benchmark_RemoveItem_From_Cache) v5.2.0 is **50,22%** (Δ: 21,285 ns) slower than v5.0.0

127. [CacheStorage_Benchmark::GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy](#CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy) v5.2.0 is **49,82%** (Δ: 20,665 ns) slower than v5.0.0

128. [CacheStorage_Benchmark::Clear_Cache](#CacheStorage_Benchmark_Clear_Cache) v5.2.0 is **45,05%** (Δ: 18,957 ns) slower than v5.0.0

129. [CacheStorage_Benchmark::Overwrite_An_Existing_Cached_Value](#CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value) v5.2.0 is **44,66%** (Δ: 19,970 ns) slower than v5.0.0

130. [CacheStorage_Benchmark::GetValue_From_An_Already_Initialized_Cache](#CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache) v5.2.0 is **43,07%** (Δ: 19,223 ns) slower than v5.0.0

131. [FastDateTime_vs_DateTime_Benchmark::FastDateTime_Now](#FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now) v5.2.0 is **24,88%** (Δ: 56,202 ns) slower than v5.0.0

132. [ValidationContext_Benchmark::GetFieldErrors](#ValidationContext_Benchmark_GetFieldErrors) v5.2.0 is **23,58%** (Δ: 10,085 ns) slower than v5.0.0

133. [ObjectToStringHelper_Benchmark::ToFullTypeString](#ObjectToStringHelper_Benchmark_ToFullTypeString) v5.2.0 is **20,71%** (Δ: 21,460 ns) slower than v5.0.0

134. [TypeExtensions_Benchmark::IsDictionary](#TypeExtensions_Benchmark_IsDictionary) v5.2.0 is **18,11%** (Δ: 17,088 ns) slower than v5.0.0

135. [ServiceLocator_Benchmark::ResolveType_With_Singleton_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency) v5.2.0 is **17,66%** (Δ: 9,385 ns) slower than v5.0.0

136. [UniqueIdentifierHelper_Benchmark::GetUniqueIdentifier_Generic](#UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic) v5.2.0 is **16,40%** (Δ: 15,710 ns) slower than v5.0.0

137. [Enum_Benchmark::GetName_Long](#Enum_Benchmark_GetName_Long) v5.2.0 is **15,96%** (Δ: 11,490 ns) slower than v5.0.0

138. [ModelBase_GetValue_Benchmark::GetStringValue](#ModelBase_GetValue_Benchmark_GetStringValue) v5.2.0 is **15,71%** (Δ: 11,967 ns) slower than v5.0.0

139. [ServiceLocator_Benchmark::ResolveType_Singleton](#ServiceLocator_Benchmark_ResolveType_Singleton) v5.2.0 is **15,55%** (Δ: 8,247 ns) slower than v5.0.0

140. [Enum_Benchmark::GetName](#Enum_Benchmark_GetName) v5.2.0 is **14,99%** (Δ: 12,525 ns) slower than v5.0.0

141. [ObjectHelper_Benchmark::AreEqualReferences_Strings](#ObjectHelper_Benchmark_AreEqualReferences_Strings) v5.2.0 is **14,40%** (Δ: 19,757 ns) slower than v5.0.0

142. [PropertyBag_SetPropertyValue_Benchmark::SetIntValue](#PropertyBag_SetPropertyValue_Benchmark_SetIntValue) v5.2.0 is **14,35%** (Δ: 12,587 ns) slower than v5.0.0

143. [Type_ReflectionExtensions_Benchmark::GetGenericTypeDefinitionEx](#Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx) v5.2.0 is **13,77%** (Δ: 14,968 ns) slower than v5.0.0

144. [UniqueIdentifierHelper_Benchmark::GetUniqueIdentifier](#UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier) v5.2.0 is **13,06%** (Δ: 12,212 ns) slower than v5.0.0

145. [Type_ReflectionExtensions_Benchmark::GetPropertiesEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags) v5.2.0 is **12,65%** (Δ: 7,800 ns) slower than v5.0.0

146. [ModelBase_GetValue_Benchmark::GetBoolValue](#ModelBase_GetValue_Benchmark_GetBoolValue) v5.2.0 is **12,51%** (Δ: 9,115 ns) slower than v5.0.0

147. [Argument_Benchmark::IsNotOfOneOfTheTypes_Object](#Argument_Benchmark_IsNotOfOneOfTheTypes_Object) v5.2.0 is **11,79%** (Δ: 12,908 ns) slower than v5.0.0

148. [PropertyBag_SetPropertyValue_Benchmark::SetBoolValue](#PropertyBag_SetPropertyValue_Benchmark_SetBoolValue) v5.2.0 is **11,45%** (Δ: 9,845 ns) slower than v5.0.0

149. [Argument_Benchmark::IsNotOfOneOfTheTypes](#Argument_Benchmark_IsNotOfOneOfTheTypes) v5.2.0 is **11,04%** (Δ: 13,247 ns) slower than v5.0.0

150. [PropertyBag_SetPropertyValue_Benchmark::SetStringValue](#PropertyBag_SetPropertyValue_Benchmark_SetStringValue) v5.2.0 is **9,35%** (Δ: 12,883 ns) slower than v5.0.0

151. [Type_ReflectionExtensions_Benchmark::GetFieldEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags) v5.2.0 is **7,80%** (Δ: 7,847 ns) slower than v5.0.0

152. [PropertyBag_GetPropertyValue_Benchmark::GetStringValue](#PropertyBag_GetPropertyValue_Benchmark_GetStringValue) v5.2.0 is **6,69%** (Δ: 7,557 ns) slower than v5.0.0

153. [Argument_Benchmark::IsOfOneOfTheTypes](#Argument_Benchmark_IsOfOneOfTheTypes) v5.2.0 is **5,70%** (Δ: 9,367 ns) slower than v5.0.0

154. [ObjectHelper_Benchmark::AreEqualReferences_Not_Same_Reference](#ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference) v5.2.0 is **5,57%** (Δ: 11,707 ns) slower than v5.0.0

155. [Type_ReflectionExtensions_Benchmark::GetFieldsEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags) v5.2.0 is **5,45%** (Δ: 5,632 ns) slower than v5.0.0

156. [Argument_Benchmark::IsNotOfType](#Argument_Benchmark_IsNotOfType) v5.2.0 is **4,79%** (Δ: 8,353 ns) slower than v5.0.0

157. [Argument_Benchmark::InheritsFrom_Generic](#Argument_Benchmark_InheritsFrom_Generic) v5.2.0 is **4,73%** (Δ: 11,370 ns) slower than v5.0.0

158. [Type_ReflectionExtensions_Benchmark::IsValueTypeEx](#Type_ReflectionExtensions_Benchmark_IsValueTypeEx) v5.2.0 is **4,69%** (Δ: 13,005 ns) slower than v5.0.0

159. [Argument_Benchmark::InheritsFrom_Object](#Argument_Benchmark_InheritsFrom_Object) v5.2.0 is **3,91%** (Δ: 8,895 ns) slower than v5.0.0

160. [Argument_Benchmark::InheritsFrom](#Argument_Benchmark_InheritsFrom) v5.2.0 is **3,50%** (Δ: 9,705 ns) slower than v5.0.0

161. [Type_ReflectionExtensions_Benchmark::ImplementsInterfaceEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx) v5.2.0 is **3,50%** (Δ: 9,928 ns) slower than v5.0.0

162. [Argument_Benchmark::IsNotOfType_Object](#Argument_Benchmark_IsNotOfType_Object) v5.2.0 is **3,38%** (Δ: 5,013 ns) slower than v5.0.0

163. [Type_ReflectionExtensions_Benchmark::IsEnumEx](#Type_ReflectionExtensions_Benchmark_IsEnumEx) v5.2.0 is **2,77%** (Δ: 9,477 ns) slower than v5.0.0

164. [Type_ReflectionExtensions_Benchmark::HasBaseTypeEx](#Type_ReflectionExtensions_Benchmark_HasBaseTypeEx) v5.2.0 is **2,44%** (Δ: 7,633 ns) slower than v5.0.0

165. [TypeExtensions_Benchmark::IsCollection](#TypeExtensions_Benchmark_IsCollection) v5.2.0 is **2,24%** (Δ: 6,532 ns) slower than v5.0.0

166. [TypeExtensions_Benchmark::IsModelBase](#TypeExtensions_Benchmark_IsModelBase) v5.2.0 is **2,12%** (Δ: 7,372 ns) slower than v5.0.0

167. [Type_ReflectionExtensions_Benchmark::ImplementsInterfacesEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx) v5.2.0 is **1,98%** (Δ: 6,173 ns) slower than v5.0.0

168. [Type_ReflectionExtensions_Benchmark::GetBaseTypeEx](#Type_ReflectionExtensions_Benchmark_GetBaseTypeEx) v5.2.0 is **1,80%** (Δ: 6,603 ns) slower than v5.0.0

169. [Type_ReflectionExtensions_Benchmark::GetAssemblyFullNameEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx) v5.2.0 is **1,72%** (Δ: 8,587 ns) slower than v5.0.0

170. [Argument_Benchmark::IsOfType](#Argument_Benchmark_IsOfType) v5.2.0 is **1,42%** (Δ: 3,500 ns) slower than v5.0.0

171. [Type_ReflectionExtensions_Benchmark::GetAssemblyEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyEx) v5.2.0 is **1,33%** (Δ: 7,387 ns) slower than v5.0.0

172. [HashHelper_Benchmark::HashHelper](#HashHelper_Benchmark_HashHelper) v5.2.0 is **1,27%** (Δ: 6,070 ns) slower than v5.0.0

173. [Type_ReflectionExtensions_Benchmark::ContainsGenericParametersEx](#Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx) v5.2.0 is **1,03%** (Δ: 4,028 ns) slower than v5.0.0

174. [Type_ReflectionExtensions_Benchmark::IsAssignableFromEx](#Type_ReflectionExtensions_Benchmark_IsAssignableFromEx) v5.2.0 is **1,03%** (Δ: 4,060 ns) slower than v5.0.0



### Improved (current version faster than previous one)

49 item(s)

1. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.2.0 is **9599514210,02%** (Δ: -351378,073 ns) faster than v5.0.0

2. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_100](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100) v5.2.0 is **3643291042,44%** (Δ: -118506,022 ns) faster than v5.0.0

3. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.2.0 is **2817025456,69%** (Δ: -215737,305 ns) faster than v5.0.0

4. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.2.0 is **2265420643,73%** (Δ: -176390,462 ns) faster than v5.0.0

5. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.2.0 is **2031887208,03%** (Δ: -233110,848 ns) faster than v5.0.0

6. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v5.2.0 is **1439409015,25%** (Δ: -133436,918 ns) faster than v5.0.0

7. [Serialization_Binary_Benchmark::SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph) v5.2.0 is **1325272557,40%** (Δ: -205334,148 ns) faster than v5.0.0

8. [Serialization_Binary_Benchmark::SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models) v5.2.0 is **1090861009,02%** (Δ: -197784,093 ns) faster than v5.0.0

9. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.2.0 is **1044726253,62%** (Δ: -207755,068 ns) faster than v5.0.0

10. [Serialization_Binary_Benchmark::SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models) v5.2.0 is **805372579,26%** (Δ: -194153,292 ns) faster than v5.0.0

11. [AssemblyExtensions_Benchmark::GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime) v5.2.0 is **787884417,71%** (Δ: -178836,553 ns) faster than v5.0.0

12. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.2.0 is **246803871,56%** (Δ: -36506,270 ns) faster than v5.0.0

13. [WeakEventListener_Benchmark::SubscribeToWeakPropertyChangedEvent](#WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent) v5.2.0 is **525402,11%** (Δ: -2498,788 ns) faster than v5.0.0

14. [WeakEventListener_Benchmark::SubscribeToWeakGenericEvent](#WeakEventListener_Benchmark_SubscribeToWeakGenericEvent) v5.2.0 is **355093,73%** (Δ: -1824,988 ns) faster than v5.0.0

15. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v5.2.0 is **332886,04%** (Δ: -1997,793 ns) faster than v5.0.0

16. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.2.0 is **284527,30%** (Δ: -1743,188 ns) faster than v5.0.0

17. [TagHelper_Benchmark::ToString_](#TagHelper_Benchmark_ToString_) v5.2.0 is **121906,50%** (Δ: -604,882 ns) faster than v5.0.0

18. [ServiceLocator_Benchmark::ResolveType_With_Transient_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency) v5.2.0 is **40950,24%** (Δ: -625,428 ns) faster than v5.0.0

19. [ServiceLocator_Benchmark::ResolveType_Transient](#ServiceLocator_Benchmark_ResolveType_Transient) v5.2.0 is **12585,07%** (Δ: -397,342 ns) faster than v5.0.0

20. [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark::FastObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert) v5.2.0 is **7799,32%** (Δ: -315,430 ns) faster than v5.0.0

21. [Enum_Benchmark::GetValues](#Enum_Benchmark_GetValues) v5.2.0 is **6943,71%** (Δ: -178,672 ns) faster than v5.0.0

22. [TypeFactory_Benchmark::CreateInstance_PropertyInjection](#TypeFactory_Benchmark_CreateInstance_PropertyInjection) v5.2.0 is **6095,03%** (Δ: -251,593 ns) faster than v5.0.0

23. [TypeFactory_Benchmark::CreateInstanceWithParametersAndAutoCompletion](#TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion) v5.2.0 is **4944,45%** (Δ: -152,005 ns) faster than v5.0.0

24. [Enum_Benchmark::GetNames](#Enum_Benchmark_GetNames) v5.2.0 is **4273,03%** (Δ: -215,580 ns) faster than v5.0.0

25. [TypeFactory_Benchmark::CreateInstance](#TypeFactory_Benchmark_CreateInstance) v5.2.0 is **4242,72%** (Δ: -179,513 ns) faster than v5.0.0

26. [ExpressionHelper_Benchmark::GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName) v5.2.0 is **4218,08%** (Δ: -116,542 ns) faster than v5.0.0

27. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v5.2.0 is **2678,11%** (Δ: -144,412 ns) faster than v5.0.0

28. [Type_ReflectionExtensions_Benchmark::GetMemberEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static) v5.2.0 is **2501,51%** (Δ: -178,760 ns) faster than v5.0.0

29. [Type_ReflectionExtensions_Benchmark::GetMethodEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static) v5.2.0 is **941,42%** (Δ: -117,572 ns) faster than v5.0.0

30. [Type_ReflectionExtensions_Benchmark::GetEventEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static) v5.2.0 is **890,88%** (Δ: -115,647 ns) faster than v5.0.0

31. [Type_ReflectionExtensions_Benchmark::GetPropertiesEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static) v5.2.0 is **695,92%** (Δ: -52,068 ns) faster than v5.0.0

32. [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark::ObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert) v5.2.0 is **642,30%** (Δ: -67,948 ns) faster than v5.0.0

33. [Type_ReflectionExtensions_Benchmark::GetPropertyEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static) v5.2.0 is **619,05%** (Δ: -80,233 ns) faster than v5.0.0

34. [Type_ReflectionExtensions_Benchmark::GetFieldEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static) v5.2.0 is **496,68%** (Δ: -68,342 ns) faster than v5.0.0

35. [Argument_Benchmark::IsMatch](#Argument_Benchmark_IsMatch) v5.2.0 is **414,98%** (Δ: -58,552 ns) faster than v5.0.0

36. [Type_ReflectionExtensions_Benchmark::GetEventsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static) v5.2.0 is **378,38%** (Δ: -37,342 ns) faster than v5.0.0

37. [Type_ReflectionExtensions_Benchmark::GetMemberEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags) v5.2.0 is **321,68%** (Δ: -46,862 ns) faster than v5.0.0

38. [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark::FastBindingList_BashRemove](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove) v5.2.0 is **121,60%** (Δ: -24,923 ns) faster than v5.0.0

39. [ValidationContext_Benchmark::GetFieldWarningCount](#ValidationContext_Benchmark_GetFieldWarningCount) v5.2.0 is **20,87%** (Δ: -9,237 ns) faster than v5.0.0

40. [Type_ReflectionExtensions_Benchmark::GetMethodEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance) v5.2.0 is **11,37%** (Δ: -7,738 ns) faster than v5.0.0

41. [Type_ReflectionExtensions_Benchmark::GetConstructorsEx](#Type_ReflectionExtensions_Benchmark_GetConstructorsEx) v5.2.0 is **7,15%** (Δ: -8,617 ns) faster than v5.0.0

42. [Argument_Benchmark::ImplementsOneOfTheInterfaces](#Argument_Benchmark_ImplementsOneOfTheInterfaces) v5.2.0 is **6,06%** (Δ: -6,567 ns) faster than v5.0.0

43. [Argument_Benchmark::ImplementsInterface_Generic](#Argument_Benchmark_ImplementsInterface_Generic) v5.2.0 is **4,10%** (Δ: -4,168 ns) faster than v5.0.0

44. [Type_ReflectionExtensions_Benchmark::GetFieldEx_Instance](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance) v5.2.0 is **3,76%** (Δ: -3,432 ns) faster than v5.0.0

45. [Argument_Benchmark::ImplementsOneOfTheInterfaces_Object](#Argument_Benchmark_ImplementsOneOfTheInterfaces_Object) v5.2.0 is **3,61%** (Δ: -3,740 ns) faster than v5.0.0

46. [Argument_Benchmark::ImplementsInterface](#Argument_Benchmark_ImplementsInterface) v5.2.0 is **3,40%** (Δ: -3,482 ns) faster than v5.0.0

47. [Argument_Benchmark::IsNotEmpty](#Argument_Benchmark_IsNotEmpty) v5.2.0 is **1,24%** (Δ: -7,947 ns) faster than v5.0.0

48. [Log_Disabled_Benchmark::Log_Info_Format_WithBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithBoxing) v5.2.0 is **1,23%** (Δ: -6,398 ns) faster than v5.0.0

49. [Log_Disabled_Benchmark::Log_Info_Format_WithoutBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing) v5.2.0 is **1,03%** (Δ: -6,453 ns) faster than v5.0.0



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
* [ExpressionHelper_Benchmark](#ExpressionHelper_Benchmark)
  * [GetOwner](#ExpressionHelper_Benchmark_GetOwner)
  * [GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName)
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
* [HashHelper_Benchmark](#HashHelper_Benchmark)
  * [HashHelper](#HashHelper_Benchmark_HashHelper)
* [LanguageHelper_Benchmark](#LanguageHelper_Benchmark)
  * [GetString](#LanguageHelper_Benchmark_GetString)
* [Log_Debug_Benchmark](#Log_Debug_Benchmark)
  * [Log_Debug_Format_1_Format_Argument](#Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument)
  * [Log_Debug_Format_2_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments)
  * [Log_Debug_Format_3_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments)
  * [Log_Debug_Format_4_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments)
  * [Log_Debug_Format_5_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments)
  * [Log_Debug_Format_6_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments)
  * [Log_Debug_Format_7_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments)
* [Log_Disabled_Benchmark](#Log_Disabled_Benchmark)
  * [Log_Info](#Log_Disabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [Log_Enabled_Benchmark](#Log_Enabled_Benchmark)
  * [Log_Info](#Log_Enabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [Log_Error_Benchmark](#Log_Error_Benchmark)
  * [Log_Error_Format_1_Format_Argument](#Log_Error_Benchmark_Log_Error_Format_1_Format_Argument)
  * [Log_Error_Format_2_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments)
  * [Log_Error_Format_3_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments)
  * [Log_Error_Format_4_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments)
  * [Log_Error_Format_5_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments)
  * [Log_Error_Format_6_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments)
  * [Log_Error_Format_7_Format_Arguments](#Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments)
* [Log_Info_Benchmark](#Log_Info_Benchmark)
  * [Log_Info_Format_1_Format_Argument](#Log_Info_Benchmark_Log_Info_Format_1_Format_Argument)
  * [Log_Info_Format_2_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments)
  * [Log_Info_Format_3_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments)
  * [Log_Info_Format_4_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments)
  * [Log_Info_Format_5_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments)
  * [Log_Info_Format_6_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments)
  * [Log_Info_Format_7_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments)
* [Log_Status_Benchmark](#Log_Status_Benchmark)
  * [Log_Status_Format_1_Format_Argument](#Log_Status_Benchmark_Log_Status_Format_1_Format_Argument)
  * [Log_Status_Format_2_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments)
  * [Log_Status_Format_3_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments)
  * [Log_Status_Format_4_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments)
  * [Log_Status_Format_5_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments)
  * [Log_Status_Format_6_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments)
  * [Log_Status_Format_7_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments)
* [Log_Warning_Benchmark](#Log_Warning_Benchmark)
  * [Log_Warning_Format_1_Format_Argument](#Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument)
  * [Log_Warning_Format_2_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments)
  * [Log_Warning_Format_3_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments)
  * [Log_Warning_Format_4_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments)
  * [Log_Warning_Format_5_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments)
  * [Log_Warning_Format_6_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments)
  * [Log_Warning_Format_7_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments)
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
* [ObjectHelper_Benchmark](#ObjectHelper_Benchmark)
  * [AreEqual__Same_Reference](#ObjectHelper_Benchmark_AreEqual__Same_Reference)
  * [AreEqual_Both_Null](#ObjectHelper_Benchmark_AreEqual_Both_Null)
  * [AreEqual_Not_Same_Reference](#ObjectHelper_Benchmark_AreEqual_Not_Same_Reference)
  * [AreEqual_One_Null](#ObjectHelper_Benchmark_AreEqual_One_Null)
  * [AreEqual_Strings](#ObjectHelper_Benchmark_AreEqual_Strings)
  * [AreEqualReferences_Both_Null](#ObjectHelper_Benchmark_AreEqualReferences_Both_Null)
  * [AreEqualReferences_Not_Same_Reference](#ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference)
  * [AreEqualReferences_One_Null](#ObjectHelper_Benchmark_AreEqualReferences_One_Null)
  * [AreEqualReferences_Same_Reference](#ObjectHelper_Benchmark_AreEqualReferences_Same_Reference)
  * [AreEqualReferences_Strings](#ObjectHelper_Benchmark_AreEqualReferences_Strings)
  * [IsNull](#ObjectHelper_Benchmark_IsNull)
* [ObjectToStringHelper_Benchmark](#ObjectToStringHelper_Benchmark)
  * [ToFullTypeString](#ObjectToStringHelper_Benchmark_ToFullTypeString)
  * [ToString_](#ObjectToStringHelper_Benchmark_ToString_)
  * [ToTypeString](#ObjectToStringHelper_Benchmark_ToTypeString)
* [ParallelHelper_Benchmark](#ParallelHelper_Benchmark)
  * [ExecuteInParallel_ItemsPerBash_100](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100)
  * [ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000)
  * [ExecuteInParallel_ItemsPerBash_500](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500)
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
* [ResourceHelper_Benchmark](#ResourceHelper_Benchmark)
  * [GetString](#ResourceHelper_Benchmark_GetString)
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
* [TagHelper_Benchmark](#TagHelper_Benchmark)
  * [AreTagsEqual](#TagHelper_Benchmark_AreTagsEqual)
  * [ToString_](#TagHelper_Benchmark_ToString_)
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
* [UniqueIdentifierHelper_Benchmark](#UniqueIdentifierHelper_Benchmark)
  * [GetUniqueIdentifier](#UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier)
  * [GetUniqueIdentifier_Generic](#UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic)
* [ValidatableModelBase_Constructor_Benchmark](#ValidatableModelBase_Constructor_Benchmark)
  * [Constructor](#ValidatableModelBase_Constructor_Benchmark_Constructor)
* [ValidationContext_Benchmark](#ValidationContext_Benchmark)
  * [GetBusinessRuleErrorCount](#ValidationContext_Benchmark_GetBusinessRuleErrorCount)
  * [GetBusinessRuleErrors](#ValidationContext_Benchmark_GetBusinessRuleErrors)
  * [GetBusinessRuleValidations](#ValidationContext_Benchmark_GetBusinessRuleValidations)
  * [GetBusinessRuleWarningCount](#ValidationContext_Benchmark_GetBusinessRuleWarningCount)
  * [GetBusinessRuleWarnings](#ValidationContext_Benchmark_GetBusinessRuleWarnings)
  * [GetErrorCount](#ValidationContext_Benchmark_GetErrorCount)
  * [GetErrors](#ValidationContext_Benchmark_GetErrors)
  * [GetFieldErrorCount](#ValidationContext_Benchmark_GetFieldErrorCount)
  * [GetFieldErrors](#ValidationContext_Benchmark_GetFieldErrors)
  * [GetFieldValidations](#ValidationContext_Benchmark_GetFieldValidations)
  * [GetFieldWarningCount](#ValidationContext_Benchmark_GetFieldWarningCount)
  * [GetFieldWarnings](#ValidationContext_Benchmark_GetFieldWarnings)
  * [GetValidations](#ValidationContext_Benchmark_GetValidations)
  * [GetWarningCount](#ValidationContext_Benchmark_GetWarningCount)
  * [GetWarnings](#ValidationContext_Benchmark_GetWarnings)
  * [HasErrors](#ValidationContext_Benchmark_HasErrors)
  * [HasWarnings](#ValidationContext_Benchmark_HasWarnings)
  * [Initialization](#ValidationContext_Benchmark_Initialization)
* [ValidationSummary_Benchmark](#ValidationSummary_Benchmark)
  * [BusinessRuleErrors](#ValidationSummary_Benchmark_BusinessRuleErrors)
  * [BusinessRuleWarnings](#ValidationSummary_Benchmark_BusinessRuleWarnings)
  * [FieldErrors](#ValidationSummary_Benchmark_FieldErrors)
  * [FieldWarnings](#ValidationSummary_Benchmark_FieldWarnings)
  * [HasBusinessRuleErrors](#ValidationSummary_Benchmark_HasBusinessRuleErrors)
  * [HasBusinessRuleWarnings](#ValidationSummary_Benchmark_HasBusinessRuleWarnings)
  * [HasErrors](#ValidationSummary_Benchmark_HasErrors)
  * [HasFieldErrors](#ValidationSummary_Benchmark_HasFieldErrors)
  * [HasFieldWarnings](#ValidationSummary_Benchmark_HasFieldWarnings)
  * [HasWarnings](#ValidationSummary_Benchmark_HasWarnings)
  * [Initialization](#ValidationSummary_Benchmark_Initialization)
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

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 13,340 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-3,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,477 ns</td><td align="right" bgcolor="#A8D08D">97,618 ns (Δ = -9,858 ns)</td><td align="right" bgcolor="#A8D08D">94,137 ns (Δ = -3,482 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#A8D08D">0,098 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,094 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 11,010 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,5 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,263 ns</td><td align="right" bgcolor="#A8D08D">98,422 ns (Δ = -6,842 ns)</td><td align="right" bgcolor="#A8D08D">94,253 ns (Δ = -4,168 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#A8D08D">0,098 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,094 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 17,763 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,8 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,408 ns</td><td align="right" bgcolor="#A8D08D">92,212 ns (Δ = -11,197 ns)</td><td align="right" bgcolor="#A8D08D">85,645 ns (Δ = -6,567 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#A8D08D">0,092 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,086 μs (Δ = -0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 10,960 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,822 ns</td><td align="right" bgcolor="#A8D08D">96,602 ns (Δ = -7,220 ns)</td><td align="right" bgcolor="#A8D08D">92,862 ns (Δ = -3,740 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#A8D08D">0,097 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,093 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 9,705 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FF4949">+26,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,093 ns</td><td align="right" bgcolor="#FFFFFF">36,065 ns (Δ = -1,028 ns)</td><td align="right" bgcolor="#FF4949">45,770 ns (Δ = +9,705 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,046 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 16,690 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FF4949">+27,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58,263 ns</td><td align="right" bgcolor="#A8D08D">41,573 ns (Δ = -16,690 ns)</td><td align="right" bgcolor="#FF4949">52,943 ns (Δ = +11,370 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#A8D08D">0,042 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FF4949">0,053 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 9,437 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,7 %</td><td align="right" bgcolor="#FF4949">+20,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">53,432 ns</td><td align="right" bgcolor="#A8D08D">43,995 ns (Δ = -9,437 ns)</td><td align="right" bgcolor="#FF4949">52,890 ns (Δ = +8,895 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#A8D08D">0,044 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FF4949">0,053 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 58,552 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">682,935 ns</td><td align="right" bgcolor="#FF4949">708,750 ns (Δ = +25,815 ns)</td><td align="right" bgcolor="#A8D08D">650,198 ns (Δ = -58,552 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FF4949">0,709 μs (Δ = +0,026 μs)</td><td align="right" bgcolor="#A8D08D">0,650 μs (Δ = -0,059 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,590 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,385 ns</td><td align="right" bgcolor="#A8D08D">13,795 ns (Δ = -0,590 ns)</td><td align="right" bgcolor="#FF4949">14,375 ns (Δ = +0,580 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,014 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,538 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+23,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,958 ns</td><td align="right" bgcolor="#A8D08D">15,405 ns (Δ = -0,553 ns)</td><td align="right" bgcolor="#FF4949">18,943 ns (Δ = +3,538 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 8,547 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+120,4 %</td><td align="right" bgcolor="#A8D08D">-50,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,098 ns</td><td align="right" bgcolor="#FF4949">15,645 ns (Δ = +8,547 ns)</td><td align="right" bgcolor="#A8D08D">7,698 ns (Δ = -7,947 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,008 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,955 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">521,312 ns</td><td align="right" bgcolor="#FFFFFF">516,252 ns (Δ = -5,060 ns)</td><td align="right" bgcolor="#FFFFFF">524,207 ns (Δ = +7,955 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,524 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 0,682 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,9 %</td><td align="right" bgcolor="#FF4949">+54,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,042 ns</td><td align="right" bgcolor="#FF4949">1,113 ns (Δ = +0,072 ns)</td><td align="right" bgcolor="#FF4949">1,723 ns (Δ = +0,610 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,325 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+49,7 %</td><td align="right" bgcolor="#FF4949">+134,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,928 ns</td><td align="right" bgcolor="#FF4949">1,390 ns (Δ = +0,462 ns)</td><td align="right" bgcolor="#FF4949">3,253 ns (Δ = +1,863 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,003 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1,740 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+17,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,663 ns</td><td align="right" bgcolor="#FFFFFF">9,683 ns (Δ = +0,020 ns)</td><td align="right" bgcolor="#FF4949">11,403 ns (Δ = +1,720 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,011 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 0,480 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,4 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,125 ns</td><td align="right" bgcolor="#FF4949">3,605 ns (Δ = +0,480 ns)</td><td align="right" bgcolor="#A8D08D">3,460 ns (Δ = -0,145 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,003 μs (Δ = 0,000 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 3,027 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#FF4949">+16,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,459 ns</td><td align="right" bgcolor="#FF4949">14,988 ns (Δ = +0,529 ns)</td><td align="right" bgcolor="#FF4949">17,487 ns (Δ = +2,498 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,017 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 16,317 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+15,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,265 ns</td><td align="right" bgcolor="#FF4949">83,335 ns (Δ = +3,070 ns)</td><td align="right" bgcolor="#FF4949">96,582 ns (Δ = +13,247 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FF4949">0,083 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,097 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 15,167 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FF4949">+14,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">89,055 ns</td><td align="right" bgcolor="#FFFFFF">91,313 ns (Δ = +2,258 ns)</td><td align="right" bgcolor="#FF4949">104,222 ns (Δ = +12,908 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,104 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,353 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FF4949">+14,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,425 ns</td><td align="right" bgcolor="#FFFFFF">57,283 ns (Δ = -0,142 ns)</td><td align="right" bgcolor="#FF4949">65,637 ns (Δ = +8,353 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,066 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 5,013 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+7,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">69,738 ns</td><td align="right" bgcolor="#A8D08D">67,322 ns (Δ = -2,417 ns)</td><td align="right" bgcolor="#FF4949">72,335 ns (Δ = +5,013 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#A8D08D">0,067 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,072 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,293 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,915 ns</td><td align="right" bgcolor="#A8D08D">23,842 ns (Δ = -1,073 ns)</td><td align="right" bgcolor="#FF4949">26,135 ns (Δ = +2,293 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,026 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -24,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,023)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 10,720 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#FF4949">+15,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">59,450 ns</td><td align="right" bgcolor="#FFFFFF">60,803 ns (Δ = +1,353 ns)</td><td align="right" bgcolor="#FF4949">70,170 ns (Δ = +9,367 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,070 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 2,622 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">66,943 ns</td><td align="right" bgcolor="#FF4949">69,565 ns (Δ = +2,622 ns)</td><td align="right" bgcolor="#FFFFFF">69,477 ns (Δ = -0,088 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FF4949">0,070 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,069 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 4,953 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,102 ns</td><td align="right" bgcolor="#FF4949">40,555 ns (Δ = +1,453 ns)</td><td align="right" bgcolor="#FF4949">44,055 ns (Δ = +3,500 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,044 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 2,935 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">47,482 ns</td><td align="right" bgcolor="#FF4949">50,417 ns (Δ = +2,935 ns)</td><td align="right" bgcolor="#FFFFFF">50,052 ns (Δ = -0,365 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FF4949">0,050 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 859,655 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+11,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7488,637 ns</td><td align="right" bgcolor="#FFFFFF">7412,358 ns (Δ = -76,278 ns)</td><td align="right" bgcolor="#FF4949">8272,013 ns (Δ = +859,655 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,489 μs</td><td align="right" bgcolor="#FFFFFF">7,412 μs (Δ = -0,076 μs)</td><td align="right" bgcolor="#FF4949">8,272 μs (Δ = +0,860 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 768,500 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7472,713 ns</td><td align="right" bgcolor="#FFFFFF">7491,780 ns (Δ = +19,067 ns)</td><td align="right" bgcolor="#FF4949">8241,213 ns (Δ = +749,433 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,473 μs</td><td align="right" bgcolor="#FFFFFF">7,492 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#FF4949">8,241 μs (Δ = +0,749 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 5870,045 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+40,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14592,557 ns</td><td align="right" bgcolor="#FFFFFF">14577,323 ns (Δ = -15,233 ns)</td><td align="right" bgcolor="#FF4949">20447,368 ns (Δ = +5870,045 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,593 μs</td><td align="right" bgcolor="#FFFFFF">14,577 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">20,447 μs (Δ = +5,870 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,020 ms (Δ = +0,006 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1364,000</td><td align="right" bgcolor="#FFFFFF">1376,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -688,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,332</td><td align="right" bgcolor="#FFFFFF">1,344 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,672)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 3473,423 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+56,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5948,617 ns</td><td align="right" bgcolor="#FFFFFF">6016,142 ns (Δ = +67,525 ns)</td><td align="right" bgcolor="#FF4949">9422,040 ns (Δ = +3405,898 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,949 μs</td><td align="right" bgcolor="#FFFFFF">6,016 μs (Δ = +0,068 μs)</td><td align="right" bgcolor="#FF4949">9,422 μs (Δ = +3,406 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,003 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3011,000</td><td align="right" bgcolor="#FFFFFF">3043,000 (Δ = +32,000)</td><td align="right" bgcolor="#A8D08D">1523,000 (Δ = -1520,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,940</td><td align="right" bgcolor="#FFFFFF">2,972 (Δ = +0,031)</td><td align="right" bgcolor="#A8D08D">1,487 (Δ = -1,484)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 393,823 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9579,127 ns</td><td align="right" bgcolor="#FFFFFF">9492,742 ns (Δ = -86,385 ns)</td><td align="right" bgcolor="#FF4949">9886,565 ns (Δ = +393,823 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,579 μs</td><td align="right" bgcolor="#FFFFFF">9,493 μs (Δ = -0,086 μs)</td><td align="right" bgcolor="#FF4949">9,887 μs (Δ = +0,394 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">430,000 (Δ = -406,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,420 (Δ = -0,396)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 361,407 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9689,053 ns</td><td align="right" bgcolor="#FFFFFF">9624,323 ns (Δ = -64,730 ns)</td><td align="right" bgcolor="#FF4949">9985,730 ns (Δ = +361,407 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,689 μs</td><td align="right" bgcolor="#FFFFFF">9,624 μs (Δ = -0,065 μs)</td><td align="right" bgcolor="#FF4949">9,986 μs (Δ = +0,361 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">479,000 (Δ = -402,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,468 (Δ = -0,393)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 391,025 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9496,345 ns</td><td align="right" bgcolor="#FFFFFF">9472,473 ns (Δ = -23,872 ns)</td><td align="right" bgcolor="#FF4949">9863,498 ns (Δ = +391,025 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,496 μs</td><td align="right" bgcolor="#FFFFFF">9,472 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">9,863 μs (Δ = +0,391 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 178836,553 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-40,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">438958,620 ns</td><td align="right" bgcolor="#FFFFFF">440561,173 ns (Δ = +1602,553 ns)</td><td align="right" bgcolor="#A8D08D">261724,620 ns (Δ = -178836,553 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">438,959 μs</td><td align="right" bgcolor="#FFFFFF">440,561 μs (Δ = +1,603 μs)</td><td align="right" bgcolor="#A8D08D">261,725 μs (Δ = -178,837 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,439 ms</td><td align="right" bgcolor="#FFFFFF">0,441 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,262 ms (Δ = -0,179 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FFFFFF">30,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -10,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">20,000 (Δ = +5,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-46,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20467,000</td><td align="right" bgcolor="#FFFFFF">20467,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">10920,000 (Δ = -9547,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">19,987</td><td align="right" bgcolor="#FFFFFF">19,987 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">10,664 (Δ = -9,323)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,009)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 905,302 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+37,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2440,497 ns</td><td align="right" bgcolor="#FFFFFF">2442,707 ns (Δ = +2,210 ns)</td><td align="right" bgcolor="#FF4949">3345,798 ns (Δ = +903,092 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,440 μs</td><td align="right" bgcolor="#FFFFFF">2,443 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">3,346 μs (Δ = +0,903 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-25,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#FFFFFF">1012,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">750,000 (Δ = -262,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#FFFFFF">0,988 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,732 (Δ = -0,256)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 594,253 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FF4949">+7,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8225,185 ns</td><td align="right" bgcolor="#A8D08D">7684,505 ns (Δ = -540,680 ns)</td><td align="right" bgcolor="#FF4949">8278,758 ns (Δ = +594,253 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,225 μs</td><td align="right" bgcolor="#A8D08D">7,685 μs (Δ = -0,541 μs)</td><td align="right" bgcolor="#FF4949">8,279 μs (Δ = +0,594 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FFFFFF">770,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">422,000 (Δ = -348,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FFFFFF">0,752 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,412 (Δ = -0,340)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 308,260 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9706,170 ns</td><td align="right" bgcolor="#FFFFFF">9555,422 ns (Δ = -150,748 ns)</td><td align="right" bgcolor="#FF4949">9863,682 ns (Δ = +308,260 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,706 μs</td><td align="right" bgcolor="#FFFFFF">9,555 μs (Δ = -0,151 μs)</td><td align="right" bgcolor="#FF4949">9,864 μs (Δ = +0,308 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 309,522 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9497,120 ns</td><td align="right" bgcolor="#FFFFFF">9582,527 ns (Δ = +85,407 ns)</td><td align="right" bgcolor="#FFFFFF">9806,642 ns (Δ = +224,115 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,497 μs</td><td align="right" bgcolor="#FFFFFF">9,583 μs (Δ = +0,085 μs)</td><td align="right" bgcolor="#FFFFFF">9,807 μs (Δ = +0,224 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 13,285 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">945,768 ns</td><td align="right" bgcolor="#FFFFFF">952,005 ns (Δ = +6,237 ns)</td><td align="right" bgcolor="#FFFFFF">938,720 ns (Δ = -13,285 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,939 μs (Δ = -0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-28,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#FFFFFF">1233,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">881,000 (Δ = -352,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#FFFFFF">1,204 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,860 (Δ = -0,344)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 473,840 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+17,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2514,007 ns</td><td align="right" bgcolor="#FFFFFF">2547,713 ns (Δ = +33,707 ns)</td><td align="right" bgcolor="#FF4949">2987,847 ns (Δ = +440,133 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,514 μs</td><td align="right" bgcolor="#FFFFFF">2,548 μs (Δ = +0,034 μs)</td><td align="right" bgcolor="#FF4949">2,988 μs (Δ = +0,440 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 309,130 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+9,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3292,138 ns</td><td align="right" bgcolor="#FFFFFF">3295,967 ns (Δ = +3,828 ns)</td><td align="right" bgcolor="#FF4949">3601,268 ns (Δ = +305,302 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,292 μs</td><td align="right" bgcolor="#FFFFFF">3,296 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FF4949">3,601 μs (Δ = +0,305 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 604,598 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+23,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2658,373 ns</td><td align="right" bgcolor="#FFFFFF">2619,160 ns (Δ = -39,213 ns)</td><td align="right" bgcolor="#FF4949">3223,758 ns (Δ = +604,598 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,658 μs</td><td align="right" bgcolor="#FFFFFF">2,619 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#FF4949">3,224 μs (Δ = +0,605 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 236,051 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FF4949">+7,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3372,573 ns</td><td align="right" bgcolor="#FFFFFF">3357,545 ns (Δ = -15,028 ns)</td><td align="right" bgcolor="#FF4949">3593,596 ns (Δ = +236,051 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,373 μs</td><td align="right" bgcolor="#FFFFFF">3,358 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">3,594 μs (Δ = +0,236 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 728,385 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+28,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2585,122 ns</td><td align="right" bgcolor="#FFFFFF">2556,440 ns (Δ = -28,682 ns)</td><td align="right" bgcolor="#FF4949">3284,825 ns (Δ = +728,385 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,585 μs</td><td align="right" bgcolor="#FFFFFF">2,556 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FF4949">3,285 μs (Δ = +0,728 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 428,765 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+12,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3300,460 ns</td><td align="right" bgcolor="#FFFFFF">3302,712 ns (Δ = +2,252 ns)</td><td align="right" bgcolor="#FF4949">3729,225 ns (Δ = +426,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,300 μs</td><td align="right" bgcolor="#FFFFFF">3,303 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">3,729 μs (Δ = +0,427 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 474,065 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FF4949">+16,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2547,837 ns</td><td align="right" bgcolor="#FFFFFF">2597,428 ns (Δ = +49,592 ns)</td><td align="right" bgcolor="#FF4949">3021,902 ns (Δ = +424,473 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,548 μs</td><td align="right" bgcolor="#FFFFFF">2,597 μs (Δ = +0,050 μs)</td><td align="right" bgcolor="#FF4949">3,022 μs (Δ = +0,424 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 298,935 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+8,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3321,318 ns</td><td align="right" bgcolor="#FFFFFF">3335,147 ns (Δ = +13,828 ns)</td><td align="right" bgcolor="#FF4949">3620,253 ns (Δ = +285,107 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,321 μs</td><td align="right" bgcolor="#FFFFFF">3,335 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FF4949">3,620 μs (Δ = +0,285 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 466,738 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FF4949">+16,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2519,867 ns</td><td align="right" bgcolor="#FFFFFF">2555,173 ns (Δ = +35,307 ns)</td><td align="right" bgcolor="#FF4949">2986,605 ns (Δ = +431,432 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,520 μs</td><td align="right" bgcolor="#FFFFFF">2,555 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FF4949">2,987 μs (Δ = +0,431 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 357,842 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3253,813 ns</td><td align="right" bgcolor="#FFFFFF">3314,532 ns (Δ = +60,718 ns)</td><td align="right" bgcolor="#FF4949">3611,655 ns (Δ = +297,123 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,254 μs</td><td align="right" bgcolor="#FFFFFF">3,315 μs (Δ = +0,061 μs)</td><td align="right" bgcolor="#FF4949">3,612 μs (Δ = +0,297 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 435,483 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+15,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2605,985 ns</td><td align="right" bgcolor="#FFFFFF">2630,910 ns (Δ = +24,925 ns)</td><td align="right" bgcolor="#FF4949">3041,468 ns (Δ = +410,558 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,606 μs</td><td align="right" bgcolor="#FFFFFF">2,631 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FF4949">3,041 μs (Δ = +0,411 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 377,882 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+11,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3294,672 ns</td><td align="right" bgcolor="#FFFFFF">3283,345 ns (Δ = -11,327 ns)</td><td align="right" bgcolor="#FF4949">3661,227 ns (Δ = +377,882 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,295 μs</td><td align="right" bgcolor="#FFFFFF">3,283 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">3,661 μs (Δ = +0,378 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 21,905 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,712 ns</td><td align="right" bgcolor="#FFFFFF">237,660 ns (Δ = +2,948 ns)</td><td align="right" bgcolor="#FF4949">256,617 ns (Δ = +18,957 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,238 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,257 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 21,438 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">250,162 ns</td><td align="right" bgcolor="#A8D08D">238,620 ns (Δ = -11,542 ns)</td><td align="right" bgcolor="#FF4949">260,058 ns (Δ = +21,438 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,250 μs</td><td align="right" bgcolor="#A8D08D">0,239 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FF4949">0,260 μs (Δ = +0,021 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-46,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 20,665 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">246,100 ns</td><td align="right" bgcolor="#FFFFFF">241,095 ns (Δ = -5,005 ns)</td><td align="right" bgcolor="#FF4949">261,760 ns (Δ = +20,665 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,241 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,262 μs (Δ = +0,021 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-46,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 19,223 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">230,905 ns</td><td align="right" bgcolor="#A8D08D">224,033 ns (Δ = -6,872 ns)</td><td align="right" bgcolor="#FF4949">243,257 ns (Δ = +19,223 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#A8D08D">0,224 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,243 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 22,238 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+8,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,377 ns</td><td align="right" bgcolor="#FFFFFF">223,645 ns (Δ = +2,268 ns)</td><td align="right" bgcolor="#FF4949">243,615 ns (Δ = +19,970 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,244 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 22,308 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,928 ns</td><td align="right" bgcolor="#FFFFFF">235,952 ns (Δ = +1,023 ns)</td><td align="right" bgcolor="#FF4949">257,237 ns (Δ = +21,285 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,257 μs (Δ = +0,021 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 84,812 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+9,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">850,628 ns</td><td align="right" bgcolor="#FFFFFF">851,700 ns (Δ = +1,072 ns)</td><td align="right" bgcolor="#FF4949">935,440 ns (Δ = +83,740 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,852 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,935 μs (Δ = +0,084 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#FFFFFF">188,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -94,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,092)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 12,525 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#FF4949">+10,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,057 ns</td><td align="right" bgcolor="#A8D08D">119,683 ns (Δ = -5,373 ns)</td><td align="right" bgcolor="#FF4949">132,208 ns (Δ = +12,525 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#A8D08D">0,120 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,132 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 11,490 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FF4949">+8,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">142,617 ns</td><td align="right" bgcolor="#FFFFFF">138,925 ns (Δ = -3,692 ns)</td><td align="right" bgcolor="#FF4949">150,415 ns (Δ = +11,490 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,150 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-36,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 344,992 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,1 %</td><td align="right" bgcolor="#A8D08D">-10,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2111,522 ns</td><td align="right" bgcolor="#A8D08D">1982,110 ns (Δ = -129,412 ns)</td><td align="right" bgcolor="#A8D08D">1766,530 ns (Δ = -215,580 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,112 μs</td><td align="right" bgcolor="#A8D08D">1,982 μs (Δ = -0,129 μs)</td><td align="right" bgcolor="#A8D08D">1,767 μs (Δ = -0,216 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#FFFFFF">913,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -446,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#FFFFFF">0,892 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,436)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 492,007 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,5 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4199,630 ns</td><td align="right" bgcolor="#A8D08D">3886,295 ns (Δ = -313,335 ns)</td><td align="right" bgcolor="#A8D08D">3707,623 ns (Δ = -178,672 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,200 μs</td><td align="right" bgcolor="#A8D08D">3,886 μs (Δ = -0,313 μs)</td><td align="right" bgcolor="#A8D08D">3,708 μs (Δ = -0,179 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-46,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">594,000 (Δ = -512,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,580 (Δ = -0,500)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 29,210 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">281,752 ns</td><td align="right" bgcolor="#FFFFFF">283,937 ns (Δ = +2,185 ns)</td><td align="right" bgcolor="#FF4949">310,962 ns (Δ = +27,025 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,284 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,311 μs (Δ = +0,027 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 95,622 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3911,878 ns</td><td align="right" bgcolor="#FFFFFF">3862,925 ns (Δ = -48,953 ns)</td><td align="right" bgcolor="#FFFFFF">3816,257 ns (Δ = -46,668 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,912 μs</td><td align="right" bgcolor="#FFFFFF">3,863 μs (Δ = -0,049 μs)</td><td align="right" bgcolor="#FFFFFF">3,816 μs (Δ = -0,047 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#FFFFFF">1196,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">651,000 (Δ = -545,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#FFFFFF">1,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,636 (Δ = -0,532)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 41,983 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FF4949">+14,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">291,615 ns</td><td align="right" bgcolor="#FFFFFF">289,848 ns (Δ = -1,767 ns)</td><td align="right" bgcolor="#FF4949">331,832 ns (Δ = +41,983 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,332 μs (Δ = +0,042 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 35,390 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+12,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">293,157 ns</td><td align="right" bgcolor="#FFFFFF">291,712 ns (Δ = -1,445 ns)</td><td align="right" bgcolor="#FF4949">327,102 ns (Δ = +35,390 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,327 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 23,068 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+7,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">291,558 ns</td><td align="right" bgcolor="#FFFFFF">293,678 ns (Δ = +2,120 ns)</td><td align="right" bgcolor="#FF4949">314,627 ns (Δ = +20,948 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,315 μs (Δ = +0,021 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 30,218 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FF4949">+10,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">289,767 ns</td><td align="right" bgcolor="#FFFFFF">286,368 ns (Δ = -3,398 ns)</td><td align="right" bgcolor="#FF4949">316,587 ns (Δ = +30,218 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,317 μs (Δ = +0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 144,412 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1849,728 ns</td><td align="right" bgcolor="#FFFFFF">1854,500 ns (Δ = +4,772 ns)</td><td align="right" bgcolor="#A8D08D">1710,088 ns (Δ = -144,412 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,850 μs</td><td align="right" bgcolor="#FFFFFF">1,855 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">1,710 μs (Δ = -0,144 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">336,000 (Δ = -315,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,328 (Δ = -0,308)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 380,823 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3883,657 ns</td><td align="right" bgcolor="#A8D08D">3619,375 ns (Δ = -264,282 ns)</td><td align="right" bgcolor="#A8D08D">3502,833 ns (Δ = -116,542 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,884 μs</td><td align="right" bgcolor="#A8D08D">3,619 μs (Δ = -0,264 μs)</td><td align="right" bgcolor="#A8D08D">3,503 μs (Δ = -0,117 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#A8D08D">-31,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#FFFFFF">1986,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">1368,000 (Δ = -618,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#FFFFFF">1,939 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">1,336 (Δ = -0,604)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 512,747 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+187,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">270,047 ns</td><td align="right" bgcolor="#FFFFFF">272,203 ns (Δ = +2,157 ns)</td><td align="right" bgcolor="#FF4949">782,793 ns (Δ = +510,590 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,783 μs (Δ = +0,511 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 56,202 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+127,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,927 ns</td><td align="right" bgcolor="#FFFFFF">44,267 ns (Δ = -0,660 ns)</td><td align="right" bgcolor="#FF4949">100,468 ns (Δ = +56,202 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,100 μs (Δ = +0,056 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,118 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,449 ns</td><td align="right" bgcolor="#FFFFFF">6,350 ns (Δ = -0,099 ns)</td><td align="right" bgcolor="#FFFFFF">6,332 ns (Δ = -0,018 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,006 μs (Δ = 0,000 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1,082 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,9 %</td><td align="right" bgcolor="#FF4949">+5,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,353 ns</td><td align="right" bgcolor="#A8D08D">7,272 ns (Δ = -1,082 ns)</td><td align="right" bgcolor="#FF4949">7,638 ns (Δ = +0,367 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 193,728 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,5 %</td><td align="right" bgcolor="#FF4949">+7,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">956,855 ns</td><td align="right" bgcolor="#FF4949">1066,765 ns (Δ = +109,910 ns)</td><td align="right" bgcolor="#FF4949">1150,583 ns (Δ = +83,818 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FF4949">1,067 μs (Δ = +0,110 μs)</td><td align="right" bgcolor="#FF4949">1,151 μs (Δ = +0,084 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#A8D08D">-22,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1136,000</td><td align="right" bgcolor="#FF4949">1230,000 (Δ = +94,000)</td><td align="right" bgcolor="#A8D08D">948,000 (Δ = -282,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,109</td><td align="right" bgcolor="#FF4949">1,201 (Δ = +0,092)</td><td align="right" bgcolor="#A8D08D">0,926 (Δ = -0,275)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 49,352 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,3 %</td><td align="right" bgcolor="#A8D08D">-5,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">438,560 ns</td><td align="right" bgcolor="#FF4949">487,912 ns (Δ = +49,352 ns)</td><td align="right" bgcolor="#A8D08D">462,988 ns (Δ = -24,923 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FF4949">0,488 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">0,463 μs (Δ = -0,025 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">459,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -99,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,448 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,352 (Δ = -0,097)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 315,430 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,5 %</td><td align="right" bgcolor="#A8D08D">-12,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2344,235 ns</td><td align="right" bgcolor="#FF4949">2472,600 ns (Δ = +128,365 ns)</td><td align="right" bgcolor="#A8D08D">2157,170 ns (Δ = -315,430 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,344 μs</td><td align="right" bgcolor="#FF4949">2,473 μs (Δ = +0,128 μs)</td><td align="right" bgcolor="#A8D08D">2,157 μs (Δ = -0,315 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-43,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4126,000</td><td align="right" bgcolor="#FFFFFF">4225,000 (Δ = +99,000)</td><td align="right" bgcolor="#A8D08D">2402,000 (Δ = -1823,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,029</td><td align="right" bgcolor="#FFFFFF">4,126 (Δ = +0,097)</td><td align="right" bgcolor="#A8D08D">2,346 (Δ = -1,780)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 67,948 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">941,407 ns</td><td align="right" bgcolor="#FFFFFF">945,273 ns (Δ = +3,867 ns)</td><td align="right" bgcolor="#A8D08D">877,325 ns (Δ = -67,948 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,941 μs</td><td align="right" bgcolor="#FFFFFF">0,945 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,877 μs (Δ = -0,068 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2017,000</td><td align="right" bgcolor="#FFFFFF">2017,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">1153,000 (Δ = -864,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,970</td><td align="right" bgcolor="#FFFFFF">1,970 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">1,126 (Δ = -0,844)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 6,070 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#FF4949">+29,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,237 ns</td><td align="right" bgcolor="#A8D08D">20,963 ns (Δ = -1,273 ns)</td><td align="right" bgcolor="#FF4949">27,033 ns (Δ = +6,070 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,027 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-19,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">53,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,052 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 208,383 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,9 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">615,182 ns</td><td align="right" bgcolor="#A8D08D">406,798 ns (Δ = -208,383 ns)</td><td align="right" bgcolor="#FFFFFF">407,957 ns (Δ = +1,158 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#A8D08D">0,407 μs (Δ = -0,208 μs)</td><td align="right" bgcolor="#FFFFFF">0,408 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 88,915 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+15,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">606,397 ns</td><td align="right" bgcolor="#A8D08D">587,918 ns (Δ = -18,478 ns)</td><td align="right" bgcolor="#FF4949">676,833 ns (Δ = +88,915 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,606 μs</td><td align="right" bgcolor="#A8D08D">0,588 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FF4949">0,677 μs (Δ = +0,089 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 130,868 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,6 %</td><td align="right" bgcolor="#FF4949">+18,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">749,260 ns</td><td align="right" bgcolor="#A8D08D">692,622 ns (Δ = -56,638 ns)</td><td align="right" bgcolor="#FF4949">823,490 ns (Δ = +130,868 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,749 μs</td><td align="right" bgcolor="#A8D08D">0,693 μs (Δ = -0,057 μs)</td><td align="right" bgcolor="#FF4949">0,823 μs (Δ = +0,131 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 131,487 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+15,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">885,065 ns</td><td align="right" bgcolor="#A8D08D">828,745 ns (Δ = -56,320 ns)</td><td align="right" bgcolor="#FF4949">960,232 ns (Δ = +131,487 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#A8D08D">0,829 μs (Δ = -0,056 μs)</td><td align="right" bgcolor="#FF4949">0,960 μs (Δ = +0,131 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 124,355 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+11,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1039,200 ns</td><td align="right" bgcolor="#FFFFFF">1046,858 ns (Δ = +7,658 ns)</td><td align="right" bgcolor="#FF4949">1163,555 ns (Δ = +116,697 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,039 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FF4949">1,164 μs (Δ = +0,117 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 129,535 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FF4949">+11,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1185,028 ns</td><td align="right" bgcolor="#FFFFFF">1154,145 ns (Δ = -30,883 ns)</td><td align="right" bgcolor="#FF4949">1283,680 ns (Δ = +129,535 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,185 μs</td><td align="right" bgcolor="#FFFFFF">1,154 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FF4949">1,284 μs (Δ = +0,130 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 216,193 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FF4949">+14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1318,613 ns</td><td align="right" bgcolor="#FFFFFF">1346,228 ns (Δ = +27,615 ns)</td><td align="right" bgcolor="#FF4949">1534,807 ns (Δ = +188,578 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,319 μs</td><td align="right" bgcolor="#FFFFFF">1,346 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FF4949">1,535 μs (Δ = +0,189 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 279,183 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FF4949">+17,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1466,237 ns</td><td align="right" bgcolor="#FFFFFF">1487,470 ns (Δ = +21,233 ns)</td><td align="right" bgcolor="#FF4949">1745,420 ns (Δ = +257,950 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,466 μs</td><td align="right" bgcolor="#FFFFFF">1,487 μs (Δ = +0,021 μs)</td><td align="right" bgcolor="#FF4949">1,745 μs (Δ = +0,258 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 4,758 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#A8D08D">-87,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,432 ns</td><td align="right" bgcolor="#FFFFFF">5,350 ns (Δ = -0,082 ns)</td><td align="right" bgcolor="#A8D08D">0,673 ns (Δ = -4,677 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 8,288 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,9 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,122 ns</td><td align="right" bgcolor="#A8D08D">19,232 ns (Δ = -1,890 ns)</td><td align="right" bgcolor="#A8D08D">12,833 ns (Δ = -6,398 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 6,580 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#A8D08D">-40,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,092 ns</td><td align="right" bgcolor="#FFFFFF">15,965 ns (Δ = -0,127 ns)</td><td align="right" bgcolor="#A8D08D">9,512 ns (Δ = -6,453 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 118,172 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,1 %</td><td align="right" bgcolor="#FF4949">+43,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">299,450 ns</td><td align="right" bgcolor="#A8D08D">272,113 ns (Δ = -27,337 ns)</td><td align="right" bgcolor="#FF4949">390,285 ns (Δ = +118,172 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td><td align="right" bgcolor="#A8D08D">0,272 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,390 μs (Δ = +0,118 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#A8D08D">-37,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -62,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,061)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 104,903 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">687,120 ns</td><td align="right" bgcolor="#A8D08D">587,125 ns (Δ = -99,995 ns)</td><td align="right" bgcolor="#FF4949">692,028 ns (Δ = +104,903 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td><td align="right" bgcolor="#A8D08D">0,587 μs (Δ = -0,100 μs)</td><td align="right" bgcolor="#FF4949">0,692 μs (Δ = +0,105 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-32,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">385,000</td><td align="right" bgcolor="#A8D08D">352,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">238,000 (Δ = -114,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,376</td><td align="right" bgcolor="#A8D08D">0,344 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,232 (Δ = -0,111)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 175,942 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,9 %</td><td align="right" bgcolor="#FF4949">+25,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">680,230 ns</td><td align="right" bgcolor="#A8D08D">504,288 ns (Δ = -175,942 ns)</td><td align="right" bgcolor="#FF4949">630,567 ns (Δ = +126,278 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,680 μs</td><td align="right" bgcolor="#A8D08D">0,504 μs (Δ = -0,176 μs)</td><td align="right" bgcolor="#FF4949">0,631 μs (Δ = +0,126 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#A8D08D">-26,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">377,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -90,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,368</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,088)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 118,063 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#FF4949">+21,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">605,982 ns</td><td align="right" bgcolor="#A8D08D">555,600 ns (Δ = -50,382 ns)</td><td align="right" bgcolor="#FF4949">673,663 ns (Δ = +118,063 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,606 μs</td><td align="right" bgcolor="#A8D08D">0,556 μs (Δ = -0,050 μs)</td><td align="right" bgcolor="#FF4949">0,674 μs (Δ = +0,118 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 142,187 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FF4949">+20,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">746,233 ns</td><td align="right" bgcolor="#A8D08D">688,167 ns (Δ = -58,067 ns)</td><td align="right" bgcolor="#FF4949">830,353 ns (Δ = +142,187 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#A8D08D">0,688 μs (Δ = -0,058 μs)</td><td align="right" bgcolor="#FF4949">0,830 μs (Δ = +0,142 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 122,722 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+14,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">891,762 ns</td><td align="right" bgcolor="#A8D08D">834,948 ns (Δ = -56,814 ns)</td><td align="right" bgcolor="#FF4949">957,670 ns (Δ = +122,722 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#A8D08D">0,835 μs (Δ = -0,057 μs)</td><td align="right" bgcolor="#FF4949">0,958 μs (Δ = +0,123 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 138,935 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+13,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1041,897 ns</td><td align="right" bgcolor="#A8D08D">1003,700 ns (Δ = -38,197 ns)</td><td align="right" bgcolor="#FF4949">1142,635 ns (Δ = +138,935 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,042 μs</td><td align="right" bgcolor="#A8D08D">1,004 μs (Δ = -0,038 μs)</td><td align="right" bgcolor="#FF4949">1,143 μs (Δ = +0,139 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 169,892 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+14,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1172,735 ns</td><td align="right" bgcolor="#FFFFFF">1149,118 ns (Δ = -23,617 ns)</td><td align="right" bgcolor="#FF4949">1319,010 ns (Δ = +169,892 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,149 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">1,319 μs (Δ = +0,170 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 813,035 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#FF4949">+58,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1316,348 ns</td><td align="right" bgcolor="#FFFFFF">1346,458 ns (Δ = +30,110 ns)</td><td align="right" bgcolor="#FF4949">2129,383 ns (Δ = +782,925 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,316 μs</td><td align="right" bgcolor="#FFFFFF">1,346 μs (Δ = +0,030 μs)</td><td align="right" bgcolor="#FF4949">2,129 μs (Δ = +0,783 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 229,928 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FF4949">+13,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1462,613 ns</td><td align="right" bgcolor="#FFFFFF">1489,928 ns (Δ = +27,315 ns)</td><td align="right" bgcolor="#FF4949">1692,541 ns (Δ = +202,613 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,490 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#FF4949">1,693 μs (Δ = +0,203 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 94,920 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,9 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">682,365 ns</td><td align="right" bgcolor="#A8D08D">587,445 ns (Δ = -94,920 ns)</td><td align="right" bgcolor="#FF4949">677,380 ns (Δ = +89,935 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td><td align="right" bgcolor="#A8D08D">0,587 μs (Δ = -0,095 μs)</td><td align="right" bgcolor="#FF4949">0,677 μs (Δ = +0,090 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 123,318 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FF4949">+16,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">764,543 ns</td><td align="right" bgcolor="#A8D08D">732,197 ns (Δ = -32,347 ns)</td><td align="right" bgcolor="#FF4949">855,515 ns (Δ = +123,318 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,765 μs</td><td align="right" bgcolor="#A8D08D">0,732 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FF4949">0,856 μs (Δ = +0,123 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">274,000 (Δ = -144,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,268 (Δ = -0,141)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 99,505 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+11,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">895,475 ns</td><td align="right" bgcolor="#FFFFFF">892,413 ns (Δ = -3,062 ns)</td><td align="right" bgcolor="#FF4949">991,918 ns (Δ = +99,505 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,895 μs</td><td align="right" bgcolor="#FFFFFF">0,892 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,992 μs (Δ = +0,100 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-35,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">500,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">324,000 (Δ = -176,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,488 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,316 (Δ = -0,172)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 112,880 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FF4949">+11,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1035,982 ns</td><td align="right" bgcolor="#FFFFFF">1016,988 ns (Δ = -18,993 ns)</td><td align="right" bgcolor="#FF4949">1129,868 ns (Δ = +112,880 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,036 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#FF4949">1,130 μs (Δ = +0,113 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 123,718 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FF4949">+10,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1196,800 ns</td><td align="right" bgcolor="#A8D08D">1157,810 ns (Δ = -38,990 ns)</td><td align="right" bgcolor="#FF4949">1281,528 ns (Δ = +123,718 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,197 μs</td><td align="right" bgcolor="#A8D08D">1,158 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#FF4949">1,282 μs (Δ = +0,124 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 151,137 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+11,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1320,347 ns</td><td align="right" bgcolor="#FFFFFF">1289,087 ns (Δ = -31,260 ns)</td><td align="right" bgcolor="#FF4949">1440,223 ns (Δ = +151,137 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,320 μs</td><td align="right" bgcolor="#FFFFFF">1,289 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FF4949">1,440 μs (Δ = +0,151 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">737,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -270,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,720 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,264)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 117,237 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+8,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1450,278 ns</td><td align="right" bgcolor="#FFFFFF">1442,375 ns (Δ = -7,903 ns)</td><td align="right" bgcolor="#FF4949">1559,612 ns (Δ = +117,237 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,450 μs</td><td align="right" bgcolor="#FFFFFF">1,442 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">1,560 μs (Δ = +0,117 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">819,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -303,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,800 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,296)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 81,833 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FF4949">+14,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">607,537 ns</td><td align="right" bgcolor="#A8D08D">559,598 ns (Δ = -47,938 ns)</td><td align="right" bgcolor="#FF4949">641,432 ns (Δ = +81,833 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,608 μs</td><td align="right" bgcolor="#A8D08D">0,560 μs (Δ = -0,048 μs)</td><td align="right" bgcolor="#FF4949">0,641 μs (Δ = +0,082 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 107,442 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">737,630 ns</td><td align="right" bgcolor="#A8D08D">701,415 ns (Δ = -36,215 ns)</td><td align="right" bgcolor="#FF4949">808,857 ns (Δ = +107,442 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#A8D08D">0,701 μs (Δ = -0,036 μs)</td><td align="right" bgcolor="#FF4949">0,809 μs (Δ = +0,107 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 126,820 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+15,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">896,222 ns</td><td align="right" bgcolor="#A8D08D">836,320 ns (Δ = -59,902 ns)</td><td align="right" bgcolor="#FF4949">963,140 ns (Δ = +126,820 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,896 μs</td><td align="right" bgcolor="#A8D08D">0,836 μs (Δ = -0,060 μs)</td><td align="right" bgcolor="#FF4949">0,963 μs (Δ = +0,127 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 113,717 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FF4949">+11,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1035,653 ns</td><td align="right" bgcolor="#FFFFFF">1015,733 ns (Δ = -19,920 ns)</td><td align="right" bgcolor="#FF4949">1129,450 ns (Δ = +113,717 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,036 μs</td><td align="right" bgcolor="#FFFFFF">1,016 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FF4949">1,129 μs (Δ = +0,114 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 96,240 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+8,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1167,802 ns</td><td align="right" bgcolor="#FFFFFF">1162,425 ns (Δ = -5,377 ns)</td><td align="right" bgcolor="#FF4949">1258,665 ns (Δ = +96,240 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,168 μs</td><td align="right" bgcolor="#FFFFFF">1,162 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">1,259 μs (Δ = +0,096 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 178,897 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FF4949">+9,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1320,710 ns</td><td align="right" bgcolor="#FF4949">1365,647 ns (Δ = +44,937 ns)</td><td align="right" bgcolor="#FF4949">1499,607 ns (Δ = +133,960 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,321 μs</td><td align="right" bgcolor="#FF4949">1,366 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#FF4949">1,500 μs (Δ = +0,134 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 246,767 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1440,243 ns</td><td align="right" bgcolor="#FF4949">1498,112 ns (Δ = +57,868 ns)</td><td align="right" bgcolor="#FF4949">1687,010 ns (Δ = +188,898 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,440 μs</td><td align="right" bgcolor="#FF4949">1,498 μs (Δ = +0,058 μs)</td><td align="right" bgcolor="#FF4949">1,687 μs (Δ = +0,189 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 112,885 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FF4949">+20,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">601,110 ns</td><td align="right" bgcolor="#A8D08D">553,698 ns (Δ = -47,412 ns)</td><td align="right" bgcolor="#FF4949">666,583 ns (Δ = +112,885 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,601 μs</td><td align="right" bgcolor="#A8D08D">0,554 μs (Δ = -0,047 μs)</td><td align="right" bgcolor="#FF4949">0,667 μs (Δ = +0,113 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 131,442 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#FF4949">+18,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">748,477 ns</td><td align="right" bgcolor="#A8D08D">702,193 ns (Δ = -46,283 ns)</td><td align="right" bgcolor="#FF4949">833,635 ns (Δ = +131,442 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td><td align="right" bgcolor="#A8D08D">0,702 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FF4949">0,834 μs (Δ = +0,131 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 131,168 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#FF4949">+15,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">889,029 ns</td><td align="right" bgcolor="#A8D08D">833,468 ns (Δ = -55,561 ns)</td><td align="right" bgcolor="#FF4949">964,637 ns (Δ = +131,168 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,889 μs</td><td align="right" bgcolor="#A8D08D">0,833 μs (Δ = -0,056 μs)</td><td align="right" bgcolor="#FF4949">0,965 μs (Δ = +0,131 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 105,103 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FF4949">+10,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1039,960 ns</td><td align="right" bgcolor="#FFFFFF">1015,762 ns (Δ = -24,198 ns)</td><td align="right" bgcolor="#FF4949">1120,865 ns (Δ = +105,103 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,040 μs</td><td align="right" bgcolor="#FFFFFF">1,016 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">1,121 μs (Δ = +0,105 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 104,127 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1180,357 ns</td><td align="right" bgcolor="#FFFFFF">1156,903 ns (Δ = -23,453 ns)</td><td align="right" bgcolor="#FF4949">1261,030 ns (Δ = +104,127 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,180 μs</td><td align="right" bgcolor="#FFFFFF">1,157 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FF4949">1,261 μs (Δ = +0,104 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 240,550 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,0 %</td><td align="right" bgcolor="#FF4949">+10,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1312,378 ns</td><td align="right" bgcolor="#FF4949">1403,653 ns (Δ = +91,275 ns)</td><td align="right" bgcolor="#FF4949">1552,928 ns (Δ = +149,275 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,312 μs</td><td align="right" bgcolor="#FF4949">1,404 μs (Δ = +0,091 μs)</td><td align="right" bgcolor="#FF4949">1,553 μs (Δ = +0,149 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 195,107 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FF4949">+9,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1447,685 ns</td><td align="right" bgcolor="#FF4949">1496,072 ns (Δ = +48,387 ns)</td><td align="right" bgcolor="#FF4949">1642,792 ns (Δ = +146,720 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,448 μs</td><td align="right" bgcolor="#FF4949">1,496 μs (Δ = +0,048 μs)</td><td align="right" bgcolor="#FF4949">1,643 μs (Δ = +0,147 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 113,834 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,0 %</td><td align="right" bgcolor="#FF4949">+41,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">303,907 ns</td><td align="right" bgcolor="#A8D08D">276,655 ns (Δ = -27,252 ns)</td><td align="right" bgcolor="#FF4949">390,489 ns (Δ = +113,834 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#A8D08D">0,277 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,390 μs (Δ = +0,114 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 70,105 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FF4949">+23,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">363,578 ns</td><td align="right" bgcolor="#A8D08D">299,468 ns (Δ = -64,110 ns)</td><td align="right" bgcolor="#FF4949">369,573 ns (Δ = +70,105 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,364 μs</td><td align="right" bgcolor="#A8D08D">0,299 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#FF4949">0,370 μs (Δ = +0,070 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 389,125 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FF4949">+9,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3957,922 ns</td><td align="right" bgcolor="#FFFFFF">3925,657 ns (Δ = -32,265 ns)</td><td align="right" bgcolor="#FF4949">4314,782 ns (Δ = +389,125 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,958 μs</td><td align="right" bgcolor="#FFFFFF">3,926 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FF4949">4,315 μs (Δ = +0,389 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 593,947 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FF4949">+8,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6805,403 ns</td><td align="right" bgcolor="#FFFFFF">6663,527 ns (Δ = -141,877 ns)</td><td align="right" bgcolor="#FF4949">7257,473 ns (Δ = +593,947 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,805 μs</td><td align="right" bgcolor="#FFFFFF">6,664 μs (Δ = -0,142 μs)</td><td align="right" bgcolor="#FF4949">7,257 μs (Δ = +0,594 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,007 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 399,172 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+7,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5200,185 ns</td><td align="right" bgcolor="#FFFFFF">5222,000 ns (Δ = +21,815 ns)</td><td align="right" bgcolor="#FF4949">5599,357 ns (Δ = +377,357 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,200 μs</td><td align="right" bgcolor="#FFFFFF">5,222 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#FF4949">5,599 μs (Δ = +0,377 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">348,000 (Δ = -328,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,340 (Δ = -0,320)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 386,180 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+9,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3924,492 ns</td><td align="right" bgcolor="#FFFFFF">3920,510 ns (Δ = -3,982 ns)</td><td align="right" bgcolor="#FF4949">4306,690 ns (Δ = +386,180 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,924 μs</td><td align="right" bgcolor="#FFFFFF">3,921 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">4,307 μs (Δ = +0,386 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 582,912 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FF4949">+8,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6780,468 ns</td><td align="right" bgcolor="#FFFFFF">6601,227 ns (Δ = -179,242 ns)</td><td align="right" bgcolor="#FF4949">7184,138 ns (Δ = +582,912 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,780 μs</td><td align="right" bgcolor="#FFFFFF">6,601 μs (Δ = -0,179 μs)</td><td align="right" bgcolor="#FF4949">7,184 μs (Δ = +0,583 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,007 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 697,105 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FF4949">+9,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7800,393 ns</td><td align="right" bgcolor="#FFFFFF">7688,093 ns (Δ = -112,300 ns)</td><td align="right" bgcolor="#FF4949">8385,198 ns (Δ = +697,105 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,800 μs</td><td align="right" bgcolor="#FFFFFF">7,688 μs (Δ = -0,112 μs)</td><td align="right" bgcolor="#FF4949">8,385 μs (Δ = +0,697 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#FFFFFF">1090,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -525,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#FFFFFF">1,064 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,513)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 775,915 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,0 %</td><td align="right" bgcolor="#FF4949">+17,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3519,630 ns</td><td align="right" bgcolor="#A8D08D">2743,715 ns (Δ = -775,915 ns)</td><td align="right" bgcolor="#FF4949">3218,048 ns (Δ = +474,333 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,520 μs</td><td align="right" bgcolor="#A8D08D">2,744 μs (Δ = -0,776 μs)</td><td align="right" bgcolor="#FF4949">3,218 μs (Δ = +0,474 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 994,973 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,8 %</td><td align="right" bgcolor="#FF4949">+21,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3718,438 ns</td><td align="right" bgcolor="#A8D08D">2723,465 ns (Δ = -994,973 ns)</td><td align="right" bgcolor="#FF4949">3310,445 ns (Δ = +586,980 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,718 μs</td><td align="right" bgcolor="#A8D08D">2,723 μs (Δ = -0,995 μs)</td><td align="right" bgcolor="#FF4949">3,310 μs (Δ = +0,587 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1536,388 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,7 %</td><td align="right" bgcolor="#FF4949">+20,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4303,973 ns</td><td align="right" bgcolor="#A8D08D">2767,585 ns (Δ = -1536,388 ns)</td><td align="right" bgcolor="#FF4949">3333,237 ns (Δ = +565,652 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,304 μs</td><td align="right" bgcolor="#A8D08D">2,768 μs (Δ = -1,536 μs)</td><td align="right" bgcolor="#FF4949">3,333 μs (Δ = +0,566 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,3 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1888,000</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -893,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -430,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,844</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,872)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,420)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 21,495 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,9 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,893 ns</td><td align="right" bgcolor="#FF4949">137,273 ns (Δ = +12,380 ns)</td><td align="right" bgcolor="#FF4949">146,388 ns (Δ = +9,115 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FF4949">0,137 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">0,146 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 21,127 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,2 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,038 ns</td><td align="right" bgcolor="#FF4949">140,542 ns (Δ = +18,503 ns)</td><td align="right" bgcolor="#FFFFFF">143,165 ns (Δ = +2,623 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FF4949">0,141 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#FFFFFF">0,143 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 24,743 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,8 %</td><td align="right" bgcolor="#FF4949">+9,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">118,493 ns</td><td align="right" bgcolor="#FF4949">131,270 ns (Δ = +12,777 ns)</td><td align="right" bgcolor="#FF4949">143,237 ns (Δ = +11,967 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FF4949">0,131 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FF4949">0,143 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1311,193 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FF4949">+12,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1742,910 ns</td><td align="right" bgcolor="#A8D08D">431,717 ns (Δ = -1311,193 ns)</td><td align="right" bgcolor="#FF4949">487,135 ns (Δ = +55,418 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,743 μs</td><td align="right" bgcolor="#A8D08D">0,432 μs (Δ = -1,311 μs)</td><td align="right" bgcolor="#FF4949">0,487 μs (Δ = +0,055 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1310,200 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,4 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1761,167 ns</td><td align="right" bgcolor="#A8D08D">450,967 ns (Δ = -1310,200 ns)</td><td align="right" bgcolor="#FF4949">479,228 ns (Δ = +28,262 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,761 μs</td><td align="right" bgcolor="#A8D08D">0,451 μs (Δ = -1,310 μs)</td><td align="right" bgcolor="#FF4949">0,479 μs (Δ = +0,028 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1278,688 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-79,0 %</td><td align="right" bgcolor="#FF4949">+10,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1618,033 ns</td><td align="right" bgcolor="#A8D08D">339,345 ns (Δ = -1278,688 ns)</td><td align="right" bgcolor="#FF4949">374,732 ns (Δ = +35,387 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,618 μs</td><td align="right" bgcolor="#A8D08D">0,339 μs (Δ = -1,279 μs)</td><td align="right" bgcolor="#FF4949">0,375 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-90,5 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,828 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FF4949">+36,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,572 ns</td><td align="right" bgcolor="#A8D08D">2,272 ns (Δ = -0,300 ns)</td><td align="right" bgcolor="#FF4949">3,100 ns (Δ = +0,828 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,003 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,200 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FF4949">+9,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,290 ns</td><td align="right" bgcolor="#A8D08D">2,208 ns (Δ = -0,082 ns)</td><td align="right" bgcolor="#FF4949">2,408 ns (Δ = +0,200 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,838 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+59,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,648 ns</td><td align="right" bgcolor="#A8D08D">8,198 ns (Δ = -0,450 ns)</td><td align="right" bgcolor="#FF4949">13,037 ns (Δ = +4,838 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,013 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,657 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,0 %</td><td align="right" bgcolor="#FF4949">+14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,850 ns</td><td align="right" bgcolor="#A8D08D">2,193 ns (Δ = -0,657 ns)</td><td align="right" bgcolor="#FF4949">2,500 ns (Δ = +0,307 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,003 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,523 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FF4949">+41,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,780 ns</td><td align="right" bgcolor="#FFFFFF">8,538 ns (Δ = -0,242 ns)</td><td align="right" bgcolor="#FF4949">12,062 ns (Δ = +3,523 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,012 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,443 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#FF4949">+20,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,533 ns</td><td align="right" bgcolor="#A8D08D">2,218 ns (Δ = -0,315 ns)</td><td align="right" bgcolor="#FF4949">2,662 ns (Δ = +0,443 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,003 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 11,707 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FF4949">+24,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">49,177 ns</td><td align="right" bgcolor="#A8D08D">47,550 ns (Δ = -1,627 ns)</td><td align="right" bgcolor="#FF4949">59,257 ns (Δ = +11,707 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#A8D08D">0,048 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,059 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,740 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+28,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,587 ns</td><td align="right" bgcolor="#FFFFFF">2,575 ns (Δ = -0,012 ns)</td><td align="right" bgcolor="#FF4949">3,315 ns (Δ = +0,740 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,003 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,802 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,2 %</td><td align="right" bgcolor="#FF4949">+74,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,277 ns</td><td align="right" bgcolor="#A8D08D">2,418 ns (Δ = -0,858 ns)</td><td align="right" bgcolor="#FF4949">4,220 ns (Δ = +1,802 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 19,757 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+27,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,658 ns</td><td align="right" bgcolor="#A8D08D">72,875 ns (Δ = -2,783 ns)</td><td align="right" bgcolor="#FF4949">92,632 ns (Δ = +19,757 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#A8D08D">0,073 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,093 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,085 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,2 %</td><td align="right" bgcolor="#FF4949">+196,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,075 ns</td><td align="right" bgcolor="#A8D08D">0,043 ns (Δ = -0,032 ns)</td><td align="right" bgcolor="#FF4949">0,129 ns (Δ = +0,085 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#A8D08D">0,000 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,000 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 21,460 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+22,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,513 ns</td><td align="right" bgcolor="#A8D08D">96,525 ns (Δ = -3,988 ns)</td><td align="right" bgcolor="#FF4949">117,985 ns (Δ = +21,460 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#A8D08D">0,097 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,118 μs (Δ = +0,021 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 347,013 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3633,342 ns</td><td align="right" bgcolor="#A8D08D">3286,328 ns (Δ = -347,013 ns)</td><td align="right" bgcolor="#FF4949">3439,723 ns (Δ = +153,395 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,633 μs</td><td align="right" bgcolor="#A8D08D">3,286 μs (Δ = -0,347 μs)</td><td align="right" bgcolor="#FF4949">3,440 μs (Δ = +0,153 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1741,000</td><td align="right" bgcolor="#FFFFFF">1741,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">889,000 (Δ = -852,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,700</td><td align="right" bgcolor="#FFFFFF">1,700 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,868 (Δ = -0,832)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 0,780 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,082 ns</td><td align="right" bgcolor="#FFFFFF">25,268 ns (Δ = +0,187 ns)</td><td align="right" bgcolor="#FFFFFF">25,862 ns (Δ = +0,593 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 242254,620 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3198099,582 ns</td><td align="right" bgcolor="#A8D08D">3074350,983 ns (Δ = -123748,598 ns)</td><td align="right" bgcolor="#A8D08D">2955844,962 ns (Δ = -118506,022 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3198,100 μs</td><td align="right" bgcolor="#A8D08D">3074,351 μs (Δ = -123,749 μs)</td><td align="right" bgcolor="#A8D08D">2955,845 μs (Δ = -118,506 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,198 ms</td><td align="right" bgcolor="#A8D08D">3,074 ms (Δ = -0,124 ms)</td><td align="right" bgcolor="#A8D08D">2,956 ms (Δ = -0,119 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">275,000</td><td align="right" bgcolor="#A8D08D">261,000 (Δ = -14,000)</td><td align="right" bgcolor="#FFFFFF">261,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">40,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">261,000 (Δ = +224,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-17,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175315,000</td><td align="right" bgcolor="#A8D08D">167367,000 (Δ = -7948,000)</td><td align="right" bgcolor="#A8D08D">138881,000 (Δ = -28486,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">171,206</td><td align="right" bgcolor="#A8D08D">163,444 (Δ = -7,762)</td><td align="right" bgcolor="#A8D08D">135,626 (Δ = -27,818)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,167</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,027)</td></tr>
</table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 42300,562 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">633758,295 ns</td><td align="right" bgcolor="#FF4949">676058,857 ns (Δ = +42300,562 ns)</td><td align="right" bgcolor="#A8D08D">639552,587 ns (Δ = -36506,270 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">633,758 μs</td><td align="right" bgcolor="#FF4949">676,059 μs (Δ = +42,301 μs)</td><td align="right" bgcolor="#A8D08D">639,553 μs (Δ = -36,506 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,634 ms</td><td align="right" bgcolor="#FF4949">0,676 ms (Δ = +0,042 ms)</td><td align="right" bgcolor="#A8D08D">0,640 ms (Δ = -0,037 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">145,000</td><td align="right" bgcolor="#A8D08D">140,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">165,000 (Δ = +25,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">165,000 (Δ = +150,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">92144,000</td><td align="right" bgcolor="#FFFFFF">91084,000 (Δ = -1060,000)</td><td align="right" bgcolor="#A8D08D">87363,000 (Δ = -3721,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,984</td><td align="right" bgcolor="#FFFFFF">88,949 (Δ = -1,035)</td><td align="right" bgcolor="#A8D08D">85,315 (Δ = -3,634)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#FFFFFF">0,087 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,004)</td></tr>
</table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 38338,248 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">889220,418 ns</td><td align="right" bgcolor="#A8D08D">859635,550 ns (Δ = -29584,868 ns)</td><td align="right" bgcolor="#FFFFFF">850882,170 ns (Δ = -8753,380 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">889,220 μs</td><td align="right" bgcolor="#A8D08D">859,636 μs (Δ = -29,585 μs)</td><td align="right" bgcolor="#FFFFFF">850,882 μs (Δ = -8,753 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,889 ms</td><td align="right" bgcolor="#A8D08D">0,860 ms (Δ = -0,030 ms)</td><td align="right" bgcolor="#FFFFFF">0,851 ms (Δ = -0,009 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">155,000</td><td align="right" bgcolor="#A8D08D">150,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +20,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +155,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">99007,000</td><td align="right" bgcolor="#FFFFFF">97261,000 (Δ = -1746,000)</td><td align="right" bgcolor="#A8D08D">90767,000 (Δ = -6494,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">96,687</td><td align="right" bgcolor="#FFFFFF">94,981 (Δ = -1,705)</td><td align="right" bgcolor="#A8D08D">88,640 (Δ = -6,342)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#FFFFFF">0,093 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,006)</td></tr>
</table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,515 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">76,073 ns</td><td align="right" bgcolor="#FFFFFF">77,202 ns (Δ = +1,129 ns)</td><td align="right" bgcolor="#FFFFFF">78,588 ns (Δ = +1,387 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,079 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 3,167 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">76,168 ns</td><td align="right" bgcolor="#FF4949">78,582 ns (Δ = +2,413 ns)</td><td align="right" bgcolor="#FFFFFF">79,335 ns (Δ = +0,753 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FF4949">0,079 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,079 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 14,043 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,9 %</td><td align="right" bgcolor="#FF4949">+8,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,037 ns</td><td align="right" bgcolor="#FF4949">88,523 ns (Δ = +6,487 ns)</td><td align="right" bgcolor="#FF4949">96,080 ns (Δ = +7,557 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FF4949">0,089 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,096 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 49,022 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,7 %</td><td align="right" bgcolor="#FF4949">+8,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">165,298 ns</td><td align="right" bgcolor="#A8D08D">116,277 ns (Δ = -49,022 ns)</td><td align="right" bgcolor="#FF4949">126,122 ns (Δ = +9,845 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#A8D08D">0,116 μs (Δ = -0,049 μs)</td><td align="right" bgcolor="#FF4949">0,126 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 55,040 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FF4949">+11,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">169,063 ns</td><td align="right" bgcolor="#A8D08D">114,023 ns (Δ = -55,040 ns)</td><td align="right" bgcolor="#FF4949">126,610 ns (Δ = +12,587 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#A8D08D">0,114 μs (Δ = -0,055 μs)</td><td align="right" bgcolor="#FF4949">0,127 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 12,883 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FF4949">+17,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,298 ns</td><td align="right" bgcolor="#A8D08D">72,543 ns (Δ = -6,755 ns)</td><td align="right" bgcolor="#FF4949">85,427 ns (Δ = +12,883 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#A8D08D">0,073 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,085 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 273,875 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,0 %</td><td align="right" bgcolor="#FF4949">+7,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3789,030 ns</td><td align="right" bgcolor="#FFFFFF">3789,798 ns (Δ = +0,768 ns)</td><td align="right" bgcolor="#FF4949">4062,905 ns (Δ = +273,107 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,789 μs</td><td align="right" bgcolor="#FFFFFF">3,790 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">4,063 μs (Δ = +0,273 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 199,727 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+18,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">809,403 ns</td><td align="right" bgcolor="#FF4949">849,698 ns (Δ = +40,295 ns)</td><td align="right" bgcolor="#FF4949">1009,130 ns (Δ = +159,432 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,809 μs</td><td align="right" bgcolor="#FF4949">0,850 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#FF4949">1,009 μs (Δ = +0,159 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 299,690 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FF4949">+4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4492,288 ns</td><td align="right" bgcolor="#FFFFFF">4568,947 ns (Δ = +76,658 ns)</td><td align="right" bgcolor="#FF4949">4791,978 ns (Δ = +223,032 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,492 μs</td><td align="right" bgcolor="#FFFFFF">4,569 μs (Δ = +0,077 μs)</td><td align="right" bgcolor="#FF4949">4,792 μs (Δ = +0,223 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-48,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#FFFFFF">586,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -283,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#FFFFFF">0,572 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,276)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 222,203 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3747,265 ns</td><td align="right" bgcolor="#FFFFFF">3787,515 ns (Δ = +40,250 ns)</td><td align="right" bgcolor="#FF4949">3969,468 ns (Δ = +181,953 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,747 μs</td><td align="right" bgcolor="#FFFFFF">3,788 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#FF4949">3,969 μs (Δ = +0,182 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 197,578 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FF4949">+22,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">802,680 ns</td><td align="right" bgcolor="#FFFFFF">814,968 ns (Δ = +12,288 ns)</td><td align="right" bgcolor="#FF4949">1000,258 ns (Δ = +185,290 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td><td align="right" bgcolor="#FFFFFF">0,815 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">1,000 μs (Δ = +0,185 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 118,772 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,4 %</td><td align="right" bgcolor="#FF4949">+12,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">656,052 ns</td><td align="right" bgcolor="#FF4949">691,283 ns (Δ = +35,232 ns)</td><td align="right" bgcolor="#FF4949">774,823 ns (Δ = +83,540 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,656 μs</td><td align="right" bgcolor="#FF4949">0,691 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FF4949">0,775 μs (Δ = +0,084 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,088 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 176,648 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,7 %</td><td align="right" bgcolor="#FF4949">+18,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">594,902 ns</td><td align="right" bgcolor="#A8D08D">418,253 ns (Δ = -176,648 ns)</td><td align="right" bgcolor="#FF4949">496,608 ns (Δ = +78,355 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,595 μs</td><td align="right" bgcolor="#A8D08D">0,418 μs (Δ = -0,177 μs)</td><td align="right" bgcolor="#FF4949">0,497 μs (Δ = +0,078 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 49,868 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,2 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,307 ns</td><td align="right" bgcolor="#A8D08D">145,818 ns (Δ = -46,488 ns)</td><td align="right" bgcolor="#FFFFFF">142,438 ns (Δ = -3,380 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#A8D08D">0,146 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FFFFFF">0,142 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 47,205 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">189,712 ns</td><td align="right" bgcolor="#A8D08D">145,147 ns (Δ = -44,565 ns)</td><td align="right" bgcolor="#FFFFFF">142,507 ns (Δ = -2,640 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#A8D08D">0,145 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#FFFFFF">0,143 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 223871,285 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#A8D08D">-31,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">663959,522 ns</td><td align="right" bgcolor="#FFFFFF">645422,385 ns (Δ = -18537,137 ns)</td><td align="right" bgcolor="#A8D08D">440088,237 ns (Δ = -205334,148 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">663,960 μs</td><td align="right" bgcolor="#FFFFFF">645,422 μs (Δ = -18,537 μs)</td><td align="right" bgcolor="#A8D08D">440,088 μs (Δ = -205,334 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,664 ms</td><td align="right" bgcolor="#FFFFFF">0,645 ms (Δ = -0,019 ms)</td><td align="right" bgcolor="#A8D08D">0,440 ms (Δ = -0,205 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.4</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -40,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FF4949">40,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">80,000 (Δ = +40,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-38,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">110633,000</td><td align="right" bgcolor="#A8D08D">103138,000 (Δ = -7495,000)</td><td align="right" bgcolor="#A8D08D">63865,000 (Δ = -39273,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">108,040</td><td align="right" bgcolor="#A8D08D">100,721 (Δ = -7,319)</td><td align="right" bgcolor="#A8D08D">62,368 (Δ = -38,353)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,106</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = -0,037)</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 196597,943 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#A8D08D">-46,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">417257,387 ns</td><td align="right" bgcolor="#FFFFFF">414812,735 ns (Δ = -2444,652 ns)</td><td align="right" bgcolor="#A8D08D">220659,443 ns (Δ = -194153,292 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">417,257 μs</td><td align="right" bgcolor="#FFFFFF">414,813 μs (Δ = -2,445 μs)</td><td align="right" bgcolor="#A8D08D">220,659 μs (Δ = -194,153 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,417 ms</td><td align="right" bgcolor="#FFFFFF">0,415 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,221 ms (Δ = -0,194 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">60,000</td><td align="right" bgcolor="#A8D08D">55,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">35,000 (Δ = -20,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -5,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-47,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">39196,000</td><td align="right" bgcolor="#A8D08D">37902,000 (Δ = -1294,000)</td><td align="right" bgcolor="#A8D08D">20026,000 (Δ = -17876,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">38,277</td><td align="right" bgcolor="#A8D08D">37,014 (Δ = -1,264)</td><td align="right" bgcolor="#A8D08D">19,557 (Δ = -17,457)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,037</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,019 (Δ = -0,017)</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 203313,202 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#A8D08D">-35,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">557070,433 ns</td><td align="right" bgcolor="#FFFFFF">551541,325 ns (Δ = -5529,108 ns)</td><td align="right" bgcolor="#A8D08D">353757,232 ns (Δ = -197784,093 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">557,070 μs</td><td align="right" bgcolor="#FFFFFF">551,541 μs (Δ = -5,529 μs)</td><td align="right" bgcolor="#A8D08D">353,757 μs (Δ = -197,784 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,557 ms</td><td align="right" bgcolor="#FFFFFF">0,552 ms (Δ = -0,006 ms)</td><td align="right" bgcolor="#A8D08D">0,354 ms (Δ = -0,198 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#A8D08D">125,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -35,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FFFFFF">30,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">36,000 (Δ = +6,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-41,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">87806,000</td><td align="right" bgcolor="#A8D08D">82268,000 (Δ = -5538,000)</td><td align="right" bgcolor="#A8D08D">47887,000 (Δ = -34381,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">85,748</td><td align="right" bgcolor="#A8D08D">80,340 (Δ = -5,408)</td><td align="right" bgcolor="#A8D08D">46,765 (Δ = -33,575)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,046 (Δ = -0,033)</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 272703,797 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-16,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1362732,992 ns</td><td align="right" bgcolor="#A8D08D">1305766,500 ns (Δ = -56966,492 ns)</td><td align="right" bgcolor="#A8D08D">1090029,195 ns (Δ = -215737,305 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1362,733 μs</td><td align="right" bgcolor="#A8D08D">1305,767 μs (Δ = -56,966 μs)</td><td align="right" bgcolor="#A8D08D">1090,029 μs (Δ = -215,737 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,363 ms</td><td align="right" bgcolor="#A8D08D">1,306 ms (Δ = -0,057 ms)</td><td align="right" bgcolor="#A8D08D">1,090 ms (Δ = -0,216 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">530,000</td><td align="right" bgcolor="#A8D08D">490,000 (Δ = -40,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -130,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">85,000</td><td align="right" bgcolor="#FFFFFF">85,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">55,000 (Δ = -30,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-38,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">337071,000</td><td align="right" bgcolor="#A8D08D">310251,000 (Δ = -26820,000)</td><td align="right" bgcolor="#A8D08D">190729,000 (Δ = -119522,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">329,171</td><td align="right" bgcolor="#A8D08D">302,979 (Δ = -26,191)</td><td align="right" bgcolor="#A8D08D">186,259 (Δ = -116,721)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">0,182 (Δ = -0,114)</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1173626,417 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FF4949">+6,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17294666,487 ns</td><td align="right" bgcolor="#FFFFFF">17156720,355 ns (Δ = -137946,132 ns)</td><td align="right" bgcolor="#FF4949">18330346,772 ns (Δ = +1173626,417 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17294,666 μs</td><td align="right" bgcolor="#FFFFFF">17156,720 μs (Δ = -137,946 μs)</td><td align="right" bgcolor="#FF4949">18330,347 μs (Δ = +1173,626 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">17,295 ms</td><td align="right" bgcolor="#FFFFFF">17,157 ms (Δ = -0,138 ms)</td><td align="right" bgcolor="#FF4949">18,330 ms (Δ = +1,174 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2456,000</td><td align="right" bgcolor="#FFFFFF">2390,000 (Δ = -66,000)</td><td align="right" bgcolor="#A8D08D">1495,000 (Δ = -895,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">816,000</td><td align="right" bgcolor="#FFFFFF">795,000 (Δ = -21,000)</td><td align="right" bgcolor="#A8D08D">495,000 (Δ = -300,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1547366,000</td><td align="right" bgcolor="#FFFFFF">1504997,000 (Δ = -42369,000)</td><td align="right" bgcolor="#A8D08D">784885,000 (Δ = -720112,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1511,100</td><td align="right" bgcolor="#FFFFFF">1469,724 (Δ = -41,376)</td><td align="right" bgcolor="#A8D08D">766,489 (Δ = -703,234)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,476</td><td align="right" bgcolor="#FFFFFF">1,435 (Δ = -0,040)</td><td align="right" bgcolor="#A8D08D">0,749 (Δ = -0,687)</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 138695,495 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#A8D08D">-12,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1083977,295 ns</td><td align="right" bgcolor="#FFFFFF">1078718,718 ns (Δ = -5258,577 ns)</td><td align="right" bgcolor="#A8D08D">945281,800 ns (Δ = -133436,918 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1083,977 μs</td><td align="right" bgcolor="#FFFFFF">1078,719 μs (Δ = -5,259 μs)</td><td align="right" bgcolor="#A8D08D">945,282 μs (Δ = -133,437 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,084 ms</td><td align="right" bgcolor="#FFFFFF">1,079 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#A8D08D">0,945 ms (Δ = -0,133 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#A8D08D">130,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">85,000 (Δ = -45,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">45,000</td><td align="right" bgcolor="#A8D08D">40,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">85,000 (Δ = +45,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86941,000</td><td align="right" bgcolor="#FFFFFF">85308,000 (Δ = -1633,000)</td><td align="right" bgcolor="#A8D08D">44814,000 (Δ = -40494,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,903</td><td align="right" bgcolor="#FFFFFF">83,309 (Δ = -1,595)</td><td align="right" bgcolor="#A8D08D">43,764 (Δ = -39,545)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,083</td><td align="right" bgcolor="#FFFFFF">0,081 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,039)</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 34932,503 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3201841,998 ns</td><td align="right" bgcolor="#FFFFFF">3178928,383 ns (Δ = -22913,615 ns)</td><td align="right" bgcolor="#FFFFFF">3213860,887 ns (Δ = +34932,503 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3201,842 μs</td><td align="right" bgcolor="#FFFFFF">3178,928 μs (Δ = -22,914 μs)</td><td align="right" bgcolor="#FFFFFF">3213,861 μs (Δ = +34,933 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,202 ms</td><td align="right" bgcolor="#FFFFFF">3,179 ms (Δ = -0,023 ms)</td><td align="right" bgcolor="#FFFFFF">3,214 ms (Δ = +0,035 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">445,000</td><td align="right" bgcolor="#FFFFFF">434,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -164,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">130,000</td><td align="right" bgcolor="#A8D08D">115,000 (Δ = -15,000)</td><td align="right" bgcolor="#FF4949">270,000 (Δ = +155,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">281774,000</td><td align="right" bgcolor="#FFFFFF">274479,000 (Δ = -7295,000)</td><td align="right" bgcolor="#A8D08D">142444,000 (Δ = -132035,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">275,170</td><td align="right" bgcolor="#FFFFFF">268,046 (Δ = -7,124)</td><td align="right" bgcolor="#A8D08D">139,105 (Δ = -128,940)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,269</td><td align="right" bgcolor="#FFFFFF">0,262 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,126)</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1127828,785 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FF4949">+8,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13739715,490 ns</td><td align="right" bgcolor="#FFFFFF">13575450,450 ns (Δ = -164265,040 ns)</td><td align="right" bgcolor="#FF4949">14703279,235 ns (Δ = +1127828,785 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13739,715 μs</td><td align="right" bgcolor="#FFFFFF">13575,450 μs (Δ = -164,265 μs)</td><td align="right" bgcolor="#FF4949">14703,279 μs (Δ = +1127,829 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">13,740 ms</td><td align="right" bgcolor="#FFFFFF">13,575 ms (Δ = -0,164 ms)</td><td align="right" bgcolor="#FF4949">14,703 ms (Δ = +1,128 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2005,000</td><td align="right" bgcolor="#A8D08D">1933,000 (Δ = -72,000)</td><td align="right" bgcolor="#A8D08D">1205,000 (Δ = -728,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">554,000</td><td align="right" bgcolor="#A8D08D">511,000 (Δ = -43,000)</td><td align="right" bgcolor="#A8D08D">300,000 (Δ = -211,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#A8D08D">-47,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1263521,000</td><td align="right" bgcolor="#A8D08D">1218299,000 (Δ = -45222,000)</td><td align="right" bgcolor="#A8D08D">634273,000 (Δ = -584026,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1233,907</td><td align="right" bgcolor="#A8D08D">1189,745 (Δ = -44,162)</td><td align="right" bgcolor="#A8D08D">619,407 (Δ = -570,338)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,205</td><td align="right" bgcolor="#A8D08D">1,162 (Δ = -0,043)</td><td align="right" bgcolor="#A8D08D">0,605 (Δ = -0,557)</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 194647,545 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#A8D08D">-13,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1302578,595 ns</td><td align="right" bgcolor="#FFFFFF">1284321,512 ns (Δ = -18257,083 ns)</td><td align="right" bgcolor="#A8D08D">1107931,050 ns (Δ = -176390,462 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1302,579 μs</td><td align="right" bgcolor="#FFFFFF">1284,322 μs (Δ = -18,257 μs)</td><td align="right" bgcolor="#A8D08D">1107,931 μs (Δ = -176,390 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,303 ms</td><td align="right" bgcolor="#FFFFFF">1,284 ms (Δ = -0,018 ms)</td><td align="right" bgcolor="#A8D08D">1,108 ms (Δ = -0,176 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">930,000</td><td align="right" bgcolor="#FFFFFF">915,000 (Δ = -15,000)</td><td align="right" bgcolor="#FF4949">950,000 (Δ = +35,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">152,000</td><td align="right" bgcolor="#A8D08D">146,000 (Δ = -6,000)</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -11,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587211,000</td><td align="right" bgcolor="#FFFFFF">577277,000 (Δ = -9934,000)</td><td align="right" bgcolor="#A8D08D">500545,000 (Δ = -76732,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">573,448</td><td align="right" bgcolor="#FFFFFF">563,747 (Δ = -9,701)</td><td align="right" bgcolor="#A8D08D">488,813 (Δ = -74,934)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,560</td><td align="right" bgcolor="#FFFFFF">0,551 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,073)</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 212440,582 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-41,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">507549,902 ns</td><td align="right" bgcolor="#FFFFFF">502864,388 ns (Δ = -4685,513 ns)</td><td align="right" bgcolor="#A8D08D">295109,320 ns (Δ = -207755,068 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">507,550 μs</td><td align="right" bgcolor="#FFFFFF">502,864 μs (Δ = -4,686 μs)</td><td align="right" bgcolor="#A8D08D">295,109 μs (Δ = -207,755 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,508 ms</td><td align="right" bgcolor="#FFFFFF">0,503 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#A8D08D">0,295 ms (Δ = -0,208 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">215,000</td><td align="right" bgcolor="#FFFFFF">215,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">215,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#FFFFFF">35,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">215,000 (Δ = +180,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138529,000</td><td align="right" bgcolor="#FFFFFF">136484,000 (Δ = -2045,000)</td><td align="right" bgcolor="#A8D08D">113850,000 (Δ = -22634,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">135,282</td><td align="right" bgcolor="#FFFFFF">133,285 (Δ = -1,997)</td><td align="right" bgcolor="#A8D08D">111,182 (Δ = -22,104)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,130 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = -0,022)</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 256917,242 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#A8D08D">-26,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">895446,312 ns</td><td align="right" bgcolor="#FFFFFF">871639,918 ns (Δ = -23806,393 ns)</td><td align="right" bgcolor="#A8D08D">638529,070 ns (Δ = -233110,848 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">895,446 μs</td><td align="right" bgcolor="#FFFFFF">871,640 μs (Δ = -23,806 μs)</td><td align="right" bgcolor="#A8D08D">638,529 μs (Δ = -233,111 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,895 ms</td><td align="right" bgcolor="#FFFFFF">0,872 ms (Δ = -0,024 ms)</td><td align="right" bgcolor="#A8D08D">0,639 ms (Δ = -0,233 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">690,000</td><td align="right" bgcolor="#FFFFFF">680,000 (Δ = -10,000)</td><td align="right" bgcolor="#FF4949">710,000 (Δ = +30,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">84,000</td><td align="right" bgcolor="#A8D08D">76,000 (Δ = -8,000)</td><td align="right" bgcolor="#FF4949">349,000 (Δ = +273,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">437436,000</td><td align="right" bgcolor="#FFFFFF">429269,000 (Δ = -8167,000)</td><td align="right" bgcolor="#A8D08D">373007,000 (Δ = -56262,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">427,184</td><td align="right" bgcolor="#FFFFFF">419,208 (Δ = -7,976)</td><td align="right" bgcolor="#A8D08D">364,265 (Δ = -54,943)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,417</td><td align="right" bgcolor="#FFFFFF">0,409 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,356 (Δ = -0,054)</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 412358,535 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#A8D08D">-12,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2792942,112 ns</td><td align="right" bgcolor="#FFFFFF">2731961,650 ns (Δ = -60980,462 ns)</td><td align="right" bgcolor="#A8D08D">2380583,577 ns (Δ = -351378,073 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2792,942 μs</td><td align="right" bgcolor="#FFFFFF">2731,962 μs (Δ = -60,980 μs)</td><td align="right" bgcolor="#A8D08D">2380,584 μs (Δ = -351,378 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,793 ms</td><td align="right" bgcolor="#FFFFFF">2,732 ms (Δ = -0,061 ms)</td><td align="right" bgcolor="#A8D08D">2,381 ms (Δ = -0,351 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3065,000</td><td align="right" bgcolor="#FFFFFF">3000,000 (Δ = -65,000)</td><td align="right" bgcolor="#FF4949">3170,000 (Δ = +170,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">504,000</td><td align="right" bgcolor="#FFFFFF">493,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">476,000 (Δ = -17,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#A8D08D">-12,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1930829,000</td><td align="right" bgcolor="#FFFFFF">1892599,000 (Δ = -38230,000)</td><td align="right" bgcolor="#A8D08D">1665864,000 (Δ = -226735,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1885,575</td><td align="right" bgcolor="#FFFFFF">1848,241 (Δ = -37,334)</td><td align="right" bgcolor="#A8D08D">1626,820 (Δ = -221,421)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,841</td><td align="right" bgcolor="#FFFFFF">1,805 (Δ = -0,036)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = -0,216)</td></tr>
</table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 138,772 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,5 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">850,683 ns</td><td align="right" bgcolor="#FF4949">965,715 ns (Δ = +115,032 ns)</td><td align="right" bgcolor="#FFFFFF">989,455 ns (Δ = +23,740 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FF4949">0,966 μs (Δ = +0,115 μs)</td><td align="right" bgcolor="#FFFFFF">0,989 μs (Δ = +0,024 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#A8D08D">-26,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -118,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -246,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,115)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,240)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,247 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,430 ns</td><td align="right" bgcolor="#FFFFFF">188,615 ns (Δ = -4,815 ns)</td><td align="right" bgcolor="#FF4949">196,862 ns (Δ = +8,247 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,197 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-44,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 397,342 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2971,547 ns</td><td align="right" bgcolor="#FF4949">3167,317 ns (Δ = +195,770 ns)</td><td align="right" bgcolor="#A8D08D">2769,975 ns (Δ = -397,342 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,972 μs</td><td align="right" bgcolor="#FF4949">3,167 μs (Δ = +0,196 μs)</td><td align="right" bgcolor="#A8D08D">2,770 μs (Δ = -0,397 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-39,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1425,000</td><td align="right" bgcolor="#FFFFFF">1433,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">867,000 (Δ = -566,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,392</td><td align="right" bgcolor="#FFFFFF">1,399 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,847 (Δ = -0,553)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 9,385 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FF4949">+5,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">190,792 ns</td><td align="right" bgcolor="#FFFFFF">188,123 ns (Δ = -2,668 ns)</td><td align="right" bgcolor="#FF4949">197,508 ns (Δ = +9,385 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,198 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-44,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1174,253 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#A8D08D">-9,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7096,377 ns</td><td align="right" bgcolor="#A8D08D">6547,552 ns (Δ = -548,825 ns)</td><td align="right" bgcolor="#A8D08D">5922,123 ns (Δ = -625,428 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,096 μs</td><td align="right" bgcolor="#A8D08D">6,548 μs (Δ = -0,549 μs)</td><td align="right" bgcolor="#A8D08D">5,922 μs (Δ = -0,625 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-40,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3147,000</td><td align="right" bgcolor="#A8D08D">3004,000 (Δ = -143,000)</td><td align="right" bgcolor="#A8D08D">1794,000 (Δ = -1210,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,073</td><td align="right" bgcolor="#A8D08D">2,934 (Δ = -0,140)</td><td align="right" bgcolor="#A8D08D">1,752 (Δ = -1,182)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td></tr>
</table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,080 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FF4949">+33,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,672 ns</td><td align="right" bgcolor="#A8D08D">9,090 ns (Δ = -0,582 ns)</td><td align="right" bgcolor="#FF4949">12,170 ns (Δ = +3,080 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,012 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 604,882 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20038,785 ns</td><td align="right" bgcolor="#FFFFFF">20153,777 ns (Δ = +114,992 ns)</td><td align="right" bgcolor="#A8D08D">19548,895 ns (Δ = -604,882 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20,039 μs</td><td align="right" bgcolor="#FFFFFF">20,154 μs (Δ = +0,115 μs)</td><td align="right" bgcolor="#A8D08D">19,549 μs (Δ = -0,605 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,020 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">5.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -5,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">10,000 (Δ = +10,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10996,000</td><td align="right" bgcolor="#FFFFFF">10996,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">5526,000 (Δ = -5470,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,738</td><td align="right" bgcolor="#FFFFFF">10,738 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">5,396 (Δ = -5,342)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,005)</td></tr>
</table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,028 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+15,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,005 ns</td><td align="right" bgcolor="#FFFFFF">25,487 ns (Δ = -0,518 ns)</td><td align="right" bgcolor="#FF4949">29,515 ns (Δ = +4,028 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,030 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,387 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FF4949">+40,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,097 ns</td><td align="right" bgcolor="#FFFFFF">18,058 ns (Δ = -0,038 ns)</td><td align="right" bgcolor="#FF4949">25,445 ns (Δ = +7,387 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,025 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,587 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+42,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,420 ns</td><td align="right" bgcolor="#FFFFFF">20,003 ns (Δ = -0,417 ns)</td><td align="right" bgcolor="#FF4949">28,590 ns (Δ = +8,587 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 7,733 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FF4949">+24,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,178 ns</td><td align="right" bgcolor="#FF4949">27,308 ns (Δ = +1,130 ns)</td><td align="right" bgcolor="#FF4949">33,912 ns (Δ = +6,603 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FF4949">0,027 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,034 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 36,768 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FF4949">+12,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">265,835 ns</td><td align="right" bgcolor="#FFFFFF">269,130 ns (Δ = +3,295 ns)</td><td align="right" bgcolor="#FF4949">302,603 ns (Δ = +33,473 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,303 μs (Δ = +0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,6 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">66,000 (Δ = -65,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,064 (Δ = -0,063)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 8,617 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#A8D08D">-10,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,268 ns</td><td align="right" bgcolor="#FF4949">83,008 ns (Δ = +2,740 ns)</td><td align="right" bgcolor="#A8D08D">74,392 ns (Δ = -8,617 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FF4949">0,083 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,074 μs (Δ = -0,009 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 238,335 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FF4949">+7,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3331,237 ns</td><td align="right" bgcolor="#FFFFFF">3316,265 ns (Δ = -14,972 ns)</td><td align="right" bgcolor="#FF4949">3554,600 ns (Δ = +238,335 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,331 μs</td><td align="right" bgcolor="#FFFFFF">3,316 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">3,555 μs (Δ = +0,238 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1914,653 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,7 %</td><td align="right" bgcolor="#FF4949">+14,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8045,442 ns</td><td align="right" bgcolor="#FF4949">8664,757 ns (Δ = +619,315 ns)</td><td align="right" bgcolor="#FF4949">9960,095 ns (Δ = +1295,338 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,045 μs</td><td align="right" bgcolor="#FF4949">8,665 μs (Δ = +0,619 μs)</td><td align="right" bgcolor="#FF4949">9,960 μs (Δ = +1,295 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 265,488 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+8,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3320,633 ns</td><td align="right" bgcolor="#FFFFFF">3296,177 ns (Δ = -24,457 ns)</td><td align="right" bgcolor="#FF4949">3561,665 ns (Δ = +265,488 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,321 μs</td><td align="right" bgcolor="#FFFFFF">3,296 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">3,562 μs (Δ = +0,265 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1920,620 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#FF4949">+14,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8034,682 ns</td><td align="right" bgcolor="#FF4949">8704,823 ns (Δ = +670,142 ns)</td><td align="right" bgcolor="#FF4949">9955,302 ns (Δ = +1250,478 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,035 μs</td><td align="right" bgcolor="#FF4949">8,705 μs (Δ = +0,670 μs)</td><td align="right" bgcolor="#FF4949">9,955 μs (Δ = +1,250 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,632 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#FF4949">+23,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,495 ns</td><td align="right" bgcolor="#A8D08D">7,088 ns (Δ = -0,407 ns)</td><td align="right" bgcolor="#FF4949">8,720 ns (Δ = +1,632 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 115,647 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#A8D08D">-15,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">766,460 ns</td><td align="right" bgcolor="#FFFFFF">770,347 ns (Δ = +3,887 ns)</td><td align="right" bgcolor="#A8D08D">654,700 ns (Δ = -115,647 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,766 μs</td><td align="right" bgcolor="#FFFFFF">0,770 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,655 μs (Δ = -0,116 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 7,180 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,9 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,978 ns</td><td align="right" bgcolor="#A8D08D">96,798 ns (Δ = -7,180 ns)</td><td align="right" bgcolor="#FFFFFF">97,850 ns (Δ = +1,052 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#A8D08D">0,097 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,098 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 317,480 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2737,900 ns</td><td align="right" bgcolor="#A8D08D">2420,420 ns (Δ = -317,480 ns)</td><td align="right" bgcolor="#FFFFFF">2449,968 ns (Δ = +29,548 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,738 μs</td><td align="right" bgcolor="#A8D08D">2,420 μs (Δ = -0,317 μs)</td><td align="right" bgcolor="#FFFFFF">2,450 μs (Δ = +0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 221,588 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1197,527 ns</td><td align="right" bgcolor="#A8D08D">1013,280 ns (Δ = -184,247 ns)</td><td align="right" bgcolor="#A8D08D">975,938 ns (Δ = -37,342 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,198 μs</td><td align="right" bgcolor="#A8D08D">1,013 μs (Δ = -0,184 μs)</td><td align="right" bgcolor="#A8D08D">0,976 μs (Δ = -0,037 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">475,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -200,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,464</td><td align="right" bgcolor="#A8D08D">0,392 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,195)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 199,793 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,1 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">623,060 ns</td><td align="right" bgcolor="#A8D08D">423,267 ns (Δ = -199,793 ns)</td><td align="right" bgcolor="#FF4949">463,685 ns (Δ = +40,418 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,623 μs</td><td align="right" bgcolor="#A8D08D">0,423 μs (Δ = -0,200 μs)</td><td align="right" bgcolor="#FF4949">0,464 μs (Δ = +0,040 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,8 %</td><td align="right" bgcolor="#A8D08D">-49,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -148,000)</td><td align="right" bgcolor="#A8D08D">152,000 (Δ = -151,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,145)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,147)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 91,755 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#A8D08D">-9,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">750,172 ns</td><td align="right" bgcolor="#A8D08D">726,758 ns (Δ = -23,413 ns)</td><td align="right" bgcolor="#A8D08D">658,417 ns (Δ = -68,342 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,750 μs</td><td align="right" bgcolor="#A8D08D">0,727 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,658 μs (Δ = -0,068 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 7,453 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,605 ns</td><td align="right" bgcolor="#A8D08D">96,863 ns (Δ = -4,742 ns)</td><td align="right" bgcolor="#FFFFFF">94,152 ns (Δ = -2,712 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#A8D08D">0,097 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,094 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 7,713 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">113,915 ns</td><td align="right" bgcolor="#A8D08D">109,633 ns (Δ = -4,282 ns)</td><td align="right" bgcolor="#A8D08D">106,202 ns (Δ = -3,432 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#A8D08D">0,110 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,106 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,847 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+7,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,640 ns</td><td align="right" bgcolor="#A8D08D">99,352 ns (Δ = -4,288 ns)</td><td align="right" bgcolor="#FF4949">107,198 ns (Δ = +7,847 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#A8D08D">0,099 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,107 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 27,585 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">552,150 ns</td><td align="right" bgcolor="#FF4949">579,735 ns (Δ = +27,585 ns)</td><td align="right" bgcolor="#FFFFFF">571,543 ns (Δ = -8,192 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,552 μs</td><td align="right" bgcolor="#FF4949">0,580 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FFFFFF">0,572 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-44,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">315,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">176,000 (Δ = -139,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FF4949">0,308 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,172 (Δ = -0,136)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 4,520 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94,935 ns</td><td align="right" bgcolor="#FFFFFF">97,442 ns (Δ = +2,507 ns)</td><td align="right" bgcolor="#FFFFFF">99,455 ns (Δ = +2,013 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,099 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 64,427 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">878,730 ns</td><td align="right" bgcolor="#FF4949">911,715 ns (Δ = +32,985 ns)</td><td align="right" bgcolor="#FF4949">943,157 ns (Δ = +31,442 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td><td align="right" bgcolor="#FF4949">0,912 μs (Δ = +0,033 μs)</td><td align="right" bgcolor="#FF4949">0,943 μs (Δ = +0,031 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-44,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FF4949">356,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -159,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FF4949">0,348 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,155)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 7,210 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,225 ns</td><td align="right" bgcolor="#FFFFFF">96,803 ns (Δ = +1,578 ns)</td><td align="right" bgcolor="#FF4949">102,435 ns (Δ = +5,632 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,102 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 61,363 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+38,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">154,540 ns</td><td align="right" bgcolor="#FFFFFF">155,445 ns (Δ = +0,905 ns)</td><td align="right" bgcolor="#FF4949">215,903 ns (Δ = +60,458 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,216 μs (Δ = +0,060 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 14,968 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#FF4949">+16,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,928 ns</td><td align="right" bgcolor="#A8D08D">91,970 ns (Δ = -6,958 ns)</td><td align="right" bgcolor="#FF4949">106,938 ns (Δ = +14,968 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#A8D08D">0,092 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,107 μs (Δ = +0,015 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 21,035 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,4 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">157,432 ns</td><td align="right" bgcolor="#A8D08D">136,397 ns (Δ = -21,035 ns)</td><td align="right" bgcolor="#FFFFFF">139,468 ns (Δ = +3,072 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#A8D08D">0,136 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,139 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-50,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -99,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,097)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 178,760 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#A8D08D">-12,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1386,732 ns</td><td align="right" bgcolor="#FFFFFF">1399,368 ns (Δ = +12,637 ns)</td><td align="right" bgcolor="#A8D08D">1220,608 ns (Δ = -178,760 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,387 μs</td><td align="right" bgcolor="#FFFFFF">1,399 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">1,221 μs (Δ = -0,179 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -131,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,128)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 46,862 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,0 %</td><td align="right" bgcolor="#A8D08D">-6,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">641,477 ns</td><td align="right" bgcolor="#FF4949">686,445 ns (Δ = +44,968 ns)</td><td align="right" bgcolor="#A8D08D">639,583 ns (Δ = -46,862 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FF4949">0,686 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#A8D08D">0,640 μs (Δ = -0,047 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-44,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 15,715 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">641,328 ns</td><td align="right" bgcolor="#FFFFFF">625,613 ns (Δ = -15,715 ns)</td><td align="right" bgcolor="#FFFFFF">639,890 ns (Δ = +14,277 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,640 μs (Δ = +0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 36,683 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">630,848 ns</td><td align="right" bgcolor="#A8D08D">594,165 ns (Δ = -36,683 ns)</td><td align="right" bgcolor="#FFFFFF">611,532 ns (Δ = +17,367 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,631 μs</td><td align="right" bgcolor="#A8D08D">0,594 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FFFFFF">0,612 μs (Δ = +0,017 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-44,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 117,572 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#A8D08D">-14,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">794,822 ns</td><td align="right" bgcolor="#FFFFFF">800,723 ns (Δ = +5,902 ns)</td><td align="right" bgcolor="#A8D08D">683,152 ns (Δ = -117,572 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">0,801 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,683 μs (Δ = -0,118 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 3,947 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,457 ns</td><td align="right" bgcolor="#FFFFFF">123,500 ns (Δ = -2,957 ns)</td><td align="right" bgcolor="#FFFFFF">122,510 ns (Δ = -0,990 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,123 μs (Δ = -0,001 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 7,867 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,063 ns</td><td align="right" bgcolor="#FF4949">146,930 ns (Δ = +7,867 ns)</td><td align="right" bgcolor="#A8D08D">139,192 ns (Δ = -7,738 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FF4949">0,147 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,139 μs (Δ = -0,008 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1,592 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,028 ns</td><td align="right" bgcolor="#FFFFFF">125,437 ns (Δ = -1,592 ns)</td><td align="right" bgcolor="#FFFFFF">126,202 ns (Δ = +0,765 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,126 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2144,420 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,0 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7382,492 ns</td><td align="right" bgcolor="#A8D08D">5238,072 ns (Δ = -2144,420 ns)</td><td align="right" bgcolor="#FF4949">5462,567 ns (Δ = +224,495 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,382 μs</td><td align="right" bgcolor="#A8D08D">5,238 μs (Δ = -2,144 μs)</td><td align="right" bgcolor="#FF4949">5,463 μs (Δ = +0,224 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,5 %</td><td align="right" bgcolor="#A8D08D">-49,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2945,000</td><td align="right" bgcolor="#A8D08D">2048,000 (Δ = -897,000)</td><td align="right" bgcolor="#A8D08D">1044,000 (Δ = -1004,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,876</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -0,876)</td><td align="right" bgcolor="#A8D08D">1,020 (Δ = -0,980)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 440,012 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,7 %</td><td align="right" bgcolor="#FF4949">+15,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1347,192 ns</td><td align="right" bgcolor="#A8D08D">907,180 ns (Δ = -440,012 ns)</td><td align="right" bgcolor="#FF4949">1050,578 ns (Δ = +143,398 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,347 μs</td><td align="right" bgcolor="#A8D08D">0,907 μs (Δ = -0,440 μs)</td><td align="right" bgcolor="#FF4949">1,051 μs (Δ = +0,143 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2406,108 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7127,782 ns</td><td align="right" bgcolor="#A8D08D">4721,673 ns (Δ = -2406,108 ns)</td><td align="right" bgcolor="#FF4949">4867,750 ns (Δ = +146,077 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,128 μs</td><td align="right" bgcolor="#A8D08D">4,722 μs (Δ = -2,406 μs)</td><td align="right" bgcolor="#FF4949">4,868 μs (Δ = +0,146 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,0 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5093,000</td><td align="right" bgcolor="#A8D08D">3465,000 (Δ = -1628,000)</td><td align="right" bgcolor="#A8D08D">1774,000 (Δ = -1691,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,974</td><td align="right" bgcolor="#A8D08D">3,384 (Δ = -1,590)</td><td align="right" bgcolor="#A8D08D">1,732 (Δ = -1,651)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 433,442 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,3 %</td><td align="right" bgcolor="#FF4949">+16,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1340,730 ns</td><td align="right" bgcolor="#A8D08D">907,288 ns (Δ = -433,442 ns)</td><td align="right" bgcolor="#FF4949">1054,793 ns (Δ = +147,505 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,341 μs</td><td align="right" bgcolor="#A8D08D">0,907 μs (Δ = -0,433 μs)</td><td align="right" bgcolor="#FF4949">1,055 μs (Δ = +0,148 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 158,737 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+21,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">712,772 ns</td><td align="right" bgcolor="#FFFFFF">720,085 ns (Δ = +7,313 ns)</td><td align="right" bgcolor="#FF4949">871,508 ns (Δ = +151,423 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,713 μs</td><td align="right" bgcolor="#FFFFFF">0,720 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FF4949">0,872 μs (Δ = +0,151 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">291,000</td><td align="right" bgcolor="#A8D08D">266,000 (Δ = -25,000)</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -127,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,284</td><td align="right" bgcolor="#A8D08D">0,260 (Δ = -0,024)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,124)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 310,837 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,2 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1595,315 ns</td><td align="right" bgcolor="#A8D08D">1336,547 ns (Δ = -258,768 ns)</td><td align="right" bgcolor="#A8D08D">1284,478 ns (Δ = -52,068 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,595 μs</td><td align="right" bgcolor="#A8D08D">1,337 μs (Δ = -0,259 μs)</td><td align="right" bgcolor="#A8D08D">1,284 μs (Δ = -0,052 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#A8D08D">-50,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -110,000)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -271,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,107)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,265)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 176,463 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">891,610 ns</td><td align="right" bgcolor="#A8D08D">715,147 ns (Δ = -176,463 ns)</td><td align="right" bgcolor="#FFFFFF">729,563 ns (Δ = +14,417 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#A8D08D">0,715 μs (Δ = -0,176 μs)</td><td align="right" bgcolor="#FFFFFF">0,730 μs (Δ = +0,014 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -164,000)</td><td align="right" bgcolor="#A8D08D">279,000 (Δ = -278,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,160)</td><td align="right" bgcolor="#A8D08D">0,272 (Δ = -0,271)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 41,783 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,5 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">203,987 ns</td><td align="right" bgcolor="#A8D08D">162,203 ns (Δ = -41,783 ns)</td><td align="right" bgcolor="#FF4949">170,003 ns (Δ = +7,800 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#A8D08D">0,162 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#FF4949">0,170 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -4,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,004)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 179,717 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,4 %</td><td align="right" bgcolor="#A8D08D">-10,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">871,048 ns</td><td align="right" bgcolor="#A8D08D">771,565 ns (Δ = -99,483 ns)</td><td align="right" bgcolor="#A8D08D">691,332 ns (Δ = -80,233 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#A8D08D">0,772 μs (Δ = -0,099 μs)</td><td align="right" bgcolor="#A8D08D">0,691 μs (Δ = -0,080 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-49,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 3,057 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">135,758 ns</td><td align="right" bgcolor="#FFFFFF">133,858 ns (Δ = -1,900 ns)</td><td align="right" bgcolor="#FFFFFF">132,702 ns (Δ = -1,157 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,133 μs (Δ = -0,001 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">4,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,004 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 346,747 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2807,797 ns</td><td align="right" bgcolor="#A8D08D">2491,625 ns (Δ = -316,172 ns)</td><td align="right" bgcolor="#FFFFFF">2461,050 ns (Δ = -30,575 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,808 μs</td><td align="right" bgcolor="#A8D08D">2,492 μs (Δ = -0,316 μs)</td><td align="right" bgcolor="#FFFFFF">2,461 μs (Δ = -0,031 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 80,425 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FF4949">+45,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">168,833 ns</td><td align="right" bgcolor="#FFFFFF">171,532 ns (Δ = +2,698 ns)</td><td align="right" bgcolor="#FF4949">249,258 ns (Δ = +77,727 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,249 μs (Δ = +0,078 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -12,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,012)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,322 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+19,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,793 ns</td><td align="right" bgcolor="#FFFFFF">11,863 ns (Δ = +0,070 ns)</td><td align="right" bgcolor="#FF4949">14,115 ns (Δ = +2,252 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,014 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 7,633 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+23,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,472 ns</td><td align="right" bgcolor="#FFFFFF">31,985 ns (Δ = -0,487 ns)</td><td align="right" bgcolor="#FF4949">39,618 ns (Δ = +7,633 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,040 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 9,928 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FF4949">+28,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,554 ns</td><td align="right" bgcolor="#A8D08D">35,212 ns (Δ = -5,342 ns)</td><td align="right" bgcolor="#FF4949">45,140 ns (Δ = +9,928 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#A8D08D">0,035 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,045 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 6,173 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#FF4949">+19,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,338 ns</td><td align="right" bgcolor="#A8D08D">32,102 ns (Δ = -3,237 ns)</td><td align="right" bgcolor="#FF4949">38,275 ns (Δ = +6,173 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#A8D08D">0,032 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,038 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,390 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,910 ns</td><td align="right" bgcolor="#FFFFFF">14,482 ns (Δ = -0,428 ns)</td><td align="right" bgcolor="#A8D08D">12,520 ns (Δ = -1,962 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,487 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,983 ns</td><td align="right" bgcolor="#FFFFFF">19,972 ns (Δ = -0,012 ns)</td><td align="right" bgcolor="#FFFFFF">20,458 ns (Δ = +0,487 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 4,440 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,873 ns</td><td align="right" bgcolor="#FFFFFF">25,253 ns (Δ = +0,380 ns)</td><td align="right" bgcolor="#FF4949">29,313 ns (Δ = +4,060 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 70,552 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FF4949">+14,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">446,552 ns</td><td align="right" bgcolor="#FFFFFF">451,788 ns (Δ = +5,237 ns)</td><td align="right" bgcolor="#FF4949">517,103 ns (Δ = +65,315 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FF4949">0,517 μs (Δ = +0,065 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 68,468 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td><td align="right" bgcolor="#FF4949">+20,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,527 ns</td><td align="right" bgcolor="#FF4949">172,970 ns (Δ = +33,443 ns)</td><td align="right" bgcolor="#FF4949">207,995 ns (Δ = +35,025 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FF4949">0,173 μs (Δ = +0,033 μs)</td><td align="right" bgcolor="#FF4949">0,208 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,738 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,160 ns</td><td align="right" bgcolor="#FFFFFF">25,550 ns (Δ = -0,610 ns)</td><td align="right" bgcolor="#FFFFFF">25,422 ns (Δ = -0,128 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = 0,000 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 9,477 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+32,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,888 ns</td><td align="right" bgcolor="#FFFFFF">29,178 ns (Δ = -0,710 ns)</td><td align="right" bgcolor="#FF4949">38,655 ns (Δ = +9,477 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,039 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,448 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+29,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,778 ns</td><td align="right" bgcolor="#A8D08D">8,348 ns (Δ = -0,430 ns)</td><td align="right" bgcolor="#FF4949">10,797 ns (Δ = +2,448 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,011 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1,783 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,435 ns</td><td align="right" bgcolor="#FFFFFF">9,518 ns (Δ = +0,083 ns)</td><td align="right" bgcolor="#FF4949">11,218 ns (Δ = +1,700 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,011 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 19977,252 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,8 %</td><td align="right" bgcolor="#A8D08D">-10,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34556,298 ns</td><td align="right" bgcolor="#A8D08D">16322,235 ns (Δ = -18234,063 ns)</td><td align="right" bgcolor="#A8D08D">14579,047 ns (Δ = -1743,188 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">34,556 μs</td><td align="right" bgcolor="#A8D08D">16,322 μs (Δ = -18,234 μs)</td><td align="right" bgcolor="#A8D08D">14,579 μs (Δ = -1,743 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#A8D08D">0,016 ms (Δ = -0,018 ms)</td><td align="right" bgcolor="#A8D08D">0,015 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">5,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td><td align="right" bgcolor="#A8D08D">-46,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7852,000</td><td align="right" bgcolor="#A8D08D">5932,000 (Δ = -1920,000)</td><td align="right" bgcolor="#A8D08D">3197,000 (Δ = -2735,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,668</td><td align="right" bgcolor="#A8D08D">5,793 (Δ = -1,875)</td><td align="right" bgcolor="#A8D08D">3,122 (Δ = -2,671)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,863 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+17,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,098 ns</td><td align="right" bgcolor="#A8D08D">10,648 ns (Δ = -0,450 ns)</td><td align="right" bgcolor="#FF4949">12,512 ns (Δ = +1,863 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,013 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1,957 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#A8D08D">-12,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,658 ns</td><td align="right" bgcolor="#FFFFFF">14,473 ns (Δ = -0,185 ns)</td><td align="right" bgcolor="#A8D08D">12,702 ns (Δ = -1,772 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,858 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+13,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,628 ns</td><td align="right" bgcolor="#A8D08D">14,092 ns (Δ = -0,537 ns)</td><td align="right" bgcolor="#FF4949">15,950 ns (Δ = +1,858 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 2,772 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,452 ns</td><td align="right" bgcolor="#FF4949">15,277 ns (Δ = +0,825 ns)</td><td align="right" bgcolor="#A8D08D">12,505 ns (Δ = -2,772 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,003 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,098 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">-10,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,110 ns</td><td align="right" bgcolor="#A8D08D">15,565 ns (Δ = -0,545 ns)</td><td align="right" bgcolor="#A8D08D">14,012 ns (Δ = -1,553 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 13,005 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FF4949">+36,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">38,317 ns</td><td align="right" bgcolor="#A8D08D">36,037 ns (Δ = -2,280 ns)</td><td align="right" bgcolor="#FF4949">49,042 ns (Δ = +13,005 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#A8D08D">0,036 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,049 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 207,307 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+21,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">923,106 ns</td><td align="right" bgcolor="#FFFFFF">932,490 ns (Δ = +9,384 ns)</td><td align="right" bgcolor="#FF4949">1130,413 ns (Δ = +197,923 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,923 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#FF4949">1,130 μs (Δ = +0,198 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -86,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,084)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,215 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,053 ns</td><td align="right" bgcolor="#FFFFFF">17,995 ns (Δ = -0,058 ns)</td><td align="right" bgcolor="#FFFFFF">18,210 ns (Δ = +0,215 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 58,857 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+26,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">223,140 ns</td><td align="right" bgcolor="#FFFFFF">221,468 ns (Δ = -1,672 ns)</td><td align="right" bgcolor="#FF4949">280,325 ns (Δ = +58,857 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,280 μs (Δ = +0,059 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 6,532 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FF4949">+19,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,862 ns</td><td align="right" bgcolor="#FFFFFF">34,280 ns (Δ = -0,582 ns)</td><td align="right" bgcolor="#FF4949">40,812 ns (Δ = +6,532 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 17,088 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">115,844 ns</td><td align="right" bgcolor="#A8D08D">105,957 ns (Δ = -9,887 ns)</td><td align="right" bgcolor="#FF4949">123,045 ns (Δ = +17,088 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#A8D08D">0,106 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,123 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 7,433 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+25,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28,690 ns</td><td align="right" bgcolor="#FFFFFF">28,752 ns (Δ = +0,062 ns)</td><td align="right" bgcolor="#FF4949">36,123 ns (Δ = +7,372 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,036 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 98,623 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+33,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">301,008 ns</td><td align="right" bgcolor="#A8D08D">290,572 ns (Δ = -10,436 ns)</td><td align="right" bgcolor="#FF4949">389,195 ns (Δ = +98,623 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#A8D08D">0,291 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,389 μs (Δ = +0,099 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 183,275 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#A8D08D">-7,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2367,217 ns</td><td align="right" bgcolor="#FFFFFF">2363,455 ns (Δ = -3,762 ns)</td><td align="right" bgcolor="#A8D08D">2183,942 ns (Δ = -179,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,367 μs</td><td align="right" bgcolor="#FFFFFF">2,363 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">2,184 μs (Δ = -0,180 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,4 %</td><td align="right" bgcolor="#A8D08D">-36,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">889,000</td><td align="right" bgcolor="#FF4949">1044,000 (Δ = +155,000)</td><td align="right" bgcolor="#A8D08D">663,000 (Δ = -381,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,868</td><td align="right" bgcolor="#FF4949">1,020 (Δ = +0,151)</td><td align="right" bgcolor="#A8D08D">0,647 (Δ = -0,372)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 251,593 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-10,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2335,608 ns</td><td align="right" bgcolor="#FF4949">2422,572 ns (Δ = +86,963 ns)</td><td align="right" bgcolor="#A8D08D">2170,978 ns (Δ = -251,593 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,336 μs</td><td align="right" bgcolor="#FF4949">2,423 μs (Δ = +0,087 μs)</td><td align="right" bgcolor="#A8D08D">2,171 μs (Δ = -0,252 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,6 %</td><td align="right" bgcolor="#A8D08D">-36,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FF4949">1036,000 (Δ = +155,000)</td><td align="right" bgcolor="#A8D08D">658,000 (Δ = -378,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FF4949">1,012 (Δ = +0,151)</td><td align="right" bgcolor="#A8D08D">0,643 (Δ = -0,369)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 53,587 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2763,325 ns</td><td align="right" bgcolor="#FFFFFF">2810,028 ns (Δ = +46,703 ns)</td><td align="right" bgcolor="#FFFFFF">2756,442 ns (Δ = -53,587 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,763 μs</td><td align="right" bgcolor="#FFFFFF">2,810 μs (Δ = +0,047 μs)</td><td align="right" bgcolor="#FFFFFF">2,756 μs (Δ = -0,054 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,7 %</td><td align="right" bgcolor="#A8D08D">-30,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1298,000</td><td align="right" bgcolor="#FF4949">1450,000 (Δ = +152,000)</td><td align="right" bgcolor="#A8D08D">1015,000 (Δ = -435,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,268</td><td align="right" bgcolor="#FF4949">1,416 (Δ = +0,148)</td><td align="right" bgcolor="#A8D08D">0,991 (Δ = -0,425)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 152,005 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3175,978 ns</td><td align="right" bgcolor="#FFFFFF">3252,818 ns (Δ = +76,840 ns)</td><td align="right" bgcolor="#A8D08D">3100,813 ns (Δ = -152,005 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,176 μs</td><td align="right" bgcolor="#FFFFFF">3,253 μs (Δ = +0,077 μs)</td><td align="right" bgcolor="#A8D08D">3,101 μs (Δ = -0,152 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#A8D08D">-32,1 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1507,000</td><td align="right" bgcolor="#FF4949">1658,000 (Δ = +151,000)</td><td align="right" bgcolor="#A8D08D">1125,000 (Δ = -533,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,472</td><td align="right" bgcolor="#FF4949">1,619 (Δ = +0,147)</td><td align="right" bgcolor="#A8D08D">1,099 (Δ = -0,521)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 15,163 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FF4949">+11,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,990 ns</td><td align="right" bgcolor="#FFFFFF">106,942 ns (Δ = +2,952 ns)</td><td align="right" bgcolor="#FF4949">119,153 ns (Δ = +12,212 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,119 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 15,715 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,0 %</td><td align="right" bgcolor="#FF4949">+15,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,363 ns</td><td align="right" bgcolor="#FFFFFF">104,368 ns (Δ = +0,005 ns)</td><td align="right" bgcolor="#FF4949">120,078 ns (Δ = +15,710 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,120 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 436,788 ns


<table>
<tr>
<th> </th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2844,938 ns</td><td align="right" bgcolor="#FF4949">3281,727 ns (Δ = +436,788 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,845 μs</td><td align="right" bgcolor="#FF4949">3,282 μs (Δ = +0,437 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">971,000</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,948</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr>
</table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 4,178 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">196,358 ns</td><td align="right" bgcolor="#FFFFFF">197,055 ns (Δ = +0,697 ns)</td><td align="right" bgcolor="#FFFFFF">200,537 ns (Δ = +3,482 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,201 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 6,087 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">197,833 ns</td><td align="right" bgcolor="#FFFFFF">197,075 ns (Δ = -0,758 ns)</td><td align="right" bgcolor="#FFFFFF">203,162 ns (Δ = +6,087 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,203 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 8,635 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,557 ns</td><td align="right" bgcolor="#FFFFFF">222,522 ns (Δ = +2,965 ns)</td><td align="right" bgcolor="#FFFFFF">228,192 ns (Δ = +5,670 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,228 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 32,470 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+16,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,647 ns</td><td align="right" bgcolor="#FFFFFF">196,388 ns (Δ = +0,742 ns)</td><td align="right" bgcolor="#FF4949">228,117 ns (Δ = +31,728 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,228 μs (Δ = +0,032 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 66,187 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+34,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">199,017 ns</td><td align="right" bgcolor="#A8D08D">193,142 ns (Δ = -5,875 ns)</td><td align="right" bgcolor="#FF4949">259,328 ns (Δ = +66,187 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#A8D08D">0,193 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,259 μs (Δ = +0,066 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 120,615 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,5 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">983,780 ns</td><td align="right" bgcolor="#FF4949">1087,382 ns (Δ = +103,602 ns)</td><td align="right" bgcolor="#FFFFFF">1104,395 ns (Δ = +17,013 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,984 μs</td><td align="right" bgcolor="#FF4949">1,087 μs (Δ = +0,104 μs)</td><td align="right" bgcolor="#FFFFFF">1,104 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 239,092 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FF4949">+21,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">973,753 ns</td><td align="right" bgcolor="#FFFFFF">999,158 ns (Δ = +25,405 ns)</td><td align="right" bgcolor="#FF4949">1212,845 ns (Δ = +213,687 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td><td align="right" bgcolor="#FFFFFF">0,999 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FF4949">1,213 μs (Δ = +0,214 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 49,473 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+20,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">237,138 ns</td><td align="right" bgcolor="#FFFFFF">237,012 ns (Δ = -0,127 ns)</td><td align="right" bgcolor="#FF4949">286,485 ns (Δ = +49,473 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,286 μs (Δ = +0,049 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 10,085 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">238,750 ns</td><td align="right" bgcolor="#FFFFFF">233,818 ns (Δ = -4,932 ns)</td><td align="right" bgcolor="#FF4949">243,903 ns (Δ = +10,085 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,244 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 35,368 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">256,812 ns</td><td align="right" bgcolor="#FFFFFF">252,950 ns (Δ = -3,862 ns)</td><td align="right" bgcolor="#FF4949">288,318 ns (Δ = +35,368 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,288 μs (Δ = +0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 18,768 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,1 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">207,128 ns</td><td align="right" bgcolor="#FF4949">225,897 ns (Δ = +18,768 ns)</td><td align="right" bgcolor="#A8D08D">216,660 ns (Δ = -9,237 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FF4949">0,226 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#A8D08D">0,217 μs (Δ = -0,009 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 29,455 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FF4949">+14,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">213,095 ns</td><td align="right" bgcolor="#FFFFFF">207,322 ns (Δ = -5,773 ns)</td><td align="right" bgcolor="#FF4949">236,777 ns (Δ = +29,455 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,237 μs (Δ = +0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 255,145 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+51,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">494,293 ns</td><td align="right" bgcolor="#FFFFFF">495,230 ns (Δ = +0,937 ns)</td><td align="right" bgcolor="#FF4949">749,438 ns (Δ = +254,208 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,494 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,749 μs (Δ = +0,254 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">193,000 (Δ = -151,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,147)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 130,137 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+13,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">927,888 ns</td><td align="right" bgcolor="#FFFFFF">929,335 ns (Δ = +1,447 ns)</td><td align="right" bgcolor="#FF4949">1058,025 ns (Δ = +128,690 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,928 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">1,058 μs (Δ = +0,129 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 79,242 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">922,000 ns</td><td align="right" bgcolor="#FFFFFF">928,945 ns (Δ = +6,945 ns)</td><td align="right" bgcolor="#FF4949">1001,242 ns (Δ = +72,297 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,922 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FF4949">1,001 μs (Δ = +0,072 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 7,813 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">240,040 ns</td><td align="right" bgcolor="#FFFFFF">245,732 ns (Δ = +5,692 ns)</td><td align="right" bgcolor="#FFFFFF">247,853 ns (Δ = +2,122 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,248 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,303 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">213,350 ns</td><td align="right" bgcolor="#FFFFFF">213,158 ns (Δ = -0,192 ns)</td><td align="right" bgcolor="#FFFFFF">217,462 ns (Δ = +4,303 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,217 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 173,713 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+54,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">331,982 ns</td><td align="right" bgcolor="#A8D08D">319,400 ns (Δ = -12,582 ns)</td><td align="right" bgcolor="#FF4949">493,113 ns (Δ = +173,713 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#A8D08D">0,319 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">0,493 μs (Δ = +0,174 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-45,8 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FFFFFF">332,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -152,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FFFFFF">0,324 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,148)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,783 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,807 ns</td><td align="right" bgcolor="#A8D08D">7,462 ns (Δ = -0,345 ns)</td><td align="right" bgcolor="#A8D08D">7,023 ns (Δ = -0,438 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,688 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,4 %</td><td align="right" bgcolor="#FF4949">+9,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,608 ns</td><td align="right" bgcolor="#A8D08D">7,045 ns (Δ = -0,563 ns)</td><td align="right" bgcolor="#FF4949">7,733 ns (Δ = +0,688 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 4,195 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,9 %</td><td align="right" bgcolor="#A8D08D">-12,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,685 ns</td><td align="right" bgcolor="#A8D08D">8,537 ns (Δ = -3,148 ns)</td><td align="right" bgcolor="#A8D08D">7,490 ns (Δ = -1,047 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 1,098 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-13,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,560 ns</td><td align="right" bgcolor="#FF4949">8,042 ns (Δ = +0,482 ns)</td><td align="right" bgcolor="#A8D08D">6,943 ns (Δ = -1,098 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = -0,001 μs)</td></tr>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 0,096 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+191,3 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,050 ns</td><td align="right" bgcolor="#FF4949">0,146 ns (Δ = +0,096 ns)</td><td align="right" bgcolor="#A8D08D">0,139 ns (Δ = -0,007 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FF4949">0,000 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,000 μs (Δ = 0,000 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,075 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,9 %</td><td align="right" bgcolor="#FF4949">+104,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,079 ns</td><td align="right" bgcolor="#A8D08D">0,072 ns (Δ = -0,007 ns)</td><td align="right" bgcolor="#FF4949">0,147 ns (Δ = +0,075 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#A8D08D">0,000 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,000 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 0,095 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FF4949">+13,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,583 ns</td><td align="right" bgcolor="#FFFFFF">0,598 ns (Δ = +0,015 ns)</td><td align="right" bgcolor="#FF4949">0,678 ns (Δ = +0,080 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,021 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-64,6 %</td><td align="right" bgcolor="#FF4949">+22,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#A8D08D">0,012 ns (Δ = -0,021 ns)</td><td align="right" bgcolor="#FF4949">0,014 ns (Δ = +0,003 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#A8D08D">0,000 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,000 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 0,024 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,1 %</td><td align="right" bgcolor="#A8D08D">-64,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,028 ns</td><td align="right" bgcolor="#FF4949">0,037 ns (Δ = +0,009 ns)</td><td align="right" bgcolor="#A8D08D">0,013 ns (Δ = -0,024 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FF4949">0,000 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,000 μs (Δ = 0,000 μs)</td></tr>
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
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,110 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,628 ns</td><td align="right" bgcolor="#FFFFFF">0,615 ns (Δ = -0,013 ns)</td><td align="right" bgcolor="#FF4949">0,725 ns (Δ = +0,110 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 164,860 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+18,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">926,272 ns</td><td align="right" bgcolor="#FFFFFF">916,022 ns (Δ = -10,250 ns)</td><td align="right" bgcolor="#FF4949">1080,882 ns (Δ = +164,860 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,926 μs</td><td align="right" bgcolor="#FFFFFF">0,916 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">1,081 μs (Δ = +0,165 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#A8D08D">-42,2 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#FFFFFF">737,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">426,000 (Δ = -311,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#FFFFFF">0,720 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,416 (Δ = -0,304)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 15110,632 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,0 %</td><td align="right" bgcolor="#A8D08D">-12,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29775,525 ns</td><td align="right" bgcolor="#A8D08D">16662,687 ns (Δ = -13112,838 ns)</td><td align="right" bgcolor="#A8D08D">14664,893 ns (Δ = -1997,793 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">29,776 μs</td><td align="right" bgcolor="#A8D08D">16,663 μs (Δ = -13,113 μs)</td><td align="right" bgcolor="#A8D08D">14,665 μs (Δ = -1,998 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#A8D08D">0,017 ms (Δ = -0,013 ms)</td><td align="right" bgcolor="#A8D08D">0,015 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.2.0</td>
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
<td align="right">5.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">5,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#A8D08D">-46,0 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7563,000</td><td align="right" bgcolor="#A8D08D">5852,000 (Δ = -1711,000)</td><td align="right" bgcolor="#A8D08D">3158,000 (Δ = -2694,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,386</td><td align="right" bgcolor="#A8D08D">5,715 (Δ = -1,671)</td><td align="right" bgcolor="#A8D08D">3,084 (Δ = -2,631)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td></tr>
</table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1157,297 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+919,1 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,302 ns</td><td align="right" bgcolor="#FF4949">1246,372 ns (Δ = +1124,070 ns)</td><td align="right" bgcolor="#FFFFFF">1279,598 ns (Δ = +33,227 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FF4949">1,246 μs (Δ = +1,124 μs)</td><td align="right" bgcolor="#FFFFFF">1,280 μs (Δ = +0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+136,0 %</td><td align="right" bgcolor="#A8D08D">-47,9 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175,000</td><td align="right" bgcolor="#FF4949">413,000 (Δ = +238,000)</td><td align="right" bgcolor="#A8D08D">215,000 (Δ = -198,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,171</td><td align="right" bgcolor="#FF4949">0,403 (Δ = +0,232)</td><td align="right" bgcolor="#A8D08D">0,210 (Δ = -0,193)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1156,972 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3610,5 %</td><td align="right" bgcolor="#FF4949">+20,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,468 ns</td><td align="right" bgcolor="#FF4949">982,103 ns (Δ = +955,635 ns)</td><td align="right" bgcolor="#FF4949">1183,440 ns (Δ = +201,337 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FF4949">0,982 μs (Δ = +0,956 μs)</td><td align="right" bgcolor="#FF4949">1,183 μs (Δ = +0,201 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -115,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,112)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,798 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#A8D08D">-56,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,795 ns</td><td align="right" bgcolor="#A8D08D">4,558 ns (Δ = -0,237 ns)</td><td align="right" bgcolor="#A8D08D">1,997 ns (Δ = -2,562 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

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
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">NaN %</td><td align="right" bgcolor="#FFFFFF">NaN %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 2788,137 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,7 %</td><td align="right" bgcolor="#A8D08D">-9,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16669,178 ns</td><td align="right" bgcolor="#FF4949">19457,315 ns (Δ = +2788,137 ns)</td><td align="right" bgcolor="#A8D08D">17632,327 ns (Δ = -1824,988 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">16,669 μs</td><td align="right" bgcolor="#FF4949">19,457 μs (Δ = +2,788 μs)</td><td align="right" bgcolor="#A8D08D">17,632 μs (Δ = -1,825 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FF4949">0,019 ms (Δ = +0,003 ms)</td><td align="right" bgcolor="#A8D08D">0,018 ms (Δ = -0,002 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,8 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1224,000</td><td align="right" bgcolor="#FF4949">1478,000 (Δ = +254,000)</td><td align="right" bgcolor="#A8D08D">743,000 (Δ = -735,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,195</td><td align="right" bgcolor="#FF4949">1,443 (Δ = +0,248)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,718)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3782,065 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,9 %</td><td align="right" bgcolor="#A8D08D">-11,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17244,210 ns</td><td align="right" bgcolor="#FF4949">21026,275 ns (Δ = +3782,065 ns)</td><td align="right" bgcolor="#A8D08D">18527,487 ns (Δ = -2498,788 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,244 μs</td><td align="right" bgcolor="#FF4949">21,026 μs (Δ = +3,782 μs)</td><td align="right" bgcolor="#A8D08D">18,527 μs (Δ = -2,499 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FF4949">0,021 ms (Δ = +0,004 ms)</td><td align="right" bgcolor="#A8D08D">0,019 ms (Δ = -0,002 ms)</td></tr>
</table>

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
<td align="right">5.2.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000 (Δ = 0,000)</td></tr>
<tr>
<td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,8 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td></tr>
<tr>
<td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1224,000</td><td align="right" bgcolor="#FF4949">1478,000 (Δ = +254,000)</td><td align="right" bgcolor="#A8D08D">743,000 (Δ = -735,000)</td></tr>
<tr>
<td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,195</td><td align="right" bgcolor="#FF4949">1,443 (Δ = +0,248)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,718)</td></tr>
<tr>
<td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr>
</table>


