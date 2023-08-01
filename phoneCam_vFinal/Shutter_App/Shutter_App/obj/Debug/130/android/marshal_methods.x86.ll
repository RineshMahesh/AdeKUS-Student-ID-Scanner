; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [150 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 41
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 63
	i32 134690465, ; 2: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 67
	i32 165246403, ; 3: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 20
	i32 209399409, ; 4: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 18
	i32 230216969, ; 5: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 37
	i32 261689757, ; 6: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 23
	i32 280482487, ; 7: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 36
	i32 318968648, ; 8: Xamarin.AndroidX.Activity.dll => 0x13031348 => 11
	i32 321597661, ; 9: System.Numerics => 0x132b30dd => 7
	i32 342366114, ; 10: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 38
	i32 441335492, ; 11: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 22
	i32 442521989, ; 12: Xamarin.Essentials => 0x1a605985 => 60
	i32 450948140, ; 13: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 35
	i32 465846621, ; 14: mscorlib => 0x1bc4415d => 3
	i32 469710990, ; 15: System.dll => 0x1bff388e => 6
	i32 476646585, ; 16: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 36
	i32 486930444, ; 17: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 45
	i32 527452488, ; 18: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 67
	i32 563931624, ; 19: Shutter_App => 0x219ce9e8 => 0
	i32 627609679, ; 20: Xamarin.AndroidX.CustomView => 0x2568904f => 28
	i32 639843206, ; 21: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 34
	i32 663517072, ; 22: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 57
	i32 666292255, ; 23: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 16
	i32 691348768, ; 24: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 69
	i32 700284507, ; 25: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 64
	i32 720511267, ; 26: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 68
	i32 790371945, ; 27: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 29
	i32 809851609, ; 28: System.Drawing.Common.dll => 0x30455ad9 => 72
	i32 843511501, ; 29: Xamarin.AndroidX.Print => 0x3246f6cd => 47
	i32 928116545, ; 30: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 63
	i32 956575887, ; 31: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 68
	i32 967690846, ; 32: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 38
	i32 1012816738, ; 33: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 51
	i32 1031528504, ; 34: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 62
	i32 1035644815, ; 35: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 15
	i32 1052210849, ; 36: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 42
	i32 1084122840, ; 37: Xamarin.Kotlin.StdLib => 0x409e66d8 => 66
	i32 1098259244, ; 38: System => 0x41761b2c => 6
	i32 1104002344, ; 39: Plugin.Media => 0x41cdbd28 => 4
	i32 1175144683, ; 40: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 55
	i32 1204270330, ; 41: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 16
	i32 1264511973, ; 42: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 52
	i32 1267360935, ; 43: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 56
	i32 1275534314, ; 44: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 69
	i32 1293217323, ; 45: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 31
	i32 1376866003, ; 46: Xamarin.AndroidX.SavedState => 0x52114ed3 => 51
	i32 1406073936, ; 47: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 24
	i32 1469204771, ; 48: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 14
	i32 1582372066, ; 49: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 30
	i32 1597949149, ; 50: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 62
	i32 1622152042, ; 51: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 44
	i32 1624863272, ; 52: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 59
	i32 1635184631, ; 53: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 34
	i32 1636350590, ; 54: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 27
	i32 1639515021, ; 55: System.Net.Http.dll => 0x61b9038d => 71
	i32 1657153582, ; 56: System.Runtime => 0x62c6282e => 9
	i32 1658241508, ; 57: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 53
	i32 1658251792, ; 58: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 61
	i32 1670060433, ; 59: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 23
	i32 1698840827, ; 60: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 65
	i32 1729485958, ; 61: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 19
	i32 1776026572, ; 62: System.Core.dll => 0x69dc03cc => 5
	i32 1788241197, ; 63: Xamarin.AndroidX.Fragment => 0x6a96652d => 35
	i32 1808609942, ; 64: Xamarin.AndroidX.Loader => 0x6bcd3296 => 44
	i32 1813058853, ; 65: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 66
	i32 1813201214, ; 66: Xamarin.Google.Android.Material => 0x6c13413e => 61
	i32 1867746548, ; 67: Xamarin.Essentials.dll => 0x6f538cf4 => 60
	i32 1885316902, ; 68: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 17
	i32 1919157823, ; 69: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 46
	i32 1983156543, ; 70: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 65
	i32 2019465201, ; 71: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 42
	i32 2048185678, ; 72: Plugin.Media.dll => 0x7a14d54e => 4
	i32 2055257422, ; 73: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 39
	i32 2079903147, ; 74: System.Runtime.dll => 0x7bf8cdab => 9
	i32 2090596640, ; 75: System.Numerics.Vectors => 0x7c9bf920 => 8
	i32 2201107256, ; 76: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 70
	i32 2201231467, ; 77: System.Net.Http => 0x8334206b => 71
	i32 2217644978, ; 78: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 55
	i32 2244775296, ; 79: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 45
	i32 2256548716, ; 80: Xamarin.AndroidX.MultiDex => 0x8680336c => 46
	i32 2279755925, ; 81: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 49
	i32 2315684594, ; 82: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 12
	i32 2403452196, ; 83: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 33
	i32 2465532216, ; 84: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 22
	i32 2475788418, ; 85: Java.Interop.dll => 0x93918882 => 1
	i32 2505896520, ; 86: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 41
	i32 2581819634, ; 87: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 56
	i32 2605712449, ; 88: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 70
	i32 2620871830, ; 89: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 27
	i32 2624644809, ; 90: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 32
	i32 2701096212, ; 91: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 53
	i32 2732626843, ; 92: Xamarin.AndroidX.Activity => 0xa2e0939b => 11
	i32 2737747696, ; 93: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 14
	i32 2770495804, ; 94: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 64
	i32 2778768386, ; 95: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 58
	i32 2779977773, ; 96: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 50
	i32 2810250172, ; 97: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 24
	i32 2819470561, ; 98: System.Xml.dll => 0xa80db4e1 => 10
	i32 2821294376, ; 99: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 50
	i32 2853208004, ; 100: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 58
	i32 2855708567, ; 101: Xamarin.AndroidX.Transition => 0xaa36a797 => 54
	i32 2903344695, ; 102: System.ComponentModel.Composition => 0xad0d8637 => 74
	i32 2905242038, ; 103: mscorlib.dll => 0xad2a79b6 => 3
	i32 2916838712, ; 104: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 59
	i32 2919462931, ; 105: System.Numerics.Vectors.dll => 0xae037813 => 8
	i32 2921128767, ; 106: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 13
	i32 2978675010, ; 107: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 31
	i32 2996846495, ; 108: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 40
	i32 3016983068, ; 109: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 52
	i32 3024354802, ; 110: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 37
	i32 3211777861, ; 111: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 30
	i32 3247949154, ; 112: Mono.Security => 0xc197c562 => 73
	i32 3258312781, ; 113: Xamarin.AndroidX.CardView => 0xc235e84d => 19
	i32 3317135071, ; 114: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 28
	i32 3340431453, ; 115: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 17
	i32 3345895724, ; 116: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 48
	i32 3362522851, ; 117: Xamarin.AndroidX.Core => 0xc86c06e3 => 26
	i32 3366347497, ; 118: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 119: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 49
	i32 3405233483, ; 120: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 29
	i32 3429136800, ; 121: System.Xml => 0xcc6479a0 => 10
	i32 3441283291, ; 122: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 32
	i32 3476120550, ; 123: Mono.Android => 0xcf3163e6 => 2
	i32 3493954962, ; 124: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 21
	i32 3567349600, ; 125: System.ComponentModel.Composition.dll => 0xd4a16f60 => 74
	i32 3605791829, ; 126: Shutter_App.dll => 0xd6ec0455 => 0
	i32 3627220390, ; 127: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 47
	i32 3633644679, ; 128: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 13
	i32 3641597786, ; 129: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 39
	i32 3672681054, ; 130: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3682565725, ; 131: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 18
	i32 3684561358, ; 132: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 21
	i32 3689375977, ; 133: System.Drawing.Common => 0xdbe768e9 => 72
	i32 3706696989, ; 134: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 25
	i32 3718780102, ; 135: Xamarin.AndroidX.Annotation => 0xdda814c6 => 12
	i32 3786282454, ; 136: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 20
	i32 3829621856, ; 137: System.Numerics.dll => 0xe4436460 => 7
	i32 3885922214, ; 138: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 54
	i32 3888767677, ; 139: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 48
	i32 3896760992, ; 140: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 26
	i32 3921031405, ; 141: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 57
	i32 3955647286, ; 142: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 15
	i32 3959773229, ; 143: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 40
	i32 4101593132, ; 144: Xamarin.AndroidX.Emoji2 => 0xf479582c => 33
	i32 4105002889, ; 145: Mono.Security.dll => 0xf4ad5f89 => 73
	i32 4151237749, ; 146: System.Core => 0xf76edc75 => 5
	i32 4182413190, ; 147: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 43
	i32 4256097574, ; 148: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 25
	i32 4292120959 ; 149: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 43
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [150 x i32] [
	i32 41, i32 63, i32 67, i32 20, i32 18, i32 37, i32 23, i32 36, ; 0..7
	i32 11, i32 7, i32 38, i32 22, i32 60, i32 35, i32 3, i32 6, ; 8..15
	i32 36, i32 45, i32 67, i32 0, i32 28, i32 34, i32 57, i32 16, ; 16..23
	i32 69, i32 64, i32 68, i32 29, i32 72, i32 47, i32 63, i32 68, ; 24..31
	i32 38, i32 51, i32 62, i32 15, i32 42, i32 66, i32 6, i32 4, ; 32..39
	i32 55, i32 16, i32 52, i32 56, i32 69, i32 31, i32 51, i32 24, ; 40..47
	i32 14, i32 30, i32 62, i32 44, i32 59, i32 34, i32 27, i32 71, ; 48..55
	i32 9, i32 53, i32 61, i32 23, i32 65, i32 19, i32 5, i32 35, ; 56..63
	i32 44, i32 66, i32 61, i32 60, i32 17, i32 46, i32 65, i32 42, ; 64..71
	i32 4, i32 39, i32 9, i32 8, i32 70, i32 71, i32 55, i32 45, ; 72..79
	i32 46, i32 49, i32 12, i32 33, i32 22, i32 1, i32 41, i32 56, ; 80..87
	i32 70, i32 27, i32 32, i32 53, i32 11, i32 14, i32 64, i32 58, ; 88..95
	i32 50, i32 24, i32 10, i32 50, i32 58, i32 54, i32 74, i32 3, ; 96..103
	i32 59, i32 8, i32 13, i32 31, i32 40, i32 52, i32 37, i32 30, ; 104..111
	i32 73, i32 19, i32 28, i32 17, i32 48, i32 26, i32 1, i32 49, ; 112..119
	i32 29, i32 10, i32 32, i32 2, i32 21, i32 74, i32 0, i32 47, ; 120..127
	i32 13, i32 39, i32 2, i32 18, i32 21, i32 72, i32 25, i32 12, ; 128..135
	i32 20, i32 7, i32 54, i32 48, i32 26, i32 57, i32 15, i32 40, ; 136..143
	i32 33, i32 73, i32 5, i32 43, i32 25, i32 43 ; 144..149
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
