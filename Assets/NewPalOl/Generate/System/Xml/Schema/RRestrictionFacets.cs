using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.RestrictionFacets
	/// </summary>
    public partial class RRestrictionFacets : RMember //
    {

		/// <summary>
		/// System.Int32 Length
		/// </summary>
		protected RField r_Length;
		public virtual RField RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length");
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// System.Int32 MinLength
		/// </summary>
		protected RField r_MinLength;
		public virtual RField RMinLength
		{
			get
			{
				if(r_MinLength == null)
				{
					r_MinLength = new(this, "MinLength");
					r_MinLength.SetBelong(this.instance);
				}
				return r_MinLength;
			}
		}

		/// <summary>
		/// System.Int32 MaxLength
		/// </summary>
		protected RField r_MaxLength;
		public virtual RField RMaxLength
		{
			get
			{
				if(r_MaxLength == null)
				{
					r_MaxLength = new(this, "MaxLength");
					r_MaxLength.SetBelong(this.instance);
				}
				return r_MaxLength;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Patterns
		/// </summary>
		protected RSystem.RCollections.RArrayList r_Patterns;
		public virtual RSystem.RCollections.RArrayList RPatterns
		{
			get
			{
				if(r_Patterns == null)
				{
					r_Patterns = new(this, "Patterns");
					r_Patterns.SetBelong(this.instance);
				}
				return r_Patterns;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Enumeration
		/// </summary>
		protected RSystem.RCollections.RArrayList r_Enumeration;
		public virtual RSystem.RCollections.RArrayList REnumeration
		{
			get
			{
				if(r_Enumeration == null)
				{
					r_Enumeration = new(this, "Enumeration");
					r_Enumeration.SetBelong(this.instance);
				}
				return r_Enumeration;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaWhiteSpace WhiteSpace
		/// </summary>
		protected RField r_WhiteSpace;
		public virtual RField RWhiteSpace
		{
			get
			{
				if(r_WhiteSpace == null)
				{
					r_WhiteSpace = new(this, "WhiteSpace");
					r_WhiteSpace.SetBelong(this.instance);
				}
				return r_WhiteSpace;
			}
		}

		/// <summary>
		/// System.Object MaxInclusive
		/// </summary>
		protected RSystem.RObject r_MaxInclusive;
		public virtual RSystem.RObject RMaxInclusive
		{
			get
			{
				if(r_MaxInclusive == null)
				{
					r_MaxInclusive = new(this, "MaxInclusive");
					r_MaxInclusive.SetBelong(this.instance);
				}
				return r_MaxInclusive;
			}
		}

		/// <summary>
		/// System.Object MaxExclusive
		/// </summary>
		protected RSystem.RObject r_MaxExclusive;
		public virtual RSystem.RObject RMaxExclusive
		{
			get
			{
				if(r_MaxExclusive == null)
				{
					r_MaxExclusive = new(this, "MaxExclusive");
					r_MaxExclusive.SetBelong(this.instance);
				}
				return r_MaxExclusive;
			}
		}

		/// <summary>
		/// System.Object MinInclusive
		/// </summary>
		protected RSystem.RObject r_MinInclusive;
		public virtual RSystem.RObject RMinInclusive
		{
			get
			{
				if(r_MinInclusive == null)
				{
					r_MinInclusive = new(this, "MinInclusive");
					r_MinInclusive.SetBelong(this.instance);
				}
				return r_MinInclusive;
			}
		}

		/// <summary>
		/// System.Object MinExclusive
		/// </summary>
		protected RSystem.RObject r_MinExclusive;
		public virtual RSystem.RObject RMinExclusive
		{
			get
			{
				if(r_MinExclusive == null)
				{
					r_MinExclusive = new(this, "MinExclusive");
					r_MinExclusive.SetBelong(this.instance);
				}
				return r_MinExclusive;
			}
		}

		/// <summary>
		/// System.Int32 TotalDigits
		/// </summary>
		protected RField r_TotalDigits;
		public virtual RField RTotalDigits
		{
			get
			{
				if(r_TotalDigits == null)
				{
					r_TotalDigits = new(this, "TotalDigits");
					r_TotalDigits.SetBelong(this.instance);
				}
				return r_TotalDigits;
			}
		}

		/// <summary>
		/// System.Int32 FractionDigits
		/// </summary>
		protected RField r_FractionDigits;
		public virtual RField RFractionDigits
		{
			get
			{
				if(r_FractionDigits == null)
				{
					r_FractionDigits = new(this, "FractionDigits");
					r_FractionDigits.SetBelong(this.instance);
				}
				return r_FractionDigits;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFlags Flags
		/// </summary>
		protected RField r_Flags;
		public virtual RField RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags");
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFlags FixedFlags
		/// </summary>
		protected RField r_FixedFlags;
		public virtual RField RFixedFlags
		{
			get
			{
				if(r_FixedFlags == null)
				{
					r_FixedFlags = new(this, "FixedFlags");
					r_FixedFlags.SetBelong(this.instance);
				}
				return r_FixedFlags;
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


        public RRestrictionFacets() : base("System.Xml.Schema.RestrictionFacets")
        {
        }

        public RRestrictionFacets(System.Object instance) : base("System.Xml.Schema.RestrictionFacets")
		{
            SetInstance(instance);
		}

        public RRestrictionFacets(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRestrictionFacets(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
