using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ParserXmlAttribute
	/// </summary>
    public partial class RParserXmlAttribute : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Object #b
		/// </summary>
		protected RSystem.RObject r___0__b;
		public virtual RSystem.RObject R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.String ParserName
		/// </summary>
		protected RProperty r_ParserName;
		public virtual RProperty RParserName
		{
			get
			{
				if(r_ParserName == null)
				{
					r_ParserName = new(this, "ParserName", -1);
					r_ParserName.SetBelong(this.instance);
				}
				return r_ParserName;
			}
		}

		/// <summary>
		/// System.Object defaultValue
		/// </summary>
		protected RSystem.RObject r_defaultValue;
		public virtual RSystem.RObject RdefaultValue
		{
			get
			{
				if(r_defaultValue == null)
				{
					r_defaultValue = new(this, "defaultValue", -1);
					r_defaultValue.SetBelong(this.instance);
				}
				return r_defaultValue;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_TypeId;
		public virtual RSystem.RObject RTypeId
		{
			get
			{
				if(r_TypeId == null)
				{
					r_TypeId = new(this, "TypeId", -1);
					r_TypeId.SetBelong(this.instance);
				}
				return r_TypeId;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_RMatch_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_RMatch_Object == null)
				{
					r_RMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_RMatch_Object.SetBelong(this.instance);
				}
				return r_RMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_RIsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_RIsDefaultAttribute == null)
				{
					r_RIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_RIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_RIsDefaultAttribute;
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


        public RParserXmlAttribute() : base("ParserXmlAttribute")
        {
        }

        public RParserXmlAttribute(System.Object instance) : base("ParserXmlAttribute")
		{
            SetInstance(instance);
		}

        public RParserXmlAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParserXmlAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Match(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
