using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaInfo
	/// </summary>
    public partial class RSchemaInfo : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] elementDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_elementDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RelementDecls
		{
			get
			{
				if(r_elementDecls == null)
				{
					r_elementDecls = new(this, "elementDecls");
					r_elementDecls.SetBelong(this.instance);
				}
				return r_elementDecls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] undeclaredElementDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_undeclaredElementDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RundeclaredElementDecls
		{
			get
			{
				if(r_undeclaredElementDecls == null)
				{
					r_undeclaredElementDecls = new(this, "undeclaredElementDecls");
					r_undeclaredElementDecls.SetBelong(this.instance);
				}
				return r_undeclaredElementDecls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity] generalEntities
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> r_generalEntities;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> RgeneralEntities
		{
			get
			{
				if(r_generalEntities == null)
				{
					r_generalEntities = new(this, "generalEntities");
					r_generalEntities.SetBelong(this.instance);
				}
				return r_generalEntities;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity] parameterEntities
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> r_parameterEntities;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> RparameterEntities
		{
			get
			{
				if(r_parameterEntities == null)
				{
					r_parameterEntities = new(this, "parameterEntities");
					r_parameterEntities.SetBelong(this.instance);
				}
				return r_parameterEntities;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName docTypeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_docTypeName;
		public virtual RSystem.RXml.RXmlQualifiedName RdocTypeName
		{
			get
			{
				if(r_docTypeName == null)
				{
					r_docTypeName = new(this, "docTypeName");
					r_docTypeName.SetBelong(this.instance);
				}
				return r_docTypeName;
			}
		}

		/// <summary>
		/// System.String internalDtdSubset
		/// </summary>
		protected RField r_internalDtdSubset;
		public virtual RField RinternalDtdSubset
		{
			get
			{
				if(r_internalDtdSubset == null)
				{
					r_internalDtdSubset = new(this, "internalDtdSubset");
					r_internalDtdSubset.SetBelong(this.instance);
				}
				return r_internalDtdSubset;
			}
		}

		/// <summary>
		/// System.Boolean hasNonCDataAttributes
		/// </summary>
		protected RField r_hasNonCDataAttributes;
		public virtual RField RhasNonCDataAttributes
		{
			get
			{
				if(r_hasNonCDataAttributes == null)
				{
					r_hasNonCDataAttributes = new(this, "hasNonCDataAttributes");
					r_hasNonCDataAttributes.SetBelong(this.instance);
				}
				return r_hasNonCDataAttributes;
			}
		}

		/// <summary>
		/// System.Boolean hasDefaultAttributes
		/// </summary>
		protected RField r_hasDefaultAttributes;
		public virtual RField RhasDefaultAttributes
		{
			get
			{
				if(r_hasDefaultAttributes == null)
				{
					r_hasDefaultAttributes = new(this, "hasDefaultAttributes");
					r_hasDefaultAttributes.SetBelong(this.instance);
				}
				return r_hasDefaultAttributes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Boolean] targetNamespaces
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_targetNamespaces;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RtargetNamespaces
		{
			get
			{
				if(r_targetNamespaces == null)
				{
					r_targetNamespaces = new(this, "targetNamespaces");
					r_targetNamespaces.SetBelong(this.instance);
				}
				return r_targetNamespaces;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef] attributeDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> r_attributeDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> RattributeDecls
		{
			get
			{
				if(r_attributeDecls == null)
				{
					r_attributeDecls = new(this, "attributeDecls");
					r_attributeDecls.SetBelong(this.instance);
				}
				return r_attributeDecls;
			}
		}

		/// <summary>
		/// System.Int32 errorCount
		/// </summary>
		protected RField r_errorCount;
		public virtual RField RerrorCount
		{
			get
			{
				if(r_errorCount == null)
				{
					r_errorCount = new(this, "errorCount");
					r_errorCount.SetBelong(this.instance);
				}
				return r_errorCount;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaType schemaType
		/// </summary>
		protected RField r_schemaType;
		public virtual RField RschemaType
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
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] elementDeclsByType
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_elementDeclsByType;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RelementDeclsByType
		{
			get
			{
				if(r_elementDeclsByType == null)
				{
					r_elementDeclsByType = new(this, "elementDeclsByType");
					r_elementDeclsByType.SetBelong(this.instance);
				}
				return r_elementDeclsByType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Xml.Schema.SchemaNotation] notations
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RXml.RSchema.RSchemaNotation> r_notations;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RXml.RSchema.RSchemaNotation> Rnotations
		{
			get
			{
				if(r_notations == null)
				{
					r_notations = new(this, "notations");
					r_notations.SetBelong(this.instance);
				}
				return r_notations;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName DocTypeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_DocTypeName;
		public virtual RSystem.RXml.RXmlQualifiedName RDocTypeName
		{
			get
			{
				if(r_DocTypeName == null)
				{
					r_DocTypeName = new(this, "DocTypeName", -1);
					r_DocTypeName.SetBelong(this.instance);
				}
				return r_DocTypeName;
			}
		}

		/// <summary>
		/// System.String InternalDtdSubset
		/// </summary>
		protected RProperty r_InternalDtdSubset;
		public virtual RProperty RInternalDtdSubset
		{
			get
			{
				if(r_InternalDtdSubset == null)
				{
					r_InternalDtdSubset = new(this, "InternalDtdSubset", -1);
					r_InternalDtdSubset.SetBelong(this.instance);
				}
				return r_InternalDtdSubset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] ElementDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_ElementDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RElementDecls
		{
			get
			{
				if(r_ElementDecls == null)
				{
					r_ElementDecls = new(this, "ElementDecls", -1);
					r_ElementDecls.SetBelong(this.instance);
				}
				return r_ElementDecls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] UndeclaredElementDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_UndeclaredElementDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RUndeclaredElementDecls
		{
			get
			{
				if(r_UndeclaredElementDecls == null)
				{
					r_UndeclaredElementDecls = new(this, "UndeclaredElementDecls", -1);
					r_UndeclaredElementDecls.SetBelong(this.instance);
				}
				return r_UndeclaredElementDecls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity] GeneralEntities
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> r_GeneralEntities;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> RGeneralEntities
		{
			get
			{
				if(r_GeneralEntities == null)
				{
					r_GeneralEntities = new(this, "GeneralEntities", -1);
					r_GeneralEntities.SetBelong(this.instance);
				}
				return r_GeneralEntities;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity] ParameterEntities
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> r_ParameterEntities;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaEntity> RParameterEntities
		{
			get
			{
				if(r_ParameterEntities == null)
				{
					r_ParameterEntities = new(this, "ParameterEntities", -1);
					r_ParameterEntities.SetBelong(this.instance);
				}
				return r_ParameterEntities;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaType SchemaType
		/// </summary>
		protected RProperty r_SchemaType;
		public virtual RProperty RSchemaType
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Boolean] TargetNamespaces
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_TargetNamespaces;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> RTargetNamespaces
		{
			get
			{
				if(r_TargetNamespaces == null)
				{
					r_TargetNamespaces = new(this, "TargetNamespaces", -1);
					r_TargetNamespaces.SetBelong(this.instance);
				}
				return r_TargetNamespaces;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl] ElementDeclsByType
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> r_ElementDeclsByType;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaElementDecl> RElementDeclsByType
		{
			get
			{
				if(r_ElementDeclsByType == null)
				{
					r_ElementDeclsByType = new(this, "ElementDeclsByType", -1);
					r_ElementDeclsByType.SetBelong(this.instance);
				}
				return r_ElementDeclsByType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef] AttributeDecls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> r_AttributeDecls;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RSchemaAttDef> RAttributeDecls
		{
			get
			{
				if(r_AttributeDecls == null)
				{
					r_AttributeDecls = new(this, "AttributeDecls", -1);
					r_AttributeDecls.SetBelong(this.instance);
				}
				return r_AttributeDecls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Xml.Schema.SchemaNotation] Notations
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RSystem.RXml.RSchema.RSchemaNotation> r_Notations;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RSystem.RXml.RSchema.RSchemaNotation> RNotations
		{
			get
			{
				if(r_Notations == null)
				{
					r_Notations = new(this, "Notations", -1);
					r_Notations.SetBelong(this.instance);
				}
				return r_Notations;
			}
		}

		/// <summary>
		/// Int32 ErrorCount
		/// </summary>
		protected RProperty r_ErrorCount;
		public virtual RProperty RErrorCount
		{
			get
			{
				if(r_ErrorCount == null)
				{
					r_ErrorCount = new(this, "ErrorCount", -1);
					r_ErrorCount.SetBelong(this.instance);
				}
				return r_ErrorCount;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdInfo.HasDefaultAttributes
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes;
		public virtual RProperty RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes = new(this, "System.Xml.IDtdInfo.HasDefaultAttributes", -1);
					r_RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__get_HasDefaultAttributes;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdInfo.HasNonCDataAttributes
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes;
		public virtual RProperty RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes = new(this, "System.Xml.IDtdInfo.HasNonCDataAttributes", -1);
					r_RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__get_HasNonCDataAttributes;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName System.Xml.IDtdInfo.Name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_RSystem__1__Xml__1__IDtdInfo__1__get_Name;
		public virtual RSystem.RXml.RXmlQualifiedName RSystem__1__Xml__1__IDtdInfo__1__get_Name
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__get_Name == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__get_Name = new(this, "System.Xml.IDtdInfo.Name", -1);
					r_RSystem__1__Xml__1__IDtdInfo__1__get_Name.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__get_Name;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdInfo.InternalDtdSubset
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset;
		public virtual RProperty RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset = new(this, "System.Xml.IDtdInfo.InternalDtdSubset", -1);
					r_RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__get_InternalDtdSubset;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetElementDecl_XmlQualifiedName;
		public virtual RMethod RGetElementDecl_XmlQualifiedName
		{
			get
			{
				if(r_RGetElementDecl_XmlQualifiedName == null)
				{
					r_RGetElementDecl_XmlQualifiedName = new(this, "GetElementDecl", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetElementDecl_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetElementDecl_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetTypeDecl_XmlQualifiedName;
		public virtual RMethod RGetTypeDecl_XmlQualifiedName
		{
			get
			{
				if(r_RGetTypeDecl_XmlQualifiedName == null)
				{
					r_RGetTypeDecl_XmlQualifiedName = new(this, "GetTypeDecl", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetTypeDecl_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetTypeDecl_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetElement_XmlQualifiedName;
		public virtual RMethod RGetElement_XmlQualifiedName
		{
			get
			{
				if(r_RGetElement_XmlQualifiedName == null)
				{
					r_RGetElement_XmlQualifiedName = new(this, "GetElement", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetElement_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetElement_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAttribute GetAttribute(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetAttribute_XmlQualifiedName;
		public virtual RMethod RGetAttribute_XmlQualifiedName
		{
			get
			{
				if(r_RGetAttribute_XmlQualifiedName == null)
				{
					r_RGetAttribute_XmlQualifiedName = new(this, "GetAttribute", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetAttribute_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetAttribute_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaElement GetType(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetType_XmlQualifiedName;
		public virtual RMethod RGetType_XmlQualifiedName
		{
			get
			{
				if(r_RGetType_XmlQualifiedName == null)
				{
					r_RGetType_XmlQualifiedName = new(this, "GetType", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetType_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetType_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Boolean HasSchema(System.String)
		/// </summary>
		protected RMethod r_RHasSchema_String;
		public virtual RMethod RHasSchema_String
		{
			get
			{
				if(r_RHasSchema_String == null)
				{
					r_RHasSchema_String = new(this, "HasSchema", 0, typeof(System.String));
					r_RHasSchema_String.SetBelong(this.instance);
				}
				return r_RHasSchema_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_RContains_String;
		public virtual RMethod RContains_String
		{
			get
			{
				if(r_RContains_String == null)
				{
					r_RContains_String = new(this, "Contains", 0, typeof(System.String));
					r_RContains_String.SetBelong(this.instance);
				}
				return r_RContains_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl, System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName;
		public virtual RMethod RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName
		{
			get
			{
				if(r_RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName == null)
				{
					r_RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName = new(this, "GetAttributeXdr", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaElementDecl"), typeof(System.Xml.XmlQualifiedName));
					r_RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RGetAttributeXdr_SchemaElementDecl_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl, System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject, System.Xml.Schema.AttributeMatchState ByRef)
		/// </summary>
		protected RMethod r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState;
		public virtual RMethod RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState
		{
			get
			{
				if(r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState == null)
				{
					r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState = new(this, "GetAttributeXsd", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaElementDecl"), typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaObject),  ReleactionUtils.GetType("System.Xml.Schema.AttributeMatchState").MakeByRefType());
					r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState.SetBelong(this.instance);
				}
				return r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_Out_AttributeMatchState;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl, System.Xml.XmlQualifiedName, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean;
		public virtual RMethod RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean
		{
			get
			{
				if(r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean == null)
				{
					r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean = new(this, "GetAttributeXsd", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaElementDecl"), typeof(System.Xml.XmlQualifiedName), typeof(System.Boolean).MakeByRefType());
					r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean.SetBelong(this.instance);
				}
				return r_RGetAttributeXsd_SchemaElementDecl_XmlQualifiedName_Ref_Boolean;
			}
		}

		/// <summary>
		/// Void Add(System.Xml.Schema.SchemaInfo, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RAdd_SchemaInfo_ValidationEventHandler;
		public virtual RMethod RAdd_SchemaInfo_ValidationEventHandler
		{
			get
			{
				if(r_RAdd_SchemaInfo_ValidationEventHandler == null)
				{
					r_RAdd_SchemaInfo_ValidationEventHandler = new(this, "Add", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RAdd_SchemaInfo_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RAdd_SchemaInfo_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void Finish()
		/// </summary>
		protected RMethod r_RFinish;
		public virtual RMethod RFinish
		{
			get
			{
				if(r_RFinish == null)
				{
					r_RFinish = new(this, "Finish", 0);
					r_RFinish.SetBelong(this.instance);
				}
				return r_RFinish;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(System.String, System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String;
		public virtual RMethod RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String = new(this, "System.Xml.IDtdInfo.LookupAttributeList", 0, typeof(System.String), typeof(System.String));
					r_RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Xml.IDtdAttributeListInfo] System.Xml.IDtdInfo.GetAttributeLists()
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists;
		public virtual RMethod RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists = new(this, "System.Xml.IDtdInfo.GetAttributeLists", 0);
					r_RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists;
			}
		}

		/// <summary>
		/// System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String;
		public virtual RMethod RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String == null)
				{
					r_RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String = new(this, "System.Xml.IDtdInfo.LookupEntity", 0, typeof(System.String));
					r_RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String;
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


        public RSchemaInfo() : base("System.Xml.Schema.SchemaInfo")
        {
        }

        public RSchemaInfo(System.Object instance) : base("System.Xml.Schema.SchemaInfo")
		{
            SetInstance(instance);
		}

        public RSchemaInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetElementDecl(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetElementDecl_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetTypeDecl(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetTypeDecl_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetElement_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaElement)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaAttribute GetAttribute(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetAttribute_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaAttribute)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaElement GetType(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetType_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaElement)___result;
        }


        public virtual System.Boolean HasSchema(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RHasSchema_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }






        public virtual void Finish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinish.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object System__1__Xml__1__IDtdInfo__1__LookupAttributeList(System.String  @prefix, System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName};
            var ___result = RSystem__1__Xml__1__IDtdInfo__1__LookupAttributeList_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__Xml__1__IDtdInfo__1__GetAttributeLists()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Xml__1__IDtdInfo__1__GetAttributeLists.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__Xml__1__IDtdInfo__1__LookupEntity(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RSystem__1__Xml__1__IDtdInfo__1__LookupEntity_String.Invoke(___genericsType, ___parameters);

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
