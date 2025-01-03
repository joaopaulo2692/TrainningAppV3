#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
196,
208,
209,
210,
211,
212,
213,
214,
215,
216,
219,
220,
221,
390,
391,
392,
421,
422,
423,
443,
444,
445,
446,
563,
564,
565,
568,
606,
607,
609,
611,
613,
615,
620,
628,
629,
630,
631,
632,
633,
634,
635,
636,
637,
638,
639,
640,
641,
642,
643,
644,
646,
647,
648,
649,
650,
651,
652,
741,
742,
743,
744,
745,
746,
747,
748,
749,
750,
751,
752,
753,
754,
755,
756,
757,
759,
760,
761,
762,
763,
764,
765,
832,
833,
900,
906,
909,
911,
916,
917,
919,
920,
924,
926,
927,
929,
931,
932,
935,
936,
937,
940,
942,
945,
947,
949,
958,
1026,
1028,
1030,
1040,
1041,
1042,
1043,
1045,
1052,
1053,
1054,
1055,
1056,
1064,
1065,
1066,
1070,
1071,
1073,
1077,
1078,
1079,
1358,
1551,
1552,
8030,
8031,
8033,
8034,
8035,
8036,
8037,
8038,
8040,
8042,
8044,
8045,
8046,
8057,
8059,
8064,
8066,
8068,
8070,
8120,
8126,
8127,
8129,
8130,
8131,
8132,
8133,
8135,
8137,
9232,
9236,
9238,
9239,
9240,
9241,
9496,
9497,
9498,
9499,
9519,
9520,
9521,
9523,
9564,
9623,
9625,
9627,
9636,
9637,
9638,
9639,
10064,
10065,
10070,
10071,
10104,
10140,
10147,
10154,
10165,
10169,
10194,
10278,
10280,
10290,
10292,
10293,
10294,
10301,
10316,
10336,
10337,
10345,
10347,
10354,
10355,
10358,
10360,
10365,
10371,
10372,
10379,
10381,
10393,
10396,
10397,
10398,
10409,
10418,
10424,
10425,
10426,
10428,
10429,
10446,
10448,
10462,
10482,
10483,
10508,
10513,
10543,
10544,
11148,
11241,
11242,
11456,
11457,
11465,
11466,
11467,
11473,
11570,
11972,
11973,
12213,
12214,
12219,
12229,
13573,
13594,
13596,
13598,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_System_RuntimeType_AllocateValueType_raw (int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
void ves_icall_System_Threading_Thread_StartInternal_raw (int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 196,
ves_icall_System_Array_InternalCreate,
// token 208,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 209,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 210,
ves_icall_System_Array_CanChangePrimitive,
// token 211,
ves_icall_System_Array_FastCopy,
// token 212,
ves_icall_System_Array_GetLengthInternal_raw,
// token 213,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 214,
ves_icall_System_Array_GetGenericValue_icall,
// token 215,
ves_icall_System_Array_GetValueImpl_raw,
// token 216,
ves_icall_System_Array_SetGenericValue_icall,
// token 219,
ves_icall_System_Array_SetValueImpl_raw,
// token 220,
ves_icall_System_Array_InitializeInternal_raw,
// token 221,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 390,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 391,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 392,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 421,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 422,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 423,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 443,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 444,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 445,
ves_icall_System_Enum_InternalGetCorElementType,
// token 446,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 563,
ves_icall_System_Environment_get_ProcessorCount,
// token 564,
ves_icall_System_Environment_get_TickCount,
// token 565,
ves_icall_System_Environment_get_TickCount64,
// token 568,
ves_icall_System_Environment_FailFast_raw,
// token 606,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 607,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 609,
ves_icall_System_GC_SuppressFinalize_raw,
// token 611,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 613,
ves_icall_System_GC_GetGCMemoryInfo,
// token 615,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 620,
ves_icall_System_Object_MemberwiseClone_raw,
// token 628,
ves_icall_System_Math_Acos,
// token 629,
ves_icall_System_Math_Acosh,
// token 630,
ves_icall_System_Math_Asin,
// token 631,
ves_icall_System_Math_Asinh,
// token 632,
ves_icall_System_Math_Atan,
// token 633,
ves_icall_System_Math_Atan2,
// token 634,
ves_icall_System_Math_Atanh,
// token 635,
ves_icall_System_Math_Cbrt,
// token 636,
ves_icall_System_Math_Ceiling,
// token 637,
ves_icall_System_Math_Cos,
// token 638,
ves_icall_System_Math_Cosh,
// token 639,
ves_icall_System_Math_Exp,
// token 640,
ves_icall_System_Math_Floor,
// token 641,
ves_icall_System_Math_Log,
// token 642,
ves_icall_System_Math_Log10,
// token 643,
ves_icall_System_Math_Pow,
// token 644,
ves_icall_System_Math_Sin,
// token 646,
ves_icall_System_Math_Sinh,
// token 647,
ves_icall_System_Math_Sqrt,
// token 648,
ves_icall_System_Math_Tan,
// token 649,
ves_icall_System_Math_Tanh,
// token 650,
ves_icall_System_Math_FusedMultiplyAdd,
// token 651,
ves_icall_System_Math_Log2,
// token 652,
ves_icall_System_Math_ModF,
// token 741,
ves_icall_System_MathF_Acos,
// token 742,
ves_icall_System_MathF_Acosh,
// token 743,
ves_icall_System_MathF_Asin,
// token 744,
ves_icall_System_MathF_Asinh,
// token 745,
ves_icall_System_MathF_Atan,
// token 746,
ves_icall_System_MathF_Atan2,
// token 747,
ves_icall_System_MathF_Atanh,
// token 748,
ves_icall_System_MathF_Cbrt,
// token 749,
ves_icall_System_MathF_Ceiling,
// token 750,
ves_icall_System_MathF_Cos,
// token 751,
ves_icall_System_MathF_Cosh,
// token 752,
ves_icall_System_MathF_Exp,
// token 753,
ves_icall_System_MathF_Floor,
// token 754,
ves_icall_System_MathF_Log,
// token 755,
ves_icall_System_MathF_Log10,
// token 756,
ves_icall_System_MathF_Pow,
// token 757,
ves_icall_System_MathF_Sin,
// token 759,
ves_icall_System_MathF_Sinh,
// token 760,
ves_icall_System_MathF_Sqrt,
// token 761,
ves_icall_System_MathF_Tan,
// token 762,
ves_icall_System_MathF_Tanh,
// token 763,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 764,
ves_icall_System_MathF_Log2,
// token 765,
ves_icall_System_MathF_ModF,
// token 832,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 833,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 900,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 906,
ves_icall_RuntimeType_make_array_type_raw,
// token 909,
ves_icall_RuntimeType_make_byref_type_raw,
// token 911,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 916,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 917,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 919,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 920,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 924,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 926,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 927,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 929,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 931,
ves_icall_System_RuntimeType_getFullName_raw,
// token 932,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 935,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 936,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 937,
ves_icall_RuntimeType_GetFields_native_raw,
// token 940,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 942,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 945,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 947,
ves_icall_RuntimeType_GetName_raw,
// token 949,
ves_icall_RuntimeType_GetNamespace_raw,
// token 958,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1026,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1028,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1030,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1040,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1041,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1042,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1043,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1045,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1052,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1053,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1054,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1055,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1056,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1064,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1065,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1066,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1070,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1071,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1073,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1077,
ves_icall_System_String_FastAllocateString_raw,
// token 1078,
ves_icall_System_String_InternalIsInterned_raw,
// token 1079,
ves_icall_System_String_InternalIntern_raw,
// token 1358,
ves_icall_System_Type_internal_from_handle_raw,
// token 1551,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1552,
ves_icall_System_ValueType_Equals_raw,
// token 8030,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8031,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8033,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8034,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 8035,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8036,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8037,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8038,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8040,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8042,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8044,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8045,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8046,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 8057,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8059,
mono_monitor_exit_icall_raw,
// token 8064,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8066,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8068,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8070,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8120,
ves_icall_System_Threading_Thread_StartInternal_raw,
// token 8126,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8127,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8129,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8130,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8131,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8132,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8133,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8135,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8137,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 9232,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 9236,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 9238,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 9239,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 9240,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 9241,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 9496,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 9497,
ves_icall_System_GCHandle_InternalFree_raw,
// token 9498,
ves_icall_System_GCHandle_InternalGet_raw,
// token 9499,
ves_icall_System_GCHandle_InternalSet_raw,
// token 9519,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 9520,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 9521,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 9523,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 9564,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 9623,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 9625,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 9627,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 9636,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 9637,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 9638,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 9639,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 10064,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 10065,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 10070,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 10071,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 10104,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 10140,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 10147,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 10154,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10165,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10169,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 10194,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 10278,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 10280,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 10290,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 10292,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 10293,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 10294,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 10301,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 10316,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 10336,
ves_icall_reflection_get_token_raw,
// token 10337,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 10345,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 10347,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 10354,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 10355,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 10358,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 10360,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 10365,
ves_icall_reflection_get_token_raw,
// token 10371,
ves_icall_get_method_info_raw,
// token 10372,
ves_icall_get_method_attributes,
// token 10379,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 10381,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 10393,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 10396,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 10397,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 10398,
ves_icall_reflection_get_token_raw,
// token 10409,
ves_icall_InternalInvoke_raw,
// token 10418,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 10424,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 10425,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 10426,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 10428,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 10429,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 10446,
ves_icall_InvokeClassConstructor_raw,
// token 10448,
ves_icall_InternalInvoke_raw,
// token 10462,
ves_icall_reflection_get_token_raw,
// token 10482,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 10483,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 10508,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 10513,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 10543,
ves_icall_reflection_get_token_raw,
// token 10544,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 11148,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 11241,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 11242,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 11456,
ves_icall_ModuleBuilder_basic_init_raw,
// token 11457,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 11465,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 11466,
ves_icall_ModuleBuilder_getToken_raw,
// token 11467,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 11473,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 11570,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 11972,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 11973,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 12213,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 12214,
ves_icall_System_Diagnostics_Debugger_Log,
// token 12219,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 12229,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 13573,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 13594,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 13596,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 13598,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
};
