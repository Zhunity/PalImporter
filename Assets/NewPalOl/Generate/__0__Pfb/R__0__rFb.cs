using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__Pfb
{
	/// <summary>
	/// #Pfb.#rFb
	/// </summary>
    public partial class R__0__rFb : RMember //
    {

		/// <summary>
		/// System.String Serialize[#bk](#bk)
		/// </summary>
		protected static RMethod r_RSerialize_G__0__bk___0__bk;
		public static RMethod RSerialize_G__0__bk___0__bk
		{
			get
			{
				if(r_RSerialize_G__0__bk___0__bk == null)
				{
					r_RSerialize_G__0__bk___0__bk = new( ReleactionUtils.GetType("#Pfb.#rFb"), "Serialize", 1, Type.MakeGenericMethodParameter(0));
					r_RSerialize_G__0__bk___0__bk.SetBelong(null);
				}
				return r_RSerialize_G__0__bk___0__bk;
			}
		}

		/// <summary>
		/// #Pfb.#n6c Deserialize(#Pfb.#n6c, System.String)
		/// </summary>
		protected static RMethod r_RDeserialize___0__n6c_String;
		public static RMethod RDeserialize___0__n6c_String
		{
			get
			{
				if(r_RDeserialize___0__n6c_String == null)
				{
					r_RDeserialize___0__n6c_String = new( ReleactionUtils.GetType("#Pfb.#rFb"), "Deserialize", 0,  ReleactionUtils.GetType("#Pfb.#n6c"), typeof(System.String));
					r_RDeserialize___0__n6c_String.SetBelong(null);
				}
				return r_RDeserialize___0__n6c_String;
			}
		}

		/// <summary>
		/// #bk Deserialize[#bk](System.String)
		/// </summary>
		protected static RMethod r_RDeserialize_G__0__bk_String;
		public static RMethod RDeserialize_G__0__bk_String
		{
			get
			{
				if(r_RDeserialize_G__0__bk_String == null)
				{
					r_RDeserialize_G__0__bk_String = new( ReleactionUtils.GetType("#Pfb.#rFb"), "Deserialize", 1, typeof(System.String));
					r_RDeserialize_G__0__bk_String.SetBelong(null);
				}
				return r_RDeserialize_G__0__bk_String;
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


        public R__0__rFb() : base("#Pfb.#rFb")
        {
        }

        public R__0__rFb(System.Object instance) : base("#Pfb.#rFb")
		{
            SetInstance(instance);
		}

        public R__0__rFb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__rFb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String Serialize<__0__bk>(__0__bk  @instanceObj) where __0__bk : __0__Pfb.__0__zsb
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{@instanceObj};
            var ___result = RSerialize_G__0__bk___0__bk.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public static __0__bk Deserialize<__0__bk>(System.String  @message) where __0__bk : __0__Pfb.__0__n6c
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{@message};
            var ___result = RDeserialize_G__0__bk_String.Invoke(___genericsType, ___parameters);

            return (__0__bk)___result;
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
