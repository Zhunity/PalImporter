using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaElement
	/// </summary>
    public partial class RXmlSchemaElement : RMember //
    {

		/// <summary>
		/// System.Boolean isAbstract
		/// </summary>
		protected RField r_isAbstract;
		public virtual RField RisAbstract
		{
			get
			{
				if(r_isAbstract == null)
				{
					r_isAbstract = new(this, "isAbstract");
					r_isAbstract.SetBelong(this.instance);
				}
				return r_isAbstract;
			}
		}

		/// <summary>
		/// System.Boolean hasAbstractAttribute
		/// </summary>
		protected RField r_hasAbstractAttribute;
		public virtual RField RhasAbstractAttribute
		{
			get
			{
				if(r_hasAbstractAttribute == null)
				{
					r_hasAbstractAttribute = new(this, "hasAbstractAttribute");
					r_hasAbstractAttribute.SetBelong(this.instance);
				}
				return r_hasAbstractAttribute;
			}
		}

		/// <summary>
		/// System.Boolean isNillable
		/// </summary>
		protected RField r_isNillable;
		public virtual RField RisNillable
		{
			get
			{
				if(r_isNillable == null)
				{
					r_isNillable = new(this, "isNillable");
					r_isNillable.SetBelong(this.instance);
				}
				return r_isNillable;
			}
		}

		/// <summary>
		/// System.Boolean hasNillableAttribute
		/// </summary>
		protected RField r_hasNillableAttribute;
		public virtual RField RhasNillableAttribute
		{
			get
			{
				if(r_hasNillableAttribute == null)
				{
					r_hasNillableAttribute = new(this, "hasNillableAttribute");
					r_hasNillableAttribute.SetBelong(this.instance);
				}
				return r_hasNillableAttribute;
			}
		}

		/// <summary>
		/// System.Boolean isLocalTypeDerivationChecked
		/// </summary>
		protected RField r_isLocalTypeDerivationChecked;
		public virtual RField RisLocalTypeDerivationChecked
		{
			get
			{
				if(r_isLocalTypeDerivationChecked == null)
				{
					r_isLocalTypeDerivationChecked = new(this, "isLocalTypeDerivationChecked");
					r_isLocalTypeDerivationChecked.SetBelong(this.instance);
				}
				return r_isLocalTypeDerivationChecked;
			}
		}

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
		/// System.Xml.Schema.XmlSchemaForm form
		/// </summary>
		protected RField r_form;
		public virtual RField Rform
		{
			get
			{
				if(r_form == null)
				{
					r_form = new(this, "form");
					r_form.SetBelong(this.instance);
				}
				return r_form;
			}
		}

		/// <summary>
		/// System.String defaultValue
		/// </summary>
		protected RField r_defaultValue;
		public virtual RField RdefaultValue
		{
			get
			{
				if(r_defaultValue == null)
				{
					r_defaultValue = new(this, "defaultValue");
					r_defaultValue.SetBelong(this.instance);
				}
				return r_defaultValue;
			}
		}

		/// <summary>
		/// System.String fixedValue
		/// </summary>
		protected RField r_fixedValue;
		public virtual RField RfixedValue
		{
			get
			{
				if(r_fixedValue == null)
				{
					r_fixedValue = new(this, "fixedValue");
					r_fixedValue.SetBelong(this.instance);
				}
				return r_fixedValue;
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
		/// System.Xml.XmlQualifiedName refName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_refName;
		public virtual RSystem.RXml.RXmlQualifiedName RrefName
		{
			get
			{
				if(r_refName == null)
				{
					r_refName = new(this, "refName");
					r_refName.SetBelong(this.instance);
				}
				return r_refName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName substitutionGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_substitutionGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RsubstitutionGroup
		{
			get
			{
				if(r_substitutionGroup == null)
				{
					r_substitutionGroup = new(this, "substitutionGroup");
					r_substitutionGroup.SetBelong(this.instance);
				}
				return r_substitutionGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName typeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_typeName;
		public virtual RSystem.RXml.RXmlQualifiedName RtypeName
		{
			get
			{
				if(r_typeName == null)
				{
					r_typeName = new(this, "typeName");
					r_typeName.SetBelong(this.instance);
				}
				return r_typeName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType type
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_type;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName qualifiedName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_qualifiedName;
		public virtual RSystem.RXml.RXmlQualifiedName RqualifiedName
		{
			get
			{
				if(r_qualifiedName == null)
				{
					r_qualifiedName = new(this, "qualifiedName");
					r_qualifiedName.SetBelong(this.instance);
				}
				return r_qualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType elementType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_elementType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RelementType
		{
			get
			{
				if(r_elementType == null)
				{
					r_elementType = new(this, "elementType");
					r_elementType.SetBelong(this.instance);
				}
				return r_elementType;
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
		/// System.Xml.Schema.XmlSchemaObjectCollection constraints
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_constraints;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection Rconstraints
		{
			get
			{
				if(r_constraints == null)
				{
					r_constraints = new(this, "constraints");
					r_constraints.SetBelong(this.instance);
				}
				return r_constraints;
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
		/// System.String DefaultValue
		/// </summary>
		protected RProperty r_DefaultValue;
		public virtual RProperty RDefaultValue
		{
			get
			{
				if(r_DefaultValue == null)
				{
					r_DefaultValue = new(this, "DefaultValue", -1);
					r_DefaultValue.SetBelong(this.instance);
				}
				return r_DefaultValue;
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
		/// System.String FixedValue
		/// </summary>
		protected RProperty r_FixedValue;
		public virtual RProperty RFixedValue
		{
			get
			{
				if(r_FixedValue == null)
				{
					r_FixedValue = new(this, "FixedValue", -1);
					r_FixedValue.SetBelong(this.instance);
				}
				return r_FixedValue;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm Form
		/// </summary>
		protected RProperty r_Form;
		public virtual RProperty RForm
		{
			get
			{
				if(r_Form == null)
				{
					r_Form = new(this, "Form", -1);
					r_Form.SetBelong(this.instance);
				}
				return r_Form;
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
		/// Boolean IsNillable
		/// </summary>
		protected RProperty r_IsNillable;
		public virtual RProperty RIsNillable
		{
			get
			{
				if(r_IsNillable == null)
				{
					r_IsNillable = new(this, "IsNillable", -1);
					r_IsNillable.SetBelong(this.instance);
				}
				return r_IsNillable;
			}
		}

		/// <summary>
		/// Boolean HasNillableAttribute
		/// </summary>
		protected RProperty r_HasNillableAttribute;
		public virtual RProperty RHasNillableAttribute
		{
			get
			{
				if(r_HasNillableAttribute == null)
				{
					r_HasNillableAttribute = new(this, "HasNillableAttribute", -1);
					r_HasNillableAttribute.SetBelong(this.instance);
				}
				return r_HasNillableAttribute;
			}
		}

		/// <summary>
		/// Boolean HasAbstractAttribute
		/// </summary>
		protected RProperty r_HasAbstractAttribute;
		public virtual RProperty RHasAbstractAttribute
		{
			get
			{
				if(r_HasAbstractAttribute == null)
				{
					r_HasAbstractAttribute = new(this, "HasAbstractAttribute", -1);
					r_HasAbstractAttribute.SetBelong(this.instance);
				}
				return r_HasAbstractAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName RefName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_RefName;
		public virtual RSystem.RXml.RXmlQualifiedName RefName
		{
			get
			{
				if(r_RefName == null)
				{
					r_RefName = new(this, "RefName", -1);
					r_RefName.SetBelong(this.instance);
				}
				return r_RefName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName SubstitutionGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_SubstitutionGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RSubstitutionGroup
		{
			get
			{
				if(r_SubstitutionGroup == null)
				{
					r_SubstitutionGroup = new(this, "SubstitutionGroup", -1);
					r_SubstitutionGroup.SetBelong(this.instance);
				}
				return r_SubstitutionGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName SchemaTypeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_SchemaTypeName;
		public virtual RSystem.RXml.RXmlQualifiedName RSchemaTypeName
		{
			get
			{
				if(r_SchemaTypeName == null)
				{
					r_SchemaTypeName = new(this, "SchemaTypeName", -1);
					r_SchemaTypeName.SetBelong(this.instance);
				}
				return r_SchemaTypeName;
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
		/// System.Xml.Schema.XmlSchemaObjectCollection Constraints
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_Constraints;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection RConstraints
		{
			get
			{
				if(r_Constraints == null)
				{
					r_Constraints = new(this, "Constraints", -1);
					r_Constraints.SetBelong(this.instance);
				}
				return r_Constraints;
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
		/// System.Object ElementType
		/// </summary>
		protected RSystem.RObject r_ElementType;
		public virtual RSystem.RObject RElementType
		{
			get
			{
				if(r_ElementType == null)
				{
					r_ElementType = new(this, "ElementType", -1);
					r_ElementType.SetBelong(this.instance);
				}
				return r_ElementType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType ElementSchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_ElementSchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RElementSchemaType
		{
			get
			{
				if(r_ElementSchemaType == null)
				{
					r_ElementSchemaType = new(this, "ElementSchemaType", -1);
					r_ElementSchemaType.SetBelong(this.instance);
				}
				return r_ElementSchemaType;
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
		/// Boolean HasDefault
		/// </summary>
		protected RProperty r_HasDefault;
		public virtual RProperty RHasDefault
		{
			get
			{
				if(r_HasDefault == null)
				{
					r_HasDefault = new(this, "HasDefault", -1);
					r_HasDefault.SetBelong(this.instance);
				}
				return r_HasDefault;
			}
		}

		/// <summary>
		/// Boolean HasConstraints
		/// </summary>
		protected RProperty r_HasConstraints;
		public virtual RProperty RHasConstraints
		{
			get
			{
				if(r_HasConstraints == null)
				{
					r_HasConstraints = new(this, "HasConstraints", -1);
					r_HasConstraints.SetBelong(this.instance);
				}
				return r_HasConstraints;
			}
		}

		/// <summary>
		/// Boolean IsLocalTypeDerivationChecked
		/// </summary>
		protected RProperty r_IsLocalTypeDerivationChecked;
		public virtual RProperty RIsLocalTypeDerivationChecked
		{
			get
			{
				if(r_IsLocalTypeDerivationChecked == null)
				{
					r_IsLocalTypeDerivationChecked = new(this, "IsLocalTypeDerivationChecked", -1);
					r_IsLocalTypeDerivationChecked.SetBelong(this.instance);
				}
				return r_IsLocalTypeDerivationChecked;
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
		/// System.String NameString
		/// </summary>
		protected RProperty r_NameString;
		public virtual RProperty RNameString
		{
			get
			{
				if(r_NameString == null)
				{
					r_NameString = new(this, "NameString", -1);
					r_NameString.SetBelong(this.instance);
				}
				return r_NameString;
			}
		}

		/// <summary>
		/// System.String MinOccursString
		/// </summary>
		protected RProperty r_MinOccursString;
		public virtual RProperty RMinOccursString
		{
			get
			{
				if(r_MinOccursString == null)
				{
					r_MinOccursString = new(this, "MinOccursString", -1);
					r_MinOccursString.SetBelong(this.instance);
				}
				return r_MinOccursString;
			}
		}

		/// <summary>
		/// System.String MaxOccursString
		/// </summary>
		protected RProperty r_MaxOccursString;
		public virtual RProperty RMaxOccursString
		{
			get
			{
				if(r_MaxOccursString == null)
				{
					r_MaxOccursString = new(this, "MaxOccursString", -1);
					r_MaxOccursString.SetBelong(this.instance);
				}
				return r_MaxOccursString;
			}
		}

		/// <summary>
		/// System.Decimal MinOccurs
		/// </summary>
		protected RSystem.RDecimal r_MinOccurs;
		public virtual RSystem.RDecimal RMinOccurs
		{
			get
			{
				if(r_MinOccurs == null)
				{
					r_MinOccurs = new(this, "MinOccurs", -1);
					r_MinOccurs.SetBelong(this.instance);
				}
				return r_MinOccurs;
			}
		}

		/// <summary>
		/// System.Decimal MaxOccurs
		/// </summary>
		protected RSystem.RDecimal r_MaxOccurs;
		public virtual RSystem.RDecimal RMaxOccurs
		{
			get
			{
				if(r_MaxOccurs == null)
				{
					r_MaxOccurs = new(this, "MaxOccurs", -1);
					r_MaxOccurs.SetBelong(this.instance);
				}
				return r_MaxOccurs;
			}
		}

		/// <summary>
		/// Boolean IsEmpty
		/// </summary>
		protected RProperty r_IsEmpty;
		public virtual RProperty RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", -1);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsMultipleOccurrence
		/// </summary>
		protected RProperty r_IsMultipleOccurrence;
		public virtual RProperty RIsMultipleOccurrence
		{
			get
			{
				if(r_IsMultipleOccurrence == null)
				{
					r_IsMultipleOccurrence = new(this, "IsMultipleOccurrence", -1);
					r_IsMultipleOccurrence.SetBelong(this.instance);
				}
				return r_IsMultipleOccurrence;
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
		/// Void SetElementType(System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RSetElementType_XmlSchemaType;
		public virtual RMethod RSetElementType_XmlSchemaType
		{
			get
			{
				if(r_RSetElementType_XmlSchemaType == null)
				{
					r_RSetElementType_XmlSchemaType = new(this, "SetElementType", 0, typeof(System.Xml.Schema.XmlSchemaType));
					r_RSetElementType_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RSetElementType_XmlSchemaType;
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
		/// System.Xml.XmlQualifiedName GetQualifiedName()
		/// </summary>
		protected RMethod r_RGetQualifiedName;
		public virtual RMethod RGetQualifiedName
		{
			get
			{
				if(r_RGetQualifiedName == null)
				{
					r_RGetQualifiedName = new(this, "GetQualifiedName", 0);
					r_RGetQualifiedName.SetBelong(this.instance);
				}
				return r_RGetQualifiedName;
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


        public RXmlSchemaElement() : base("System.Xml.Schema.XmlSchemaElement")
        {
        }

        public RXmlSchemaElement(System.Object instance) : base("System.Xml.Schema.XmlSchemaElement")
		{
            SetInstance(instance);
		}

        public RXmlSchemaElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void SetElementType(System.Xml.Schema.XmlSchemaType  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetElementType_XmlSchemaType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetBlockResolved_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetFinalResolved_XmlSchemaDerivationMethod.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Xml.XmlQualifiedName GetQualifiedName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlQualifiedName)___result;
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
