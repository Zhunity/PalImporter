using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.BinaryReader
	/// </summary>
    public partial class RBinaryReader : RMember //
    {

		/// <summary>
		/// System.Int32 MaxCharBytesSize
		/// </summary>
		protected static RField r_MaxCharBytesSize;
		public static RField RMaxCharBytesSize
		{
			get
			{
				if(r_MaxCharBytesSize == null)
				{
					r_MaxCharBytesSize = new(typeof(System.IO.BinaryReader), "MaxCharBytesSize");
					r_MaxCharBytesSize.SetBelong(null);
				}
				return r_MaxCharBytesSize;
			}
		}

		/// <summary>
		/// System.IO.Stream m_stream
		/// </summary>
		protected RSystem.RIO.RStream r_m_stream;
		public virtual RSystem.RIO.RStream Rm_stream
		{
			get
			{
				if(r_m_stream == null)
				{
					r_m_stream = new(this, "m_stream");
					r_m_stream.SetBelong(this.instance);
				}
				return r_m_stream;
			}
		}

		/// <summary>
		/// System.Byte[] m_buffer
		/// </summary>
		protected RFieldArray<RField> r_m_buffer;
		public virtual RFieldArray<RField> Rm_buffer
		{
			get
			{
				if(r_m_buffer == null)
				{
					r_m_buffer = new(this, "m_buffer");
					r_m_buffer.SetBelong(this.instance);
				}
				return r_m_buffer;
			}
		}

		/// <summary>
		/// System.Text.Decoder m_decoder
		/// </summary>
		protected RSystem.RText.RDecoder r_m_decoder;
		public virtual RSystem.RText.RDecoder Rm_decoder
		{
			get
			{
				if(r_m_decoder == null)
				{
					r_m_decoder = new(this, "m_decoder");
					r_m_decoder.SetBelong(this.instance);
				}
				return r_m_decoder;
			}
		}

		/// <summary>
		/// System.Byte[] m_charBytes
		/// </summary>
		protected RFieldArray<RField> r_m_charBytes;
		public virtual RFieldArray<RField> Rm_charBytes
		{
			get
			{
				if(r_m_charBytes == null)
				{
					r_m_charBytes = new(this, "m_charBytes");
					r_m_charBytes.SetBelong(this.instance);
				}
				return r_m_charBytes;
			}
		}

		/// <summary>
		/// System.Char[] m_singleChar
		/// </summary>
		protected RFieldArray<RField> r_m_singleChar;
		public virtual RFieldArray<RField> Rm_singleChar
		{
			get
			{
				if(r_m_singleChar == null)
				{
					r_m_singleChar = new(this, "m_singleChar");
					r_m_singleChar.SetBelong(this.instance);
				}
				return r_m_singleChar;
			}
		}

		/// <summary>
		/// System.Char[] m_charBuffer
		/// </summary>
		protected RFieldArray<RField> r_m_charBuffer;
		public virtual RFieldArray<RField> Rm_charBuffer
		{
			get
			{
				if(r_m_charBuffer == null)
				{
					r_m_charBuffer = new(this, "m_charBuffer");
					r_m_charBuffer.SetBelong(this.instance);
				}
				return r_m_charBuffer;
			}
		}

		/// <summary>
		/// System.Int32 m_maxCharsSize
		/// </summary>
		protected RField r_m_maxCharsSize;
		public virtual RField Rm_maxCharsSize
		{
			get
			{
				if(r_m_maxCharsSize == null)
				{
					r_m_maxCharsSize = new(this, "m_maxCharsSize");
					r_m_maxCharsSize.SetBelong(this.instance);
				}
				return r_m_maxCharsSize;
			}
		}

		/// <summary>
		/// System.Boolean m_2BytesPerChar
		/// </summary>
		protected RField r_m_2BytesPerChar;
		public virtual RField Rm_2BytesPerChar
		{
			get
			{
				if(r_m_2BytesPerChar == null)
				{
					r_m_2BytesPerChar = new(this, "m_2BytesPerChar");
					r_m_2BytesPerChar.SetBelong(this.instance);
				}
				return r_m_2BytesPerChar;
			}
		}

		/// <summary>
		/// System.Boolean m_isMemoryStream
		/// </summary>
		protected RField r_m_isMemoryStream;
		public virtual RField Rm_isMemoryStream
		{
			get
			{
				if(r_m_isMemoryStream == null)
				{
					r_m_isMemoryStream = new(this, "m_isMemoryStream");
					r_m_isMemoryStream.SetBelong(this.instance);
				}
				return r_m_isMemoryStream;
			}
		}

		/// <summary>
		/// System.Boolean m_leaveOpen
		/// </summary>
		protected RField r_m_leaveOpen;
		public virtual RField Rm_leaveOpen
		{
			get
			{
				if(r_m_leaveOpen == null)
				{
					r_m_leaveOpen = new(this, "m_leaveOpen");
					r_m_leaveOpen.SetBelong(this.instance);
				}
				return r_m_leaveOpen;
			}
		}

		/// <summary>
		/// System.IO.Stream BaseStream
		/// </summary>
		protected RSystem.RIO.RStream r_BaseStream;
		public virtual RSystem.RIO.RStream RBaseStream
		{
			get
			{
				if(r_BaseStream == null)
				{
					r_BaseStream = new(this, "BaseStream", -1);
					r_BaseStream.SetBelong(this.instance);
				}
				return r_BaseStream;
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
		/// Int32 PeekChar()
		/// </summary>
		protected RMethod r_RPeekChar;
		public virtual RMethod RPeekChar
		{
			get
			{
				if(r_RPeekChar == null)
				{
					r_RPeekChar = new(this, "PeekChar", 0);
					r_RPeekChar.SetBelong(this.instance);
				}
				return r_RPeekChar;
			}
		}

		/// <summary>
		/// Int32 Read()
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
		/// Boolean ReadBoolean()
		/// </summary>
		protected RMethod r_RReadBoolean;
		public virtual RMethod RReadBoolean
		{
			get
			{
				if(r_RReadBoolean == null)
				{
					r_RReadBoolean = new(this, "ReadBoolean", 0);
					r_RReadBoolean.SetBelong(this.instance);
				}
				return r_RReadBoolean;
			}
		}

		/// <summary>
		/// Byte ReadByte()
		/// </summary>
		protected RMethod r_RReadByte;
		public virtual RMethod RReadByte
		{
			get
			{
				if(r_RReadByte == null)
				{
					r_RReadByte = new(this, "ReadByte", 0);
					r_RReadByte.SetBelong(this.instance);
				}
				return r_RReadByte;
			}
		}

		/// <summary>
		/// SByte ReadSByte()
		/// </summary>
		protected RMethod r_RReadSByte;
		public virtual RMethod RReadSByte
		{
			get
			{
				if(r_RReadSByte == null)
				{
					r_RReadSByte = new(this, "ReadSByte", 0);
					r_RReadSByte.SetBelong(this.instance);
				}
				return r_RReadSByte;
			}
		}

		/// <summary>
		/// Char ReadChar()
		/// </summary>
		protected RMethod r_RReadChar;
		public virtual RMethod RReadChar
		{
			get
			{
				if(r_RReadChar == null)
				{
					r_RReadChar = new(this, "ReadChar", 0);
					r_RReadChar.SetBelong(this.instance);
				}
				return r_RReadChar;
			}
		}

		/// <summary>
		/// Int16 ReadInt16()
		/// </summary>
		protected RMethod r_RReadInt16;
		public virtual RMethod RReadInt16
		{
			get
			{
				if(r_RReadInt16 == null)
				{
					r_RReadInt16 = new(this, "ReadInt16", 0);
					r_RReadInt16.SetBelong(this.instance);
				}
				return r_RReadInt16;
			}
		}

		/// <summary>
		/// UInt16 ReadUInt16()
		/// </summary>
		protected RMethod r_RReadUInt16;
		public virtual RMethod RReadUInt16
		{
			get
			{
				if(r_RReadUInt16 == null)
				{
					r_RReadUInt16 = new(this, "ReadUInt16", 0);
					r_RReadUInt16.SetBelong(this.instance);
				}
				return r_RReadUInt16;
			}
		}

		/// <summary>
		/// Int32 ReadInt32()
		/// </summary>
		protected RMethod r_RReadInt32;
		public virtual RMethod RReadInt32
		{
			get
			{
				if(r_RReadInt32 == null)
				{
					r_RReadInt32 = new(this, "ReadInt32", 0);
					r_RReadInt32.SetBelong(this.instance);
				}
				return r_RReadInt32;
			}
		}

		/// <summary>
		/// UInt32 ReadUInt32()
		/// </summary>
		protected RMethod r_RReadUInt32;
		public virtual RMethod RReadUInt32
		{
			get
			{
				if(r_RReadUInt32 == null)
				{
					r_RReadUInt32 = new(this, "ReadUInt32", 0);
					r_RReadUInt32.SetBelong(this.instance);
				}
				return r_RReadUInt32;
			}
		}

		/// <summary>
		/// Int64 ReadInt64()
		/// </summary>
		protected RMethod r_RReadInt64;
		public virtual RMethod RReadInt64
		{
			get
			{
				if(r_RReadInt64 == null)
				{
					r_RReadInt64 = new(this, "ReadInt64", 0);
					r_RReadInt64.SetBelong(this.instance);
				}
				return r_RReadInt64;
			}
		}

		/// <summary>
		/// UInt64 ReadUInt64()
		/// </summary>
		protected RMethod r_RReadUInt64;
		public virtual RMethod RReadUInt64
		{
			get
			{
				if(r_RReadUInt64 == null)
				{
					r_RReadUInt64 = new(this, "ReadUInt64", 0);
					r_RReadUInt64.SetBelong(this.instance);
				}
				return r_RReadUInt64;
			}
		}

		/// <summary>
		/// Single ReadSingle()
		/// </summary>
		protected RMethod r_RReadSingle;
		public virtual RMethod RReadSingle
		{
			get
			{
				if(r_RReadSingle == null)
				{
					r_RReadSingle = new(this, "ReadSingle", 0);
					r_RReadSingle.SetBelong(this.instance);
				}
				return r_RReadSingle;
			}
		}

		/// <summary>
		/// Double ReadDouble()
		/// </summary>
		protected RMethod r_RReadDouble;
		public virtual RMethod RReadDouble
		{
			get
			{
				if(r_RReadDouble == null)
				{
					r_RReadDouble = new(this, "ReadDouble", 0);
					r_RReadDouble.SetBelong(this.instance);
				}
				return r_RReadDouble;
			}
		}

		/// <summary>
		/// System.Decimal ReadDecimal()
		/// </summary>
		protected RMethod r_RReadDecimal;
		public virtual RMethod RReadDecimal
		{
			get
			{
				if(r_RReadDecimal == null)
				{
					r_RReadDecimal = new(this, "ReadDecimal", 0);
					r_RReadDecimal.SetBelong(this.instance);
				}
				return r_RReadDecimal;
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
		/// Int32 Read(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRead_CharArray_Int32_Int32;
		public virtual RMethod RRead_CharArray_Int32_Int32
		{
			get
			{
				if(r_RRead_CharArray_Int32_Int32 == null)
				{
					r_RRead_CharArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRead_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRead_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalReadChars(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RInternalReadChars_CharArray_Int32_Int32;
		public virtual RMethod RInternalReadChars_CharArray_Int32_Int32
		{
			get
			{
				if(r_RInternalReadChars_CharArray_Int32_Int32 == null)
				{
					r_RInternalReadChars_CharArray_Int32_Int32 = new(this, "InternalReadChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RInternalReadChars_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternalReadChars_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalReadOneChar()
		/// </summary>
		protected RMethod r_RInternalReadOneChar;
		public virtual RMethod RInternalReadOneChar
		{
			get
			{
				if(r_RInternalReadOneChar == null)
				{
					r_RInternalReadOneChar = new(this, "InternalReadOneChar", 0);
					r_RInternalReadOneChar.SetBelong(this.instance);
				}
				return r_RInternalReadOneChar;
			}
		}

		/// <summary>
		/// Char[] ReadChars(Int32)
		/// </summary>
		protected RMethod r_RReadChars_Int32;
		public virtual RMethod RReadChars_Int32
		{
			get
			{
				if(r_RReadChars_Int32 == null)
				{
					r_RReadChars_Int32 = new(this, "ReadChars", 0, typeof(System.Int32));
					r_RReadChars_Int32.SetBelong(this.instance);
				}
				return r_RReadChars_Int32;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RRead_Span_d_Char_p_;
		public virtual RMethod RRead_Span_d_Char_p_
		{
			get
			{
				if(r_RRead_Span_d_Char_p_ == null)
				{
					r_RRead_Span_d_Char_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RRead_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RRead_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RRead_Span_d_Byte_p_;
		public virtual RMethod RRead_Span_d_Byte_p_
		{
			get
			{
				if(r_RRead_Span_d_Byte_p_ == null)
				{
					r_RRead_Span_d_Byte_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RRead_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RRead_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Int32 Read(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRead_ByteArray_Int32_Int32;
		public virtual RMethod RRead_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RRead_ByteArray_Int32_Int32 == null)
				{
					r_RRead_ByteArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRead_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRead_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] ReadBytes(Int32)
		/// </summary>
		protected RMethod r_RReadBytes_Int32;
		public virtual RMethod RReadBytes_Int32
		{
			get
			{
				if(r_RReadBytes_Int32 == null)
				{
					r_RReadBytes_Int32 = new(this, "ReadBytes", 0, typeof(System.Int32));
					r_RReadBytes_Int32.SetBelong(this.instance);
				}
				return r_RReadBytes_Int32;
			}
		}

		/// <summary>
		/// Void FillBuffer(Int32)
		/// </summary>
		protected RMethod r_RFillBuffer_Int32;
		public virtual RMethod RFillBuffer_Int32
		{
			get
			{
				if(r_RFillBuffer_Int32 == null)
				{
					r_RFillBuffer_Int32 = new(this, "FillBuffer", 0, typeof(System.Int32));
					r_RFillBuffer_Int32.SetBelong(this.instance);
				}
				return r_RFillBuffer_Int32;
			}
		}

		/// <summary>
		/// Int32 Read7BitEncodedInt()
		/// </summary>
		protected RMethod r_RRead7BitEncodedInt;
		public virtual RMethod RRead7BitEncodedInt
		{
			get
			{
				if(r_RRead7BitEncodedInt == null)
				{
					r_RRead7BitEncodedInt = new(this, "Read7BitEncodedInt", 0);
					r_RRead7BitEncodedInt.SetBelong(this.instance);
				}
				return r_RRead7BitEncodedInt;
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


        public RBinaryReader() : base("System.IO.BinaryReader")
        {
        }

        public RBinaryReader(System.Object instance) : base("System.IO.BinaryReader")
		{
            SetInstance(instance);
		}

        public RBinaryReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBinaryReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 PeekChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeekChar.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ReadBoolean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadBoolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte ReadByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadByte.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.SByte ReadSByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadSByte.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Char ReadChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Int16 ReadInt16()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInt16.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 ReadUInt16()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadUInt16.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 ReadInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 ReadUInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadUInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 ReadInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInt64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 ReadUInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadUInt64.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single ReadSingle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadSingle.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double ReadDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal ReadDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadDecimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.String ReadString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 Read(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RRead_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalReadChars(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RInternalReadChars_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalReadOneChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReadOneChar.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] ReadChars(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RReadChars_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }




        public virtual System.Int32 Read(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RRead_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] ReadBytes(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RReadBytes_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void FillBuffer(System.Int32  @numBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numBytes};
            var ___result = RFillBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Read7BitEncodedInt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead7BitEncodedInt.Invoke(___genericsType, ___parameters);

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
