using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#0T
	/// </summary>
    public partial class R__0__0T : RMember //
    {

		/// <summary>
		/// Single #ST(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__ST_Quaternion;
		public static RMethod R__0__ST_Quaternion
		{
			get
			{
				if(r_R__0__ST_Quaternion == null)
				{
					r_R__0__ST_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#ST", 0, typeof(UnityEngine.Quaternion));
					r_R__0__ST_Quaternion.SetBelong(null);
				}
				return r_R__0__ST_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #TT(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__TT_Quaternion;
		public static RMethod R__0__TT_Quaternion
		{
			get
			{
				if(r_R__0__TT_Quaternion == null)
				{
					r_R__0__TT_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#TT", 0, typeof(UnityEngine.Quaternion));
					r_R__0__TT_Quaternion.SetBelong(null);
				}
				return r_R__0__TT_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #UT(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__UT_Quaternion;
		public static RMethod R__0__UT_Quaternion
		{
			get
			{
				if(r_R__0__UT_Quaternion == null)
				{
					r_R__0__UT_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#UT", 0, typeof(UnityEngine.Quaternion));
					r_R__0__UT_Quaternion.SetBelong(null);
				}
				return r_R__0__UT_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #VT(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__VT_Quaternion;
		public static RMethod R__0__VT_Quaternion
		{
			get
			{
				if(r_R__0__VT_Quaternion == null)
				{
					r_R__0__VT_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#VT", 0, typeof(UnityEngine.Quaternion));
					r_R__0__VT_Quaternion.SetBelong(null);
				}
				return r_R__0__VT_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #WT(Single, UnityEngine.Quaternion, UnityEngine.Quaternion, UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion;
		public static RMethod R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion
		{
			get
			{
				if(r_R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion == null)
				{
					r_R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#WT", 0, typeof(System.Single), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion.SetBelong(null);
				}
				return r_R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #XT(UnityEngine.Quaternion, UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_R__0__XT_Quaternion_Quaternion_Quaternion;
		public static RMethod R__0__XT_Quaternion_Quaternion_Quaternion
		{
			get
			{
				if(r_R__0__XT_Quaternion_Quaternion_Quaternion == null)
				{
					r_R__0__XT_Quaternion_Quaternion_Quaternion = new( ReleactionUtils.GetType("#u.#0T"), "#XT", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_R__0__XT_Quaternion_Quaternion_Quaternion.SetBelong(null);
				}
				return r_R__0__XT_Quaternion_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Single #YT(Single, Single, Single)
		/// </summary>
		protected static RMethod r_R__0__YT_Single_Single_Single;
		public static RMethod R__0__YT_Single_Single_Single
		{
			get
			{
				if(r_R__0__YT_Single_Single_Single == null)
				{
					r_R__0__YT_Single_Single_Single = new( ReleactionUtils.GetType("#u.#0T"), "#YT", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__YT_Single_Single_Single.SetBelong(null);
				}
				return r_R__0__YT_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #ZT(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_R__0__ZT_Quaternion_Quaternion_Single;
		public static RMethod R__0__ZT_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_R__0__ZT_Quaternion_Quaternion_Single == null)
				{
					r_R__0__ZT_Quaternion_Quaternion_Single = new( ReleactionUtils.GetType("#u.#0T"), "#ZT", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_R__0__ZT_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_R__0__ZT_Quaternion_Quaternion_Single;
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


        public R__0__0T() : base("#u.#0T")
        {
        }

        public R__0__0T(System.Object instance) : base("#u.#0T")
		{
            SetInstance(instance);
		}

        public R__0__0T(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__0T(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Single __0__ST(UnityEngine.Quaternion  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = R__0__ST_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Quaternion __0__TT(UnityEngine.Quaternion  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = R__0__TT_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion __0__UT(UnityEngine.Quaternion  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = R__0__UT_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion __0__VT(UnityEngine.Quaternion  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = R__0__VT_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion __0__WT(System.Single  @t, UnityEngine.Quaternion  @q0, UnityEngine.Quaternion  @q1, UnityEngine.Quaternion  @a0, UnityEngine.Quaternion  @a1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @q0, @q1, @a0, @a1};
            var ___result = R__0__WT_Single_Quaternion_Quaternion_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion __0__XT(UnityEngine.Quaternion  @q0, UnityEngine.Quaternion  @q1, UnityEngine.Quaternion  @q2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q0, @q1, @q2};
            var ___result = R__0__XT_Quaternion_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static System.Single __0__YT(System.Single  @t, System.Single  @k1, System.Single  @k2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @k1, @k2};
            var ___result = R__0__YT_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Quaternion __0__ZT(UnityEngine.Quaternion  @p, UnityEngine.Quaternion  @q, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p, @q, @t};
            var ___result = R__0__ZT_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
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
