using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Mmn
	/// </summary>
    public partial class R__0__Mmn : RMember //
    {

		/// <summary>
		/// System.Single #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Mmn"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Single #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("#u.#Mmn"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// Single COMBAT_TIMESCALE
		/// </summary>
		protected static RProperty r_R__0__Hnn;
		public static RProperty R__0__Hnn
		{
			get
			{
				if(r_R__0__Hnn == null)
				{
					r_R__0__Hnn = new( ReleactionUtils.GetType("#u.#Mmn"), "COMBAT_TIMESCALE", -1);
					r_R__0__Hnn.SetBelong(null);
				}
				return r_R__0__Hnn;
			}
		}

		/// <summary>
		/// Void #Jmn()
		/// </summary>
		protected static RMethod r_R__0__Jmn;
		public static RMethod R__0__Jmn
		{
			get
			{
				if(r_R__0__Jmn == null)
				{
					r_R__0__Jmn = new( ReleactionUtils.GetType("#u.#Mmn"), "#Jmn", 0);
					r_R__0__Jmn.SetBelong(null);
				}
				return r_R__0__Jmn;
			}
		}

		/// <summary>
		/// Void #Kmn()
		/// </summary>
		protected static RMethod r_R__0__Kmn;
		public static RMethod R__0__Kmn
		{
			get
			{
				if(r_R__0__Kmn == null)
				{
					r_R__0__Kmn = new( ReleactionUtils.GetType("#u.#Mmn"), "#Kmn", 0);
					r_R__0__Kmn.SetBelong(null);
				}
				return r_R__0__Kmn;
			}
		}

		/// <summary>
		/// Void #Lmn(Single)
		/// </summary>
		protected static RMethod r_R__0__Lmn_Single;
		public static RMethod R__0__Lmn_Single
		{
			get
			{
				if(r_R__0__Lmn_Single == null)
				{
					r_R__0__Lmn_Single = new( ReleactionUtils.GetType("#u.#Mmn"), "#Lmn", 0, typeof(System.Single));
					r_R__0__Lmn_Single.SetBelong(null);
				}
				return r_R__0__Lmn_Single;
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


        public R__0__Mmn() : base("#u.#Mmn")
        {
        }

        public R__0__Mmn(System.Object instance) : base("#u.#Mmn")
		{
            SetInstance(instance);
		}

        public R__0__Mmn(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Mmn(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void __0__Jmn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Jmn.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__Kmn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Kmn.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__Lmn(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = R__0__Lmn_Single.Invoke(___genericsType, ___parameters);

            
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
