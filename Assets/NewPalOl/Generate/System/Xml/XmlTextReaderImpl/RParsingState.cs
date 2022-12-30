using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlTextReaderImpl+ParsingState
	/// </summary>
    public partial class RParsingState : RMember //
    {

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
		/// System.Int32 charPos
		/// </summary>
		protected RField r_charPos;
		public virtual RField RcharPos
		{
			get
			{
				if(r_charPos == null)
				{
					r_charPos = new(this, "charPos");
					r_charPos.SetBelong(this.instance);
				}
				return r_charPos;
			}
		}

		/// <summary>
		/// System.Int32 charsUsed
		/// </summary>
		protected RField r_charsUsed;
		public virtual RField RcharsUsed
		{
			get
			{
				if(r_charsUsed == null)
				{
					r_charsUsed = new(this, "charsUsed");
					r_charsUsed.SetBelong(this.instance);
				}
				return r_charsUsed;
			}
		}

		/// <summary>
		/// System.Text.Encoding encoding
		/// </summary>
		protected RSystem.RText.REncoding r_encoding;
		public virtual RSystem.RText.REncoding Rencoding
		{
			get
			{
				if(r_encoding == null)
				{
					r_encoding = new(this, "encoding");
					r_encoding.SetBelong(this.instance);
				}
				return r_encoding;
			}
		}

		/// <summary>
		/// System.Boolean appendMode
		/// </summary>
		protected RField r_appendMode;
		public virtual RField RappendMode
		{
			get
			{
				if(r_appendMode == null)
				{
					r_appendMode = new(this, "appendMode");
					r_appendMode.SetBelong(this.instance);
				}
				return r_appendMode;
			}
		}

		/// <summary>
		/// System.IO.Stream stream
		/// </summary>
		protected RSystem.RIO.RStream r_stream;
		public virtual RSystem.RIO.RStream Rstream
		{
			get
			{
				if(r_stream == null)
				{
					r_stream = new(this, "stream");
					r_stream.SetBelong(this.instance);
				}
				return r_stream;
			}
		}

		/// <summary>
		/// System.Text.Decoder decoder
		/// </summary>
		protected RSystem.RText.RDecoder r_decoder;
		public virtual RSystem.RText.RDecoder Rdecoder
		{
			get
			{
				if(r_decoder == null)
				{
					r_decoder = new(this, "decoder");
					r_decoder.SetBelong(this.instance);
				}
				return r_decoder;
			}
		}

		/// <summary>
		/// System.Byte[] bytes
		/// </summary>
		protected RFieldArray<RField> r_bytes;
		public virtual RFieldArray<RField> Rbytes
		{
			get
			{
				if(r_bytes == null)
				{
					r_bytes = new(this, "bytes");
					r_bytes.SetBelong(this.instance);
				}
				return r_bytes;
			}
		}

		/// <summary>
		/// System.Int32 bytePos
		/// </summary>
		protected RField r_bytePos;
		public virtual RField RbytePos
		{
			get
			{
				if(r_bytePos == null)
				{
					r_bytePos = new(this, "bytePos");
					r_bytePos.SetBelong(this.instance);
				}
				return r_bytePos;
			}
		}

		/// <summary>
		/// System.Int32 bytesUsed
		/// </summary>
		protected RField r_bytesUsed;
		public virtual RField RbytesUsed
		{
			get
			{
				if(r_bytesUsed == null)
				{
					r_bytesUsed = new(this, "bytesUsed");
					r_bytesUsed.SetBelong(this.instance);
				}
				return r_bytesUsed;
			}
		}

		/// <summary>
		/// System.IO.TextReader textReader
		/// </summary>
		protected RSystem.RIO.RTextReader r_textReader;
		public virtual RSystem.RIO.RTextReader RtextReader
		{
			get
			{
				if(r_textReader == null)
				{
					r_textReader = new(this, "textReader");
					r_textReader.SetBelong(this.instance);
				}
				return r_textReader;
			}
		}

		/// <summary>
		/// System.Int32 lineNo
		/// </summary>
		protected RField r_lineNo;
		public virtual RField RlineNo
		{
			get
			{
				if(r_lineNo == null)
				{
					r_lineNo = new(this, "lineNo");
					r_lineNo.SetBelong(this.instance);
				}
				return r_lineNo;
			}
		}

		/// <summary>
		/// System.Int32 lineStartPos
		/// </summary>
		protected RField r_lineStartPos;
		public virtual RField RlineStartPos
		{
			get
			{
				if(r_lineStartPos == null)
				{
					r_lineStartPos = new(this, "lineStartPos");
					r_lineStartPos.SetBelong(this.instance);
				}
				return r_lineStartPos;
			}
		}

		/// <summary>
		/// System.String baseUriStr
		/// </summary>
		protected RField r_baseUriStr;
		public virtual RField RbaseUriStr
		{
			get
			{
				if(r_baseUriStr == null)
				{
					r_baseUriStr = new(this, "baseUriStr");
					r_baseUriStr.SetBelong(this.instance);
				}
				return r_baseUriStr;
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
		/// System.Boolean isEof
		/// </summary>
		protected RField r_isEof;
		public virtual RField RisEof
		{
			get
			{
				if(r_isEof == null)
				{
					r_isEof = new(this, "isEof");
					r_isEof.SetBelong(this.instance);
				}
				return r_isEof;
			}
		}

		/// <summary>
		/// System.Boolean isStreamEof
		/// </summary>
		protected RField r_isStreamEof;
		public virtual RField RisStreamEof
		{
			get
			{
				if(r_isStreamEof == null)
				{
					r_isStreamEof = new(this, "isStreamEof");
					r_isStreamEof.SetBelong(this.instance);
				}
				return r_isStreamEof;
			}
		}

		/// <summary>
		/// System.Xml.IDtdEntityInfo entity
		/// </summary>
		protected RSystem.RXml.RIDtdEntityInfo r_entity;
		public virtual RSystem.RXml.RIDtdEntityInfo Rentity
		{
			get
			{
				if(r_entity == null)
				{
					r_entity = new(this, "entity");
					r_entity.SetBelong(this.instance);
				}
				return r_entity;
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
		/// System.Boolean eolNormalized
		/// </summary>
		protected RField r_eolNormalized;
		public virtual RField ReolNormalized
		{
			get
			{
				if(r_eolNormalized == null)
				{
					r_eolNormalized = new(this, "eolNormalized");
					r_eolNormalized.SetBelong(this.instance);
				}
				return r_eolNormalized;
			}
		}

		/// <summary>
		/// System.Boolean entityResolvedManually
		/// </summary>
		protected RField r_entityResolvedManually;
		public virtual RField RentityResolvedManually
		{
			get
			{
				if(r_entityResolvedManually == null)
				{
					r_entityResolvedManually = new(this, "entityResolvedManually");
					r_entityResolvedManually.SetBelong(this.instance);
				}
				return r_entityResolvedManually;
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
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void Close(Boolean)
		/// </summary>
		protected RMethod r_RClose_Boolean;
		public virtual RMethod RClose_Boolean
		{
			get
			{
				if(r_RClose_Boolean == null)
				{
					r_RClose_Boolean = new(this, "Close", 0, typeof(System.Boolean));
					r_RClose_Boolean.SetBelong(this.instance);
				}
				return r_RClose_Boolean;
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


        public RParsingState() : base("System.Xml.XmlTextReaderImpl+ParsingState")
        {
        }

        public RParsingState(System.Object instance) : base("System.Xml.XmlTextReaderImpl+ParsingState")
		{
            SetInstance(instance);
		}

        public RParsingState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParsingState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close(System.Boolean  @closeInput)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@closeInput};
            var ___result = RClose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
}