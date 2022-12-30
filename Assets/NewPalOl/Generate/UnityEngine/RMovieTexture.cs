using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.MovieTexture
	/// </summary>
    public partial class RMovieTexture : RMember //
    {

		/// <summary>
		/// UnityEngine.AudioClip audioClip
		/// </summary>
		protected RUnityEngine.RAudioClip r_audioClip;
		public virtual RUnityEngine.RAudioClip RaudioClip
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
		/// Boolean loop
		/// </summary>
		protected RProperty r_loop;
		public virtual RProperty Rloop
		{
			get
			{
				if(r_loop == null)
				{
					r_loop = new(this, "loop", -1);
					r_loop.SetBelong(this.instance);
				}
				return r_loop;
			}
		}

		/// <summary>
		/// Boolean isPlaying
		/// </summary>
		protected RProperty r_isPlaying;
		public virtual RProperty RisPlaying
		{
			get
			{
				if(r_isPlaying == null)
				{
					r_isPlaying = new(this, "isPlaying", -1);
					r_isPlaying.SetBelong(this.instance);
				}
				return r_isPlaying;
			}
		}

		/// <summary>
		/// Boolean isReadyToPlay
		/// </summary>
		protected RProperty r_isReadyToPlay;
		public virtual RProperty RisReadyToPlay
		{
			get
			{
				if(r_isReadyToPlay == null)
				{
					r_isReadyToPlay = new(this, "isReadyToPlay", -1);
					r_isReadyToPlay.SetBelong(this.instance);
				}
				return r_isReadyToPlay;
			}
		}

		/// <summary>
		/// Single duration
		/// </summary>
		protected RProperty r_duration;
		public virtual RProperty Rduration
		{
			get
			{
				if(r_duration == null)
				{
					r_duration = new(this, "duration", -1);
					r_duration.SetBelong(this.instance);
				}
				return r_duration;
			}
		}

		/// <summary>
		/// Int32 mipmapCount
		/// </summary>
		protected RProperty r_mipmapCount;
		public virtual RProperty RmipmapCount
		{
			get
			{
				if(r_mipmapCount == null)
				{
					r_mipmapCount = new(this, "mipmapCount", -1);
					r_mipmapCount.SetBelong(this.instance);
				}
				return r_mipmapCount;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		/// </summary>
		protected RProperty r_graphicsFormat;
		public virtual RProperty RgraphicsFormat
		{
			get
			{
				if(r_graphicsFormat == null)
				{
					r_graphicsFormat = new(this, "graphicsFormat", -1);
					r_graphicsFormat.SetBelong(this.instance);
				}
				return r_graphicsFormat;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension dimension
		/// </summary>
		protected RProperty r_dimension;
		public virtual RProperty Rdimension
		{
			get
			{
				if(r_dimension == null)
				{
					r_dimension = new(this, "dimension", -1);
					r_dimension.SetBelong(this.instance);
				}
				return r_dimension;
			}
		}

		/// <summary>
		/// Boolean isReadable
		/// </summary>
		protected RProperty r_isReadable;
		public virtual RProperty RisReadable
		{
			get
			{
				if(r_isReadable == null)
				{
					r_isReadable = new(this, "isReadable", -1);
					r_isReadable.SetBelong(this.instance);
				}
				return r_isReadable;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapMode
		/// </summary>
		protected RProperty r_wrapMode;
		public virtual RProperty RwrapMode
		{
			get
			{
				if(r_wrapMode == null)
				{
					r_wrapMode = new(this, "wrapMode", -1);
					r_wrapMode.SetBelong(this.instance);
				}
				return r_wrapMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeU
		/// </summary>
		protected RProperty r_wrapModeU;
		public virtual RProperty RwrapModeU
		{
			get
			{
				if(r_wrapModeU == null)
				{
					r_wrapModeU = new(this, "wrapModeU", -1);
					r_wrapModeU.SetBelong(this.instance);
				}
				return r_wrapModeU;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeV
		/// </summary>
		protected RProperty r_wrapModeV;
		public virtual RProperty RwrapModeV
		{
			get
			{
				if(r_wrapModeV == null)
				{
					r_wrapModeV = new(this, "wrapModeV", -1);
					r_wrapModeV.SetBelong(this.instance);
				}
				return r_wrapModeV;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeW
		/// </summary>
		protected RProperty r_wrapModeW;
		public virtual RProperty RwrapModeW
		{
			get
			{
				if(r_wrapModeW == null)
				{
					r_wrapModeW = new(this, "wrapModeW", -1);
					r_wrapModeW.SetBelong(this.instance);
				}
				return r_wrapModeW;
			}
		}

		/// <summary>
		/// UnityEngine.FilterMode filterMode
		/// </summary>
		protected RProperty r_filterMode;
		public virtual RProperty RfilterMode
		{
			get
			{
				if(r_filterMode == null)
				{
					r_filterMode = new(this, "filterMode", -1);
					r_filterMode.SetBelong(this.instance);
				}
				return r_filterMode;
			}
		}

		/// <summary>
		/// Int32 anisoLevel
		/// </summary>
		protected RProperty r_anisoLevel;
		public virtual RProperty RanisoLevel
		{
			get
			{
				if(r_anisoLevel == null)
				{
					r_anisoLevel = new(this, "anisoLevel", -1);
					r_anisoLevel.SetBelong(this.instance);
				}
				return r_anisoLevel;
			}
		}

		/// <summary>
		/// Single mipMapBias
		/// </summary>
		protected RProperty r_mipMapBias;
		public virtual RProperty RmipMapBias
		{
			get
			{
				if(r_mipMapBias == null)
				{
					r_mipMapBias = new(this, "mipMapBias", -1);
					r_mipMapBias.SetBelong(this.instance);
				}
				return r_mipMapBias;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 texelSize
		/// </summary>
		protected RUnityEngine.RVector2 r_texelSize;
		public virtual RUnityEngine.RVector2 RtexelSize
		{
			get
			{
				if(r_texelSize == null)
				{
					r_texelSize = new(this, "texelSize", -1);
					r_texelSize.SetBelong(this.instance);
				}
				return r_texelSize;
			}
		}

		/// <summary>
		/// UInt32 updateCount
		/// </summary>
		protected RProperty r_updateCount;
		public virtual RProperty RupdateCount
		{
			get
			{
				if(r_updateCount == null)
				{
					r_updateCount = new(this, "updateCount", -1);
					r_updateCount.SetBelong(this.instance);
				}
				return r_updateCount;
			}
		}

		/// <summary>
		/// UnityEngine.ColorSpace activeTextureColorSpace
		/// </summary>
		protected RProperty r_activeTextureColorSpace;
		public virtual RProperty RactiveTextureColorSpace
		{
			get
			{
				if(r_activeTextureColorSpace == null)
				{
					r_activeTextureColorSpace = new(this, "activeTextureColorSpace", -1);
					r_activeTextureColorSpace.SetBelong(this.instance);
				}
				return r_activeTextureColorSpace;
			}
		}

		/// <summary>
		/// Boolean isDataSRGB
		/// </summary>
		protected RProperty r_isDataSRGB;
		public virtual RProperty RisDataSRGB
		{
			get
			{
				if(r_isDataSRGB == null)
				{
					r_isDataSRGB = new(this, "isDataSRGB", -1);
					r_isDataSRGB.SetBelong(this.instance);
				}
				return r_isDataSRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 imageContentsHash
		/// </summary>
		protected RUnityEngine.RHash128 r_imageContentsHash;
		public virtual RUnityEngine.RHash128 RimageContentsHash
		{
			get
			{
				if(r_imageContentsHash == null)
				{
					r_imageContentsHash = new(this, "imageContentsHash", -1);
					r_imageContentsHash.SetBelong(this.instance);
				}
				return r_imageContentsHash;
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
		/// Void FeatureRemoved()
		/// </summary>
		protected static RMethod r_RFeatureRemoved;
		public static RMethod RFeatureRemoved
		{
			get
			{
				if(r_RFeatureRemoved == null)
				{
					r_RFeatureRemoved = new(typeof(UnityEngine.MovieTexture), "FeatureRemoved", 0);
					r_RFeatureRemoved.SetBelong(null);
				}
				return r_RFeatureRemoved;
			}
		}

		/// <summary>
		/// Void Play()
		/// </summary>
		protected RMethod r_RPlay;
		public virtual RMethod RPlay
		{
			get
			{
				if(r_RPlay == null)
				{
					r_RPlay = new(this, "Play", 0);
					r_RPlay.SetBelong(this.instance);
				}
				return r_RPlay;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_RStop;
		public virtual RMethod RStop
		{
			get
			{
				if(r_RStop == null)
				{
					r_RStop = new(this, "Stop", 0);
					r_RStop.SetBelong(this.instance);
				}
				return r_RStop;
			}
		}

		/// <summary>
		/// Void Pause()
		/// </summary>
		protected RMethod r_RPause;
		public virtual RMethod RPause
		{
			get
			{
				if(r_RPause == null)
				{
					r_RPause = new(this, "Pause", 0);
					r_RPause.SetBelong(this.instance);
				}
				return r_RPause;
			}
		}

		/// <summary>
		/// IntPtr GetNativeTexturePtr()
		/// </summary>
		protected RMethod r_RGetNativeTexturePtr;
		public virtual RMethod RGetNativeTexturePtr
		{
			get
			{
				if(r_RGetNativeTexturePtr == null)
				{
					r_RGetNativeTexturePtr = new(this, "GetNativeTexturePtr", 0);
					r_RGetNativeTexturePtr.SetBelong(this.instance);
				}
				return r_RGetNativeTexturePtr;
			}
		}

		/// <summary>
		/// Int32 GetNativeTextureID()
		/// </summary>
		protected RMethod r_RGetNativeTextureID;
		public virtual RMethod RGetNativeTextureID
		{
			get
			{
				if(r_RGetNativeTextureID == null)
				{
					r_RGetNativeTextureID = new(this, "GetNativeTextureID", 0);
					r_RGetNativeTextureID.SetBelong(this.instance);
				}
				return r_RGetNativeTextureID;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount()
		/// </summary>
		protected RMethod r_RIncrementUpdateCount;
		public virtual RMethod RIncrementUpdateCount
		{
			get
			{
				if(r_RIncrementUpdateCount == null)
				{
					r_RIncrementUpdateCount = new(this, "IncrementUpdateCount", 0);
					r_RIncrementUpdateCount.SetBelong(this.instance);
				}
				return r_RIncrementUpdateCount;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataSize(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixelDataSize_Int32_Int32;
		public virtual RMethod RGetPixelDataSize_Int32_Int32
		{
			get
			{
				if(r_RGetPixelDataSize_Int32_Int32 == null)
				{
					r_RGetPixelDataSize_Int32_Int32 = new(this, "GetPixelDataSize", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetPixelDataSize_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelDataSize_Int32_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataOffset(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixelDataOffset_Int32_Int32;
		public virtual RMethod RGetPixelDataOffset_Int32_Int32
		{
			get
			{
				if(r_RGetPixelDataOffset_Int32_Int32 == null)
				{
					r_RGetPixelDataOffset_Int32_Int32 = new(this, "GetPixelDataOffset", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetPixelDataOffset_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelDataOffset_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_RValidateFormat_RenderTextureFormat;
		public virtual RMethod RValidateFormat_RenderTextureFormat
		{
			get
			{
				if(r_RValidateFormat_RenderTextureFormat == null)
				{
					r_RValidateFormat_RenderTextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.RenderTextureFormat));
					r_RValidateFormat_RenderTextureFormat.SetBelong(this.instance);
				}
				return r_RValidateFormat_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat)
		/// </summary>
		protected RMethod r_RValidateFormat_TextureFormat;
		public virtual RMethod RValidateFormat_TextureFormat
		{
			get
			{
				if(r_RValidateFormat_TextureFormat == null)
				{
					r_RValidateFormat_TextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat));
					r_RValidateFormat_TextureFormat.SetBelong(this.instance);
				}
				return r_RValidateFormat_TextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.FormatUsage)
		/// </summary>
		protected RMethod r_RValidateFormat_GraphicsFormat_FormatUsage;
		public virtual RMethod RValidateFormat_GraphicsFormat_FormatUsage
		{
			get
			{
				if(r_RValidateFormat_GraphicsFormat_FormatUsage == null)
				{
					r_RValidateFormat_GraphicsFormat_FormatUsage = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage));
					r_RValidateFormat_GraphicsFormat_FormatUsage.SetBelong(this.instance);
				}
				return r_RValidateFormat_GraphicsFormat_FormatUsage;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RCreateNonReadableException_Texture;
		public virtual RMethod RCreateNonReadableException_Texture
		{
			get
			{
				if(r_RCreateNonReadableException_Texture == null)
				{
					r_RCreateNonReadableException_Texture = new(this, "CreateNonReadableException", 0, typeof(UnityEngine.Texture));
					r_RCreateNonReadableException_Texture.SetBelong(this.instance);
				}
				return r_RCreateNonReadableException_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
		/// </summary>
		protected RMethod r_RCreateNativeArrayLengthOverflowException;
		public virtual RMethod RCreateNativeArrayLengthOverflowException
		{
			get
			{
				if(r_RCreateNativeArrayLengthOverflowException == null)
				{
					r_RCreateNativeArrayLengthOverflowException = new(this, "CreateNativeArrayLengthOverflowException", 0);
					r_RCreateNativeArrayLengthOverflowException.SetBelong(this.instance);
				}
				return r_RCreateNativeArrayLengthOverflowException;
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


        public RMovieTexture() : base("UnityEngine.MovieTexture")
        {
        }

        public RMovieTexture(System.Object instance) : base("UnityEngine.MovieTexture")
		{
            SetInstance(instance);
		}

        public RMovieTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMovieTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void FeatureRemoved()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFeatureRemoved.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Play()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetNativeTexturePtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeTexturePtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Int32 GetNativeTextureID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeTextureID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void IncrementUpdateCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIncrementUpdateCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetPixelDataSize(System.Int32  @mipLevel, System.Int32  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RGetPixelDataSize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.UInt64 GetPixelDataOffset(System.Int32  @mipLevel, System.Int32  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RGetPixelDataOffset_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RValidateFormat_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RValidateFormat_TextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.FormatUsage  @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @usage};
            var ___result = RValidateFormat_GraphicsFormat_FormatUsage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RCreateNonReadableException_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
        }


        public virtual UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNativeArrayLengthOverflowException.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
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
