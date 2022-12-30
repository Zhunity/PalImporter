using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#OFb
	/// </summary>
    public partial class R__0__OFb : RMember //
    {

		/// <summary>
		/// Void SetNumber(Byte[] ByRef, Int32 ByRef, UInt64, Boolean)
		/// </summary>
		protected static RMethod r_RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean;
		public static RMethod RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean
		{
			get
			{
				if(r_RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean == null)
				{
					r_RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean = new( ReleactionUtils.GetType("#u.#OFb"), "SetNumber", 0, typeof(System.Byte).MakeArrayType().MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.UInt64), typeof(System.Boolean));
					r_RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean.SetBelong(null);
				}
				return r_RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean;
			}
		}

		/// <summary>
		/// Byte[] #Oob(System.String)
		/// </summary>
		protected static RMethod r_R__0__Oob_String;
		public static RMethod R__0__Oob_String
		{
			get
			{
				if(r_R__0__Oob_String == null)
				{
					r_R__0__Oob_String = new( ReleactionUtils.GetType("#u.#OFb"), "#Oob", 0, typeof(System.String));
					r_R__0__Oob_String.SetBelong(null);
				}
				return r_R__0__Oob_String;
			}
		}

		/// <summary>
		/// System.String #MFb(Byte[])
		/// </summary>
		protected static RMethod r_R__0__MFb_ByteArray;
		public static RMethod R__0__MFb_ByteArray
		{
			get
			{
				if(r_R__0__MFb_ByteArray == null)
				{
					r_R__0__MFb_ByteArray = new( ReleactionUtils.GetType("#u.#OFb"), "#MFb", 0, typeof(System.Byte).MakeArrayType());
					r_R__0__MFb_ByteArray.SetBelong(null);
				}
				return r_R__0__MFb_ByteArray;
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


        public R__0__OFb() : base("#u.#OFb")
        {
        }

        public R__0__OFb(System.Object instance) : base("#u.#OFb")
		{
            SetInstance(instance);
		}

        public R__0__OFb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__OFb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetNumber(ref System.Byte[]  @szTmp, ref System.Int32  @nSize, System.UInt64  @unVal, System.Boolean  @bSigned)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@szTmp, @nSize, @unVal, @bSigned};
            var ___result = RSetNumber_Ref_ByteArray_Ref_Int32_UInt64_Boolean.Invoke(___genericsType, ___parameters);
			szTmp = (System.Byte[])___parameters[0];
			nSize = (System.Int32)___parameters[1];

            
        }


        public static System.Byte[] __0__Oob(System.String  @strSrc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strSrc};
            var ___result = R__0__Oob_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.String __0__MFb(System.Byte[]  @lpSrc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lpSrc};
            var ___result = R__0__MFb_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
