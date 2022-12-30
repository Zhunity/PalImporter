using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlName
	/// </summary>
    public partial class RXmlName : RMember //
    {

		/// <summary>
		/// System.String prefix
		/// </summary>
		protected RField r_prefix;
		public virtual RField Rprefix
		{
			get
			{
				if(r_prefix == null)
				{
					r_prefix = new(this, "prefix");
					r_prefix.SetBelong(this.instance);
				}
				return r_prefix;
			}
		}

		/// <summary>
		/// System.String localName
		/// </summary>
		protected RField r_localName;
		public virtual RField RlocalName
		{
			get
			{
				if(r_localName == null)
				{
					r_localName = new(this, "localName");
					r_localName.SetBelong(this.instance);
				}
				return r_localName;
			}
		}

		/// <summary>
		/// System.String ns
		/// </summary>
		protected RField r_ns;
		public virtual RField Rns
		{
			get
			{
				if(r_ns == null)
				{
					r_ns = new(this, "ns");
					r_ns.SetBelong(this.instance);
				}
				return r_ns;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Int32 hashCode
		/// </summary>
		protected RField r_hashCode;
		public virtual RField RhashCode
		{
			get
			{
				if(r_hashCode == null)
				{
					r_hashCode = new(this, "hashCode");
					r_hashCode.SetBelong(this.instance);
				}
				return r_hashCode;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocument ownerDoc
		/// </summary>
		protected RSystem.RXml.RXmlDocument r_ownerDoc;
		public virtual RSystem.RXml.RXmlDocument RownerDoc
		{
			get
			{
				if(r_ownerDoc == null)
				{
					r_ownerDoc = new(this, "ownerDoc");
					r_ownerDoc.SetBelong(this.instance);
				}
				return r_ownerDoc;
			}
		}

		/// <summary>
		/// System.Xml.XmlName next
		/// </summary>
		protected RSystem.RXml.RXmlName r_next;
		public virtual RSystem.RXml.RXmlName Rnext
		{
			get
			{
				if(r_next == null)
				{
					r_next = new(this, "next");
					r_next.SetBelong(this.instance);
				}
				return r_next;
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
		/// System.String NamespaceURI
		/// </summary>
		protected RProperty r_NamespaceURI;
		public virtual RProperty RNamespaceURI
		{
			get
			{
				if(r_NamespaceURI == null)
				{
					r_NamespaceURI = new(this, "NamespaceURI", -1);
					r_NamespaceURI.SetBelong(this.instance);
				}
				return r_NamespaceURI;
			}
		}

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
		/// Int32 HashCode
		/// </summary>
		protected RProperty r_HashCode;
		public virtual RProperty RHashCode
		{
			get
			{
				if(r_HashCode == null)
				{
					r_HashCode = new(this, "HashCode", -1);
					r_HashCode.SetBelong(this.instance);
				}
				return r_HashCode;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocument OwnerDocument
		/// </summary>
		protected RSystem.RXml.RXmlDocument r_OwnerDocument;
		public virtual RSystem.RXml.RXmlDocument ROwnerDocument
		{
			get
			{
				if(r_OwnerDocument == null)
				{
					r_OwnerDocument = new(this, "OwnerDocument", -1);
					r_OwnerDocument.SetBelong(this.instance);
				}
				return r_OwnerDocument;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

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

		/// <summary>
		/// System.Xml.XmlName Create(System.String, System.String, System.String, Int32, System.Xml.XmlDocument, System.Xml.XmlName, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected static RMethod r_RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo;
		public static RMethod RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo
		{
			get
			{
				if(r_RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo == null)
				{
					r_RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo = new( ReleactionUtils.GetType("System.Xml.XmlName"), "Create", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Xml.XmlDocument),  ReleactionUtils.GetType("System.Xml.XmlName"), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo.SetBelong(null);
				}
				return r_RCreate_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_REquals_IXmlSchemaInfo;
		public virtual RMethod REquals_IXmlSchemaInfo
		{
			get
			{
				if(r_REquals_IXmlSchemaInfo == null)
				{
					r_REquals_IXmlSchemaInfo = new(this, "Equals", 0, typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_REquals_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_REquals_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.String)
		/// </summary>
		protected static RMethod r_RGetHashCode_String;
		public static RMethod RGetHashCode_String
		{
			get
			{
				if(r_RGetHashCode_String == null)
				{
					r_RGetHashCode_String = new( ReleactionUtils.GetType("System.Xml.XmlName"), "GetHashCode", 0, typeof(System.String));
					r_RGetHashCode_String.SetBelong(null);
				}
				return r_RGetHashCode_String;
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


        public RXmlName() : base("System.Xml.XmlName")
        {
        }

        public RXmlName(System.Object instance) : base("System.Xml.XmlName")
		{
            SetInstance(instance);
		}

        public RXmlName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Boolean Equals(System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaInfo};
            var ___result = REquals_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetHashCode(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetHashCode_String.Invoke(___genericsType, ___parameters);

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
