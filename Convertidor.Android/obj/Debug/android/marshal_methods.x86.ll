; ModuleID = 'obj/Debug/android/marshal_methods.x86.ll'
source_filename = "obj/Debug/android/marshal_methods.x86.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [198 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 57
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 86
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 81
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 71
	i32 120558881, ; 4: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 71
	i32 165246403, ; 5: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 38
	i32 182336117, ; 6: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 72
	i32 209399409, ; 7: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 36
	i32 230216969, ; 8: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 52
	i32 231814094, ; 9: System.Globalization => 0xdd133ce => 7
	i32 232815796, ; 10: System.Web.Services => 0xde07cb4 => 95
	i32 261689757, ; 11: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 41
	i32 278686392, ; 12: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 56
	i32 280482487, ; 13: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 50
	i32 318968648, ; 14: Xamarin.AndroidX.Activity.dll => 0x13031348 => 28
	i32 321597661, ; 15: System.Numerics => 0x132b30dd => 23
	i32 342366114, ; 16: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 54
	i32 441335492, ; 17: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 40
	i32 442521989, ; 18: Xamarin.Essentials => 0x1a605985 => 80
	i32 442565967, ; 19: System.Collections => 0x1a61054f => 3
	i32 450948140, ; 20: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 49
	i32 465846621, ; 21: mscorlib => 0x1bc4415d => 15
	i32 469710990, ; 22: System.dll => 0x1bff388e => 22
	i32 476646585, ; 23: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 50
	i32 486930444, ; 24: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 61
	i32 526420162, ; 25: System.Transactions.dll => 0x1f6088c2 => 90
	i32 545304856, ; 26: System.Runtime.Extensions => 0x2080b118 => 4
	i32 605376203, ; 27: System.IO.Compression.FileSystem => 0x24154ecb => 93
	i32 627609679, ; 28: Xamarin.AndroidX.CustomView => 0x2568904f => 45
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 77
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 33
	i32 690569205, ; 31: System.Xml.Linq.dll => 0x29293ff5 => 27
	i32 719061231, ; 32: Syncfusion.Core.XForms.dll => 0x2adc00ef => 17
	i32 775507847, ; 33: System.IO.Compression => 0x2e394f87 => 92
	i32 809851609, ; 34: System.Drawing.Common.dll => 0x30455ad9 => 8
	i32 843511501, ; 35: Xamarin.AndroidX.Print => 0x3246f6cd => 68
	i32 877678880, ; 36: System.Globalization.dll => 0x34505120 => 7
	i32 928116545, ; 37: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 86
	i32 967690846, ; 38: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 54
	i32 974778368, ; 39: FormsViewGroup.dll => 0x3a19f000 => 12
	i32 992768348, ; 40: System.Collections.dll => 0x3b2c715c => 3
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 70
	i32 1035644815, ; 42: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 32
	i32 1042160112, ; 43: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 83
	i32 1052210849, ; 44: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 58
	i32 1098259244, ; 45: System => 0x41761b2c => 22
	i32 1175144683, ; 46: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 75
	i32 1178241025, ; 47: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 65
	i32 1204270330, ; 48: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 33
	i32 1220769793, ; 49: Convertidor => 0x48c37801 => 11
	i32 1267360935, ; 50: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 76
	i32 1293217323, ; 51: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 47
	i32 1324164729, ; 52: System.Linq => 0x4eed2679 => 97
	i32 1365406463, ; 53: System.ServiceModel.Internals.dll => 0x516272ff => 87
	i32 1376866003, ; 54: Xamarin.AndroidX.SavedState => 0x52114ed3 => 70
	i32 1379779777, ; 55: System.Resources.ResourceManager => 0x523dc4c1 => 1
	i32 1395857551, ; 56: Xamarin.AndroidX.Media.dll => 0x5333188f => 62
	i32 1406073936, ; 57: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 42
	i32 1457743152, ; 58: System.Runtime.Extensions.dll => 0x56e36530 => 4
	i32 1460219004, ; 59: Xamarin.Forms.Xaml => 0x57092c7c => 84
	i32 1462112819, ; 60: System.IO.Compression.dll => 0x57261233 => 92
	i32 1469204771, ; 61: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 31
	i32 1516315406, ; 62: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 16
	i32 1543031311, ; 63: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 96
	i32 1550322496, ; 64: System.Reflection.Extensions.dll => 0x5c680b40 => 5
	i32 1582372066, ; 65: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 46
	i32 1592978981, ; 66: System.Runtime.Serialization.dll => 0x5ef2ee25 => 10
	i32 1622152042, ; 67: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 60
	i32 1624863272, ; 68: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 79
	i32 1636350590, ; 69: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 44
	i32 1639515021, ; 70: System.Net.Http.dll => 0x61b9038d => 9
	i32 1639986890, ; 71: System.Text.RegularExpressions => 0x61c036ca => 96
	i32 1657153582, ; 72: System.Runtime => 0x62c6282e => 25
	i32 1658241508, ; 73: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 73
	i32 1658251792, ; 74: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 85
	i32 1670060433, ; 75: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 41
	i32 1696888072, ; 76: Syncfusion.SfNumericUpDown.XForms.dll => 0x65247508 => 20
	i32 1726116996, ; 77: System.Reflection.dll => 0x66e27484 => 2
	i32 1729485958, ; 78: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 37
	i32 1765942094, ; 79: System.Reflection.Extensions => 0x6942234e => 5
	i32 1766324549, ; 80: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 72
	i32 1776026572, ; 81: System.Core.dll => 0x69dc03cc => 21
	i32 1788241197, ; 82: Xamarin.AndroidX.Fragment => 0x6a96652d => 49
	i32 1808609942, ; 83: Xamarin.AndroidX.Loader => 0x6bcd3296 => 60
	i32 1813201214, ; 84: Xamarin.Google.Android.Material => 0x6c13413e => 85
	i32 1818569960, ; 85: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 66
	i32 1864410085, ; 86: Syncfusion.SfNumericUpDown.XForms.Android => 0x6f20a3e5 => 19
	i32 1867746548, ; 87: Xamarin.Essentials.dll => 0x6f538cf4 => 80
	i32 1878053835, ; 88: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 84
	i32 1885316902, ; 89: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 34
	i32 1900610850, ; 90: System.Resources.ResourceManager.dll => 0x71490522 => 1
	i32 1919157823, ; 91: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 63
	i32 2019465201, ; 92: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 58
	i32 2055257422, ; 93: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 55
	i32 2079903147, ; 94: System.Runtime.dll => 0x7bf8cdab => 25
	i32 2090596640, ; 95: System.Numerics.Vectors => 0x7c9bf920 => 24
	i32 2097448633, ; 96: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 51
	i32 2126786730, ; 97: Xamarin.Forms.Platform.Android => 0x7ec430aa => 82
	i32 2201231467, ; 98: System.Net.Http => 0x8334206b => 9
	i32 2217644978, ; 99: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 75
	i32 2244775296, ; 100: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 61
	i32 2256548716, ; 101: Xamarin.AndroidX.MultiDex => 0x8680336c => 63
	i32 2261435625, ; 102: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 53
	i32 2279755925, ; 103: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 69
	i32 2315684594, ; 104: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 29
	i32 2343171156, ; 105: Syncfusion.Core.XForms => 0x8ba9f454 => 17
	i32 2354730003, ; 106: Syncfusion.Licensing => 0x8c5a5413 => 18
	i32 2409053734, ; 107: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 67
	i32 2454642406, ; 108: System.Text.Encoding.dll => 0x924edee6 => 6
	i32 2465532216, ; 109: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 40
	i32 2471841756, ; 110: netstandard.dll => 0x93554fdc => 88
	i32 2475788418, ; 111: Java.Interop.dll => 0x93918882 => 13
	i32 2501346920, ; 112: System.Data.DataSetExtensions => 0x95178668 => 91
	i32 2505896520, ; 113: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 57
	i32 2581819634, ; 114: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 76
	i32 2620871830, ; 115: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 44
	i32 2624644809, ; 116: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 48
	i32 2633051222, ; 117: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 56
	i32 2667468896, ; 118: Convertidor.Android.dll => 0x9efe5860 => 0
	i32 2701096212, ; 119: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 73
	i32 2732626843, ; 120: Xamarin.AndroidX.Activity => 0xa2e0939b => 28
	i32 2733225977, ; 121: Convertidor.Android => 0xa2e9b7f9 => 0
	i32 2737747696, ; 122: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 31
	i32 2766581644, ; 123: Xamarin.Forms.Core => 0xa4e6af8c => 81
	i32 2778768386, ; 124: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 78
	i32 2810250172, ; 125: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 42
	i32 2819470561, ; 126: System.Xml.dll => 0xa80db4e1 => 26
	i32 2853208004, ; 127: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 78
	i32 2855708567, ; 128: Xamarin.AndroidX.Transition => 0xaa36a797 => 74
	i32 2868557005, ; 129: Syncfusion.Licensing.dll => 0xaafab4cd => 18
	i32 2874148507, ; 130: Syncfusion.Core.XForms.Android => 0xab50069b => 16
	i32 2901442782, ; 131: System.Reflection => 0xacf080de => 2
	i32 2903344695, ; 132: System.ComponentModel.Composition => 0xad0d8637 => 94
	i32 2905242038, ; 133: mscorlib.dll => 0xad2a79b6 => 15
	i32 2916838712, ; 134: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 79
	i32 2919462931, ; 135: System.Numerics.Vectors.dll => 0xae037813 => 24
	i32 2921128767, ; 136: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 30
	i32 2978675010, ; 137: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 47
	i32 3004694178, ; 138: Syncfusion.SfNumericUpDown.XForms => 0xb317fea2 => 20
	i32 3024354802, ; 139: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 52
	i32 3044182254, ; 140: FormsViewGroup => 0xb57288ee => 12
	i32 3057625584, ; 141: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 64
	i32 3111772706, ; 142: System.Runtime.Serialization => 0xb979e222 => 10
	i32 3204380047, ; 143: System.Data.dll => 0xbefef58f => 89
	i32 3211777861, ; 144: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 46
	i32 3247949154, ; 145: Mono.Security => 0xc197c562 => 98
	i32 3258312781, ; 146: Xamarin.AndroidX.CardView => 0xc235e84d => 37
	i32 3267021929, ; 147: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 35
	i32 3299363146, ; 148: System.Text.Encoding => 0xc4a8494a => 6
	i32 3317135071, ; 149: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 45
	i32 3317144872, ; 150: System.Data => 0xc5b79d28 => 89
	i32 3340431453, ; 151: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 34
	i32 3346324047, ; 152: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 65
	i32 3353484488, ; 153: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 51
	i32 3362522851, ; 154: Xamarin.AndroidX.Core => 0xc86c06e3 => 43
	i32 3366347497, ; 155: Java.Interop => 0xc8a662e9 => 13
	i32 3374999561, ; 156: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 69
	i32 3404865022, ; 157: System.ServiceModel.Internals => 0xcaf21dfe => 87
	i32 3429136800, ; 158: System.Xml => 0xcc6479a0 => 26
	i32 3430777524, ; 159: netstandard => 0xcc7d82b4 => 88
	i32 3434480064, ; 160: Syncfusion.SfNumericUpDown.XForms.Android.dll => 0xccb601c0 => 19
	i32 3441283291, ; 161: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 48
	i32 3476120550, ; 162: Mono.Android => 0xcf3163e6 => 14
	i32 3486566296, ; 163: System.Transactions => 0xcfd0c798 => 90
	i32 3493954962, ; 164: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 39
	i32 3501239056, ; 165: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 35
	i32 3509114376, ; 166: System.Xml.Linq => 0xd128d608 => 27
	i32 3536029504, ; 167: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 82
	i32 3567349600, ; 168: System.ComponentModel.Composition.dll => 0xd4a16f60 => 94
	i32 3608519521, ; 169: System.Linq.dll => 0xd715a361 => 97
	i32 3618140916, ; 170: Xamarin.AndroidX.Preference => 0xd7a872f4 => 67
	i32 3627220390, ; 171: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 68
	i32 3632359727, ; 172: Xamarin.Forms.Platform => 0xd881692f => 83
	i32 3633644679, ; 173: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 30
	i32 3641597786, ; 174: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 55
	i32 3672681054, ; 175: Mono.Android.dll => 0xdae8aa5e => 14
	i32 3676310014, ; 176: System.Web.Services.dll => 0xdb2009fe => 95
	i32 3682565725, ; 177: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 36
	i32 3684561358, ; 178: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 39
	i32 3689375977, ; 179: System.Drawing.Common => 0xdbe768e9 => 8
	i32 3718780102, ; 180: Xamarin.AndroidX.Annotation => 0xdda814c6 => 29
	i32 3724971120, ; 181: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 64
	i32 3758932259, ; 182: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 53
	i32 3786282454, ; 183: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 38
	i32 3822602673, ; 184: Xamarin.AndroidX.Media => 0xe3d849b1 => 62
	i32 3829621856, ; 185: System.Numerics.dll => 0xe4436460 => 23
	i32 3885922214, ; 186: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 74
	i32 3896760992, ; 187: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 43
	i32 3920810846, ; 188: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 93
	i32 3921031405, ; 189: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 77
	i32 3931092270, ; 190: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 66
	i32 3945713374, ; 191: System.Data.DataSetExtensions.dll => 0xeb2ecede => 91
	i32 3955647286, ; 192: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 32
	i32 4070288862, ; 193: Convertidor.dll => 0xf29badde => 11
	i32 4105002889, ; 194: Mono.Security.dll => 0xf4ad5f89 => 98
	i32 4151237749, ; 195: System.Core => 0xf76edc75 => 21
	i32 4182413190, ; 196: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 59
	i32 4292120959 ; 197: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 59
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [198 x i32] [
	i32 57, i32 86, i32 81, i32 71, i32 71, i32 38, i32 72, i32 36, ; 0..7
	i32 52, i32 7, i32 95, i32 41, i32 56, i32 50, i32 28, i32 23, ; 8..15
	i32 54, i32 40, i32 80, i32 3, i32 49, i32 15, i32 22, i32 50, ; 16..23
	i32 61, i32 90, i32 4, i32 93, i32 45, i32 77, i32 33, i32 27, ; 24..31
	i32 17, i32 92, i32 8, i32 68, i32 7, i32 86, i32 54, i32 12, ; 32..39
	i32 3, i32 70, i32 32, i32 83, i32 58, i32 22, i32 75, i32 65, ; 40..47
	i32 33, i32 11, i32 76, i32 47, i32 97, i32 87, i32 70, i32 1, ; 48..55
	i32 62, i32 42, i32 4, i32 84, i32 92, i32 31, i32 16, i32 96, ; 56..63
	i32 5, i32 46, i32 10, i32 60, i32 79, i32 44, i32 9, i32 96, ; 64..71
	i32 25, i32 73, i32 85, i32 41, i32 20, i32 2, i32 37, i32 5, ; 72..79
	i32 72, i32 21, i32 49, i32 60, i32 85, i32 66, i32 19, i32 80, ; 80..87
	i32 84, i32 34, i32 1, i32 63, i32 58, i32 55, i32 25, i32 24, ; 88..95
	i32 51, i32 82, i32 9, i32 75, i32 61, i32 63, i32 53, i32 69, ; 96..103
	i32 29, i32 17, i32 18, i32 67, i32 6, i32 40, i32 88, i32 13, ; 104..111
	i32 91, i32 57, i32 76, i32 44, i32 48, i32 56, i32 0, i32 73, ; 112..119
	i32 28, i32 0, i32 31, i32 81, i32 78, i32 42, i32 26, i32 78, ; 120..127
	i32 74, i32 18, i32 16, i32 2, i32 94, i32 15, i32 79, i32 24, ; 128..135
	i32 30, i32 47, i32 20, i32 52, i32 12, i32 64, i32 10, i32 89, ; 136..143
	i32 46, i32 98, i32 37, i32 35, i32 6, i32 45, i32 89, i32 34, ; 144..151
	i32 65, i32 51, i32 43, i32 13, i32 69, i32 87, i32 26, i32 88, ; 152..159
	i32 19, i32 48, i32 14, i32 90, i32 39, i32 35, i32 27, i32 82, ; 160..167
	i32 94, i32 97, i32 67, i32 68, i32 83, i32 30, i32 55, i32 14, ; 168..175
	i32 95, i32 36, i32 39, i32 8, i32 29, i32 64, i32 53, i32 38, ; 176..183
	i32 62, i32 23, i32 74, i32 43, i32 93, i32 77, i32 66, i32 91, ; 184..191
	i32 32, i32 11, i32 98, i32 21, i32 59, i32 59 ; 192..197
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
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
