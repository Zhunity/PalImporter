using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Random
	/// </summary>
    public partial class RRandom : RMember //
    {

		/// <summary>
		/// System.Int32 MBIG
		/// </summary>
		protected static RField r_MBIG;
		public static RField RMBIG
		{
			get
			{
				if(r_MBIG == null)
				{
					r_MBIG = new(typeof(System.Random), "MBIG");
					r_MBIG.SetBelong(null);
				}
				return r_MBIG;
			}
		}

		/// <summary>
		/// System.Int32 MSEED
		/// </summary>
		protected static RField r_MSEED;
		public static RField RMSEED
		{
			get
			{
				if(r_MSEED == null)
				{
					r_MSEED = new(typeof(System.Random), "MSEED");
					r_MSEED.SetBelong(null);
				}
				return r_MSEED;
			}
		}

		/// <summary>
		/// System.Int32 MZ
		/// </summary>
		protected static RField r_MZ;
		public static RField RMZ
		{
			get
			{
				if(r_MZ == null)
				{
					r_MZ = new(typeof(System.Random), "MZ");
					r_MZ.SetBelong(null);
				}
				return r_MZ;
			}
		}

		/// <summary>
		/// System.Int32 _inext
		/// </summary>
		protected RField r__inext;
		public virtual RField R_inext
		{
			get
			{
				if(r__inext == null)
				{
					r__inext = new(this, "_inext");
					r__inext.SetBelong(this.instance);
				}
				return r__inext;
			}
		}

		/// <summary>
		/// System.Int32 _inextp
		/// </summary>
		protected RField r__inextp;
		public virtual RField R_inextp
		{
			get
			{
				if(r__inextp == null)
				{
					r__inextp = new(this, "_inextp");
					r__inextp.SetBelong(this.instance);
				}
				return r__inextp;
			}
		}

		/// <summary>
		/// System.Int32[] _seedArray
		/// </summary>
		protected RFieldArray<RField> r__seedArray;
		public virtual RFieldArray<RField> R_seedArray
		{
			get
			{
				if(r__seedArray == null)
				{
					r__seedArray = new(this, "_seedArray");
					r__seedArray.SetBelong(this.instance);
				}
				return r__seedArray;
			}
		}

		/// <summary>
		/// System.Random t_threadRandom
		/// </summary>
		protected static RSystem.RRandom r_t_threadRandom;
		public static RSystem.RRandom Rt_threadRandom
		{
			get
			{
				if(r_t_threadRandom == null)
				{
					r_t_threadRandom = new(typeof(System.Random), "t_threadRandom");
					r_t_threadRandom.SetBelong(null);
				}
				return r_t_threadRandom;
			}
		}

		/// <summary>
		/// System.Random s_globalRandom
		/// </summary>
		protected static RSystem.RRandom r_s_globalRandom;
		public static RSystem.RRandom Rs_globalRandom
		{
			get
			{
				if(r_s_globalRandom == null)
				{
					r_s_globalRandom = new(typeof(System.Random), "s_globalRandom");
					r_s_globalRandom.SetBelong(null);
				}
				return r_s_globalRandom;
			}
		}

		/// <summary>
		/// Double Sample()
		/// </summary>
		protected RMethod r_RSample;
		public virtual RMethod RSample
		{
			get
			{
				if(r_RSample == null)
				{
					r_RSample = new(this, "Sample", 0);
					r_RSample.SetBelong(this.instance);
				}
				return r_RSample;
			}
		}

		/// <summary>
		/// Int32 InternalSample()
		/// </summary>
		protected RMethod r_RInternalSample;
		public virtual RMethod RInternalSample
		{
			get
			{
				if(r_RInternalSample == null)
				{
					r_RInternalSample = new(this, "InternalSample", 0);
					r_RInternalSample.SetBelong(this.instance);
				}
				return r_RInternalSample;
			}
		}

		/// <summary>
		/// Int32 GenerateSeed()
		/// </summary>
		protected static RMethod r_RGenerateSeed;
		public static RMethod RGenerateSeed
		{
			get
			{
				if(r_RGenerateSeed == null)
				{
					r_RGenerateSeed = new(typeof(System.Random), "GenerateSeed", 0);
					r_RGenerateSeed.SetBelong(null);
				}
				return r_RGenerateSeed;
			}
		}

		/// <summary>
		/// Int32 GenerateGlobalSeed()
		/// </summary>
		protected static RMethod r_RGenerateGlobalSeed;
		public static RMethod RGenerateGlobalSeed
		{
			get
			{
				if(r_RGenerateGlobalSeed == null)
				{
					r_RGenerateGlobalSeed = new(typeof(System.Random), "GenerateGlobalSeed", 0);
					r_RGenerateGlobalSeed.SetBelong(null);
				}
				return r_RGenerateGlobalSeed;
			}
		}

		/// <summary>
		/// Int32 Next()
		/// </summary>
		protected RMethod r_RNext;
		public virtual RMethod RNext
		{
			get
			{
				if(r_RNext == null)
				{
					r_RNext = new(this, "Next", 0);
					r_RNext.SetBelong(this.instance);
				}
				return r_RNext;
			}
		}

		/// <summary>
		/// Double GetSampleForLargeRange()
		/// </summary>
		protected RMethod r_RGetSampleForLargeRange;
		public virtual RMethod RGetSampleForLargeRange
		{
			get
			{
				if(r_RGetSampleForLargeRange == null)
				{
					r_RGetSampleForLargeRange = new(this, "GetSampleForLargeRange", 0);
					r_RGetSampleForLargeRange.SetBelong(this.instance);
				}
				return r_RGetSampleForLargeRange;
			}
		}

		/// <summary>
		/// Int32 Next(Int32, Int32)
		/// </summary>
		protected RMethod r_RNext_Int32_Int32;
		public virtual RMethod RNext_Int32_Int32
		{
			get
			{
				if(r_RNext_Int32_Int32 == null)
				{
					r_RNext_Int32_Int32 = new(this, "Next", 0, typeof(System.Int32), typeof(System.Int32));
					r_RNext_Int32_Int32.SetBelong(this.instance);
				}
				return r_RNext_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Next(Int32)
		/// </summary>
		protected RMethod r_RNext_Int32;
		public virtual RMethod RNext_Int32
		{
			get
			{
				if(r_RNext_Int32 == null)
				{
					r_RNext_Int32 = new(this, "Next", 0, typeof(System.Int32));
					r_RNext_Int32.SetBelong(this.instance);
				}
				return r_RNext_Int32;
			}
		}

		/// <summary>
		/// Double NextDouble()
		/// </summary>
		protected RMethod r_RNextDouble;
		public virtual RMethod RNextDouble
		{
			get
			{
				if(r_RNextDouble == null)
				{
					r_RNextDouble = new(this, "NextDouble", 0);
					r_RNextDouble.SetBelong(this.instance);
				}
				return r_RNextDouble;
			}
		}

		/// <summary>
		/// Void NextBytes(Byte[])
		/// </summary>
		protected RMethod r_RNextBytes_ByteArray;
		public virtual RMethod RNextBytes_ByteArray
		{
			get
			{
				if(r_RNextBytes_ByteArray == null)
				{
					r_RNextBytes_ByteArray = new(this, "NextBytes", 0, typeof(System.Byte).MakeArrayType());
					r_RNextBytes_ByteArray.SetBelong(this.instance);
				}
				return r_RNextBytes_ByteArray;
			}
		}

		/// <summary>
		/// Void NextBytes(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RNextBytes_Span_d_Byte_p_;
		public virtual RMethod RNextBytes_Span_d_Byte_p_
		{
			get
			{
				if(r_RNextBytes_Span_d_Byte_p_ == null)
				{
					r_RNextBytes_Span_d_Byte_p_ = new(this, "NextBytes", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RNextBytes_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RNextBytes_Span_d_Byte_p_;
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


        public RRandom() : base("System.Random")
        {
        }

        public RRandom(System.Object instance) : base("System.Random")
		{
            SetInstance(instance);
		}

        public RRandom(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRandom(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Double Sample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSample.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int32 InternalSample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalSample.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GenerateSeed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateSeed.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GenerateGlobalSeed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateGlobalSeed.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Next()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNext.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Double GetSampleForLargeRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSampleForLargeRange.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int32 Next(System.Int32  @minValue, System.Int32  @maxValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minValue, @maxValue};
            var ___result = RNext_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Next(System.Int32  @maxValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxValue};
            var ___result = RNext_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Double NextDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNextDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual void NextBytes(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RNextBytes_ByteArray.Invoke(___genericsType, ___parameters);

            
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
