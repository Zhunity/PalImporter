using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchema
	/// </summary>
    public partial class RXmlSchema : RMember //
    {

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected static RField r_Namespace;
		public static RField RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(typeof(System.Xml.Schema.XmlSchema), "Namespace");
					r_Namespace.SetBelong(null);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.String InstanceNamespace
		/// </summary>
		protected static RField r_InstanceNamespace;
		public static RField RInstanceNamespace
		{
			get
			{
				if(r_InstanceNamespace == null)
				{
					r_InstanceNamespace = new(typeof(System.Xml.Schema.XmlSchema), "InstanceNamespace");
					r_InstanceNamespace.SetBelong(null);
				}
				return r_InstanceNamespace;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm attributeFormDefault
		/// </summary>
		protected RField r_attributeFormDefault;
		public virtual RField RattributeFormDefault
		{
			get
			{
				if(r_attributeFormDefault == null)
				{
					r_attributeFormDefault = new(this, "attributeFormDefault");
					r_attributeFormDefault.SetBelong(this.instance);
				}
				return r_attributeFormDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm elementFormDefault
		/// </summary>
		protected RField r_elementFormDefault;
		public virtual RField RelementFormDefault
		{
			get
			{
				if(r_elementFormDefault == null)
				{
					r_elementFormDefault = new(this, "elementFormDefault");
					r_elementFormDefault.SetBelong(this.instance);
				}
				return r_elementFormDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod blockDefault
		/// </summary>
		protected RField r_blockDefault;
		public virtual RField RblockDefault
		{
			get
			{
				if(r_blockDefault == null)
				{
					r_blockDefault = new(this, "blockDefault");
					r_blockDefault.SetBelong(this.instance);
				}
				return r_blockDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod finalDefault
		/// </summary>
		protected RField r_finalDefault;
		public virtual RField RfinalDefault
		{
			get
			{
				if(r_finalDefault == null)
				{
					r_finalDefault = new(this, "finalDefault");
					r_finalDefault.SetBelong(this.instance);
				}
				return r_finalDefault;
			}
		}

		/// <summary>
		/// System.String targetNs
		/// </summary>
		protected RField r_targetNs;
		public virtual RField RtargetNs
		{
			get
			{
				if(r_targetNs == null)
				{
					r_targetNs = new(this, "targetNs");
					r_targetNs.SetBelong(this.instance);
				}
				return r_targetNs;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected RField r_version;
		public virtual RField Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection includes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_includes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection Rincludes
		{
			get
			{
				if(r_includes == null)
				{
					r_includes = new(this, "includes");
					r_includes.SetBelong(this.instance);
				}
				return r_includes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection items
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_items;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection Ritems
		{
			get
			{
				if(r_items == null)
				{
					r_items = new(this, "items");
					r_items.SetBelong(this.instance);
				}
				return r_items;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute[] moreAttributes
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlAttribute> r_moreAttributes;
		public virtual RFieldArray<RSystem.RXml.RXmlAttribute> RmoreAttributes
		{
			get
			{
				if(r_moreAttributes == null)
				{
					r_moreAttributes = new(this, "moreAttributes");
					r_moreAttributes.SetBelong(this.instance);
				}
				return r_moreAttributes;
			}
		}

		/// <summary>
		/// System.Boolean isCompiled
		/// </summary>
		protected RField r_isCompiled;
		public virtual RField RisCompiled
		{
			get
			{
				if(r_isCompiled == null)
				{
					r_isCompiled = new(this, "isCompiled");
					r_isCompiled.SetBelong(this.instance);
				}
				return r_isCompiled;
			}
		}

		/// <summary>
		/// System.Boolean isCompiledBySet
		/// </summary>
		protected RField r_isCompiledBySet;
		public virtual RField RisCompiledBySet
		{
			get
			{
				if(r_isCompiledBySet == null)
				{
					r_isCompiledBySet = new(this, "isCompiledBySet");
					r_isCompiledBySet.SetBelong(this.instance);
				}
				return r_isCompiledBySet;
			}
		}

		/// <summary>
		/// System.Boolean isPreprocessed
		/// </summary>
		protected RField r_isPreprocessed;
		public virtual RField RisPreprocessed
		{
			get
			{
				if(r_isPreprocessed == null)
				{
					r_isPreprocessed = new(this, "isPreprocessed");
					r_isPreprocessed.SetBelong(this.instance);
				}
				return r_isPreprocessed;
			}
		}

		/// <summary>
		/// System.Boolean isRedefined
		/// </summary>
		protected RField r_isRedefined;
		public virtual RField RisRedefined
		{
			get
			{
				if(r_isRedefined == null)
				{
					r_isRedefined = new(this, "isRedefined");
					r_isRedefined.SetBelong(this.instance);
				}
				return r_isRedefined;
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
		/// System.Xml.Schema.XmlSchemaObjectTable attributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_attributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Rattributes
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
		/// System.Xml.Schema.XmlSchemaObjectTable attributeGroups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_attributeGroups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RattributeGroups
		{
			get
			{
				if(r_attributeGroups == null)
				{
					r_attributeGroups = new(this, "attributeGroups");
					r_attributeGroups.SetBelong(this.instance);
				}
				return r_attributeGroups;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable elements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_elements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Relements
		{
			get
			{
				if(r_elements == null)
				{
					r_elements = new(this, "elements");
					r_elements.SetBelong(this.instance);
				}
				return r_elements;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable types
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_types;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Rtypes
		{
			get
			{
				if(r_types == null)
				{
					r_types = new(this, "types");
					r_types.SetBelong(this.instance);
				}
				return r_types;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable groups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_groups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Rgroups
		{
			get
			{
				if(r_groups == null)
				{
					r_groups = new(this, "groups");
					r_groups.SetBelong(this.instance);
				}
				return r_groups;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable notations
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_notations;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Rnotations
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
		/// System.Xml.Schema.XmlSchemaObjectTable identityConstraints
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_identityConstraints;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RidentityConstraints
		{
			get
			{
				if(r_identityConstraints == null)
				{
					r_identityConstraints = new(this, "identityConstraints");
					r_identityConstraints.SetBelong(this.instance);
				}
				return r_identityConstraints;
			}
		}

		/// <summary>
		/// System.Int32 globalIdCounter
		/// </summary>
		protected static RField r_globalIdCounter;
		public static RField RglobalIdCounter
		{
			get
			{
				if(r_globalIdCounter == null)
				{
					r_globalIdCounter = new(typeof(System.Xml.Schema.XmlSchema), "globalIdCounter");
					r_globalIdCounter.SetBelong(null);
				}
				return r_globalIdCounter;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList importedSchemas
		/// </summary>
		protected RSystem.RCollections.RArrayList r_importedSchemas;
		public virtual RSystem.RCollections.RArrayList RimportedSchemas
		{
			get
			{
				if(r_importedSchemas == null)
				{
					r_importedSchemas = new(this, "importedSchemas");
					r_importedSchemas.SetBelong(this.instance);
				}
				return r_importedSchemas;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList importedNamespaces
		/// </summary>
		protected RSystem.RCollections.RArrayList r_importedNamespaces;
		public virtual RSystem.RCollections.RArrayList RimportedNamespaces
		{
			get
			{
				if(r_importedNamespaces == null)
				{
					r_importedNamespaces = new(this, "importedNamespaces");
					r_importedNamespaces.SetBelong(this.instance);
				}
				return r_importedNamespaces;
			}
		}

		/// <summary>
		/// System.Int32 schemaId
		/// </summary>
		protected RField r_schemaId;
		public virtual RField RschemaId
		{
			get
			{
				if(r_schemaId == null)
				{
					r_schemaId = new(this, "schemaId");
					r_schemaId.SetBelong(this.instance);
				}
				return r_schemaId;
			}
		}

		/// <summary>
		/// System.Uri baseUri
		/// </summary>
		protected RSystem.RUri r_baseUri;
		public virtual RSystem.RUri RbaseUri
		{
			get
			{
				if(r_baseUri == null)
				{
					r_baseUri = new(this, "baseUri");
					r_baseUri.SetBelong(this.instance);
				}
				return r_baseUri;
			}
		}

		/// <summary>
		/// System.Boolean isChameleon
		/// </summary>
		protected RField r_isChameleon;
		public virtual RField RisChameleon
		{
			get
			{
				if(r_isChameleon == null)
				{
					r_isChameleon = new(this, "isChameleon");
					r_isChameleon.SetBelong(this.instance);
				}
				return r_isChameleon;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable ids
		/// </summary>
		protected RSystem.RCollections.RHashtable r_ids;
		public virtual RSystem.RCollections.RHashtable Rids
		{
			get
			{
				if(r_ids == null)
				{
					r_ids = new(this, "ids");
					r_ids.SetBelong(this.instance);
				}
				return r_ids;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocument document
		/// </summary>
		protected RSystem.RXml.RXmlDocument r_document;
		public virtual RSystem.RXml.RXmlDocument Rdocument
		{
			get
			{
				if(r_document == null)
				{
					r_document = new(this, "document");
					r_document.SetBelong(this.instance);
				}
				return r_document;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable nameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_nameTable;
		public virtual RSystem.RXml.RXmlNameTable RnameTable
		{
			get
			{
				if(r_nameTable == null)
				{
					r_nameTable = new(this, "nameTable");
					r_nameTable.SetBelong(this.instance);
				}
				return r_nameTable;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm AttributeFormDefault
		/// </summary>
		protected RProperty r_AttributeFormDefault;
		public virtual RProperty RAttributeFormDefault
		{
			get
			{
				if(r_AttributeFormDefault == null)
				{
					r_AttributeFormDefault = new(this, "AttributeFormDefault", -1);
					r_AttributeFormDefault.SetBelong(this.instance);
				}
				return r_AttributeFormDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod BlockDefault
		/// </summary>
		protected RProperty r_BlockDefault;
		public virtual RProperty RBlockDefault
		{
			get
			{
				if(r_BlockDefault == null)
				{
					r_BlockDefault = new(this, "BlockDefault", -1);
					r_BlockDefault.SetBelong(this.instance);
				}
				return r_BlockDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDerivationMethod FinalDefault
		/// </summary>
		protected RProperty r_FinalDefault;
		public virtual RProperty RFinalDefault
		{
			get
			{
				if(r_FinalDefault == null)
				{
					r_FinalDefault = new(this, "FinalDefault", -1);
					r_FinalDefault.SetBelong(this.instance);
				}
				return r_FinalDefault;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm ElementFormDefault
		/// </summary>
		protected RProperty r_ElementFormDefault;
		public virtual RProperty RElementFormDefault
		{
			get
			{
				if(r_ElementFormDefault == null)
				{
					r_ElementFormDefault = new(this, "ElementFormDefault", -1);
					r_ElementFormDefault.SetBelong(this.instance);
				}
				return r_ElementFormDefault;
			}
		}

		/// <summary>
		/// System.String TargetNamespace
		/// </summary>
		protected RProperty r_TargetNamespace;
		public virtual RProperty RTargetNamespace
		{
			get
			{
				if(r_TargetNamespace == null)
				{
					r_TargetNamespace = new(this, "TargetNamespace", -1);
					r_TargetNamespace.SetBelong(this.instance);
				}
				return r_TargetNamespace;
			}
		}

		/// <summary>
		/// System.String Version
		/// </summary>
		protected RProperty r_Version;
		public virtual RProperty RVersion
		{
			get
			{
				if(r_Version == null)
				{
					r_Version = new(this, "Version", -1);
					r_Version.SetBelong(this.instance);
				}
				return r_Version;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection Includes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_Includes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection RIncludes
		{
			get
			{
				if(r_Includes == null)
				{
					r_Includes = new(this, "Includes", -1);
					r_Includes.SetBelong(this.instance);
				}
				return r_Includes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection Items
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectCollection r_Items;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectCollection RItems
		{
			get
			{
				if(r_Items == null)
				{
					r_Items = new(this, "Items", -1);
					r_Items.SetBelong(this.instance);
				}
				return r_Items;
			}
		}

		/// <summary>
		/// Boolean IsCompiled
		/// </summary>
		protected RProperty r_IsCompiled;
		public virtual RProperty RIsCompiled
		{
			get
			{
				if(r_IsCompiled == null)
				{
					r_IsCompiled = new(this, "IsCompiled", -1);
					r_IsCompiled.SetBelong(this.instance);
				}
				return r_IsCompiled;
			}
		}

		/// <summary>
		/// Boolean IsCompiledBySet
		/// </summary>
		protected RProperty r_IsCompiledBySet;
		public virtual RProperty RIsCompiledBySet
		{
			get
			{
				if(r_IsCompiledBySet == null)
				{
					r_IsCompiledBySet = new(this, "IsCompiledBySet", -1);
					r_IsCompiledBySet.SetBelong(this.instance);
				}
				return r_IsCompiledBySet;
			}
		}

		/// <summary>
		/// Boolean IsPreprocessed
		/// </summary>
		protected RProperty r_IsPreprocessed;
		public virtual RProperty RIsPreprocessed
		{
			get
			{
				if(r_IsPreprocessed == null)
				{
					r_IsPreprocessed = new(this, "IsPreprocessed", -1);
					r_IsPreprocessed.SetBelong(this.instance);
				}
				return r_IsPreprocessed;
			}
		}

		/// <summary>
		/// Boolean IsRedefined
		/// </summary>
		protected RProperty r_IsRedefined;
		public virtual RProperty RIsRedefined
		{
			get
			{
				if(r_IsRedefined == null)
				{
					r_IsRedefined = new(this, "IsRedefined", -1);
					r_IsRedefined.SetBelong(this.instance);
				}
				return r_IsRedefined;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable Attributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_Attributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RAttributes
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
		/// System.Xml.Schema.XmlSchemaObjectTable AttributeGroups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_AttributeGroups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RAttributeGroups
		{
			get
			{
				if(r_AttributeGroups == null)
				{
					r_AttributeGroups = new(this, "AttributeGroups", -1);
					r_AttributeGroups.SetBelong(this.instance);
				}
				return r_AttributeGroups;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable SchemaTypes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_SchemaTypes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RSchemaTypes
		{
			get
			{
				if(r_SchemaTypes == null)
				{
					r_SchemaTypes = new(this, "SchemaTypes", -1);
					r_SchemaTypes.SetBelong(this.instance);
				}
				return r_SchemaTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable Elements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_Elements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RElements
		{
			get
			{
				if(r_Elements == null)
				{
					r_Elements = new(this, "Elements", -1);
					r_Elements.SetBelong(this.instance);
				}
				return r_Elements;
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
		/// System.Xml.Schema.XmlSchemaObjectTable Groups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_Groups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RGroups
		{
			get
			{
				if(r_Groups == null)
				{
					r_Groups = new(this, "Groups", -1);
					r_Groups.SetBelong(this.instance);
				}
				return r_Groups;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable Notations
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_Notations;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RNotations
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
		/// System.Xml.Schema.XmlSchemaObjectTable IdentityConstraints
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_IdentityConstraints;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RIdentityConstraints
		{
			get
			{
				if(r_IdentityConstraints == null)
				{
					r_IdentityConstraints = new(this, "IdentityConstraints", -1);
					r_IdentityConstraints.SetBelong(this.instance);
				}
				return r_IdentityConstraints;
			}
		}

		/// <summary>
		/// System.Uri BaseUri
		/// </summary>
		protected RSystem.RUri r_BaseUri;
		public virtual RSystem.RUri RBaseUri
		{
			get
			{
				if(r_BaseUri == null)
				{
					r_BaseUri = new(this, "BaseUri", -1);
					r_BaseUri.SetBelong(this.instance);
				}
				return r_BaseUri;
			}
		}

		/// <summary>
		/// Int32 SchemaId
		/// </summary>
		protected RProperty r_SchemaId;
		public virtual RProperty RSchemaId
		{
			get
			{
				if(r_SchemaId == null)
				{
					r_SchemaId = new(this, "SchemaId", -1);
					r_SchemaId.SetBelong(this.instance);
				}
				return r_SchemaId;
			}
		}

		/// <summary>
		/// Boolean IsChameleon
		/// </summary>
		protected RProperty r_IsChameleon;
		public virtual RProperty RIsChameleon
		{
			get
			{
				if(r_IsChameleon == null)
				{
					r_IsChameleon = new(this, "IsChameleon", -1);
					r_IsChameleon.SetBelong(this.instance);
				}
				return r_IsChameleon;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Ids
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Ids;
		public virtual RSystem.RCollections.RHashtable RIds
		{
			get
			{
				if(r_Ids == null)
				{
					r_Ids = new(this, "Ids", -1);
					r_Ids.SetBelong(this.instance);
				}
				return r_Ids;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocument Document
		/// </summary>
		protected RSystem.RXml.RXmlDocument r_Document;
		public virtual RSystem.RXml.RXmlDocument RDocument
		{
			get
			{
				if(r_Document == null)
				{
					r_Document = new(this, "Document", -1);
					r_Document.SetBelong(this.instance);
				}
				return r_Document;
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
		/// System.Xml.XmlNameTable NameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_NameTable;
		public virtual RSystem.RXml.RXmlNameTable RNameTable
		{
			get
			{
				if(r_NameTable == null)
				{
					r_NameTable = new(this, "NameTable", -1);
					r_NameTable.SetBelong(this.instance);
				}
				return r_NameTable;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ImportedSchemas
		/// </summary>
		protected RSystem.RCollections.RArrayList r_ImportedSchemas;
		public virtual RSystem.RCollections.RArrayList RImportedSchemas
		{
			get
			{
				if(r_ImportedSchemas == null)
				{
					r_ImportedSchemas = new(this, "ImportedSchemas", -1);
					r_ImportedSchemas.SetBelong(this.instance);
				}
				return r_ImportedSchemas;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ImportedNamespaces
		/// </summary>
		protected RSystem.RCollections.RArrayList r_ImportedNamespaces;
		public virtual RSystem.RCollections.RArrayList RImportedNamespaces
		{
			get
			{
				if(r_ImportedNamespaces == null)
				{
					r_ImportedNamespaces = new(this, "ImportedNamespaces", -1);
					r_ImportedNamespaces.SetBelong(this.instance);
				}
				return r_ImportedNamespaces;
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
		/// System.Xml.Schema.XmlSchema Read(System.IO.TextReader, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected static RMethod r_RRead_TextReader_ValidationEventHandler;
		public static RMethod RRead_TextReader_ValidationEventHandler
		{
			get
			{
				if(r_RRead_TextReader_ValidationEventHandler == null)
				{
					r_RRead_TextReader_ValidationEventHandler = new(typeof(System.Xml.Schema.XmlSchema), "Read", 0, typeof(System.IO.TextReader), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RRead_TextReader_ValidationEventHandler.SetBelong(null);
				}
				return r_RRead_TextReader_ValidationEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Read(System.IO.Stream, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected static RMethod r_RRead_Stream_ValidationEventHandler;
		public static RMethod RRead_Stream_ValidationEventHandler
		{
			get
			{
				if(r_RRead_Stream_ValidationEventHandler == null)
				{
					r_RRead_Stream_ValidationEventHandler = new(typeof(System.Xml.Schema.XmlSchema), "Read", 0, typeof(System.IO.Stream), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RRead_Stream_ValidationEventHandler.SetBelong(null);
				}
				return r_RRead_Stream_ValidationEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected static RMethod r_RRead_XmlReader_ValidationEventHandler;
		public static RMethod RRead_XmlReader_ValidationEventHandler
		{
			get
			{
				if(r_RRead_XmlReader_ValidationEventHandler == null)
				{
					r_RRead_XmlReader_ValidationEventHandler = new(typeof(System.Xml.Schema.XmlSchema), "Read", 0, typeof(System.Xml.XmlReader), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RRead_XmlReader_ValidationEventHandler.SetBelong(null);
				}
				return r_RRead_XmlReader_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void Write(System.IO.Stream)
		/// </summary>
		protected RMethod r_RWrite_Stream;
		public virtual RMethod RWrite_Stream
		{
			get
			{
				if(r_RWrite_Stream == null)
				{
					r_RWrite_Stream = new(this, "Write", 0, typeof(System.IO.Stream));
					r_RWrite_Stream.SetBelong(this.instance);
				}
				return r_RWrite_Stream;
			}
		}

		/// <summary>
		/// Void Write(System.IO.Stream, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RWrite_Stream_XmlNamespaceManager;
		public virtual RMethod RWrite_Stream_XmlNamespaceManager
		{
			get
			{
				if(r_RWrite_Stream_XmlNamespaceManager == null)
				{
					r_RWrite_Stream_XmlNamespaceManager = new(this, "Write", 0, typeof(System.IO.Stream), typeof(System.Xml.XmlNamespaceManager));
					r_RWrite_Stream_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RWrite_Stream_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Void Write(System.IO.TextWriter)
		/// </summary>
		protected RMethod r_RWrite_TextWriter;
		public virtual RMethod RWrite_TextWriter
		{
			get
			{
				if(r_RWrite_TextWriter == null)
				{
					r_RWrite_TextWriter = new(this, "Write", 0, typeof(System.IO.TextWriter));
					r_RWrite_TextWriter.SetBelong(this.instance);
				}
				return r_RWrite_TextWriter;
			}
		}

		/// <summary>
		/// Void Write(System.IO.TextWriter, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RWrite_TextWriter_XmlNamespaceManager;
		public virtual RMethod RWrite_TextWriter_XmlNamespaceManager
		{
			get
			{
				if(r_RWrite_TextWriter_XmlNamespaceManager == null)
				{
					r_RWrite_TextWriter_XmlNamespaceManager = new(this, "Write", 0, typeof(System.IO.TextWriter), typeof(System.Xml.XmlNamespaceManager));
					r_RWrite_TextWriter_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RWrite_TextWriter_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Void Write(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RWrite_XmlWriter;
		public virtual RMethod RWrite_XmlWriter
		{
			get
			{
				if(r_RWrite_XmlWriter == null)
				{
					r_RWrite_XmlWriter = new(this, "Write", 0, typeof(System.Xml.XmlWriter));
					r_RWrite_XmlWriter.SetBelong(this.instance);
				}
				return r_RWrite_XmlWriter;
			}
		}

		/// <summary>
		/// Void Write(System.Xml.XmlWriter, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RWrite_XmlWriter_XmlNamespaceManager;
		public virtual RMethod RWrite_XmlWriter_XmlNamespaceManager
		{
			get
			{
				if(r_RWrite_XmlWriter_XmlNamespaceManager == null)
				{
					r_RWrite_XmlWriter_XmlNamespaceManager = new(this, "Write", 0, typeof(System.Xml.XmlWriter), typeof(System.Xml.XmlNamespaceManager));
					r_RWrite_XmlWriter_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RWrite_XmlWriter_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Void Compile(System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RCompile_ValidationEventHandler;
		public virtual RMethod RCompile_ValidationEventHandler
		{
			get
			{
				if(r_RCompile_ValidationEventHandler == null)
				{
					r_RCompile_ValidationEventHandler = new(this, "Compile", 0, typeof(System.Xml.Schema.ValidationEventHandler));
					r_RCompile_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RCompile_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void Compile(System.Xml.Schema.ValidationEventHandler, System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RCompile_ValidationEventHandler_XmlResolver;
		public virtual RMethod RCompile_ValidationEventHandler_XmlResolver
		{
			get
			{
				if(r_RCompile_ValidationEventHandler_XmlResolver == null)
				{
					r_RCompile_ValidationEventHandler_XmlResolver = new(this, "Compile", 0, typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.Xml.XmlResolver));
					r_RCompile_ValidationEventHandler_XmlResolver.SetBelong(this.instance);
				}
				return r_RCompile_ValidationEventHandler_XmlResolver;
			}
		}

		/// <summary>
		/// Boolean CompileSchema(System.Xml.Schema.XmlSchemaCollection, System.Xml.XmlResolver, System.Xml.Schema.SchemaInfo, System.String, System.Xml.Schema.ValidationEventHandler, System.Xml.XmlNameTable, Boolean)
		/// </summary>
		protected RMethod r_RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean;
		public virtual RMethod RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean
		{
			get
			{
				if(r_RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean == null)
				{
					r_RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean = new(this, "CompileSchema", 0, typeof(System.Xml.Schema.XmlSchemaCollection), typeof(System.Xml.XmlResolver),  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.String), typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.Xml.XmlNameTable), typeof(System.Boolean));
					r_RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean.SetBelong(this.instance);
				}
				return r_RCompileSchema_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean;
			}
		}

		/// <summary>
		/// Void CompileSchemaInSet(System.Xml.XmlNameTable, System.Xml.Schema.ValidationEventHandler, System.Xml.Schema.XmlSchemaCompilationSettings)
		/// </summary>
		protected RMethod r_RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings;
		public virtual RMethod RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings
		{
			get
			{
				if(r_RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings == null)
				{
					r_RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings = new(this, "CompileSchemaInSet", 0, typeof(System.Xml.XmlNameTable), typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.Xml.Schema.XmlSchemaCompilationSettings));
					r_RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings.SetBelong(this.instance);
				}
				return r_RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Clone()
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
		/// System.Xml.Schema.XmlSchema DeepClone()
		/// </summary>
		protected RMethod r_RDeepClone;
		public virtual RMethod RDeepClone
		{
			get
			{
				if(r_RDeepClone == null)
				{
					r_RDeepClone = new(this, "DeepClone", 0);
					r_RDeepClone.SetBelong(this.instance);
				}
				return r_RDeepClone;
			}
		}

		/// <summary>
		/// Void SetIsCompiled(Boolean)
		/// </summary>
		protected RMethod r_RSetIsCompiled_Boolean;
		public virtual RMethod RSetIsCompiled_Boolean
		{
			get
			{
				if(r_RSetIsCompiled_Boolean == null)
				{
					r_RSetIsCompiled_Boolean = new(this, "SetIsCompiled", 0, typeof(System.Boolean));
					r_RSetIsCompiled_Boolean.SetBelong(this.instance);
				}
				return r_RSetIsCompiled_Boolean;
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
		/// Void GetExternalSchemasList(System.Collections.IList, System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RGetExternalSchemasList_IList_XmlSchema;
		public virtual RMethod RGetExternalSchemasList_IList_XmlSchema
		{
			get
			{
				if(r_RGetExternalSchemasList_IList_XmlSchema == null)
				{
					r_RGetExternalSchemasList_IList_XmlSchema = new(this, "GetExternalSchemasList", 0, typeof(System.Collections.IList), typeof(System.Xml.Schema.XmlSchema));
					r_RGetExternalSchemasList_IList_XmlSchema.SetBelong(this.instance);
				}
				return r_RGetExternalSchemasList_IList_XmlSchema;
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


        public RXmlSchema() : base("System.Xml.Schema.XmlSchema")
        {
        }

        public RXmlSchema(System.Object instance) : base("System.Xml.Schema.XmlSchema")
		{
            SetInstance(instance);
		}

        public RXmlSchema(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchema(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Xml.Schema.XmlSchema Read(System.IO.TextReader  @reader, System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @validationEventHandler};
            var ___result = RRead_TextReader_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public static System.Xml.Schema.XmlSchema Read(System.IO.Stream  @stream, System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @validationEventHandler};
            var ___result = RRead_Stream_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public static System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader  @reader, System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @validationEventHandler};
            var ___result = RRead_XmlReader_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void Write(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RWrite_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.IO.Stream  @stream, System.Xml.XmlNamespaceManager  @namespaceManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @namespaceManager};
            var ___result = RWrite_Stream_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.IO.TextWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer};
            var ___result = RWrite_TextWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.IO.TextWriter  @writer, System.Xml.XmlNamespaceManager  @namespaceManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer, @namespaceManager};
            var ___result = RWrite_TextWriter_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Xml.XmlWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer};
            var ___result = RWrite_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Xml.XmlWriter  @writer, System.Xml.XmlNamespaceManager  @namespaceManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer, @namespaceManager};
            var ___result = RWrite_XmlWriter_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Compile(System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@validationEventHandler};
            var ___result = RCompile_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Compile(System.Xml.Schema.ValidationEventHandler  @validationEventHandler, System.Xml.XmlResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@validationEventHandler, @resolver};
            var ___result = RCompile_ValidationEventHandler_XmlResolver.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void CompileSchemaInSet(System.Xml.XmlNameTable  @nameTable, System.Xml.Schema.ValidationEventHandler  @eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings  @compilationSettings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameTable, @eventHandler, @compilationSettings};
            var ___result = RCompileSchemaInSet_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchema Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema DeepClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeepClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void SetIsCompiled(System.Boolean  @isCompiled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isCompiled};
            var ___result = RSetIsCompiled_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GetExternalSchemasList(System.Collections.IList  @extList, System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extList, @schema};
            var ___result = RGetExternalSchemasList_IList_XmlSchema.Invoke(___genericsType, ___parameters);

            
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
