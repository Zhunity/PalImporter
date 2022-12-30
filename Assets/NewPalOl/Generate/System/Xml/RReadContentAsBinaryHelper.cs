using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.ReadContentAsBinaryHelper
	/// </summary>
    public partial class RReadContentAsBinaryHelper : RMember //
    {

		/// <summary>
		/// System.Xml.XmlReader reader
		/// </summary>
		protected RSystem.RXml.RXmlReader r_reader;
		public virtual RSystem.RXml.RXmlReader Rreader
		{
			get
			{
				if(r_reader == null)
				{
					r_reader = new(this, "reader");
					r_reader.SetBelong(this.instance);
				}
				return r_reader;
			}
		}

		/// <summary>
		/// System.Xml.ReadContentAsBinaryHelper+State state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Int32 valueOffset
		/// </summary>
		protected RField r_valueOffset;
		public virtual RField RvalueOffset
		{
			get
			{
				if(r_valueOffset == null)
				{
					r_valueOffset = new(this, "valueOffset");
					r_valueOffset.SetBelong(this.instance);
				}
				return r_valueOffset;
			}
		}

		/// <summary>
		/// System.Boolean isEnd
		/// </summary>
		protected RField r_isEnd;
		public virtual RField RisEnd
		{
			get
			{
				if(r_isEnd == null)
				{
					r_isEnd = new(this, "isEnd");
					r_isEnd.SetBelong(this.instance);
				}
				return r_isEnd;
			}
		}

		/// <summary>
		/// System.Boolean canReadValueChunk
		/// </summary>
		protected RField r_canReadValueChunk;
		public virtual RField RcanReadValueChunk
		{
			get
			{
				if(r_canReadValueChunk == null)
				{
					r_canReadValueChunk = new(this, "canReadValueChunk");
					r_canReadValueChunk.SetBelong(this.instance);
				}
				return r_canReadValueChunk;
			}
		}

		/// <summary>
		/// System.Char[] valueChunk
		/// </summary>
		protected RFieldArray<RField> r_valueChunk;
		public virtual RFieldArray<RField> RvalueChunk
		{
			get
			{
				if(r_valueChunk == null)
				{
					r_valueChunk = new(this, "valueChunk");
					r_valueChunk.SetBelong(this.instance);
				}
				return r_valueChunk;
			}
		}

		/// <summary>
		/// System.Int32 valueChunkLength
		/// </summary>
		protected RField r_valueChunkLength;
		public virtual RField RvalueChunkLength
		{
			get
			{
				if(r_valueChunkLength == null)
				{
					r_valueChunkLength = new(this, "valueChunkLength");
					r_valueChunkLength.SetBelong(this.instance);
				}
				return r_valueChunkLength;
			}
		}

		/// <summary>
		/// System.Xml.IncrementalReadDecoder decoder
		/// </summary>
		protected RSystem.RXml.RIncrementalReadDecoder r_decoder;
		public virtual RSystem.RXml.RIncrementalReadDecoder Rdecoder
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
		/// System.Xml.Base64Decoder base64Decoder
		/// </summary>
		protected RSystem.RXml.RBase64Decoder r_base64Decoder;
		public virtual RSystem.RXml.RBase64Decoder Rbase64Decoder
		{
			get
			{
				if(r_base64Decoder == null)
				{
					r_base64Decoder = new(this, "base64Decoder");
					r_base64Decoder.SetBelong(this.instance);
				}
				return r_base64Decoder;
			}
		}

		/// <summary>
		/// System.Xml.BinHexDecoder binHexDecoder
		/// </summary>
		protected RSystem.RXml.RBinHexDecoder r_binHexDecoder;
		public virtual RSystem.RXml.RBinHexDecoder RbinHexDecoder
		{
			get
			{
				if(r_binHexDecoder == null)
				{
					r_binHexDecoder = new(this, "binHexDecoder");
					r_binHexDecoder.SetBelong(this.instance);
				}
				return r_binHexDecoder;
			}
		}

		/// <summary>
		/// System.Int32 ChunkSize
		/// </summary>
		protected static RField r_ChunkSize;
		public static RField RChunkSize
		{
			get
			{
				if(r_ChunkSize == null)
				{
					r_ChunkSize = new( ReleactionUtils.GetType("System.Xml.ReadContentAsBinaryHelper"), "ChunkSize");
					r_ChunkSize.SetBelong(null);
				}
				return r_ChunkSize;
			}
		}

		/// <summary>
		/// System.Xml.ReadContentAsBinaryHelper CreateOrReset(System.Xml.ReadContentAsBinaryHelper, System.Xml.XmlReader)
		/// </summary>
		protected static RMethod r_RCreateOrReset_ReadContentAsBinaryHelper_XmlReader;
		public static RMethod RCreateOrReset_ReadContentAsBinaryHelper_XmlReader
		{
			get
			{
				if(r_RCreateOrReset_ReadContentAsBinaryHelper_XmlReader == null)
				{
					r_RCreateOrReset_ReadContentAsBinaryHelper_XmlReader = new( ReleactionUtils.GetType("System.Xml.ReadContentAsBinaryHelper"), "CreateOrReset", 0,  ReleactionUtils.GetType("System.Xml.ReadContentAsBinaryHelper"), typeof(System.Xml.XmlReader));
					r_RCreateOrReset_ReadContentAsBinaryHelper_XmlReader.SetBelong(null);
				}
				return r_RCreateOrReset_ReadContentAsBinaryHelper_XmlReader;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Boolean Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Boolean InitOnElement()
		/// </summary>
		protected RMethod r_RInitOnElement;
		public virtual RMethod RInitOnElement
		{
			get
			{
				if(r_RInitOnElement == null)
				{
					r_RInitOnElement = new(this, "InitOnElement", 0);
					r_RInitOnElement.SetBelong(this.instance);
				}
				return r_RInitOnElement;
			}
		}

		/// <summary>
		/// Void InitBase64Decoder()
		/// </summary>
		protected RMethod r_RInitBase64Decoder;
		public virtual RMethod RInitBase64Decoder
		{
			get
			{
				if(r_RInitBase64Decoder == null)
				{
					r_RInitBase64Decoder = new(this, "InitBase64Decoder", 0);
					r_RInitBase64Decoder.SetBelong(this.instance);
				}
				return r_RInitBase64Decoder;
			}
		}

		/// <summary>
		/// Void InitBinHexDecoder()
		/// </summary>
		protected RMethod r_RInitBinHexDecoder;
		public virtual RMethod RInitBinHexDecoder
		{
			get
			{
				if(r_RInitBinHexDecoder == null)
				{
					r_RInitBinHexDecoder = new(this, "InitBinHexDecoder", 0);
					r_RInitBinHexDecoder.SetBelong(this.instance);
				}
				return r_RInitBinHexDecoder;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBinary(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinary_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinary_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinary_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinary_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinary", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinary_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinary_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBinary(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinary_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinary_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinary_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinary_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinary", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinary_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinary_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveToNextContentNode(Boolean)
		/// </summary>
		protected RMethod r_RMoveToNextContentNode_Boolean;
		public virtual RMethod RMoveToNextContentNode_Boolean
		{
			get
			{
				if(r_RMoveToNextContentNode_Boolean == null)
				{
					r_RMoveToNextContentNode_Boolean = new(this, "MoveToNextContentNode", 0, typeof(System.Boolean));
					r_RMoveToNextContentNode_Boolean.SetBelong(this.instance);
				}
				return r_RMoveToNextContentNode_Boolean;
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
		/// System.Threading.Tasks.Task FinishAsync()
		/// </summary>
		protected RMethod r_RFinishAsync;
		public virtual RMethod RFinishAsync
		{
			get
			{
				if(r_RFinishAsync == null)
				{
					r_RFinishAsync = new(this, "FinishAsync", 0);
					r_RFinishAsync.SetBelong(this.instance);
				}
				return r_RFinishAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] InitAsync()
		/// </summary>
		protected RMethod r_RInitAsync;
		public virtual RMethod RInitAsync
		{
			get
			{
				if(r_RInitAsync == null)
				{
					r_RInitAsync = new(this, "InitAsync", 0);
					r_RInitAsync.SetBelong(this.instance);
				}
				return r_RInitAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] InitOnElementAsync()
		/// </summary>
		protected RMethod r_RInitOnElementAsync;
		public virtual RMethod RInitOnElementAsync
		{
			get
			{
				if(r_RInitOnElementAsync == null)
				{
					r_RInitOnElementAsync = new(this, "InitOnElementAsync", 0);
					r_RInitOnElementAsync.SetBelong(this.instance);
				}
				return r_RInitOnElementAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBinaryAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinaryAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinaryAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBinaryAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinaryAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] MoveToNextContentNodeAsync(Boolean)
		/// </summary>
		protected RMethod r_RMoveToNextContentNodeAsync_Boolean;
		public virtual RMethod RMoveToNextContentNodeAsync_Boolean
		{
			get
			{
				if(r_RMoveToNextContentNodeAsync_Boolean == null)
				{
					r_RMoveToNextContentNodeAsync_Boolean = new(this, "MoveToNextContentNodeAsync", 0, typeof(System.Boolean));
					r_RMoveToNextContentNodeAsync_Boolean.SetBelong(this.instance);
				}
				return r_RMoveToNextContentNodeAsync_Boolean;
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


        public RReadContentAsBinaryHelper() : base("System.Xml.ReadContentAsBinaryHelper")
        {
        }

        public RReadContentAsBinaryHelper(System.Object instance) : base("System.Xml.ReadContentAsBinaryHelper")
		{
            SetInstance(instance);
		}

        public RReadContentAsBinaryHelper(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadContentAsBinaryHelper(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Int32 ReadContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Finish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinish.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InitOnElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitOnElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InitBase64Decoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBase64Decoder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitBinHexDecoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBinHexDecoder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadContentAsBinary(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinary_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBinary(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinary_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean MoveToNextContentNode(System.Boolean  @moveIfOnContentNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moveIfOnContentNode};
            var ___result = RMoveToNextContentNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task FinishAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> InitAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> InitOnElementAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitOnElementAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBinaryAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinaryAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBinaryAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> MoveToNextContentNodeAsync(System.Boolean  @moveIfOnContentNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moveIfOnContentNode};
            var ___result = RMoveToNextContentNodeAsync_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
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
