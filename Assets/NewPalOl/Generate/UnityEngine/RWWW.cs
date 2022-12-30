using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.WWW
	/// </summary>
    public partial class RWWW : RMember //
    {

		/// <summary>
		/// UnityEngine.ThreadPriority <threadPriority>k__BackingField
		/// </summary>
		protected RField r___2__threadPriority__4__k__BackingField;
		public virtual RField R__2__threadPriority__4__k__BackingField
		{
			get
			{
				if(r___2__threadPriority__4__k__BackingField == null)
				{
					r___2__threadPriority__4__k__BackingField = new(this, "<threadPriority>k__BackingField");
					r___2__threadPriority__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__threadPriority__4__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest _uwr
		/// </summary>
		protected RUnityEngine.RNetworking.RUnityWebRequest r__uwr;
		public virtual RUnityEngine.RNetworking.RUnityWebRequest R_uwr
		{
			get
			{
				if(r__uwr == null)
				{
					r__uwr = new(this, "_uwr");
					r__uwr.SetBelong(this.instance);
				}
				return r__uwr;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle _assetBundle
		/// </summary>
		protected RUnityEngine.RAssetBundle r__assetBundle;
		public virtual RUnityEngine.RAssetBundle R_assetBundle
		{
			get
			{
				if(r__assetBundle == null)
				{
					r__assetBundle = new(this, "_assetBundle");
					r__assetBundle.SetBelong(this.instance);
				}
				return r__assetBundle;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] _responseHeaders
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r__responseHeaders;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R_responseHeaders
		{
			get
			{
				if(r__responseHeaders == null)
				{
					r__responseHeaders = new(this, "_responseHeaders");
					r__responseHeaders.SetBelong(this.instance);
				}
				return r__responseHeaders;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle assetBundle
		/// </summary>
		protected RUnityEngine.RAssetBundle r_assetBundle;
		public virtual RUnityEngine.RAssetBundle RassetBundle
		{
			get
			{
				if(r_assetBundle == null)
				{
					r_assetBundle = new(this, "assetBundle", -1);
					r_assetBundle.SetBelong(this.instance);
				}
				return r_assetBundle;
			}
		}

		/// <summary>
		/// UnityEngine.Object audioClip
		/// </summary>
		protected RUnityEngine.RObject r_audioClip;
		public virtual RUnityEngine.RObject RaudioClip
		{
			get
			{
				if(r_audioClip == null)
				{
					r_audioClip = new(this, "audioClip", -1);
					r_audioClip.SetBelong(this.instance);
				}
				return r_audioClip;
			}
		}

		/// <summary>
		/// Byte[] bytes
		/// </summary>
		protected RPropertyArray<RProperty> r_bytes;
		public virtual RPropertyArray<RProperty> Rbytes
		{
			get
			{
				if(r_bytes == null)
				{
					r_bytes = new(this, "bytes", -1);
					r_bytes.SetBelong(this.instance);
				}
				return r_bytes;
			}
		}

		/// <summary>
		/// UnityEngine.Object movie
		/// </summary>
		protected RUnityEngine.RObject r_movie;
		public virtual RUnityEngine.RObject Rmovie
		{
			get
			{
				if(r_movie == null)
				{
					r_movie = new(this, "movie", -1);
					r_movie.SetBelong(this.instance);
				}
				return r_movie;
			}
		}

		/// <summary>
		/// Int32 size
		/// </summary>
		protected RProperty r_size;
		public virtual RProperty Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// Int32 bytesDownloaded
		/// </summary>
		protected RProperty r_bytesDownloaded;
		public virtual RProperty RbytesDownloaded
		{
			get
			{
				if(r_bytesDownloaded == null)
				{
					r_bytesDownloaded = new(this, "bytesDownloaded", -1);
					r_bytesDownloaded.SetBelong(this.instance);
				}
				return r_bytesDownloaded;
			}
		}

		/// <summary>
		/// System.String error
		/// </summary>
		protected RProperty r_error;
		public virtual RProperty Rerror
		{
			get
			{
				if(r_error == null)
				{
					r_error = new(this, "error", -1);
					r_error.SetBelong(this.instance);
				}
				return r_error;
			}
		}

		/// <summary>
		/// Boolean isDone
		/// </summary>
		protected RProperty r_isDone;
		public virtual RProperty RisDone
		{
			get
			{
				if(r_isDone == null)
				{
					r_isDone = new(this, "isDone", -1);
					r_isDone.SetBelong(this.instance);
				}
				return r_isDone;
			}
		}

		/// <summary>
		/// UnityEngine.Object oggVorbis
		/// </summary>
		protected RUnityEngine.RObject r_oggVorbis;
		public virtual RUnityEngine.RObject RoggVorbis
		{
			get
			{
				if(r_oggVorbis == null)
				{
					r_oggVorbis = new(this, "oggVorbis", -1);
					r_oggVorbis.SetBelong(this.instance);
				}
				return r_oggVorbis;
			}
		}

		/// <summary>
		/// Single progress
		/// </summary>
		protected RProperty r_progress;
		public virtual RProperty Rprogress
		{
			get
			{
				if(r_progress == null)
				{
					r_progress = new(this, "progress", -1);
					r_progress.SetBelong(this.instance);
				}
				return r_progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] responseHeaders
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_responseHeaders;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> RresponseHeaders
		{
			get
			{
				if(r_responseHeaders == null)
				{
					r_responseHeaders = new(this, "responseHeaders", -1);
					r_responseHeaders.SetBelong(this.instance);
				}
				return r_responseHeaders;
			}
		}

		/// <summary>
		/// System.String data
		/// </summary>
		protected RProperty r_data;
		public virtual RProperty Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data", -1);
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D textureNonReadable
		/// </summary>
		protected RUnityEngine.RTexture2D r_textureNonReadable;
		public virtual RUnityEngine.RTexture2D RtextureNonReadable
		{
			get
			{
				if(r_textureNonReadable == null)
				{
					r_textureNonReadable = new(this, "textureNonReadable", -1);
					r_textureNonReadable.SetBelong(this.instance);
				}
				return r_textureNonReadable;
			}
		}

		/// <summary>
		/// UnityEngine.ThreadPriority threadPriority
		/// </summary>
		protected RProperty r_threadPriority;
		public virtual RProperty RthreadPriority
		{
			get
			{
				if(r_threadPriority == null)
				{
					r_threadPriority = new(this, "threadPriority", -1);
					r_threadPriority.SetBelong(this.instance);
				}
				return r_threadPriority;
			}
		}

		/// <summary>
		/// Single uploadProgress
		/// </summary>
		protected RProperty r_uploadProgress;
		public virtual RProperty RuploadProgress
		{
			get
			{
				if(r_uploadProgress == null)
				{
					r_uploadProgress = new(this, "uploadProgress", -1);
					r_uploadProgress.SetBelong(this.instance);
				}
				return r_uploadProgress;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RProperty r_url;
		public virtual RProperty Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url", -1);
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// Boolean keepWaiting
		/// </summary>
		protected RProperty r_keepWaiting;
		public virtual RProperty RkeepWaiting
		{
			get
			{
				if(r_keepWaiting == null)
				{
					r_keepWaiting = new(this, "keepWaiting", -1);
					r_keepWaiting.SetBelong(this.instance);
				}
				return r_keepWaiting;
			}
		}

		/// <summary>
		/// System.Object Current
		/// </summary>
		protected RSystem.RObject r_Current;
		public virtual RSystem.RObject RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(this, "Current", -1);
					r_Current.SetBelong(this.instance);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.String EscapeURL(System.String)
		/// </summary>
		protected static RMethod r_REscapeURL_String;
		public static RMethod REscapeURL_String
		{
			get
			{
				if(r_REscapeURL_String == null)
				{
					r_REscapeURL_String = new(typeof(UnityEngine.WWW), "EscapeURL", 0, typeof(System.String));
					r_REscapeURL_String.SetBelong(null);
				}
				return r_REscapeURL_String;
			}
		}

		/// <summary>
		/// System.String EscapeURL(System.String, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_REscapeURL_String_Encoding;
		public static RMethod REscapeURL_String_Encoding
		{
			get
			{
				if(r_REscapeURL_String_Encoding == null)
				{
					r_REscapeURL_String_Encoding = new(typeof(UnityEngine.WWW), "EscapeURL", 0, typeof(System.String), typeof(System.Text.Encoding));
					r_REscapeURL_String_Encoding.SetBelong(null);
				}
				return r_REscapeURL_String_Encoding;
			}
		}

		/// <summary>
		/// System.String UnEscapeURL(System.String)
		/// </summary>
		protected static RMethod r_RUnEscapeURL_String;
		public static RMethod RUnEscapeURL_String
		{
			get
			{
				if(r_RUnEscapeURL_String == null)
				{
					r_RUnEscapeURL_String = new(typeof(UnityEngine.WWW), "UnEscapeURL", 0, typeof(System.String));
					r_RUnEscapeURL_String.SetBelong(null);
				}
				return r_RUnEscapeURL_String;
			}
		}

		/// <summary>
		/// System.String UnEscapeURL(System.String, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_RUnEscapeURL_String_Encoding;
		public static RMethod RUnEscapeURL_String_Encoding
		{
			get
			{
				if(r_RUnEscapeURL_String_Encoding == null)
				{
					r_RUnEscapeURL_String_Encoding = new(typeof(UnityEngine.WWW), "UnEscapeURL", 0, typeof(System.String), typeof(System.Text.Encoding));
					r_RUnEscapeURL_String_Encoding.SetBelong(null);
				}
				return r_RUnEscapeURL_String_Encoding;
			}
		}

		/// <summary>
		/// UnityEngine.WWW LoadFromCacheOrDownload(System.String, Int32)
		/// </summary>
		protected static RMethod r_RLoadFromCacheOrDownload_String_Int32;
		public static RMethod RLoadFromCacheOrDownload_String_Int32
		{
			get
			{
				if(r_RLoadFromCacheOrDownload_String_Int32 == null)
				{
					r_RLoadFromCacheOrDownload_String_Int32 = new(typeof(UnityEngine.WWW), "LoadFromCacheOrDownload", 0, typeof(System.String), typeof(System.Int32));
					r_RLoadFromCacheOrDownload_String_Int32.SetBelong(null);
				}
				return r_RLoadFromCacheOrDownload_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.WWW LoadFromCacheOrDownload(System.String, Int32, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromCacheOrDownload_String_Int32_UInt32;
		public static RMethod RLoadFromCacheOrDownload_String_Int32_UInt32
		{
			get
			{
				if(r_RLoadFromCacheOrDownload_String_Int32_UInt32 == null)
				{
					r_RLoadFromCacheOrDownload_String_Int32_UInt32 = new(typeof(UnityEngine.WWW), "LoadFromCacheOrDownload", 0, typeof(System.String), typeof(System.Int32), typeof(System.UInt32));
					r_RLoadFromCacheOrDownload_String_Int32_UInt32.SetBelong(null);
				}
				return r_RLoadFromCacheOrDownload_String_Int32_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.WWW LoadFromCacheOrDownload(System.String, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_RLoadFromCacheOrDownload_String_Hash128;
		public static RMethod RLoadFromCacheOrDownload_String_Hash128
		{
			get
			{
				if(r_RLoadFromCacheOrDownload_String_Hash128 == null)
				{
					r_RLoadFromCacheOrDownload_String_Hash128 = new(typeof(UnityEngine.WWW), "LoadFromCacheOrDownload", 0, typeof(System.String), typeof(UnityEngine.Hash128));
					r_RLoadFromCacheOrDownload_String_Hash128.SetBelong(null);
				}
				return r_RLoadFromCacheOrDownload_String_Hash128;
			}
		}

		/// <summary>
		/// UnityEngine.WWW LoadFromCacheOrDownload(System.String, UnityEngine.Hash128, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromCacheOrDownload_String_Hash128_UInt32;
		public static RMethod RLoadFromCacheOrDownload_String_Hash128_UInt32
		{
			get
			{
				if(r_RLoadFromCacheOrDownload_String_Hash128_UInt32 == null)
				{
					r_RLoadFromCacheOrDownload_String_Hash128_UInt32 = new(typeof(UnityEngine.WWW), "LoadFromCacheOrDownload", 0, typeof(System.String), typeof(UnityEngine.Hash128), typeof(System.UInt32));
					r_RLoadFromCacheOrDownload_String_Hash128_UInt32.SetBelong(null);
				}
				return r_RLoadFromCacheOrDownload_String_Hash128_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.WWW LoadFromCacheOrDownload(System.String, UnityEngine.CachedAssetBundle, UInt32)
		/// </summary>
		protected static RMethod r_RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32;
		public static RMethod RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32
		{
			get
			{
				if(r_RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32 == null)
				{
					r_RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32 = new(typeof(UnityEngine.WWW), "LoadFromCacheOrDownload", 0, typeof(System.String), typeof(UnityEngine.CachedAssetBundle), typeof(System.UInt32));
					r_RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32.SetBelong(null);
				}
				return r_RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D CreateTextureFromDownloadedData(Boolean)
		/// </summary>
		protected RMethod r_RCreateTextureFromDownloadedData_Boolean;
		public virtual RMethod RCreateTextureFromDownloadedData_Boolean
		{
			get
			{
				if(r_RCreateTextureFromDownloadedData_Boolean == null)
				{
					r_RCreateTextureFromDownloadedData_Boolean = new(this, "CreateTextureFromDownloadedData", 0, typeof(System.Boolean));
					r_RCreateTextureFromDownloadedData_Boolean.SetBelong(this.instance);
				}
				return r_RCreateTextureFromDownloadedData_Boolean;
			}
		}

		/// <summary>
		/// Void LoadImageIntoTexture(UnityEngine.Texture2D)
		/// </summary>
		protected RMethod r_RLoadImageIntoTexture_Texture2D;
		public virtual RMethod RLoadImageIntoTexture_Texture2D
		{
			get
			{
				if(r_RLoadImageIntoTexture_Texture2D == null)
				{
					r_RLoadImageIntoTexture_Texture2D = new(this, "LoadImageIntoTexture", 0, typeof(UnityEngine.Texture2D));
					r_RLoadImageIntoTexture_Texture2D.SetBelong(this.instance);
				}
				return r_RLoadImageIntoTexture_Texture2D;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetAudioClipInternal(Boolean, Boolean, Boolean, UnityEngine.AudioType)
		/// </summary>
		protected RMethod r_RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType;
		public virtual RMethod RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType
		{
			get
			{
				if(r_RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType == null)
				{
					r_RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType = new(this, "GetAudioClipInternal", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.AudioType));
					r_RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType.SetBelong(this.instance);
				}
				return r_RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClip()
		/// </summary>
		protected RMethod r_RGetAudioClip;
		public virtual RMethod RGetAudioClip
		{
			get
			{
				if(r_RGetAudioClip == null)
				{
					r_RGetAudioClip = new(this, "GetAudioClip", 0);
					r_RGetAudioClip.SetBelong(this.instance);
				}
				return r_RGetAudioClip;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClip(Boolean)
		/// </summary>
		protected RMethod r_RGetAudioClip_Boolean;
		public virtual RMethod RGetAudioClip_Boolean
		{
			get
			{
				if(r_RGetAudioClip_Boolean == null)
				{
					r_RGetAudioClip_Boolean = new(this, "GetAudioClip", 0, typeof(System.Boolean));
					r_RGetAudioClip_Boolean.SetBelong(this.instance);
				}
				return r_RGetAudioClip_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClip(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetAudioClip_Boolean_Boolean;
		public virtual RMethod RGetAudioClip_Boolean_Boolean
		{
			get
			{
				if(r_RGetAudioClip_Boolean_Boolean == null)
				{
					r_RGetAudioClip_Boolean_Boolean = new(this, "GetAudioClip", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RGetAudioClip_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetAudioClip_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClip(Boolean, Boolean, UnityEngine.AudioType)
		/// </summary>
		protected RMethod r_RGetAudioClip_Boolean_Boolean_AudioType;
		public virtual RMethod RGetAudioClip_Boolean_Boolean_AudioType
		{
			get
			{
				if(r_RGetAudioClip_Boolean_Boolean_AudioType == null)
				{
					r_RGetAudioClip_Boolean_Boolean_AudioType = new(this, "GetAudioClip", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.AudioType));
					r_RGetAudioClip_Boolean_Boolean_AudioType.SetBelong(this.instance);
				}
				return r_RGetAudioClip_Boolean_Boolean_AudioType;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClipCompressed()
		/// </summary>
		protected RMethod r_RGetAudioClipCompressed;
		public virtual RMethod RGetAudioClipCompressed
		{
			get
			{
				if(r_RGetAudioClipCompressed == null)
				{
					r_RGetAudioClipCompressed = new(this, "GetAudioClipCompressed", 0);
					r_RGetAudioClipCompressed.SetBelong(this.instance);
				}
				return r_RGetAudioClipCompressed;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClipCompressed(Boolean)
		/// </summary>
		protected RMethod r_RGetAudioClipCompressed_Boolean;
		public virtual RMethod RGetAudioClipCompressed_Boolean
		{
			get
			{
				if(r_RGetAudioClipCompressed_Boolean == null)
				{
					r_RGetAudioClipCompressed_Boolean = new(this, "GetAudioClipCompressed", 0, typeof(System.Boolean));
					r_RGetAudioClipCompressed_Boolean.SetBelong(this.instance);
				}
				return r_RGetAudioClipCompressed_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip GetAudioClipCompressed(Boolean, UnityEngine.AudioType)
		/// </summary>
		protected RMethod r_RGetAudioClipCompressed_Boolean_AudioType;
		public virtual RMethod RGetAudioClipCompressed_Boolean_AudioType
		{
			get
			{
				if(r_RGetAudioClipCompressed_Boolean_AudioType == null)
				{
					r_RGetAudioClipCompressed_Boolean_AudioType = new(this, "GetAudioClipCompressed", 0, typeof(System.Boolean), typeof(UnityEngine.AudioType));
					r_RGetAudioClipCompressed_Boolean_AudioType.SetBelong(this.instance);
				}
				return r_RGetAudioClipCompressed_Boolean_AudioType;
			}
		}

		/// <summary>
		/// UnityEngine.MovieTexture GetMovieTexture()
		/// </summary>
		protected RMethod r_RGetMovieTexture;
		public virtual RMethod RGetMovieTexture
		{
			get
			{
				if(r_RGetMovieTexture == null)
				{
					r_RGetMovieTexture = new(this, "GetMovieTexture", 0);
					r_RGetMovieTexture.SetBelong(this.instance);
				}
				return r_RGetMovieTexture;
			}
		}

		/// <summary>
		/// Boolean WaitUntilDoneIfPossible()
		/// </summary>
		protected RMethod r_RWaitUntilDoneIfPossible;
		public virtual RMethod RWaitUntilDoneIfPossible
		{
			get
			{
				if(r_RWaitUntilDoneIfPossible == null)
				{
					r_RWaitUntilDoneIfPossible = new(this, "WaitUntilDoneIfPossible", 0);
					r_RWaitUntilDoneIfPossible.SetBelong(this.instance);
				}
				return r_RWaitUntilDoneIfPossible;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
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


        public RWWW() : base("UnityEngine.WWW")
        {
        }

        public RWWW(System.Object instance) : base("UnityEngine.WWW")
		{
            SetInstance(instance);
		}

        public RWWW(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWWW(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String EscapeURL(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = REscapeURL_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String EscapeURL(System.String  @s, System.Text.Encoding  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @e};
            var ___result = REscapeURL_String_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String UnEscapeURL(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RUnEscapeURL_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String UnEscapeURL(System.String  @s, System.Text.Encoding  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @e};
            var ___result = RUnEscapeURL_String_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.WWW LoadFromCacheOrDownload(System.String  @url, System.Int32  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @version};
            var ___result = RLoadFromCacheOrDownload_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.WWW)___result;
        }


        public static UnityEngine.WWW LoadFromCacheOrDownload(System.String  @url, System.Int32  @version, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @version, @crc};
            var ___result = RLoadFromCacheOrDownload_String_Int32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.WWW)___result;
        }


        public static UnityEngine.WWW LoadFromCacheOrDownload(System.String  @url, UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @hash};
            var ___result = RLoadFromCacheOrDownload_String_Hash128.Invoke(___genericsType, ___parameters);

            return (UnityEngine.WWW)___result;
        }


        public static UnityEngine.WWW LoadFromCacheOrDownload(System.String  @url, UnityEngine.Hash128  @hash, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @hash, @crc};
            var ___result = RLoadFromCacheOrDownload_String_Hash128_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.WWW)___result;
        }


        public static UnityEngine.WWW LoadFromCacheOrDownload(System.String  @url, UnityEngine.CachedAssetBundle  @cachedBundle, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @cachedBundle, @crc};
            var ___result = RLoadFromCacheOrDownload_String_CachedAssetBundle_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.WWW)___result;
        }


        public virtual UnityEngine.Texture2D CreateTextureFromDownloadedData(System.Boolean  @markNonReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markNonReadable};
            var ___result = RCreateTextureFromDownloadedData_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void LoadImageIntoTexture(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RLoadImageIntoTexture_Texture2D.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Object GetAudioClipInternal(System.Boolean  @threeD, System.Boolean  @stream, System.Boolean  @compressed, UnityEngine.AudioType  @audioType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD, @stream, @compressed, @audioType};
            var ___result = RGetAudioClipInternal_Boolean_Boolean_Boolean_AudioType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAudioClip.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClip(System.Boolean  @threeD)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD};
            var ___result = RGetAudioClip_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClip(System.Boolean  @threeD, System.Boolean  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD, @stream};
            var ___result = RGetAudioClip_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClip(System.Boolean  @threeD, System.Boolean  @stream, UnityEngine.AudioType  @audioType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD, @stream, @audioType};
            var ___result = RGetAudioClip_Boolean_Boolean_AudioType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClipCompressed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAudioClipCompressed.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClipCompressed(System.Boolean  @threeD)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD};
            var ___result = RGetAudioClipCompressed_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.AudioClip GetAudioClipCompressed(System.Boolean  @threeD, UnityEngine.AudioType  @audioType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threeD, @audioType};
            var ___result = RGetAudioClipCompressed_Boolean_AudioType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual UnityEngine.MovieTexture GetMovieTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMovieTexture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.MovieTexture)___result;
        }


        public virtual System.Boolean WaitUntilDoneIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitUntilDoneIfPossible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
