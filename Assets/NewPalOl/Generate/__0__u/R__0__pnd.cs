using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#pnd
	/// </summary>
    public partial class R__0__pnd : RMember //
    {

		/// <summary>
		/// System.Byte[] #a
		/// </summary>
		protected static RFieldArray<RField> r___0__a;
		public static RFieldArray<RField> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#pnd"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// Byte[] #Oob(Byte[])
		/// </summary>
		protected static RMethod r_R__0__Oob_ByteArray;
		public static RMethod R__0__Oob_ByteArray
		{
			get
			{
				if(r_R__0__Oob_ByteArray == null)
				{
					r_R__0__Oob_ByteArray = new( ReleactionUtils.GetType("#u.#pnd"), "#Oob", 0, typeof(System.Byte).MakeArrayType());
					r_R__0__Oob_ByteArray.SetBelong(null);
				}
				return r_R__0__Oob_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] #MFb(Byte[])
		/// </summary>
		protected static RMethod r_R__0__MFb_ByteArray;
		public static RMethod R__0__MFb_ByteArray
		{
			get
			{
				if(r_R__0__MFb_ByteArray == null)
				{
					r_R__0__MFb_ByteArray = new( ReleactionUtils.GetType("#u.#pnd"), "#MFb", 0, typeof(System.Byte).MakeArrayType());
					r_R__0__MFb_ByteArray.SetBelong(null);
				}
				return r_R__0__MFb_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] #rnd(Byte[])
		/// </summary>
		protected static RMethod r_R__0__rnd_ByteArray;
		public static RMethod R__0__rnd_ByteArray
		{
			get
			{
				if(r_R__0__rnd_ByteArray == null)
				{
					r_R__0__rnd_ByteArray = new( ReleactionUtils.GetType("#u.#pnd"), "#rnd", 0, typeof(System.Byte).MakeArrayType());
					r_R__0__rnd_ByteArray.SetBelong(null);
				}
				return r_R__0__rnd_ByteArray;
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


        public R__0__pnd() : base("#u.#pnd")
        {
        }

        public R__0__pnd(System.Object instance) : base("#u.#pnd")
		{
            SetInstance(instance);
		}

        public R__0__pnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__pnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Byte[] __0__Oob(System.Byte[]  @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src};
            var ___result = R__0__Oob_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] __0__MFb(System.Byte[]  @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src};
            var ___result = R__0__MFb_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] __0__rnd(System.Byte[]  @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src};
            var ___result = R__0__rnd_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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
