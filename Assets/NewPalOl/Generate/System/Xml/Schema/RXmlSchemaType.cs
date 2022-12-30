using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaType
	/// </summary>
    public partial class RXmlSchemaType : RMember //
    {

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
		/// System.Xml.Schema.XmlSchemaDerivationMethod final
		/// </summary>
		protected RField r_final;
		public virtual RField Rfinal
		{
			get
			{
				if(r_final == null)
				{
					r_final = new(this, "final");
					r_final.SetBelong(this.instance);
				}
				return r_final;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod derivedBy
		/// </summary>
		protected RField r_derivedBy;
		public virtual RField RderivedBy
		{
			get
			{
				if(r_derivedBy == null)
				{
					r_derivedBy = new(this, "derivedBy");
					r_derivedBy.SetBelong(this.instance);
				}
				return r_derivedBy;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType baseSchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_baseSchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RbaseSchemaType
		{
			get
			{
				if(r_baseSchemaType == null)
				{
					r_baseSchemaType = new(this, "baseSchemaType");
					r_baseSchemaType.SetBelong(this.instance);
				}
				return r_baseSchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype datatype
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_datatype;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype Rdatatype
		{
			get
			{
				if(r_datatype == null)
				{
					r_datatype = new(this, "datatype");
					r_datatype.SetBelong(this.instance);
				}
				return r_datatype;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod finalResolved
		/// </summary>
		protected RField r_finalResolved;
		public virtual RField RfinalResolved
		{
			get
			{
				if(r_finalResolved == null)
				{
					r_finalResolved = new(this, "finalResolved");
					r_finalResolved.SetBelong(this.instance);
				}
				return r_finalResolved;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl elementDecl
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaElementDecl r_elementDecl;
		public virtual RSystem.RXml.RSchema.RSchemaElementDecl RelementDecl
		{
			get
			{
				if(r_elementDecl == null)
				{
					r_elementDecl = new(this, "elementDecl");
					r_elementDecl.SetBelong(this.instance);
				}
				return r_elementDecl;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName qname
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_qname;
		public virtual RSystem.RXml.RXmlQualifiedName Rqname
		{
			get
			{
				if(r_qname == null)
				{
					r_qname = new(this, "qname");
					r_qname.SetBelong(this.instance);
				}
				return r_qname;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType redefined
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_redefined;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType Rredefined
		{
			get
			{
				if(r_redefined == null)
				{
					r_redefined = new(this, "redefined");
					r_redefined.SetBelong(this.instance);
				}
				return r_redefined;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentType contentType
		/// </summary>
		protected RField r_contentType;
		public virtual RField RcontentType
		{
			get
			{
				if(r_contentType == null)
				{
					r_contentType = new(this, "contentType");
					r_contentType.SetBelong(this.instance);
				}
				return r_contentType;
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
		/// System.Xml.Schema.XmlSchemaDerivationMethod Final
		/// </summary>
		protected RProperty r_Final;
		public virtual RProperty RFinal
		{
			get
			{
				if(r_Final == null)
				{
					r_Final = new(this, "Final", -1);
					r_Final.SetBelong(this.instance);
				}
				return r_Final;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QualifiedName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QualifiedName;
		public virtual RSystem.RXml.RXmlQualifiedName RQualifiedName
		{
			get
			{
				if(r_QualifiedName == null)
				{
					r_QualifiedName = new(this, "QualifiedName", -1);
					r_QualifiedName.SetBelong(this.instance);
				}
				return r_QualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod FinalResolved
		/// </summary>
		protected RProperty r_FinalResolved;
		public virtual RProperty RFinalResolved
		{
			get
			{
				if(r_FinalResolved == null)
				{
					r_FinalResolved = new(this, "FinalResolved", -1);
					r_FinalResolved.SetBelong(this.instance);
				}
				return r_FinalResolved;
			}
		}

		/// <summary>
		/// System.Object BaseSchemaType
		/// </summary>
		protected RSystem.RObject r_BaseSchemaType;
		public virtual RSystem.RObject RBaseSchemaType
		{
			get
			{
				if(r_BaseSchemaType == null)
				{
					r_BaseSchemaType = new(this, "BaseSchemaType", -1);
					r_BaseSchemaType.SetBelong(this.instance);
				}
				return r_BaseSchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType BaseXmlSchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_BaseXmlSchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RBaseXmlSchemaType
		{
			get
			{
				if(r_BaseXmlSchemaType == null)
				{
					r_BaseXmlSchemaType = new(this, "BaseXmlSchemaType", -1);
					r_BaseXmlSchemaType.SetBelong(this.instance);
				}
				return r_BaseXmlSchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod DerivedBy
		/// </summary>
		protected RProperty r_DerivedBy;
		public virtual RProperty RDerivedBy
		{
			get
			{
				if(r_DerivedBy == null)
				{
					r_DerivedBy = new(this, "DerivedBy", -1);
					r_DerivedBy.SetBelong(this.instance);
				}
				return r_DerivedBy;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype Datatype
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_Datatype;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype RDatatype
		{
			get
			{
				if(r_Datatype == null)
				{
					r_Datatype = new(this, "Datatype", -1);
					r_Datatype.SetBelong(this.instance);
				}
				return r_Datatype;
			}
		}

		/// <summary>
		/// Boolean IsMixed
		/// </summary>
		protected RProperty r_IsMixed;
		public virtual RProperty RIsMixed
		{
			get
			{
				if(r_IsMixed == null)
				{
					r_IsMixed = new(this, "IsMixed", -1);
					r_IsMixed.SetBelong(this.instance);
				}
				return r_IsMixed;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlTypeCode TypeCode
		/// </summary>
		protected RProperty r_TypeCode;
		public virtual RProperty RTypeCode
		{
			get
			{
				if(r_TypeCode == null)
				{
					r_TypeCode = new(this, "TypeCode", -1);
					r_TypeCode.SetBelong(this.instance);
				}
				return r_TypeCode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlValueConverter ValueConverter
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlValueConverter r_ValueConverter;
		public virtual RSystem.RXml.RSchema.RXmlValueConverter RValueConverter
		{
			get
			{
				if(r_ValueConverter == null)
				{
					r_ValueConverter = new(this, "ValueConverter", -1);
					r_ValueConverter.SetBelong(this.instance);
				}
				return r_ValueConverter;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentType SchemaContentType
		/// </summary>
		protected RProperty r_SchemaContentType;
		public virtual RProperty RSchemaContentType
		{
			get
			{
				if(r_SchemaContentType == null)
				{
					r_SchemaContentType = new(this, "SchemaContentType", -1);
					r_SchemaContentType.SetBelong(this.instance);
				}
				return r_SchemaContentType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl ElementDecl
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaElementDecl r_ElementDecl;
		public virtual RSystem.RXml.RSchema.RSchemaElementDecl RElementDecl
		{
			get
			{
				if(r_ElementDecl == null)
				{
					r_ElementDecl = new(this, "ElementDecl", -1);
					r_ElementDecl.SetBelong(this.instance);
				}
				return r_ElementDecl;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType Redefined
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_Redefined;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType Redefined
		{
			get
			{
				if(r_Redefined == null)
				{
					r_Redefined = new(this, "Redefined", -1);
					r_Redefined.SetBelong(this.instance);
				}
				return r_Redefined;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName DerivedFrom
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_DerivedFrom;
		public virtual RSystem.RXml.RXmlQualifiedName RDerivedFrom
		{
			get
			{
				if(r_DerivedFrom == null)
				{
					r_DerivedFrom = new(this, "DerivedFrom", -1);
					r_DerivedFrom.SetBelong(this.instance);
				}
				return r_DerivedFrom;
			}
		}

		/// <summary>
		/// System.String NameAttribute
		/// </summary>
		protected RProperty r_NameAttribute;
		public virtual RProperty RNameAttribute
		{
			get
			{
				if(r_NameAttribute == null)
				{
					r_NameAttribute = new(this, "NameAttribute", -1);
					r_NameAttribute.SetBelong(this.instance);
				}
				return r_NameAttribute;
			}
		}

		/// <summary>
		/// System.String Id
		/// </summary>
		protected RProperty r_Id;
		public virtual RProperty RId
		{
			get
			{
				if(r_Id == null)
				{
					r_Id = new(this, "Id", -1);
					r_Id.SetBelong(this.instance);
				}
				return r_Id;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnnotation Annotation
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnnotation r_Annotation;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnnotation RAnnotation
		{
			get
			{
				if(r_Annotation == null)
				{
					r_Annotation = new(this, "Annotation", -1);
					r_Annotation.SetBelong(this.instance);
				}
				return r_Annotation;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute[] UnhandledAttributes
		/// </summary>
		protected RPropertyArray<RSystem.RXml.RXmlAttribute> r_UnhandledAttributes;
		public virtual RPropertyArray<RSystem.RXml.RXmlAttribute> RUnhandledAttributes
		{
			get
			{
				if(r_UnhandledAttributes == null)
				{
					r_UnhandledAttributes = new(this, "UnhandledAttributes", -1);
					r_UnhandledAttributes.SetBelong(this.instance);
				}
				return r_UnhandledAttributes;
			}
		}

		/// <summary>
		/// System.String IdAttribute
		/// </summary>
		protected RProperty r_IdAttribute;
		public virtual RProperty RIdAttribute
		{
			get
			{
				if(r_IdAttribute == null)
				{
					r_IdAttribute = new(this, "IdAttribute", -1);
					r_IdAttribute.SetBelong(this.instance);
				}
				return r_IdAttribute;
			}
		}

		/// <summary>
		/// Int32 LineNumber
		/// </summary>
		protected RProperty r_LineNumber;
		public virtual RProperty RLineNumber
		{
			get
			{
				if(r_LineNumber == null)
				{
					r_LineNumber = new(this, "LineNumber", -1);
					r_LineNumber.SetBelong(this.instance);
				}
				return r_LineNumber;
			}
		}

		/// <summary>
		/// Int32 LinePosition
		/// </summary>
		protected RProperty r_LinePosition;
		public virtual RProperty RLinePosition
		{
			get
			{
				if(r_LinePosition == null)
				{
					r_LinePosition = new(this, "LinePosition", -1);
					r_LinePosition.SetBelong(this.instance);
				}
				return r_LinePosition;
			}
		}

		/// <summary>
		/// System.String SourceUri
		/// </summary>
		protected RProperty r_SourceUri;
		public virtual RProperty RSourceUri
		{
			get
			{
				if(r_SourceUri == null)
				{
					r_SourceUri = new(this, "SourceUri", -1);
					r_SourceUri.SetBelong(this.instance);
				}
				return r_SourceUri;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObject Parent
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObject r_Parent;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObject RParent
		{
			get
			{
				if(r_Parent == null)
				{
					r_Parent = new(this, "Parent", -1);
					r_Parent.SetBelong(this.instance);
				}
				return r_Parent;
			}
		}

		/// <summary>
		/// System.Xml.Serialization.XmlSerializerNamespaces Namespaces
		/// </summary>
		protected RSystem.RXml.RSerialization.RXmlSerializerNamespaces r_Namespaces;
		public virtual RSystem.RXml.RSerialization.RXmlSerializerNamespaces RNamespaces
		{
			get
			{
				if(r_Namespaces == null)
				{
					r_Namespaces = new(this, "Namespaces", -1);
					r_Namespaces.SetBelong(this.instance);
				}
				return r_Namespaces;
			}
		}

		/// <summary>
		/// Boolean IsProcessing
		/// </summary>
		protected RProperty r_IsProcessing;
		public virtual RProperty RIsProcessing
		{
			get
			{
				if(r_IsProcessing == null)
				{
					r_IsProcessing = new(this, "IsProcessing", -1);
					r_IsProcessing.SetBelong(this.instance);
				}
				return r_IsProcessing;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_RGetBuiltInSimpleType_XmlQualifiedName;
		public static RMethod RGetBuiltInSimpleType_XmlQualifiedName
		{
			get
			{
				if(r_RGetBuiltInSimpleType_XmlQualifiedName == null)
				{
					r_RGetBuiltInSimpleType_XmlQualifiedName = new(typeof(System.Xml.Schema.XmlSchemaType), "GetBuiltInSimpleType", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetBuiltInSimpleType_XmlQualifiedName.SetBelong(null);
				}
				return r_RGetBuiltInSimpleType_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode)
		/// </summary>
		protected static RMethod r_RGetBuiltInSimpleType_XmlTypeCode;
		public static RMethod RGetBuiltInSimpleType_XmlTypeCode
		{
			get
			{
				if(r_RGetBuiltInSimpleType_XmlTypeCode == null)
				{
					r_RGetBuiltInSimpleType_XmlTypeCode = new(typeof(System.Xml.Schema.XmlSchemaType), "GetBuiltInSimpleType", 0, typeof(System.Xml.Schema.XmlTypeCode));
					r_RGetBuiltInSimpleType_XmlTypeCode.SetBelong(null);
				}
				return r_RGetBuiltInSimpleType_XmlTypeCode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.Schema.XmlTypeCode)
		/// </summary>
		protected static RMethod r_RGetBuiltInComplexType_XmlTypeCode;
		public static RMethod RGetBuiltInComplexType_XmlTypeCode
		{
			get
			{
				if(r_RGetBuiltInComplexType_XmlTypeCode == null)
				{
					r_RGetBuiltInComplexType_XmlTypeCode = new(typeof(System.Xml.Schema.XmlSchemaType), "GetBuiltInComplexType", 0, typeof(System.Xml.Schema.XmlTypeCode));
					r_RGetBuiltInComplexType_XmlTypeCode.SetBelong(null);
				}
				return r_RGetBuiltInComplexType_XmlTypeCode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_RGetBuiltInComplexType_XmlQualifiedName;
		public static RMethod RGetBuiltInComplexType_XmlQualifiedName
		{
			get
			{
				if(r_RGetBuiltInComplexType_XmlQualifiedName == null)
				{
					r_RGetBuiltInComplexType_XmlQualifiedName = new(typeof(System.Xml.Schema.XmlSchemaType), "GetBuiltInComplexType", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetBuiltInComplexType_XmlQualifiedName.SetBelong(null);
				}
				return r_RGetBuiltInComplexType_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader Validate(System.Xml.XmlReader, System.Xml.XmlResolver, System.Xml.Schema.XmlSchemaSet, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler;
		public virtual RMethod RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler
		{
			get
			{
				if(r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler == null)
				{
					r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler = new(this, "Validate", 0, typeof(System.Xml.XmlReader), typeof(System.Xml.XmlResolver), typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void SetQualifiedName(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RSetQualifiedName_XmlQualifiedName;
		public virtual RMethod RSetQualifiedName_XmlQualifiedName
		{
			get
			{
				if(r_RSetQualifiedName_XmlQualifiedName == null)
				{
					r_RSetQualifiedName_XmlQualifiedName = new(this, "SetQualifiedName", 0, typeof(System.Xml.XmlQualifiedName));
					r_RSetQualifiedName_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RSetQualifiedName_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod)
		/// </summary>
		protected RMethod r_RSetFinalResolved_XmlSchemaDerivationMethod;
		public virtual RMethod RSetFinalResolved_XmlSchemaDerivationMethod
		{
			get
			{
				if(r_RSetFinalResolved_XmlSchemaDerivationMethod == null)
				{
					r_RSetFinalResolved_XmlSchemaDerivationMethod = new(this, "SetFinalResolved", 0, typeof(System.Xml.Schema.XmlSchemaDerivationMethod));
					r_RSetFinalResolved_XmlSchemaDerivationMethod.SetBelong(this.instance);
				}
				return r_RSetFinalResolved_XmlSchemaDerivationMethod;
			}
		}

		/// <summary>
		/// Void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RSetBaseSchemaType_XmlSchemaType;
		public virtual RMethod RSetBaseSchemaType_XmlSchemaType
		{
			get
			{
				if(r_RSetBaseSchemaType_XmlSchemaType == null)
				{
					r_RSetBaseSchemaType_XmlSchemaType = new(this, "SetBaseSchemaType", 0, typeof(System.Xml.Schema.XmlSchemaType));
					r_RSetBaseSchemaType_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RSetBaseSchemaType_XmlSchemaType;
			}
		}

		/// <summary>
		/// Void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod)
		/// </summary>
		protected RMethod r_RSetDerivedBy_XmlSchemaDerivationMethod;
		public virtual RMethod RSetDerivedBy_XmlSchemaDerivationMethod
		{
			get
			{
				if(r_RSetDerivedBy_XmlSchemaDerivationMethod == null)
				{
					r_RSetDerivedBy_XmlSchemaDerivationMethod = new(this, "SetDerivedBy", 0, typeof(System.Xml.Schema.XmlSchemaDerivationMethod));
					r_RSetDerivedBy_XmlSchemaDerivationMethod.SetBelong(this.instance);
				}
				return r_RSetDerivedBy_XmlSchemaDerivationMethod;
			}
		}

		/// <summary>
		/// Void SetDatatype(System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RSetDatatype_XmlSchemaDatatype;
		public virtual RMethod RSetDatatype_XmlSchemaDatatype
		{
			get
			{
				if(r_RSetDatatype_XmlSchemaDatatype == null)
				{
					r_RSetDatatype_XmlSchemaDatatype = new(this, "SetDatatype", 0, typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RSetDatatype_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RSetDatatype_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// Void SetContentType(System.Xml.Schema.XmlSchemaContentType)
		/// </summary>
		protected RMethod r_RSetContentType_XmlSchemaContentType;
		public virtual RMethod RSetContentType_XmlSchemaContentType
		{
			get
			{
				if(r_RSetContentType_XmlSchemaContentType == null)
				{
					r_RSetContentType_XmlSchemaContentType = new(this, "SetContentType", 0, typeof(System.Xml.Schema.XmlSchemaContentType));
					r_RSetContentType_XmlSchemaContentType.SetBelong(this.instance);
				}
				return r_RSetContentType_XmlSchemaContentType;
			}
		}

		/// <summary>
		/// Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaType, System.Xml.Schema.XmlSchemaType, System.Xml.Schema.XmlSchemaDerivationMethod)
		/// </summary>
		protected static RMethod r_RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod;
		public static RMethod RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod
		{
			get
			{
				if(r_RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod == null)
				{
					r_RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod = new(typeof(System.Xml.Schema.XmlSchemaType), "IsDerivedFrom", 0, typeof(System.Xml.Schema.XmlSchemaType), typeof(System.Xml.Schema.XmlSchemaType), typeof(System.Xml.Schema.XmlSchemaDerivationMethod));
					r_RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod.SetBelong(null);
				}
				return r_RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod;
			}
		}

		/// <summary>
		/// Boolean IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype, System.Xml.Schema.XmlSchemaDatatype, System.Xml.Schema.XmlSchemaDerivationMethod)
		/// </summary>
		protected static RMethod r_RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod;
		public static RMethod RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod
		{
			get
			{
				if(r_RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod == null)
				{
					r_RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod = new(typeof(System.Xml.Schema.XmlSchemaType), "IsDerivedFromDatatype", 0, typeof(System.Xml.Schema.XmlSchemaDatatype), typeof(System.Xml.Schema.XmlSchemaDatatype), typeof(System.Xml.Schema.XmlSchemaDerivationMethod));
					r_RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod.SetBelong(null);
				}
				return r_RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod;
			}
		}

		/// <summary>
		/// Void SetUnhandledAttributes(System.Xml.XmlAttribute[])
		/// </summary>
		protected RMethod r_RSetUnhandledAttributes_XmlAttributeArray;
		public virtual RMethod RSetUnhandledAttributes_XmlAttributeArray
		{
			get
			{
				if(r_RSetUnhandledAttributes_XmlAttributeArray == null)
				{
					r_RSetUnhandledAttributes_XmlAttributeArray = new(this, "SetUnhandledAttributes", 0, typeof(System.Xml.XmlAttribute).MakeArrayType());
					r_RSetUnhandledAttributes_XmlAttributeArray.SetBelong(this.instance);
				}
				return r_RSetUnhandledAttributes_XmlAttributeArray;
			}
		}

		/// <summary>
		/// Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation)
		/// </summary>
		protected RMethod r_RAddAnnotation_XmlSchemaAnnotation;
		public virtual RMethod RAddAnnotation_XmlSchemaAnnotation
		{
			get
			{
				if(r_RAddAnnotation_XmlSchemaAnnotation == null)
				{
					r_RAddAnnotation_XmlSchemaAnnotation = new(this, "AddAnnotation", 0, typeof(System.Xml.Schema.XmlSchemaAnnotation));
					r_RAddAnnotation_XmlSchemaAnnotation.SetBelong(this.instance);
				}
				return r_RAddAnnotation_XmlSchemaAnnotation;
			}
		}

		/// <summary>
		/// Void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection, System.Object)
		/// </summary>
		protected RMethod r_ROnAdd_XmlSchemaObjectCollection_Object;
		public virtual RMethod ROnAdd_XmlSchemaObjectCollection_Object
		{
			get
			{
				if(r_ROnAdd_XmlSchemaObjectCollection_Object == null)
				{
					r_ROnAdd_XmlSchemaObjectCollection_Object = new(this, "OnAdd", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Object));
					r_ROnAdd_XmlSchemaObjectCollection_Object.SetBelong(this.instance);
				}
				return r_ROnAdd_XmlSchemaObjectCollection_Object;
			}
		}

		/// <summary>
		/// Void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection, System.Object)
		/// </summary>
		protected RMethod r_ROnRemove_XmlSchemaObjectCollection_Object;
		public virtual RMethod ROnRemove_XmlSchemaObjectCollection_Object
		{
			get
			{
				if(r_ROnRemove_XmlSchemaObjectCollection_Object == null)
				{
					r_ROnRemove_XmlSchemaObjectCollection_Object = new(this, "OnRemove", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Object));
					r_ROnRemove_XmlSchemaObjectCollection_Object.SetBelong(this.instance);
				}
				return r_ROnRemove_XmlSchemaObjectCollection_Object;
			}
		}

		/// <summary>
		/// Void OnClear(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected RMethod r_ROnClear_XmlSchemaObjectCollection;
		public virtual RMethod ROnClear_XmlSchemaObjectCollection
		{
			get
			{
				if(r_ROnClear_XmlSchemaObjectCollection == null)
				{
					r_ROnClear_XmlSchemaObjectCollection = new(this, "OnClear", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_ROnClear_XmlSchemaObjectCollection.SetBelong(this.instance);
				}
				return r_ROnClear_XmlSchemaObjectCollection;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObject Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
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


        public RXmlSchemaType() : base("System.Xml.Schema.XmlSchemaType")
        {
        }

        public RXmlSchemaType(System.Object instance) : base("System.Xml.Schema.XmlSchemaType")
		{
            SetInstance(instance);
		}

        public RXmlSchemaType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName  @qualifiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifiedName};
            var ___result = RGetBuiltInSimpleType_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RGetBuiltInSimpleType_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RGetBuiltInComplexType_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaComplexType)___result;
        }


        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName  @qualifiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifiedName};
            var ___result = RGetBuiltInComplexType_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaComplexType)___result;
        }


        public virtual System.Xml.XmlReader Validate(System.Xml.XmlReader  @reader, System.Xml.XmlResolver  @resolver, System.Xml.Schema.XmlSchemaSet  @schemaSet, System.Xml.Schema.ValidationEventHandler  @valEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @resolver, @schemaSet, @valEventHandler};
            var ___result = RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void SetQualifiedName(System.Xml.XmlQualifiedName  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetQualifiedName_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetFinalResolved_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetBaseSchemaType_XmlSchemaType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetDerivedBy_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDatatype(System.Xml.Schema.XmlSchemaDatatype  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetDatatype_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetContentType(System.Xml.Schema.XmlSchemaContentType  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetContentType_XmlSchemaContentType.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaType  @derivedType, System.Xml.Schema.XmlSchemaType  @baseType, System.Xml.Schema.XmlSchemaDerivationMethod  @except)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@derivedType, @baseType, @except};
            var ___result = RIsDerivedFrom_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype  @derivedDataType, System.Xml.Schema.XmlSchemaDatatype  @baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod  @except)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@derivedDataType, @baseDataType, @except};
            var ___result = RIsDerivedFromDatatype_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetUnhandledAttributes(System.Xml.XmlAttribute[]  @moreAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moreAttributes};
            var ___result = RSetUnhandledAttributes_XmlAttributeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation  @annotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@annotation};
            var ___result = RAddAnnotation_XmlSchemaAnnotation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection  @container, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @item};
            var ___result = ROnAdd_XmlSchemaObjectCollection_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection  @container, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @item};
            var ___result = ROnRemove_XmlSchemaObjectCollection_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnClear(System.Xml.Schema.XmlSchemaObjectCollection  @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container};
            var ___result = ROnClear_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchemaObject Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObject)___result;
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
