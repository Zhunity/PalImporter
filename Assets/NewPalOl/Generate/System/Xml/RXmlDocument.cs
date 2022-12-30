using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlDocument
	/// </summary>
    public partial class RXmlDocument : RMember //
    {

		/// <summary>
		/// System.Xml.XmlImplementation implementation
		/// </summary>
		protected RSystem.RXml.RXmlImplementation r_implementation;
		public virtual RSystem.RXml.RXmlImplementation Rimplementation
		{
			get
			{
				if(r_implementation == null)
				{
					r_implementation = new(this, "implementation");
					r_implementation.SetBelong(this.instance);
				}
				return r_implementation;
			}
		}

		/// <summary>
		/// System.Xml.DomNameTable domNameTable
		/// </summary>
		protected RSystem.RXml.RDomNameTable r_domNameTable;
		public virtual RSystem.RXml.RDomNameTable RdomNameTable
		{
			get
			{
				if(r_domNameTable == null)
				{
					r_domNameTable = new(this, "domNameTable");
					r_domNameTable.SetBelong(this.instance);
				}
				return r_domNameTable;
			}
		}

		/// <summary>
		/// System.Xml.XmlLinkedNode lastChild
		/// </summary>
		protected RSystem.RXml.RXmlLinkedNode r_lastChild;
		public virtual RSystem.RXml.RXmlLinkedNode RlastChild
		{
			get
			{
				if(r_lastChild == null)
				{
					r_lastChild = new(this, "lastChild");
					r_lastChild.SetBelong(this.instance);
				}
				return r_lastChild;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamedNodeMap entities
		/// </summary>
		protected RSystem.RXml.RXmlNamedNodeMap r_entities;
		public virtual RSystem.RXml.RXmlNamedNodeMap Rentities
		{
			get
			{
				if(r_entities == null)
				{
					r_entities = new(this, "entities");
					r_entities.SetBelong(this.instance);
				}
				return r_entities;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable htElementIdMap
		/// </summary>
		protected RSystem.RCollections.RHashtable r_htElementIdMap;
		public virtual RSystem.RCollections.RHashtable RhtElementIdMap
		{
			get
			{
				if(r_htElementIdMap == null)
				{
					r_htElementIdMap = new(this, "htElementIdMap");
					r_htElementIdMap.SetBelong(this.instance);
				}
				return r_htElementIdMap;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable htElementIDAttrDecl
		/// </summary>
		protected RSystem.RCollections.RHashtable r_htElementIDAttrDecl;
		public virtual RSystem.RCollections.RHashtable RhtElementIDAttrDecl
		{
			get
			{
				if(r_htElementIDAttrDecl == null)
				{
					r_htElementIDAttrDecl = new(this, "htElementIDAttrDecl");
					r_htElementIDAttrDecl.SetBelong(this.instance);
				}
				return r_htElementIDAttrDecl;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo schemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_schemaInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RschemaInfo
		{
			get
			{
				if(r_schemaInfo == null)
				{
					r_schemaInfo = new(this, "schemaInfo");
					r_schemaInfo.SetBelong(this.instance);
				}
				return r_schemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSet schemas
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSet r_schemas;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSet Rschemas
		{
			get
			{
				if(r_schemas == null)
				{
					r_schemas = new(this, "schemas");
					r_schemas.SetBelong(this.instance);
				}
				return r_schemas;
			}
		}

		/// <summary>
		/// System.Boolean reportValidity
		/// </summary>
		protected RField r_reportValidity;
		public virtual RField RreportValidity
		{
			get
			{
				if(r_reportValidity == null)
				{
					r_reportValidity = new(this, "reportValidity");
					r_reportValidity.SetBelong(this.instance);
				}
				return r_reportValidity;
			}
		}

		/// <summary>
		/// System.Boolean actualLoadingStatus
		/// </summary>
		protected RField r_actualLoadingStatus;
		public virtual RField RactualLoadingStatus
		{
			get
			{
				if(r_actualLoadingStatus == null)
				{
					r_actualLoadingStatus = new(this, "actualLoadingStatus");
					r_actualLoadingStatus.SetBelong(this.instance);
				}
				return r_actualLoadingStatus;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeInsertingDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeInsertingDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeInsertingDelegate
		{
			get
			{
				if(r_onNodeInsertingDelegate == null)
				{
					r_onNodeInsertingDelegate = new(this, "onNodeInsertingDelegate");
					r_onNodeInsertingDelegate.SetBelong(this.instance);
				}
				return r_onNodeInsertingDelegate;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeInsertedDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeInsertedDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeInsertedDelegate
		{
			get
			{
				if(r_onNodeInsertedDelegate == null)
				{
					r_onNodeInsertedDelegate = new(this, "onNodeInsertedDelegate");
					r_onNodeInsertedDelegate.SetBelong(this.instance);
				}
				return r_onNodeInsertedDelegate;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeRemovingDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeRemovingDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeRemovingDelegate
		{
			get
			{
				if(r_onNodeRemovingDelegate == null)
				{
					r_onNodeRemovingDelegate = new(this, "onNodeRemovingDelegate");
					r_onNodeRemovingDelegate.SetBelong(this.instance);
				}
				return r_onNodeRemovingDelegate;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeRemovedDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeRemovedDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeRemovedDelegate
		{
			get
			{
				if(r_onNodeRemovedDelegate == null)
				{
					r_onNodeRemovedDelegate = new(this, "onNodeRemovedDelegate");
					r_onNodeRemovedDelegate.SetBelong(this.instance);
				}
				return r_onNodeRemovedDelegate;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeChangingDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeChangingDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeChangingDelegate
		{
			get
			{
				if(r_onNodeChangingDelegate == null)
				{
					r_onNodeChangingDelegate = new(this, "onNodeChangingDelegate");
					r_onNodeChangingDelegate.SetBelong(this.instance);
				}
				return r_onNodeChangingDelegate;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler onNodeChangedDelegate
		/// </summary>
		protected RSystem.RXml.RXmlNodeChangedEventHandler r_onNodeChangedDelegate;
		public virtual RSystem.RXml.RXmlNodeChangedEventHandler RonNodeChangedDelegate
		{
			get
			{
				if(r_onNodeChangedDelegate == null)
				{
					r_onNodeChangedDelegate = new(this, "onNodeChangedDelegate");
					r_onNodeChangedDelegate.SetBelong(this.instance);
				}
				return r_onNodeChangedDelegate;
			}
		}

		/// <summary>
		/// System.Boolean fEntRefNodesPresent
		/// </summary>
		protected RField r_fEntRefNodesPresent;
		public virtual RField RfEntRefNodesPresent
		{
			get
			{
				if(r_fEntRefNodesPresent == null)
				{
					r_fEntRefNodesPresent = new(this, "fEntRefNodesPresent");
					r_fEntRefNodesPresent.SetBelong(this.instance);
				}
				return r_fEntRefNodesPresent;
			}
		}

		/// <summary>
		/// System.Boolean fCDataNodesPresent
		/// </summary>
		protected RField r_fCDataNodesPresent;
		public virtual RField RfCDataNodesPresent
		{
			get
			{
				if(r_fCDataNodesPresent == null)
				{
					r_fCDataNodesPresent = new(this, "fCDataNodesPresent");
					r_fCDataNodesPresent.SetBelong(this.instance);
				}
				return r_fCDataNodesPresent;
			}
		}

		/// <summary>
		/// System.Boolean preserveWhitespace
		/// </summary>
		protected RField r_preserveWhitespace;
		public virtual RField RpreserveWhitespace
		{
			get
			{
				if(r_preserveWhitespace == null)
				{
					r_preserveWhitespace = new(this, "preserveWhitespace");
					r_preserveWhitespace.SetBelong(this.instance);
				}
				return r_preserveWhitespace;
			}
		}

		/// <summary>
		/// System.Boolean isLoading
		/// </summary>
		protected RField r_isLoading;
		public virtual RField RisLoading
		{
			get
			{
				if(r_isLoading == null)
				{
					r_isLoading = new(this, "isLoading");
					r_isLoading.SetBelong(this.instance);
				}
				return r_isLoading;
			}
		}

		/// <summary>
		/// System.String strDocumentName
		/// </summary>
		protected RField r_strDocumentName;
		public virtual RField RstrDocumentName
		{
			get
			{
				if(r_strDocumentName == null)
				{
					r_strDocumentName = new(this, "strDocumentName");
					r_strDocumentName.SetBelong(this.instance);
				}
				return r_strDocumentName;
			}
		}

		/// <summary>
		/// System.String strDocumentFragmentName
		/// </summary>
		protected RField r_strDocumentFragmentName;
		public virtual RField RstrDocumentFragmentName
		{
			get
			{
				if(r_strDocumentFragmentName == null)
				{
					r_strDocumentFragmentName = new(this, "strDocumentFragmentName");
					r_strDocumentFragmentName.SetBelong(this.instance);
				}
				return r_strDocumentFragmentName;
			}
		}

		/// <summary>
		/// System.String strCommentName
		/// </summary>
		protected RField r_strCommentName;
		public virtual RField RstrCommentName
		{
			get
			{
				if(r_strCommentName == null)
				{
					r_strCommentName = new(this, "strCommentName");
					r_strCommentName.SetBelong(this.instance);
				}
				return r_strCommentName;
			}
		}

		/// <summary>
		/// System.String strTextName
		/// </summary>
		protected RField r_strTextName;
		public virtual RField RstrTextName
		{
			get
			{
				if(r_strTextName == null)
				{
					r_strTextName = new(this, "strTextName");
					r_strTextName.SetBelong(this.instance);
				}
				return r_strTextName;
			}
		}

		/// <summary>
		/// System.String strCDataSectionName
		/// </summary>
		protected RField r_strCDataSectionName;
		public virtual RField RstrCDataSectionName
		{
			get
			{
				if(r_strCDataSectionName == null)
				{
					r_strCDataSectionName = new(this, "strCDataSectionName");
					r_strCDataSectionName.SetBelong(this.instance);
				}
				return r_strCDataSectionName;
			}
		}

		/// <summary>
		/// System.String strEntityName
		/// </summary>
		protected RField r_strEntityName;
		public virtual RField RstrEntityName
		{
			get
			{
				if(r_strEntityName == null)
				{
					r_strEntityName = new(this, "strEntityName");
					r_strEntityName.SetBelong(this.instance);
				}
				return r_strEntityName;
			}
		}

		/// <summary>
		/// System.String strID
		/// </summary>
		protected RField r_strID;
		public virtual RField RstrID
		{
			get
			{
				if(r_strID == null)
				{
					r_strID = new(this, "strID");
					r_strID.SetBelong(this.instance);
				}
				return r_strID;
			}
		}

		/// <summary>
		/// System.String strXmlns
		/// </summary>
		protected RField r_strXmlns;
		public virtual RField RstrXmlns
		{
			get
			{
				if(r_strXmlns == null)
				{
					r_strXmlns = new(this, "strXmlns");
					r_strXmlns.SetBelong(this.instance);
				}
				return r_strXmlns;
			}
		}

		/// <summary>
		/// System.String strXml
		/// </summary>
		protected RField r_strXml;
		public virtual RField RstrXml
		{
			get
			{
				if(r_strXml == null)
				{
					r_strXml = new(this, "strXml");
					r_strXml.SetBelong(this.instance);
				}
				return r_strXml;
			}
		}

		/// <summary>
		/// System.String strSpace
		/// </summary>
		protected RField r_strSpace;
		public virtual RField RstrSpace
		{
			get
			{
				if(r_strSpace == null)
				{
					r_strSpace = new(this, "strSpace");
					r_strSpace.SetBelong(this.instance);
				}
				return r_strSpace;
			}
		}

		/// <summary>
		/// System.String strLang
		/// </summary>
		protected RField r_strLang;
		public virtual RField RstrLang
		{
			get
			{
				if(r_strLang == null)
				{
					r_strLang = new(this, "strLang");
					r_strLang.SetBelong(this.instance);
				}
				return r_strLang;
			}
		}

		/// <summary>
		/// System.String strEmpty
		/// </summary>
		protected RField r_strEmpty;
		public virtual RField RstrEmpty
		{
			get
			{
				if(r_strEmpty == null)
				{
					r_strEmpty = new(this, "strEmpty");
					r_strEmpty.SetBelong(this.instance);
				}
				return r_strEmpty;
			}
		}

		/// <summary>
		/// System.String strNonSignificantWhitespaceName
		/// </summary>
		protected RField r_strNonSignificantWhitespaceName;
		public virtual RField RstrNonSignificantWhitespaceName
		{
			get
			{
				if(r_strNonSignificantWhitespaceName == null)
				{
					r_strNonSignificantWhitespaceName = new(this, "strNonSignificantWhitespaceName");
					r_strNonSignificantWhitespaceName.SetBelong(this.instance);
				}
				return r_strNonSignificantWhitespaceName;
			}
		}

		/// <summary>
		/// System.String strSignificantWhitespaceName
		/// </summary>
		protected RField r_strSignificantWhitespaceName;
		public virtual RField RstrSignificantWhitespaceName
		{
			get
			{
				if(r_strSignificantWhitespaceName == null)
				{
					r_strSignificantWhitespaceName = new(this, "strSignificantWhitespaceName");
					r_strSignificantWhitespaceName.SetBelong(this.instance);
				}
				return r_strSignificantWhitespaceName;
			}
		}

		/// <summary>
		/// System.String strReservedXmlns
		/// </summary>
		protected RField r_strReservedXmlns;
		public virtual RField RstrReservedXmlns
		{
			get
			{
				if(r_strReservedXmlns == null)
				{
					r_strReservedXmlns = new(this, "strReservedXmlns");
					r_strReservedXmlns.SetBelong(this.instance);
				}
				return r_strReservedXmlns;
			}
		}

		/// <summary>
		/// System.String strReservedXml
		/// </summary>
		protected RField r_strReservedXml;
		public virtual RField RstrReservedXml
		{
			get
			{
				if(r_strReservedXml == null)
				{
					r_strReservedXml = new(this, "strReservedXml");
					r_strReservedXml.SetBelong(this.instance);
				}
				return r_strReservedXml;
			}
		}

		/// <summary>
		/// System.String baseURI
		/// </summary>
		protected RField r_baseURI;
		public virtual RField RbaseURI
		{
			get
			{
				if(r_baseURI == null)
				{
					r_baseURI = new(this, "baseURI");
					r_baseURI.SetBelong(this.instance);
				}
				return r_baseURI;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver resolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_resolver;
		public virtual RSystem.RXml.RXmlResolver Rresolver
		{
			get
			{
				if(r_resolver == null)
				{
					r_resolver = new(this, "resolver");
					r_resolver.SetBelong(this.instance);
				}
				return r_resolver;
			}
		}

		/// <summary>
		/// System.Boolean bSetResolver
		/// </summary>
		protected RField r_bSetResolver;
		public virtual RField RbSetResolver
		{
			get
			{
				if(r_bSetResolver == null)
				{
					r_bSetResolver = new(this, "bSetResolver");
					r_bSetResolver.SetBelong(this.instance);
				}
				return r_bSetResolver;
			}
		}

		/// <summary>
		/// System.Object objLock
		/// </summary>
		protected RSystem.RObject r_objLock;
		public virtual RSystem.RObject RobjLock
		{
			get
			{
				if(r_objLock == null)
				{
					r_objLock = new(this, "objLock");
					r_objLock.SetBelong(this.instance);
				}
				return r_objLock;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute namespaceXml
		/// </summary>
		protected RSystem.RXml.RXmlAttribute r_namespaceXml;
		public virtual RSystem.RXml.RXmlAttribute RnamespaceXml
		{
			get
			{
				if(r_namespaceXml == null)
				{
					r_namespaceXml = new(this, "namespaceXml");
					r_namespaceXml.SetBelong(this.instance);
				}
				return r_namespaceXml;
			}
		}

		/// <summary>
		/// System.Xml.EmptyEnumerator EmptyEnumerator
		/// </summary>
		protected static RSystem.RXml.REmptyEnumerator r_EmptyEnumerator;
		public static RSystem.RXml.REmptyEnumerator REmptyEnumerator
		{
			get
			{
				if(r_EmptyEnumerator == null)
				{
					r_EmptyEnumerator = new(typeof(System.Xml.XmlDocument), "EmptyEnumerator");
					r_EmptyEnumerator.SetBelong(null);
				}
				return r_EmptyEnumerator;
			}
		}

		/// <summary>
		/// System.Xml.Schema.IXmlSchemaInfo NotKnownSchemaInfo
		/// </summary>
		protected static RSystem.RXml.RSchema.RIXmlSchemaInfo r_NotKnownSchemaInfo;
		public static RSystem.RXml.RSchema.RIXmlSchemaInfo RNotKnownSchemaInfo
		{
			get
			{
				if(r_NotKnownSchemaInfo == null)
				{
					r_NotKnownSchemaInfo = new(typeof(System.Xml.XmlDocument), "NotKnownSchemaInfo");
					r_NotKnownSchemaInfo.SetBelong(null);
				}
				return r_NotKnownSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.Schema.IXmlSchemaInfo ValidSchemaInfo
		/// </summary>
		protected static RSystem.RXml.RSchema.RIXmlSchemaInfo r_ValidSchemaInfo;
		public static RSystem.RXml.RSchema.RIXmlSchemaInfo RValidSchemaInfo
		{
			get
			{
				if(r_ValidSchemaInfo == null)
				{
					r_ValidSchemaInfo = new(typeof(System.Xml.XmlDocument), "ValidSchemaInfo");
					r_ValidSchemaInfo.SetBelong(null);
				}
				return r_ValidSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.Schema.IXmlSchemaInfo InvalidSchemaInfo
		/// </summary>
		protected static RSystem.RXml.RSchema.RIXmlSchemaInfo r_InvalidSchemaInfo;
		public static RSystem.RXml.RSchema.RIXmlSchemaInfo RInvalidSchemaInfo
		{
			get
			{
				if(r_InvalidSchemaInfo == null)
				{
					r_InvalidSchemaInfo = new(typeof(System.Xml.XmlDocument), "InvalidSchemaInfo");
					r_InvalidSchemaInfo.SetBelong(null);
				}
				return r_InvalidSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode parentNode
		/// </summary>
		protected RSystem.RXml.RXmlNode r_parentNode;
		public virtual RSystem.RXml.RXmlNode RparentNode
		{
			get
			{
				if(r_parentNode == null)
				{
					r_parentNode = new(this, "parentNode");
					r_parentNode.SetBelong(this.instance);
				}
				return r_parentNode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo DtdSchemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_DtdSchemaInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RDtdSchemaInfo
		{
			get
			{
				if(r_DtdSchemaInfo == null)
				{
					r_DtdSchemaInfo = new(this, "DtdSchemaInfo", -1);
					r_DtdSchemaInfo.SetBelong(this.instance);
				}
				return r_DtdSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType NodeType
		/// </summary>
		protected RProperty r_NodeType;
		public virtual RProperty RNodeType
		{
			get
			{
				if(r_NodeType == null)
				{
					r_NodeType = new(this, "NodeType", -1);
					r_NodeType.SetBelong(this.instance);
				}
				return r_NodeType;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ParentNode
		/// </summary>
		protected RSystem.RXml.RXmlNode r_ParentNode;
		public virtual RSystem.RXml.RXmlNode RParentNode
		{
			get
			{
				if(r_ParentNode == null)
				{
					r_ParentNode = new(this, "ParentNode", -1);
					r_ParentNode.SetBelong(this.instance);
				}
				return r_ParentNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocumentType DocumentType
		/// </summary>
		protected RSystem.RXml.RXmlDocumentType r_DocumentType;
		public virtual RSystem.RXml.RXmlDocumentType RDocumentType
		{
			get
			{
				if(r_DocumentType == null)
				{
					r_DocumentType = new(this, "DocumentType", -1);
					r_DocumentType.SetBelong(this.instance);
				}
				return r_DocumentType;
			}
		}

		/// <summary>
		/// System.Xml.XmlDeclaration Declaration
		/// </summary>
		protected RSystem.RXml.RXmlDeclaration r_Declaration;
		public virtual RSystem.RXml.RXmlDeclaration RDeclaration
		{
			get
			{
				if(r_Declaration == null)
				{
					r_Declaration = new(this, "Declaration", -1);
					r_Declaration.SetBelong(this.instance);
				}
				return r_Declaration;
			}
		}

		/// <summary>
		/// System.Xml.XmlImplementation Implementation
		/// </summary>
		protected RSystem.RXml.RXmlImplementation r_Implementation;
		public virtual RSystem.RXml.RXmlImplementation RImplementation
		{
			get
			{
				if(r_Implementation == null)
				{
					r_Implementation = new(this, "Implementation", -1);
					r_Implementation.SetBelong(this.instance);
				}
				return r_Implementation;
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
		/// System.Xml.XmlElement DocumentElement
		/// </summary>
		protected RSystem.RXml.RXmlElement r_DocumentElement;
		public virtual RSystem.RXml.RXmlElement RDocumentElement
		{
			get
			{
				if(r_DocumentElement == null)
				{
					r_DocumentElement = new(this, "DocumentElement", -1);
					r_DocumentElement.SetBelong(this.instance);
				}
				return r_DocumentElement;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected RProperty r_IsContainer;
		public virtual RProperty RIsContainer
		{
			get
			{
				if(r_IsContainer == null)
				{
					r_IsContainer = new(this, "IsContainer", -1);
					r_IsContainer.SetBelong(this.instance);
				}
				return r_IsContainer;
			}
		}

		/// <summary>
		/// System.Xml.XmlLinkedNode LastNode
		/// </summary>
		protected RSystem.RXml.RXmlLinkedNode r_LastNode;
		public virtual RSystem.RXml.RXmlLinkedNode RLastNode
		{
			get
			{
				if(r_LastNode == null)
				{
					r_LastNode = new(this, "LastNode", -1);
					r_LastNode.SetBelong(this.instance);
				}
				return r_LastNode;
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
		/// System.Xml.Schema.XmlSchemaSet Schemas
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSet r_Schemas;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSet RSchemas
		{
			get
			{
				if(r_Schemas == null)
				{
					r_Schemas = new(this, "Schemas", -1);
					r_Schemas.SetBelong(this.instance);
				}
				return r_Schemas;
			}
		}

		/// <summary>
		/// Boolean CanReportValidity
		/// </summary>
		protected RProperty r_CanReportValidity;
		public virtual RProperty RCanReportValidity
		{
			get
			{
				if(r_CanReportValidity == null)
				{
					r_CanReportValidity = new(this, "CanReportValidity", -1);
					r_CanReportValidity.SetBelong(this.instance);
				}
				return r_CanReportValidity;
			}
		}

		/// <summary>
		/// Boolean HasSetResolver
		/// </summary>
		protected RProperty r_HasSetResolver;
		public virtual RProperty RHasSetResolver
		{
			get
			{
				if(r_HasSetResolver == null)
				{
					r_HasSetResolver = new(this, "HasSetResolver", -1);
					r_HasSetResolver.SetBelong(this.instance);
				}
				return r_HasSetResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver XmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_XmlResolver_XmlResolver;
		public virtual RSystem.RXml.RXmlResolver RXmlResolver_XmlResolver
		{
			get
			{
				if(r_XmlResolver_XmlResolver == null)
				{
					r_XmlResolver_XmlResolver = new(this, "XmlResolver", -1, typeof(System.Xml.XmlResolver));
					r_XmlResolver_XmlResolver.SetBelong(this.instance);
				}
				return r_XmlResolver_XmlResolver;
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
		/// Boolean PreserveWhitespace
		/// </summary>
		protected RProperty r_PreserveWhitespace;
		public virtual RProperty RPreserveWhitespace
		{
			get
			{
				if(r_PreserveWhitespace == null)
				{
					r_PreserveWhitespace = new(this, "PreserveWhitespace", -1);
					r_PreserveWhitespace.SetBelong(this.instance);
				}
				return r_PreserveWhitespace;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamedNodeMap Entities
		/// </summary>
		protected RSystem.RXml.RXmlNamedNodeMap r_Entities;
		public virtual RSystem.RXml.RXmlNamedNodeMap REntities
		{
			get
			{
				if(r_Entities == null)
				{
					r_Entities = new(this, "Entities", -1);
					r_Entities.SetBelong(this.instance);
				}
				return r_Entities;
			}
		}

		/// <summary>
		/// Boolean IsLoading
		/// </summary>
		protected RProperty r_IsLoading;
		public virtual RProperty RIsLoading
		{
			get
			{
				if(r_IsLoading == null)
				{
					r_IsLoading = new(this, "IsLoading", -1);
					r_IsLoading.SetBelong(this.instance);
				}
				return r_IsLoading;
			}
		}

		/// <summary>
		/// Boolean ActualLoadingStatus
		/// </summary>
		protected RProperty r_ActualLoadingStatus;
		public virtual RProperty RActualLoadingStatus
		{
			get
			{
				if(r_ActualLoadingStatus == null)
				{
					r_ActualLoadingStatus = new(this, "ActualLoadingStatus", -1);
					r_ActualLoadingStatus.SetBelong(this.instance);
				}
				return r_ActualLoadingStatus;
			}
		}

		/// <summary>
		/// System.Text.Encoding TextEncoding
		/// </summary>
		protected RSystem.RText.REncoding r_TextEncoding;
		public virtual RSystem.RText.REncoding RTextEncoding
		{
			get
			{
				if(r_TextEncoding == null)
				{
					r_TextEncoding = new(this, "TextEncoding", -1);
					r_TextEncoding.SetBelong(this.instance);
				}
				return r_TextEncoding;
			}
		}

		/// <summary>
		/// System.String InnerText
		/// </summary>
		protected RProperty r_InnerText_String;
		public virtual RProperty RInnerText_String
		{
			get
			{
				if(r_InnerText_String == null)
				{
					r_InnerText_String = new(this, "InnerText", -1, typeof(System.String));
					r_InnerText_String.SetBelong(this.instance);
				}
				return r_InnerText_String;
			}
		}

		/// <summary>
		/// System.String InnerXml
		/// </summary>
		protected RProperty r_InnerXml;
		public virtual RProperty RInnerXml
		{
			get
			{
				if(r_InnerXml == null)
				{
					r_InnerXml = new(this, "InnerXml", -1);
					r_InnerXml.SetBelong(this.instance);
				}
				return r_InnerXml;
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
		/// System.String Encoding
		/// </summary>
		protected RProperty r_Encoding;
		public virtual RProperty REncoding
		{
			get
			{
				if(r_Encoding == null)
				{
					r_Encoding = new(this, "Encoding", -1);
					r_Encoding.SetBelong(this.instance);
				}
				return r_Encoding;
			}
		}

		/// <summary>
		/// System.String Standalone
		/// </summary>
		protected RProperty r_Standalone;
		public virtual RProperty RStandalone
		{
			get
			{
				if(r_Standalone == null)
				{
					r_Standalone = new(this, "Standalone", -1);
					r_Standalone.SetBelong(this.instance);
				}
				return r_Standalone;
			}
		}

		/// <summary>
		/// System.Xml.Schema.IXmlSchemaInfo SchemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RIXmlSchemaInfo r_SchemaInfo;
		public virtual RSystem.RXml.RSchema.RIXmlSchemaInfo RSchemaInfo
		{
			get
			{
				if(r_SchemaInfo == null)
				{
					r_SchemaInfo = new(this, "SchemaInfo", -1);
					r_SchemaInfo.SetBelong(this.instance);
				}
				return r_SchemaInfo;
			}
		}

		/// <summary>
		/// System.String BaseURI
		/// </summary>
		protected RProperty r_BaseURI;
		public virtual RProperty RBaseURI
		{
			get
			{
				if(r_BaseURI == null)
				{
					r_BaseURI = new(this, "BaseURI", -1);
					r_BaseURI.SetBelong(this.instance);
				}
				return r_BaseURI;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeType XPNodeType
		/// </summary>
		protected RProperty r_XPNodeType;
		public virtual RProperty RXPNodeType
		{
			get
			{
				if(r_XPNodeType == null)
				{
					r_XPNodeType = new(this, "XPNodeType", -1);
					r_XPNodeType.SetBelong(this.instance);
				}
				return r_XPNodeType;
			}
		}

		/// <summary>
		/// Boolean HasEntityReferences
		/// </summary>
		protected RProperty r_HasEntityReferences;
		public virtual RProperty RHasEntityReferences
		{
			get
			{
				if(r_HasEntityReferences == null)
				{
					r_HasEntityReferences = new(this, "HasEntityReferences", -1);
					r_HasEntityReferences.SetBelong(this.instance);
				}
				return r_HasEntityReferences;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute NamespaceXml
		/// </summary>
		protected RSystem.RXml.RXmlAttribute r_NamespaceXml;
		public virtual RSystem.RXml.RXmlAttribute RNamespaceXml
		{
			get
			{
				if(r_NamespaceXml == null)
				{
					r_NamespaceXml = new(this, "NamespaceXml", -1);
					r_NamespaceXml.SetBelong(this.instance);
				}
				return r_NamespaceXml;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeList ChildNodes
		/// </summary>
		protected RSystem.RXml.RXmlNodeList r_ChildNodes;
		public virtual RSystem.RXml.RXmlNodeList RChildNodes
		{
			get
			{
				if(r_ChildNodes == null)
				{
					r_ChildNodes = new(this, "ChildNodes", -1);
					r_ChildNodes.SetBelong(this.instance);
				}
				return r_ChildNodes;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode PreviousSibling
		/// </summary>
		protected RSystem.RXml.RXmlNode r_PreviousSibling;
		public virtual RSystem.RXml.RXmlNode RPreviousSibling
		{
			get
			{
				if(r_PreviousSibling == null)
				{
					r_PreviousSibling = new(this, "PreviousSibling", -1);
					r_PreviousSibling.SetBelong(this.instance);
				}
				return r_PreviousSibling;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode NextSibling
		/// </summary>
		protected RSystem.RXml.RXmlNode r_NextSibling;
		public virtual RSystem.RXml.RXmlNode RNextSibling
		{
			get
			{
				if(r_NextSibling == null)
				{
					r_NextSibling = new(this, "NextSibling", -1);
					r_NextSibling.SetBelong(this.instance);
				}
				return r_NextSibling;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttributeCollection Attributes
		/// </summary>
		protected RSystem.RXml.RXmlAttributeCollection r_Attributes;
		public virtual RSystem.RXml.RXmlAttributeCollection RAttributes
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
		/// System.Xml.XmlNode FirstChild
		/// </summary>
		protected RSystem.RXml.RXmlNode r_FirstChild;
		public virtual RSystem.RXml.RXmlNode RFirstChild
		{
			get
			{
				if(r_FirstChild == null)
				{
					r_FirstChild = new(this, "FirstChild", -1);
					r_FirstChild.SetBelong(this.instance);
				}
				return r_FirstChild;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode LastChild
		/// </summary>
		protected RSystem.RXml.RXmlNode r_LastChild;
		public virtual RSystem.RXml.RXmlNode RLastChild
		{
			get
			{
				if(r_LastChild == null)
				{
					r_LastChild = new(this, "LastChild", -1);
					r_LastChild.SetBelong(this.instance);
				}
				return r_LastChild;
			}
		}

		/// <summary>
		/// Boolean HasChildNodes
		/// </summary>
		protected RProperty r_HasChildNodes;
		public virtual RProperty RHasChildNodes
		{
			get
			{
				if(r_HasChildNodes == null)
				{
					r_HasChildNodes = new(this, "HasChildNodes", -1);
					r_HasChildNodes.SetBelong(this.instance);
				}
				return r_HasChildNodes;
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
		/// System.String OuterXml
		/// </summary>
		protected RProperty r_OuterXml;
		public virtual RProperty ROuterXml
		{
			get
			{
				if(r_OuterXml == null)
				{
					r_OuterXml = new(this, "OuterXml", -1);
					r_OuterXml.SetBelong(this.instance);
				}
				return r_OuterXml;
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
		/// System.Xml.XmlElement Item [System.String]
		/// </summary>
		protected RSystem.RXml.RXmlElement r_Item_String;
		public virtual RSystem.RXml.RXmlElement RItem_String
		{
			get
			{
				if(r_Item_String == null)
				{
					r_Item_String = new(this, "Item", -1, typeof(System.String));
					r_Item_String.SetBelong(this.instance);
				}
				return r_Item_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlElement Item [System.String, System.String]
		/// </summary>
		protected RSystem.RXml.RXmlElement r_Item_String_String;
		public virtual RSystem.RXml.RXmlElement RItem_String_String
		{
			get
			{
				if(r_Item_String_String == null)
				{
					r_Item_String_String = new(this, "Item", -1, typeof(System.String), typeof(System.String));
					r_Item_String_String.SetBelong(this.instance);
				}
				return r_Item_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlSpace XmlSpace
		/// </summary>
		protected RProperty r_XmlSpace;
		public virtual RProperty RXmlSpace
		{
			get
			{
				if(r_XmlSpace == null)
				{
					r_XmlSpace = new(this, "XmlSpace", -1);
					r_XmlSpace.SetBelong(this.instance);
				}
				return r_XmlSpace;
			}
		}

		/// <summary>
		/// System.String XmlLang
		/// </summary>
		protected RProperty r_XmlLang;
		public virtual RProperty RXmlLang
		{
			get
			{
				if(r_XmlLang == null)
				{
					r_XmlLang = new(this, "XmlLang", -1);
					r_XmlLang.SetBelong(this.instance);
				}
				return r_XmlLang;
			}
		}

		/// <summary>
		/// System.String XPLocalName
		/// </summary>
		protected RProperty r_XPLocalName;
		public virtual RProperty RXPLocalName
		{
			get
			{
				if(r_XPLocalName == null)
				{
					r_XPLocalName = new(this, "XPLocalName", -1);
					r_XPLocalName.SetBelong(this.instance);
				}
				return r_XPLocalName;
			}
		}

		/// <summary>
		/// Boolean IsText
		/// </summary>
		protected RProperty r_IsText;
		public virtual RProperty RIsText
		{
			get
			{
				if(r_IsText == null)
				{
					r_IsText = new(this, "IsText", -1);
					r_IsText.SetBelong(this.instance);
				}
				return r_IsText;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode PreviousText
		/// </summary>
		protected RSystem.RXml.RXmlNode r_PreviousText;
		public virtual RSystem.RXml.RXmlNode RPreviousText
		{
			get
			{
				if(r_PreviousText == null)
				{
					r_PreviousText = new(this, "PreviousText", -1);
					r_PreviousText.SetBelong(this.instance);
				}
				return r_PreviousText;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeInserting
		/// </summary>
		protected REvent r_NodeInserting;
		public virtual REvent RNodeInserting
		{
			get
			{
				if(r_NodeInserting == null)
				{
					r_NodeInserting = new(this, "NodeInserting");
					r_NodeInserting.SetBelong(this.instance);
				}
				return r_NodeInserting;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeInserted
		/// </summary>
		protected REvent r_NodeInserted;
		public virtual REvent RNodeInserted
		{
			get
			{
				if(r_NodeInserted == null)
				{
					r_NodeInserted = new(this, "NodeInserted");
					r_NodeInserted.SetBelong(this.instance);
				}
				return r_NodeInserted;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeRemoving
		/// </summary>
		protected REvent r_NodeRemoving;
		public virtual REvent RNodeRemoving
		{
			get
			{
				if(r_NodeRemoving == null)
				{
					r_NodeRemoving = new(this, "NodeRemoving");
					r_NodeRemoving.SetBelong(this.instance);
				}
				return r_NodeRemoving;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeRemoved
		/// </summary>
		protected REvent r_NodeRemoved;
		public virtual REvent RNodeRemoved
		{
			get
			{
				if(r_NodeRemoved == null)
				{
					r_NodeRemoved = new(this, "NodeRemoved");
					r_NodeRemoved.SetBelong(this.instance);
				}
				return r_NodeRemoved;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeChanging
		/// </summary>
		protected REvent r_NodeChanging;
		public virtual REvent RNodeChanging
		{
			get
			{
				if(r_NodeChanging == null)
				{
					r_NodeChanging = new(this, "NodeChanging");
					r_NodeChanging.SetBelong(this.instance);
				}
				return r_NodeChanging;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventHandler NodeChanged
		/// </summary>
		protected REvent r_NodeChanged;
		public virtual REvent RNodeChanged
		{
			get
			{
				if(r_NodeChanged == null)
				{
					r_NodeChanged = new(this, "NodeChanged");
					r_NodeChanged.SetBelong(this.instance);
				}
				return r_NodeChanged;
			}
		}

		/// <summary>
		/// Void CheckName(System.String)
		/// </summary>
		protected static RMethod r_RCheckName_String;
		public static RMethod RCheckName_String
		{
			get
			{
				if(r_RCheckName_String == null)
				{
					r_RCheckName_String = new(typeof(System.Xml.XmlDocument), "CheckName", 0, typeof(System.String));
					r_RCheckName_String.SetBelong(null);
				}
				return r_RCheckName_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlName AddXmlName(System.String, System.String, System.String, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_RAddXmlName_String_String_String_IXmlSchemaInfo;
		public virtual RMethod RAddXmlName_String_String_String_IXmlSchemaInfo
		{
			get
			{
				if(r_RAddXmlName_String_String_String_IXmlSchemaInfo == null)
				{
					r_RAddXmlName_String_String_String_IXmlSchemaInfo = new(this, "AddXmlName", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RAddXmlName_String_String_String_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_RAddXmlName_String_String_String_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlName GetXmlName(System.String, System.String, System.String, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_RGetXmlName_String_String_String_IXmlSchemaInfo;
		public virtual RMethod RGetXmlName_String_String_String_IXmlSchemaInfo
		{
			get
			{
				if(r_RGetXmlName_String_String_String_IXmlSchemaInfo == null)
				{
					r_RGetXmlName_String_String_String_IXmlSchemaInfo = new(this, "GetXmlName", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RGetXmlName_String_String_String_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_RGetXmlName_String_String_String_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlName AddAttrXmlName(System.String, System.String, System.String, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_RAddAttrXmlName_String_String_String_IXmlSchemaInfo;
		public virtual RMethod RAddAttrXmlName_String_String_String_IXmlSchemaInfo
		{
			get
			{
				if(r_RAddAttrXmlName_String_String_String_IXmlSchemaInfo == null)
				{
					r_RAddAttrXmlName_String_String_String_IXmlSchemaInfo = new(this, "AddAttrXmlName", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RAddAttrXmlName_String_String_String_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_RAddAttrXmlName_String_String_String_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// Boolean AddIdInfo(System.Xml.XmlName, System.Xml.XmlName)
		/// </summary>
		protected RMethod r_RAddIdInfo_XmlName_XmlName;
		public virtual RMethod RAddIdInfo_XmlName_XmlName
		{
			get
			{
				if(r_RAddIdInfo_XmlName_XmlName == null)
				{
					r_RAddIdInfo_XmlName_XmlName = new(this, "AddIdInfo", 0,  ReleactionUtils.GetType("System.Xml.XmlName"),  ReleactionUtils.GetType("System.Xml.XmlName"));
					r_RAddIdInfo_XmlName_XmlName.SetBelong(this.instance);
				}
				return r_RAddIdInfo_XmlName_XmlName;
			}
		}

		/// <summary>
		/// System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName)
		/// </summary>
		protected RMethod r_RGetIDInfoByElement__XmlName;
		public virtual RMethod RGetIDInfoByElement__XmlName
		{
			get
			{
				if(r_RGetIDInfoByElement__XmlName == null)
				{
					r_RGetIDInfoByElement__XmlName = new(this, "GetIDInfoByElement_", 0,  ReleactionUtils.GetType("System.Xml.XmlName"));
					r_RGetIDInfoByElement__XmlName.SetBelong(this.instance);
				}
				return r_RGetIDInfoByElement__XmlName;
			}
		}

		/// <summary>
		/// System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName)
		/// </summary>
		protected RMethod r_RGetIDInfoByElement_XmlName;
		public virtual RMethod RGetIDInfoByElement_XmlName
		{
			get
			{
				if(r_RGetIDInfoByElement_XmlName == null)
				{
					r_RGetIDInfoByElement_XmlName = new(this, "GetIDInfoByElement", 0,  ReleactionUtils.GetType("System.Xml.XmlName"));
					r_RGetIDInfoByElement_XmlName.SetBelong(this.instance);
				}
				return r_RGetIDInfoByElement_XmlName;
			}
		}

		/// <summary>
		/// System.WeakReference GetElement(System.Collections.ArrayList, System.Xml.XmlElement)
		/// </summary>
		protected RMethod r_RGetElement_ArrayList_XmlElement;
		public virtual RMethod RGetElement_ArrayList_XmlElement
		{
			get
			{
				if(r_RGetElement_ArrayList_XmlElement == null)
				{
					r_RGetElement_ArrayList_XmlElement = new(this, "GetElement", 0, typeof(System.Collections.ArrayList), typeof(System.Xml.XmlElement));
					r_RGetElement_ArrayList_XmlElement.SetBelong(this.instance);
				}
				return r_RGetElement_ArrayList_XmlElement;
			}
		}

		/// <summary>
		/// Void AddElementWithId(System.String, System.Xml.XmlElement)
		/// </summary>
		protected RMethod r_RAddElementWithId_String_XmlElement;
		public virtual RMethod RAddElementWithId_String_XmlElement
		{
			get
			{
				if(r_RAddElementWithId_String_XmlElement == null)
				{
					r_RAddElementWithId_String_XmlElement = new(this, "AddElementWithId", 0, typeof(System.String), typeof(System.Xml.XmlElement));
					r_RAddElementWithId_String_XmlElement.SetBelong(this.instance);
				}
				return r_RAddElementWithId_String_XmlElement;
			}
		}

		/// <summary>
		/// Void RemoveElementWithId(System.String, System.Xml.XmlElement)
		/// </summary>
		protected RMethod r_RRemoveElementWithId_String_XmlElement;
		public virtual RMethod RRemoveElementWithId_String_XmlElement
		{
			get
			{
				if(r_RRemoveElementWithId_String_XmlElement == null)
				{
					r_RRemoveElementWithId_String_XmlElement = new(this, "RemoveElementWithId", 0, typeof(System.String), typeof(System.Xml.XmlElement));
					r_RRemoveElementWithId_String_XmlElement.SetBelong(this.instance);
				}
				return r_RRemoveElementWithId_String_XmlElement;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode CloneNode(Boolean)
		/// </summary>
		protected RMethod r_RCloneNode_Boolean;
		public virtual RMethod RCloneNode_Boolean
		{
			get
			{
				if(r_RCloneNode_Boolean == null)
				{
					r_RCloneNode_Boolean = new(this, "CloneNode", 0, typeof(System.Boolean));
					r_RCloneNode_Boolean.SetBelong(this.instance);
				}
				return r_RCloneNode_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetResolver()
		/// </summary>
		protected RMethod r_RGetResolver;
		public virtual RMethod RGetResolver
		{
			get
			{
				if(r_RGetResolver == null)
				{
					r_RGetResolver = new(this, "GetResolver", 0);
					r_RGetResolver.SetBelong(this.instance);
				}
				return r_RGetResolver;
			}
		}

		/// <summary>
		/// Boolean IsValidChildType(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RIsValidChildType_XmlNodeType;
		public virtual RMethod RIsValidChildType_XmlNodeType
		{
			get
			{
				if(r_RIsValidChildType_XmlNodeType == null)
				{
					r_RIsValidChildType_XmlNodeType = new(this, "IsValidChildType", 0, typeof(System.Xml.XmlNodeType));
					r_RIsValidChildType_XmlNodeType.SetBelong(this.instance);
				}
				return r_RIsValidChildType_XmlNodeType;
			}
		}

		/// <summary>
		/// Boolean HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode;
		public virtual RMethod RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode
		{
			get
			{
				if(r_RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode == null)
				{
					r_RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode = new(this, "HasNodeTypeInPrevSiblings", 0, typeof(System.Xml.XmlNodeType), typeof(System.Xml.XmlNode));
					r_RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode.SetBelong(this.instance);
				}
				return r_RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode;
			}
		}

		/// <summary>
		/// Boolean HasNodeTypeInNextSiblings(System.Xml.XmlNodeType, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode;
		public virtual RMethod RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode
		{
			get
			{
				if(r_RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode == null)
				{
					r_RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode = new(this, "HasNodeTypeInNextSiblings", 0, typeof(System.Xml.XmlNodeType), typeof(System.Xml.XmlNode));
					r_RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode.SetBelong(this.instance);
				}
				return r_RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode;
			}
		}

		/// <summary>
		/// Boolean CanInsertBefore(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCanInsertBefore_XmlNode_XmlNode;
		public virtual RMethod RCanInsertBefore_XmlNode_XmlNode
		{
			get
			{
				if(r_RCanInsertBefore_XmlNode_XmlNode == null)
				{
					r_RCanInsertBefore_XmlNode_XmlNode = new(this, "CanInsertBefore", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RCanInsertBefore_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RCanInsertBefore_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// Boolean CanInsertAfter(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCanInsertAfter_XmlNode_XmlNode;
		public virtual RMethod RCanInsertAfter_XmlNode_XmlNode
		{
			get
			{
				if(r_RCanInsertAfter_XmlNode_XmlNode == null)
				{
					r_RCanInsertAfter_XmlNode_XmlNode = new(this, "CanInsertAfter", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RCanInsertAfter_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RCanInsertAfter_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute CreateAttribute(System.String)
		/// </summary>
		protected RMethod r_RCreateAttribute_String;
		public virtual RMethod RCreateAttribute_String
		{
			get
			{
				if(r_RCreateAttribute_String == null)
				{
					r_RCreateAttribute_String = new(this, "CreateAttribute", 0, typeof(System.String));
					r_RCreateAttribute_String.SetBelong(this.instance);
				}
				return r_RCreateAttribute_String;
			}
		}

		/// <summary>
		/// Void SetDefaultNamespace(System.String, System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_RSetDefaultNamespace_String_String_Ref_String;
		public virtual RMethod RSetDefaultNamespace_String_String_Ref_String
		{
			get
			{
				if(r_RSetDefaultNamespace_String_String_Ref_String == null)
				{
					r_RSetDefaultNamespace_String_String_Ref_String = new(this, "SetDefaultNamespace", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeByRefType());
					r_RSetDefaultNamespace_String_String_Ref_String.SetBelong(this.instance);
				}
				return r_RSetDefaultNamespace_String_String_Ref_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlCDataSection CreateCDataSection(System.String)
		/// </summary>
		protected RMethod r_RCreateCDataSection_String;
		public virtual RMethod RCreateCDataSection_String
		{
			get
			{
				if(r_RCreateCDataSection_String == null)
				{
					r_RCreateCDataSection_String = new(this, "CreateCDataSection", 0, typeof(System.String));
					r_RCreateCDataSection_String.SetBelong(this.instance);
				}
				return r_RCreateCDataSection_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlComment CreateComment(System.String)
		/// </summary>
		protected RMethod r_RCreateComment_String;
		public virtual RMethod RCreateComment_String
		{
			get
			{
				if(r_RCreateComment_String == null)
				{
					r_RCreateComment_String = new(this, "CreateComment", 0, typeof(System.String));
					r_RCreateComment_String.SetBelong(this.instance);
				}
				return r_RCreateComment_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocumentType CreateDocumentType(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateDocumentType_String_String_String_String;
		public virtual RMethod RCreateDocumentType_String_String_String_String
		{
			get
			{
				if(r_RCreateDocumentType_String_String_String_String == null)
				{
					r_RCreateDocumentType_String_String_String_String = new(this, "CreateDocumentType", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateDocumentType_String_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateDocumentType_String_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocumentFragment CreateDocumentFragment()
		/// </summary>
		protected RMethod r_RCreateDocumentFragment;
		public virtual RMethod RCreateDocumentFragment
		{
			get
			{
				if(r_RCreateDocumentFragment == null)
				{
					r_RCreateDocumentFragment = new(this, "CreateDocumentFragment", 0);
					r_RCreateDocumentFragment.SetBelong(this.instance);
				}
				return r_RCreateDocumentFragment;
			}
		}

		/// <summary>
		/// System.Xml.XmlElement CreateElement(System.String)
		/// </summary>
		protected RMethod r_RCreateElement_String;
		public virtual RMethod RCreateElement_String
		{
			get
			{
				if(r_RCreateElement_String == null)
				{
					r_RCreateElement_String = new(this, "CreateElement", 0, typeof(System.String));
					r_RCreateElement_String.SetBelong(this.instance);
				}
				return r_RCreateElement_String;
			}
		}

		/// <summary>
		/// Void AddDefaultAttributes(System.Xml.XmlElement)
		/// </summary>
		protected RMethod r_RAddDefaultAttributes_XmlElement;
		public virtual RMethod RAddDefaultAttributes_XmlElement
		{
			get
			{
				if(r_RAddDefaultAttributes_XmlElement == null)
				{
					r_RAddDefaultAttributes_XmlElement = new(this, "AddDefaultAttributes", 0, typeof(System.Xml.XmlElement));
					r_RAddDefaultAttributes_XmlElement.SetBelong(this.instance);
				}
				return r_RAddDefaultAttributes_XmlElement;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement)
		/// </summary>
		protected RMethod r_RGetSchemaElementDecl_XmlElement;
		public virtual RMethod RGetSchemaElementDecl_XmlElement
		{
			get
			{
				if(r_RGetSchemaElementDecl_XmlElement == null)
				{
					r_RGetSchemaElementDecl_XmlElement = new(this, "GetSchemaElementDecl", 0, typeof(System.Xml.XmlElement));
					r_RGetSchemaElementDecl_XmlElement.SetBelong(this.instance);
				}
				return r_RGetSchemaElementDecl_XmlElement;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RPrepareDefaultAttribute_SchemaAttDef_String_String_String;
		public virtual RMethod RPrepareDefaultAttribute_SchemaAttDef_String_String_String
		{
			get
			{
				if(r_RPrepareDefaultAttribute_SchemaAttDef_String_String_String == null)
				{
					r_RPrepareDefaultAttribute_SchemaAttDef_String_String_String = new(this, "PrepareDefaultAttribute", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaAttDef"), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RPrepareDefaultAttribute_SchemaAttDef_String_String_String.SetBelong(this.instance);
				}
				return r_RPrepareDefaultAttribute_SchemaAttDef_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlEntityReference CreateEntityReference(System.String)
		/// </summary>
		protected RMethod r_RCreateEntityReference_String;
		public virtual RMethod RCreateEntityReference_String
		{
			get
			{
				if(r_RCreateEntityReference_String == null)
				{
					r_RCreateEntityReference_String = new(this, "CreateEntityReference", 0, typeof(System.String));
					r_RCreateEntityReference_String.SetBelong(this.instance);
				}
				return r_RCreateEntityReference_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlProcessingInstruction CreateProcessingInstruction(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateProcessingInstruction_String_String;
		public virtual RMethod RCreateProcessingInstruction_String_String
		{
			get
			{
				if(r_RCreateProcessingInstruction_String_String == null)
				{
					r_RCreateProcessingInstruction_String_String = new(this, "CreateProcessingInstruction", 0, typeof(System.String), typeof(System.String));
					r_RCreateProcessingInstruction_String_String.SetBelong(this.instance);
				}
				return r_RCreateProcessingInstruction_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlDeclaration CreateXmlDeclaration(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateXmlDeclaration_String_String_String;
		public virtual RMethod RCreateXmlDeclaration_String_String_String
		{
			get
			{
				if(r_RCreateXmlDeclaration_String_String_String == null)
				{
					r_RCreateXmlDeclaration_String_String_String = new(this, "CreateXmlDeclaration", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateXmlDeclaration_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateXmlDeclaration_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlText CreateTextNode(System.String)
		/// </summary>
		protected RMethod r_RCreateTextNode_String;
		public virtual RMethod RCreateTextNode_String
		{
			get
			{
				if(r_RCreateTextNode_String == null)
				{
					r_RCreateTextNode_String = new(this, "CreateTextNode", 0, typeof(System.String));
					r_RCreateTextNode_String.SetBelong(this.instance);
				}
				return r_RCreateTextNode_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(System.String)
		/// </summary>
		protected RMethod r_RCreateSignificantWhitespace_String;
		public virtual RMethod RCreateSignificantWhitespace_String
		{
			get
			{
				if(r_RCreateSignificantWhitespace_String == null)
				{
					r_RCreateSignificantWhitespace_String = new(this, "CreateSignificantWhitespace", 0, typeof(System.String));
					r_RCreateSignificantWhitespace_String.SetBelong(this.instance);
				}
				return r_RCreateSignificantWhitespace_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNavigator CreateNavigator()
		/// </summary>
		protected RMethod r_RCreateNavigator;
		public virtual RMethod RCreateNavigator
		{
			get
			{
				if(r_RCreateNavigator == null)
				{
					r_RCreateNavigator = new(this, "CreateNavigator", 0);
					r_RCreateNavigator.SetBelong(this.instance);
				}
				return r_RCreateNavigator;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateNavigator_XmlNode;
		public virtual RMethod RCreateNavigator_XmlNode
		{
			get
			{
				if(r_RCreateNavigator_XmlNode == null)
				{
					r_RCreateNavigator_XmlNode = new(this, "CreateNavigator", 0, typeof(System.Xml.XmlNode));
					r_RCreateNavigator_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateNavigator_XmlNode;
			}
		}

		/// <summary>
		/// Boolean IsTextNode(System.Xml.XmlNodeType)
		/// </summary>
		protected static RMethod r_RIsTextNode_XmlNodeType;
		public static RMethod RIsTextNode_XmlNodeType
		{
			get
			{
				if(r_RIsTextNode_XmlNodeType == null)
				{
					r_RIsTextNode_XmlNodeType = new(typeof(System.Xml.XmlDocument), "IsTextNode", 0, typeof(System.Xml.XmlNodeType));
					r_RIsTextNode_XmlNodeType.SetBelong(null);
				}
				return r_RIsTextNode_XmlNodeType;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode NormalizeText(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RNormalizeText_XmlNode;
		public virtual RMethod RNormalizeText_XmlNode
		{
			get
			{
				if(r_RNormalizeText_XmlNode == null)
				{
					r_RNormalizeText_XmlNode = new(this, "NormalizeText", 0, typeof(System.Xml.XmlNode));
					r_RNormalizeText_XmlNode.SetBelong(this.instance);
				}
				return r_RNormalizeText_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlWhitespace CreateWhitespace(System.String)
		/// </summary>
		protected RMethod r_RCreateWhitespace_String;
		public virtual RMethod RCreateWhitespace_String
		{
			get
			{
				if(r_RCreateWhitespace_String == null)
				{
					r_RCreateWhitespace_String = new(this, "CreateWhitespace", 0, typeof(System.String));
					r_RCreateWhitespace_String.SetBelong(this.instance);
				}
				return r_RCreateWhitespace_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeList GetElementsByTagName(System.String)
		/// </summary>
		protected RMethod r_RGetElementsByTagName_String;
		public virtual RMethod RGetElementsByTagName_String
		{
			get
			{
				if(r_RGetElementsByTagName_String == null)
				{
					r_RGetElementsByTagName_String = new(this, "GetElementsByTagName", 0, typeof(System.String));
					r_RGetElementsByTagName_String.SetBelong(this.instance);
				}
				return r_RGetElementsByTagName_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute CreateAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateAttribute_String_String;
		public virtual RMethod RCreateAttribute_String_String
		{
			get
			{
				if(r_RCreateAttribute_String_String == null)
				{
					r_RCreateAttribute_String_String = new(this, "CreateAttribute", 0, typeof(System.String), typeof(System.String));
					r_RCreateAttribute_String_String.SetBelong(this.instance);
				}
				return r_RCreateAttribute_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlElement CreateElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateElement_String_String;
		public virtual RMethod RCreateElement_String_String
		{
			get
			{
				if(r_RCreateElement_String_String == null)
				{
					r_RCreateElement_String_String = new(this, "CreateElement", 0, typeof(System.String), typeof(System.String));
					r_RCreateElement_String_String.SetBelong(this.instance);
				}
				return r_RCreateElement_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeList GetElementsByTagName(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetElementsByTagName_String_String;
		public virtual RMethod RGetElementsByTagName_String_String
		{
			get
			{
				if(r_RGetElementsByTagName_String_String == null)
				{
					r_RGetElementsByTagName_String_String = new(this, "GetElementsByTagName", 0, typeof(System.String), typeof(System.String));
					r_RGetElementsByTagName_String_String.SetBelong(this.instance);
				}
				return r_RGetElementsByTagName_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlElement GetElementById(System.String)
		/// </summary>
		protected RMethod r_RGetElementById_String;
		public virtual RMethod RGetElementById_String
		{
			get
			{
				if(r_RGetElementById_String == null)
				{
					r_RGetElementById_String = new(this, "GetElementById", 0, typeof(System.String));
					r_RGetElementById_String.SetBelong(this.instance);
				}
				return r_RGetElementById_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ImportNode(System.Xml.XmlNode, Boolean)
		/// </summary>
		protected RMethod r_RImportNode_XmlNode_Boolean;
		public virtual RMethod RImportNode_XmlNode_Boolean
		{
			get
			{
				if(r_RImportNode_XmlNode_Boolean == null)
				{
					r_RImportNode_XmlNode_Boolean = new(this, "ImportNode", 0, typeof(System.Xml.XmlNode), typeof(System.Boolean));
					r_RImportNode_XmlNode_Boolean.SetBelong(this.instance);
				}
				return r_RImportNode_XmlNode_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode, Boolean)
		/// </summary>
		protected RMethod r_RImportNodeInternal_XmlNode_Boolean;
		public virtual RMethod RImportNodeInternal_XmlNode_Boolean
		{
			get
			{
				if(r_RImportNodeInternal_XmlNode_Boolean == null)
				{
					r_RImportNodeInternal_XmlNode_Boolean = new(this, "ImportNodeInternal", 0, typeof(System.Xml.XmlNode), typeof(System.Boolean));
					r_RImportNodeInternal_XmlNode_Boolean.SetBelong(this.instance);
				}
				return r_RImportNodeInternal_XmlNode_Boolean;
			}
		}

		/// <summary>
		/// Void ImportAttributes(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RImportAttributes_XmlNode_XmlNode;
		public virtual RMethod RImportAttributes_XmlNode_XmlNode
		{
			get
			{
				if(r_RImportAttributes_XmlNode_XmlNode == null)
				{
					r_RImportAttributes_XmlNode_XmlNode = new(this, "ImportAttributes", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RImportAttributes_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RImportAttributes_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// Void ImportChildren(System.Xml.XmlNode, System.Xml.XmlNode, Boolean)
		/// </summary>
		protected RMethod r_RImportChildren_XmlNode_XmlNode_Boolean;
		public virtual RMethod RImportChildren_XmlNode_XmlNode_Boolean
		{
			get
			{
				if(r_RImportChildren_XmlNode_XmlNode_Boolean == null)
				{
					r_RImportChildren_XmlNode_XmlNode_Boolean = new(this, "ImportChildren", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode), typeof(System.Boolean));
					r_RImportChildren_XmlNode_XmlNode_Boolean.SetBelong(this.instance);
				}
				return r_RImportChildren_XmlNode_XmlNode_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute CreateAttribute(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateAttribute_String_String_String;
		public virtual RMethod RCreateAttribute_String_String_String
		{
			get
			{
				if(r_RCreateAttribute_String_String_String == null)
				{
					r_RCreateAttribute_String_String_String = new(this, "CreateAttribute", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateAttribute_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateAttribute_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute CreateDefaultAttribute(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateDefaultAttribute_String_String_String;
		public virtual RMethod RCreateDefaultAttribute_String_String_String
		{
			get
			{
				if(r_RCreateDefaultAttribute_String_String_String == null)
				{
					r_RCreateDefaultAttribute_String_String_String = new(this, "CreateDefaultAttribute", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateDefaultAttribute_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateDefaultAttribute_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlElement CreateElement(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateElement_String_String_String;
		public virtual RMethod RCreateElement_String_String_String
		{
			get
			{
				if(r_RCreateElement_String_String_String == null)
				{
					r_RCreateElement_String_String_String = new(this, "CreateElement", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateElement_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateElement_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateNode_XmlNodeType_String_String_String;
		public virtual RMethod RCreateNode_XmlNodeType_String_String_String
		{
			get
			{
				if(r_RCreateNode_XmlNodeType_String_String_String == null)
				{
					r_RCreateNode_XmlNodeType_String_String_String = new(this, "CreateNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateNode_XmlNodeType_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateNode_XmlNodeType_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode CreateNode(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateNode_String_String_String;
		public virtual RMethod RCreateNode_String_String_String
		{
			get
			{
				if(r_RCreateNode_String_String_String == null)
				{
					r_RCreateNode_String_String_String = new(this, "CreateNode", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateNode_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateNode_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateNode_XmlNodeType_String_String;
		public virtual RMethod RCreateNode_XmlNodeType_String_String
		{
			get
			{
				if(r_RCreateNode_XmlNodeType_String_String == null)
				{
					r_RCreateNode_XmlNodeType_String_String = new(this, "CreateNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.String), typeof(System.String));
					r_RCreateNode_XmlNodeType_String_String.SetBelong(this.instance);
				}
				return r_RCreateNode_XmlNodeType_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ReadNode(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RReadNode_XmlReader;
		public virtual RMethod RReadNode_XmlReader
		{
			get
			{
				if(r_RReadNode_XmlReader == null)
				{
					r_RReadNode_XmlReader = new(this, "ReadNode", 0, typeof(System.Xml.XmlReader));
					r_RReadNode_XmlReader.SetBelong(this.instance);
				}
				return r_RReadNode_XmlReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType ConvertToNodeType(System.String)
		/// </summary>
		protected RMethod r_RConvertToNodeType_String;
		public virtual RMethod RConvertToNodeType_String
		{
			get
			{
				if(r_RConvertToNodeType_String == null)
				{
					r_RConvertToNodeType_String = new(this, "ConvertToNodeType", 0, typeof(System.String));
					r_RConvertToNodeType_String.SetBelong(this.instance);
				}
				return r_RConvertToNodeType_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader)
		/// </summary>
		protected RMethod r_RSetupReader_XmlTextReader;
		public virtual RMethod RSetupReader_XmlTextReader
		{
			get
			{
				if(r_RSetupReader_XmlTextReader == null)
				{
					r_RSetupReader_XmlTextReader = new(this, "SetupReader", 0, typeof(System.Xml.XmlTextReader));
					r_RSetupReader_XmlTextReader.SetBelong(this.instance);
				}
				return r_RSetupReader_XmlTextReader;
			}
		}

		/// <summary>
		/// Void Load(System.String)
		/// </summary>
		protected RMethod r_RLoad_String;
		public virtual RMethod RLoad_String
		{
			get
			{
				if(r_RLoad_String == null)
				{
					r_RLoad_String = new(this, "Load", 0, typeof(System.String));
					r_RLoad_String.SetBelong(this.instance);
				}
				return r_RLoad_String;
			}
		}

		/// <summary>
		/// Void Load(System.IO.Stream)
		/// </summary>
		protected RMethod r_RLoad_Stream;
		public virtual RMethod RLoad_Stream
		{
			get
			{
				if(r_RLoad_Stream == null)
				{
					r_RLoad_Stream = new(this, "Load", 0, typeof(System.IO.Stream));
					r_RLoad_Stream.SetBelong(this.instance);
				}
				return r_RLoad_Stream;
			}
		}

		/// <summary>
		/// Void Load(System.IO.TextReader)
		/// </summary>
		protected RMethod r_RLoad_TextReader;
		public virtual RMethod RLoad_TextReader
		{
			get
			{
				if(r_RLoad_TextReader == null)
				{
					r_RLoad_TextReader = new(this, "Load", 0, typeof(System.IO.TextReader));
					r_RLoad_TextReader.SetBelong(this.instance);
				}
				return r_RLoad_TextReader;
			}
		}

		/// <summary>
		/// Void Load(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RLoad_XmlReader;
		public virtual RMethod RLoad_XmlReader
		{
			get
			{
				if(r_RLoad_XmlReader == null)
				{
					r_RLoad_XmlReader = new(this, "Load", 0, typeof(System.Xml.XmlReader));
					r_RLoad_XmlReader.SetBelong(this.instance);
				}
				return r_RLoad_XmlReader;
			}
		}

		/// <summary>
		/// Void LoadXml(System.String)
		/// </summary>
		protected RMethod r_RLoadXml_String;
		public virtual RMethod RLoadXml_String
		{
			get
			{
				if(r_RLoadXml_String == null)
				{
					r_RLoadXml_String = new(this, "LoadXml", 0, typeof(System.String));
					r_RLoadXml_String.SetBelong(this.instance);
				}
				return r_RLoadXml_String;
			}
		}

		/// <summary>
		/// Void Save(System.String)
		/// </summary>
		protected RMethod r_RSave_String;
		public virtual RMethod RSave_String
		{
			get
			{
				if(r_RSave_String == null)
				{
					r_RSave_String = new(this, "Save", 0, typeof(System.String));
					r_RSave_String.SetBelong(this.instance);
				}
				return r_RSave_String;
			}
		}

		/// <summary>
		/// Void Save(System.IO.Stream)
		/// </summary>
		protected RMethod r_RSave_Stream;
		public virtual RMethod RSave_Stream
		{
			get
			{
				if(r_RSave_Stream == null)
				{
					r_RSave_Stream = new(this, "Save", 0, typeof(System.IO.Stream));
					r_RSave_Stream.SetBelong(this.instance);
				}
				return r_RSave_Stream;
			}
		}

		/// <summary>
		/// Void Save(System.IO.TextWriter)
		/// </summary>
		protected RMethod r_RSave_TextWriter;
		public virtual RMethod RSave_TextWriter
		{
			get
			{
				if(r_RSave_TextWriter == null)
				{
					r_RSave_TextWriter = new(this, "Save", 0, typeof(System.IO.TextWriter));
					r_RSave_TextWriter.SetBelong(this.instance);
				}
				return r_RSave_TextWriter;
			}
		}

		/// <summary>
		/// Void Save(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RSave_XmlWriter;
		public virtual RMethod RSave_XmlWriter
		{
			get
			{
				if(r_RSave_XmlWriter == null)
				{
					r_RSave_XmlWriter = new(this, "Save", 0, typeof(System.Xml.XmlWriter));
					r_RSave_XmlWriter.SetBelong(this.instance);
				}
				return r_RSave_XmlWriter;
			}
		}

		/// <summary>
		/// Void WriteTo(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RWriteTo_XmlWriter;
		public virtual RMethod RWriteTo_XmlWriter
		{
			get
			{
				if(r_RWriteTo_XmlWriter == null)
				{
					r_RWriteTo_XmlWriter = new(this, "WriteTo", 0, typeof(System.Xml.XmlWriter));
					r_RWriteTo_XmlWriter.SetBelong(this.instance);
				}
				return r_RWriteTo_XmlWriter;
			}
		}

		/// <summary>
		/// Void WriteContentTo(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RWriteContentTo_XmlWriter;
		public virtual RMethod RWriteContentTo_XmlWriter
		{
			get
			{
				if(r_RWriteContentTo_XmlWriter == null)
				{
					r_RWriteContentTo_XmlWriter = new(this, "WriteContentTo", 0, typeof(System.Xml.XmlWriter));
					r_RWriteContentTo_XmlWriter.SetBelong(this.instance);
				}
				return r_RWriteContentTo_XmlWriter;
			}
		}

		/// <summary>
		/// Void Validate(System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RValidate_ValidationEventHandler;
		public virtual RMethod RValidate_ValidationEventHandler
		{
			get
			{
				if(r_RValidate_ValidationEventHandler == null)
				{
					r_RValidate_ValidationEventHandler = new(this, "Validate", 0, typeof(System.Xml.Schema.ValidationEventHandler));
					r_RValidate_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RValidate_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void Validate(System.Xml.Schema.ValidationEventHandler, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RValidate_ValidationEventHandler_XmlNode;
		public virtual RMethod RValidate_ValidationEventHandler_XmlNode
		{
			get
			{
				if(r_RValidate_ValidationEventHandler_XmlNode == null)
				{
					r_RValidate_ValidationEventHandler_XmlNode = new(this, "Validate", 0, typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.Xml.XmlNode));
					r_RValidate_ValidationEventHandler_XmlNode.SetBelong(this.instance);
				}
				return r_RValidate_ValidationEventHandler_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode, System.Xml.XmlNode, System.Xml.XmlNode, System.String, System.String, System.Xml.XmlNodeChangedAction)
		/// </summary>
		protected RMethod r_RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction;
		public virtual RMethod RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction
		{
			get
			{
				if(r_RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction == null)
				{
					r_RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction = new(this, "GetEventArgs", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode), typeof(System.String), typeof(System.String), typeof(System.Xml.XmlNodeChangedAction));
					r_RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction.SetBelong(this.instance);
				}
				return r_RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RGetInsertEventArgsForLoad_XmlNode_XmlNode;
		public virtual RMethod RGetInsertEventArgsForLoad_XmlNode_XmlNode
		{
			get
			{
				if(r_RGetInsertEventArgsForLoad_XmlNode_XmlNode == null)
				{
					r_RGetInsertEventArgsForLoad_XmlNode_XmlNode = new(this, "GetInsertEventArgsForLoad", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RGetInsertEventArgsForLoad_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RGetInsertEventArgsForLoad_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// Void BeforeEvent(System.Xml.XmlNodeChangedEventArgs)
		/// </summary>
		protected RMethod r_RBeforeEvent_XmlNodeChangedEventArgs;
		public virtual RMethod RBeforeEvent_XmlNodeChangedEventArgs
		{
			get
			{
				if(r_RBeforeEvent_XmlNodeChangedEventArgs == null)
				{
					r_RBeforeEvent_XmlNodeChangedEventArgs = new(this, "BeforeEvent", 0, typeof(System.Xml.XmlNodeChangedEventArgs));
					r_RBeforeEvent_XmlNodeChangedEventArgs.SetBelong(this.instance);
				}
				return r_RBeforeEvent_XmlNodeChangedEventArgs;
			}
		}

		/// <summary>
		/// Void AfterEvent(System.Xml.XmlNodeChangedEventArgs)
		/// </summary>
		protected RMethod r_RAfterEvent_XmlNodeChangedEventArgs;
		public virtual RMethod RAfterEvent_XmlNodeChangedEventArgs
		{
			get
			{
				if(r_RAfterEvent_XmlNodeChangedEventArgs == null)
				{
					r_RAfterEvent_XmlNodeChangedEventArgs = new(this, "AfterEvent", 0, typeof(System.Xml.XmlNodeChangedEventArgs));
					r_RAfterEvent_XmlNodeChangedEventArgs.SetBelong(this.instance);
				}
				return r_RAfterEvent_XmlNodeChangedEventArgs;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RGetDefaultAttribute_XmlElement_String_String_String;
		public virtual RMethod RGetDefaultAttribute_XmlElement_String_String_String
		{
			get
			{
				if(r_RGetDefaultAttribute_XmlElement_String_String_String == null)
				{
					r_RGetDefaultAttribute_XmlElement_String_String_String = new(this, "GetDefaultAttribute", 0, typeof(System.Xml.XmlElement), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RGetDefaultAttribute_XmlElement_String_String_String.SetBelong(this.instance);
				}
				return r_RGetDefaultAttribute_XmlElement_String_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlEntity GetEntityNode(System.String)
		/// </summary>
		protected RMethod r_RGetEntityNode_String;
		public virtual RMethod RGetEntityNode_String
		{
			get
			{
				if(r_RGetEntityNode_String == null)
				{
					r_RGetEntityNode_String = new(this, "GetEntityNode", 0, typeof(System.String));
					r_RGetEntityNode_String.SetBelong(this.instance);
				}
				return r_RGetEntityNode_String;
			}
		}

		/// <summary>
		/// Void SetBaseURI(System.String)
		/// </summary>
		protected RMethod r_RSetBaseURI_String;
		public virtual RMethod RSetBaseURI_String
		{
			get
			{
				if(r_RSetBaseURI_String == null)
				{
					r_RSetBaseURI_String = new(this, "SetBaseURI", 0, typeof(System.String));
					r_RSetBaseURI_String.SetBelong(this.instance);
				}
				return r_RSetBaseURI_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode, System.Xml.XmlDocument)
		/// </summary>
		protected RMethod r_RAppendChildForLoad_XmlNode_XmlDocument;
		public virtual RMethod RAppendChildForLoad_XmlNode_XmlDocument
		{
			get
			{
				if(r_RAppendChildForLoad_XmlNode_XmlDocument == null)
				{
					r_RAppendChildForLoad_XmlNode_XmlDocument = new(this, "AppendChildForLoad", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlDocument));
					r_RAppendChildForLoad_XmlNode_XmlDocument.SetBelong(this.instance);
				}
				return r_RAppendChildForLoad_XmlNode_XmlDocument;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode SelectSingleNode(System.String)
		/// </summary>
		protected RMethod r_RSelectSingleNode_String;
		public virtual RMethod RSelectSingleNode_String
		{
			get
			{
				if(r_RSelectSingleNode_String == null)
				{
					r_RSelectSingleNode_String = new(this, "SelectSingleNode", 0, typeof(System.String));
					r_RSelectSingleNode_String.SetBelong(this.instance);
				}
				return r_RSelectSingleNode_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode SelectSingleNode(System.String, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RSelectSingleNode_String_XmlNamespaceManager;
		public virtual RMethod RSelectSingleNode_String_XmlNamespaceManager
		{
			get
			{
				if(r_RSelectSingleNode_String_XmlNamespaceManager == null)
				{
					r_RSelectSingleNode_String_XmlNamespaceManager = new(this, "SelectSingleNode", 0, typeof(System.String), typeof(System.Xml.XmlNamespaceManager));
					r_RSelectSingleNode_String_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RSelectSingleNode_String_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeList SelectNodes(System.String)
		/// </summary>
		protected RMethod r_RSelectNodes_String;
		public virtual RMethod RSelectNodes_String
		{
			get
			{
				if(r_RSelectNodes_String == null)
				{
					r_RSelectNodes_String = new(this, "SelectNodes", 0, typeof(System.String));
					r_RSelectNodes_String.SetBelong(this.instance);
				}
				return r_RSelectNodes_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeList SelectNodes(System.String, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RSelectNodes_String_XmlNamespaceManager;
		public virtual RMethod RSelectNodes_String_XmlNamespaceManager
		{
			get
			{
				if(r_RSelectNodes_String_XmlNamespaceManager == null)
				{
					r_RSelectNodes_String_XmlNamespaceManager = new(this, "SelectNodes", 0, typeof(System.String), typeof(System.Xml.XmlNamespaceManager));
					r_RSelectNodes_String_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RSelectNodes_String_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Boolean AncestorNode(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RAncestorNode_XmlNode;
		public virtual RMethod RAncestorNode_XmlNode
		{
			get
			{
				if(r_RAncestorNode_XmlNode == null)
				{
					r_RAncestorNode_XmlNode = new(this, "AncestorNode", 0, typeof(System.Xml.XmlNode));
					r_RAncestorNode_XmlNode.SetBelong(this.instance);
				}
				return r_RAncestorNode_XmlNode;
			}
		}

		/// <summary>
		/// Boolean IsConnected()
		/// </summary>
		protected RMethod r_RIsConnected;
		public virtual RMethod RIsConnected
		{
			get
			{
				if(r_RIsConnected == null)
				{
					r_RIsConnected = new(this, "IsConnected", 0);
					r_RIsConnected.SetBelong(this.instance);
				}
				return r_RIsConnected;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode InsertBefore(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RInsertBefore_XmlNode_XmlNode;
		public virtual RMethod RInsertBefore_XmlNode_XmlNode
		{
			get
			{
				if(r_RInsertBefore_XmlNode_XmlNode == null)
				{
					r_RInsertBefore_XmlNode_XmlNode = new(this, "InsertBefore", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RInsertBefore_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RInsertBefore_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode InsertAfter(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RInsertAfter_XmlNode_XmlNode;
		public virtual RMethod RInsertAfter_XmlNode_XmlNode
		{
			get
			{
				if(r_RInsertAfter_XmlNode_XmlNode == null)
				{
					r_RInsertAfter_XmlNode_XmlNode = new(this, "InsertAfter", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RInsertAfter_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RInsertAfter_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RReplaceChild_XmlNode_XmlNode;
		public virtual RMethod RReplaceChild_XmlNode_XmlNode
		{
			get
			{
				if(r_RReplaceChild_XmlNode_XmlNode == null)
				{
					r_RReplaceChild_XmlNode_XmlNode = new(this, "ReplaceChild", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlNode));
					r_RReplaceChild_XmlNode_XmlNode.SetBelong(this.instance);
				}
				return r_RReplaceChild_XmlNode_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode RemoveChild(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RRemoveChild_XmlNode;
		public virtual RMethod RRemoveChild_XmlNode
		{
			get
			{
				if(r_RRemoveChild_XmlNode == null)
				{
					r_RRemoveChild_XmlNode = new(this, "RemoveChild", 0, typeof(System.Xml.XmlNode));
					r_RRemoveChild_XmlNode.SetBelong(this.instance);
				}
				return r_RRemoveChild_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode PrependChild(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RPrependChild_XmlNode;
		public virtual RMethod RPrependChild_XmlNode
		{
			get
			{
				if(r_RPrependChild_XmlNode == null)
				{
					r_RPrependChild_XmlNode = new(this, "PrependChild", 0, typeof(System.Xml.XmlNode));
					r_RPrependChild_XmlNode.SetBelong(this.instance);
				}
				return r_RPrependChild_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode AppendChild(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RAppendChild_XmlNode;
		public virtual RMethod RAppendChild_XmlNode
		{
			get
			{
				if(r_RAppendChild_XmlNode == null)
				{
					r_RAppendChild_XmlNode = new(this, "AppendChild", 0, typeof(System.Xml.XmlNode));
					r_RAppendChild_XmlNode.SetBelong(this.instance);
				}
				return r_RAppendChild_XmlNode;
			}
		}

		/// <summary>
		/// Void CopyChildren(System.Xml.XmlDocument, System.Xml.XmlNode, Boolean)
		/// </summary>
		protected RMethod r_RCopyChildren_XmlDocument_XmlNode_Boolean;
		public virtual RMethod RCopyChildren_XmlDocument_XmlNode_Boolean
		{
			get
			{
				if(r_RCopyChildren_XmlDocument_XmlNode_Boolean == null)
				{
					r_RCopyChildren_XmlDocument_XmlNode_Boolean = new(this, "CopyChildren", 0, typeof(System.Xml.XmlDocument), typeof(System.Xml.XmlNode), typeof(System.Boolean));
					r_RCopyChildren_XmlDocument_XmlNode_Boolean.SetBelong(this.instance);
				}
				return r_RCopyChildren_XmlDocument_XmlNode_Boolean;
			}
		}

		/// <summary>
		/// Void Normalize()
		/// </summary>
		protected RMethod r_RNormalize;
		public virtual RMethod RNormalize
		{
			get
			{
				if(r_RNormalize == null)
				{
					r_RNormalize = new(this, "Normalize", 0);
					r_RNormalize.SetBelong(this.instance);
				}
				return r_RNormalize;
			}
		}

		/// <summary>
		/// Boolean Supports(System.String, System.String)
		/// </summary>
		protected RMethod r_RSupports_String_String;
		public virtual RMethod RSupports_String_String
		{
			get
			{
				if(r_RSupports_String_String == null)
				{
					r_RSupports_String_String = new(this, "Supports", 0, typeof(System.String), typeof(System.String));
					r_RSupports_String_String.SetBelong(this.instance);
				}
				return r_RSupports_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode Clone()
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
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// System.String get_InnerText()
		/// </summary>
		protected RMethod r_Rget_InnerText;
		public virtual RMethod Rget_InnerText
		{
			get
			{
				if(r_Rget_InnerText == null)
				{
					r_Rget_InnerText = new(this, "get_InnerText", 0);
					r_Rget_InnerText.SetBelong(this.instance);
				}
				return r_Rget_InnerText;
			}
		}

		/// <summary>
		/// Void RemoveAll()
		/// </summary>
		protected RMethod r_RRemoveAll;
		public virtual RMethod RRemoveAll
		{
			get
			{
				if(r_RRemoveAll == null)
				{
					r_RRemoveAll = new(this, "RemoveAll", 0);
					r_RRemoveAll.SetBelong(this.instance);
				}
				return r_RRemoveAll;
			}
		}

		/// <summary>
		/// System.String GetNamespaceOfPrefix(System.String)
		/// </summary>
		protected RMethod r_RGetNamespaceOfPrefix_String;
		public virtual RMethod RGetNamespaceOfPrefix_String
		{
			get
			{
				if(r_RGetNamespaceOfPrefix_String == null)
				{
					r_RGetNamespaceOfPrefix_String = new(this, "GetNamespaceOfPrefix", 0, typeof(System.String));
					r_RGetNamespaceOfPrefix_String.SetBelong(this.instance);
				}
				return r_RGetNamespaceOfPrefix_String;
			}
		}

		/// <summary>
		/// System.String GetNamespaceOfPrefixStrict(System.String)
		/// </summary>
		protected RMethod r_RGetNamespaceOfPrefixStrict_String;
		public virtual RMethod RGetNamespaceOfPrefixStrict_String
		{
			get
			{
				if(r_RGetNamespaceOfPrefixStrict_String == null)
				{
					r_RGetNamespaceOfPrefixStrict_String = new(this, "GetNamespaceOfPrefixStrict", 0, typeof(System.String));
					r_RGetNamespaceOfPrefixStrict_String.SetBelong(this.instance);
				}
				return r_RGetNamespaceOfPrefixStrict_String;
			}
		}

		/// <summary>
		/// System.String GetPrefixOfNamespace(System.String)
		/// </summary>
		protected RMethod r_RGetPrefixOfNamespace_String;
		public virtual RMethod RGetPrefixOfNamespace_String
		{
			get
			{
				if(r_RGetPrefixOfNamespace_String == null)
				{
					r_RGetPrefixOfNamespace_String = new(this, "GetPrefixOfNamespace", 0, typeof(System.String));
					r_RGetPrefixOfNamespace_String.SetBelong(this.instance);
				}
				return r_RGetPrefixOfNamespace_String;
			}
		}

		/// <summary>
		/// System.String GetPrefixOfNamespaceStrict(System.String)
		/// </summary>
		protected RMethod r_RGetPrefixOfNamespaceStrict_String;
		public virtual RMethod RGetPrefixOfNamespaceStrict_String
		{
			get
			{
				if(r_RGetPrefixOfNamespaceStrict_String == null)
				{
					r_RGetPrefixOfNamespaceStrict_String = new(this, "GetPrefixOfNamespaceStrict", 0, typeof(System.String));
					r_RGetPrefixOfNamespaceStrict_String.SetBelong(this.instance);
				}
				return r_RGetPrefixOfNamespaceStrict_String;
			}
		}

		/// <summary>
		/// Void SetParent(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RSetParent_XmlNode;
		public virtual RMethod RSetParent_XmlNode
		{
			get
			{
				if(r_RSetParent_XmlNode == null)
				{
					r_RSetParent_XmlNode = new(this, "SetParent", 0, typeof(System.Xml.XmlNode));
					r_RSetParent_XmlNode.SetBelong(this.instance);
				}
				return r_RSetParent_XmlNode;
			}
		}

		/// <summary>
		/// Void SetParentForLoad(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RSetParentForLoad_XmlNode;
		public virtual RMethod RSetParentForLoad_XmlNode
		{
			get
			{
				if(r_RSetParentForLoad_XmlNode == null)
				{
					r_RSetParentForLoad_XmlNode = new(this, "SetParentForLoad", 0, typeof(System.Xml.XmlNode));
					r_RSetParentForLoad_XmlNode.SetBelong(this.instance);
				}
				return r_RSetParentForLoad_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode FindChild(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RFindChild_XmlNodeType;
		public virtual RMethod RFindChild_XmlNodeType
		{
			get
			{
				if(r_RFindChild_XmlNodeType == null)
				{
					r_RFindChild_XmlNodeType = new(this, "FindChild", 0, typeof(System.Xml.XmlNodeType));
					r_RFindChild_XmlNodeType.SetBelong(this.instance);
				}
				return r_RFindChild_XmlNodeType;
			}
		}

		/// <summary>
		/// System.String GetXPAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetXPAttribute_String_String;
		public virtual RMethod RGetXPAttribute_String_String
		{
			get
			{
				if(r_RGetXPAttribute_String_String == null)
				{
					r_RGetXPAttribute_String_String = new(this, "GetXPAttribute", 0, typeof(System.String), typeof(System.String));
					r_RGetXPAttribute_String_String.SetBelong(this.instance);
				}
				return r_RGetXPAttribute_String_String;
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


        public RXmlDocument() : base("System.Xml.XmlDocument")
        {
        }

        public RXmlDocument(System.Object instance) : base("System.Xml.XmlDocument")
		{
            SetInstance(instance);
		}

        public RXmlDocument(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlDocument(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void CheckName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCheckName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object AddXmlName(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @schemaInfo};
            var ___result = RAddXmlName_String_String_String_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetXmlName(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @schemaInfo};
            var ___result = RGetXmlName_String_String_String_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AddAttrXmlName(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @schemaInfo};
            var ___result = RAddAttrXmlName_String_String_String_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual System.WeakReference GetElement(System.Collections.ArrayList  @elementList, System.Xml.XmlElement  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementList, @elem};
            var ___result = RGetElement_ArrayList_XmlElement.Invoke(___genericsType, ___parameters);

            return (System.WeakReference)___result;
        }


        public virtual void AddElementWithId(System.String  @id, System.Xml.XmlElement  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @elem};
            var ___result = RAddElementWithId_String_XmlElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveElementWithId(System.String  @id, System.Xml.XmlElement  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @elem};
            var ___result = RRemoveElementWithId_String_XmlElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNode CloneNode(System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deep};
            var ___result = RCloneNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlResolver GetResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }


        public virtual System.Boolean IsValidChildType(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsValidChildType_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType  @nt, System.Xml.XmlNode  @refNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt, @refNode};
            var ___result = RHasNodeTypeInPrevSiblings_XmlNodeType_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasNodeTypeInNextSiblings(System.Xml.XmlNodeType  @nt, System.Xml.XmlNode  @refNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt, @refNode};
            var ___result = RHasNodeTypeInNextSiblings_XmlNodeType_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanInsertBefore(System.Xml.XmlNode  @newChild, System.Xml.XmlNode  @refChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @refChild};
            var ___result = RCanInsertBefore_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanInsertAfter(System.Xml.XmlNode  @newChild, System.Xml.XmlNode  @refChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @refChild};
            var ___result = RCanInsertAfter_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlAttribute CreateAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual void SetDefaultNamespace(System.String  @prefix, System.String  @localName, ref System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI};
            var ___result = RSetDefaultNamespace_String_String_Ref_String.Invoke(___genericsType, ___parameters);
			namespaceURI = (System.String)___parameters[2];

            
        }


        public virtual System.Xml.XmlCDataSection CreateCDataSection(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCreateCDataSection_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlCDataSection)___result;
        }


        public virtual System.Xml.XmlComment CreateComment(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCreateComment_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlComment)___result;
        }


        public virtual System.Xml.XmlDocumentType CreateDocumentType(System.String  @name, System.String  @publicId, System.String  @systemId, System.String  @internalSubset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @publicId, @systemId, @internalSubset};
            var ___result = RCreateDocumentType_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlDocumentType)___result;
        }


        public virtual System.Xml.XmlDocumentFragment CreateDocumentFragment()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDocumentFragment.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlDocumentFragment)___result;
        }


        public virtual System.Xml.XmlElement CreateElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateElement_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlElement)___result;
        }


        public virtual void AddDefaultAttributes(System.Xml.XmlElement  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = RAddDefaultAttributes_XmlElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetSchemaElementDecl(System.Xml.XmlElement  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = RGetSchemaElementDecl_XmlElement.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Xml.XmlEntityReference CreateEntityReference(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateEntityReference_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlEntityReference)___result;
        }


        public virtual System.Xml.XmlProcessingInstruction CreateProcessingInstruction(System.String  @target, System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @data};
            var ___result = RCreateProcessingInstruction_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlProcessingInstruction)___result;
        }


        public virtual System.Xml.XmlDeclaration CreateXmlDeclaration(System.String  @version, System.String  @encoding, System.String  @standalone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version, @encoding, @standalone};
            var ___result = RCreateXmlDeclaration_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlDeclaration)___result;
        }


        public virtual System.Xml.XmlText CreateTextNode(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RCreateTextNode_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlText)___result;
        }


        public virtual System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RCreateSignificantWhitespace_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlSignificantWhitespace)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator CreateNavigator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateNavigator_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public static System.Boolean IsTextNode(System.Xml.XmlNodeType  @nt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt};
            var ___result = RIsTextNode_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlNode NormalizeText(System.Xml.XmlNode  @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RNormalizeText_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlWhitespace CreateWhitespace(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RCreateWhitespace_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWhitespace)___result;
        }


        public virtual System.Xml.XmlNodeList GetElementsByTagName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetElementsByTagName_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeList)___result;
        }


        public virtual System.Xml.XmlAttribute CreateAttribute(System.String  @qualifiedName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifiedName, @namespaceURI};
            var ___result = RCreateAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlElement CreateElement(System.String  @qualifiedName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifiedName, @namespaceURI};
            var ___result = RCreateElement_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlElement)___result;
        }


        public virtual System.Xml.XmlNodeList GetElementsByTagName(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetElementsByTagName_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeList)___result;
        }


        public virtual System.Xml.XmlElement GetElementById(System.String  @elementId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementId};
            var ___result = RGetElementById_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlElement)___result;
        }


        public virtual System.Xml.XmlNode ImportNode(System.Xml.XmlNode  @node, System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @deep};
            var ___result = RImportNode_XmlNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode  @node, System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @deep};
            var ___result = RImportNodeInternal_XmlNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual void ImportAttributes(System.Xml.XmlNode  @fromElem, System.Xml.XmlNode  @toElem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromElem, @toElem};
            var ___result = RImportAttributes_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ImportChildren(System.Xml.XmlNode  @fromNode, System.Xml.XmlNode  @toNode, System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNode, @toNode, @deep};
            var ___result = RImportChildren_XmlNode_XmlNode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlAttribute CreateAttribute(System.String  @prefix, System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI};
            var ___result = RCreateAttribute_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute CreateDefaultAttribute(System.String  @prefix, System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI};
            var ___result = RCreateDefaultAttribute_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlElement CreateElement(System.String  @prefix, System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI};
            var ___result = RCreateElement_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlElement)___result;
        }


        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType  @type, System.String  @prefix, System.String  @name, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @prefix, @name, @namespaceURI};
            var ___result = RCreateNode_XmlNodeType_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode CreateNode(System.String  @nodeTypeString, System.String  @name, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodeTypeString, @name, @namespaceURI};
            var ___result = RCreateNode_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType  @type, System.String  @name, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name, @namespaceURI};
            var ___result = RCreateNode_XmlNodeType_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode ReadNode(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RReadNode_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNodeType ConvertToNodeType(System.String  @nodeTypeString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodeTypeString};
            var ___result = RConvertToNodeType_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeType)___result;
        }


        public virtual System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader  @tr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tr};
            var ___result = RSetupReader_XmlTextReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlTextReader)___result;
        }


        public virtual void Load(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RLoad_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(System.IO.Stream  @inStream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inStream};
            var ___result = RLoad_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(System.IO.TextReader  @txtReader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@txtReader};
            var ___result = RLoad_TextReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RLoad_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadXml(System.String  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RLoadXml_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RSave_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.IO.Stream  @outStream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outStream};
            var ___result = RSave_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.IO.TextWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer};
            var ___result = RSave_TextWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.Xml.XmlWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RSave_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteTo(System.Xml.XmlWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RWriteTo_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteContentTo(System.Xml.XmlWriter  @xw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xw};
            var ___result = RWriteContentTo_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Validate(System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@validationEventHandler};
            var ___result = RValidate_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Validate(System.Xml.Schema.ValidationEventHandler  @validationEventHandler, System.Xml.XmlNode  @nodeToValidate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@validationEventHandler, @nodeToValidate};
            var ___result = RValidate_ValidationEventHandler_XmlNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode  @node, System.Xml.XmlNode  @oldParent, System.Xml.XmlNode  @newParent, System.String  @oldValue, System.String  @newValue, System.Xml.XmlNodeChangedAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @oldParent, @newParent, @oldValue, @newValue, @action};
            var ___result = RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeChangedEventArgs)___result;
        }


        public virtual System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode  @node, System.Xml.XmlNode  @newParent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newParent};
            var ___result = RGetInsertEventArgsForLoad_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeChangedEventArgs)___result;
        }


        public virtual void BeforeEvent(System.Xml.XmlNodeChangedEventArgs  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RBeforeEvent_XmlNodeChangedEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AfterEvent(System.Xml.XmlNodeChangedEventArgs  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RAfterEvent_XmlNodeChangedEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement  @elem, System.String  @attrPrefix, System.String  @attrLocalname, System.String  @attrNamespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @attrPrefix, @attrLocalname, @attrNamespaceURI};
            var ___result = RGetDefaultAttribute_XmlElement_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlEntity GetEntityNode(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEntityNode_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlEntity)___result;
        }


        public virtual void SetBaseURI(System.String  @inBaseURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inBaseURI};
            var ___result = RSetBaseURI_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode  @newChild, System.Xml.XmlDocument  @doc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @doc};
            var ___result = RAppendChildForLoad_XmlNode_XmlDocument.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode SelectSingleNode(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RSelectSingleNode_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode SelectSingleNode(System.String  @xpath, System.Xml.XmlNamespaceManager  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @nsmgr};
            var ___result = RSelectSingleNode_String_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNodeList SelectNodes(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RSelectNodes_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeList)___result;
        }


        public virtual System.Xml.XmlNodeList SelectNodes(System.String  @xpath, System.Xml.XmlNamespaceManager  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @nsmgr};
            var ___result = RSelectNodes_String_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeList)___result;
        }


        public virtual System.Boolean AncestorNode(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAncestorNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsConnected()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsConnected.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlNode InsertBefore(System.Xml.XmlNode  @newChild, System.Xml.XmlNode  @refChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @refChild};
            var ___result = RInsertBefore_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode InsertAfter(System.Xml.XmlNode  @newChild, System.Xml.XmlNode  @refChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @refChild};
            var ___result = RInsertAfter_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode  @newChild, System.Xml.XmlNode  @oldChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @oldChild};
            var ___result = RReplaceChild_XmlNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode RemoveChild(System.Xml.XmlNode  @oldChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChild};
            var ___result = RRemoveChild_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode PrependChild(System.Xml.XmlNode  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RPrependChild_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode AppendChild(System.Xml.XmlNode  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RAppendChild_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual void CopyChildren(System.Xml.XmlDocument  @doc, System.Xml.XmlNode  @container, System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doc, @container, @deep};
            var ___result = RCopyChildren_XmlDocument_XmlNode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Supports(System.String  @feature, System.String  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@feature, @version};
            var ___result = RSupports_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlNode Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.String get_InnerText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_InnerText.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void RemoveAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetNamespaceOfPrefix(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RGetNamespaceOfPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNamespaceOfPrefixStrict(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RGetNamespaceOfPrefixStrict_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPrefixOfNamespace(System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceURI};
            var ___result = RGetPrefixOfNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPrefixOfNamespaceStrict(System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceURI};
            var ___result = RGetPrefixOfNamespaceStrict_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetParent(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RSetParent_XmlNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParentForLoad(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RSetParentForLoad_XmlNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNode FindChild(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindChild_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.String GetXPAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetXPAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
