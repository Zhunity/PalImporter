using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__Pfb
{
	/// <summary>
	/// #Pfb.#pFb
	/// </summary>
    public partial class R__0__pFb : RMember //
    {

		/// <summary>
		/// System.String[] #a
		/// </summary>
		protected static RFieldArray<RField> r___0__a;
		public static RFieldArray<RField> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32 #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected static RProperty r_R__0__mFb;
		public static RProperty R__0__mFb
		{
			get
			{
				if(r_R__0__mFb == null)
				{
					r_R__0__mFb = new( ReleactionUtils.GetType("#Pfb.#pFb"), "Length", -1);
					r_R__0__mFb.SetBelong(null);
				}
				return r_R__0__mFb;
			}
		}

		/// <summary>
		/// Boolean #kFb()
		/// </summary>
		protected static RMethod r_R__0__kFb;
		public static RMethod R__0__kFb
		{
			get
			{
				if(r_R__0__kFb == null)
				{
					r_R__0__kFb = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#kFb", 0);
					r_R__0__kFb.SetBelong(null);
				}
				return r_R__0__kFb;
			}
		}

		/// <summary>
		/// Void #lFb(System.String)
		/// </summary>
		protected static RMethod r_R__0__lFb_String;
		public static RMethod R__0__lFb_String
		{
			get
			{
				if(r_R__0__lFb_String == null)
				{
					r_R__0__lFb_String = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#lFb", 0, typeof(System.String));
					r_R__0__lFb_String.SetBelong(null);
				}
				return r_R__0__lFb_String;
			}
		}

		/// <summary>
		/// Void #nFb()
		/// </summary>
		protected static RMethod r_R__0__nFb;
		public static RMethod R__0__nFb
		{
			get
			{
				if(r_R__0__nFb == null)
				{
					r_R__0__nFb = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#nFb", 0);
					r_R__0__nFb.SetBelong(null);
				}
				return r_R__0__nFb;
			}
		}

		/// <summary>
		/// System.String Get()
		/// </summary>
		protected static RMethod r_RGet;
		public static RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new( ReleactionUtils.GetType("#Pfb.#pFb"), "Get", 0);
					r_RGet.SetBelong(null);
				}
				return r_RGet;
			}
		}

		/// <summary>
		/// Int32 #oFb()
		/// </summary>
		protected static RMethod r_R__0__oFb;
		public static RMethod R__0__oFb
		{
			get
			{
				if(r_R__0__oFb == null)
				{
					r_R__0__oFb = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#oFb", 0);
					r_R__0__oFb.SetBelong(null);
				}
				return r_R__0__oFb;
			}
		}

		/// <summary>
		/// Void #Asb(#Pfb.#n6c, System.Type)
		/// </summary>
		protected static RMethod r_R__0__Asb___0__n6c_Type;
		public static RMethod R__0__Asb___0__n6c_Type
		{
			get
			{
				if(r_R__0__Asb___0__n6c_Type == null)
				{
					r_R__0__Asb___0__n6c_Type = new( ReleactionUtils.GetType("#Pfb.#pFb"), "#Asb", 0,  ReleactionUtils.GetType("#Pfb.#n6c"), typeof(System.Type));
					r_R__0__Asb___0__n6c_Type.SetBelong(null);
				}
				return r_R__0__Asb___0__n6c_Type;
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


        public R__0__pFb() : base("#Pfb.#pFb")
        {
        }

        public R__0__pFb(System.Object instance) : base("#Pfb.#pFb")
		{
            SetInstance(instance);
		}

        public R__0__pFb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__pFb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean __0__kFb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kFb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void __0__lFb(System.String  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = R__0__lFb_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__nFb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nFb.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 __0__oFb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__oFb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
