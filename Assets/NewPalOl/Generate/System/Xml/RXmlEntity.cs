using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlEntity
	/// </summary>
    public partial class RXmlEntity : RMember //
    {

		/// <summary>
		/// System.String publicId
		/// </summary>
		protected RField r_publicId;
		public virtual RField RpublicId
		{
			get
			{
				if(r_publicId == null)
				{
					r_publicId = new(this, "publicId");
					r_publicId.SetBelong(this.instance);
				}
				return r_publicId;
			}
		}

		/// <summary>
		/// System.String systemId
		/// </summary>
		protected RField r_systemId;
		public virtual RField RsystemId
		{
			get
			{
				if(r_systemId == null)
				{
					r_systemId = new(this, "systemId");
					r_systemId.SetBelong(this.instance);
				}
				return r_systemId;
			}
		}

		/// <summary>
		/// System.String notationName
		/// </summary>
		protected RField r_notationName;
		public virtual RField RnotationName
		{
			get
			{
				if(r_notationName == null)
				{
					r_notationName = new(this, "notationName");
					r_notationName.SetBelong(this.instance);
				}
				return r_notationName;
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
		/// System.String unparsedReplacementStr
		/// </summary>
		protected RField r_unparsedReplacementStr;
		public virtual RField RunparsedReplacementStr
		{
			get
			{
				if(r_unparsedReplacementStr == null)
				{
					r_unparsedReplacementStr = new(this, "unparsedReplacementStr");
					r_unparsedReplacementStr.SetBelong(this.instance);
				}
				return r_unparsedReplacementStr;
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
		/// System.Boolean childrenFoliating
		/// </summary>
		protected RField r_childrenFoliating;
		public virtual RField RchildrenFoliating
		{
			get
			{
				if(r_childrenFoliating == null)
				{
					r_childrenFoliating = new(this, "childrenFoliating");
					r_childrenFoliating.SetBelong(this.instance);
				}
				return r_childrenFoliating;
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
		/// System.String InnerText
		/// </summary>
		protected RProperty r_InnerText;
		public virtual RProperty RInnerText
		{
			get
			{
				if(r_InnerText == null)
				{
					r_InnerText = new(this, "InnerText", -1);
					r_InnerText.SetBelong(this.instance);
				}
				return r_InnerText;
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
		/// System.String PublicId
		/// </summary>
		protected RProperty r_PublicId;
		public virtual RProperty RPublicId
		{
			get
			{
				if(r_PublicId == null)
				{
					r_PublicId = new(this, "PublicId", -1);
					r_PublicId.SetBelong(this.instance);
				}
				return r_PublicId;
			}
		}

		/// <summary>
		/// System.String SystemId
		/// </summary>
		protected RProperty r_SystemId;
		public virtual RProperty RSystemId
		{
			get
			{
				if(r_SystemId == null)
				{
					r_SystemId = new(this, "SystemId", -1);
					r_SystemId.SetBelong(this.instance);
				}
				return r_SystemId;
			}
		}

		/// <summary>
		/// System.String NotationName
		/// </summary>
		protected RProperty r_NotationName;
		public virtual RProperty RNotationName
		{
			get
			{
				if(r_NotationName == null)
				{
					r_NotationName = new(this, "NotationName", -1);
					r_NotationName.SetBelong(this.instance);
				}
				return r_NotationName;
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


        public RXmlEntity() : base("System.Xml.XmlEntity")
        {
        }

        public RXmlEntity(System.Object instance) : base("System.Xml.XmlEntity")
		{
            SetInstance(instance);
		}

        public RXmlEntity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlEntity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.XmlNode CloneNode(System.Boolean  @deep)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deep};
            var ___result = RCloneNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Boolean IsValidChildType(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsValidChildType_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void WriteTo(System.Xml.XmlWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RWriteTo_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteContentTo(System.Xml.XmlWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RWriteContentTo_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBaseURI(System.String  @inBaseURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inBaseURI};
            var ___result = RSetBaseURI_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XPath.XPathNavigator CreateNavigator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
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


        public virtual System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode  @newChild, System.Xml.XmlDocument  @doc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild, @doc};
            var ___result = RAppendChildForLoad_XmlNode_XmlDocument.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
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


        public virtual System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode  @node, System.Xml.XmlNode  @oldParent, System.Xml.XmlNode  @newParent, System.String  @oldValue, System.String  @newValue, System.Xml.XmlNodeChangedAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @oldParent, @newParent, @oldValue, @newValue, @action};
            var ___result = RGetEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction.Invoke(___genericsType, ___parameters);

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
