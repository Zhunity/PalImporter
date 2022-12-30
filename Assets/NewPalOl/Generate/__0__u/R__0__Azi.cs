using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Azi
	/// </summary>
    public partial class R__0__Azi : RMember //
    {

		/// <summary>
		/// System.String #szi(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected static RMethod r_R__0__szi_IDictionary_d_String_Object_p_;
		public static RMethod R__0__szi_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_R__0__szi_IDictionary_d_String_Object_p_ == null)
				{
					r_R__0__szi_IDictionary_d_String_Object_p_ = new( ReleactionUtils.GetType("#u.#Azi"), "#szi", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_R__0__szi_IDictionary_d_String_Object_p_.SetBelong(null);
				}
				return r_R__0__szi_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// Int32 #3Xi(Char)
		/// </summary>
		protected static RMethod r_R__0__3Xi_Char;
		public static RMethod R__0__3Xi_Char
		{
			get
			{
				if(r_R__0__3Xi_Char == null)
				{
					r_R__0__3Xi_Char = new( ReleactionUtils.GetType("#u.#Azi"), "#3Xi", 0, typeof(System.Char));
					r_R__0__3Xi_Char.SetBelong(null);
				}
				return r_R__0__3Xi_Char;
			}
		}

		/// <summary>
		/// System.String #tzi(System.String, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_R__0__tzi_String_Encoding;
		public static RMethod R__0__tzi_String_Encoding
		{
			get
			{
				if(r_R__0__tzi_String_Encoding == null)
				{
					r_R__0__tzi_String_Encoding = new( ReleactionUtils.GetType("#u.#Azi"), "#tzi", 0, typeof(System.String), typeof(System.Text.Encoding));
					r_R__0__tzi_String_Encoding.SetBelong(null);
				}
				return r_R__0__tzi_String_Encoding;
			}
		}

		/// <summary>
		/// Byte[] #yzi(System.String, System.String)
		/// </summary>
		protected static RMethod r_R__0__yzi_String_String;
		public static RMethod R__0__yzi_String_String
		{
			get
			{
				if(r_R__0__yzi_String_String == null)
				{
					r_R__0__yzi_String_String = new( ReleactionUtils.GetType("#u.#Azi"), "#yzi", 0, typeof(System.String), typeof(System.String));
					r_R__0__yzi_String_String.SetBelong(null);
				}
				return r_R__0__yzi_String_String;
			}
		}

		/// <summary>
		/// System.String #zzi(System.String, System.String)
		/// </summary>
		protected static RMethod r_R__0__zzi_String_String;
		public static RMethod R__0__zzi_String_String
		{
			get
			{
				if(r_R__0__zzi_String_String == null)
				{
					r_R__0__zzi_String_String = new( ReleactionUtils.GetType("#u.#Azi"), "#zzi", 0, typeof(System.String), typeof(System.String));
					r_R__0__zzi_String_String.SetBelong(null);
				}
				return r_R__0__zzi_String_String;
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


        public R__0__Azi() : base("#u.#Azi")
        {
        }

        public R__0__Azi(System.Object instance) : base("#u.#Azi")
		{
            SetInstance(instance);
		}

        public R__0__Azi(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Azi(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String __0__szi(System.Collections.Generic.IDictionary<System.String, System.Object>  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__szi_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 __0__3Xi(System.Char  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h};
            var ___result = R__0__3Xi_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String __0__tzi(System.String  @value, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @encoding};
            var ___result = R__0__tzi_String_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Byte[] __0__yzi(System.String  @val, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @key};
            var ___result = R__0__yzi_String_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.String __0__zzi(System.String  @source, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @key};
            var ___result = R__0__zzi_String_String.Invoke(___genericsType, ___parameters);

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
