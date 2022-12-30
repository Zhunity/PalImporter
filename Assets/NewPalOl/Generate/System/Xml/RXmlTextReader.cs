using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlTextReader
	/// </summary>
    public partial class RXmlTextReader : RMember //
    {

		/// <summary>
		/// System.Xml.XmlTextReaderImpl impl
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl r_impl;
		public virtual RSystem.RXml.RXmlTextReaderImpl Rimpl
		{
			get
			{
				if(r_impl == null)
				{
					r_impl = new(this, "impl");
					r_impl.SetBelong(this.instance);
				}
				return r_impl;
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
		/// Boolean HasValue
		/// </summary>
		protected RProperty r_HasValue;
		public virtual RProperty RHasValue
		{
			get
			{
				if(r_HasValue == null)
				{
					r_HasValue = new(this, "HasValue", -1);
					r_HasValue.SetBelong(this.instance);
				}
				return r_HasValue;
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
		/// Int32 Depth
		/// </summary>
		protected RProperty r_Depth;
		public virtual RProperty RDepth
		{
			get
			{
				if(r_Depth == null)
				{
					r_Depth = new(this, "Depth", -1);
					r_Depth.SetBelong(this.instance);
				}
				return r_Depth;
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
		/// Boolean IsEmptyElement
		/// </summary>
		protected RProperty r_IsEmptyElement;
		public virtual RProperty RIsEmptyElement
		{
			get
			{
				if(r_IsEmptyElement == null)
				{
					r_IsEmptyElement = new(this, "IsEmptyElement", -1);
					r_IsEmptyElement.SetBelong(this.instance);
				}
				return r_IsEmptyElement;
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
		/// Char QuoteChar
		/// </summary>
		protected RProperty r_QuoteChar;
		public virtual RProperty RQuoteChar
		{
			get
			{
				if(r_QuoteChar == null)
				{
					r_QuoteChar = new(this, "QuoteChar", -1);
					r_QuoteChar.SetBelong(this.instance);
				}
				return r_QuoteChar;
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
		/// Int32 AttributeCount
		/// </summary>
		protected RProperty r_AttributeCount;
		public virtual RProperty RAttributeCount
		{
			get
			{
				if(r_AttributeCount == null)
				{
					r_AttributeCount = new(this, "AttributeCount", -1);
					r_AttributeCount.SetBelong(this.instance);
				}
				return r_AttributeCount;
			}
		}

		/// <summary>
		/// Boolean EOF
		/// </summary>
		protected RProperty r_EOF;
		public virtual RProperty REOF
		{
			get
			{
				if(r_EOF == null)
				{
					r_EOF = new(this, "EOF", -1);
					r_EOF.SetBelong(this.instance);
				}
				return r_EOF;
			}
		}

		/// <summary>
		/// System.Xml.ReadState ReadState
		/// </summary>
		protected RProperty r_ReadState;
		public virtual RProperty ReadState
		{
			get
			{
				if(r_ReadState == null)
				{
					r_ReadState = new(this, "ReadState", -1);
					r_ReadState.SetBelong(this.instance);
				}
				return r_ReadState;
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
		/// Boolean CanResolveEntity
		/// </summary>
		protected RProperty r_CanResolveEntity;
		public virtual RProperty RCanResolveEntity
		{
			get
			{
				if(r_CanResolveEntity == null)
				{
					r_CanResolveEntity = new(this, "CanResolveEntity", -1);
					r_CanResolveEntity.SetBelong(this.instance);
				}
				return r_CanResolveEntity;
			}
		}

		/// <summary>
		/// Boolean CanReadBinaryContent
		/// </summary>
		protected RProperty r_CanReadBinaryContent;
		public virtual RProperty RCanReadBinaryContent
		{
			get
			{
				if(r_CanReadBinaryContent == null)
				{
					r_CanReadBinaryContent = new(this, "CanReadBinaryContent", -1);
					r_CanReadBinaryContent.SetBelong(this.instance);
				}
				return r_CanReadBinaryContent;
			}
		}

		/// <summary>
		/// Boolean CanReadValueChunk
		/// </summary>
		protected RProperty r_CanReadValueChunk;
		public virtual RProperty RCanReadValueChunk
		{
			get
			{
				if(r_CanReadValueChunk == null)
				{
					r_CanReadValueChunk = new(this, "CanReadValueChunk", -1);
					r_CanReadValueChunk.SetBelong(this.instance);
				}
				return r_CanReadValueChunk;
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
		/// Boolean Namespaces
		/// </summary>
		protected RProperty r_Namespaces;
		public virtual RProperty RNamespaces
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
		/// Boolean Normalization
		/// </summary>
		protected RProperty r_Normalization;
		public virtual RProperty RNormalization
		{
			get
			{
				if(r_Normalization == null)
				{
					r_Normalization = new(this, "Normalization", -1);
					r_Normalization.SetBelong(this.instance);
				}
				return r_Normalization;
			}
		}

		/// <summary>
		/// System.Text.Encoding Encoding
		/// </summary>
		protected RSystem.RText.REncoding r_Encoding;
		public virtual RSystem.RText.REncoding REncoding
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
		/// System.Xml.WhitespaceHandling WhitespaceHandling
		/// </summary>
		protected RProperty r_WhitespaceHandling;
		public virtual RProperty RWhitespaceHandling
		{
			get
			{
				if(r_WhitespaceHandling == null)
				{
					r_WhitespaceHandling = new(this, "WhitespaceHandling", -1);
					r_WhitespaceHandling.SetBelong(this.instance);
				}
				return r_WhitespaceHandling;
			}
		}

		/// <summary>
		/// Boolean ProhibitDtd
		/// </summary>
		protected RProperty r_ProhibitDtd;
		public virtual RProperty RProhibitDtd
		{
			get
			{
				if(r_ProhibitDtd == null)
				{
					r_ProhibitDtd = new(this, "ProhibitDtd", -1);
					r_ProhibitDtd.SetBelong(this.instance);
				}
				return r_ProhibitDtd;
			}
		}

		/// <summary>
		/// System.Xml.DtdProcessing DtdProcessing
		/// </summary>
		protected RProperty r_DtdProcessing;
		public virtual RProperty RDtdProcessing
		{
			get
			{
				if(r_DtdProcessing == null)
				{
					r_DtdProcessing = new(this, "DtdProcessing", -1);
					r_DtdProcessing.SetBelong(this.instance);
				}
				return r_DtdProcessing;
			}
		}

		/// <summary>
		/// System.Xml.EntityHandling EntityHandling
		/// </summary>
		protected RProperty r_EntityHandling;
		public virtual RProperty REntityHandling
		{
			get
			{
				if(r_EntityHandling == null)
				{
					r_EntityHandling = new(this, "EntityHandling", -1);
					r_EntityHandling.SetBelong(this.instance);
				}
				return r_EntityHandling;
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
		/// System.Xml.XmlTextReaderImpl Impl
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl r_Impl;
		public virtual RSystem.RXml.RXmlTextReaderImpl RImpl
		{
			get
			{
				if(r_Impl == null)
				{
					r_Impl = new(this, "Impl", -1);
					r_Impl.SetBelong(this.instance);
				}
				return r_Impl;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager NamespaceManager
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r_NamespaceManager;
		public virtual RSystem.RXml.RXmlNamespaceManager RNamespaceManager
		{
			get
			{
				if(r_NamespaceManager == null)
				{
					r_NamespaceManager = new(this, "NamespaceManager", -1);
					r_NamespaceManager.SetBelong(this.instance);
				}
				return r_NamespaceManager;
			}
		}

		/// <summary>
		/// Boolean XmlValidatingReaderCompatibilityMode
		/// </summary>
		protected RProperty r_XmlValidatingReaderCompatibilityMode_Boolean;
		public virtual RProperty RXmlValidatingReaderCompatibilityMode_Boolean
		{
			get
			{
				if(r_XmlValidatingReaderCompatibilityMode_Boolean == null)
				{
					r_XmlValidatingReaderCompatibilityMode_Boolean = new(this, "XmlValidatingReaderCompatibilityMode", -1, typeof(System.Boolean));
					r_XmlValidatingReaderCompatibilityMode_Boolean.SetBelong(this.instance);
				}
				return r_XmlValidatingReaderCompatibilityMode_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.IDtdInfo DtdInfo
		/// </summary>
		protected RSystem.RXml.RIDtdInfo r_DtdInfo;
		public virtual RSystem.RXml.RIDtdInfo RDtdInfo
		{
			get
			{
				if(r_DtdInfo == null)
				{
					r_DtdInfo = new(this, "DtdInfo", -1);
					r_DtdInfo.SetBelong(this.instance);
				}
				return r_DtdInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlReaderSettings Settings
		/// </summary>
		protected RSystem.RXml.RXmlReaderSettings r_Settings;
		public virtual RSystem.RXml.RXmlReaderSettings RSettings
		{
			get
			{
				if(r_Settings == null)
				{
					r_Settings = new(this, "Settings", -1);
					r_Settings.SetBelong(this.instance);
				}
				return r_Settings;
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
		/// System.Type ValueType
		/// </summary>
		protected RSystem.RType r_ValueType;
		public virtual RSystem.RType RValueType
		{
			get
			{
				if(r_ValueType == null)
				{
					r_ValueType = new(this, "ValueType", -1);
					r_ValueType.SetBelong(this.instance);
				}
				return r_ValueType;
			}
		}

		/// <summary>
		/// System.String Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// System.String Item [System.String]
		/// </summary>
		protected RProperty r_Item_String;
		public virtual RProperty RItem_String
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
		/// System.String Item [System.String, System.String]
		/// </summary>
		protected RProperty r_Item_String_String;
		public virtual RProperty RItem_String_String
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
		/// Boolean HasAttributes
		/// </summary>
		protected RProperty r_HasAttributes;
		public virtual RProperty RHasAttributes
		{
			get
			{
				if(r_HasAttributes == null)
				{
					r_HasAttributes = new(this, "HasAttributes", -1);
					r_HasAttributes.SetBelong(this.instance);
				}
				return r_HasAttributes;
			}
		}

		/// <summary>
		/// Boolean IsDefaultInternal
		/// </summary>
		protected RProperty r_IsDefaultInternal;
		public virtual RProperty RIsDefaultInternal
		{
			get
			{
				if(r_IsDefaultInternal == null)
				{
					r_IsDefaultInternal = new(this, "IsDefaultInternal", -1);
					r_IsDefaultInternal.SetBelong(this.instance);
				}
				return r_IsDefaultInternal;
			}
		}

		/// <summary>
		/// System.String GetAttribute(System.String)
		/// </summary>
		protected RMethod r_RGetAttribute_String;
		public virtual RMethod RGetAttribute_String
		{
			get
			{
				if(r_RGetAttribute_String == null)
				{
					r_RGetAttribute_String = new(this, "GetAttribute", 0, typeof(System.String));
					r_RGetAttribute_String.SetBelong(this.instance);
				}
				return r_RGetAttribute_String;
			}
		}

		/// <summary>
		/// System.String GetAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetAttribute_String_String;
		public virtual RMethod RGetAttribute_String_String
		{
			get
			{
				if(r_RGetAttribute_String_String == null)
				{
					r_RGetAttribute_String_String = new(this, "GetAttribute", 0, typeof(System.String), typeof(System.String));
					r_RGetAttribute_String_String.SetBelong(this.instance);
				}
				return r_RGetAttribute_String_String;
			}
		}

		/// <summary>
		/// System.String GetAttribute(Int32)
		/// </summary>
		protected RMethod r_RGetAttribute_Int32;
		public virtual RMethod RGetAttribute_Int32
		{
			get
			{
				if(r_RGetAttribute_Int32 == null)
				{
					r_RGetAttribute_Int32 = new(this, "GetAttribute", 0, typeof(System.Int32));
					r_RGetAttribute_Int32.SetBelong(this.instance);
				}
				return r_RGetAttribute_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveToAttribute(System.String)
		/// </summary>
		protected RMethod r_RMoveToAttribute_String;
		public virtual RMethod RMoveToAttribute_String
		{
			get
			{
				if(r_RMoveToAttribute_String == null)
				{
					r_RMoveToAttribute_String = new(this, "MoveToAttribute", 0, typeof(System.String));
					r_RMoveToAttribute_String.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_String;
			}
		}

		/// <summary>
		/// Boolean MoveToAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToAttribute_String_String;
		public virtual RMethod RMoveToAttribute_String_String
		{
			get
			{
				if(r_RMoveToAttribute_String_String == null)
				{
					r_RMoveToAttribute_String_String = new(this, "MoveToAttribute", 0, typeof(System.String), typeof(System.String));
					r_RMoveToAttribute_String_String.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_String_String;
			}
		}

		/// <summary>
		/// Void MoveToAttribute(Int32)
		/// </summary>
		protected RMethod r_RMoveToAttribute_Int32;
		public virtual RMethod RMoveToAttribute_Int32
		{
			get
			{
				if(r_RMoveToAttribute_Int32 == null)
				{
					r_RMoveToAttribute_Int32 = new(this, "MoveToAttribute", 0, typeof(System.Int32));
					r_RMoveToAttribute_Int32.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveToFirstAttribute()
		/// </summary>
		protected RMethod r_RMoveToFirstAttribute;
		public virtual RMethod RMoveToFirstAttribute
		{
			get
			{
				if(r_RMoveToFirstAttribute == null)
				{
					r_RMoveToFirstAttribute = new(this, "MoveToFirstAttribute", 0);
					r_RMoveToFirstAttribute.SetBelong(this.instance);
				}
				return r_RMoveToFirstAttribute;
			}
		}

		/// <summary>
		/// Boolean MoveToNextAttribute()
		/// </summary>
		protected RMethod r_RMoveToNextAttribute;
		public virtual RMethod RMoveToNextAttribute
		{
			get
			{
				if(r_RMoveToNextAttribute == null)
				{
					r_RMoveToNextAttribute = new(this, "MoveToNextAttribute", 0);
					r_RMoveToNextAttribute.SetBelong(this.instance);
				}
				return r_RMoveToNextAttribute;
			}
		}

		/// <summary>
		/// Boolean MoveToElement()
		/// </summary>
		protected RMethod r_RMoveToElement;
		public virtual RMethod RMoveToElement
		{
			get
			{
				if(r_RMoveToElement == null)
				{
					r_RMoveToElement = new(this, "MoveToElement", 0);
					r_RMoveToElement.SetBelong(this.instance);
				}
				return r_RMoveToElement;
			}
		}

		/// <summary>
		/// Boolean ReadAttributeValue()
		/// </summary>
		protected RMethod r_RReadAttributeValue;
		public virtual RMethod RReadAttributeValue
		{
			get
			{
				if(r_RReadAttributeValue == null)
				{
					r_RReadAttributeValue = new(this, "ReadAttributeValue", 0);
					r_RReadAttributeValue.SetBelong(this.instance);
				}
				return r_RReadAttributeValue;
			}
		}

		/// <summary>
		/// Boolean Read()
		/// </summary>
		protected RMethod r_RRead;
		public virtual RMethod RRead
		{
			get
			{
				if(r_RRead == null)
				{
					r_RRead = new(this, "Read", 0);
					r_RRead.SetBelong(this.instance);
				}
				return r_RRead;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Skip()
		/// </summary>
		protected RMethod r_RSkip;
		public virtual RMethod RSkip
		{
			get
			{
				if(r_RSkip == null)
				{
					r_RSkip = new(this, "Skip", 0);
					r_RSkip.SetBelong(this.instance);
				}
				return r_RSkip;
			}
		}

		/// <summary>
		/// System.String LookupNamespace(System.String)
		/// </summary>
		protected RMethod r_RLookupNamespace_String;
		public virtual RMethod RLookupNamespace_String
		{
			get
			{
				if(r_RLookupNamespace_String == null)
				{
					r_RLookupNamespace_String = new(this, "LookupNamespace", 0, typeof(System.String));
					r_RLookupNamespace_String.SetBelong(this.instance);
				}
				return r_RLookupNamespace_String;
			}
		}

		/// <summary>
		/// Void ResolveEntity()
		/// </summary>
		protected RMethod r_RResolveEntity;
		public virtual RMethod RResolveEntity
		{
			get
			{
				if(r_RResolveEntity == null)
				{
					r_RResolveEntity = new(this, "ResolveEntity", 0);
					r_RResolveEntity.SetBelong(this.instance);
				}
				return r_RResolveEntity;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBase64_ByteArray_Int32_Int32 = new(this, "ReadContentAsBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBase64_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinHex_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinHex_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ReadString()
		/// </summary>
		protected RMethod r_RReadString;
		public virtual RMethod RReadString
		{
			get
			{
				if(r_RReadString == null)
				{
					r_RReadString = new(this, "ReadString", 0);
					r_RReadString.SetBelong(this.instance);
				}
				return r_RReadString;
			}
		}

		/// <summary>
		/// Boolean HasLineInfo()
		/// </summary>
		protected RMethod r_RHasLineInfo;
		public virtual RMethod RHasLineInfo
		{
			get
			{
				if(r_RHasLineInfo == null)
				{
					r_RHasLineInfo = new(this, "HasLineInfo", 0);
					r_RHasLineInfo.SetBelong(this.instance);
				}
				return r_RHasLineInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope = new(this, "System.Xml.IXmlNamespaceResolver.GetNamespacesInScope", 0, typeof(System.Xml.XmlNamespaceScope));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope;
			}
		}

		/// <summary>
		/// System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String = new(this, "System.Xml.IXmlNamespaceResolver.LookupNamespace", 0, typeof(System.String));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String;
			}
		}

		/// <summary>
		/// System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String = new(this, "System.Xml.IXmlNamespaceResolver.LookupPrefix", 0, typeof(System.String));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] GetNamespacesInScope(System.Xml.XmlNamespaceScope)
		/// </summary>
		protected RMethod r_RGetNamespacesInScope_XmlNamespaceScope;
		public virtual RMethod RGetNamespacesInScope_XmlNamespaceScope
		{
			get
			{
				if(r_RGetNamespacesInScope_XmlNamespaceScope == null)
				{
					r_RGetNamespacesInScope_XmlNamespaceScope = new(this, "GetNamespacesInScope", 0, typeof(System.Xml.XmlNamespaceScope));
					r_RGetNamespacesInScope_XmlNamespaceScope.SetBelong(this.instance);
				}
				return r_RGetNamespacesInScope_XmlNamespaceScope;
			}
		}

		/// <summary>
		/// Void ResetState()
		/// </summary>
		protected RMethod r_RResetState;
		public virtual RMethod RResetState
		{
			get
			{
				if(r_RResetState == null)
				{
					r_RResetState = new(this, "ResetState", 0);
					r_RResetState.SetBelong(this.instance);
				}
				return r_RResetState;
			}
		}

		/// <summary>
		/// System.IO.TextReader GetRemainder()
		/// </summary>
		protected RMethod r_RGetRemainder;
		public virtual RMethod RGetRemainder
		{
			get
			{
				if(r_RGetRemainder == null)
				{
					r_RGetRemainder = new(this, "GetRemainder", 0);
					r_RGetRemainder.SetBelong(this.instance);
				}
				return r_RGetRemainder;
			}
		}

		/// <summary>
		/// Int32 ReadChars(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadChars_CharArray_Int32_Int32;
		public virtual RMethod RReadChars_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadChars_CharArray_Int32_Int32 == null)
				{
					r_RReadChars_CharArray_Int32_Int32 = new(this, "ReadChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadChars_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadChars_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadBase64_ByteArray_Int32_Int32 = new(this, "ReadBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadBinHex_ByteArray_Int32_Int32 = new(this, "ReadBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object ReadContentAsObject()
		/// </summary>
		protected RMethod r_RReadContentAsObject;
		public virtual RMethod RReadContentAsObject
		{
			get
			{
				if(r_RReadContentAsObject == null)
				{
					r_RReadContentAsObject = new(this, "ReadContentAsObject", 0);
					r_RReadContentAsObject.SetBelong(this.instance);
				}
				return r_RReadContentAsObject;
			}
		}

		/// <summary>
		/// Boolean ReadContentAsBoolean()
		/// </summary>
		protected RMethod r_RReadContentAsBoolean;
		public virtual RMethod RReadContentAsBoolean
		{
			get
			{
				if(r_RReadContentAsBoolean == null)
				{
					r_RReadContentAsBoolean = new(this, "ReadContentAsBoolean", 0);
					r_RReadContentAsBoolean.SetBelong(this.instance);
				}
				return r_RReadContentAsBoolean;
			}
		}

		/// <summary>
		/// System.DateTime ReadContentAsDateTime()
		/// </summary>
		protected RMethod r_RReadContentAsDateTime;
		public virtual RMethod RReadContentAsDateTime
		{
			get
			{
				if(r_RReadContentAsDateTime == null)
				{
					r_RReadContentAsDateTime = new(this, "ReadContentAsDateTime", 0);
					r_RReadContentAsDateTime.SetBelong(this.instance);
				}
				return r_RReadContentAsDateTime;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ReadContentAsDateTimeOffset()
		/// </summary>
		protected RMethod r_RReadContentAsDateTimeOffset;
		public virtual RMethod RReadContentAsDateTimeOffset
		{
			get
			{
				if(r_RReadContentAsDateTimeOffset == null)
				{
					r_RReadContentAsDateTimeOffset = new(this, "ReadContentAsDateTimeOffset", 0);
					r_RReadContentAsDateTimeOffset.SetBelong(this.instance);
				}
				return r_RReadContentAsDateTimeOffset;
			}
		}

		/// <summary>
		/// Double ReadContentAsDouble()
		/// </summary>
		protected RMethod r_RReadContentAsDouble;
		public virtual RMethod RReadContentAsDouble
		{
			get
			{
				if(r_RReadContentAsDouble == null)
				{
					r_RReadContentAsDouble = new(this, "ReadContentAsDouble", 0);
					r_RReadContentAsDouble.SetBelong(this.instance);
				}
				return r_RReadContentAsDouble;
			}
		}

		/// <summary>
		/// Single ReadContentAsFloat()
		/// </summary>
		protected RMethod r_RReadContentAsFloat;
		public virtual RMethod RReadContentAsFloat
		{
			get
			{
				if(r_RReadContentAsFloat == null)
				{
					r_RReadContentAsFloat = new(this, "ReadContentAsFloat", 0);
					r_RReadContentAsFloat.SetBelong(this.instance);
				}
				return r_RReadContentAsFloat;
			}
		}

		/// <summary>
		/// System.Decimal ReadContentAsDecimal()
		/// </summary>
		protected RMethod r_RReadContentAsDecimal;
		public virtual RMethod RReadContentAsDecimal
		{
			get
			{
				if(r_RReadContentAsDecimal == null)
				{
					r_RReadContentAsDecimal = new(this, "ReadContentAsDecimal", 0);
					r_RReadContentAsDecimal.SetBelong(this.instance);
				}
				return r_RReadContentAsDecimal;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsInt()
		/// </summary>
		protected RMethod r_RReadContentAsInt;
		public virtual RMethod RReadContentAsInt
		{
			get
			{
				if(r_RReadContentAsInt == null)
				{
					r_RReadContentAsInt = new(this, "ReadContentAsInt", 0);
					r_RReadContentAsInt.SetBelong(this.instance);
				}
				return r_RReadContentAsInt;
			}
		}

		/// <summary>
		/// Int64 ReadContentAsLong()
		/// </summary>
		protected RMethod r_RReadContentAsLong;
		public virtual RMethod RReadContentAsLong
		{
			get
			{
				if(r_RReadContentAsLong == null)
				{
					r_RReadContentAsLong = new(this, "ReadContentAsLong", 0);
					r_RReadContentAsLong.SetBelong(this.instance);
				}
				return r_RReadContentAsLong;
			}
		}

		/// <summary>
		/// System.String ReadContentAsString()
		/// </summary>
		protected RMethod r_RReadContentAsString;
		public virtual RMethod RReadContentAsString
		{
			get
			{
				if(r_RReadContentAsString == null)
				{
					r_RReadContentAsString = new(this, "ReadContentAsString", 0);
					r_RReadContentAsString.SetBelong(this.instance);
				}
				return r_RReadContentAsString;
			}
		}

		/// <summary>
		/// System.Object ReadContentAs(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadContentAs_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadContentAs_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadContentAs_Type_IXmlNamespaceResolver == null)
				{
					r_RReadContentAs_Type_IXmlNamespaceResolver = new(this, "ReadContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadContentAs_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadContentAs_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAsObject()
		/// </summary>
		protected RMethod r_RReadElementContentAsObject;
		public virtual RMethod RReadElementContentAsObject
		{
			get
			{
				if(r_RReadElementContentAsObject == null)
				{
					r_RReadElementContentAsObject = new(this, "ReadElementContentAsObject", 0);
					r_RReadElementContentAsObject.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObject;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAsObject(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsObject_String_String;
		public virtual RMethod RReadElementContentAsObject_String_String
		{
			get
			{
				if(r_RReadElementContentAsObject_String_String == null)
				{
					r_RReadElementContentAsObject_String_String = new(this, "ReadElementContentAsObject", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsObject_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObject_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadElementContentAsBoolean()
		/// </summary>
		protected RMethod r_RReadElementContentAsBoolean;
		public virtual RMethod RReadElementContentAsBoolean
		{
			get
			{
				if(r_RReadElementContentAsBoolean == null)
				{
					r_RReadElementContentAsBoolean = new(this, "ReadElementContentAsBoolean", 0);
					r_RReadElementContentAsBoolean.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBoolean;
			}
		}

		/// <summary>
		/// Boolean ReadElementContentAsBoolean(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsBoolean_String_String;
		public virtual RMethod RReadElementContentAsBoolean_String_String
		{
			get
			{
				if(r_RReadElementContentAsBoolean_String_String == null)
				{
					r_RReadElementContentAsBoolean_String_String = new(this, "ReadElementContentAsBoolean", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsBoolean_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBoolean_String_String;
			}
		}

		/// <summary>
		/// System.DateTime ReadElementContentAsDateTime()
		/// </summary>
		protected RMethod r_RReadElementContentAsDateTime;
		public virtual RMethod RReadElementContentAsDateTime
		{
			get
			{
				if(r_RReadElementContentAsDateTime == null)
				{
					r_RReadElementContentAsDateTime = new(this, "ReadElementContentAsDateTime", 0);
					r_RReadElementContentAsDateTime.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDateTime;
			}
		}

		/// <summary>
		/// System.DateTime ReadElementContentAsDateTime(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDateTime_String_String;
		public virtual RMethod RReadElementContentAsDateTime_String_String
		{
			get
			{
				if(r_RReadElementContentAsDateTime_String_String == null)
				{
					r_RReadElementContentAsDateTime_String_String = new(this, "ReadElementContentAsDateTime", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDateTime_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDateTime_String_String;
			}
		}

		/// <summary>
		/// Double ReadElementContentAsDouble()
		/// </summary>
		protected RMethod r_RReadElementContentAsDouble;
		public virtual RMethod RReadElementContentAsDouble
		{
			get
			{
				if(r_RReadElementContentAsDouble == null)
				{
					r_RReadElementContentAsDouble = new(this, "ReadElementContentAsDouble", 0);
					r_RReadElementContentAsDouble.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDouble;
			}
		}

		/// <summary>
		/// Double ReadElementContentAsDouble(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDouble_String_String;
		public virtual RMethod RReadElementContentAsDouble_String_String
		{
			get
			{
				if(r_RReadElementContentAsDouble_String_String == null)
				{
					r_RReadElementContentAsDouble_String_String = new(this, "ReadElementContentAsDouble", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDouble_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDouble_String_String;
			}
		}

		/// <summary>
		/// Single ReadElementContentAsFloat()
		/// </summary>
		protected RMethod r_RReadElementContentAsFloat;
		public virtual RMethod RReadElementContentAsFloat
		{
			get
			{
				if(r_RReadElementContentAsFloat == null)
				{
					r_RReadElementContentAsFloat = new(this, "ReadElementContentAsFloat", 0);
					r_RReadElementContentAsFloat.SetBelong(this.instance);
				}
				return r_RReadElementContentAsFloat;
			}
		}

		/// <summary>
		/// Single ReadElementContentAsFloat(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsFloat_String_String;
		public virtual RMethod RReadElementContentAsFloat_String_String
		{
			get
			{
				if(r_RReadElementContentAsFloat_String_String == null)
				{
					r_RReadElementContentAsFloat_String_String = new(this, "ReadElementContentAsFloat", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsFloat_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsFloat_String_String;
			}
		}

		/// <summary>
		/// System.Decimal ReadElementContentAsDecimal()
		/// </summary>
		protected RMethod r_RReadElementContentAsDecimal;
		public virtual RMethod RReadElementContentAsDecimal
		{
			get
			{
				if(r_RReadElementContentAsDecimal == null)
				{
					r_RReadElementContentAsDecimal = new(this, "ReadElementContentAsDecimal", 0);
					r_RReadElementContentAsDecimal.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDecimal;
			}
		}

		/// <summary>
		/// System.Decimal ReadElementContentAsDecimal(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDecimal_String_String;
		public virtual RMethod RReadElementContentAsDecimal_String_String
		{
			get
			{
				if(r_RReadElementContentAsDecimal_String_String == null)
				{
					r_RReadElementContentAsDecimal_String_String = new(this, "ReadElementContentAsDecimal", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDecimal_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDecimal_String_String;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsInt()
		/// </summary>
		protected RMethod r_RReadElementContentAsInt;
		public virtual RMethod RReadElementContentAsInt
		{
			get
			{
				if(r_RReadElementContentAsInt == null)
				{
					r_RReadElementContentAsInt = new(this, "ReadElementContentAsInt", 0);
					r_RReadElementContentAsInt.SetBelong(this.instance);
				}
				return r_RReadElementContentAsInt;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsInt(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsInt_String_String;
		public virtual RMethod RReadElementContentAsInt_String_String
		{
			get
			{
				if(r_RReadElementContentAsInt_String_String == null)
				{
					r_RReadElementContentAsInt_String_String = new(this, "ReadElementContentAsInt", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsInt_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsInt_String_String;
			}
		}

		/// <summary>
		/// Int64 ReadElementContentAsLong()
		/// </summary>
		protected RMethod r_RReadElementContentAsLong;
		public virtual RMethod RReadElementContentAsLong
		{
			get
			{
				if(r_RReadElementContentAsLong == null)
				{
					r_RReadElementContentAsLong = new(this, "ReadElementContentAsLong", 0);
					r_RReadElementContentAsLong.SetBelong(this.instance);
				}
				return r_RReadElementContentAsLong;
			}
		}

		/// <summary>
		/// Int64 ReadElementContentAsLong(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsLong_String_String;
		public virtual RMethod RReadElementContentAsLong_String_String
		{
			get
			{
				if(r_RReadElementContentAsLong_String_String == null)
				{
					r_RReadElementContentAsLong_String_String = new(this, "ReadElementContentAsLong", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsLong_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsLong_String_String;
			}
		}

		/// <summary>
		/// System.String ReadElementContentAsString()
		/// </summary>
		protected RMethod r_RReadElementContentAsString;
		public virtual RMethod RReadElementContentAsString
		{
			get
			{
				if(r_RReadElementContentAsString == null)
				{
					r_RReadElementContentAsString = new(this, "ReadElementContentAsString", 0);
					r_RReadElementContentAsString.SetBelong(this.instance);
				}
				return r_RReadElementContentAsString;
			}
		}

		/// <summary>
		/// System.String ReadElementContentAsString(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsString_String_String;
		public virtual RMethod RReadElementContentAsString_String_String
		{
			get
			{
				if(r_RReadElementContentAsString_String_String == null)
				{
					r_RReadElementContentAsString_String_String = new(this, "ReadElementContentAsString", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsString_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsString_String_String;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAs(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadElementContentAs_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadElementContentAs_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadElementContentAs_Type_IXmlNamespaceResolver == null)
				{
					r_RReadElementContentAs_Type_IXmlNamespaceResolver = new(this, "ReadElementContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadElementContentAs_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadElementContentAs_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAs(System.Type, System.Xml.IXmlNamespaceResolver, System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String;
		public virtual RMethod RReadElementContentAs_Type_IXmlNamespaceResolver_String_String
		{
			get
			{
				if(r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String == null)
				{
					r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String = new(this, "ReadElementContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.String), typeof(System.String));
					r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String;
			}
		}

		/// <summary>
		/// Int32 ReadValueChunk(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadValueChunk_CharArray_Int32_Int32;
		public virtual RMethod RReadValueChunk_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadValueChunk_CharArray_Int32_Int32 == null)
				{
					r_RReadValueChunk_CharArray_Int32_Int32 = new(this, "ReadValueChunk", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadValueChunk_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadValueChunk_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType MoveToContent()
		/// </summary>
		protected RMethod r_RMoveToContent;
		public virtual RMethod RMoveToContent
		{
			get
			{
				if(r_RMoveToContent == null)
				{
					r_RMoveToContent = new(this, "MoveToContent", 0);
					r_RMoveToContent.SetBelong(this.instance);
				}
				return r_RMoveToContent;
			}
		}

		/// <summary>
		/// Void ReadStartElement()
		/// </summary>
		protected RMethod r_RReadStartElement;
		public virtual RMethod RReadStartElement
		{
			get
			{
				if(r_RReadStartElement == null)
				{
					r_RReadStartElement = new(this, "ReadStartElement", 0);
					r_RReadStartElement.SetBelong(this.instance);
				}
				return r_RReadStartElement;
			}
		}

		/// <summary>
		/// Void ReadStartElement(System.String)
		/// </summary>
		protected RMethod r_RReadStartElement_String;
		public virtual RMethod RReadStartElement_String
		{
			get
			{
				if(r_RReadStartElement_String == null)
				{
					r_RReadStartElement_String = new(this, "ReadStartElement", 0, typeof(System.String));
					r_RReadStartElement_String.SetBelong(this.instance);
				}
				return r_RReadStartElement_String;
			}
		}

		/// <summary>
		/// Void ReadStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadStartElement_String_String;
		public virtual RMethod RReadStartElement_String_String
		{
			get
			{
				if(r_RReadStartElement_String_String == null)
				{
					r_RReadStartElement_String_String = new(this, "ReadStartElement", 0, typeof(System.String), typeof(System.String));
					r_RReadStartElement_String_String.SetBelong(this.instance);
				}
				return r_RReadStartElement_String_String;
			}
		}

		/// <summary>
		/// System.String ReadElementString()
		/// </summary>
		protected RMethod r_RReadElementString;
		public virtual RMethod RReadElementString
		{
			get
			{
				if(r_RReadElementString == null)
				{
					r_RReadElementString = new(this, "ReadElementString", 0);
					r_RReadElementString.SetBelong(this.instance);
				}
				return r_RReadElementString;
			}
		}

		/// <summary>
		/// System.String ReadElementString(System.String)
		/// </summary>
		protected RMethod r_RReadElementString_String;
		public virtual RMethod RReadElementString_String
		{
			get
			{
				if(r_RReadElementString_String == null)
				{
					r_RReadElementString_String = new(this, "ReadElementString", 0, typeof(System.String));
					r_RReadElementString_String.SetBelong(this.instance);
				}
				return r_RReadElementString_String;
			}
		}

		/// <summary>
		/// System.String ReadElementString(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementString_String_String;
		public virtual RMethod RReadElementString_String_String
		{
			get
			{
				if(r_RReadElementString_String_String == null)
				{
					r_RReadElementString_String_String = new(this, "ReadElementString", 0, typeof(System.String), typeof(System.String));
					r_RReadElementString_String_String.SetBelong(this.instance);
				}
				return r_RReadElementString_String_String;
			}
		}

		/// <summary>
		/// Void ReadEndElement()
		/// </summary>
		protected RMethod r_RReadEndElement;
		public virtual RMethod RReadEndElement
		{
			get
			{
				if(r_RReadEndElement == null)
				{
					r_RReadEndElement = new(this, "ReadEndElement", 0);
					r_RReadEndElement.SetBelong(this.instance);
				}
				return r_RReadEndElement;
			}
		}

		/// <summary>
		/// Boolean IsStartElement()
		/// </summary>
		protected RMethod r_RIsStartElement;
		public virtual RMethod RIsStartElement
		{
			get
			{
				if(r_RIsStartElement == null)
				{
					r_RIsStartElement = new(this, "IsStartElement", 0);
					r_RIsStartElement.SetBelong(this.instance);
				}
				return r_RIsStartElement;
			}
		}

		/// <summary>
		/// Boolean IsStartElement(System.String)
		/// </summary>
		protected RMethod r_RIsStartElement_String;
		public virtual RMethod RIsStartElement_String
		{
			get
			{
				if(r_RIsStartElement_String == null)
				{
					r_RIsStartElement_String = new(this, "IsStartElement", 0, typeof(System.String));
					r_RIsStartElement_String.SetBelong(this.instance);
				}
				return r_RIsStartElement_String;
			}
		}

		/// <summary>
		/// Boolean IsStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsStartElement_String_String;
		public virtual RMethod RIsStartElement_String_String
		{
			get
			{
				if(r_RIsStartElement_String_String == null)
				{
					r_RIsStartElement_String_String = new(this, "IsStartElement", 0, typeof(System.String), typeof(System.String));
					r_RIsStartElement_String_String.SetBelong(this.instance);
				}
				return r_RIsStartElement_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToFollowing(System.String)
		/// </summary>
		protected RMethod r_RReadToFollowing_String;
		public virtual RMethod RReadToFollowing_String
		{
			get
			{
				if(r_RReadToFollowing_String == null)
				{
					r_RReadToFollowing_String = new(this, "ReadToFollowing", 0, typeof(System.String));
					r_RReadToFollowing_String.SetBelong(this.instance);
				}
				return r_RReadToFollowing_String;
			}
		}

		/// <summary>
		/// Boolean ReadToFollowing(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToFollowing_String_String;
		public virtual RMethod RReadToFollowing_String_String
		{
			get
			{
				if(r_RReadToFollowing_String_String == null)
				{
					r_RReadToFollowing_String_String = new(this, "ReadToFollowing", 0, typeof(System.String), typeof(System.String));
					r_RReadToFollowing_String_String.SetBelong(this.instance);
				}
				return r_RReadToFollowing_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToDescendant(System.String)
		/// </summary>
		protected RMethod r_RReadToDescendant_String;
		public virtual RMethod RReadToDescendant_String
		{
			get
			{
				if(r_RReadToDescendant_String == null)
				{
					r_RReadToDescendant_String = new(this, "ReadToDescendant", 0, typeof(System.String));
					r_RReadToDescendant_String.SetBelong(this.instance);
				}
				return r_RReadToDescendant_String;
			}
		}

		/// <summary>
		/// Boolean ReadToDescendant(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToDescendant_String_String;
		public virtual RMethod RReadToDescendant_String_String
		{
			get
			{
				if(r_RReadToDescendant_String_String == null)
				{
					r_RReadToDescendant_String_String = new(this, "ReadToDescendant", 0, typeof(System.String), typeof(System.String));
					r_RReadToDescendant_String_String.SetBelong(this.instance);
				}
				return r_RReadToDescendant_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToNextSibling(System.String)
		/// </summary>
		protected RMethod r_RReadToNextSibling_String;
		public virtual RMethod RReadToNextSibling_String
		{
			get
			{
				if(r_RReadToNextSibling_String == null)
				{
					r_RReadToNextSibling_String = new(this, "ReadToNextSibling", 0, typeof(System.String));
					r_RReadToNextSibling_String.SetBelong(this.instance);
				}
				return r_RReadToNextSibling_String;
			}
		}

		/// <summary>
		/// Boolean ReadToNextSibling(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToNextSibling_String_String;
		public virtual RMethod RReadToNextSibling_String_String
		{
			get
			{
				if(r_RReadToNextSibling_String_String == null)
				{
					r_RReadToNextSibling_String_String = new(this, "ReadToNextSibling", 0, typeof(System.String), typeof(System.String));
					r_RReadToNextSibling_String_String.SetBelong(this.instance);
				}
				return r_RReadToNextSibling_String_String;
			}
		}

		/// <summary>
		/// System.String ReadInnerXml()
		/// </summary>
		protected RMethod r_RReadInnerXml;
		public virtual RMethod RReadInnerXml
		{
			get
			{
				if(r_RReadInnerXml == null)
				{
					r_RReadInnerXml = new(this, "ReadInnerXml", 0);
					r_RReadInnerXml.SetBelong(this.instance);
				}
				return r_RReadInnerXml;
			}
		}

		/// <summary>
		/// System.String ReadOuterXml()
		/// </summary>
		protected RMethod r_RReadOuterXml;
		public virtual RMethod RReadOuterXml
		{
			get
			{
				if(r_RReadOuterXml == null)
				{
					r_RReadOuterXml = new(this, "ReadOuterXml", 0);
					r_RReadOuterXml.SetBelong(this.instance);
				}
				return r_RReadOuterXml;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader ReadSubtree()
		/// </summary>
		protected RMethod r_RReadSubtree;
		public virtual RMethod RReadSubtree
		{
			get
			{
				if(r_RReadSubtree == null)
				{
					r_RReadSubtree = new(this, "ReadSubtree", 0);
					r_RReadSubtree.SetBelong(this.instance);
				}
				return r_RReadSubtree;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void CheckElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RCheckElement_String_String;
		public virtual RMethod RCheckElement_String_String
		{
			get
			{
				if(r_RCheckElement_String_String == null)
				{
					r_RCheckElement_String_String = new(this, "CheckElement", 0, typeof(System.String), typeof(System.String));
					r_RCheckElement_String_String.SetBelong(this.instance);
				}
				return r_RCheckElement_String_String;
			}
		}

		/// <summary>
		/// System.Exception CreateReadContentAsException(System.String)
		/// </summary>
		protected RMethod r_RCreateReadContentAsException_String;
		public virtual RMethod RCreateReadContentAsException_String
		{
			get
			{
				if(r_RCreateReadContentAsException_String == null)
				{
					r_RCreateReadContentAsException_String = new(this, "CreateReadContentAsException", 0, typeof(System.String));
					r_RCreateReadContentAsException_String.SetBelong(this.instance);
				}
				return r_RCreateReadContentAsException_String;
			}
		}

		/// <summary>
		/// System.Exception CreateReadElementContentAsException(System.String)
		/// </summary>
		protected RMethod r_RCreateReadElementContentAsException_String;
		public virtual RMethod RCreateReadElementContentAsException_String
		{
			get
			{
				if(r_RCreateReadElementContentAsException_String == null)
				{
					r_RCreateReadElementContentAsException_String = new(this, "CreateReadElementContentAsException", 0, typeof(System.String));
					r_RCreateReadElementContentAsException_String.SetBelong(this.instance);
				}
				return r_RCreateReadElementContentAsException_String;
			}
		}

		/// <summary>
		/// Boolean CanReadContentAs()
		/// </summary>
		protected RMethod r_RCanReadContentAs;
		public virtual RMethod RCanReadContentAs
		{
			get
			{
				if(r_RCanReadContentAs == null)
				{
					r_RCanReadContentAs = new(this, "CanReadContentAs", 0);
					r_RCanReadContentAs.SetBelong(this.instance);
				}
				return r_RCanReadContentAs;
			}
		}

		/// <summary>
		/// System.String InternalReadContentAsString()
		/// </summary>
		protected RMethod r_RInternalReadContentAsString;
		public virtual RMethod RInternalReadContentAsString
		{
			get
			{
				if(r_RInternalReadContentAsString == null)
				{
					r_RInternalReadContentAsString = new(this, "InternalReadContentAsString", 0);
					r_RInternalReadContentAsString.SetBelong(this.instance);
				}
				return r_RInternalReadContentAsString;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] GetValueAsync()
		/// </summary>
		protected RMethod r_RGetValueAsync;
		public virtual RMethod RGetValueAsync
		{
			get
			{
				if(r_RGetValueAsync == null)
				{
					r_RGetValueAsync = new(this, "GetValueAsync", 0);
					r_RGetValueAsync.SetBelong(this.instance);
				}
				return r_RGetValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadContentAsObjectAsync()
		/// </summary>
		protected RMethod r_RReadContentAsObjectAsync;
		public virtual RMethod RReadContentAsObjectAsync
		{
			get
			{
				if(r_RReadContentAsObjectAsync == null)
				{
					r_RReadContentAsObjectAsync = new(this, "ReadContentAsObjectAsync", 0);
					r_RReadContentAsObjectAsync.SetBelong(this.instance);
				}
				return r_RReadContentAsObjectAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadContentAsStringAsync()
		/// </summary>
		protected RMethod r_RReadContentAsStringAsync;
		public virtual RMethod RReadContentAsStringAsync
		{
			get
			{
				if(r_RReadContentAsStringAsync == null)
				{
					r_RReadContentAsStringAsync = new(this, "ReadContentAsStringAsync", 0);
					r_RReadContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RReadContentAsStringAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadContentAsAsync(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadContentAsAsync_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadContentAsAsync_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadContentAsAsync_Type_IXmlNamespaceResolver == null)
				{
					r_RReadContentAsAsync_Type_IXmlNamespaceResolver = new(this, "ReadContentAsAsync", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadContentAsAsync_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadContentAsAsync_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadElementContentAsObjectAsync()
		/// </summary>
		protected RMethod r_RReadElementContentAsObjectAsync;
		public virtual RMethod RReadElementContentAsObjectAsync
		{
			get
			{
				if(r_RReadElementContentAsObjectAsync == null)
				{
					r_RReadElementContentAsObjectAsync = new(this, "ReadElementContentAsObjectAsync", 0);
					r_RReadElementContentAsObjectAsync.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObjectAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadElementContentAsStringAsync()
		/// </summary>
		protected RMethod r_RReadElementContentAsStringAsync;
		public virtual RMethod RReadElementContentAsStringAsync
		{
			get
			{
				if(r_RReadElementContentAsStringAsync == null)
				{
					r_RReadElementContentAsStringAsync = new(this, "ReadElementContentAsStringAsync", 0);
					r_RReadElementContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RReadElementContentAsStringAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadElementContentAsAsync(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadElementContentAsAsync_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver == null)
				{
					r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver = new(this, "ReadElementContentAsAsync", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ReadAsync()
		/// </summary>
		protected RMethod r_RReadAsync;
		public virtual RMethod RReadAsync
		{
			get
			{
				if(r_RReadAsync == null)
				{
					r_RReadAsync = new(this, "ReadAsync", 0);
					r_RReadAsync.SetBelong(this.instance);
				}
				return r_RReadAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipAsync()
		/// </summary>
		protected RMethod r_RSkipAsync;
		public virtual RMethod RSkipAsync
		{
			get
			{
				if(r_RSkipAsync == null)
				{
					r_RSkipAsync = new(this, "SkipAsync", 0);
					r_RSkipAsync.SetBelong(this.instance);
				}
				return r_RSkipAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBase64Async(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBase64Async_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBase64Async_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBase64Async_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBase64Async_ByteArray_Int32_Int32 = new(this, "ReadContentAsBase64Async", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBase64Async_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBase64Async_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBase64Async(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBase64Async_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBase64Async", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBinHexAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinHexAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinHexAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBinHexAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinHexAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadValueChunkAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadValueChunkAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadValueChunkAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadValueChunkAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadValueChunkAsync_CharArray_Int32_Int32 = new(this, "ReadValueChunkAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadValueChunkAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadValueChunkAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Xml.XmlNodeType] MoveToContentAsync()
		/// </summary>
		protected RMethod r_RMoveToContentAsync;
		public virtual RMethod RMoveToContentAsync
		{
			get
			{
				if(r_RMoveToContentAsync == null)
				{
					r_RMoveToContentAsync = new(this, "MoveToContentAsync", 0);
					r_RMoveToContentAsync.SetBelong(this.instance);
				}
				return r_RMoveToContentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadInnerXmlAsync()
		/// </summary>
		protected RMethod r_RReadInnerXmlAsync;
		public virtual RMethod RReadInnerXmlAsync
		{
			get
			{
				if(r_RReadInnerXmlAsync == null)
				{
					r_RReadInnerXmlAsync = new(this, "ReadInnerXmlAsync", 0);
					r_RReadInnerXmlAsync.SetBelong(this.instance);
				}
				return r_RReadInnerXmlAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadOuterXmlAsync()
		/// </summary>
		protected RMethod r_RReadOuterXmlAsync;
		public virtual RMethod RReadOuterXmlAsync
		{
			get
			{
				if(r_RReadOuterXmlAsync == null)
				{
					r_RReadOuterXmlAsync = new(this, "ReadOuterXmlAsync", 0);
					r_RReadOuterXmlAsync.SetBelong(this.instance);
				}
				return r_RReadOuterXmlAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] InternalReadContentAsStringAsync()
		/// </summary>
		protected RMethod r_RInternalReadContentAsStringAsync;
		public virtual RMethod RInternalReadContentAsStringAsync
		{
			get
			{
				if(r_RInternalReadContentAsStringAsync == null)
				{
					r_RInternalReadContentAsStringAsync = new(this, "InternalReadContentAsStringAsync", 0);
					r_RInternalReadContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RInternalReadContentAsStringAsync;
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


        public RXmlTextReader() : base("System.Xml.XmlTextReader")
        {
        }

        public RXmlTextReader(System.Object instance) : base("System.Xml.XmlTextReader")
		{
            SetInstance(instance);
		}

        public RXmlTextReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlTextReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String GetAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAttribute(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGetAttribute_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMoveToAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MoveToAttribute(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMoveToAttribute_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveToFirstAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToFirstAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNextAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNextAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadAttributeValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadAttributeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Skip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RLookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ResolveEntity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveEntity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ReadString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasLineInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasLineInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> System__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual System.String System__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String System__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix(System.String  @namespaceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceName};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RGetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual void ResetState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.TextReader GetRemainder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRemainder.Invoke(___genericsType, ___parameters);

            return (System.IO.TextReader)___result;
        }


        public virtual System.Int32 ReadChars(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadChars_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadBase64(System.Byte[]  @array, System.Int32  @offset, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @len};
            var ___result = RReadBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadBinHex(System.Byte[]  @array, System.Int32  @offset, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @len};
            var ___result = RReadBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object ReadContentAsObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsObject.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ReadContentAsBoolean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsBoolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ReadContentAsDateTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTimeOffset ReadContentAsDateTimeOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.Double ReadContentAsDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Single ReadContentAsFloat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsFloat.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Decimal ReadContentAsDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDecimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Int32 ReadContentAsInt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsInt.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ReadContentAsLong()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsLong.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String ReadContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ReadContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadContentAs_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAsObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsObject.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAsObject(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsObject_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ReadElementContentAsBoolean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsBoolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadElementContentAsBoolean(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsBoolean_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ReadElementContentAsDateTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ReadElementContentAsDateTime(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDateTime_String_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Double ReadElementContentAsDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ReadElementContentAsDouble(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDouble_String_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Single ReadElementContentAsFloat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsFloat.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ReadElementContentAsFloat(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsFloat_String_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Decimal ReadElementContentAsDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDecimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ReadElementContentAsDecimal(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDecimal_String_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Int32 ReadElementContentAsInt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsInt.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsInt(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsInt_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ReadElementContentAsLong()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsLong.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ReadElementContentAsLong(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsLong_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String ReadElementContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementContentAsString(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsString_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ReadElementContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadElementContentAs_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver, System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver, @localName, @namespaceURI};
            var ___result = RReadElementContentAs_Type_IXmlNamespaceResolver_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 ReadValueChunk(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadValueChunk_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Xml.XmlNodeType MoveToContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToContent.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeType)___result;
        }


        public virtual void ReadStartElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadStartElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadStartElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadStartElement_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadStartElement(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RReadStartElement_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ReadElementString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementString(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadElementString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementString(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RReadElementString_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ReadEndElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadEndElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsStartElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsStartElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsStartElement_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartElement(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RIsStartElement_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToFollowing(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToFollowing_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToFollowing(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToFollowing_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToDescendant(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToDescendant_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToDescendant(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToDescendant_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToNextSibling(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToNextSibling_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToNextSibling(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToNextSibling_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ReadInnerXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInnerXml.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadOuterXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadOuterXml.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Xml.XmlReader ReadSubtree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadSubtree.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElement(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RCheckElement_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception CreateReadContentAsException(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCreateReadContentAsException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CreateReadElementContentAsException(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCreateReadElementContentAsException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Boolean CanReadContentAs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanReadContentAs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalReadContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReadContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> GetValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadContentAsObjectAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsObjectAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadContentAsAsync(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadContentAsAsync_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadElementContentAsObjectAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsObjectAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadElementContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadElementContentAsAsync(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadElementContentAsAsync_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ReadAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task SkipAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadValueChunkAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadValueChunkAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Xml.XmlNodeType> MoveToContentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToContentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Xml.XmlNodeType>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadInnerXmlAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInnerXmlAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadOuterXmlAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadOuterXmlAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> InternalReadContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReadContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
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
