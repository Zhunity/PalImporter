using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AssetBundle
	/// </summary>
    public partial class RAssetBundle : RMember //
    {

		/// <summary>
		/// UnityEngine.Object mainAsset
		/// </summary>
		protected RUnityEngine.RObject r_mainAsset;
		public virtual RUnityEngine.RObject RmainAsset
		{
			get
			{
				if(r_mainAsset == null)
				{
					r_mainAsset = new(this, "mainAsset", -1);
					r_mainAsset.SetBelong(this.instance);
				}
				return r_mainAsset;
			}
		}

		/// <summary>
		/// Boolean isStreamedSceneAssetBundle
		/// </summary>
		protected RProperty r_isStreamedSceneAssetBundle;
		public virtual RProperty RisStreamedSceneAssetBundle
		{
			get
			{
				if(r_isStreamedSceneAssetBundle == null)
				{
					r_isStreamedSceneAssetBundle = new(this, "isStreamedSceneAssetBundle", -1);
					r_isStreamedSceneAssetBundle.SetBelong(this.instance);
				}
				return r_isStreamedSceneAssetBundle;
			}
		}

		/// <summary>
		/// UInt32 memoryBudgetKB
		/// </summary>
		protected static RProperty r_memoryBudgetKB;
		public static RProperty RmemoryBudgetKB
		{
			get
			{
				if(r_memoryBudgetKB == null)
				{
					r_memoryBudgetKB = new(typeof(UnityEngine.AssetBundle), "memoryBudgetKB", -1);
					r_memoryBudgetKB.SetBelong(null);
				}
				return r_memoryBudgetKB;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Object returnMainAsset(UnityEngine.AssetBundle)
		/// </summary>
		protected static RMethod r_RreturnMainAsset_AssetBundle;
		public static RMethod RreturnMainAsset_AssetBundle
		{
			get
			{
				if(r_RreturnMainAsset_AssetBundle == null)
				{
					r_RreturnMainAsset_AssetBundle = new(typeof(UnityEngine.AssetBundle), "returnMainAsset", 0, typeof(UnityEngine.AssetBundle));
					r_RreturnMainAsset_AssetBundle.SetBelong(null);
				}
				return r_RreturnMainAsset_AssetBundle;
			}
		}

		/// <summary>
		/// Void UnloadAllAssetBundles(Boolean)
		/// </summary>
		protected static RMethod r_RUnloadAllAssetBundles_Boolean;
		public static RMethod RUnloadAllAssetBundles_Boolean
		{
			get
			{
				if(r_RUnloadAllAssetBundles_Boolean == null)
				{
					r_RUnloadAllAssetBundles_Boolean = new(typeof(UnityEngine.AssetBundle), "UnloadAllAssetBundles", 0, typeof(System.Boolean));
					r_RUnloadAllAssetBundles_Boolean.SetBelong(null);
				}
				return r_RUnloadAllAssetBundles_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native()
		/// </summary>
		protected static RMethod r_RGetAllLoadedAssetBundles_Native;
		public static RMethod RGetAllLoadedAssetBundles_Native
		{
			get
			{
				if(r_RGetAllLoadedAssetBundles_Native == null)
				{
					r_RGetAllLoadedAssetBundles_Native = new(typeof(UnityEngine.AssetBundle), "GetAllLoadedAssetBundles_Native", 0);
					r_RGetAllLoadedAssetBundles_Native.SetBelong(null);
				}
				return r_RGetAllLoadedAssetBundles_Native;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.AssetBundle] GetAllLoadedAssetBundles()
		/// </summary>
		protected static RMethod r_RGetAllLoadedAssetBundles;
		public static RMethod RGetAllLoadedAssetBundles
		{
			get
			{
				if(r_RGetAllLoadedAssetBundles == null)
				{
					r_RGetAllLoadedAssetBundles = new(typeof(UnityEngine.AssetBundle), "GetAllLoadedAssetBundles", 0);
					r_RGetAllLoadedAssetBundles.SetBelong(null);
				}
				return r_RGetAllLoadedAssetBundles;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String, UInt32, UInt64)
		/// </summary>
		protected static RMethod r_RLoadFromFileAsync_Internal_String_UInt32_UInt64;
		public static RMethod RLoadFromFileAsync_Internal_String_UInt32_UInt64
		{
			get
			{
				if(r_RLoadFromFileAsync_Internal_String_UInt32_UInt64 == null)
				{
					r_RLoadFromFileAsync_Internal_String_UInt32_UInt64 = new(typeof(UnityEngine.AssetBundle), "LoadFromFileAsync_Internal", 0, typeof(System.String), typeof(System.UInt32), typeof(System.UInt64));
					r_RLoadFromFileAsync_Internal_String_UInt32_UInt64.SetBelong(null);
				}
				return r_RLoadFromFileAsync_Internal_String_UInt32_UInt64;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String)
		/// </summary>
		protected static RMethod r_RLoadFromFileAsync_String;
		public static RMethod RLoadFromFileAsync_String
		{
			get
			{
				if(r_RLoadFromFileAsync_String == null)
				{
					r_RLoadFromFileAsync_String = new(typeof(UnityEngine.AssetBundle), "LoadFromFileAsync", 0, typeof(System.String));
					r_RLoadFromFileAsync_String.SetBelong(null);
				}
				return r_RLoadFromFileAsync_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromFileAsync_String_UInt32;
		public static RMethod RLoadFromFileAsync_String_UInt32
		{
			get
			{
				if(r_RLoadFromFileAsync_String_UInt32 == null)
				{
					r_RLoadFromFileAsync_String_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromFileAsync", 0, typeof(System.String), typeof(System.UInt32));
					r_RLoadFromFileAsync_String_UInt32.SetBelong(null);
				}
				return r_RLoadFromFileAsync_String_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String, UInt32, UInt64)
		/// </summary>
		protected static RMethod r_RLoadFromFileAsync_String_UInt32_UInt64;
		public static RMethod RLoadFromFileAsync_String_UInt32_UInt64
		{
			get
			{
				if(r_RLoadFromFileAsync_String_UInt32_UInt64 == null)
				{
					r_RLoadFromFileAsync_String_UInt32_UInt64 = new(typeof(UnityEngine.AssetBundle), "LoadFromFileAsync", 0, typeof(System.String), typeof(System.UInt32), typeof(System.UInt64));
					r_RLoadFromFileAsync_String_UInt32_UInt64.SetBelong(null);
				}
				return r_RLoadFromFileAsync_String_UInt32_UInt64;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromFile_Internal(System.String, UInt32, UInt64)
		/// </summary>
		protected static RMethod r_RLoadFromFile_Internal_String_UInt32_UInt64;
		public static RMethod RLoadFromFile_Internal_String_UInt32_UInt64
		{
			get
			{
				if(r_RLoadFromFile_Internal_String_UInt32_UInt64 == null)
				{
					r_RLoadFromFile_Internal_String_UInt32_UInt64 = new(typeof(UnityEngine.AssetBundle), "LoadFromFile_Internal", 0, typeof(System.String), typeof(System.UInt32), typeof(System.UInt64));
					r_RLoadFromFile_Internal_String_UInt32_UInt64.SetBelong(null);
				}
				return r_RLoadFromFile_Internal_String_UInt32_UInt64;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromFile(System.String)
		/// </summary>
		protected static RMethod r_RLoadFromFile_String;
		public static RMethod RLoadFromFile_String
		{
			get
			{
				if(r_RLoadFromFile_String == null)
				{
					r_RLoadFromFile_String = new(typeof(UnityEngine.AssetBundle), "LoadFromFile", 0, typeof(System.String));
					r_RLoadFromFile_String.SetBelong(null);
				}
				return r_RLoadFromFile_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromFile(System.String, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromFile_String_UInt32;
		public static RMethod RLoadFromFile_String_UInt32
		{
			get
			{
				if(r_RLoadFromFile_String_UInt32 == null)
				{
					r_RLoadFromFile_String_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromFile", 0, typeof(System.String), typeof(System.UInt32));
					r_RLoadFromFile_String_UInt32.SetBelong(null);
				}
				return r_RLoadFromFile_String_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromFile(System.String, UInt32, UInt64)
		/// </summary>
		protected static RMethod r_RLoadFromFile_String_UInt32_UInt64;
		public static RMethod RLoadFromFile_String_UInt32_UInt64
		{
			get
			{
				if(r_RLoadFromFile_String_UInt32_UInt64 == null)
				{
					r_RLoadFromFile_String_UInt32_UInt64 = new(typeof(UnityEngine.AssetBundle), "LoadFromFile", 0, typeof(System.String), typeof(System.UInt32), typeof(System.UInt64));
					r_RLoadFromFile_String_UInt32_UInt64.SetBelong(null);
				}
				return r_RLoadFromFile_String_UInt32_UInt64;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Byte[], UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromMemoryAsync_Internal_ByteArray_UInt32;
		public static RMethod RLoadFromMemoryAsync_Internal_ByteArray_UInt32
		{
			get
			{
				if(r_RLoadFromMemoryAsync_Internal_ByteArray_UInt32 == null)
				{
					r_RLoadFromMemoryAsync_Internal_ByteArray_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromMemoryAsync_Internal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.UInt32));
					r_RLoadFromMemoryAsync_Internal_ByteArray_UInt32.SetBelong(null);
				}
				return r_RLoadFromMemoryAsync_Internal_ByteArray_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(Byte[])
		/// </summary>
		protected static RMethod r_RLoadFromMemoryAsync_ByteArray;
		public static RMethod RLoadFromMemoryAsync_ByteArray
		{
			get
			{
				if(r_RLoadFromMemoryAsync_ByteArray == null)
				{
					r_RLoadFromMemoryAsync_ByteArray = new(typeof(UnityEngine.AssetBundle), "LoadFromMemoryAsync", 0, typeof(System.Byte).MakeArrayType());
					r_RLoadFromMemoryAsync_ByteArray.SetBelong(null);
				}
				return r_RLoadFromMemoryAsync_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(Byte[], UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromMemoryAsync_ByteArray_UInt32;
		public static RMethod RLoadFromMemoryAsync_ByteArray_UInt32
		{
			get
			{
				if(r_RLoadFromMemoryAsync_ByteArray_UInt32 == null)
				{
					r_RLoadFromMemoryAsync_ByteArray_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromMemoryAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.UInt32));
					r_RLoadFromMemoryAsync_ByteArray_UInt32.SetBelong(null);
				}
				return r_RLoadFromMemoryAsync_ByteArray_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromMemory_Internal(Byte[], UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromMemory_Internal_ByteArray_UInt32;
		public static RMethod RLoadFromMemory_Internal_ByteArray_UInt32
		{
			get
			{
				if(r_RLoadFromMemory_Internal_ByteArray_UInt32 == null)
				{
					r_RLoadFromMemory_Internal_ByteArray_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromMemory_Internal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.UInt32));
					r_RLoadFromMemory_Internal_ByteArray_UInt32.SetBelong(null);
				}
				return r_RLoadFromMemory_Internal_ByteArray_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromMemory(Byte[])
		/// </summary>
		protected static RMethod r_RLoadFromMemory_ByteArray;
		public static RMethod RLoadFromMemory_ByteArray
		{
			get
			{
				if(r_RLoadFromMemory_ByteArray == null)
				{
					r_RLoadFromMemory_ByteArray = new(typeof(UnityEngine.AssetBundle), "LoadFromMemory", 0, typeof(System.Byte).MakeArrayType());
					r_RLoadFromMemory_ByteArray.SetBelong(null);
				}
				return r_RLoadFromMemory_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromMemory(Byte[], UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromMemory_ByteArray_UInt32;
		public static RMethod RLoadFromMemory_ByteArray_UInt32
		{
			get
			{
				if(r_RLoadFromMemory_ByteArray_UInt32 == null)
				{
					r_RLoadFromMemory_ByteArray_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromMemory", 0, typeof(System.Byte).MakeArrayType(), typeof(System.UInt32));
					r_RLoadFromMemory_ByteArray_UInt32.SetBelong(null);
				}
				return r_RLoadFromMemory_ByteArray_UInt32;
			}
		}

		/// <summary>
		/// Void ValidateLoadFromStream(System.IO.Stream)
		/// </summary>
		protected static RMethod r_RValidateLoadFromStream_Stream;
		public static RMethod RValidateLoadFromStream_Stream
		{
			get
			{
				if(r_RValidateLoadFromStream_Stream == null)
				{
					r_RValidateLoadFromStream_Stream = new(typeof(UnityEngine.AssetBundle), "ValidateLoadFromStream", 0, typeof(System.IO.Stream));
					r_RValidateLoadFromStream_Stream.SetBelong(null);
				}
				return r_RValidateLoadFromStream_Stream;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream, UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStreamAsync_Stream_UInt32_UInt32;
		public static RMethod RLoadFromStreamAsync_Stream_UInt32_UInt32
		{
			get
			{
				if(r_RLoadFromStreamAsync_Stream_UInt32_UInt32 == null)
				{
					r_RLoadFromStreamAsync_Stream_UInt32_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStreamAsync", 0, typeof(System.IO.Stream), typeof(System.UInt32), typeof(System.UInt32));
					r_RLoadFromStreamAsync_Stream_UInt32_UInt32.SetBelong(null);
				}
				return r_RLoadFromStreamAsync_Stream_UInt32_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStreamAsync_Stream_UInt32;
		public static RMethod RLoadFromStreamAsync_Stream_UInt32
		{
			get
			{
				if(r_RLoadFromStreamAsync_Stream_UInt32 == null)
				{
					r_RLoadFromStreamAsync_Stream_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStreamAsync", 0, typeof(System.IO.Stream), typeof(System.UInt32));
					r_RLoadFromStreamAsync_Stream_UInt32.SetBelong(null);
				}
				return r_RLoadFromStreamAsync_Stream_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream)
		/// </summary>
		protected static RMethod r_RLoadFromStreamAsync_Stream;
		public static RMethod RLoadFromStreamAsync_Stream
		{
			get
			{
				if(r_RLoadFromStreamAsync_Stream == null)
				{
					r_RLoadFromStreamAsync_Stream = new(typeof(UnityEngine.AssetBundle), "LoadFromStreamAsync", 0, typeof(System.IO.Stream));
					r_RLoadFromStreamAsync_Stream.SetBelong(null);
				}
				return r_RLoadFromStreamAsync_Stream;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromStream(System.IO.Stream, UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStream_Stream_UInt32_UInt32;
		public static RMethod RLoadFromStream_Stream_UInt32_UInt32
		{
			get
			{
				if(r_RLoadFromStream_Stream_UInt32_UInt32 == null)
				{
					r_RLoadFromStream_Stream_UInt32_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStream", 0, typeof(System.IO.Stream), typeof(System.UInt32), typeof(System.UInt32));
					r_RLoadFromStream_Stream_UInt32_UInt32.SetBelong(null);
				}
				return r_RLoadFromStream_Stream_UInt32_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromStream(System.IO.Stream, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStream_Stream_UInt32;
		public static RMethod RLoadFromStream_Stream_UInt32
		{
			get
			{
				if(r_RLoadFromStream_Stream_UInt32 == null)
				{
					r_RLoadFromStream_Stream_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStream", 0, typeof(System.IO.Stream), typeof(System.UInt32));
					r_RLoadFromStream_Stream_UInt32.SetBelong(null);
				}
				return r_RLoadFromStream_Stream_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromStream(System.IO.Stream)
		/// </summary>
		protected static RMethod r_RLoadFromStream_Stream;
		public static RMethod RLoadFromStream_Stream
		{
			get
			{
				if(r_RLoadFromStream_Stream == null)
				{
					r_RLoadFromStream_Stream = new(typeof(UnityEngine.AssetBundle), "LoadFromStream", 0, typeof(System.IO.Stream));
					r_RLoadFromStream_Stream.SetBelong(null);
				}
				return r_RLoadFromStream_Stream;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest LoadFromStreamAsyncInternal(System.IO.Stream, UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32;
		public static RMethod RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32
		{
			get
			{
				if(r_RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32 == null)
				{
					r_RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStreamAsyncInternal", 0, typeof(System.IO.Stream), typeof(System.UInt32), typeof(System.UInt32));
					r_RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32.SetBelong(null);
				}
				return r_RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle LoadFromStreamInternal(System.IO.Stream, UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromStreamInternal_Stream_UInt32_UInt32;
		public static RMethod RLoadFromStreamInternal_Stream_UInt32_UInt32
		{
			get
			{
				if(r_RLoadFromStreamInternal_Stream_UInt32_UInt32 == null)
				{
					r_RLoadFromStreamInternal_Stream_UInt32_UInt32 = new(typeof(UnityEngine.AssetBundle), "LoadFromStreamInternal", 0, typeof(System.IO.Stream), typeof(System.UInt32), typeof(System.UInt32));
					r_RLoadFromStreamInternal_Stream_UInt32_UInt32.SetBelong(null);
				}
				return r_RLoadFromStreamInternal_Stream_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void SetAssetBundleDecryptKey(System.String)
		/// </summary>
		protected static RMethod r_RSetAssetBundleDecryptKey_String;
		public static RMethod RSetAssetBundleDecryptKey_String
		{
			get
			{
				if(r_RSetAssetBundleDecryptKey_String == null)
				{
					r_RSetAssetBundleDecryptKey_String = new(typeof(UnityEngine.AssetBundle), "SetAssetBundleDecryptKey", 0, typeof(System.String));
					r_RSetAssetBundleDecryptKey_String.SetBelong(null);
				}
				return r_RSetAssetBundleDecryptKey_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_RContains_String;
		public virtual RMethod RContains_String
		{
			get
			{
				if(r_RContains_String == null)
				{
					r_RContains_String = new(this, "Contains", 0, typeof(System.String));
					r_RContains_String.SetBelong(this.instance);
				}
				return r_RContains_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object Load(System.String)
		/// </summary>
		protected RMethod r_RLoad_String;
		public virtual RMethod RLoad_String
		{
			get
			{
				if(r_RLoad_String == null)
				{
					r_RLoad_String = new(this, "Load", 0, typeof(System.String));
					r_RLoad_String.SetBelong(this.instance);
				}
				return r_RLoad_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object Load[T](System.String)
		/// </summary>
		protected RMethod r_RLoad_GT_String;
		public virtual RMethod RLoad_GT_String
		{
			get
			{
				if(r_RLoad_GT_String == null)
				{
					r_RLoad_GT_String = new(this, "Load", 1, typeof(System.String));
					r_RLoad_GT_String.SetBelong(this.instance);
				}
				return r_RLoad_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object Load(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoad_String_Type;
		public virtual RMethod RLoad_String_Type
		{
			get
			{
				if(r_RLoad_String_Type == null)
				{
					r_RLoad_String_Type = new(this, "Load", 0, typeof(System.String), typeof(System.Type));
					r_RLoad_String_Type.SetBelong(this.instance);
				}
				return r_RLoad_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAsync(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAsync_String_Type;
		public virtual RMethod RLoadAsync_String_Type
		{
			get
			{
				if(r_RLoadAsync_String_Type == null)
				{
					r_RLoadAsync_String_Type = new(this, "LoadAsync", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAsync_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAsync_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAll(System.Type)
		/// </summary>
		protected RMethod r_RLoadAll_Type;
		public virtual RMethod RLoadAll_Type
		{
			get
			{
				if(r_RLoadAll_Type == null)
				{
					r_RLoadAll_Type = new(this, "LoadAll", 0, typeof(System.Type));
					r_RLoadAll_Type.SetBelong(this.instance);
				}
				return r_RLoadAll_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAll()
		/// </summary>
		protected RMethod r_RLoadAll;
		public virtual RMethod RLoadAll
		{
			get
			{
				if(r_RLoadAll == null)
				{
					r_RLoadAll = new(this, "LoadAll", 0);
					r_RLoadAll.SetBelong(this.instance);
				}
				return r_RLoadAll;
			}
		}

		/// <summary>
		/// T[] LoadAll[T]()
		/// </summary>
		protected RMethod r_RLoadAll_GT;
		public virtual RMethod RLoadAll_GT
		{
			get
			{
				if(r_RLoadAll_GT == null)
				{
					r_RLoadAll_GT = new(this, "LoadAll", 1);
					r_RLoadAll_GT.SetBelong(this.instance);
				}
				return r_RLoadAll_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Object LoadAsset(System.String)
		/// </summary>
		protected RMethod r_RLoadAsset_String;
		public virtual RMethod RLoadAsset_String
		{
			get
			{
				if(r_RLoadAsset_String == null)
				{
					r_RLoadAsset_String = new(this, "LoadAsset", 0, typeof(System.String));
					r_RLoadAsset_String.SetBelong(this.instance);
				}
				return r_RLoadAsset_String;
			}
		}

		/// <summary>
		/// T LoadAsset[T](System.String)
		/// </summary>
		protected RMethod r_RLoadAsset_GT_String;
		public virtual RMethod RLoadAsset_GT_String
		{
			get
			{
				if(r_RLoadAsset_GT_String == null)
				{
					r_RLoadAsset_GT_String = new(this, "LoadAsset", 1, typeof(System.String));
					r_RLoadAsset_GT_String.SetBelong(this.instance);
				}
				return r_RLoadAsset_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object LoadAsset(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAsset_String_Type;
		public virtual RMethod RLoadAsset_String_Type
		{
			get
			{
				if(r_RLoadAsset_String_Type == null)
				{
					r_RLoadAsset_String_Type = new(this, "LoadAsset", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAsset_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAsset_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object LoadAsset_Internal(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAsset_Internal_String_Type;
		public virtual RMethod RLoadAsset_Internal_String_Type
		{
			get
			{
				if(r_RLoadAsset_Internal_String_Type == null)
				{
					r_RLoadAsset_Internal_String_Type = new(this, "LoadAsset_Internal", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAsset_Internal_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAsset_Internal_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetAsync(System.String)
		/// </summary>
		protected RMethod r_RLoadAssetAsync_String;
		public virtual RMethod RLoadAssetAsync_String
		{
			get
			{
				if(r_RLoadAssetAsync_String == null)
				{
					r_RLoadAssetAsync_String = new(this, "LoadAssetAsync", 0, typeof(System.String));
					r_RLoadAssetAsync_String.SetBelong(this.instance);
				}
				return r_RLoadAssetAsync_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetAsync[T](System.String)
		/// </summary>
		protected RMethod r_RLoadAssetAsync_GT_String;
		public virtual RMethod RLoadAssetAsync_GT_String
		{
			get
			{
				if(r_RLoadAssetAsync_GT_String == null)
				{
					r_RLoadAssetAsync_GT_String = new(this, "LoadAssetAsync", 1, typeof(System.String));
					r_RLoadAssetAsync_GT_String.SetBelong(this.instance);
				}
				return r_RLoadAssetAsync_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetAsync(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetAsync_String_Type;
		public virtual RMethod RLoadAssetAsync_String_Type
		{
			get
			{
				if(r_RLoadAssetAsync_String_Type == null)
				{
					r_RLoadAssetAsync_String_Type = new(this, "LoadAssetAsync", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetAsync_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetAsync_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAssetWithSubAssets(System.String)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssets_String;
		public virtual RMethod RLoadAssetWithSubAssets_String
		{
			get
			{
				if(r_RLoadAssetWithSubAssets_String == null)
				{
					r_RLoadAssetWithSubAssets_String = new(this, "LoadAssetWithSubAssets", 0, typeof(System.String));
					r_RLoadAssetWithSubAssets_String.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssets_String;
			}
		}

		/// <summary>
		/// T[] ConvertObjects[T](UnityEngine.Object[])
		/// </summary>
		protected static RMethod r_RConvertObjects_GT_ObjectArray;
		public static RMethod RConvertObjects_GT_ObjectArray
		{
			get
			{
				if(r_RConvertObjects_GT_ObjectArray == null)
				{
					r_RConvertObjects_GT_ObjectArray = new(typeof(UnityEngine.AssetBundle), "ConvertObjects", 1, typeof(UnityEngine.Object).MakeArrayType());
					r_RConvertObjects_GT_ObjectArray.SetBelong(null);
				}
				return r_RConvertObjects_GT_ObjectArray;
			}
		}

		/// <summary>
		/// T[] LoadAssetWithSubAssets[T](System.String)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssets_GT_String;
		public virtual RMethod RLoadAssetWithSubAssets_GT_String
		{
			get
			{
				if(r_RLoadAssetWithSubAssets_GT_String == null)
				{
					r_RLoadAssetWithSubAssets_GT_String = new(this, "LoadAssetWithSubAssets", 1, typeof(System.String));
					r_RLoadAssetWithSubAssets_GT_String.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssets_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAssetWithSubAssets(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssets_String_Type;
		public virtual RMethod RLoadAssetWithSubAssets_String_Type
		{
			get
			{
				if(r_RLoadAssetWithSubAssets_String_Type == null)
				{
					r_RLoadAssetWithSubAssets_String_Type = new(this, "LoadAssetWithSubAssets", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetWithSubAssets_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssets_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(System.String)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssetsAsync_String;
		public virtual RMethod RLoadAssetWithSubAssetsAsync_String
		{
			get
			{
				if(r_RLoadAssetWithSubAssetsAsync_String == null)
				{
					r_RLoadAssetWithSubAssetsAsync_String = new(this, "LoadAssetWithSubAssetsAsync", 0, typeof(System.String));
					r_RLoadAssetWithSubAssetsAsync_String.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssetsAsync_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync[T](System.String)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssetsAsync_GT_String;
		public virtual RMethod RLoadAssetWithSubAssetsAsync_GT_String
		{
			get
			{
				if(r_RLoadAssetWithSubAssetsAsync_GT_String == null)
				{
					r_RLoadAssetWithSubAssetsAsync_GT_String = new(this, "LoadAssetWithSubAssetsAsync", 1, typeof(System.String));
					r_RLoadAssetWithSubAssetsAsync_GT_String.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssetsAsync_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssetsAsync_String_Type;
		public virtual RMethod RLoadAssetWithSubAssetsAsync_String_Type
		{
			get
			{
				if(r_RLoadAssetWithSubAssetsAsync_String_Type == null)
				{
					r_RLoadAssetWithSubAssetsAsync_String_Type = new(this, "LoadAssetWithSubAssetsAsync", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetWithSubAssetsAsync_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssetsAsync_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAllAssets()
		/// </summary>
		protected RMethod r_RLoadAllAssets;
		public virtual RMethod RLoadAllAssets
		{
			get
			{
				if(r_RLoadAllAssets == null)
				{
					r_RLoadAllAssets = new(this, "LoadAllAssets", 0);
					r_RLoadAllAssets.SetBelong(this.instance);
				}
				return r_RLoadAllAssets;
			}
		}

		/// <summary>
		/// T[] LoadAllAssets[T]()
		/// </summary>
		protected RMethod r_RLoadAllAssets_GT;
		public virtual RMethod RLoadAllAssets_GT
		{
			get
			{
				if(r_RLoadAllAssets_GT == null)
				{
					r_RLoadAllAssets_GT = new(this, "LoadAllAssets", 1);
					r_RLoadAllAssets_GT.SetBelong(this.instance);
				}
				return r_RLoadAllAssets_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAllAssets(System.Type)
		/// </summary>
		protected RMethod r_RLoadAllAssets_Type;
		public virtual RMethod RLoadAllAssets_Type
		{
			get
			{
				if(r_RLoadAllAssets_Type == null)
				{
					r_RLoadAllAssets_Type = new(this, "LoadAllAssets", 0, typeof(System.Type));
					r_RLoadAllAssets_Type.SetBelong(this.instance);
				}
				return r_RLoadAllAssets_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAllAssetsAsync()
		/// </summary>
		protected RMethod r_RLoadAllAssetsAsync;
		public virtual RMethod RLoadAllAssetsAsync
		{
			get
			{
				if(r_RLoadAllAssetsAsync == null)
				{
					r_RLoadAllAssetsAsync = new(this, "LoadAllAssetsAsync", 0);
					r_RLoadAllAssetsAsync.SetBelong(this.instance);
				}
				return r_RLoadAllAssetsAsync;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAllAssetsAsync[T]()
		/// </summary>
		protected RMethod r_RLoadAllAssetsAsync_GT;
		public virtual RMethod RLoadAllAssetsAsync_GT
		{
			get
			{
				if(r_RLoadAllAssetsAsync_GT == null)
				{
					r_RLoadAllAssetsAsync_GT = new(this, "LoadAllAssetsAsync", 1);
					r_RLoadAllAssetsAsync_GT.SetBelong(this.instance);
				}
				return r_RLoadAllAssetsAsync_GT;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type)
		/// </summary>
		protected RMethod r_RLoadAllAssetsAsync_Type;
		public virtual RMethod RLoadAllAssetsAsync_Type
		{
			get
			{
				if(r_RLoadAllAssetsAsync_Type == null)
				{
					r_RLoadAllAssetsAsync_Type = new(this, "LoadAllAssetsAsync", 0, typeof(System.Type));
					r_RLoadAllAssetsAsync_Type.SetBelong(this.instance);
				}
				return r_RLoadAllAssetsAsync_Type;
			}
		}

		/// <summary>
		/// System.String[] AllAssetNames()
		/// </summary>
		protected RMethod r_RAllAssetNames;
		public virtual RMethod RAllAssetNames
		{
			get
			{
				if(r_RAllAssetNames == null)
				{
					r_RAllAssetNames = new(this, "AllAssetNames", 0);
					r_RAllAssetNames.SetBelong(this.instance);
				}
				return r_RAllAssetNames;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetAsync_Internal_String_Type;
		public virtual RMethod RLoadAssetAsync_Internal_String_Type
		{
			get
			{
				if(r_RLoadAssetAsync_Internal_String_Type == null)
				{
					r_RLoadAssetAsync_Internal_String_Type = new(this, "LoadAssetAsync_Internal", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetAsync_Internal_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetAsync_Internal_String_Type;
			}
		}

		/// <summary>
		/// Void Unload(Boolean)
		/// </summary>
		protected RMethod r_RUnload_Boolean;
		public virtual RMethod RUnload_Boolean
		{
			get
			{
				if(r_RUnload_Boolean == null)
				{
					r_RUnload_Boolean = new(this, "Unload", 0, typeof(System.Boolean));
					r_RUnload_Boolean.SetBelong(this.instance);
				}
				return r_RUnload_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleUnloadOperation UnloadAsync(Boolean)
		/// </summary>
		protected RMethod r_RUnloadAsync_Boolean;
		public virtual RMethod RUnloadAsync_Boolean
		{
			get
			{
				if(r_RUnloadAsync_Boolean == null)
				{
					r_RUnloadAsync_Boolean = new(this, "UnloadAsync", 0, typeof(System.Boolean));
					r_RUnloadAsync_Boolean.SetBelong(this.instance);
				}
				return r_RUnloadAsync_Boolean;
			}
		}

		/// <summary>
		/// System.String[] GetAllAssetNames()
		/// </summary>
		protected RMethod r_RGetAllAssetNames;
		public virtual RMethod RGetAllAssetNames
		{
			get
			{
				if(r_RGetAllAssetNames == null)
				{
					r_RGetAllAssetNames = new(this, "GetAllAssetNames", 0);
					r_RGetAllAssetNames.SetBelong(this.instance);
				}
				return r_RGetAllAssetNames;
			}
		}

		/// <summary>
		/// System.String[] GetAllScenePaths()
		/// </summary>
		protected RMethod r_RGetAllScenePaths;
		public virtual RMethod RGetAllScenePaths
		{
			get
			{
				if(r_RGetAllScenePaths == null)
				{
					r_RGetAllScenePaths = new(this, "GetAllScenePaths", 0);
					r_RGetAllScenePaths.SetBelong(this.instance);
				}
				return r_RGetAllScenePaths;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] LoadAssetWithSubAssets_Internal(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssets_Internal_String_Type;
		public virtual RMethod RLoadAssetWithSubAssets_Internal_String_Type
		{
			get
			{
				if(r_RLoadAssetWithSubAssets_Internal_String_Type == null)
				{
					r_RLoadAssetWithSubAssets_Internal_String_Type = new(this, "LoadAssetWithSubAssets_Internal", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetWithSubAssets_Internal_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssets_Internal_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(System.String, System.Type)
		/// </summary>
		protected RMethod r_RLoadAssetWithSubAssetsAsync_Internal_String_Type;
		public virtual RMethod RLoadAssetWithSubAssetsAsync_Internal_String_Type
		{
			get
			{
				if(r_RLoadAssetWithSubAssetsAsync_Internal_String_Type == null)
				{
					r_RLoadAssetWithSubAssetsAsync_Internal_String_Type = new(this, "LoadAssetWithSubAssetsAsync_Internal", 0, typeof(System.String), typeof(System.Type));
					r_RLoadAssetWithSubAssetsAsync_Internal_String_Type.SetBelong(this.instance);
				}
				return r_RLoadAssetWithSubAssetsAsync_Internal_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync(System.String, System.String, UnityEngine.BuildCompression, UInt32, UnityEngine.ThreadPriority)
		/// </summary>
		protected static RMethod r_RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority;
		public static RMethod RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority
		{
			get
			{
				if(r_RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority == null)
				{
					r_RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority = new(typeof(UnityEngine.AssetBundle), "RecompressAssetBundleAsync", 0, typeof(System.String), typeof(System.String), typeof(UnityEngine.BuildCompression), typeof(System.UInt32), typeof(UnityEngine.ThreadPriority));
					r_RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority.SetBelong(null);
				}
				return r_RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal(System.String, System.String, UnityEngine.BuildCompression, UInt32, UnityEngine.ThreadPriority)
		/// </summary>
		protected static RMethod r_RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority;
		public static RMethod RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority
		{
			get
			{
				if(r_RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority == null)
				{
					r_RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority = new(typeof(UnityEngine.AssetBundle), "RecompressAssetBundleAsync_Internal", 0, typeof(System.String), typeof(System.String), typeof(UnityEngine.BuildCompression), typeof(System.UInt32), typeof(UnityEngine.ThreadPriority));
					r_RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority.SetBelong(null);
				}
				return r_RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle CreateFromFile(System.String)
		/// </summary>
		protected static RMethod r_RCreateFromFile_String;
		public static RMethod RCreateFromFile_String
		{
			get
			{
				if(r_RCreateFromFile_String == null)
				{
					r_RCreateFromFile_String = new(typeof(UnityEngine.AssetBundle), "CreateFromFile", 0, typeof(System.String));
					r_RCreateFromFile_String.SetBelong(null);
				}
				return r_RCreateFromFile_String;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest CreateFromMemory(Byte[])
		/// </summary>
		protected static RMethod r_RCreateFromMemory_ByteArray;
		public static RMethod RCreateFromMemory_ByteArray
		{
			get
			{
				if(r_RCreateFromMemory_ByteArray == null)
				{
					r_RCreateFromMemory_ByteArray = new(typeof(UnityEngine.AssetBundle), "CreateFromMemory", 0, typeof(System.Byte).MakeArrayType());
					r_RCreateFromMemory_ByteArray.SetBelong(null);
				}
				return r_RCreateFromMemory_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle CreateFromMemoryImmediate(Byte[])
		/// </summary>
		protected static RMethod r_RCreateFromMemoryImmediate_ByteArray;
		public static RMethod RCreateFromMemoryImmediate_ByteArray
		{
			get
			{
				if(r_RCreateFromMemoryImmediate_ByteArray == null)
				{
					r_RCreateFromMemoryImmediate_ByteArray = new(typeof(UnityEngine.AssetBundle), "CreateFromMemoryImmediate", 0, typeof(System.Byte).MakeArrayType());
					r_RCreateFromMemoryImmediate_ByteArray.SetBelong(null);
				}
				return r_RCreateFromMemoryImmediate_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal_Injected(System.String, System.String, UnityEngine.BuildCompression ByRef, UInt32, UnityEngine.ThreadPriority)
		/// </summary>
		protected static RMethod r_RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority;
		public static RMethod RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority
		{
			get
			{
				if(r_RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority == null)
				{
					r_RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority = new(typeof(UnityEngine.AssetBundle), "RecompressAssetBundleAsync_Internal_Injected", 0, typeof(System.String), typeof(System.String), typeof(UnityEngine.BuildCompression).MakeByRefType(), typeof(System.UInt32), typeof(UnityEngine.ThreadPriority));
					r_RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority.SetBelong(null);
				}
				return r_RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RAssetBundle() : base("UnityEngine.AssetBundle")
        {
        }

        public RAssetBundle(System.Object instance) : base("UnityEngine.AssetBundle")
		{
            SetInstance(instance);
		}

        public RAssetBundle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetBundle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Object returnMainAsset(UnityEngine.AssetBundle  @bundle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bundle};
            var ___result = RreturnMainAsset_AssetBundle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static void UnloadAllAssetBundles(System.Boolean  @unloadAllObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unloadAllObjects};
            var ___result = RUnloadAllAssetBundles_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllLoadedAssetBundles_Native.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle[])___result;
        }


        public static System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllLoadedAssetBundles.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle>)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String  @path, System.UInt32  @crc, System.UInt64  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc, @offset};
            var ___result = RLoadFromFileAsync_Internal_String_UInt32_UInt64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RLoadFromFileAsync_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String  @path, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc};
            var ___result = RLoadFromFileAsync_String_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String  @path, System.UInt32  @crc, System.UInt64  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc, @offset};
            var ___result = RLoadFromFileAsync_String_UInt32_UInt64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundle LoadFromFile_Internal(System.String  @path, System.UInt32  @crc, System.UInt64  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc, @offset};
            var ___result = RLoadFromFile_Internal_String_UInt32_UInt64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromFile(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RLoadFromFile_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromFile(System.String  @path, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc};
            var ___result = RLoadFromFile_String_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromFile(System.String  @path, System.UInt32  @crc, System.UInt64  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @crc, @offset};
            var ___result = RLoadFromFile_String_UInt32_UInt64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(System.Byte[]  @binary, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary, @crc};
            var ___result = RLoadFromMemoryAsync_Internal_ByteArray_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[]  @binary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary};
            var ___result = RLoadFromMemoryAsync_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[]  @binary, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary, @crc};
            var ___result = RLoadFromMemoryAsync_ByteArray_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundle LoadFromMemory_Internal(System.Byte[]  @binary, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary, @crc};
            var ___result = RLoadFromMemory_Internal_ByteArray_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromMemory(System.Byte[]  @binary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary};
            var ___result = RLoadFromMemory_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromMemory(System.Byte[]  @binary, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary, @crc};
            var ___result = RLoadFromMemory_ByteArray_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static void ValidateLoadFromStream(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RValidateLoadFromStream_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream  @stream, System.UInt32  @crc, System.UInt32  @managedReadBufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc, @managedReadBufferSize};
            var ___result = RLoadFromStreamAsync_Stream_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream  @stream, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc};
            var ___result = RLoadFromStreamAsync_Stream_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RLoadFromStreamAsync_Stream.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream  @stream, System.UInt32  @crc, System.UInt32  @managedReadBufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc, @managedReadBufferSize};
            var ___result = RLoadFromStream_Stream_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream  @stream, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc};
            var ___result = RLoadFromStream_Stream_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RLoadFromStream_Stream.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsyncInternal(System.IO.Stream  @stream, System.UInt32  @crc, System.UInt32  @managedReadBufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc, @managedReadBufferSize};
            var ___result = RLoadFromStreamAsyncInternal_Stream_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundle LoadFromStreamInternal(System.IO.Stream  @stream, System.UInt32  @crc, System.UInt32  @managedReadBufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @crc, @managedReadBufferSize};
            var ___result = RLoadFromStreamInternal_Stream_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static void SetAssetBundleDecryptKey(System.String  @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password};
            var ___result = RSetAssetBundleDecryptKey_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Object Load(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLoad_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object Load<T>(System.String  @name)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@name};
            var ___result = RLoad_GT_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object Load(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoad_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAsync(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAsync_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.Object[] LoadAll(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RLoadAll_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual UnityEngine.Object[] LoadAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAll.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual T[] LoadAll<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RLoadAll_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Object LoadAsset(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAsset_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual T LoadAsset<T>(System.String  @name) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAsset_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Object LoadAsset(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAsset_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object LoadAsset_Internal(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAsset_Internal_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetAsync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetAsync_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetAsync<T>(System.String  @name)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetAsync_GT_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetAsync(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetAsync_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.Object[] LoadAssetWithSubAssets(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetWithSubAssets_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static T[] ConvertObjects<T>(UnityEngine.Object[]  @rawObjects) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rawObjects};
            var ___result = RConvertObjects_GT_ObjectArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual T[] LoadAssetWithSubAssets<T>(System.String  @name) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetWithSubAssets_GT_String.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Object[] LoadAssetWithSubAssets(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetWithSubAssets_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetWithSubAssetsAsync_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(System.String  @name)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@name};
            var ___result = RLoadAssetWithSubAssetsAsync_GT_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetWithSubAssetsAsync_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.Object[] LoadAllAssets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAllAssets.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual T[] LoadAllAssets<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RLoadAllAssets_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Object[] LoadAllAssets(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RLoadAllAssets_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAllAssetsAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAllAssetsAsync.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAllAssetsAsync<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RLoadAllAssetsAsync_GT.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RLoadAllAssetsAsync_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual System.String[] AllAssetNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllAssetNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetAsync_Internal_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public virtual void Unload(System.Boolean  @unloadAllLoadedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unloadAllLoadedObjects};
            var ___result = RUnload_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.AssetBundleUnloadOperation UnloadAsync(System.Boolean  @unloadAllLoadedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unloadAllLoadedObjects};
            var ___result = RUnloadAsync_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleUnloadOperation)___result;
        }


        public virtual System.String[] GetAllAssetNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllAssetNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetAllScenePaths()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllScenePaths.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual UnityEngine.Object[] LoadAssetWithSubAssets_Internal(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetWithSubAssets_Internal_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RLoadAssetWithSubAssetsAsync_Internal_String_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRequest)___result;
        }


        public static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync(System.String  @inputPath, System.String  @outputPath, UnityEngine.BuildCompression  @method, System.UInt32  @expectedCRC, UnityEngine.ThreadPriority  @priority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputPath, @outputPath, @method, @expectedCRC, @priority};
            var ___result = RRecompressAssetBundleAsync_String_String_BuildCompression_UInt32_ThreadPriority.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRecompressOperation)___result;
        }


        public static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal(System.String  @inputPath, System.String  @outputPath, UnityEngine.BuildCompression  @method, System.UInt32  @expectedCRC, UnityEngine.ThreadPriority  @priority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputPath, @outputPath, @method, @expectedCRC, @priority};
            var ___result = RRecompressAssetBundleAsync_Internal_String_String_BuildCompression_UInt32_ThreadPriority.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleRecompressOperation)___result;
        }


        public static UnityEngine.AssetBundle CreateFromFile(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RCreateFromFile_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundleCreateRequest CreateFromMemory(System.Byte[]  @binary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary};
            var ___result = RCreateFromMemory_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundleCreateRequest)___result;
        }


        public static UnityEngine.AssetBundle CreateFromMemoryImmediate(System.Byte[]  @binary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binary};
            var ___result = RCreateFromMemoryImmediate_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AssetBundle)___result;
        }


        public static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal_Injected(System.String  @inputPath, System.String  @outputPath, ref UnityEngine.BuildCompression  @method, System.UInt32  @expectedCRC, UnityEngine.ThreadPriority  @priority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputPath, @outputPath, @method, @expectedCRC, @priority};
            var ___result = RRecompressAssetBundleAsync_Internal_Injected_String_String_Ref_BuildCompression_UInt32_ThreadPriority.Invoke(___genericsType, ___parameters);
			method = (UnityEngine.BuildCompression)___parameters[2];

            return (UnityEngine.AssetBundleRecompressOperation)___result;
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
