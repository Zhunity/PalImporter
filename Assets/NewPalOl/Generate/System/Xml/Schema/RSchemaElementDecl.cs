using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaElementDecl
	/// </summary>
    public partial class RSchemaElementDecl : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef] attdefs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> r_attdefs;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> Rattdefs
		{
			get
			{
				if(r_attdefs == null)
				{
					r_attdefs = new(this, "attdefs");
					r_attdefs.SetBelong(this.instance);
				}
				return r_attdefs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Xml.IDtdDefaultAttributeInfo] defaultAttdefs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RXml.RIDtdDefaultAttributeInfo> r_defaultAttdefs;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RXml.RIDtdDefaultAttributeInfo> RdefaultAttdefs
		{
			get
			{
				if(r_defaultAttdefs == null)
				{
					r_defaultAttdefs = new(this, "defaultAttdefs");
					r_defaultAttdefs.SetBelong(this.instance);
				}
				return r_defaultAttdefs;
			}
		}

		/// <summary>
		/// System.Boolean isIdDeclared
		/// </summary>
		protected RField r_isIdDeclared;
		public virtual RField RisIdDeclared
		{
			get
			{
				if(r_isIdDeclared == null)
				{
					r_isIdDeclared = new(this, "isIdDeclared");
					r_isIdDeclared.SetBelong(this.instance);
				}
				return r_isIdDeclared;
			}
		}

		/// <summary>
		/// System.Boolean hasNonCDataAttribute
		/// </summary>
		protected RField r_hasNonCDataAttribute;
		public virtual RField RhasNonCDataAttribute
		{
			get
			{
				if(r_hasNonCDataAttribute == null)
				{
					r_hasNonCDataAttribute = new(this, "hasNonCDataAttribute");
					r_hasNonCDataAttribute.SetBelong(this.instance);
				}
				return r_hasNonCDataAttribute;
			}
		}

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
		/// System.Boolean hasRequiredAttribute
		/// </summary>
		protected RField r_hasRequiredAttribute;
		public virtual RField RhasRequiredAttribute
		{
			get
			{
				if(r_hasRequiredAttribute == null)
				{
					r_hasRequiredAttribute = new(this, "hasRequiredAttribute");
					r_hasRequiredAttribute.SetBelong(this.instance);
				}
				return r_hasRequiredAttribute;
			}
		}

		/// <summary>
		/// System.Boolean isNotationDeclared
		/// </summary>
		protected RField r_isNotationDeclared;
		public virtual RField RisNotationDeclared
		{
			get
			{
				if(r_isNotationDeclared == null)
				{
					r_isNotationDeclared = new(this, "isNotationDeclared");
					r_isNotationDeclared.SetBelong(this.instance);
				}
				return r_isNotationDeclared;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName] prohibitedAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RXmlQualifiedName> r_prohibitedAttributes;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RXmlQualifiedName> RprohibitedAttributes
		{
			get
			{
				if(r_prohibitedAttributes == null)
				{
					r_prohibitedAttributes = new(this, "prohibitedAttributes");
					r_prohibitedAttributes.SetBelong(this.instance);
				}
				return r_prohibitedAttributes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator contentValidator
		/// </summary>
		protected RSystem.RXml.RSchema.RContentValidator r_contentValidator;
		public virtual RSystem.RXml.RSchema.RContentValidator RcontentValidator
		{
			get
			{
				if(r_contentValidator == null)
				{
					r_contentValidator = new(this, "contentValidator");
					r_contentValidator.SetBelong(this.instance);
				}
				return r_contentValidator;
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
		/// System.Xml.Schema.CompiledIdentityConstraint[] constraints
		/// </summary>
		protected RFieldArray<RSystem.RXml.RSchema.RCompiledIdentityConstraint> r_constraints;
		public virtual RFieldArray<RSystem.RXml.RSchema.RCompiledIdentityConstraint> Rconstraints
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
		/// System.Xml.Schema.XmlSchemaElement schemaElement
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaElement r_schemaElement;
		public virtual RSystem.RXml.RSchema.RXmlSchemaElement RschemaElement
		{
			get
			{
				if(r_schemaElement == null)
				{
					r_schemaElement = new(this, "schemaElement");
					r_schemaElement.SetBelong(this.instance);
				}
				return r_schemaElement;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl Empty
		/// </summary>
		protected static RSystem.RXml.RSchema.RSchemaElementDecl r_Empty;
		public static RSystem.RXml.RSchema.RSchemaElementDecl REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaElementDecl"), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_name;
		public virtual RSystem.RXml.RXmlQualifiedName Rname
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
		/// System.Boolean isDeclaredInExternal
		/// </summary>
		protected RField r_isDeclaredInExternal;
		public virtual RField RisDeclaredInExternal
		{
			get
			{
				if(r_isDeclaredInExternal == null)
				{
					r_isDeclaredInExternal = new(this, "isDeclaredInExternal");
					r_isDeclaredInExternal.SetBelong(this.instance);
				}
				return r_isDeclaredInExternal;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaDeclBase+Use presence
		/// </summary>
		protected RField r_presence;
		public virtual RField Rpresence
		{
			get
			{
				if(r_presence == null)
				{
					r_presence = new(this, "presence");
					r_presence.SetBelong(this.instance);
				}
				return r_presence;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType schemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_schemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RschemaType
		{
			get
			{
				if(r_schemaType == null)
				{
					r_schemaType = new(this, "schemaType");
					r_schemaType.SetBelong(this.instance);
				}
				return r_schemaType;
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
		/// System.String defaultValueRaw
		/// </summary>
		protected RField r_defaultValueRaw;
		public virtual RField RdefaultValueRaw
		{
			get
			{
				if(r_defaultValueRaw == null)
				{
					r_defaultValueRaw = new(this, "defaultValueRaw");
					r_defaultValueRaw.SetBelong(this.instance);
				}
				return r_defaultValueRaw;
			}
		}

		/// <summary>
		/// System.Object defaultValueTyped
		/// </summary>
		protected RSystem.RObject r_defaultValueTyped;
		public virtual RSystem.RObject RdefaultValueTyped
		{
			get
			{
				if(r_defaultValueTyped == null)
				{
					r_defaultValueTyped = new(this, "defaultValueTyped");
					r_defaultValueTyped.SetBelong(this.instance);
				}
				return r_defaultValueTyped;
			}
		}

		/// <summary>
		/// System.Int64 maxLength
		/// </summary>
		protected RField r_maxLength;
		public virtual RField RmaxLength
		{
			get
			{
				if(r_maxLength == null)
				{
					r_maxLength = new(this, "maxLength");
					r_maxLength.SetBelong(this.instance);
				}
				return r_maxLength;
			}
		}

		/// <summary>
		/// System.Int64 minLength
		/// </summary>
		protected RField r_minLength;
		public virtual RField RminLength
		{
			get
			{
				if(r_minLength == null)
				{
					r_minLength = new(this, "minLength");
					r_minLength.SetBelong(this.instance);
				}
				return r_minLength;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_values;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rvalues
		{
			get
			{
				if(r_values == null)
				{
					r_values = new(this, "values");
					r_values.SetBelong(this.instance);
				}
				return r_values;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdAttributeListInfo.Prefix
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix = new(this, "System.Xml.IDtdAttributeListInfo.Prefix", -1);
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_Prefix;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdAttributeListInfo.LocalName
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName = new(this, "System.Xml.IDtdAttributeListInfo.LocalName", -1);
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_LocalName;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes = new(this, "System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes", -1);
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__get_HasNonCDataAttributes;
			}
		}

		/// <summary>
		/// Boolean IsIdDeclared
		/// </summary>
		protected RProperty r_IsIdDeclared;
		public virtual RProperty RIsIdDeclared
		{
			get
			{
				if(r_IsIdDeclared == null)
				{
					r_IsIdDeclared = new(this, "IsIdDeclared", -1);
					r_IsIdDeclared.SetBelong(this.instance);
				}
				return r_IsIdDeclared;
			}
		}

		/// <summary>
		/// Boolean HasNonCDataAttribute
		/// </summary>
		protected RProperty r_HasNonCDataAttribute;
		public virtual RProperty RHasNonCDataAttribute
		{
			get
			{
				if(r_HasNonCDataAttribute == null)
				{
					r_HasNonCDataAttribute = new(this, "HasNonCDataAttribute", -1);
					r_HasNonCDataAttribute.SetBelong(this.instance);
				}
				return r_HasNonCDataAttribute;
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
		/// Boolean IsNotationDeclared
		/// </summary>
		protected RProperty r_IsNotationDeclared;
		public virtual RProperty RIsNotationDeclared
		{
			get
			{
				if(r_IsNotationDeclared == null)
				{
					r_IsNotationDeclared = new(this, "IsNotationDeclared", -1);
					r_IsNotationDeclared.SetBelong(this.instance);
				}
				return r_IsNotationDeclared;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAttribute
		/// </summary>
		protected RProperty r_HasDefaultAttribute;
		public virtual RProperty RHasDefaultAttribute
		{
			get
			{
				if(r_HasDefaultAttribute == null)
				{
					r_HasDefaultAttribute = new(this, "HasDefaultAttribute", -1);
					r_HasDefaultAttribute.SetBelong(this.instance);
				}
				return r_HasDefaultAttribute;
			}
		}

		/// <summary>
		/// Boolean HasRequiredAttribute
		/// </summary>
		protected RProperty r_HasRequiredAttribute;
		public virtual RProperty RHasRequiredAttribute
		{
			get
			{
				if(r_HasRequiredAttribute == null)
				{
					r_HasRequiredAttribute = new(this, "HasRequiredAttribute", -1);
					r_HasRequiredAttribute.SetBelong(this.instance);
				}
				return r_HasRequiredAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator ContentValidator
		/// </summary>
		protected RSystem.RXml.RSchema.RContentValidator r_ContentValidator;
		public virtual RSystem.RXml.RSchema.RContentValidator RContentValidator
		{
			get
			{
				if(r_ContentValidator == null)
				{
					r_ContentValidator = new(this, "ContentValidator", -1);
					r_ContentValidator.SetBelong(this.instance);
				}
				return r_ContentValidator;
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
		/// System.Xml.Schema.CompiledIdentityConstraint[] Constraints
		/// </summary>
		protected RPropertyArray<RSystem.RXml.RSchema.RCompiledIdentityConstraint> r_Constraints;
		public virtual RPropertyArray<RSystem.RXml.RSchema.RCompiledIdentityConstraint> RConstraints
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
		/// System.Collections.Generic.IList`1[System.Xml.IDtdDefaultAttributeInfo] DefaultAttDefs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RXml.RIDtdDefaultAttributeInfo> r_DefaultAttDefs;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RXml.RIDtdDefaultAttributeInfo> RDefaultAttDefs
		{
			get
			{
				if(r_DefaultAttDefs == null)
				{
					r_DefaultAttDefs = new(this, "DefaultAttDefs", -1);
					r_DefaultAttDefs.SetBelong(this.instance);
				}
				return r_DefaultAttDefs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef] AttDefs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> r_AttDefs;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> RAttDefs
		{
			get
			{
				if(r_AttDefs == null)
				{
					r_AttDefs = new(this, "AttDefs", -1);
					r_AttDefs.SetBelong(this.instance);
				}
				return r_AttDefs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName] ProhibitedAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RXmlQualifiedName> r_ProhibitedAttributes;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RXmlQualifiedName> RProhibitedAttributes
		{
			get
			{
				if(r_ProhibitedAttributes == null)
				{
					r_ProhibitedAttributes = new(this, "ProhibitedAttributes", -1);
					r_ProhibitedAttributes.SetBelong(this.instance);
				}
				return r_ProhibitedAttributes;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_Name;
		public virtual RSystem.RXml.RXmlQualifiedName RName
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
		/// Boolean IsDeclaredInExternal
		/// </summary>
		protected RProperty r_IsDeclaredInExternal;
		public virtual RProperty RIsDeclaredInExternal
		{
			get
			{
				if(r_IsDeclaredInExternal == null)
				{
					r_IsDeclaredInExternal = new(this, "IsDeclaredInExternal", -1);
					r_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Use Presence
		/// </summary>
		protected RProperty r_Presence;
		public virtual RProperty RPresence
		{
			get
			{
				if(r_Presence == null)
				{
					r_Presence = new(this, "Presence", -1);
					r_Presence.SetBelong(this.instance);
				}
				return r_Presence;
			}
		}

		/// <summary>
		/// Int64 MaxLength
		/// </summary>
		protected RProperty r_MaxLength;
		public virtual RProperty RMaxLength
		{
			get
			{
				if(r_MaxLength == null)
				{
					r_MaxLength = new(this, "MaxLength", -1);
					r_MaxLength.SetBelong(this.instance);
				}
				return r_MaxLength;
			}
		}

		/// <summary>
		/// Int64 MinLength
		/// </summary>
		protected RProperty r_MinLength;
		public virtual RProperty RMinLength
		{
			get
			{
				if(r_MinLength == null)
				{
					r_MinLength = new(this, "MinLength", -1);
					r_MinLength.SetBelong(this.instance);
				}
				return r_MinLength;
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
		/// System.Collections.Generic.List`1[System.String] Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
			}
		}

		/// <summary>
		/// System.String DefaultValueRaw
		/// </summary>
		protected RProperty r_DefaultValueRaw;
		public virtual RProperty RDefaultValueRaw
		{
			get
			{
				if(r_DefaultValueRaw == null)
				{
					r_DefaultValueRaw = new(this, "DefaultValueRaw", -1);
					r_DefaultValueRaw.SetBelong(this.instance);
				}
				return r_DefaultValueRaw;
			}
		}

		/// <summary>
		/// System.Object DefaultValueTyped
		/// </summary>
		protected RSystem.RObject r_DefaultValueTyped;
		public virtual RSystem.RObject RDefaultValueTyped
		{
			get
			{
				if(r_DefaultValueTyped == null)
				{
					r_DefaultValueTyped = new(this, "DefaultValueTyped", -1);
					r_DefaultValueTyped.SetBelong(this.instance);
				}
				return r_DefaultValueTyped;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl()
		/// </summary>
		protected static RMethod r_RCreateAnyTypeElementDecl;
		public static RMethod RCreateAnyTypeElementDecl
		{
			get
			{
				if(r_RCreateAnyTypeElementDecl == null)
				{
					r_RCreateAnyTypeElementDecl = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaElementDecl"), "CreateAnyTypeElementDecl", 0);
					r_RCreateAnyTypeElementDecl.SetBelong(null);
				}
				return r_RCreateAnyTypeElementDecl;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String;
		public virtual RMethod RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String = new(this, "System.Xml.IDtdAttributeListInfo.LookupAttribute", 0, typeof(System.String), typeof(System.String));
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Xml.IDtdDefaultAttributeInfo] System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes()
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes;
		public virtual RMethod RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes = new(this, "System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes", 0);
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupIdAttribute()
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute;
		public virtual RMethod RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute = new(this, "System.Xml.IDtdAttributeListInfo.LookupIdAttribute", 0);
					r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl Clone()
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
		/// Void AddAttDef(System.Xml.Schema.SchemaAttDef)
		/// </summary>
		protected RMethod r_RAddAttDef_SchemaAttDef;
		public virtual RMethod RAddAttDef_SchemaAttDef
		{
			get
			{
				if(r_RAddAttDef_SchemaAttDef == null)
				{
					r_RAddAttDef_SchemaAttDef = new(this, "AddAttDef", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaAttDef"));
					r_RAddAttDef_SchemaAttDef.SetBelong(this.instance);
				}
				return r_RAddAttDef_SchemaAttDef;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetAttDef_XmlQualifiedName;
		public virtual RMethod RGetAttDef_XmlQualifiedName
		{
			get
			{
				if(r_RGetAttDef_XmlQualifiedName == null)
				{
					r_RGetAttDef_XmlQualifiedName = new(this, "GetAttDef", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetAttDef_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetAttDef_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Void CheckAttributes(System.Collections.Hashtable, Boolean)
		/// </summary>
		protected RMethod r_RCheckAttributes_Hashtable_Boolean;
		public virtual RMethod RCheckAttributes_Hashtable_Boolean
		{
			get
			{
				if(r_RCheckAttributes_Hashtable_Boolean == null)
				{
					r_RCheckAttributes_Hashtable_Boolean = new(this, "CheckAttributes", 0, typeof(System.Collections.Hashtable), typeof(System.Boolean));
					r_RCheckAttributes_Hashtable_Boolean.SetBelong(this.instance);
				}
				return r_RCheckAttributes_Hashtable_Boolean;
			}
		}

		/// <summary>
		/// Void AddValue(System.String)
		/// </summary>
		protected RMethod r_RAddValue_String;
		public virtual RMethod RAddValue_String
		{
			get
			{
				if(r_RAddValue_String == null)
				{
					r_RAddValue_String = new(this, "AddValue", 0, typeof(System.String));
					r_RAddValue_String.SetBelong(this.instance);
				}
				return r_RAddValue_String;
			}
		}

		/// <summary>
		/// Boolean CheckEnumeration(System.Object)
		/// </summary>
		protected RMethod r_RCheckEnumeration_Object;
		public virtual RMethod RCheckEnumeration_Object
		{
			get
			{
				if(r_RCheckEnumeration_Object == null)
				{
					r_RCheckEnumeration_Object = new(this, "CheckEnumeration", 0, typeof(System.Object));
					r_RCheckEnumeration_Object.SetBelong(this.instance);
				}
				return r_RCheckEnumeration_Object;
			}
		}

		/// <summary>
		/// Boolean CheckValue(System.Object)
		/// </summary>
		protected RMethod r_RCheckValue_Object;
		public virtual RMethod RCheckValue_Object
		{
			get
			{
				if(r_RCheckValue_Object == null)
				{
					r_RCheckValue_Object = new(this, "CheckValue", 0, typeof(System.Object));
					r_RCheckValue_Object.SetBelong(this.instance);
				}
				return r_RCheckValue_Object;
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


        public RSchemaElementDecl() : base("System.Xml.Schema.SchemaElementDecl")
        {
        }

        public RSchemaElementDecl(System.Object instance) : base("System.Xml.Schema.SchemaElementDecl")
		{
            SetInstance(instance);
		}

        public RSchemaElementDecl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaElementDecl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object CreateAnyTypeElementDecl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateAnyTypeElementDecl.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute(System.String  @prefix, System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName};
            var ___result = RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupDefaultAttributes.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Xml__1__IDtdAttributeListInfo__1__LookupIdAttribute.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Object GetAttDef(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetAttDef_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CheckAttributes(System.Collections.Hashtable  @presence, System.Boolean  @standalone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@presence, @standalone};
            var ___result = RCheckAttributes_Hashtable_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckEnumeration(System.Object  @pVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pVal};
            var ___result = RCheckEnumeration_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckValue(System.Object  @pVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pVal};
            var ___result = RCheckValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
