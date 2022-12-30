using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.IXmlSchemaInfo
	/// </summary>
    public partial class RIXmlSchemaInfo : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaValidity Validity
		/// </summary>
		protected RProperty r_Validity;
		public virtual RProperty RValidity
		{
			get
			{
				if(r_Validity == null)
				{
					r_Validity = new(this, "Validity", -1);
					r_Validity.SetBelong(this.instance);
				}
				return r_Validity;
			}
		}

		/// <summary>
		/// Boolean IsDefault
		/// </summary>
		protected RProperty r_IsDefault;
		public virtual RProperty RIsDefault
		{
			get
			{
				if(r_IsDefault == null)
				{
					r_IsDefault = new(this, "IsDefault", -1);
					r_IsDefault.SetBelong(this.instance);
				}
				return r_IsDefault;
			}
		}

		/// <summary>
		/// Boolean IsNil
		/// </summary>
		protected RProperty r_IsNil;
		public virtual RProperty RIsNil
		{
			get
			{
				if(r_IsNil == null)
				{
					r_IsNil = new(this, "IsNil", -1);
					r_IsNil.SetBelong(this.instance);
				}
				return r_IsNil;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType MemberType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSimpleType r_MemberType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSimpleType RMemberType
		{
			get
			{
				if(r_MemberType == null)
				{
					r_MemberType = new(this, "MemberType", -1);
					r_MemberType.SetBelong(this.instance);
				}
				return r_MemberType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType SchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_SchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RSchemaType
		{
			get
			{
				if(r_SchemaType == null)
				{
					r_SchemaType = new(this, "SchemaType", -1);
					r_SchemaType.SetBelong(this.instance);
				}
				return r_SchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaElement SchemaElement
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaElement r_SchemaElement;
		public virtual RSystem.RXml.RSchema.RXmlSchemaElement RSchemaElement
		{
			get
			{
				if(r_SchemaElement == null)
				{
					r_SchemaElement = new(this, "SchemaElement", -1);
					r_SchemaElement.SetBelong(this.instance);
				}
				return r_SchemaElement;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAttribute SchemaAttribute
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAttribute r_SchemaAttribute;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAttribute RSchemaAttribute
		{
			get
			{
				if(r_SchemaAttribute == null)
				{
					r_SchemaAttribute = new(this, "SchemaAttribute", -1);
					r_SchemaAttribute.SetBelong(this.instance);
				}
				return r_SchemaAttribute;
			}
		}


        public RIXmlSchemaInfo() : base("System.Xml.Schema.IXmlSchemaInfo")
        {
        }

        public RIXmlSchemaInfo(System.Object instance) : base("System.Xml.Schema.IXmlSchemaInfo")
		{
            SetInstance(instance);
		}

        public RIXmlSchemaInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIXmlSchemaInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
