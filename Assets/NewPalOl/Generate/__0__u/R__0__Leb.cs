using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Leb
	/// </summary>
    public partial class R__0__Leb : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #a
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__a;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Leb"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #b
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__b;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("#u.#Leb"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.String #Jeb(System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__Jeb_String_String;
		public virtual RMethod R__0__Jeb_String_String
		{
			get
			{
				if(r_R__0__Jeb_String_String == null)
				{
					r_R__0__Jeb_String_String = new(this, "#Jeb", 0, typeof(System.String), typeof(System.String));
					r_R__0__Jeb_String_String.SetBelong(this.instance);
				}
				return r_R__0__Jeb_String_String;
			}
		}

		/// <summary>
		/// Double #Keb(Double, Char, Double)
		/// </summary>
		protected RMethod r_R__0__Keb_Double_Char_Double;
		public virtual RMethod R__0__Keb_Double_Char_Double
		{
			get
			{
				if(r_R__0__Keb_Double_Char_Double == null)
				{
					r_R__0__Keb_Double_Char_Double = new(this, "#Keb", 0, typeof(System.Double), typeof(System.Char), typeof(System.Double));
					r_R__0__Keb_Double_Char_Double.SetBelong(this.instance);
				}
				return r_R__0__Keb_Double_Char_Double;
			}
		}

		/// <summary>
		/// Int64 #Keb(Int64, Char, Int64)
		/// </summary>
		protected RMethod r_R__0__Keb_Int64_Char_Int64;
		public virtual RMethod R__0__Keb_Int64_Char_Int64
		{
			get
			{
				if(r_R__0__Keb_Int64_Char_Int64 == null)
				{
					r_R__0__Keb_Int64_Char_Int64 = new(this, "#Keb", 0, typeof(System.Int64), typeof(System.Char), typeof(System.Int64));
					r_R__0__Keb_Int64_Char_Int64.SetBelong(this.instance);
				}
				return r_R__0__Keb_Int64_Char_Int64;
			}
		}

		/// <summary>
		/// System.Object #BS(System.String)
		/// </summary>
		protected RMethod r_R__0__BS_String;
		public virtual RMethod R__0__BS_String
		{
			get
			{
				if(r_R__0__BS_String == null)
				{
					r_R__0__BS_String = new(this, "#BS", 0, typeof(System.String));
					r_R__0__BS_String.SetBelong(this.instance);
				}
				return r_R__0__BS_String;
			}
		}

		/// <summary>
		/// System.Object #CS(System.String, Boolean)
		/// </summary>
		protected RMethod r_R__0__CS_String_Boolean;
		public virtual RMethod R__0__CS_String_Boolean
		{
			get
			{
				if(r_R__0__CS_String_Boolean == null)
				{
					r_R__0__CS_String_Boolean = new(this, "#CS", 0, typeof(System.String), typeof(System.Boolean));
					r_R__0__CS_String_Boolean.SetBelong(this.instance);
				}
				return r_R__0__CS_String_Boolean;
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


        public R__0__Leb() : base("#u.#Leb")
        {
        }

        public R__0__Leb(System.Object instance) : base("#u.#Leb")
		{
            SetInstance(instance);
		}

        public R__0__Leb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Leb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String __0__Jeb(System.String  @p, System.String  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p, @q};
            var ___result = R__0__Jeb_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Double __0__Keb(System.Double  @a, System.Char  @o, System.Double  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @o, @b};
            var ___result = R__0__Keb_Double_Char_Double.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int64 __0__Keb(System.Int64  @a, System.Char  @o, System.Int64  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @o, @b};
            var ___result = R__0__Keb_Int64_Char_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Object __0__BS(System.String  @Expression)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Expression};
            var ___result = R__0__BS_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__CS(System.String  @Expression, System.Boolean  @isCeilToInt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Expression, @isCeilToInt};
            var ___result = R__0__CS_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
