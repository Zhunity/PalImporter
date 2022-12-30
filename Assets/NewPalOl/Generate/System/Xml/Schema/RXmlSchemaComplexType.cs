using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaComplexType
	/// </summary>
    public partial class RXmlSchemaComplexType : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod block
		/// </summary>
		protected RField r_block;
		public virtual RField Rblock
		{
			get
			{
				if(r_block == null)
				{
					r_block = new(this, "block");
					r_block.SetBelong(this.instance);
				}
				return r_block;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentModel contentModel
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaContentModel r_contentModel;
		public virtual RSystem.RXml.RSchema.RXmlSchemaContentModel RcontentModel
		{
			get
			{
				if(r_contentModel == null)
				{
					r_contentModel = new(this, "contentModel");
					r_contentModel.SetBelong(this.instance);
				}
				return r_contentModel;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaParticle particle
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaParticle r_particle;
		public virtual RSystem.RXml.RSchema.RXmlSchemaParticle Rparticle
		{
			get
			{
				if(r_particle == null)
				{
					r_particle = new(this, "particle");
					r_particle.SetBelong(this.instance);
				}
				return r_particle;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection attributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_attributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection Rattributes
		{
			get
			{
				if(r_attributes == null)
				{
					r_attributes = new(this, "attributes");
					r_attributes.SetBelong(this.instance);
				}
				return r_attributes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnyAttribute r_anyAttribute;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnyAttribute RanyAttribute
		{
			get
			{
				if(r_anyAttribute == null)
				{
					r_anyAttribute = new(this, "anyAttribute");
					r_anyAttribute.SetBelong(this.instance);
				}
				return r_anyAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaParticle contentTypeParticle
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaParticle r_contentTypeParticle;
		public virtual RSystem.RXml.RSchema.RXmlSchemaParticle RcontentTypeParticle
		{
			get
			{
				if(r_contentTypeParticle == null)
				{
					r_contentTypeParticle = new(this, "contentTypeParticle");
					r_contentTypeParticle.SetBelong(this.instance);
				}
				return r_contentTypeParticle;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod blockResolved
		/// </summary>
		protected RField r_blockResolved;
		public virtual RField RblockResolved
		{
			get
			{
				if(r_blockResolved == null)
				{
					r_blockResolved = new(this, "blockResolved");
					r_blockResolved.SetBelong(this.instance);
				}
				return r_blockResolved;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable localElements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_localElements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RlocalElements
		{
			get
			{
				if(r_localElements == null)
				{
					r_localElements = new(this, "localElements");
					r_localElements.SetBelong(this.instance);
				}
				return r_localElements;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable attributeUses
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_attributeUses;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RattributeUses
		{
			get
			{
				if(r_attributeUses == null)
				{
					r_attributeUses = new(this, "attributeUses");
					r_attributeUses.SetBelong(this.instance);
				}
				return r_attributeUses;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnyAttribute r_attributeWildcard;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnyAttribute RattributeWildcard
		{
			get
			{
				if(r_attributeWildcard == null)
				{
					r_attributeWildcard = new(this, "attributeWildcard");
					r_attributeWildcard.SetBelong(this.instance);
				}
				return r_attributeWildcard;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType anyTypeLax
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_anyTypeLax;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RanyTypeLax
		{
			get
			{
				if(r_anyTypeLax == null)
				{
					r_anyTypeLax = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "anyTypeLax");
					r_anyTypeLax.SetBelong(null);
				}
				return r_anyTypeLax;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType anyTypeSkip
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_anyTypeSkip;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RanyTypeSkip
		{
			get
			{
				if(r_anyTypeSkip == null)
				{
					r_anyTypeSkip = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "anyTypeSkip");
					r_anyTypeSkip.SetBelong(null);
				}
				return r_anyTypeSkip;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType untypedAnyType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_untypedAnyType;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RuntypedAnyType
		{
			get
			{
				if(r_untypedAnyType == null)
				{
					r_untypedAnyType = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "untypedAnyType");
					r_untypedAnyType.SetBelong(null);
				}
				return r_untypedAnyType;
			}
		}

		/// <summary>
		/// System.Byte pvFlags
		/// </summary>
		protected RField r_pvFlags;
		public virtual RField RpvFlags
		{
			get
			{
				if(r_pvFlags == null)
				{
					r_pvFlags = new(this, "pvFlags");
					r_pvFlags.SetBelong(this.instance);
				}
				return r_pvFlags;
			}
		}

		/// <summary>
		/// System.Byte wildCardMask
		/// </summary>
		protected static RField r_wildCardMask;
		public static RField RwildCardMask
		{
			get
			{
				if(r_wildCardMask == null)
				{
					r_wildCardMask = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "wildCardMask");
					r_wildCardMask.SetBelong(null);
				}
				return r_wildCardMask;
			}
		}

		/// <summary>
		/// System.Byte isMixedMask
		/// </summary>
		protected static RField r_isMixedMask;
		public static RField RisMixedMask
		{
			get
			{
				if(r_isMixedMask == null)
				{
					r_isMixedMask = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "isMixedMask");
					r_isMixedMask.SetBelong(null);
				}
				return r_isMixedMask;
			}
		}

		/// <summary>
		/// System.Byte isAbstractMask
		/// </summary>
		protected static RField r_isAbstractMask;
		public static RField RisAbstractMask
		{
			get
			{
				if(r_isAbstractMask == null)
				{
					r_isAbstractMask = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "isAbstractMask");
					r_isAbstractMask.SetBelong(null);
				}
				return r_isAbstractMask;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType AnyType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_AnyType;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RAnyType
		{
			get
			{
				if(r_AnyType == null)
				{
					r_AnyType = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "AnyType", -1);
					r_AnyType.SetBelong(null);
				}
				return r_AnyType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType UntypedAnyType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_UntypedAnyType;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RUntypedAnyType
		{
			get
			{
				if(r_UntypedAnyType == null)
				{
					r_UntypedAnyType = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "UntypedAnyType", -1);
					r_UntypedAnyType.SetBelong(null);
				}
				return r_UntypedAnyType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaComplexType AnyTypeSkip
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaComplexType r_AnyTypeSkip;
		public static RSystem.RXml.RSchema.RXmlSchemaComplexType RAnyTypeSkip
		{
			get
			{
				if(r_AnyTypeSkip == null)
				{
					r_AnyTypeSkip = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "AnyTypeSkip", -1);
					r_AnyTypeSkip.SetBelong(null);
				}
				return r_AnyTypeSkip;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator AnyTypeContentValidator
		/// </summary>
		protected static RSystem.RXml.RSchema.RContentValidator r_AnyTypeContentValidator;
		public static RSystem.RXml.RSchema.RContentValidator RAnyTypeContentValidator
		{
			get
			{
				if(r_AnyTypeContentValidator == null)
				{
					r_AnyTypeContentValidator = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "AnyTypeContentValidator", -1);
					r_AnyTypeContentValidator.SetBelong(null);
				}
				return r_AnyTypeContentValidator;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected RProperty r_IsAbstract;
		public virtual RProperty RIsAbstract
		{
			get
			{
				if(r_IsAbstract == null)
				{
					r_IsAbstract = new(this, "IsAbstract", -1);
					r_IsAbstract.SetBelong(this.instance);
				}
				return r_IsAbstract;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod Block
		/// </summary>
		protected RProperty r_Block;
		public virtual RProperty RBlock
		{
			get
			{
				if(r_Block == null)
				{
					r_Block = new(this, "Block", -1);
					r_Block.SetBelong(this.instance);
				}
				return r_Block;
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
		/// System.Xml.Schema.XmlSchemaContentModel ContentModel
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaContentModel r_ContentModel;
		public virtual RSystem.RXml.RSchema.RXmlSchemaContentModel RContentModel
		{
			get
			{
				if(r_ContentModel == null)
				{
					r_ContentModel = new(this, "ContentModel", -1);
					r_ContentModel.SetBelong(this.instance);
				}
				return r_ContentModel;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaParticle Particle
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaParticle r_Particle;
		public virtual RSystem.RXml.RSchema.RXmlSchemaParticle RParticle
		{
			get
			{
				if(r_Particle == null)
				{
					r_Particle = new(this, "Particle", -1);
					r_Particle.SetBelong(this.instance);
				}
				return r_Particle;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection Attributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_Attributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnyAttribute r_AnyAttribute;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnyAttribute RAnyAttribute
		{
			get
			{
				if(r_AnyAttribute == null)
				{
					r_AnyAttribute = new(this, "AnyAttribute", -1);
					r_AnyAttribute.SetBelong(this.instance);
				}
				return r_AnyAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentType ContentType
		/// </summary>
		protected RProperty r_ContentType;
		public virtual RProperty RContentType
		{
			get
			{
				if(r_ContentType == null)
				{
					r_ContentType = new(this, "ContentType", -1);
					r_ContentType.SetBelong(this.instance);
				}
				return r_ContentType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaParticle ContentTypeParticle
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaParticle r_ContentTypeParticle;
		public virtual RSystem.RXml.RSchema.RXmlSchemaParticle RContentTypeParticle
		{
			get
			{
				if(r_ContentTypeParticle == null)
				{
					r_ContentTypeParticle = new(this, "ContentTypeParticle", -1);
					r_ContentTypeParticle.SetBelong(this.instance);
				}
				return r_ContentTypeParticle;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod BlockResolved
		/// </summary>
		protected RProperty r_BlockResolved;
		public virtual RProperty RBlockResolved
		{
			get
			{
				if(r_BlockResolved == null)
				{
					r_BlockResolved = new(this, "BlockResolved", -1);
					r_BlockResolved.SetBelong(this.instance);
				}
				return r_BlockResolved;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable AttributeUses
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_AttributeUses;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RAttributeUses
		{
			get
			{
				if(r_AttributeUses == null)
				{
					r_AttributeUses = new(this, "AttributeUses", -1);
					r_AttributeUses.SetBelong(this.instance);
				}
				return r_AttributeUses;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute AttributeWildcard
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnyAttribute r_AttributeWildcard;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnyAttribute RAttributeWildcard
		{
			get
			{
				if(r_AttributeWildcard == null)
				{
					r_AttributeWildcard = new(this, "AttributeWildcard", -1);
					r_AttributeWildcard.SetBelong(this.instance);
				}
				return r_AttributeWildcard;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable LocalElements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_LocalElements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RLocalElements
		{
			get
			{
				if(r_LocalElements == null)
				{
					r_LocalElements = new(this, "LocalElements", -1);
					r_LocalElements.SetBelong(this.instance);
				}
				return r_LocalElements;
			}
		}

		/// <summary>
		/// Boolean HasWildCard
		/// </summary>
		protected RProperty r_HasWildCard;
		public virtual RProperty RHasWildCard
		{
			get
			{
				if(r_HasWildCard == null)
				{
					r_HasWildCard = new(this, "HasWildCard", -1);
					r_HasWildCard.SetBelong(this.instance);
				}
				return r_HasWildCard;
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
		/// System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing)
		/// </summary>
		protected static RMethod r_RCreateAnyType_XmlSchemaContentProcessing;
		public static RMethod RCreateAnyType_XmlSchemaContentProcessing
		{
			get
			{
				if(r_RCreateAnyType_XmlSchemaContentProcessing == null)
				{
					r_RCreateAnyType_XmlSchemaContentProcessing = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "CreateAnyType", 0, typeof(System.Xml.Schema.XmlSchemaContentProcessing));
					r_RCreateAnyType_XmlSchemaContentProcessing.SetBelong(null);
				}
				return r_RCreateAnyType_XmlSchemaContentProcessing;
			}
		}

		/// <summary>
		/// Void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle)
		/// </summary>
		protected RMethod r_RSetContentTypeParticle_XmlSchemaParticle;
		public virtual RMethod RSetContentTypeParticle_XmlSchemaParticle
		{
			get
			{
				if(r_RSetContentTypeParticle_XmlSchemaParticle == null)
				{
					r_RSetContentTypeParticle_XmlSchemaParticle = new(this, "SetContentTypeParticle", 0, typeof(System.Xml.Schema.XmlSchemaParticle));
					r_RSetContentTypeParticle_XmlSchemaParticle.SetBelong(this.instance);
				}
				return r_RSetContentTypeParticle_XmlSchemaParticle;
			}
		}

		/// <summary>
		/// Void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod)
		/// </summary>
		protected RMethod r_RSetBlockResolved_XmlSchemaDerivationMethod;
		public virtual RMethod RSetBlockResolved_XmlSchemaDerivationMethod
		{
			get
			{
				if(r_RSetBlockResolved_XmlSchemaDerivationMethod == null)
				{
					r_RSetBlockResolved_XmlSchemaDerivationMethod = new(this, "SetBlockResolved", 0, typeof(System.Xml.Schema.XmlSchemaDerivationMethod));
					r_RSetBlockResolved_XmlSchemaDerivationMethod.SetBelong(this.instance);
				}
				return r_RSetBlockResolved_XmlSchemaDerivationMethod;
			}
		}

		/// <summary>
		/// Void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute)
		/// </summary>
		protected RMethod r_RSetAttributeWildcard_XmlSchemaAnyAttribute;
		public virtual RMethod RSetAttributeWildcard_XmlSchemaAnyAttribute
		{
			get
			{
				if(r_RSetAttributeWildcard_XmlSchemaAnyAttribute == null)
				{
					r_RSetAttributeWildcard_XmlSchemaAnyAttribute = new(this, "SetAttributeWildcard", 0, typeof(System.Xml.Schema.XmlSchemaAnyAttribute));
					r_RSetAttributeWildcard_XmlSchemaAnyAttribute.SetBelong(this.instance);
				}
				return r_RSetAttributeWildcard_XmlSchemaAnyAttribute;
			}
		}

		/// <summary>
		/// Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected RMethod r_RSetAttributes_XmlSchemaObjectCollection;
		public virtual RMethod RSetAttributes_XmlSchemaObjectCollection
		{
			get
			{
				if(r_RSetAttributes_XmlSchemaObjectCollection == null)
				{
					r_RSetAttributes_XmlSchemaObjectCollection = new(this, "SetAttributes", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_RSetAttributes_XmlSchemaObjectCollection.SetBelong(this.instance);
				}
				return r_RSetAttributes_XmlSchemaObjectCollection;
			}
		}

		/// <summary>
		/// Boolean ContainsIdAttribute(Boolean)
		/// </summary>
		protected RMethod r_RContainsIdAttribute_Boolean;
		public virtual RMethod RContainsIdAttribute_Boolean
		{
			get
			{
				if(r_RContainsIdAttribute_Boolean == null)
				{
					r_RContainsIdAttribute_Boolean = new(this, "ContainsIdAttribute", 0, typeof(System.Boolean));
					r_RContainsIdAttribute_Boolean.SetBelong(this.instance);
				}
				return r_RContainsIdAttribute_Boolean;
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
		/// System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RClone_XmlSchema;
		public virtual RMethod RClone_XmlSchema
		{
			get
			{
				if(r_RClone_XmlSchema == null)
				{
					r_RClone_XmlSchema = new(this, "Clone", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RClone_XmlSchema.SetBelong(this.instance);
				}
				return r_RClone_XmlSchema;
			}
		}

		/// <summary>
		/// Void ClearCompiledState()
		/// </summary>
		protected RMethod r_RClearCompiledState;
		public virtual RMethod RClearCompiledState
		{
			get
			{
				if(r_RClearCompiledState == null)
				{
					r_RClearCompiledState = new(this, "ClearCompiledState", 0);
					r_RClearCompiledState.SetBelong(this.instance);
				}
				return r_RClearCompiledState;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected static RMethod r_RCloneAttributes_XmlSchemaObjectCollection;
		public static RMethod RCloneAttributes_XmlSchemaObjectCollection
		{
			get
			{
				if(r_RCloneAttributes_XmlSchemaObjectCollection == null)
				{
					r_RCloneAttributes_XmlSchemaObjectCollection = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "CloneAttributes", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_RCloneAttributes_XmlSchemaObjectCollection.SetBelong(null);
				}
				return r_RCloneAttributes_XmlSchemaObjectCollection;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection, System.Xml.Schema.XmlSchema)
		/// </summary>
		protected static RMethod r_RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema;
		public static RMethod RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema
		{
			get
			{
				if(r_RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema == null)
				{
					r_RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "CloneGroupBaseParticles", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Xml.Schema.XmlSchema));
					r_RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema.SetBelong(null);
				}
				return r_RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle, System.Xml.Schema.XmlSchema)
		/// </summary>
		protected static RMethod r_RCloneParticle_XmlSchemaParticle_XmlSchema;
		public static RMethod RCloneParticle_XmlSchemaParticle_XmlSchema
		{
			get
			{
				if(r_RCloneParticle_XmlSchemaParticle_XmlSchema == null)
				{
					r_RCloneParticle_XmlSchemaParticle_XmlSchema = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "CloneParticle", 0, typeof(System.Xml.Schema.XmlSchemaParticle), typeof(System.Xml.Schema.XmlSchema));
					r_RCloneParticle_XmlSchemaParticle_XmlSchema.SetBelong(null);
				}
				return r_RCloneParticle_XmlSchemaParticle_XmlSchema;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema, System.Xml.Schema.XmlSchemaElement)
		/// </summary>
		protected static RMethod r_RGetResolvedElementForm_XmlSchema_XmlSchemaElement;
		public static RMethod RGetResolvedElementForm_XmlSchema_XmlSchemaElement
		{
			get
			{
				if(r_RGetResolvedElementForm_XmlSchema_XmlSchemaElement == null)
				{
					r_RGetResolvedElementForm_XmlSchema_XmlSchemaElement = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "GetResolvedElementForm", 0, typeof(System.Xml.Schema.XmlSchema), typeof(System.Xml.Schema.XmlSchemaElement));
					r_RGetResolvedElementForm_XmlSchema_XmlSchemaElement.SetBelong(null);
				}
				return r_RGetResolvedElementForm_XmlSchema_XmlSchemaElement;
			}
		}

		/// <summary>
		/// Boolean HasParticleRef(System.Xml.Schema.XmlSchemaParticle, System.Xml.Schema.XmlSchema)
		/// </summary>
		protected static RMethod r_RHasParticleRef_XmlSchemaParticle_XmlSchema;
		public static RMethod RHasParticleRef_XmlSchemaParticle_XmlSchema
		{
			get
			{
				if(r_RHasParticleRef_XmlSchemaParticle_XmlSchema == null)
				{
					r_RHasParticleRef_XmlSchemaParticle_XmlSchema = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "HasParticleRef", 0, typeof(System.Xml.Schema.XmlSchemaParticle), typeof(System.Xml.Schema.XmlSchema));
					r_RHasParticleRef_XmlSchemaParticle_XmlSchema.SetBelong(null);
				}
				return r_RHasParticleRef_XmlSchemaParticle_XmlSchema;
			}
		}

		/// <summary>
		/// Boolean HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected static RMethod r_RHasAttributeQNameRef_XmlSchemaObjectCollection;
		public static RMethod RHasAttributeQNameRef_XmlSchemaObjectCollection
		{
			get
			{
				if(r_RHasAttributeQNameRef_XmlSchemaObjectCollection == null)
				{
					r_RHasAttributeQNameRef_XmlSchemaObjectCollection = new(typeof(System.Xml.Schema.XmlSchemaComplexType), "HasAttributeQNameRef", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_RHasAttributeQNameRef_XmlSchemaObjectCollection.SetBelong(null);
				}
				return r_RHasAttributeQNameRef_XmlSchemaObjectCollection;
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


        public RXmlSchemaComplexType() : base("System.Xml.Schema.XmlSchemaComplexType")
        {
        }

        public RXmlSchemaComplexType(System.Object instance) : base("System.Xml.Schema.XmlSchemaComplexType")
		{
            SetInstance(instance);
		}

        public RXmlSchemaComplexType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaComplexType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing  @processContents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@processContents};
            var ___result = RCreateAnyType_XmlSchemaContentProcessing.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaComplexType)___result;
        }


        public virtual void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetContentTypeParticle_XmlSchemaParticle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetBlockResolved_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAttributeWildcard_XmlSchemaAnyAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection  @newAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newAttributes};
            var ___result = RSetAttributes_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsIdAttribute(System.Boolean  @findAll)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@findAll};
            var ___result = RContainsIdAttribute_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaObject Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObject)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema  @parentSchema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentSchema};
            var ___result = RClone_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObject)___result;
        }


        public virtual void ClearCompiledState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCompiledState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RCloneAttributes_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObjectCollection)___result;
        }


        public static System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection  @groupBaseParticles, System.Xml.Schema.XmlSchema  @parentSchema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupBaseParticles, @parentSchema};
            var ___result = RCloneGroupBaseParticles_XmlSchemaObjectCollection_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObjectCollection)___result;
        }


        public static System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle  @particle, System.Xml.Schema.XmlSchema  @parentSchema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@particle, @parentSchema};
            var ___result = RCloneParticle_XmlSchemaParticle_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaParticle)___result;
        }


        public static System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema  @parentSchema, System.Xml.Schema.XmlSchemaElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentSchema, @element};
            var ___result = RGetResolvedElementForm_XmlSchema_XmlSchemaElement.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaForm)___result;
        }


        public static System.Boolean HasParticleRef(System.Xml.Schema.XmlSchemaParticle  @particle, System.Xml.Schema.XmlSchema  @parentSchema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@particle, @parentSchema};
            var ___result = RHasParticleRef_XmlSchemaParticle_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RHasAttributeQNameRef_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
