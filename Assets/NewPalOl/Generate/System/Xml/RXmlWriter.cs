using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlWriter
	/// </summary>
    public partial class RXmlWriter : RMember //
    {

		/// <summary>
		/// System.Char[] writeNodeBuffer
		/// </summary>
		protected RFieldArray<RField> r_writeNodeBuffer;
		public virtual RFieldArray<RField> RwriteNodeBuffer
		{
			get
			{
				if(r_writeNodeBuffer == null)
				{
					r_writeNodeBuffer = new(this, "writeNodeBuffer");
					r_writeNodeBuffer.SetBelong(this.instance);
				}
				return r_writeNodeBuffer;
			}
		}

		/// <summary>
		/// System.Int32 WriteNodeBufferSize
		/// </summary>
		protected static RField r_WriteNodeBufferSize;
		public static RField RWriteNodeBufferSize
		{
			get
			{
				if(r_WriteNodeBufferSize == null)
				{
					r_WriteNodeBufferSize = new(typeof(System.Xml.XmlWriter), "WriteNodeBufferSize");
					r_WriteNodeBufferSize.SetBelong(null);
				}
				return r_WriteNodeBufferSize;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriterSettings Settings
		/// </summary>
		protected RSystem.RXml.RXmlWriterSettings r_Settings;
		public virtual RSystem.RXml.RXmlWriterSettings RSettings
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
		/// System.Xml.WriteState WriteState
		/// </summary>
		protected RProperty r_WriteState;
		public virtual RProperty RWriteState
		{
			get
			{
				if(r_WriteState == null)
				{
					r_WriteState = new(this, "WriteState", -1);
					r_WriteState.SetBelong(this.instance);
				}
				return r_WriteState;
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
		/// Void WriteStartDocument()
		/// </summary>
		protected RMethod r_RWriteStartDocument;
		public virtual RMethod RWriteStartDocument
		{
			get
			{
				if(r_RWriteStartDocument == null)
				{
					r_RWriteStartDocument = new(this, "WriteStartDocument", 0);
					r_RWriteStartDocument.SetBelong(this.instance);
				}
				return r_RWriteStartDocument;
			}
		}

		/// <summary>
		/// Void WriteStartDocument(Boolean)
		/// </summary>
		protected RMethod r_RWriteStartDocument_Boolean;
		public virtual RMethod RWriteStartDocument_Boolean
		{
			get
			{
				if(r_RWriteStartDocument_Boolean == null)
				{
					r_RWriteStartDocument_Boolean = new(this, "WriteStartDocument", 0, typeof(System.Boolean));
					r_RWriteStartDocument_Boolean.SetBelong(this.instance);
				}
				return r_RWriteStartDocument_Boolean;
			}
		}

		/// <summary>
		/// Void WriteEndDocument()
		/// </summary>
		protected RMethod r_RWriteEndDocument;
		public virtual RMethod RWriteEndDocument
		{
			get
			{
				if(r_RWriteEndDocument == null)
				{
					r_RWriteEndDocument = new(this, "WriteEndDocument", 0);
					r_RWriteEndDocument.SetBelong(this.instance);
				}
				return r_RWriteEndDocument;
			}
		}

		/// <summary>
		/// Void WriteDocType(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteDocType_String_String_String_String;
		public virtual RMethod RWriteDocType_String_String_String_String
		{
			get
			{
				if(r_RWriteDocType_String_String_String_String == null)
				{
					r_RWriteDocType_String_String_String_String = new(this, "WriteDocType", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteDocType_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteDocType_String_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartElement_String_String;
		public virtual RMethod RWriteStartElement_String_String
		{
			get
			{
				if(r_RWriteStartElement_String_String == null)
				{
					r_RWriteStartElement_String_String = new(this, "WriteStartElement", 0, typeof(System.String), typeof(System.String));
					r_RWriteStartElement_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartElement_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartElement(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartElement_String_String_String;
		public virtual RMethod RWriteStartElement_String_String_String
		{
			get
			{
				if(r_RWriteStartElement_String_String_String == null)
				{
					r_RWriteStartElement_String_String_String = new(this, "WriteStartElement", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteStartElement_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartElement_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartElement(System.String)
		/// </summary>
		protected RMethod r_RWriteStartElement_String;
		public virtual RMethod RWriteStartElement_String
		{
			get
			{
				if(r_RWriteStartElement_String == null)
				{
					r_RWriteStartElement_String = new(this, "WriteStartElement", 0, typeof(System.String));
					r_RWriteStartElement_String.SetBelong(this.instance);
				}
				return r_RWriteStartElement_String;
			}
		}

		/// <summary>
		/// Void WriteEndElement()
		/// </summary>
		protected RMethod r_RWriteEndElement;
		public virtual RMethod RWriteEndElement
		{
			get
			{
				if(r_RWriteEndElement == null)
				{
					r_RWriteEndElement = new(this, "WriteEndElement", 0);
					r_RWriteEndElement.SetBelong(this.instance);
				}
				return r_RWriteEndElement;
			}
		}

		/// <summary>
		/// Void WriteFullEndElement()
		/// </summary>
		protected RMethod r_RWriteFullEndElement;
		public virtual RMethod RWriteFullEndElement
		{
			get
			{
				if(r_RWriteFullEndElement == null)
				{
					r_RWriteFullEndElement = new(this, "WriteFullEndElement", 0);
					r_RWriteFullEndElement.SetBelong(this.instance);
				}
				return r_RWriteFullEndElement;
			}
		}

		/// <summary>
		/// Void WriteAttributeString(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteAttributeString_String_String_String;
		public virtual RMethod RWriteAttributeString_String_String_String
		{
			get
			{
				if(r_RWriteAttributeString_String_String_String == null)
				{
					r_RWriteAttributeString_String_String_String = new(this, "WriteAttributeString", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteAttributeString_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteAttributeString_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteAttributeString(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteAttributeString_String_String;
		public virtual RMethod RWriteAttributeString_String_String
		{
			get
			{
				if(r_RWriteAttributeString_String_String == null)
				{
					r_RWriteAttributeString_String_String = new(this, "WriteAttributeString", 0, typeof(System.String), typeof(System.String));
					r_RWriteAttributeString_String_String.SetBelong(this.instance);
				}
				return r_RWriteAttributeString_String_String;
			}
		}

		/// <summary>
		/// Void WriteAttributeString(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteAttributeString_String_String_String_String;
		public virtual RMethod RWriteAttributeString_String_String_String_String
		{
			get
			{
				if(r_RWriteAttributeString_String_String_String_String == null)
				{
					r_RWriteAttributeString_String_String_String_String = new(this, "WriteAttributeString", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteAttributeString_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteAttributeString_String_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartAttribute_String_String;
		public virtual RMethod RWriteStartAttribute_String_String
		{
			get
			{
				if(r_RWriteStartAttribute_String_String == null)
				{
					r_RWriteStartAttribute_String_String = new(this, "WriteStartAttribute", 0, typeof(System.String), typeof(System.String));
					r_RWriteStartAttribute_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartAttribute_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartAttribute(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartAttribute_String_String_String;
		public virtual RMethod RWriteStartAttribute_String_String_String
		{
			get
			{
				if(r_RWriteStartAttribute_String_String_String == null)
				{
					r_RWriteStartAttribute_String_String_String = new(this, "WriteStartAttribute", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteStartAttribute_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartAttribute_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteStartAttribute(System.String)
		/// </summary>
		protected RMethod r_RWriteStartAttribute_String;
		public virtual RMethod RWriteStartAttribute_String
		{
			get
			{
				if(r_RWriteStartAttribute_String == null)
				{
					r_RWriteStartAttribute_String = new(this, "WriteStartAttribute", 0, typeof(System.String));
					r_RWriteStartAttribute_String.SetBelong(this.instance);
				}
				return r_RWriteStartAttribute_String;
			}
		}

		/// <summary>
		/// Void WriteEndAttribute()
		/// </summary>
		protected RMethod r_RWriteEndAttribute;
		public virtual RMethod RWriteEndAttribute
		{
			get
			{
				if(r_RWriteEndAttribute == null)
				{
					r_RWriteEndAttribute = new(this, "WriteEndAttribute", 0);
					r_RWriteEndAttribute.SetBelong(this.instance);
				}
				return r_RWriteEndAttribute;
			}
		}

		/// <summary>
		/// Void WriteCData(System.String)
		/// </summary>
		protected RMethod r_RWriteCData_String;
		public virtual RMethod RWriteCData_String
		{
			get
			{
				if(r_RWriteCData_String == null)
				{
					r_RWriteCData_String = new(this, "WriteCData", 0, typeof(System.String));
					r_RWriteCData_String.SetBelong(this.instance);
				}
				return r_RWriteCData_String;
			}
		}

		/// <summary>
		/// Void WriteComment(System.String)
		/// </summary>
		protected RMethod r_RWriteComment_String;
		public virtual RMethod RWriteComment_String
		{
			get
			{
				if(r_RWriteComment_String == null)
				{
					r_RWriteComment_String = new(this, "WriteComment", 0, typeof(System.String));
					r_RWriteComment_String.SetBelong(this.instance);
				}
				return r_RWriteComment_String;
			}
		}

		/// <summary>
		/// Void WriteProcessingInstruction(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteProcessingInstruction_String_String;
		public virtual RMethod RWriteProcessingInstruction_String_String
		{
			get
			{
				if(r_RWriteProcessingInstruction_String_String == null)
				{
					r_RWriteProcessingInstruction_String_String = new(this, "WriteProcessingInstruction", 0, typeof(System.String), typeof(System.String));
					r_RWriteProcessingInstruction_String_String.SetBelong(this.instance);
				}
				return r_RWriteProcessingInstruction_String_String;
			}
		}

		/// <summary>
		/// Void WriteEntityRef(System.String)
		/// </summary>
		protected RMethod r_RWriteEntityRef_String;
		public virtual RMethod RWriteEntityRef_String
		{
			get
			{
				if(r_RWriteEntityRef_String == null)
				{
					r_RWriteEntityRef_String = new(this, "WriteEntityRef", 0, typeof(System.String));
					r_RWriteEntityRef_String.SetBelong(this.instance);
				}
				return r_RWriteEntityRef_String;
			}
		}

		/// <summary>
		/// Void WriteCharEntity(Char)
		/// </summary>
		protected RMethod r_RWriteCharEntity_Char;
		public virtual RMethod RWriteCharEntity_Char
		{
			get
			{
				if(r_RWriteCharEntity_Char == null)
				{
					r_RWriteCharEntity_Char = new(this, "WriteCharEntity", 0, typeof(System.Char));
					r_RWriteCharEntity_Char.SetBelong(this.instance);
				}
				return r_RWriteCharEntity_Char;
			}
		}

		/// <summary>
		/// Void WriteWhitespace(System.String)
		/// </summary>
		protected RMethod r_RWriteWhitespace_String;
		public virtual RMethod RWriteWhitespace_String
		{
			get
			{
				if(r_RWriteWhitespace_String == null)
				{
					r_RWriteWhitespace_String = new(this, "WriteWhitespace", 0, typeof(System.String));
					r_RWriteWhitespace_String.SetBelong(this.instance);
				}
				return r_RWriteWhitespace_String;
			}
		}

		/// <summary>
		/// Void WriteString(System.String)
		/// </summary>
		protected RMethod r_RWriteString_String;
		public virtual RMethod RWriteString_String
		{
			get
			{
				if(r_RWriteString_String == null)
				{
					r_RWriteString_String = new(this, "WriteString", 0, typeof(System.String));
					r_RWriteString_String.SetBelong(this.instance);
				}
				return r_RWriteString_String;
			}
		}

		/// <summary>
		/// Void WriteSurrogateCharEntity(Char, Char)
		/// </summary>
		protected RMethod r_RWriteSurrogateCharEntity_Char_Char;
		public virtual RMethod RWriteSurrogateCharEntity_Char_Char
		{
			get
			{
				if(r_RWriteSurrogateCharEntity_Char_Char == null)
				{
					r_RWriteSurrogateCharEntity_Char_Char = new(this, "WriteSurrogateCharEntity", 0, typeof(System.Char), typeof(System.Char));
					r_RWriteSurrogateCharEntity_Char_Char.SetBelong(this.instance);
				}
				return r_RWriteSurrogateCharEntity_Char_Char;
			}
		}

		/// <summary>
		/// Void WriteChars(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteChars_CharArray_Int32_Int32;
		public virtual RMethod RWriteChars_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteChars_CharArray_Int32_Int32 == null)
				{
					r_RWriteChars_CharArray_Int32_Int32 = new(this, "WriteChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteChars_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteChars_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteRaw(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteRaw_CharArray_Int32_Int32;
		public virtual RMethod RWriteRaw_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteRaw_CharArray_Int32_Int32 == null)
				{
					r_RWriteRaw_CharArray_Int32_Int32 = new(this, "WriteRaw", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteRaw_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteRaw_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteRaw(System.String)
		/// </summary>
		protected RMethod r_RWriteRaw_String;
		public virtual RMethod RWriteRaw_String
		{
			get
			{
				if(r_RWriteRaw_String == null)
				{
					r_RWriteRaw_String = new(this, "WriteRaw", 0, typeof(System.String));
					r_RWriteRaw_String.SetBelong(this.instance);
				}
				return r_RWriteRaw_String;
			}
		}

		/// <summary>
		/// Void WriteBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteBase64_ByteArray_Int32_Int32;
		public virtual RMethod RWriteBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteBase64_ByteArray_Int32_Int32 == null)
				{
					r_RWriteBase64_ByteArray_Int32_Int32 = new(this, "WriteBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RWriteBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RWriteBinHex_ByteArray_Int32_Int32 = new(this, "WriteBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteBinHex_ByteArray_Int32_Int32;
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
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
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
		/// Void WriteNmToken(System.String)
		/// </summary>
		protected RMethod r_RWriteNmToken_String;
		public virtual RMethod RWriteNmToken_String
		{
			get
			{
				if(r_RWriteNmToken_String == null)
				{
					r_RWriteNmToken_String = new(this, "WriteNmToken", 0, typeof(System.String));
					r_RWriteNmToken_String.SetBelong(this.instance);
				}
				return r_RWriteNmToken_String;
			}
		}

		/// <summary>
		/// Void WriteName(System.String)
		/// </summary>
		protected RMethod r_RWriteName_String;
		public virtual RMethod RWriteName_String
		{
			get
			{
				if(r_RWriteName_String == null)
				{
					r_RWriteName_String = new(this, "WriteName", 0, typeof(System.String));
					r_RWriteName_String.SetBelong(this.instance);
				}
				return r_RWriteName_String;
			}
		}

		/// <summary>
		/// Void WriteQualifiedName(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteQualifiedName_String_String;
		public virtual RMethod RWriteQualifiedName_String_String
		{
			get
			{
				if(r_RWriteQualifiedName_String_String == null)
				{
					r_RWriteQualifiedName_String_String = new(this, "WriteQualifiedName", 0, typeof(System.String), typeof(System.String));
					r_RWriteQualifiedName_String_String.SetBelong(this.instance);
				}
				return r_RWriteQualifiedName_String_String;
			}
		}

		/// <summary>
		/// Void WriteValue(System.Object)
		/// </summary>
		protected RMethod r_RWriteValue_Object;
		public virtual RMethod RWriteValue_Object
		{
			get
			{
				if(r_RWriteValue_Object == null)
				{
					r_RWriteValue_Object = new(this, "WriteValue", 0, typeof(System.Object));
					r_RWriteValue_Object.SetBelong(this.instance);
				}
				return r_RWriteValue_Object;
			}
		}

		/// <summary>
		/// Void WriteValue(System.String)
		/// </summary>
		protected RMethod r_RWriteValue_String;
		public virtual RMethod RWriteValue_String
		{
			get
			{
				if(r_RWriteValue_String == null)
				{
					r_RWriteValue_String = new(this, "WriteValue", 0, typeof(System.String));
					r_RWriteValue_String.SetBelong(this.instance);
				}
				return r_RWriteValue_String;
			}
		}

		/// <summary>
		/// Void WriteValue(Boolean)
		/// </summary>
		protected RMethod r_RWriteValue_Boolean;
		public virtual RMethod RWriteValue_Boolean
		{
			get
			{
				if(r_RWriteValue_Boolean == null)
				{
					r_RWriteValue_Boolean = new(this, "WriteValue", 0, typeof(System.Boolean));
					r_RWriteValue_Boolean.SetBelong(this.instance);
				}
				return r_RWriteValue_Boolean;
			}
		}

		/// <summary>
		/// Void WriteValue(System.DateTime)
		/// </summary>
		protected RMethod r_RWriteValue_DateTime;
		public virtual RMethod RWriteValue_DateTime
		{
			get
			{
				if(r_RWriteValue_DateTime == null)
				{
					r_RWriteValue_DateTime = new(this, "WriteValue", 0, typeof(System.DateTime));
					r_RWriteValue_DateTime.SetBelong(this.instance);
				}
				return r_RWriteValue_DateTime;
			}
		}

		/// <summary>
		/// Void WriteValue(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RWriteValue_DateTimeOffset;
		public virtual RMethod RWriteValue_DateTimeOffset
		{
			get
			{
				if(r_RWriteValue_DateTimeOffset == null)
				{
					r_RWriteValue_DateTimeOffset = new(this, "WriteValue", 0, typeof(System.DateTimeOffset));
					r_RWriteValue_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RWriteValue_DateTimeOffset;
			}
		}

		/// <summary>
		/// Void WriteValue(Double)
		/// </summary>
		protected RMethod r_RWriteValue_Double;
		public virtual RMethod RWriteValue_Double
		{
			get
			{
				if(r_RWriteValue_Double == null)
				{
					r_RWriteValue_Double = new(this, "WriteValue", 0, typeof(System.Double));
					r_RWriteValue_Double.SetBelong(this.instance);
				}
				return r_RWriteValue_Double;
			}
		}

		/// <summary>
		/// Void WriteValue(Single)
		/// </summary>
		protected RMethod r_RWriteValue_Single;
		public virtual RMethod RWriteValue_Single
		{
			get
			{
				if(r_RWriteValue_Single == null)
				{
					r_RWriteValue_Single = new(this, "WriteValue", 0, typeof(System.Single));
					r_RWriteValue_Single.SetBelong(this.instance);
				}
				return r_RWriteValue_Single;
			}
		}

		/// <summary>
		/// Void WriteValue(System.Decimal)
		/// </summary>
		protected RMethod r_RWriteValue_Decimal;
		public virtual RMethod RWriteValue_Decimal
		{
			get
			{
				if(r_RWriteValue_Decimal == null)
				{
					r_RWriteValue_Decimal = new(this, "WriteValue", 0, typeof(System.Decimal));
					r_RWriteValue_Decimal.SetBelong(this.instance);
				}
				return r_RWriteValue_Decimal;
			}
		}

		/// <summary>
		/// Void WriteValue(Int32)
		/// </summary>
		protected RMethod r_RWriteValue_Int32;
		public virtual RMethod RWriteValue_Int32
		{
			get
			{
				if(r_RWriteValue_Int32 == null)
				{
					r_RWriteValue_Int32 = new(this, "WriteValue", 0, typeof(System.Int32));
					r_RWriteValue_Int32.SetBelong(this.instance);
				}
				return r_RWriteValue_Int32;
			}
		}

		/// <summary>
		/// Void WriteValue(Int64)
		/// </summary>
		protected RMethod r_RWriteValue_Int64;
		public virtual RMethod RWriteValue_Int64
		{
			get
			{
				if(r_RWriteValue_Int64 == null)
				{
					r_RWriteValue_Int64 = new(this, "WriteValue", 0, typeof(System.Int64));
					r_RWriteValue_Int64.SetBelong(this.instance);
				}
				return r_RWriteValue_Int64;
			}
		}

		/// <summary>
		/// Void WriteAttributes(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteAttributes_XmlReader_Boolean;
		public virtual RMethod RWriteAttributes_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteAttributes_XmlReader_Boolean == null)
				{
					r_RWriteAttributes_XmlReader_Boolean = new(this, "WriteAttributes", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteAttributes_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteAttributes_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// Void WriteNode(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteNode_XmlReader_Boolean;
		public virtual RMethod RWriteNode_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteNode_XmlReader_Boolean == null)
				{
					r_RWriteNode_XmlReader_Boolean = new(this, "WriteNode", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteNode_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNode_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// Void WriteNode(System.Xml.XPath.XPathNavigator, Boolean)
		/// </summary>
		protected RMethod r_RWriteNode_XPathNavigator_Boolean;
		public virtual RMethod RWriteNode_XPathNavigator_Boolean
		{
			get
			{
				if(r_RWriteNode_XPathNavigator_Boolean == null)
				{
					r_RWriteNode_XPathNavigator_Boolean = new(this, "WriteNode", 0, typeof(System.Xml.XPath.XPathNavigator), typeof(System.Boolean));
					r_RWriteNode_XPathNavigator_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNode_XPathNavigator_Boolean;
			}
		}

		/// <summary>
		/// Void WriteElementString(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteElementString_String_String;
		public virtual RMethod RWriteElementString_String_String
		{
			get
			{
				if(r_RWriteElementString_String_String == null)
				{
					r_RWriteElementString_String_String = new(this, "WriteElementString", 0, typeof(System.String), typeof(System.String));
					r_RWriteElementString_String_String.SetBelong(this.instance);
				}
				return r_RWriteElementString_String_String;
			}
		}

		/// <summary>
		/// Void WriteElementString(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteElementString_String_String_String;
		public virtual RMethod RWriteElementString_String_String_String
		{
			get
			{
				if(r_RWriteElementString_String_String_String == null)
				{
					r_RWriteElementString_String_String_String = new(this, "WriteElementString", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteElementString_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteElementString_String_String_String;
			}
		}

		/// <summary>
		/// Void WriteElementString(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteElementString_String_String_String_String;
		public virtual RMethod RWriteElementString_String_String_String_String
		{
			get
			{
				if(r_RWriteElementString_String_String_String_String == null)
				{
					r_RWriteElementString_String_String_String_String = new(this, "WriteElementString", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteElementString_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteElementString_String_String_String_String;
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
		/// Void WriteLocalNamespaces(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RWriteLocalNamespaces_XPathNavigator;
		public virtual RMethod RWriteLocalNamespaces_XPathNavigator
		{
			get
			{
				if(r_RWriteLocalNamespaces_XPathNavigator == null)
				{
					r_RWriteLocalNamespaces_XPathNavigator = new(this, "WriteLocalNamespaces", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RWriteLocalNamespaces_XPathNavigator.SetBelong(this.instance);
				}
				return r_RWriteLocalNamespaces_XPathNavigator;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.String)
		/// </summary>
		protected static RMethod r_RCreate_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_RCreate_String == null)
				{
					r_RCreate_String = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.String));
					r_RCreate_String.SetBelong(null);
				}
				return r_RCreate_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.String, System.Xml.XmlWriterSettings)
		/// </summary>
		protected static RMethod r_RCreate_String_XmlWriterSettings;
		public static RMethod RCreate_String_XmlWriterSettings
		{
			get
			{
				if(r_RCreate_String_XmlWriterSettings == null)
				{
					r_RCreate_String_XmlWriterSettings = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.String), typeof(System.Xml.XmlWriterSettings));
					r_RCreate_String_XmlWriterSettings.SetBelong(null);
				}
				return r_RCreate_String_XmlWriterSettings;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.IO.Stream)
		/// </summary>
		protected static RMethod r_RCreate_Stream;
		public static RMethod RCreate_Stream
		{
			get
			{
				if(r_RCreate_Stream == null)
				{
					r_RCreate_Stream = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.IO.Stream));
					r_RCreate_Stream.SetBelong(null);
				}
				return r_RCreate_Stream;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.IO.Stream, System.Xml.XmlWriterSettings)
		/// </summary>
		protected static RMethod r_RCreate_Stream_XmlWriterSettings;
		public static RMethod RCreate_Stream_XmlWriterSettings
		{
			get
			{
				if(r_RCreate_Stream_XmlWriterSettings == null)
				{
					r_RCreate_Stream_XmlWriterSettings = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.IO.Stream), typeof(System.Xml.XmlWriterSettings));
					r_RCreate_Stream_XmlWriterSettings.SetBelong(null);
				}
				return r_RCreate_Stream_XmlWriterSettings;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.IO.TextWriter)
		/// </summary>
		protected static RMethod r_RCreate_TextWriter;
		public static RMethod RCreate_TextWriter
		{
			get
			{
				if(r_RCreate_TextWriter == null)
				{
					r_RCreate_TextWriter = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.IO.TextWriter));
					r_RCreate_TextWriter.SetBelong(null);
				}
				return r_RCreate_TextWriter;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.IO.TextWriter, System.Xml.XmlWriterSettings)
		/// </summary>
		protected static RMethod r_RCreate_TextWriter_XmlWriterSettings;
		public static RMethod RCreate_TextWriter_XmlWriterSettings
		{
			get
			{
				if(r_RCreate_TextWriter_XmlWriterSettings == null)
				{
					r_RCreate_TextWriter_XmlWriterSettings = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.IO.TextWriter), typeof(System.Xml.XmlWriterSettings));
					r_RCreate_TextWriter_XmlWriterSettings.SetBelong(null);
				}
				return r_RCreate_TextWriter_XmlWriterSettings;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.Text.StringBuilder)
		/// </summary>
		protected static RMethod r_RCreate_StringBuilder;
		public static RMethod RCreate_StringBuilder
		{
			get
			{
				if(r_RCreate_StringBuilder == null)
				{
					r_RCreate_StringBuilder = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.Text.StringBuilder));
					r_RCreate_StringBuilder.SetBelong(null);
				}
				return r_RCreate_StringBuilder;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.Text.StringBuilder, System.Xml.XmlWriterSettings)
		/// </summary>
		protected static RMethod r_RCreate_StringBuilder_XmlWriterSettings;
		public static RMethod RCreate_StringBuilder_XmlWriterSettings
		{
			get
			{
				if(r_RCreate_StringBuilder_XmlWriterSettings == null)
				{
					r_RCreate_StringBuilder_XmlWriterSettings = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.Text.StringBuilder), typeof(System.Xml.XmlWriterSettings));
					r_RCreate_StringBuilder_XmlWriterSettings.SetBelong(null);
				}
				return r_RCreate_StringBuilder_XmlWriterSettings;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.Xml.XmlWriter)
		/// </summary>
		protected static RMethod r_RCreate_XmlWriter;
		public static RMethod RCreate_XmlWriter
		{
			get
			{
				if(r_RCreate_XmlWriter == null)
				{
					r_RCreate_XmlWriter = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.Xml.XmlWriter));
					r_RCreate_XmlWriter.SetBelong(null);
				}
				return r_RCreate_XmlWriter;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter Create(System.Xml.XmlWriter, System.Xml.XmlWriterSettings)
		/// </summary>
		protected static RMethod r_RCreate_XmlWriter_XmlWriterSettings;
		public static RMethod RCreate_XmlWriter_XmlWriterSettings
		{
			get
			{
				if(r_RCreate_XmlWriter_XmlWriterSettings == null)
				{
					r_RCreate_XmlWriter_XmlWriterSettings = new(typeof(System.Xml.XmlWriter), "Create", 0, typeof(System.Xml.XmlWriter), typeof(System.Xml.XmlWriterSettings));
					r_RCreate_XmlWriter_XmlWriterSettings.SetBelong(null);
				}
				return r_RCreate_XmlWriter_XmlWriterSettings;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteStartDocumentAsync()
		/// </summary>
		protected RMethod r_RWriteStartDocumentAsync;
		public virtual RMethod RWriteStartDocumentAsync
		{
			get
			{
				if(r_RWriteStartDocumentAsync == null)
				{
					r_RWriteStartDocumentAsync = new(this, "WriteStartDocumentAsync", 0);
					r_RWriteStartDocumentAsync.SetBelong(this.instance);
				}
				return r_RWriteStartDocumentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteStartDocumentAsync(Boolean)
		/// </summary>
		protected RMethod r_RWriteStartDocumentAsync_Boolean;
		public virtual RMethod RWriteStartDocumentAsync_Boolean
		{
			get
			{
				if(r_RWriteStartDocumentAsync_Boolean == null)
				{
					r_RWriteStartDocumentAsync_Boolean = new(this, "WriteStartDocumentAsync", 0, typeof(System.Boolean));
					r_RWriteStartDocumentAsync_Boolean.SetBelong(this.instance);
				}
				return r_RWriteStartDocumentAsync_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteEndDocumentAsync()
		/// </summary>
		protected RMethod r_RWriteEndDocumentAsync;
		public virtual RMethod RWriteEndDocumentAsync
		{
			get
			{
				if(r_RWriteEndDocumentAsync == null)
				{
					r_RWriteEndDocumentAsync = new(this, "WriteEndDocumentAsync", 0);
					r_RWriteEndDocumentAsync.SetBelong(this.instance);
				}
				return r_RWriteEndDocumentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteDocTypeAsync(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteDocTypeAsync_String_String_String_String;
		public virtual RMethod RWriteDocTypeAsync_String_String_String_String
		{
			get
			{
				if(r_RWriteDocTypeAsync_String_String_String_String == null)
				{
					r_RWriteDocTypeAsync_String_String_String_String = new(this, "WriteDocTypeAsync", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteDocTypeAsync_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteDocTypeAsync_String_String_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteStartElementAsync(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartElementAsync_String_String_String;
		public virtual RMethod RWriteStartElementAsync_String_String_String
		{
			get
			{
				if(r_RWriteStartElementAsync_String_String_String == null)
				{
					r_RWriteStartElementAsync_String_String_String = new(this, "WriteStartElementAsync", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteStartElementAsync_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartElementAsync_String_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteEndElementAsync()
		/// </summary>
		protected RMethod r_RWriteEndElementAsync;
		public virtual RMethod RWriteEndElementAsync
		{
			get
			{
				if(r_RWriteEndElementAsync == null)
				{
					r_RWriteEndElementAsync = new(this, "WriteEndElementAsync", 0);
					r_RWriteEndElementAsync.SetBelong(this.instance);
				}
				return r_RWriteEndElementAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteFullEndElementAsync()
		/// </summary>
		protected RMethod r_RWriteFullEndElementAsync;
		public virtual RMethod RWriteFullEndElementAsync
		{
			get
			{
				if(r_RWriteFullEndElementAsync == null)
				{
					r_RWriteFullEndElementAsync = new(this, "WriteFullEndElementAsync", 0);
					r_RWriteFullEndElementAsync.SetBelong(this.instance);
				}
				return r_RWriteFullEndElementAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAttributeStringAsync(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteAttributeStringAsync_String_String_String_String;
		public virtual RMethod RWriteAttributeStringAsync_String_String_String_String
		{
			get
			{
				if(r_RWriteAttributeStringAsync_String_String_String_String == null)
				{
					r_RWriteAttributeStringAsync_String_String_String_String = new(this, "WriteAttributeStringAsync", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteAttributeStringAsync_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteAttributeStringAsync_String_String_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAttributeStringAsyncHelper(System.Threading.Tasks.Task, System.String)
		/// </summary>
		protected RMethod r_RWriteAttributeStringAsyncHelper_Task_String;
		public virtual RMethod RWriteAttributeStringAsyncHelper_Task_String
		{
			get
			{
				if(r_RWriteAttributeStringAsyncHelper_Task_String == null)
				{
					r_RWriteAttributeStringAsyncHelper_Task_String = new(this, "WriteAttributeStringAsyncHelper", 0, typeof(System.Threading.Tasks.Task), typeof(System.String));
					r_RWriteAttributeStringAsyncHelper_Task_String.SetBelong(this.instance);
				}
				return r_RWriteAttributeStringAsyncHelper_Task_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteStartAttributeAsync(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteStartAttributeAsync_String_String_String;
		public virtual RMethod RWriteStartAttributeAsync_String_String_String
		{
			get
			{
				if(r_RWriteStartAttributeAsync_String_String_String == null)
				{
					r_RWriteStartAttributeAsync_String_String_String = new(this, "WriteStartAttributeAsync", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteStartAttributeAsync_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteStartAttributeAsync_String_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteEndAttributeAsync()
		/// </summary>
		protected RMethod r_RWriteEndAttributeAsync;
		public virtual RMethod RWriteEndAttributeAsync
		{
			get
			{
				if(r_RWriteEndAttributeAsync == null)
				{
					r_RWriteEndAttributeAsync = new(this, "WriteEndAttributeAsync", 0);
					r_RWriteEndAttributeAsync.SetBelong(this.instance);
				}
				return r_RWriteEndAttributeAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteCDataAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteCDataAsync_String;
		public virtual RMethod RWriteCDataAsync_String
		{
			get
			{
				if(r_RWriteCDataAsync_String == null)
				{
					r_RWriteCDataAsync_String = new(this, "WriteCDataAsync", 0, typeof(System.String));
					r_RWriteCDataAsync_String.SetBelong(this.instance);
				}
				return r_RWriteCDataAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteCommentAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteCommentAsync_String;
		public virtual RMethod RWriteCommentAsync_String
		{
			get
			{
				if(r_RWriteCommentAsync_String == null)
				{
					r_RWriteCommentAsync_String = new(this, "WriteCommentAsync", 0, typeof(System.String));
					r_RWriteCommentAsync_String.SetBelong(this.instance);
				}
				return r_RWriteCommentAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteProcessingInstructionAsync(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteProcessingInstructionAsync_String_String;
		public virtual RMethod RWriteProcessingInstructionAsync_String_String
		{
			get
			{
				if(r_RWriteProcessingInstructionAsync_String_String == null)
				{
					r_RWriteProcessingInstructionAsync_String_String = new(this, "WriteProcessingInstructionAsync", 0, typeof(System.String), typeof(System.String));
					r_RWriteProcessingInstructionAsync_String_String.SetBelong(this.instance);
				}
				return r_RWriteProcessingInstructionAsync_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteEntityRefAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteEntityRefAsync_String;
		public virtual RMethod RWriteEntityRefAsync_String
		{
			get
			{
				if(r_RWriteEntityRefAsync_String == null)
				{
					r_RWriteEntityRefAsync_String = new(this, "WriteEntityRefAsync", 0, typeof(System.String));
					r_RWriteEntityRefAsync_String.SetBelong(this.instance);
				}
				return r_RWriteEntityRefAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteCharEntityAsync(Char)
		/// </summary>
		protected RMethod r_RWriteCharEntityAsync_Char;
		public virtual RMethod RWriteCharEntityAsync_Char
		{
			get
			{
				if(r_RWriteCharEntityAsync_Char == null)
				{
					r_RWriteCharEntityAsync_Char = new(this, "WriteCharEntityAsync", 0, typeof(System.Char));
					r_RWriteCharEntityAsync_Char.SetBelong(this.instance);
				}
				return r_RWriteCharEntityAsync_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteWhitespaceAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteWhitespaceAsync_String;
		public virtual RMethod RWriteWhitespaceAsync_String
		{
			get
			{
				if(r_RWriteWhitespaceAsync_String == null)
				{
					r_RWriteWhitespaceAsync_String = new(this, "WriteWhitespaceAsync", 0, typeof(System.String));
					r_RWriteWhitespaceAsync_String.SetBelong(this.instance);
				}
				return r_RWriteWhitespaceAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteStringAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteStringAsync_String;
		public virtual RMethod RWriteStringAsync_String
		{
			get
			{
				if(r_RWriteStringAsync_String == null)
				{
					r_RWriteStringAsync_String = new(this, "WriteStringAsync", 0, typeof(System.String));
					r_RWriteStringAsync_String.SetBelong(this.instance);
				}
				return r_RWriteStringAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteSurrogateCharEntityAsync(Char, Char)
		/// </summary>
		protected RMethod r_RWriteSurrogateCharEntityAsync_Char_Char;
		public virtual RMethod RWriteSurrogateCharEntityAsync_Char_Char
		{
			get
			{
				if(r_RWriteSurrogateCharEntityAsync_Char_Char == null)
				{
					r_RWriteSurrogateCharEntityAsync_Char_Char = new(this, "WriteSurrogateCharEntityAsync", 0, typeof(System.Char), typeof(System.Char));
					r_RWriteSurrogateCharEntityAsync_Char_Char.SetBelong(this.instance);
				}
				return r_RWriteSurrogateCharEntityAsync_Char_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteCharsAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteCharsAsync_CharArray_Int32_Int32;
		public virtual RMethod RWriteCharsAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteCharsAsync_CharArray_Int32_Int32 == null)
				{
					r_RWriteCharsAsync_CharArray_Int32_Int32 = new(this, "WriteCharsAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteCharsAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteCharsAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteRawAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteRawAsync_CharArray_Int32_Int32;
		public virtual RMethod RWriteRawAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteRawAsync_CharArray_Int32_Int32 == null)
				{
					r_RWriteRawAsync_CharArray_Int32_Int32 = new(this, "WriteRawAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteRawAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteRawAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteRawAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteRawAsync_String;
		public virtual RMethod RWriteRawAsync_String
		{
			get
			{
				if(r_RWriteRawAsync_String == null)
				{
					r_RWriteRawAsync_String = new(this, "WriteRawAsync", 0, typeof(System.String));
					r_RWriteRawAsync_String.SetBelong(this.instance);
				}
				return r_RWriteRawAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteBase64Async(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteBase64Async_ByteArray_Int32_Int32;
		public virtual RMethod RWriteBase64Async_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteBase64Async_ByteArray_Int32_Int32 == null)
				{
					r_RWriteBase64Async_ByteArray_Int32_Int32 = new(this, "WriteBase64Async", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteBase64Async_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteBase64Async_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteBinHexAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteBinHexAsync_ByteArray_Int32_Int32;
		public virtual RMethod RWriteBinHexAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteBinHexAsync_ByteArray_Int32_Int32 == null)
				{
					r_RWriteBinHexAsync_ByteArray_Int32_Int32 = new(this, "WriteBinHexAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteBinHexAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteBinHexAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_RFlushAsync;
		public virtual RMethod RFlushAsync
		{
			get
			{
				if(r_RFlushAsync == null)
				{
					r_RFlushAsync = new(this, "FlushAsync", 0);
					r_RFlushAsync.SetBelong(this.instance);
				}
				return r_RFlushAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNmTokenAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteNmTokenAsync_String;
		public virtual RMethod RWriteNmTokenAsync_String
		{
			get
			{
				if(r_RWriteNmTokenAsync_String == null)
				{
					r_RWriteNmTokenAsync_String = new(this, "WriteNmTokenAsync", 0, typeof(System.String));
					r_RWriteNmTokenAsync_String.SetBelong(this.instance);
				}
				return r_RWriteNmTokenAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNameAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteNameAsync_String;
		public virtual RMethod RWriteNameAsync_String
		{
			get
			{
				if(r_RWriteNameAsync_String == null)
				{
					r_RWriteNameAsync_String = new(this, "WriteNameAsync", 0, typeof(System.String));
					r_RWriteNameAsync_String.SetBelong(this.instance);
				}
				return r_RWriteNameAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteQualifiedNameAsync(System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteQualifiedNameAsync_String_String;
		public virtual RMethod RWriteQualifiedNameAsync_String_String
		{
			get
			{
				if(r_RWriteQualifiedNameAsync_String_String == null)
				{
					r_RWriteQualifiedNameAsync_String_String = new(this, "WriteQualifiedNameAsync", 0, typeof(System.String), typeof(System.String));
					r_RWriteQualifiedNameAsync_String_String.SetBelong(this.instance);
				}
				return r_RWriteQualifiedNameAsync_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAttributesAsync(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteAttributesAsync_XmlReader_Boolean;
		public virtual RMethod RWriteAttributesAsync_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteAttributesAsync_XmlReader_Boolean == null)
				{
					r_RWriteAttributesAsync_XmlReader_Boolean = new(this, "WriteAttributesAsync", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteAttributesAsync_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteAttributesAsync_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteNodeAsync_XmlReader_Boolean;
		public virtual RMethod RWriteNodeAsync_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteNodeAsync_XmlReader_Boolean == null)
				{
					r_RWriteNodeAsync_XmlReader_Boolean = new(this, "WriteNodeAsync", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteNodeAsync_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNodeAsync_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNodeAsync_CallSyncReader(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteNodeAsync_CallSyncReader_XmlReader_Boolean;
		public virtual RMethod RWriteNodeAsync_CallSyncReader_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteNodeAsync_CallSyncReader_XmlReader_Boolean == null)
				{
					r_RWriteNodeAsync_CallSyncReader_XmlReader_Boolean = new(this, "WriteNodeAsync_CallSyncReader", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteNodeAsync_CallSyncReader_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNodeAsync_CallSyncReader_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNodeAsync_CallAsyncReader(System.Xml.XmlReader, Boolean)
		/// </summary>
		protected RMethod r_RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean;
		public virtual RMethod RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean
		{
			get
			{
				if(r_RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean == null)
				{
					r_RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean = new(this, "WriteNodeAsync_CallAsyncReader", 0, typeof(System.Xml.XmlReader), typeof(System.Boolean));
					r_RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XPath.XPathNavigator, Boolean)
		/// </summary>
		protected RMethod r_RWriteNodeAsync_XPathNavigator_Boolean;
		public virtual RMethod RWriteNodeAsync_XPathNavigator_Boolean
		{
			get
			{
				if(r_RWriteNodeAsync_XPathNavigator_Boolean == null)
				{
					r_RWriteNodeAsync_XPathNavigator_Boolean = new(this, "WriteNodeAsync", 0, typeof(System.Xml.XPath.XPathNavigator), typeof(System.Boolean));
					r_RWriteNodeAsync_XPathNavigator_Boolean.SetBelong(this.instance);
				}
				return r_RWriteNodeAsync_XPathNavigator_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteElementStringAsync(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RWriteElementStringAsync_String_String_String_String;
		public virtual RMethod RWriteElementStringAsync_String_String_String_String
		{
			get
			{
				if(r_RWriteElementStringAsync_String_String_String_String == null)
				{
					r_RWriteElementStringAsync_String_String_String_String = new(this, "WriteElementStringAsync", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RWriteElementStringAsync_String_String_String_String.SetBelong(this.instance);
				}
				return r_RWriteElementStringAsync_String_String_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLocalNamespacesAsync(System.Xml.XPath.XPathNavigator)
		/// </summary>
		protected RMethod r_RWriteLocalNamespacesAsync_XPathNavigator;
		public virtual RMethod RWriteLocalNamespacesAsync_XPathNavigator
		{
			get
			{
				if(r_RWriteLocalNamespacesAsync_XPathNavigator == null)
				{
					r_RWriteLocalNamespacesAsync_XPathNavigator = new(this, "WriteLocalNamespacesAsync", 0, typeof(System.Xml.XPath.XPathNavigator));
					r_RWriteLocalNamespacesAsync_XPathNavigator.SetBelong(this.instance);
				}
				return r_RWriteLocalNamespacesAsync_XPathNavigator;
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


        public RXmlWriter() : base("System.Xml.XmlWriter")
        {
        }

        public RXmlWriter(System.Object instance) : base("System.Xml.XmlWriter")
		{
            SetInstance(instance);
		}

        public RXmlWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void WriteStartDocument()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteStartDocument.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartDocument(System.Boolean  @standalone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@standalone};
            var ___result = RWriteStartDocument_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEndDocument()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndDocument.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteDocType(System.String  @name, System.String  @pubid, System.String  @sysid, System.String  @subset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @pubid, @sysid, @subset};
            var ___result = RWriteDocType_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartElement(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RWriteStartElement_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartElement(System.String  @prefix, System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns};
            var ___result = RWriteStartElement_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartElement(System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName};
            var ___result = RWriteStartElement_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEndElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteFullEndElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteFullEndElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteAttributeString(System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns, @value};
            var ___result = RWriteAttributeString_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteAttributeString(System.String  @localName, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @value};
            var ___result = RWriteAttributeString_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteAttributeString(System.String  @prefix, System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @value};
            var ___result = RWriteAttributeString_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartAttribute(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RWriteStartAttribute_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartAttribute(System.String  @prefix, System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns};
            var ___result = RWriteStartAttribute_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStartAttribute(System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName};
            var ___result = RWriteStartAttribute_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEndAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteCData(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteCData_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteComment(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteComment_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteProcessingInstruction(System.String  @name, System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @text};
            var ___result = RWriteProcessingInstruction_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEntityRef(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteEntityRef_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteCharEntity(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RWriteCharEntity_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteWhitespace(System.String  @ws)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ws};
            var ___result = RWriteWhitespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteString(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteSurrogateCharEntity(System.Char  @lowChar, System.Char  @highChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowChar, @highChar};
            var ___result = RWriteSurrogateCharEntity_Char_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteChars(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteChars_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRaw(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteRaw_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRaw(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RWriteRaw_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String LookupPrefix(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RLookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void WriteNmToken(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteNmToken_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteQualifiedName(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RWriteQualifiedName_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_DateTimeOffset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteValue(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteValue_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteAttributes(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteAttributes_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteNode(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteNode_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteNode(System.Xml.XPath.XPathNavigator  @navigator, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@navigator, @defattr};
            var ___result = RWriteNode_XPathNavigator_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteElementString(System.String  @localName, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @value};
            var ___result = RWriteElementString_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteElementString(System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns, @value};
            var ___result = RWriteElementString_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteElementString(System.String  @prefix, System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @value};
            var ___result = RWriteElementString_String_String_String_String.Invoke(___genericsType, ___parameters);

            
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


        public virtual void WriteLocalNamespaces(System.Xml.XPath.XPathNavigator  @nsNav)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nsNav};
            var ___result = RWriteLocalNamespaces_XPathNavigator.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.XmlWriter Create(System.String  @outputFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outputFileName};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.String  @outputFileName, System.Xml.XmlWriterSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outputFileName, @settings};
            var ___result = RCreate_String_XmlWriterSettings.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.IO.Stream  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreate_Stream.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.IO.Stream  @output, System.Xml.XmlWriterSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @settings};
            var ___result = RCreate_Stream_XmlWriterSettings.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.IO.TextWriter  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreate_TextWriter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.IO.TextWriter  @output, System.Xml.XmlWriterSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @settings};
            var ___result = RCreate_TextWriter_XmlWriterSettings.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.Text.StringBuilder  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreate_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.Text.StringBuilder  @output, System.Xml.XmlWriterSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @settings};
            var ___result = RCreate_StringBuilder_XmlWriterSettings.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreate_XmlWriter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter  @output, System.Xml.XmlWriterSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @settings};
            var ___result = RCreate_XmlWriter_XmlWriterSettings.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteStartDocumentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync(System.Boolean  @standalone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@standalone};
            var ___result = RWriteStartDocumentAsync_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteEndDocumentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndDocumentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteDocTypeAsync(System.String  @name, System.String  @pubid, System.String  @sysid, System.String  @subset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @pubid, @sysid, @subset};
            var ___result = RWriteDocTypeAsync_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteStartElementAsync(System.String  @prefix, System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns};
            var ___result = RWriteStartElementAsync_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteEndElementAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndElementAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteFullEndElementAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteFullEndElementAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAttributeStringAsync(System.String  @prefix, System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @value};
            var ___result = RWriteAttributeStringAsync_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAttributeStringAsyncHelper(System.Threading.Tasks.Task  @task, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @value};
            var ___result = RWriteAttributeStringAsyncHelper_Task_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteStartAttributeAsync(System.String  @prefix, System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns};
            var ___result = RWriteStartAttributeAsync_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteEndAttributeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteEndAttributeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteCDataAsync(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteCDataAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteCommentAsync(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteCommentAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteProcessingInstructionAsync(System.String  @name, System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @text};
            var ___result = RWriteProcessingInstructionAsync_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteEntityRefAsync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteEntityRefAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteCharEntityAsync(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RWriteCharEntityAsync_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteWhitespaceAsync(System.String  @ws)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ws};
            var ___result = RWriteWhitespaceAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteStringAsync(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteStringAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteSurrogateCharEntityAsync(System.Char  @lowChar, System.Char  @highChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowChar, @highChar};
            var ___result = RWriteSurrogateCharEntityAsync_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteCharsAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteCharsAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteRawAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteRawAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteRawAsync(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RWriteRawAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNmTokenAsync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteNmTokenAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNameAsync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteNameAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteQualifiedNameAsync(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RWriteQualifiedNameAsync_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAttributesAsync(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteAttributesAsync_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteNodeAsync_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNodeAsync_CallSyncReader(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteNodeAsync_CallSyncReader_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNodeAsync_CallAsyncReader(System.Xml.XmlReader  @reader, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @defattr};
            var ___result = RWriteNodeAsync_CallAsyncReader_XmlReader_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XPath.XPathNavigator  @navigator, System.Boolean  @defattr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@navigator, @defattr};
            var ___result = RWriteNodeAsync_XPathNavigator_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteElementStringAsync(System.String  @prefix, System.String  @localName, System.String  @ns, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @value};
            var ___result = RWriteElementStringAsync_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLocalNamespacesAsync(System.Xml.XPath.XPathNavigator  @nsNav)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nsNav};
            var ___result = RWriteLocalNamespacesAsync_XPathNavigator.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
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
