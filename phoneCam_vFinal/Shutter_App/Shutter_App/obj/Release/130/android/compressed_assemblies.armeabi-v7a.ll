; ModuleID = 'obj\Release\130\android\compressed_assemblies.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [167936 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [1628160 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [109056 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [62976 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [351232 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [56320 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [212480 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [25600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [506368 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [67072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [328704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [225792 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [9728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [41984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [197120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [29184 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [37376 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [14336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [32256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [75264 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [23448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [152984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [15240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [15296 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [15240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [2214296 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [26504 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [536984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [1881600 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [31 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 167936, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([167936 x i8], [167936 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 1628160, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1628160 x i8], [1628160 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 109056, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([109056 x i8], [109056 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 62976, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([62976 x i8], [62976 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 351232, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([351232 x i8], [351232 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 56320, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([56320 x i8], [56320 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 212480, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([212480 x i8], [212480 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25600 x i8], [25600 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 506368, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([506368 x i8], [506368 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 67072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([67072 x i8], [67072 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 328704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([328704 x i8], [328704 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 225792, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([225792 x i8], [225792 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 9728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9728 x i8], [9728 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 41984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([41984 x i8], [41984 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 197120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([197120 x i8], [197120 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 29184, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29184 x i8], [29184 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 37376, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([37376 x i8], [37376 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 14336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14336 x i8], [14336 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 32256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32256 x i8], [32256 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 75264, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([75264 x i8], [75264 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 23448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([23448 x i8], [23448 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 152984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152984 x i8], [152984 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 15240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15240 x i8], [15240 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 15296, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15296 x i8], [15296 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 15240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15240 x i8], [15240 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 2214296, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2214296 x i8], [2214296 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 26504, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26504 x i8], [26504 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 536984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([536984 x i8], [536984 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 1881600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1881600 x i8], [1881600 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}
], align 4; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 31, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([31 x %struct.CompressedAssemblyDescriptor], [31 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 4


!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
