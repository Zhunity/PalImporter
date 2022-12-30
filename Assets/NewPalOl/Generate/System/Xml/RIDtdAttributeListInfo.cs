using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IDtdAttributeListInfo
	/// </summary>
    public partial class RIDtdAttributeListInfo : RMember //
    {

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected RProperty r_Prefix;
		public virtual RProperty RPrefix
		{
			get
			{
				if(r_Prefix == null)
				{
					r_Prefix = new(this, "Prefix", -1);
					r_Prefix.SetBelong(this.instance);
				}
				return r_Prefix;
			}
		}

		/// <summary>
		/// System.String LocalName
		/// </summary>
		protected RProperty r_LocalName;
		public virtual RProperty RLocalName
		{
			get
			{
				if(r_LocalName == null)
				{
					r_LocalName = new(this, "LocalName", -1);
					r_LocalName.SetBelong(this.instance);
				}
				return r_LocalName;
			}
		}

		/// <summary>
		/// Boolean HasNonCDataAttributes
		/// </summary>
		protected RProperty r_HasNonCDataAttributes;
		public virtual RProperty RHasNonCDataAttributes
		{
			get
			{
				if(r_HasNonCDataAttributes == null)
				{
					r_HasNonCDataAttributes = new(this, "HasNonCDataAttributes", -1);
					r_HasNonCDataAttributes.SetBelong(this.instance);
				}
				return r_HasNonCDataAttributes;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeInfo LookupAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RLookupAttribute_String_String;
		public virtual RMethod RLookupAttribute_String_String
		{
			get
			{
				if(r_RLookupAttribute_String_String == null)
				{
					r_RLookupAttribute_String_String = new(this, "LookupAttribute", 0, typeof(System.String), typeof(System.String));
					r_RLookupAttribute_String_String.SetBelong(this.instance);
				}
				return r_RLookupAttribute_String_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Xml.IDtdDefaultAttributeInfo] LookupDefaultAttributes()
		/// </summary>
		protected RMethod r_RLookupDefaultAttributes;
		public virtual RMethod RLookupDefaultAttributes
		{
			get
			{
				if(r_RLookupDefaultAttributes == null)
				{
					r_RLookupDefaultAttributes = new(this, "LookupDefaultAttributes", 0);
					r_RLookupDefaultAttributes.SetBelong(this.instance);
				}
				return r_RLookupDefaultAttributes;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeInfo LookupIdAttribute()
		/// </summary>
		protected RMethod r_RLookupIdAttribute;
		public virtual RMethod RLookupIdAttribute
		{
			get
			{
				if(r_RLookupIdAttribute == null)
				{
					r_RLookupIdAttribute = new(this, "LookupIdAttribute", 0);
					r_RLookupIdAttribute.SetBelong(this.instance);
				}
				return r_RLookupIdAttribute;
			}
		}


        public RIDtdAttributeListInfo() : base("System.Xml.IDtdAttributeListInfo")
        {
        }

        public RIDtdAttributeListInfo(System.Object instance) : base("System.Xml.IDtdAttributeListInfo")
		{
            SetInstance(instance);
		}

        public RIDtdAttributeListInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDtdAttributeListInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LookupAttribute(System.String  @prefix, System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName};
            var ___result = RLookupAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LookupDefaultAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLookupDefaultAttributes.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LookupIdAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLookupIdAttribute.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
