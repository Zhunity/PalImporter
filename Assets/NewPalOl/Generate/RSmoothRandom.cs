using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SmoothRandom
	/// </summary>
    public partial class RSmoothRandom : RMember //
    {

		/// <summary>
		/// FractalNoise #a
		/// </summary>
		protected static RFractalNoise r___0__a;
		public static RFractalNoise R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(SmoothRandom), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetVector3(Single)
		/// </summary>
		protected static RMethod r_RGetVector3_Single;
		public static RMethod RGetVector3_Single
		{
			get
			{
				if(r_RGetVector3_Single == null)
				{
					r_RGetVector3_Single = new(typeof(SmoothRandom), "GetVector3", 0, typeof(System.Single));
					r_RGetVector3_Single.SetBelong(null);
				}
				return r_RGetVector3_Single;
			}
		}

		/// <summary>
		/// Single Get(Single)
		/// </summary>
		protected static RMethod r_RGet_Single;
		public static RMethod RGet_Single
		{
			get
			{
				if(r_RGet_Single == null)
				{
					r_RGet_Single = new(typeof(SmoothRandom), "Get", 0, typeof(System.Single));
					r_RGet_Single.SetBelong(null);
				}
				return r_RGet_Single;
			}
		}

		/// <summary>
		/// FractalNoise Get()
		/// </summary>
		protected static RMethod r_RGet;
		public static RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new(typeof(SmoothRandom), "Get", 0);
					r_RGet.SetBelong(null);
				}
				return r_RGet;
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


        public RSmoothRandom() : base("SmoothRandom")
        {
        }

        public RSmoothRandom(System.Object instance) : base("SmoothRandom")
		{
            SetInstance(instance);
		}

        public RSmoothRandom(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSmoothRandom(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Vector3 GetVector3(System.Single  @speed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@speed};
            var ___result = RGetVector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Single Get(System.Single  @speed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@speed};
            var ___result = RGet_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static FractalNoise Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (FractalNoise)___result;
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
