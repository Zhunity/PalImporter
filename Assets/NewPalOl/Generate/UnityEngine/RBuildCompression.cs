using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BuildCompression
	/// </summary>
    public partial class RBuildCompression : RMember //
    {

		/// <summary>
		/// UnityEngine.BuildCompression Uncompressed
		/// </summary>
		protected static RUnityEngine.RBuildCompression r_Uncompressed;
		public static RUnityEngine.RBuildCompression RUncompressed
		{
			get
			{
				if(r_Uncompressed == null)
				{
					r_Uncompressed = new(typeof(UnityEngine.BuildCompression), "Uncompressed");
					r_Uncompressed.SetBelong(null);
				}
				return r_Uncompressed;
			}
		}

		/// <summary>
		/// UnityEngine.BuildCompression LZ4
		/// </summary>
		protected static RUnityEngine.RBuildCompression r_LZ4;
		public static RUnityEngine.RBuildCompression RLZ4
		{
			get
			{
				if(r_LZ4 == null)
				{
					r_LZ4 = new(typeof(UnityEngine.BuildCompression), "LZ4");
					r_LZ4.SetBelong(null);
				}
				return r_LZ4;
			}
		}

		/// <summary>
		/// UnityEngine.BuildCompression LZMA
		/// </summary>
		protected static RUnityEngine.RBuildCompression r_LZMA;
		public static RUnityEngine.RBuildCompression RLZMA
		{
			get
			{
				if(r_LZMA == null)
				{
					r_LZMA = new(typeof(UnityEngine.BuildCompression), "LZMA");
					r_LZMA.SetBelong(null);
				}
				return r_LZMA;
			}
		}

		/// <summary>
		/// UnityEngine.BuildCompression UncompressedRuntime
		/// </summary>
		protected static RUnityEngine.RBuildCompression r_UncompressedRuntime;
		public static RUnityEngine.RBuildCompression RUncompressedRuntime
		{
			get
			{
				if(r_UncompressedRuntime == null)
				{
					r_UncompressedRuntime = new(typeof(UnityEngine.BuildCompression), "UncompressedRuntime");
					r_UncompressedRuntime.SetBelong(null);
				}
				return r_UncompressedRuntime;
			}
		}

		/// <summary>
		/// UnityEngine.BuildCompression LZ4Runtime
		/// </summary>
		protected static RUnityEngine.RBuildCompression r_LZ4Runtime;
		public static RUnityEngine.RBuildCompression RLZ4Runtime
		{
			get
			{
				if(r_LZ4Runtime == null)
				{
					r_LZ4Runtime = new(typeof(UnityEngine.BuildCompression), "LZ4Runtime");
					r_LZ4Runtime.SetBelong(null);
				}
				return r_LZ4Runtime;
			}
		}

		/// <summary>
		/// UnityEngine.CompressionType _compression
		/// </summary>
		protected RField r__compression;
		public virtual RField R_compression
		{
			get
			{
				if(r__compression == null)
				{
					r__compression = new(this, "_compression");
					r__compression.SetBelong(this.instance);
				}
				return r__compression;
			}
		}

		/// <summary>
		/// UnityEngine.CompressionLevel _level
		/// </summary>
		protected RField r__level;
		public virtual RField R_level
		{
			get
			{
				if(r__level == null)
				{
					r__level = new(this, "_level");
					r__level.SetBelong(this.instance);
				}
				return r__level;
			}
		}

		/// <summary>
		/// System.UInt32 _blockSize
		/// </summary>
		protected RField r__blockSize;
		public virtual RField R_blockSize
		{
			get
			{
				if(r__blockSize == null)
				{
					r__blockSize = new(this, "_blockSize");
					r__blockSize.SetBelong(this.instance);
				}
				return r__blockSize;
			}
		}

		/// <summary>
		/// System.Boolean _enableProtect
		/// </summary>
		protected RField r__enableProtect;
		public virtual RField R_enableProtect
		{
			get
			{
				if(r__enableProtect == null)
				{
					r__enableProtect = new(this, "_enableProtect");
					r__enableProtect.SetBelong(this.instance);
				}
				return r__enableProtect;
			}
		}

		/// <summary>
		/// UnityEngine.CompressionType compression
		/// </summary>
		protected RProperty r_compression;
		public virtual RProperty Rcompression
		{
			get
			{
				if(r_compression == null)
				{
					r_compression = new(this, "compression", -1);
					r_compression.SetBelong(this.instance);
				}
				return r_compression;
			}
		}

		/// <summary>
		/// UnityEngine.CompressionLevel level
		/// </summary>
		protected RProperty r_level;
		public virtual RProperty Rlevel
		{
			get
			{
				if(r_level == null)
				{
					r_level = new(this, "level", -1);
					r_level.SetBelong(this.instance);
				}
				return r_level;
			}
		}

		/// <summary>
		/// UInt32 blockSize
		/// </summary>
		protected RProperty r_blockSize;
		public virtual RProperty RblockSize
		{
			get
			{
				if(r_blockSize == null)
				{
					r_blockSize = new(this, "blockSize", -1);
					r_blockSize.SetBelong(this.instance);
				}
				return r_blockSize;
			}
		}

		/// <summary>
		/// Boolean enableProtect
		/// </summary>
		protected RProperty r_enableProtect;
		public virtual RProperty RenableProtect
		{
			get
			{
				if(r_enableProtect == null)
				{
					r_enableProtect = new(this, "enableProtect", -1);
					r_enableProtect.SetBelong(this.instance);
				}
				return r_enableProtect;
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


        public RBuildCompression() : base("UnityEngine.BuildCompression")
        {
        }

        public RBuildCompression(System.Object instance) : base("UnityEngine.BuildCompression")
		{
            SetInstance(instance);
		}

        public RBuildCompression(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBuildCompression(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
