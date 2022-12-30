using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlTextReaderImpl+NodeData
	/// </summary>
    public partial class RNodeData : RMember //
    {

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+NodeData s_None
		/// </summary>
		protected static RSystem.RXml.RXmlTextReaderImpl.RNodeData r_s_None;
		public static RSystem.RXml.RXmlTextReaderImpl.RNodeData Rs_None
		{
			get
			{
				if(r_s_None == null)
				{
					r_s_None = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"), "s_None");
					r_s_None.SetBelong(null);
				}
				return r_s_None;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
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
		/// System.String localName
		/// </summary>
		protected RField r_localName;
		public virtual RField RlocalName
		{
			get
			{
				if(r_localName == null)
				{
					r_localName = new(this, "localName");
					r_localName.SetBelong(this.instance);
				}
				return r_localName;
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
		/// System.String ns
		/// </summary>
		protected RField r_ns;
		public virtual RField Rns
		{
			get
			{
				if(r_ns == null)
				{
					r_ns = new(this, "ns");
					r_ns.SetBelong(this.instance);
				}
				return r_ns;
			}
		}

		/// <summary>
		/// System.String nameWPrefix
		/// </summary>
		protected RField r_nameWPrefix;
		public virtual RField RnameWPrefix
		{
			get
			{
				if(r_nameWPrefix == null)
				{
					r_nameWPrefix = new(this, "nameWPrefix");
					r_nameWPrefix.SetBelong(this.instance);
				}
				return r_nameWPrefix;
			}
		}

		/// <summary>
		/// System.String value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// System.Char[] chars
		/// </summary>
		protected RFieldArray<RField> r_chars;
		public virtual RFieldArray<RField> Rchars
		{
			get
			{
				if(r_chars == null)
				{
					r_chars = new(this, "chars");
					r_chars.SetBelong(this.instance);
				}
				return r_chars;
			}
		}

		/// <summary>
		/// System.Int32 valueStartPos
		/// </summary>
		protected RField r_valueStartPos;
		public virtual RField RvalueStartPos
		{
			get
			{
				if(r_valueStartPos == null)
				{
					r_valueStartPos = new(this, "valueStartPos");
					r_valueStartPos.SetBelong(this.instance);
				}
				return r_valueStartPos;
			}
		}

		/// <summary>
		/// System.Int32 valueLength
		/// </summary>
		protected RField r_valueLength;
		public virtual RField RvalueLength
		{
			get
			{
				if(r_valueLength == null)
				{
					r_valueLength = new(this, "valueLength");
					r_valueLength.SetBelong(this.instance);
				}
				return r_valueLength;
			}
		}

		/// <summary>
		/// System.Xml.LineInfo lineInfo
		/// </summary>
		protected RSystem.RXml.RLineInfo r_lineInfo;
		public virtual RSystem.RXml.RLineInfo RlineInfo
		{
			get
			{
				if(r_lineInfo == null)
				{
					r_lineInfo = new(this, "lineInfo");
					r_lineInfo.SetBelong(this.instance);
				}
				return r_lineInfo;
			}
		}

		/// <summary>
		/// System.Xml.LineInfo lineInfo2
		/// </summary>
		protected RSystem.RXml.RLineInfo r_lineInfo2;
		public virtual RSystem.RXml.RLineInfo RlineInfo2
		{
			get
			{
				if(r_lineInfo2 == null)
				{
					r_lineInfo2 = new(this, "lineInfo2");
					r_lineInfo2.SetBelong(this.instance);
				}
				return r_lineInfo2;
			}
		}

		/// <summary>
		/// System.Char quoteChar
		/// </summary>
		protected RField r_quoteChar;
		public virtual RField RquoteChar
		{
			get
			{
				if(r_quoteChar == null)
				{
					r_quoteChar = new(this, "quoteChar");
					r_quoteChar.SetBelong(this.instance);
				}
				return r_quoteChar;
			}
		}

		/// <summary>
		/// System.Int32 depth
		/// </summary>
		protected RField r_depth;
		public virtual RField Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth");
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// System.Boolean isEmptyOrDefault
		/// </summary>
		protected RField r_isEmptyOrDefault;
		public virtual RField RisEmptyOrDefault
		{
			get
			{
				if(r_isEmptyOrDefault == null)
				{
					r_isEmptyOrDefault = new(this, "isEmptyOrDefault");
					r_isEmptyOrDefault.SetBelong(this.instance);
				}
				return r_isEmptyOrDefault;
			}
		}

		/// <summary>
		/// System.Int32 entityId
		/// </summary>
		protected RField r_entityId;
		public virtual RField RentityId
		{
			get
			{
				if(r_entityId == null)
				{
					r_entityId = new(this, "entityId");
					r_entityId.SetBelong(this.instance);
				}
				return r_entityId;
			}
		}

		/// <summary>
		/// System.Boolean xmlContextPushed
		/// </summary>
		protected RField r_xmlContextPushed;
		public virtual RField RxmlContextPushed
		{
			get
			{
				if(r_xmlContextPushed == null)
				{
					r_xmlContextPushed = new(this, "xmlContextPushed");
					r_xmlContextPushed.SetBelong(this.instance);
				}
				return r_xmlContextPushed;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+NodeData nextAttrValueChunk
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RNodeData r_nextAttrValueChunk;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RNodeData RnextAttrValueChunk
		{
			get
			{
				if(r_nextAttrValueChunk == null)
				{
					r_nextAttrValueChunk = new(this, "nextAttrValueChunk");
					r_nextAttrValueChunk.SetBelong(this.instance);
				}
				return r_nextAttrValueChunk;
			}
		}

		/// <summary>
		/// System.Object schemaType
		/// </summary>
		protected RSystem.RObject r_schemaType;
		public virtual RSystem.RObject RschemaType
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
		/// System.Object typedValue
		/// </summary>
		protected RSystem.RObject r_typedValue;
		public virtual RSystem.RObject RtypedValue
		{
			get
			{
				if(r_typedValue == null)
				{
					r_typedValue = new(this, "typedValue");
					r_typedValue.SetBelong(this.instance);
				}
				return r_typedValue;
			}
		}

		/// <summary>
		/// NodeData None
		/// </summary>
		protected static RSystem.RXml.RXmlTextReaderImpl.RNodeData r_None;
		public static RSystem.RXml.RXmlTextReaderImpl.RNodeData RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"), "None", -1);
					r_None.SetBelong(null);
				}
				return r_None;
			}
		}

		/// <summary>
		/// Int32 LineNo
		/// </summary>
		protected RProperty r_LineNo;
		public virtual RProperty RLineNo
		{
			get
			{
				if(r_LineNo == null)
				{
					r_LineNo = new(this, "LineNo", -1);
					r_LineNo.SetBelong(this.instance);
				}
				return r_LineNo;
			}
		}

		/// <summary>
		/// Int32 LinePos
		/// </summary>
		protected RProperty r_LinePos;
		public virtual RProperty RLinePos
		{
			get
			{
				if(r_LinePos == null)
				{
					r_LinePos = new(this, "LinePos", -1);
					r_LinePos.SetBelong(this.instance);
				}
				return r_LinePos;
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
		/// Boolean IsDefaultAttribute
		/// </summary>
		protected RProperty r_IsDefaultAttribute;
		public virtual RProperty RIsDefaultAttribute
		{
			get
			{
				if(r_IsDefaultAttribute == null)
				{
					r_IsDefaultAttribute = new(this, "IsDefaultAttribute", -1);
					r_IsDefaultAttribute.SetBelong(this.instance);
				}
				return r_IsDefaultAttribute;
			}
		}

		/// <summary>
		/// Boolean ValueBuffered
		/// </summary>
		protected RProperty r_ValueBuffered;
		public virtual RProperty RValueBuffered
		{
			get
			{
				if(r_ValueBuffered == null)
				{
					r_ValueBuffered = new(this, "ValueBuffered", -1);
					r_ValueBuffered.SetBelong(this.instance);
				}
				return r_ValueBuffered;
			}
		}

		/// <summary>
		/// System.String StringValue
		/// </summary>
		protected RProperty r_StringValue;
		public virtual RProperty RStringValue
		{
			get
			{
				if(r_StringValue == null)
				{
					r_StringValue = new(this, "StringValue", -1);
					r_StringValue.SetBelong(this.instance);
				}
				return r_StringValue;
			}
		}

		/// <summary>
		/// Void TrimSpacesInValue()
		/// </summary>
		protected RMethod r_RTrimSpacesInValue;
		public virtual RMethod RTrimSpacesInValue
		{
			get
			{
				if(r_RTrimSpacesInValue == null)
				{
					r_RTrimSpacesInValue = new(this, "TrimSpacesInValue", 0);
					r_RTrimSpacesInValue.SetBelong(this.instance);
				}
				return r_RTrimSpacesInValue;
			}
		}

		/// <summary>
		/// Void Clear(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RClear_XmlNodeType;
		public virtual RMethod RClear_XmlNodeType
		{
			get
			{
				if(r_RClear_XmlNodeType == null)
				{
					r_RClear_XmlNodeType = new(this, "Clear", 0, typeof(System.Xml.XmlNodeType));
					r_RClear_XmlNodeType.SetBelong(this.instance);
				}
				return r_RClear_XmlNodeType;
			}
		}

		/// <summary>
		/// Void ClearName()
		/// </summary>
		protected RMethod r_RClearName;
		public virtual RMethod RClearName
		{
			get
			{
				if(r_RClearName == null)
				{
					r_RClearName = new(this, "ClearName", 0);
					r_RClearName.SetBelong(this.instance);
				}
				return r_RClearName;
			}
		}

		/// <summary>
		/// Void SetLineInfo(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetLineInfo_Int32_Int32;
		public virtual RMethod RSetLineInfo_Int32_Int32
		{
			get
			{
				if(r_RSetLineInfo_Int32_Int32 == null)
				{
					r_RSetLineInfo_Int32_Int32 = new(this, "SetLineInfo", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetLineInfo_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetLineInfo_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetLineInfo2(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetLineInfo2_Int32_Int32;
		public virtual RMethod RSetLineInfo2_Int32_Int32
		{
			get
			{
				if(r_RSetLineInfo2_Int32_Int32 == null)
				{
					r_RSetLineInfo2_Int32_Int32 = new(this, "SetLineInfo2", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetLineInfo2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetLineInfo2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValueNode(System.Xml.XmlNodeType, System.String)
		/// </summary>
		protected RMethod r_RSetValueNode_XmlNodeType_String;
		public virtual RMethod RSetValueNode_XmlNodeType_String
		{
			get
			{
				if(r_RSetValueNode_XmlNodeType_String == null)
				{
					r_RSetValueNode_XmlNodeType_String = new(this, "SetValueNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.String));
					r_RSetValueNode_XmlNodeType_String.SetBelong(this.instance);
				}
				return r_RSetValueNode_XmlNodeType_String;
			}
		}

		/// <summary>
		/// Void SetValueNode(System.Xml.XmlNodeType, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetValueNode_XmlNodeType_CharArray_Int32_Int32;
		public virtual RMethod RSetValueNode_XmlNodeType_CharArray_Int32_Int32
		{
			get
			{
				if(r_RSetValueNode_XmlNodeType_CharArray_Int32_Int32 == null)
				{
					r_RSetValueNode_XmlNodeType_CharArray_Int32_Int32 = new(this, "SetValueNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetValueNode_XmlNodeType_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetValueNode_XmlNodeType_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNamedNode(System.Xml.XmlNodeType, System.String)
		/// </summary>
		protected RMethod r_RSetNamedNode_XmlNodeType_String;
		public virtual RMethod RSetNamedNode_XmlNodeType_String
		{
			get
			{
				if(r_RSetNamedNode_XmlNodeType_String == null)
				{
					r_RSetNamedNode_XmlNodeType_String = new(this, "SetNamedNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.String));
					r_RSetNamedNode_XmlNodeType_String.SetBelong(this.instance);
				}
				return r_RSetNamedNode_XmlNodeType_String;
			}
		}

		/// <summary>
		/// Void SetNamedNode(System.Xml.XmlNodeType, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RSetNamedNode_XmlNodeType_String_String_String;
		public virtual RMethod RSetNamedNode_XmlNodeType_String_String_String
		{
			get
			{
				if(r_RSetNamedNode_XmlNodeType_String_String_String == null)
				{
					r_RSetNamedNode_XmlNodeType_String_String_String = new(this, "SetNamedNode", 0, typeof(System.Xml.XmlNodeType), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RSetNamedNode_XmlNodeType_String_String_String.SetBelong(this.instance);
				}
				return r_RSetNamedNode_XmlNodeType_String_String_String;
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
		/// Void SetValue(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetValue_CharArray_Int32_Int32;
		public virtual RMethod RSetValue_CharArray_Int32_Int32
		{
			get
			{
				if(r_RSetValue_CharArray_Int32_Int32 == null)
				{
					r_RSetValue_CharArray_Int32_Int32 = new(this, "SetValue", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetValue_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetValue_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void OnBufferInvalidated()
		/// </summary>
		protected RMethod r_ROnBufferInvalidated;
		public virtual RMethod ROnBufferInvalidated
		{
			get
			{
				if(r_ROnBufferInvalidated == null)
				{
					r_ROnBufferInvalidated = new(this, "OnBufferInvalidated", 0);
					r_ROnBufferInvalidated.SetBelong(this.instance);
				}
				return r_ROnBufferInvalidated;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RCopyTo_Int32_StringBuilder;
		public virtual RMethod RCopyTo_Int32_StringBuilder
		{
			get
			{
				if(r_RCopyTo_Int32_StringBuilder == null)
				{
					r_RCopyTo_Int32_StringBuilder = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Text.StringBuilder));
					r_RCopyTo_Int32_StringBuilder.SetBelong(this.instance);
				}
				return r_RCopyTo_Int32_StringBuilder;
			}
		}

		/// <summary>
		/// Int32 CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_RCopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_RCopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTo_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CopyToBinary(System.Xml.IncrementalReadDecoder, Int32)
		/// </summary>
		protected RMethod r_RCopyToBinary_IncrementalReadDecoder_Int32;
		public virtual RMethod RCopyToBinary_IncrementalReadDecoder_Int32
		{
			get
			{
				if(r_RCopyToBinary_IncrementalReadDecoder_Int32 == null)
				{
					r_RCopyToBinary_IncrementalReadDecoder_Int32 = new(this, "CopyToBinary", 0,  ReleactionUtils.GetType("System.Xml.IncrementalReadDecoder"), typeof(System.Int32));
					r_RCopyToBinary_IncrementalReadDecoder_Int32.SetBelong(this.instance);
				}
				return r_RCopyToBinary_IncrementalReadDecoder_Int32;
			}
		}

		/// <summary>
		/// Void AdjustLineInfo(Int32, Boolean, System.Xml.LineInfo ByRef)
		/// </summary>
		protected RMethod r_RAdjustLineInfo_Int32_Boolean_Ref_LineInfo;
		public virtual RMethod RAdjustLineInfo_Int32_Boolean_Ref_LineInfo
		{
			get
			{
				if(r_RAdjustLineInfo_Int32_Boolean_Ref_LineInfo == null)
				{
					r_RAdjustLineInfo_Int32_Boolean_Ref_LineInfo = new(this, "AdjustLineInfo", 0, typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.LineInfo").MakeByRefType());
					r_RAdjustLineInfo_Int32_Boolean_Ref_LineInfo.SetBelong(this.instance);
				}
				return r_RAdjustLineInfo_Int32_Boolean_Ref_LineInfo;
			}
		}

		/// <summary>
		/// System.String GetNameWPrefix(System.Xml.XmlNameTable)
		/// </summary>
		protected RMethod r_RGetNameWPrefix_XmlNameTable;
		public virtual RMethod RGetNameWPrefix_XmlNameTable
		{
			get
			{
				if(r_RGetNameWPrefix_XmlNameTable == null)
				{
					r_RGetNameWPrefix_XmlNameTable = new(this, "GetNameWPrefix", 0, typeof(System.Xml.XmlNameTable));
					r_RGetNameWPrefix_XmlNameTable.SetBelong(this.instance);
				}
				return r_RGetNameWPrefix_XmlNameTable;
			}
		}

		/// <summary>
		/// System.String CreateNameWPrefix(System.Xml.XmlNameTable)
		/// </summary>
		protected RMethod r_RCreateNameWPrefix_XmlNameTable;
		public virtual RMethod RCreateNameWPrefix_XmlNameTable
		{
			get
			{
				if(r_RCreateNameWPrefix_XmlNameTable == null)
				{
					r_RCreateNameWPrefix_XmlNameTable = new(this, "CreateNameWPrefix", 0, typeof(System.Xml.XmlNameTable));
					r_RCreateNameWPrefix_XmlNameTable.SetBelong(this.instance);
				}
				return r_RCreateNameWPrefix_XmlNameTable;
			}
		}

		/// <summary>
		/// Int32 System.IComparable.CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__IComparable__1__CompareTo_Object;
		public virtual RMethod RSystem__1__IComparable__1__CompareTo_Object
		{
			get
			{
				if(r_RSystem__1__IComparable__1__CompareTo_Object == null)
				{
					r_RSystem__1__IComparable__1__CompareTo_Object = new(this, "System.IComparable.CompareTo", 0, typeof(System.Object));
					r_RSystem__1__IComparable__1__CompareTo_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__IComparable__1__CompareTo_Object;
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


        public RNodeData() : base("System.Xml.XmlTextReaderImpl+NodeData")
        {
        }

        public RNodeData(System.Object instance) : base("System.Xml.XmlTextReaderImpl+NodeData")
		{
            SetInstance(instance);
		}

        public RNodeData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNodeData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void TrimSpacesInValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimSpacesInValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RClear_XmlNodeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLineInfo(System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lineNo, @linePos};
            var ___result = RSetLineInfo_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLineInfo2(System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lineNo, @linePos};
            var ___result = RSetLineInfo2_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValueNode(System.Xml.XmlNodeType  @type, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @value};
            var ___result = RSetValueNode_XmlNodeType_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValueNode(System.Xml.XmlNodeType  @type, System.Char[]  @chars, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @chars, @startPos, @len};
            var ___result = RSetValueNode_XmlNodeType_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNamedNode(System.Xml.XmlNodeType  @type, System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @localName};
            var ___result = RSetNamedNode_XmlNodeType_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNamedNode(System.Xml.XmlNodeType  @type, System.String  @localName, System.String  @prefix, System.String  @nameWPrefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @localName, @prefix, @nameWPrefix};
            var ___result = RSetNamedNode_XmlNodeType_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Char[]  @chars, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @startPos, @len};
            var ___result = RSetValue_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBufferInvalidated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBufferInvalidated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32  @valueOffset, System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valueOffset, @sb};
            var ___result = RCopyTo_Int32_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 CopyTo(System.Int32  @valueOffset, System.Char[]  @buffer, System.Int32  @offset, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valueOffset, @buffer, @offset, @length};
            var ___result = RCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.String GetNameWPrefix(System.Xml.XmlNameTable  @nt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt};
            var ___result = RGetNameWPrefix_XmlNameTable.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateNameWPrefix(System.Xml.XmlNameTable  @nt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt};
            var ___result = RCreateNameWPrefix_XmlNameTable.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 System__1__IComparable__1__CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RSystem__1__IComparable__1__CompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
}