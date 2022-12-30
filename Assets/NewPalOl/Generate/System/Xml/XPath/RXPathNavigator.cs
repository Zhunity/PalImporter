using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RXPath
{
	/// <summary>
	/// System.Xml.XPath.XPathNavigator
	/// </summary>
    public partial class RXPathNavigator : RMember //
    {

		/// <summary>
		/// System.Xml.XPath.XPathNavigatorKeyComparer comparer
		/// </summary>
		protected static RSystem.RXml.RXPath.RXPathNavigatorKeyComparer r_comparer;
		public static RSystem.RXml.RXPath.RXPathNavigatorKeyComparer Rcomparer
		{
			get
			{
				if(r_comparer == null)
				{
					r_comparer = new(typeof(System.Xml.XPath.XPathNavigator), "comparer");
					r_comparer.SetBelong(null);
				}
				return r_comparer;
			}
		}

		/// <summary>
		/// System.Char[] NodeTypeLetter
		/// </summary>
		protected static RFieldArray<RField> r_NodeTypeLetter;
		public static RFieldArray<RField> RNodeTypeLetter
		{
			get
			{
				if(r_NodeTypeLetter == null)
				{
					r_NodeTypeLetter = new(typeof(System.Xml.XPath.XPathNavigator), "NodeTypeLetter");
					r_NodeTypeLetter.SetBelong(null);
				}
				return r_NodeTypeLetter;
			}
		}

		/// <summary>
		/// System.Char[] UniqueIdTbl
		/// </summary>
		protected static RFieldArray<RField> r_UniqueIdTbl;
		public static RFieldArray<RField> RUniqueIdTbl
		{
			get
			{
				if(r_UniqueIdTbl == null)
				{
					r_UniqueIdTbl = new(typeof(System.Xml.XPath.XPathNavigator), "UniqueIdTbl");
					r_UniqueIdTbl.SetBelong(null);
				}
				return r_UniqueIdTbl;
			}
		}

		/// <summary>
		/// System.Int32 AllMask
		/// </summary>
		protected static RField r_AllMask;
		public static RField RAllMask
		{
			get
			{
				if(r_AllMask == null)
				{
					r_AllMask = new(typeof(System.Xml.XPath.XPathNavigator), "AllMask");
					r_AllMask.SetBelong(null);
				}
				return r_AllMask;
			}
		}

		/// <summary>
		/// System.Int32 NoAttrNmspMask
		/// </summary>
		protected static RField r_NoAttrNmspMask;
		public static RField RNoAttrNmspMask
		{
			get
			{
				if(r_NoAttrNmspMask == null)
				{
					r_NoAttrNmspMask = new(typeof(System.Xml.XPath.XPathNavigator), "NoAttrNmspMask");
					r_NoAttrNmspMask.SetBelong(null);
				}
				return r_NoAttrNmspMask;
			}
		}

		/// <summary>
		/// System.Int32 TextMask
		/// </summary>
		protected static RField r_TextMask;
		public static RField RTextMask
		{
			get
			{
				if(r_TextMask == null)
				{
					r_TextMask = new(typeof(System.Xml.XPath.XPathNavigator), "TextMask");
					r_TextMask.SetBelong(null);
				}
				return r_TextMask;
			}
		}

		/// <summary>
		/// System.Int32[] ContentKindMasks
		/// </summary>
		protected static RFieldArray<RField> r_ContentKindMasks;
		public static RFieldArray<RField> RContentKindMasks
		{
			get
			{
				if(r_ContentKindMasks == null)
				{
					r_ContentKindMasks = new(typeof(System.Xml.XPath.XPathNavigator), "ContentKindMasks");
					r_ContentKindMasks.SetBelong(null);
				}
				return r_ContentKindMasks;
			}
		}

		/// <summary>
		/// Boolean IsNode
		/// </summary>
		protected RProperty r_IsNode;
		public virtual RProperty RIsNode
		{
			get
			{
				if(r_IsNode == null)
				{
					r_IsNode = new(this, "IsNode", -1);
					r_IsNode.SetBelong(this.instance);
				}
				return r_IsNode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType XmlType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_XmlType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RXmlType
		{
			get
			{
				if(r_XmlType == null)
				{
					r_XmlType = new(this, "XmlType", -1);
					r_XmlType.SetBelong(this.instance);
				}
				return r_XmlType;
			}
		}

		/// <summary>
		/// System.Object TypedValue
		/// </summary>
		protected RSystem.RObject r_TypedValue;
		public virtual RSystem.RObject RTypedValue
		{
			get
			{
				if(r_TypedValue == null)
				{
					r_TypedValue = new(this, "TypedValue", -1);
					r_TypedValue.SetBelong(this.instance);
				}
				return r_TypedValue;
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
		/// Boolean ValueAsBoolean
		/// </summary>
		protected RProperty r_ValueAsBoolean;
		public virtual RProperty RValueAsBoolean
		{
			get
			{
				if(r_ValueAsBoolean == null)
				{
					r_ValueAsBoolean = new(this, "ValueAsBoolean", -1);
					r_ValueAsBoolean.SetBelong(this.instance);
				}
				return r_ValueAsBoolean;
			}
		}

		/// <summary>
		/// System.DateTime ValueAsDateTime
		/// </summary>
		protected RSystem.RDateTime r_ValueAsDateTime;
		public virtual RSystem.RDateTime RValueAsDateTime
		{
			get
			{
				if(r_ValueAsDateTime == null)
				{
					r_ValueAsDateTime = new(this, "ValueAsDateTime", -1);
					r_ValueAsDateTime.SetBelong(this.instance);
				}
				return r_ValueAsDateTime;
			}
		}

		/// <summary>
		/// Double ValueAsDouble
		/// </summary>
		protected RProperty r_ValueAsDouble;
		public virtual RProperty RValueAsDouble
		{
			get
			{
				if(r_ValueAsDouble == null)
				{
					r_ValueAsDouble = new(this, "ValueAsDouble", -1);
					r_ValueAsDouble.SetBelong(this.instance);
				}
				return r_ValueAsDouble;
			}
		}

		/// <summary>
		/// Int32 ValueAsInt
		/// </summary>
		protected RProperty r_ValueAsInt;
		public virtual RProperty RValueAsInt
		{
			get
			{
				if(r_ValueAsInt == null)
				{
					r_ValueAsInt = new(this, "ValueAsInt", -1);
					r_ValueAsInt.SetBelong(this.instance);
				}
				return r_ValueAsInt;
			}
		}

		/// <summary>
		/// Int64 ValueAsLong
		/// </summary>
		protected RProperty r_ValueAsLong;
		public virtual RProperty RValueAsLong
		{
			get
			{
				if(r_ValueAsLong == null)
				{
					r_ValueAsLong = new(this, "ValueAsLong", -1);
					r_ValueAsLong.SetBelong(this.instance);
				}
				return r_ValueAsLong;
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
		/// System.Collections.IEqualityComparer NavigatorComparer
		/// </summary>
		protected static RSystem.RCollections.RIEqualityComparer r_NavigatorComparer;
		public static RSystem.RCollections.RIEqualityComparer RNavigatorComparer
		{
			get
			{
				if(r_NavigatorComparer == null)
				{
					r_NavigatorComparer = new(typeof(System.Xml.XPath.XPathNavigator), "NavigatorComparer", -1);
					r_NavigatorComparer.SetBelong(null);
				}
				return r_NavigatorComparer;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeType NodeType
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
		/// System.Object UnderlyingObject
		/// </summary>
		protected RSystem.RObject r_UnderlyingObject;
		public virtual RSystem.RObject RUnderlyingObject
		{
			get
			{
				if(r_UnderlyingObject == null)
				{
					r_UnderlyingObject = new(this, "UnderlyingObject", -1);
					r_UnderlyingObject.SetBelong(this.instance);
				}
				return r_UnderlyingObject;
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
		/// Boolean HasChildren
		/// </summary>
		protected RProperty r_HasChildren;
		public virtual RProperty RHasChildren
		{
			get
			{
				if(r_HasChildren == null)
				{
					r_HasChildren = new(this, "HasChildren", -1);
					r_HasChildren.SetBelong(this.instance);
				}
				return r_HasChildren;
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
		/// Boolean CanEdit
		/// </summary>
		protected RProperty r_CanEdit;
		public virtual RProperty RCanEdit
		{
			get
			{
				if(r_CanEdit == null)
				{
					r_CanEdit = new(this, "CanEdit", -1);
					r_CanEdit.SetBelong(this.instance);
				}
				return r_CanEdit;
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
		/// UInt32 IndexInParent
		/// </summary>
		protected RProperty r_IndexInParent;
		public virtual RProperty RIndexInParent
		{
			get
			{
				if(r_IndexInParent == null)
				{
					r_IndexInParent = new(this, "IndexInParent", -1);
					r_IndexInParent.SetBelong(this.instance);
				}
				return r_IndexInParent;
			}
		}

		/// <summary>
		/// System.String UniqueId
		/// </summary>
		protected RProperty r_UniqueId;
		public virtual RProperty RUniqueId
		{
			get
			{
				if(r_UniqueId == null)
				{
					r_UniqueId = new(this, "UniqueId", -1);
					r_UniqueId.SetBelong(this.instance);
				}
				return r_UniqueId;
			}
		}

		/// <summary>
		/// System.Object debuggerDisplayProxy
		/// </summary>
		protected RSystem.RObject r_debuggerDisplayProxy;
		public virtual RSystem.RObject RdebuggerDisplayProxy
		{
			get
			{
				if(r_debuggerDisplayProxy == null)
				{
					r_debuggerDisplayProxy = new(this, "debuggerDisplayProxy", -1);
					r_debuggerDisplayProxy.SetBelong(this.instance);
				}
				return r_debuggerDisplayProxy;
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

		/// <summary>
		/// Void SetValue(System.String)
		/// </summary>
		protected RMethod r_RSetValue_String;
		public virtual RMethod RSetValue_String
		{
			get
			{
				if(r_RSetValue_String == null)
				{
					r_RSetValue_String = new(this, "SetValue", 0, typeof(System.String));
					r_RSetValue_String.SetBelong(this.instance);
				}
				return r_RSetValue_String;
			}
		}

		/// <summary>
		/// Void SetTypedValue(System.Object)
		/// </summary>
		protected RMethod r_RSetTypedValue_Object;
		public virtual RMethod RSetTypedValue_Object
		{
			get
			{
				if(r_RSetTypedValue_Object == null)
				{
					r_RSetTypedValue_Object = new(this, "SetTypedValue", 0, typeof(System.Object));
					r_RSetTypedValue_Object.SetBelong(this.instance);
				}
				return r_RSetTypedValue_Object;
			}
		}

		/// <summary>
		/// System.Object ValueAs(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RValueAs_Type_IXmlNamespaceResolver;
		public virtual RMethod RValueAs_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RValueAs_Type_IXmlNamespaceResolver == null)
				{
					r_RValueAs_Type_IXmlNamespaceResolver = new(this, "ValueAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RValueAs_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RValueAs_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object System.ICloneable.Clone()
		/// </summary>
		protected RMethod r_RSystem__1__ICloneable__1__Clone;
		public virtual RMethod RSystem__1__ICloneable__1__Clone
		{
			get
			{
				if(r_RSystem__1__ICloneable__1__Clone == null)
				{
					r_RSystem__1__ICloneable__1__Clone = new(this, "System.ICloneable.Clone", 0);
					r_RSystem__1__ICloneable__1__Clone.SetBelong(this.instance);
				}
				return r_RSystem__1__ICloneable__1__Clone;
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
		/// System.String LookupPrefix(System.String)
		/// </summary>
		protected RMethod r_RLookupPrefix_String;
		public virtual RMethod RLookupPrefix_String
		{
			get
			{
				if(r_RLookupPrefix_String == null)
				{
					r_RLookupPrefix_String = new(this, "LookupPrefix", 0, typeof(System.String));
					r_RLookupPrefix_String.SetBelong(this.instance);
				}
				return r_RLookupPrefix_String;
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
		/// System.Xml.XPath.XPathNavigator Clone()
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
		/// Void WriteSubtree(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RWriteSubtree_XmlWriter;
		public virtual RMethod RWriteSubtree_XmlWriter
		{
			get
			{
				if(r_RWriteSubtree_XmlWriter == null)
				{
					r_RWriteSubtree_XmlWriter = new(this, "WriteSubtree", 0, typeof(System.Xml.XmlWriter));
					r_RWriteSubtree_XmlWriter.SetBelong(this.instance);
				}
				return r_RWriteSubtree_XmlWriter;
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
		/// System.String GetNamespace(System.String)
		/// </summary>
		protected RMethod r_RGetNamespace_String;
		public virtual RMethod RGetNamespace_String
		{
			get
			{
				if(r_RGetNamespace_String == null)
				{
					r_RGetNamespace_String = new(this, "GetNamespace", 0, typeof(System.String));
					r_RGetNamespace_String.SetBelong(this.instance);
				}
				return r_RGetNamespace_String;
			}
		}

		/// <summary>
		/// Boolean MoveToNamespace(System.String)
		/// </summary>
		protected RMethod r_RMoveToNamespace_String;
		public virtual RMethod RMoveToNamespace_String
		{
			get
			{
				if(r_RMoveToNamespace_String == null)
				{
					r_RMoveToNamespace_String = new(this, "MoveToNamespace", 0, typeof(System.String));
					r_RMoveToNamespace_String.SetBelong(this.instance);
				}
				return r_RMoveToNamespace_String;
			}
		}

		/// <summary>
		/// Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope)
		/// </summary>
		protected RMethod r_RMoveToFirstNamespace_XPathNamespaceScope;
		public virtual RMethod RMoveToFirstNamespace_XPathNamespaceScope
		{
			get
			{
				if(r_RMoveToFirstNamespace_XPathNamespaceScope == null)
				{
					r_RMoveToFirstNamespace_XPathNamespaceScope = new(this, "MoveToFirstNamespace", 0, typeof(System.Xml.XPath.XPathNamespaceScope));
					r_RMoveToFirstNamespace_XPathNamespaceScope.SetBelong(this.instance);
				}
				return r_RMoveToFirstNamespace_XPathNamespaceScope;
			}
		}

		/// <summary>
		/// Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope)
		/// </summary>
		protected RMethod r_RMoveToNextNamespace_XPathNamespaceScope;
		public virtual RMethod RMoveToNextNamespace_XPathNamespaceScope
		{
			get
			{
				if(r_RMoveToNextNamespace_XPathNamespaceScope == null)
				{
					r_RMoveToNextNamespace_XPathNamespaceScope = new(this, "MoveToNextNamespace", 0, typeof(System.Xml.XPath.XPathNamespaceScope));
					r_RMoveToNextNamespace_XPathNamespaceScope.SetBelong(this.instance);
				}
				return r_RMoveToNextNamespace_XPathNamespaceScope;
			}
		}

		/// <summary>
		/// Boolean MoveToFirstNamespace()
		/// </summary>
		protected RMethod r_RMoveToFirstNamespace;
		public virtual RMethod RMoveToFirstNamespace
		{
			get
			{
				if(r_RMoveToFirstNamespace == null)
				{
					r_RMoveToFirstNamespace = new(this, "MoveToFirstNamespace", 0);
					r_RMoveToFirstNamespace.SetBelong(this.instance);
				}
				return r_RMoveToFirstNamespace;
			}
		}

		/// <summary>
		/// Boolean MoveToNextNamespace()
		/// </summary>
		protected RMethod r_RMoveToNextNamespace;
		public virtual RMethod RMoveToNextNamespace
		{
			get
			{
				if(r_RMoveToNextNamespace == null)
				{
					r_RMoveToNextNamespace = new(this, "MoveToNextNamespace", 0);
					r_RMoveToNextNamespace.SetBelong(this.instance);
				}
				return r_RMoveToNextNamespace;
			}
		}

		/// <summary>
		/// Boolean MoveToNext()
		/// </summary>
		protected RMethod r_RMoveToNext;
		public virtual RMethod RMoveToNext
		{
			get
			{
				if(r_RMoveToNext == null)
				{
					r_RMoveToNext = new(this, "MoveToNext", 0);
					r_RMoveToNext.SetBelong(this.instance);
				}
				return r_RMoveToNext;
			}
		}

		/// <summary>
		/// Boolean MoveToPrevious()
		/// </summary>
		protected RMethod r_RMoveToPrevious;
		public virtual RMethod RMoveToPrevious
		{
			get
			{
				if(r_RMoveToPrevious == null)
				{
					r_RMoveToPrevious = new(this, "MoveToPrevious", 0);
					r_RMoveToPrevious.SetBelong(this.instance);
				}
				return r_RMoveToPrevious;
			}
		}

		/// <summary>
		/// Boolean MoveToFirst()
		/// </summary>
		protected RMethod r_RMoveToFirst;
		public virtual RMethod RMoveToFirst
		{
			get
			{
				if(r_RMoveToFirst == null)
				{
					r_RMoveToFirst = new(this, "MoveToFirst", 0);
					r_RMoveToFirst.SetBelong(this.instance);
				}
				return r_RMoveToFirst;
			}
		}

		/// <summary>
		/// Boolean MoveToFirstChild()
		/// </summary>
		protected RMethod r_RMoveToFirstChild;
		public virtual RMethod RMoveToFirstChild
		{
			get
			{
				if(r_RMoveToFirstChild == null)
				{
					r_RMoveToFirstChild = new(this, "MoveToFirstChild", 0);
					r_RMoveToFirstChild.SetBelong(this.instance);
				}
				return r_RMoveToFirstChild;
			}
		}

		/// <summary>
		/// Boolean MoveToParent()
		/// </summary>
		protected RMethod r_RMoveToParent;
		public virtual RMethod RMoveToParent
		{
			get
			{
				if(r_RMoveToParent == null)
				{
					r_RMoveToParent = new(this, "MoveToParent", 0);
					r_RMoveToParent.SetBelong(this.instance);
				}
				return r_RMoveToParent;
			}
		}

		/// <summary>
		/// Void MoveToRoot()
		/// </summary>
		protected RMethod r_RMoveToRoot;
		public virtual RMethod RMoveToRoot
		{
			get
			{
				if(r_RMoveToRoot == null)
				{
					r_RMoveToRoot = new(this, "MoveToRoot", 0);
					r_RMoveToRoot.SetBelong(this.instance);
				}
				return r_RMoveToRoot;
			}
		}

		/// <summary>
		/// Boolean MoveTo(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RMoveTo_XPathNavigator;
		public virtual RMethod RMoveTo_XPathNavigator
		{
			get
			{
				if(r_RMoveTo_XPathNavigator == null)
				{
					r_RMoveTo_XPathNavigator = new(this, "MoveTo", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RMoveTo_XPathNavigator.SetBelong(this.instance);
				}
				return r_RMoveTo_XPathNavigator;
			}
		}

		/// <summary>
		/// Boolean MoveToId(System.String)
		/// </summary>
		protected RMethod r_RMoveToId_String;
		public virtual RMethod RMoveToId_String
		{
			get
			{
				if(r_RMoveToId_String == null)
				{
					r_RMoveToId_String = new(this, "MoveToId", 0, typeof(System.String));
					r_RMoveToId_String.SetBelong(this.instance);
				}
				return r_RMoveToId_String;
			}
		}

		/// <summary>
		/// Boolean MoveToChild(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToChild_String_String;
		public virtual RMethod RMoveToChild_String_String
		{
			get
			{
				if(r_RMoveToChild_String_String == null)
				{
					r_RMoveToChild_String_String = new(this, "MoveToChild", 0, typeof(System.String), typeof(System.String));
					r_RMoveToChild_String_String.SetBelong(this.instance);
				}
				return r_RMoveToChild_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToChild(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RMoveToChild_XPathNodeType;
		public virtual RMethod RMoveToChild_XPathNodeType
		{
			get
			{
				if(r_RMoveToChild_XPathNodeType == null)
				{
					r_RMoveToChild_XPathNodeType = new(this, "MoveToChild", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RMoveToChild_XPathNodeType.SetBelong(this.instance);
				}
				return r_RMoveToChild_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean MoveToFollowing(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToFollowing_String_String;
		public virtual RMethod RMoveToFollowing_String_String
		{
			get
			{
				if(r_RMoveToFollowing_String_String == null)
				{
					r_RMoveToFollowing_String_String = new(this, "MoveToFollowing", 0, typeof(System.String), typeof(System.String));
					r_RMoveToFollowing_String_String.SetBelong(this.instance);
				}
				return r_RMoveToFollowing_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToFollowing(System.String, System.String, System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RMoveToFollowing_String_String_XPathNavigator;
		public virtual RMethod RMoveToFollowing_String_String_XPathNavigator
		{
			get
			{
				if(r_RMoveToFollowing_String_String_XPathNavigator == null)
				{
					r_RMoveToFollowing_String_String_XPathNavigator = new(this, "MoveToFollowing", 0, typeof(System.String), typeof(System.String), typeof(System.Xml.XPath.XPathNavigator));
					r_RMoveToFollowing_String_String_XPathNavigator.SetBelong(this.instance);
				}
				return r_RMoveToFollowing_String_String_XPathNavigator;
			}
		}

		/// <summary>
		/// Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RMoveToFollowing_XPathNodeType;
		public virtual RMethod RMoveToFollowing_XPathNodeType
		{
			get
			{
				if(r_RMoveToFollowing_XPathNodeType == null)
				{
					r_RMoveToFollowing_XPathNodeType = new(this, "MoveToFollowing", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RMoveToFollowing_XPathNodeType.SetBelong(this.instance);
				}
				return r_RMoveToFollowing_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType, System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RMoveToFollowing_XPathNodeType_XPathNavigator;
		public virtual RMethod RMoveToFollowing_XPathNodeType_XPathNavigator
		{
			get
			{
				if(r_RMoveToFollowing_XPathNodeType_XPathNavigator == null)
				{
					r_RMoveToFollowing_XPathNodeType_XPathNavigator = new(this, "MoveToFollowing", 0, typeof(System.Xml.XPath.XPathNodeType), typeof(System.Xml.XPath.XPathNavigator));
					r_RMoveToFollowing_XPathNodeType_XPathNavigator.SetBelong(this.instance);
				}
				return r_RMoveToFollowing_XPathNodeType_XPathNavigator;
			}
		}

		/// <summary>
		/// Boolean MoveToNext(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToNext_String_String;
		public virtual RMethod RMoveToNext_String_String
		{
			get
			{
				if(r_RMoveToNext_String_String == null)
				{
					r_RMoveToNext_String_String = new(this, "MoveToNext", 0, typeof(System.String), typeof(System.String));
					r_RMoveToNext_String_String.SetBelong(this.instance);
				}
				return r_RMoveToNext_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToNext(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RMoveToNext_XPathNodeType;
		public virtual RMethod RMoveToNext_XPathNodeType
		{
			get
			{
				if(r_RMoveToNext_XPathNodeType == null)
				{
					r_RMoveToNext_XPathNodeType = new(this, "MoveToNext", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RMoveToNext_XPathNodeType.SetBelong(this.instance);
				}
				return r_RMoveToNext_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean IsSamePosition(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RIsSamePosition_XPathNavigator;
		public virtual RMethod RIsSamePosition_XPathNavigator
		{
			get
			{
				if(r_RIsSamePosition_XPathNavigator == null)
				{
					r_RIsSamePosition_XPathNavigator = new(this, "IsSamePosition", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RIsSamePosition_XPathNavigator.SetBelong(this.instance);
				}
				return r_RIsSamePosition_XPathNavigator;
			}
		}

		/// <summary>
		/// Boolean IsDescendant(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RIsDescendant_XPathNavigator;
		public virtual RMethod RIsDescendant_XPathNavigator
		{
			get
			{
				if(r_RIsDescendant_XPathNavigator == null)
				{
					r_RIsDescendant_XPathNavigator = new(this, "IsDescendant", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RIsDescendant_XPathNavigator.SetBelong(this.instance);
				}
				return r_RIsDescendant_XPathNavigator;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RComparePosition_XPathNavigator;
		public virtual RMethod RComparePosition_XPathNavigator
		{
			get
			{
				if(r_RComparePosition_XPathNavigator == null)
				{
					r_RComparePosition_XPathNavigator = new(this, "ComparePosition", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RComparePosition_XPathNavigator.SetBelong(this.instance);
				}
				return r_RComparePosition_XPathNavigator;
			}
		}

		/// <summary>
		/// Boolean CheckValidity(System.Xml.Schema.XmlSchemaSet, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RCheckValidity_XmlSchemaSet_ValidationEventHandler;
		public virtual RMethod RCheckValidity_XmlSchemaSet_ValidationEventHandler
		{
			get
			{
				if(r_RCheckValidity_XmlSchemaSet_ValidationEventHandler == null)
				{
					r_RCheckValidity_XmlSchemaSet_ValidationEventHandler = new(this, "CheckValidity", 0, typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RCheckValidity_XmlSchemaSet_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RCheckValidity_XmlSchemaSet_ValidationEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader GetValidatingReader(System.Xml.XmlReader, System.Xml.Schema.XmlSchemaSet, System.Xml.Schema.ValidationEventHandler, System.Xml.Schema.XmlSchemaType, System.Xml.Schema.XmlSchemaElement, System.Xml.Schema.XmlSchemaAttribute)
		/// </summary>
		protected RMethod r_RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute;
		public virtual RMethod RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute
		{
			get
			{
				if(r_RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute == null)
				{
					r_RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute = new(this, "GetValidatingReader", 0, typeof(System.Xml.XmlReader), typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.Xml.Schema.XmlSchemaType), typeof(System.Xml.Schema.XmlSchemaElement), typeof(System.Xml.Schema.XmlSchemaAttribute));
					r_RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute.SetBelong(this.instance);
				}
				return r_RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathExpression Compile(System.String)
		/// </summary>
		protected RMethod r_RCompile_String;
		public virtual RMethod RCompile_String
		{
			get
			{
				if(r_RCompile_String == null)
				{
					r_RCompile_String = new(this, "Compile", 0, typeof(System.String));
					r_RCompile_String.SetBelong(this.instance);
				}
				return r_RCompile_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNavigator SelectSingleNode(System.String)
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
		/// System.Xml.XPath.XPathNavigator SelectSingleNode(System.String, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RSelectSingleNode_String_IXmlNamespaceResolver;
		public virtual RMethod RSelectSingleNode_String_IXmlNamespaceResolver
		{
			get
			{
				if(r_RSelectSingleNode_String_IXmlNamespaceResolver == null)
				{
					r_RSelectSingleNode_String_IXmlNamespaceResolver = new(this, "SelectSingleNode", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver));
					r_RSelectSingleNode_String_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RSelectSingleNode_String_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNavigator SelectSingleNode(System.Xml.XPath.XPathExpression)
		/// </summary>
		protected RMethod r_RSelectSingleNode_XPathExpression;
		public virtual RMethod RSelectSingleNode_XPathExpression
		{
			get
			{
				if(r_RSelectSingleNode_XPathExpression == null)
				{
					r_RSelectSingleNode_XPathExpression = new(this, "SelectSingleNode", 0, typeof(System.Xml.XPath.XPathExpression));
					r_RSelectSingleNode_XPathExpression.SetBelong(this.instance);
				}
				return r_RSelectSingleNode_XPathExpression;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator Select(System.String)
		/// </summary>
		protected RMethod r_RSelect_String;
		public virtual RMethod RSelect_String
		{
			get
			{
				if(r_RSelect_String == null)
				{
					r_RSelect_String = new(this, "Select", 0, typeof(System.String));
					r_RSelect_String.SetBelong(this.instance);
				}
				return r_RSelect_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator Select(System.String, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RSelect_String_IXmlNamespaceResolver;
		public virtual RMethod RSelect_String_IXmlNamespaceResolver
		{
			get
			{
				if(r_RSelect_String_IXmlNamespaceResolver == null)
				{
					r_RSelect_String_IXmlNamespaceResolver = new(this, "Select", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver));
					r_RSelect_String_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RSelect_String_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression)
		/// </summary>
		protected RMethod r_RSelect_XPathExpression;
		public virtual RMethod RSelect_XPathExpression
		{
			get
			{
				if(r_RSelect_XPathExpression == null)
				{
					r_RSelect_XPathExpression = new(this, "Select", 0, typeof(System.Xml.XPath.XPathExpression));
					r_RSelect_XPathExpression.SetBelong(this.instance);
				}
				return r_RSelect_XPathExpression;
			}
		}

		/// <summary>
		/// System.Object Evaluate(System.String)
		/// </summary>
		protected RMethod r_REvaluate_String;
		public virtual RMethod REvaluate_String
		{
			get
			{
				if(r_REvaluate_String == null)
				{
					r_REvaluate_String = new(this, "Evaluate", 0, typeof(System.String));
					r_REvaluate_String.SetBelong(this.instance);
				}
				return r_REvaluate_String;
			}
		}

		/// <summary>
		/// System.Object Evaluate(System.String, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_REvaluate_String_IXmlNamespaceResolver;
		public virtual RMethod REvaluate_String_IXmlNamespaceResolver
		{
			get
			{
				if(r_REvaluate_String_IXmlNamespaceResolver == null)
				{
					r_REvaluate_String_IXmlNamespaceResolver = new(this, "Evaluate", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver));
					r_REvaluate_String_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_REvaluate_String_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object Evaluate(System.Xml.XPath.XPathExpression)
		/// </summary>
		protected RMethod r_REvaluate_XPathExpression;
		public virtual RMethod REvaluate_XPathExpression
		{
			get
			{
				if(r_REvaluate_XPathExpression == null)
				{
					r_REvaluate_XPathExpression = new(this, "Evaluate", 0, typeof(System.Xml.XPath.XPathExpression));
					r_REvaluate_XPathExpression.SetBelong(this.instance);
				}
				return r_REvaluate_XPathExpression;
			}
		}

		/// <summary>
		/// System.Object Evaluate(System.Xml.XPath.XPathExpression, System.Xml.XPath.XPathNodeIterator)
		/// </summary>
		protected RMethod r_REvaluate_XPathExpression_XPathNodeIterator;
		public virtual RMethod REvaluate_XPathExpression_XPathNodeIterator
		{
			get
			{
				if(r_REvaluate_XPathExpression_XPathNodeIterator == null)
				{
					r_REvaluate_XPathExpression_XPathNodeIterator = new(this, "Evaluate", 0, typeof(System.Xml.XPath.XPathExpression), typeof(System.Xml.XPath.XPathNodeIterator));
					r_REvaluate_XPathExpression_XPathNodeIterator.SetBelong(this.instance);
				}
				return r_REvaluate_XPathExpression_XPathNodeIterator;
			}
		}

		/// <summary>
		/// Boolean Matches(System.Xml.XPath.XPathExpression)
		/// </summary>
		protected RMethod r_RMatches_XPathExpression;
		public virtual RMethod RMatches_XPathExpression
		{
			get
			{
				if(r_RMatches_XPathExpression == null)
				{
					r_RMatches_XPathExpression = new(this, "Matches", 0, typeof(System.Xml.XPath.XPathExpression));
					r_RMatches_XPathExpression.SetBelong(this.instance);
				}
				return r_RMatches_XPathExpression;
			}
		}

		/// <summary>
		/// Boolean Matches(System.String)
		/// </summary>
		protected RMethod r_RMatches_String;
		public virtual RMethod RMatches_String
		{
			get
			{
				if(r_RMatches_String == null)
				{
					r_RMatches_String = new(this, "Matches", 0, typeof(System.String));
					r_RMatches_String.SetBelong(this.instance);
				}
				return r_RMatches_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RSelectChildren_XPathNodeType;
		public virtual RMethod RSelectChildren_XPathNodeType
		{
			get
			{
				if(r_RSelectChildren_XPathNodeType == null)
				{
					r_RSelectChildren_XPathNodeType = new(this, "SelectChildren", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RSelectChildren_XPathNodeType.SetBelong(this.instance);
				}
				return r_RSelectChildren_XPathNodeType;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectChildren(System.String, System.String)
		/// </summary>
		protected RMethod r_RSelectChildren_String_String;
		public virtual RMethod RSelectChildren_String_String
		{
			get
			{
				if(r_RSelectChildren_String_String == null)
				{
					r_RSelectChildren_String_String = new(this, "SelectChildren", 0, typeof(System.String), typeof(System.String));
					r_RSelectChildren_String_String.SetBelong(this.instance);
				}
				return r_RSelectChildren_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectAncestors(System.Xml.XPath.XPathNodeType, Boolean)
		/// </summary>
		protected RMethod r_RSelectAncestors_XPathNodeType_Boolean;
		public virtual RMethod RSelectAncestors_XPathNodeType_Boolean
		{
			get
			{
				if(r_RSelectAncestors_XPathNodeType_Boolean == null)
				{
					r_RSelectAncestors_XPathNodeType_Boolean = new(this, "SelectAncestors", 0, typeof(System.Xml.XPath.XPathNodeType), typeof(System.Boolean));
					r_RSelectAncestors_XPathNodeType_Boolean.SetBelong(this.instance);
				}
				return r_RSelectAncestors_XPathNodeType_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectAncestors(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_RSelectAncestors_String_String_Boolean;
		public virtual RMethod RSelectAncestors_String_String_Boolean
		{
			get
			{
				if(r_RSelectAncestors_String_String_Boolean == null)
				{
					r_RSelectAncestors_String_String_Boolean = new(this, "SelectAncestors", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RSelectAncestors_String_String_Boolean.SetBelong(this.instance);
				}
				return r_RSelectAncestors_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType, Boolean)
		/// </summary>
		protected RMethod r_RSelectDescendants_XPathNodeType_Boolean;
		public virtual RMethod RSelectDescendants_XPathNodeType_Boolean
		{
			get
			{
				if(r_RSelectDescendants_XPathNodeType_Boolean == null)
				{
					r_RSelectDescendants_XPathNodeType_Boolean = new(this, "SelectDescendants", 0, typeof(System.Xml.XPath.XPathNodeType), typeof(System.Boolean));
					r_RSelectDescendants_XPathNodeType_Boolean.SetBelong(this.instance);
				}
				return r_RSelectDescendants_XPathNodeType_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_RSelectDescendants_String_String_Boolean;
		public virtual RMethod RSelectDescendants_String_String_Boolean
		{
			get
			{
				if(r_RSelectDescendants_String_String_Boolean == null)
				{
					r_RSelectDescendants_String_String_Boolean = new(this, "SelectDescendants", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RSelectDescendants_String_String_Boolean.SetBelong(this.instance);
				}
				return r_RSelectDescendants_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter PrependChild()
		/// </summary>
		protected RMethod r_RPrependChild;
		public virtual RMethod RPrependChild
		{
			get
			{
				if(r_RPrependChild == null)
				{
					r_RPrependChild = new(this, "PrependChild", 0);
					r_RPrependChild.SetBelong(this.instance);
				}
				return r_RPrependChild;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter AppendChild()
		/// </summary>
		protected RMethod r_RAppendChild;
		public virtual RMethod RAppendChild
		{
			get
			{
				if(r_RAppendChild == null)
				{
					r_RAppendChild = new(this, "AppendChild", 0);
					r_RAppendChild.SetBelong(this.instance);
				}
				return r_RAppendChild;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter InsertAfter()
		/// </summary>
		protected RMethod r_RInsertAfter;
		public virtual RMethod RInsertAfter
		{
			get
			{
				if(r_RInsertAfter == null)
				{
					r_RInsertAfter = new(this, "InsertAfter", 0);
					r_RInsertAfter.SetBelong(this.instance);
				}
				return r_RInsertAfter;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter InsertBefore()
		/// </summary>
		protected RMethod r_RInsertBefore;
		public virtual RMethod RInsertBefore
		{
			get
			{
				if(r_RInsertBefore == null)
				{
					r_RInsertBefore = new(this, "InsertBefore", 0);
					r_RInsertBefore.SetBelong(this.instance);
				}
				return r_RInsertBefore;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter CreateAttributes()
		/// </summary>
		protected RMethod r_RCreateAttributes;
		public virtual RMethod RCreateAttributes
		{
			get
			{
				if(r_RCreateAttributes == null)
				{
					r_RCreateAttributes = new(this, "CreateAttributes", 0);
					r_RCreateAttributes.SetBelong(this.instance);
				}
				return r_RCreateAttributes;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter ReplaceRange(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RReplaceRange_XPathNavigator;
		public virtual RMethod RReplaceRange_XPathNavigator
		{
			get
			{
				if(r_RReplaceRange_XPathNavigator == null)
				{
					r_RReplaceRange_XPathNavigator = new(this, "ReplaceRange", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RReplaceRange_XPathNavigator.SetBelong(this.instance);
				}
				return r_RReplaceRange_XPathNavigator;
			}
		}

		/// <summary>
		/// Void ReplaceSelf(System.String)
		/// </summary>
		protected RMethod r_RReplaceSelf_String;
		public virtual RMethod RReplaceSelf_String
		{
			get
			{
				if(r_RReplaceSelf_String == null)
				{
					r_RReplaceSelf_String = new(this, "ReplaceSelf", 0, typeof(System.String));
					r_RReplaceSelf_String.SetBelong(this.instance);
				}
				return r_RReplaceSelf_String;
			}
		}

		/// <summary>
		/// Void ReplaceSelf(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RReplaceSelf_XmlReader;
		public virtual RMethod RReplaceSelf_XmlReader
		{
			get
			{
				if(r_RReplaceSelf_XmlReader == null)
				{
					r_RReplaceSelf_XmlReader = new(this, "ReplaceSelf", 0, typeof(System.Xml.XmlReader));
					r_RReplaceSelf_XmlReader.SetBelong(this.instance);
				}
				return r_RReplaceSelf_XmlReader;
			}
		}

		/// <summary>
		/// Void ReplaceSelf(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RReplaceSelf_XPathNavigator;
		public virtual RMethod RReplaceSelf_XPathNavigator
		{
			get
			{
				if(r_RReplaceSelf_XPathNavigator == null)
				{
					r_RReplaceSelf_XPathNavigator = new(this, "ReplaceSelf", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RReplaceSelf_XPathNavigator.SetBelong(this.instance);
				}
				return r_RReplaceSelf_XPathNavigator;
			}
		}

		/// <summary>
		/// Void AppendChild(System.String)
		/// </summary>
		protected RMethod r_RAppendChild_String;
		public virtual RMethod RAppendChild_String
		{
			get
			{
				if(r_RAppendChild_String == null)
				{
					r_RAppendChild_String = new(this, "AppendChild", 0, typeof(System.String));
					r_RAppendChild_String.SetBelong(this.instance);
				}
				return r_RAppendChild_String;
			}
		}

		/// <summary>
		/// Void AppendChild(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RAppendChild_XmlReader;
		public virtual RMethod RAppendChild_XmlReader
		{
			get
			{
				if(r_RAppendChild_XmlReader == null)
				{
					r_RAppendChild_XmlReader = new(this, "AppendChild", 0, typeof(System.Xml.XmlReader));
					r_RAppendChild_XmlReader.SetBelong(this.instance);
				}
				return r_RAppendChild_XmlReader;
			}
		}

		/// <summary>
		/// Void AppendChild(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RAppendChild_XPathNavigator;
		public virtual RMethod RAppendChild_XPathNavigator
		{
			get
			{
				if(r_RAppendChild_XPathNavigator == null)
				{
					r_RAppendChild_XPathNavigator = new(this, "AppendChild", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RAppendChild_XPathNavigator.SetBelong(this.instance);
				}
				return r_RAppendChild_XPathNavigator;
			}
		}

		/// <summary>
		/// Void PrependChild(System.String)
		/// </summary>
		protected RMethod r_RPrependChild_String;
		public virtual RMethod RPrependChild_String
		{
			get
			{
				if(r_RPrependChild_String == null)
				{
					r_RPrependChild_String = new(this, "PrependChild", 0, typeof(System.String));
					r_RPrependChild_String.SetBelong(this.instance);
				}
				return r_RPrependChild_String;
			}
		}

		/// <summary>
		/// Void PrependChild(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RPrependChild_XmlReader;
		public virtual RMethod RPrependChild_XmlReader
		{
			get
			{
				if(r_RPrependChild_XmlReader == null)
				{
					r_RPrependChild_XmlReader = new(this, "PrependChild", 0, typeof(System.Xml.XmlReader));
					r_RPrependChild_XmlReader.SetBelong(this.instance);
				}
				return r_RPrependChild_XmlReader;
			}
		}

		/// <summary>
		/// Void PrependChild(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RPrependChild_XPathNavigator;
		public virtual RMethod RPrependChild_XPathNavigator
		{
			get
			{
				if(r_RPrependChild_XPathNavigator == null)
				{
					r_RPrependChild_XPathNavigator = new(this, "PrependChild", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RPrependChild_XPathNavigator.SetBelong(this.instance);
				}
				return r_RPrependChild_XPathNavigator;
			}
		}

		/// <summary>
		/// Void InsertBefore(System.String)
		/// </summary>
		protected RMethod r_RInsertBefore_String;
		public virtual RMethod RInsertBefore_String
		{
			get
			{
				if(r_RInsertBefore_String == null)
				{
					r_RInsertBefore_String = new(this, "InsertBefore", 0, typeof(System.String));
					r_RInsertBefore_String.SetBelong(this.instance);
				}
				return r_RInsertBefore_String;
			}
		}

		/// <summary>
		/// Void InsertBefore(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RInsertBefore_XmlReader;
		public virtual RMethod RInsertBefore_XmlReader
		{
			get
			{
				if(r_RInsertBefore_XmlReader == null)
				{
					r_RInsertBefore_XmlReader = new(this, "InsertBefore", 0, typeof(System.Xml.XmlReader));
					r_RInsertBefore_XmlReader.SetBelong(this.instance);
				}
				return r_RInsertBefore_XmlReader;
			}
		}

		/// <summary>
		/// Void InsertBefore(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RInsertBefore_XPathNavigator;
		public virtual RMethod RInsertBefore_XPathNavigator
		{
			get
			{
				if(r_RInsertBefore_XPathNavigator == null)
				{
					r_RInsertBefore_XPathNavigator = new(this, "InsertBefore", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RInsertBefore_XPathNavigator.SetBelong(this.instance);
				}
				return r_RInsertBefore_XPathNavigator;
			}
		}

		/// <summary>
		/// Void InsertAfter(System.String)
		/// </summary>
		protected RMethod r_RInsertAfter_String;
		public virtual RMethod RInsertAfter_String
		{
			get
			{
				if(r_RInsertAfter_String == null)
				{
					r_RInsertAfter_String = new(this, "InsertAfter", 0, typeof(System.String));
					r_RInsertAfter_String.SetBelong(this.instance);
				}
				return r_RInsertAfter_String;
			}
		}

		/// <summary>
		/// Void InsertAfter(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RInsertAfter_XmlReader;
		public virtual RMethod RInsertAfter_XmlReader
		{
			get
			{
				if(r_RInsertAfter_XmlReader == null)
				{
					r_RInsertAfter_XmlReader = new(this, "InsertAfter", 0, typeof(System.Xml.XmlReader));
					r_RInsertAfter_XmlReader.SetBelong(this.instance);
				}
				return r_RInsertAfter_XmlReader;
			}
		}

		/// <summary>
		/// Void InsertAfter(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RInsertAfter_XPathNavigator;
		public virtual RMethod RInsertAfter_XPathNavigator
		{
			get
			{
				if(r_RInsertAfter_XPathNavigator == null)
				{
					r_RInsertAfter_XPathNavigator = new(this, "InsertAfter", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RInsertAfter_XPathNavigator.SetBelong(this.instance);
				}
				return r_RInsertAfter_XPathNavigator;
			}
		}

		/// <summary>
		/// Void DeleteRange(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RDeleteRange_XPathNavigator;
		public virtual RMethod RDeleteRange_XPathNavigator
		{
			get
			{
				if(r_RDeleteRange_XPathNavigator == null)
				{
					r_RDeleteRange_XPathNavigator = new(this, "DeleteRange", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RDeleteRange_XPathNavigator.SetBelong(this.instance);
				}
				return r_RDeleteRange_XPathNavigator;
			}
		}

		/// <summary>
		/// Void DeleteSelf()
		/// </summary>
		protected RMethod r_RDeleteSelf;
		public virtual RMethod RDeleteSelf
		{
			get
			{
				if(r_RDeleteSelf == null)
				{
					r_RDeleteSelf = new(this, "DeleteSelf", 0);
					r_RDeleteSelf.SetBelong(this.instance);
				}
				return r_RDeleteSelf;
			}
		}

		/// <summary>
		/// Void PrependChildElement(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RPrependChildElement_String_String_String_String;
		public virtual RMethod RPrependChildElement_String_String_String_String
		{
			get
			{
				if(r_RPrependChildElement_String_String_String_String == null)
				{
					r_RPrependChildElement_String_String_String_String = new(this, "PrependChildElement", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RPrependChildElement_String_String_String_String.SetBelong(this.instance);
				}
				return r_RPrependChildElement_String_String_String_String;
			}
		}

		/// <summary>
		/// Void AppendChildElement(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RAppendChildElement_String_String_String_String;
		public virtual RMethod RAppendChildElement_String_String_String_String
		{
			get
			{
				if(r_RAppendChildElement_String_String_String_String == null)
				{
					r_RAppendChildElement_String_String_String_String = new(this, "AppendChildElement", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RAppendChildElement_String_String_String_String.SetBelong(this.instance);
				}
				return r_RAppendChildElement_String_String_String_String;
			}
		}

		/// <summary>
		/// Void InsertElementBefore(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RInsertElementBefore_String_String_String_String;
		public virtual RMethod RInsertElementBefore_String_String_String_String
		{
			get
			{
				if(r_RInsertElementBefore_String_String_String_String == null)
				{
					r_RInsertElementBefore_String_String_String_String = new(this, "InsertElementBefore", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RInsertElementBefore_String_String_String_String.SetBelong(this.instance);
				}
				return r_RInsertElementBefore_String_String_String_String;
			}
		}

		/// <summary>
		/// Void InsertElementAfter(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RInsertElementAfter_String_String_String_String;
		public virtual RMethod RInsertElementAfter_String_String_String_String
		{
			get
			{
				if(r_RInsertElementAfter_String_String_String_String == null)
				{
					r_RInsertElementAfter_String_String_String_String = new(this, "InsertElementAfter", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RInsertElementAfter_String_String_String_String.SetBelong(this.instance);
				}
				return r_RInsertElementAfter_String_String_String_String;
			}
		}

		/// <summary>
		/// Void CreateAttribute(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateAttribute_String_String_String_String;
		public virtual RMethod RCreateAttribute_String_String_String_String
		{
			get
			{
				if(r_RCreateAttribute_String_String_String_String == null)
				{
					r_RCreateAttribute_String_String_String_String = new(this, "CreateAttribute", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RCreateAttribute_String_String_String_String.SetBelong(this.instance);
				}
				return r_RCreateAttribute_String_String_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToPrevious(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToPrevious_String_String;
		public virtual RMethod RMoveToPrevious_String_String
		{
			get
			{
				if(r_RMoveToPrevious_String_String == null)
				{
					r_RMoveToPrevious_String_String = new(this, "MoveToPrevious", 0, typeof(System.String), typeof(System.String));
					r_RMoveToPrevious_String_String.SetBelong(this.instance);
				}
				return r_RMoveToPrevious_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToPrevious(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RMoveToPrevious_XPathNodeType;
		public virtual RMethod RMoveToPrevious_XPathNodeType
		{
			get
			{
				if(r_RMoveToPrevious_XPathNodeType == null)
				{
					r_RMoveToPrevious_XPathNodeType = new(this, "MoveToPrevious", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RMoveToPrevious_XPathNodeType.SetBelong(this.instance);
				}
				return r_RMoveToPrevious_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean MoveToNonDescendant()
		/// </summary>
		protected RMethod r_RMoveToNonDescendant;
		public virtual RMethod RMoveToNonDescendant
		{
			get
			{
				if(r_RMoveToNonDescendant == null)
				{
					r_RMoveToNonDescendant = new(this, "MoveToNonDescendant", 0);
					r_RMoveToNonDescendant.SetBelong(this.instance);
				}
				return r_RMoveToNonDescendant;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathExpression CompileMatchPattern(System.String)
		/// </summary>
		protected static RMethod r_RCompileMatchPattern_String;
		public static RMethod RCompileMatchPattern_String
		{
			get
			{
				if(r_RCompileMatchPattern_String == null)
				{
					r_RCompileMatchPattern_String = new(typeof(System.Xml.XPath.XPathNavigator), "CompileMatchPattern", 0, typeof(System.String));
					r_RCompileMatchPattern_String.SetBelong(null);
				}
				return r_RCompileMatchPattern_String;
			}
		}

		/// <summary>
		/// Int32 GetDepth(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected static RMethod r_RGetDepth_XPathNavigator;
		public static RMethod RGetDepth_XPathNavigator
		{
			get
			{
				if(r_RGetDepth_XPathNavigator == null)
				{
					r_RGetDepth_XPathNavigator = new(typeof(System.Xml.XPath.XPathNavigator), "GetDepth", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RGetDepth_XPathNavigator.SetBelong(null);
				}
				return r_RGetDepth_XPathNavigator;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeOrder CompareSiblings(System.Xml.XPath.XPathNavigator, System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RCompareSiblings_XPathNavigator_XPathNavigator;
		public virtual RMethod RCompareSiblings_XPathNavigator_XPathNavigator
		{
			get
			{
				if(r_RCompareSiblings_XPathNavigator_XPathNavigator == null)
				{
					r_RCompareSiblings_XPathNavigator_XPathNavigator = new(this, "CompareSiblings", 0, typeof(System.Xml.XPath.XPathNavigator), typeof(System.Xml.XPath.XPathNavigator));
					r_RCompareSiblings_XPathNavigator_XPathNavigator.SetBelong(this.instance);
				}
				return r_RCompareSiblings_XPathNavigator_XPathNavigator;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager GetNamespaces(System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected static RMethod r_RGetNamespaces_IXmlNamespaceResolver;
		public static RMethod RGetNamespaces_IXmlNamespaceResolver
		{
			get
			{
				if(r_RGetNamespaces_IXmlNamespaceResolver == null)
				{
					r_RGetNamespaces_IXmlNamespaceResolver = new(typeof(System.Xml.XPath.XPathNavigator), "GetNamespaces", 0, typeof(System.Xml.IXmlNamespaceResolver));
					r_RGetNamespaces_IXmlNamespaceResolver.SetBelong(null);
				}
				return r_RGetNamespaces_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// Int32 GetContentKindMask(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected static RMethod r_RGetContentKindMask_XPathNodeType;
		public static RMethod RGetContentKindMask_XPathNodeType
		{
			get
			{
				if(r_RGetContentKindMask_XPathNodeType == null)
				{
					r_RGetContentKindMask_XPathNodeType = new(typeof(System.Xml.XPath.XPathNavigator), "GetContentKindMask", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RGetContentKindMask_XPathNodeType.SetBelong(null);
				}
				return r_RGetContentKindMask_XPathNodeType;
			}
		}

		/// <summary>
		/// Int32 GetKindMask(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected static RMethod r_RGetKindMask_XPathNodeType;
		public static RMethod RGetKindMask_XPathNodeType
		{
			get
			{
				if(r_RGetKindMask_XPathNodeType == null)
				{
					r_RGetKindMask_XPathNodeType = new(typeof(System.Xml.XPath.XPathNavigator), "GetKindMask", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RGetKindMask_XPathNodeType.SetBelong(null);
				}
				return r_RGetKindMask_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean IsText(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected static RMethod r_RIsText_XPathNodeType;
		public static RMethod RIsText_XPathNodeType
		{
			get
			{
				if(r_RIsText_XPathNodeType == null)
				{
					r_RIsText_XPathNodeType = new(typeof(System.Xml.XPath.XPathNavigator), "IsText", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RIsText_XPathNodeType.SetBelong(null);
				}
				return r_RIsText_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean IsValidChildType(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RIsValidChildType_XPathNodeType;
		public virtual RMethod RIsValidChildType_XPathNodeType
		{
			get
			{
				if(r_RIsValidChildType_XPathNodeType == null)
				{
					r_RIsValidChildType_XPathNodeType = new(this, "IsValidChildType", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RIsValidChildType_XPathNodeType.SetBelong(this.instance);
				}
				return r_RIsValidChildType_XPathNodeType;
			}
		}

		/// <summary>
		/// Boolean IsValidSiblingType(System.Xml.XPath.XPathNodeType)
		/// </summary>
		protected RMethod r_RIsValidSiblingType_XPathNodeType;
		public virtual RMethod RIsValidSiblingType_XPathNodeType
		{
			get
			{
				if(r_RIsValidSiblingType_XPathNodeType == null)
				{
					r_RIsValidSiblingType_XPathNodeType = new(this, "IsValidSiblingType", 0, typeof(System.Xml.XPath.XPathNodeType));
					r_RIsValidSiblingType_XPathNodeType.SetBelong(this.instance);
				}
				return r_RIsValidSiblingType_XPathNodeType;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateReader()
		/// </summary>
		protected RMethod r_RCreateReader;
		public virtual RMethod RCreateReader
		{
			get
			{
				if(r_RCreateReader == null)
				{
					r_RCreateReader = new(this, "CreateReader", 0);
					r_RCreateReader.SetBelong(this.instance);
				}
				return r_RCreateReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateContextReader(System.String, Boolean)
		/// </summary>
		protected RMethod r_RCreateContextReader_String_Boolean;
		public virtual RMethod RCreateContextReader_String_Boolean
		{
			get
			{
				if(r_RCreateContextReader_String_Boolean == null)
				{
					r_RCreateContextReader_String_Boolean = new(this, "CreateContextReader", 0, typeof(System.String), typeof(System.Boolean));
					r_RCreateContextReader_String_Boolean.SetBelong(this.instance);
				}
				return r_RCreateContextReader_String_Boolean;
			}
		}

		/// <summary>
		/// Void BuildSubtree(System.Xml.XmlReader, System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RBuildSubtree_XmlReader_XmlWriter;
		public virtual RMethod RBuildSubtree_XmlReader_XmlWriter
		{
			get
			{
				if(r_RBuildSubtree_XmlReader_XmlWriter == null)
				{
					r_RBuildSubtree_XmlReader_XmlWriter = new(this, "BuildSubtree", 0, typeof(System.Xml.XmlReader), typeof(System.Xml.XmlWriter));
					r_RBuildSubtree_XmlReader_XmlWriter.SetBelong(this.instance);
				}
				return r_RBuildSubtree_XmlReader_XmlWriter;
			}
		}

		/// <summary>
		/// System.Object ValueAs(System.Type)
		/// </summary>
		protected RMethod r_RValueAs_Type;
		public virtual RMethod RValueAs_Type
		{
			get
			{
				if(r_RValueAs_Type == null)
				{
					r_RValueAs_Type = new(this, "ValueAs", 0, typeof(System.Type));
					r_RValueAs_Type.SetBelong(this.instance);
				}
				return r_RValueAs_Type;
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


        public RXPathNavigator() : base("System.Xml.XPath.XPathNavigator")
        {
        }

        public RXPathNavigator(System.Object instance) : base("System.Xml.XPath.XPathNavigator")
		{
            SetInstance(instance);
		}

        public RXPathNavigator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXPathNavigator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTypedValue(System.Object  @typedValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typedValue};
            var ___result = RSetTypedValue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ValueAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @nsResolver};
            var ___result = RValueAs_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__1__ICloneable__1__Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__ICloneable__1__Clone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator CreateNavigator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.String LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RLookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String LookupPrefix(System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceURI};
            var ___result = RLookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RGetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.Xml.XmlReader ReadSubtree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadSubtree.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void WriteSubtree(System.Xml.XmlWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer};
            var ___result = RWriteSubtree_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String GetNamespace(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean MoveToNamespace(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMoveToNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope  @namespaceScope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceScope};
            var ___result = RMoveToFirstNamespace_XPathNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope  @namespaceScope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceScope};
            var ___result = RMoveToNextNamespace_XPathNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFirstNamespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToFirstNamespace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNextNamespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNextNamespace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToPrevious()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToPrevious.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToFirst.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFirstChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToFirstChild.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToParent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MoveToRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToRoot.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveTo(System.Xml.XPath.XPathNavigator  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMoveTo_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToId(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMoveToId_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToChild(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToChild_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMoveToChild_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFollowing(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToFollowing_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFollowing(System.String  @localName, System.String  @namespaceURI, System.Xml.XPath.XPathNavigator  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI, @end};
            var ___result = RMoveToFollowing_String_String_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMoveToFollowing_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType  @type, System.Xml.XPath.XPathNavigator  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @end};
            var ___result = RMoveToFollowing_XPathNodeType_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNext(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToNext_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMoveToNext_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSamePosition_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator  @nav)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nav};
            var ___result = RIsDescendant_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator  @nav)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nav};
            var ___result = RComparePosition_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeOrder)___result;
        }


        public virtual System.Boolean CheckValidity(System.Xml.Schema.XmlSchemaSet  @schemas, System.Xml.Schema.ValidationEventHandler  @validationEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemas, @validationEventHandler};
            var ___result = RCheckValidity_XmlSchemaSet_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlReader GetValidatingReader(System.Xml.XmlReader  @reader, System.Xml.Schema.XmlSchemaSet  @schemas, System.Xml.Schema.ValidationEventHandler  @validationEvent, System.Xml.Schema.XmlSchemaType  @schemaType, System.Xml.Schema.XmlSchemaElement  @schemaElement, System.Xml.Schema.XmlSchemaAttribute  @schemaAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @schemas, @validationEvent, @schemaType, @schemaElement, @schemaAttribute};
            var ___result = RGetValidatingReader_XmlReader_XmlSchemaSet_ValidationEventHandler_XmlSchemaType_XmlSchemaElement_XmlSchemaAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XPath.XPathExpression Compile(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RCompile_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathExpression)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RSelectSingleNode_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(System.String  @xpath, System.Xml.IXmlNamespaceResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @resolver};
            var ___result = RSelectSingleNode_String_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(System.Xml.XPath.XPathExpression  @expression)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expression};
            var ___result = RSelectSingleNode_XPathExpression.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNavigator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator Select(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RSelect_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator Select(System.String  @xpath, System.Xml.IXmlNamespaceResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @resolver};
            var ___result = RSelect_String_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression  @expr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr};
            var ___result = RSelect_XPathExpression.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Object Evaluate(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = REvaluate_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Evaluate(System.String  @xpath, System.Xml.IXmlNamespaceResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @resolver};
            var ___result = REvaluate_String_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Evaluate(System.Xml.XPath.XPathExpression  @expr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr};
            var ___result = REvaluate_XPathExpression.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Evaluate(System.Xml.XPath.XPathExpression  @expr, System.Xml.XPath.XPathNodeIterator  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr, @context};
            var ___result = REvaluate_XPathExpression_XPathNodeIterator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Matches(System.Xml.XPath.XPathExpression  @expr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr};
            var ___result = RMatches_XPathExpression.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Matches(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RMatches_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RSelectChildren_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(System.String  @name, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @namespaceURI};
            var ___result = RSelectChildren_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(System.Xml.XPath.XPathNodeType  @type, System.Boolean  @matchSelf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @matchSelf};
            var ___result = RSelectAncestors_XPathNodeType_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(System.String  @name, System.String  @namespaceURI, System.Boolean  @matchSelf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @namespaceURI, @matchSelf};
            var ___result = RSelectAncestors_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType  @type, System.Boolean  @matchSelf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @matchSelf};
            var ___result = RSelectDescendants_XPathNodeType_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String  @name, System.String  @namespaceURI, System.Boolean  @matchSelf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @namespaceURI, @matchSelf};
            var ___result = RSelectDescendants_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathNodeIterator)___result;
        }


        public virtual System.Xml.XmlWriter PrependChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrependChild.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter AppendChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAppendChild.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter InsertAfter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInsertAfter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter InsertBefore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInsertBefore.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter CreateAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateAttributes.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter ReplaceRange(System.Xml.XPath.XPathNavigator  @lastSiblingToReplace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lastSiblingToReplace};
            var ___result = RReplaceRange_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual void ReplaceSelf(System.String  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RReplaceSelf_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplaceSelf(System.Xml.XmlReader  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RReplaceSelf_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplaceSelf(System.Xml.XPath.XPathNavigator  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RReplaceSelf_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendChild(System.String  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RAppendChild_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendChild(System.Xml.XmlReader  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RAppendChild_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendChild(System.Xml.XPath.XPathNavigator  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RAppendChild_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrependChild(System.String  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RPrependChild_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrependChild(System.Xml.XmlReader  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RPrependChild_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrependChild(System.Xml.XPath.XPathNavigator  @newChild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newChild};
            var ___result = RPrependChild_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertBefore(System.String  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertBefore_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertBefore(System.Xml.XmlReader  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertBefore_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertBefore(System.Xml.XPath.XPathNavigator  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertBefore_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAfter(System.String  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertAfter_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAfter(System.Xml.XmlReader  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertAfter_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAfter(System.Xml.XPath.XPathNavigator  @newSibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSibling};
            var ___result = RInsertAfter_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteRange(System.Xml.XPath.XPathNavigator  @lastSiblingToDelete)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lastSiblingToDelete};
            var ___result = RDeleteRange_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteSelf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteSelf.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrependChildElement(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @value};
            var ___result = RPrependChildElement_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendChildElement(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @value};
            var ___result = RAppendChildElement_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertElementBefore(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @value};
            var ___result = RInsertElementBefore_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertElementAfter(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @value};
            var ___result = RInsertElementAfter_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateAttribute(System.String  @prefix, System.String  @localName, System.String  @namespaceURI, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @namespaceURI, @value};
            var ___result = RCreateAttribute_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveToPrevious(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToPrevious_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToPrevious(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMoveToPrevious_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNonDescendant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNonDescendant.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Xml.XPath.XPathExpression CompileMatchPattern(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RCompileMatchPattern_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathExpression)___result;
        }


        public static System.Int32 GetDepth(System.Xml.XPath.XPathNavigator  @nav)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nav};
            var ___result = RGetDepth_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Xml.XmlNodeOrder CompareSiblings(System.Xml.XPath.XPathNavigator  @n1, System.Xml.XPath.XPathNavigator  @n2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n1, @n2};
            var ___result = RCompareSiblings_XPathNavigator_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeOrder)___result;
        }


        public static System.Xml.XmlNamespaceManager GetNamespaces(System.Xml.IXmlNamespaceResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resolver};
            var ___result = RGetNamespaces_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNamespaceManager)___result;
        }


        public static System.Int32 GetContentKindMask(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetContentKindMask_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetKindMask(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetKindMask_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsText(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsText_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidChildType(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsValidChildType_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidSiblingType(System.Xml.XPath.XPathNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsValidSiblingType_XPathNodeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Xml.XmlReader CreateReader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XmlReader CreateContextReader(System.String  @xml, System.Boolean  @fromCurrentNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml, @fromCurrentNode};
            var ___result = RCreateContextReader_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void BuildSubtree(System.Xml.XmlReader  @reader, System.Xml.XmlWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @writer};
            var ___result = RBuildSubtree_XmlReader_XmlWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ValueAs(System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType};
            var ___result = RValueAs_Type.Invoke(___genericsType, ___parameters);

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


    }
}
